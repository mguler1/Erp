using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MGsTok.Entities.Contex;
using MGsTok.Entities.DataAccess;
using System.Data.Entity;
using MGsTok.Entities.Tables;
using MGsTok.BackOffice.Stok;
using MGsTok.BackOffice.Cari;
using MGsTok.BackOffice.Depo;
using MGsTok.BackOffice.Kasa;
using MGsTok.Entities.Tables.Other_Tables;

namespace MGsTok.BackOffice.Fişler
{
    public partial class FrmFisIslem : DevExpress.XtraEditors.XtraForm
    {
        MGsTOKContex context = new MGsTOKContex();
        FisDal fisdal = new FisDal();
        FisAyarlari ayarlar = new FisAyarlari();
        KasaHareketDal kasahareketdal = new KasaHareketDal();
        CariDal caridal = new CariDal();
        StokHareketDal stokHareketDal = new StokHareketDal();
        Fis _fisentity = new Fis();
        CariBakiye entityBakiye = new CariBakiye();

        public FrmFisIslem(string fiskodu=null,string fisTuru=null)//dolu fişkodu önceki kayıtları getir.
        {
            InitializeComponent();
            if (fiskodu!=null)
            {
                _fisentity = context.Fisler.Where(c => c.FisKodu == fiskodu).SingleOrDefault();
                context.StokHareketleri.Where(c => c.Fiskodu == fiskodu).Load();//belirtilen tabloyu listeler ve bind et
                context.KasaHareketleri.Where(c => c.FisKodu == fiskodu).Load();//belirtilen tabloyu listeler ve bind et
                toggleSwitch1.IsOn = context.KasaHareketleri.Count(c => c.FisKodu == fiskodu && c.Hareket == "Kasa Giriş") == 0;//hata verirse comment yap sonradan ekledim

                if (_fisentity.CariKodu != null)
                {
                    entityBakiye = this.caridal.CariBakiyesi(context, _fisentity.CariKodu);
                    lblAlacak.Text = entityBakiye.Alacak.ToString("C2");
                    lblBorc.Text = entityBakiye.Borc.ToString("C2");
                    lblBakiye.Text = entityBakiye.Bakiye.ToString("C2");
                }
                
            }
            else
            {
                _fisentity.FisTuru = fisTuru;
                _fisentity.Tarih=DateTime.Now;
            }

            
            txtFisturu.DataBindings.Add("Text", _fisentity, "FisTuru",false,DataSourceUpdateMode.OnPropertyChanged);//veriler ekrandan kaybolmasın diye
            txtFisKodu.DataBindings.Add("Text", _fisentity, "FisKodu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtTarih.DataBindings.Add("EditValue", _fisentity, "Tarih", false, DataSourceUpdateMode.OnPropertyChanged);
            txtVergiNo.DataBindings.Add("EditValue", _fisentity, "VergiNo", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAciklama.DataBindings.Add("EditValue", _fisentity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
            txtFaturaUnvani.DataBindings.Add("EditValue", _fisentity, "FaturaUnvani", false, DataSourceUpdateMode.OnPropertyChanged);
            txtTelefon.DataBindings.Add("EditValue", _fisentity, "CepTelefonu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtIl.DataBindings.Add("EditValue", _fisentity, "Il", false, DataSourceUpdateMode.OnPropertyChanged);
            txtIlce.DataBindings.Add("EditValue", _fisentity, "Ilce", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSemt.DataBindings.Add("EditValue", _fisentity, "Semt", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAdres.DataBindings.Add("EditValue", _fisentity, "Adres", false, DataSourceUpdateMode.OnPropertyChanged);
            txtBelgeNo.DataBindings.Add("Text", _fisentity, "BelgeNo", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAciklama.DataBindings.Add("Text", _fisentity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
            lblCariKodu.DataBindings.Add("Text", _fisentity, "CariKodu",false,DataSourceUpdateMode.OnPropertyChanged);
            lblCariAdi.DataBindings.Add("Text", _fisentity, "CariAdi", false, DataSourceUpdateMode.OnPropertyChanged);

            gridControl1.DataSource = context.StokHareketleri.Local.ToBindingList();//veri kaynağını bağladık
            gridControl2.DataSource = context.KasaHareketleri.Local.ToBindingList();//veri kaynağını bağladık
            toplamalar();
            OdenenTutarGuncelle();

            foreach (var item in context.OdemeTurleri.ToList())
            {
                var buton = new SimpleButton
                {
                    Name = item.OdemeTuruKodu,
                    Text = item.OdemeTuruAdi,
                    Height = 30,
                    Width = 125,
                };
                buton.Click += OdemeEkle_Click;
                flowLayoutPanel2.Controls.Add(buton);
            }
            foreach (var item in context.Personeller.ToList())
            {
                var buton = new CheckButton
                {
                    Name = item.PersonelKodu,
                    Text = item.PersonelAdi,
                    Height = 30,
                    Width = 125,
                    GroupIndex=1
                };
                buton.Click += PersonelYukle_Click;
                flowLayoutPanelPesonel.Controls.Add(buton);
            }
        }
        private void PersonelYukle_Click(object sender, EventArgs e)
        {
            var button = sender as CheckButton;
            _fisentity.PlasiyerKodu = button.Name;
            _fisentity.PlasiyerAdi = button.Text;
        }
        private void FisAyarlar()
        {
           
            switch (_fisentity.FisTuru)
            {
                case "Alış Faturası":
                    ayarlar.StokHareketi = "Stok Giriş";
                    ayarlar.KasaHareketi = "Kasa Çıkış";
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = true;
                    break;
                case "Perakende Satış Faturası":
                    ayarlar.StokHareketi = "Stok Çıkış";
                    ayarlar.KasaHareketi = "Kasa Giriş";
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = true;

                    break;
                case "Toptan Satış Faturası":
                    ayarlar.StokHareketi = "Stok Çıkış";
                    ayarlar.KasaHareketi = "Kasa Giriş";
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = true;

                    break;
                case "Alış İade  Faturası":
                    ayarlar.StokHareketi = "Stok Çıkış";
                    ayarlar.KasaHareketi = "Kasa Giriş";
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = true;

                    break;
                case "Satış İade  Faturası":
                    ayarlar.StokHareketi = "Stok Giriş";
                    ayarlar.KasaHareketi = "Kasa Çıkış";
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = true;

                    break;
                case "Sayım Fazlası Fişi":
                    ayarlar.StokHareketi = "Stok Giriş";
                    ayarlar.OdemeEkrani = false;
                    tabNavigationPage5.Dispose();
                    tabNavigationPage2.Dispose();
                    ayarlar.SatisEkrani = true;


                    break;
                case "Sayım Eksiği Fişi":
                    ayarlar.StokHareketi = "Stok Çıkış ";
                    ayarlar.OdemeEkrani = false;
                    tabNavigationPage5.Dispose();
                    tabNavigationPage2.Dispose();
                    ayarlar.SatisEkrani = true;

                    break;
                case "Stok Devir Fişi":
                    ayarlar.StokHareketi = "Stok Giriş";
                    ayarlar.OdemeEkrani = false;
                    tabNavigationPage5.Dispose();
                    tabNavigationPage2.Dispose();
                    ayarlar.SatisEkrani = true;

                    break;
                case "Tahsilat Fişi":
                    ayarlar.KasaHareketi = "Kasa Giriş";
                    ayarlar.OdemeEkrani = true;
                    tabNavigationPage5.Dispose();
                    ayarlar.SatisEkrani = false;
                    
                    break;
                case "Ödeme Fişi":
                    ayarlar.KasaHareketi = "Kasa Çıkış";
                    ayarlar.OdemeEkrani = true;
                    tabNavigationPage5.Dispose();
                    ayarlar.SatisEkrani = false;
                    break;
                case " Cari Devir Fişi":
                    ayarlar.KasaHareketi = "Kasa Çıkış";//sonra bakılacak 
                    ayarlar.OdemeEkrani = true;
                    tabNavigationPage5.Dispose();
                    ayarlar.SatisEkrani = false;
                    panelCariDevir.Visible = true;
                    break;
            }
        }
                
        private void OdemeEkle_Click(object sender, EventArgs e)
        {
            var buton = (sender as SimpleButton);//sender aslında bir simple butondur
            if (ayarlar.SatisEkrani==false)
            {
                FrmTutarGirisEkrani form = new FrmTutarGirisEkrani(buton.Text, buton.Name);
                form.ShowDialog();
                if (form.entity!=null)
                {
                    kasahareketdal.AddOrUpdate(context, form.entity);
                    OdenenTutarGuncelle();
                }
              
            }
            else
            {
                KasaHareket entityKasahareket = new KasaHareket
                {
                    OdemeTuruKodu = buton.Name,
                    OdemeTuruAdi = buton.Text,
                    Tutar = txtOdenmesiGrekenTutar.Value
                };
                if (txtOdenmesiGrekenTutar.Value <= 0)
                {
                    MessageBox.Show("Ödenmesi Gereken Tutar Zaten Ödenmiş Durumdadır ");
                }
                else
                {
                    kasahareketdal.AddOrUpdate(context, entityKasahareket);
                    gridView2.UpdateSummary();
                }
            }
           
           
            txtOdenenTutar.Value =Convert.ToDecimal( colTutar.SummaryItem.SummaryValue);
            OdenenTutarGuncelle();
        }

        private void OdenenTutarGuncelle()
        {
            gridView2.UpdateSummary();
            if (ayarlar.SatisEkrani)
            {
                txtOdenenTutar.Value = Convert.ToDecimal(colTutar.SummaryItem.SummaryValue);
                txtOdenmesiGrekenTutar.Value = txtToplam.Value - txtOdenenTutar.Value;
            }
            else
            {
                txtToplam.Value= Convert.ToDecimal(colTutar.SummaryItem.SummaryValue);
            }

        }
        private void FrmFisIslem_Load(object sender, EventArgs e)
        {

        }
        private StokHareket StokSec(Entities.Tables.Stok entity)
        {
            StokHareket stokhareket = new StokHareket();
            stokhareket.StokKodu = entity.StokKodu;//stok hareketi al stoğa gönder
            stokhareket.StokAdi = entity.StokAdi;
            stokhareket.Barkod = entity.Barkod;
            stokhareket.BarkodTuru = entity.BarkodTuru;
            stokhareket.BirimFiyati = txtFisturu.Text == "Alıs Faturası" ? entity.AlisFiyati1 : entity.SatisFiyati1;
            stokhareket.Birimi = entity.StokBirimi;
            stokhareket.Kdv = entity.SatisKdv;
            stokhareket.Miktari = txtMiktar.Value;
            stokhareket.IndirimOrani = 0;
            return stokhareket;
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            FrmStokSec form = new FrmStokSec();
            form.ShowDialog();
            if (form.secildi)
            {
                stokHareketDal.AddOrUpdate(context, StokSec(form.secilen.First()));
                toplamalar();
            }
            
        }

        private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                Entities.Tables.Stok entity;
                toplamalar();
                entity = context.Stoklar.Where(c => c.Barkod == txtBarkod.Text).SingleOrDefault();
                if (entity!=null)
                {
                    stokHareketDal.AddOrUpdate(context, StokSec(entity));
                }
                else
                {
                    MessageBox.Show("Aradığınız Barkod numarası ürünler arasında bulunamadı");
                }
                txtBarkod.Text = null;
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            FrmCariSec form = new FrmCariSec();
            form.ShowDialog();
            if (form.secildi)
            {
                Entities.Tables.Cari entity = form.secilen.FirstOrDefault();
                entityBakiye = this.caridal.CariBakiyesi(context, entity.CariKodu);

                lblCariKodu.Text =entity.CariKodu;
                lblCariAdi.Text= entity.CariAdi;
                txtFaturaUnvani.Text= entity.FaturaUnvani;
                txtVergiDairesi.Text= entity.VergiDairesi;
                txtVergiNo.Text= entity.VergiNo;
                txtTelefon.Text= entity.Telefon;
                txtIl.Text= entity.Il;
                txtIlce.Text = entity.Ilce;
                txtSemt.Text = entity.Semt;
                txtAdres.Text = entity.Adres;
                lblAlacak.Text =entityBakiye.Alacak.ToString("C2");
                lblBorc.Text = entityBakiye.Borc.ToString("C2");
                lblBakiye.Text = entityBakiye.Bakiye.ToString("C2");

            }
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            lblCariKodu.Text = null;
            lblCariAdi.Text = null;
            txtFaturaUnvani.Text = "";
            txtVergiDairesi.Text = null;
            txtVergiNo.Text = "";
            txtTelefon.Text = "";
            txtIl.Text = "";
            txtIlce.Text = "";
            txtSemt.Text = "";
            txtAdres.Text = "";
            lblAlacak.Text = "";
            lblBorc.Text = "";
            lblBakiye.Text = "";
        }

        private void tabPane1_Click(object sender, EventArgs e)
        {

        }
          
        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
                toplamalar();

           

        }
        private void toplamalar()
        {
            gridView1.UpdateSummary();
            txtIskontoTutarı.Value = Convert.ToDecimal(colToplamTutar.SummaryItem.SummaryValue) / 100 * txtIskontoOranı.Value;
            txtToplam.Value = Convert.ToDecimal(colToplamTutar.SummaryItem.SummaryValue)-txtIskontoTutarı.Value;
            txtKdvToplam.Value = Convert.ToDecimal(colKdvToplam.SummaryItem.SummaryValue);
            txtIndirimToplam.Value = Convert.ToDecimal(colIndırımTutar.SummaryItem.SummaryValue);
            txtOdenmesiGrekenTutar.Value = txtToplam.Value - txtOdenenTutar.Value;

        }

        private void txtToplam_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtIskontoOranı_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txtIskontoOranı_Validated(object sender, EventArgs e)
        {
            toplamalar();
        }

        private void repoDepoSecim_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 0)
            {

                FrmDepoSecim form = new FrmDepoSecim(gridView1.GetFocusedRowCellValue(colStokKodu).ToString());
                form.ShowDialog();
                if (form.secildi)
                {
                    gridView1.SetFocusedRowCellValue(colDepoKodu, form.entity.DepoKodu);
                    gridView1.SetFocusedRowCellValue(colDepoAdi, form.entity.DepoAdi);
                }
            }
           
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void repoBirimFiyat_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string FiyatSecilen = gridView1.GetFocusedRowCellValue(colStokKodu).ToString();
            Entities.Tables.Stok fiyatEntity = context.Stoklar.Where(c => c.StokKodu == FiyatSecilen).SingleOrDefault();
            barFiyat1.Tag =txtFisturu.Text== "Alıs Faturası" ? fiyatEntity.AlisFiyati1 ?? 0: fiyatEntity.SatisFiyati1 ?? 0;
            barFiyat2.Tag = txtFisturu.Text == "Alıs Faturası" ? fiyatEntity.AlisFiyati2 ?? 0 : fiyatEntity.SatisFiyati2 ?? 0;
            barFiyat3.Tag = txtFisturu.Text == "Alıs Faturası" ? fiyatEntity.AlisFiyati3 ?? 0 : fiyatEntity.SatisFiyati3 ?? 0;
            barFiyat1.Caption = string.Format("{0:C2}", barFiyat1.Tag);
            barFiyat2.Caption = string.Format("{0:C2}", barFiyat2.Tag);
            barFiyat3.Caption = string.Format("{0:C2}", barFiyat3.Tag);
            radialFiyat.ShowPopup(MousePosition);//mausun pozisyonuna göre aç
        }

        private void FiyatSec(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.SetFocusedRowCellValue(colBirimFiyati,Convert.ToDecimal (e.Item.Tag));
        }

        private void repoSeriNo_Click(object sender, EventArgs e)
        {

        }

        private void repoSeriNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string veri=Convert.ToString(gridView1.GetFocusedRowCellValue(colSeriNo));
            FrmSeriNoBilgileri form = new FrmSeriNoBilgileri(veri);
            form.ShowDialog();
            gridView1.SetFocusedRowCellValue(colSeriNo, form.veriSeriNo);
        }

        private void repoSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinizden emin misiniz?","Uyarı",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                gridView1.DeleteSelectedRows();
                OdenenTutarGuncelle();
                toplamalar();
            }
        }

        private void repoKasaKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FrmKasaSec form = new FrmKasaSec();
            form.ShowDialog();
            if (form.secildi)
            {
                gridView2.SetFocusedRowCellValue(colKasaKodu, form.entity.KasaKodu);
                gridView2.SetFocusedRowCellValue(colKasaAdi, form.entity.KasaAdi);
            }
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        private void repoSil2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridView2.DeleteSelectedRows();
                OdenenTutarGuncelle();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (toggleSwitch1.IsOn)
            {
                ayarlar.KasaHareketi = "Kasa Giriş";
            }
            else
            {
                ayarlar.KasaHareketi = "Kasa Giriş";
            }
           
            int stokHata = context.StokHareketleri.Local.Where(c => c.DepoKodu == null).Count();
            int kasaHata = context.KasaHareketleri.Local.Where(c => c.KasaKodu == null).Count();
            string mesaj = null;
            int hata = 0;

            if (gridView1.RowCount==0 && ayarlar.SatisEkrani==true)
            {
                mesaj += "Kasa Ekranındaki Ürünlerin Kasa Seçimlerinde Eksiklik Var"+System.Environment.NewLine;
                hata++;
            }
            if (_fisentity.CariKodu==null &&ayarlar.SatisEkrani==false)
            {
                mesaj += txtFisturu.Text +"Türünde Cari Seçimi Zorunludur." + System.Environment.NewLine;
                hata++;
            }
            if (gridView2.RowCount==0 && ayarlar.SatisEkrani==false)
            {
                mesaj += "Herhangi bir Ödeme Bulunamadı." + System.Environment.NewLine;
                hata++;
            }
            if (txtFisKodu.Text=="")
            {
                mesaj += "Satış Ekranına Eklenmiş Bir Ürün Bulunamamıştr." + System.Environment.NewLine;
                hata++;
            }
            if (txtOdenmesiGrekenTutar.Value !=0 && ayarlar.OdemeEkrani==true)
            {
               mesaj+="Ödenmesi Gereken Tutar Ödenmemiş Görünüyor"+System.Environment.NewLine;
                hata++;
            }
            if (stokHata!=0)
            {
                mesaj += "Satış Ekranındaki Ürünlerin Depo Seçimlerinde Eksiklik Var" + System.Environment.NewLine;
                hata++;
            }
            if (kasaHata != 0)
            {
                mesaj += "Kasa Ekranındaki Ödemelerin Kasa Seçimlerinde Eksiklik Var" ;
                hata++;
            }

            if (hata!=0)
            {
                MessageBox.Show(mesaj);
                return;
            }
           
            
                foreach (var stokVeri in context.StokHareketleri.ToList())
                {
                    stokVeri.Tarih = stokVeri.Tarih == null ? Convert.ToDateTime(txtTarih.DateTime) : Convert.ToDateTime(stokVeri.Tarih);
                    stokVeri.Fiskodu = txtFisKodu.Text;
                    stokVeri.Hareket = ayarlar.StokHareketi;
                }
                if (ayarlar.OdemeEkrani)
                {
                    foreach (var KasaVeri in context.KasaHareketleri.ToList())
                    {
                        KasaVeri.Tarih = KasaVeri.Tarih == null ? Convert.ToDateTime(txtTarih.DateTime) : Convert.ToDateTime(KasaVeri.Tarih);
                        KasaVeri.FisKodu = txtFisKodu.Text;
                        KasaVeri.Hareket = _fisentity.FisTuru = ayarlar.KasaHareketi;
                        KasaVeri.CariAdi = lblCariKodu.Text;
                        KasaVeri.CariAdi = lblCariAdi.Text;
                    }
                }
               
                _fisentity.ToplamTutar = txtToplam.Value;
                _fisentity.IskontoOrani = txtIskontoOranı.Value;
                _fisentity.IskontoTutari = txtIskontoTutarı.Value;

                fisdal.AddOrUpdate(context, _fisentity);
                context.SaveChanges();
                this.Close();

           
        }

        private void tabNavigationPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl29_Click(object sender, EventArgs e)
        {

        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
           



        }
    }
}