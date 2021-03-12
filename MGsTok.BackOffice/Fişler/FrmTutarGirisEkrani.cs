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
using MGsTok.BackOffice.Kasa;
using MGsTok.Entities.Tables;

namespace MGsTok.BackOffice.Fişler
{
    public partial class FrmTutarGirisEkrani : DevExpress.XtraEditors.XtraForm
    {
        public KasaHareket entity;
        private string _odemeTuruKodu = null;
        public FrmTutarGirisEkrani(string odemeTuru,string OdemeTuruKodu)
        
        {
            InitializeComponent();
            txtOdemeTuru.Text = odemeTuru;
            _odemeTuruKodu = OdemeTuruKodu;
        }

        private void txtKdvToplam_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmTutarGirisEkrani_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmKasaSec kasa = new FrmKasaSec();
            kasa.ShowDialog();
            if (kasa.secildi==true)
            {
                txtKasaKodu.Text = kasa.entity.KasaKodu;
                txtKasaAdi.Text = kasa.entity.KasaAdi;
            }
           
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string mesaj = null;
            int hata = 0;
            if (txtKasaAdi.Text=="")
            {
                mesaj += "Kasa Bilgileri boş Bırakılamaz" + System.Environment.NewLine;
                hata++;
            }
            if (calcTutar.Value <= 0)
            {
                mesaj += "Tutar 0 Değerinden küçük olamaz" + System.Environment.NewLine;
                hata++;
            }
            if (hata!=0)
            {
                MessageBox.Show(mesaj);
                return;
            }
            entity = new KasaHareket();
            entity.OdemeTuruKodu = _odemeTuruKodu;
            entity.OdemeTuruAdi = txtOdemeTuru.Text;
            entity.KasaKodu = txtKasaKodu.Text;
            entity.KasaAdi = txtKasaAdi.Text;
            entity.Tutar = calcTutar.Value;
            entity.Aciklama = txtAciklama.Text;
        }
    }
}