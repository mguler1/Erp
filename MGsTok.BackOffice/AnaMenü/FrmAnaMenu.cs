using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MGsTok.BackOffice.AnaMenü;
using MGsTok.BackOffice.Cari;
using MGsTok.BackOffice.Depo;
using MGsTok.BackOffice.Fişler;
using MGsTok.BackOffice.Fiyat_Değiştir;
using MGsTok.BackOffice.İndirimler;
using MGsTok.BackOffice.Kasa;
using MGsTok.BackOffice.KasaHareketleri;
using MGsTok.BackOffice.Ödeme_Türü;
using MGsTok.BackOffice.Personel;
using MGsTok.BackOffice.Raporlar;
using MGsTok.BackOffice.Stok;
using MGsTok.BackOffice.Stok_Hareketleri;
using MGsTok.BackOffice.Tanımlar;
using MGsTok.Entities.Contex;
using MGsTok.Entities.DataAccess;
using MGsTok.Entities.Tables;
using DevExpress.DataAccess.ObjectBinding;
using MGsTokReports.Stok;
using MGsTok.BackOffice.Ajanda;
using MGsTok.BackOffice.Döviz_Kurları;
//using Stok.backup;
using System.Diagnostics;

namespace MGsTok.BackOffice
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
            using (var contex=new MGsTOKContex())
            {
                contex.Database.CreateIfNotExists();//veritabanı varsa oluşturma yoksa oluştur.
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FrmAnaMenuBilgi form = new FrmAnaMenuBilgi();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmStok stok = new FrmStok();
            stok.MdiParent = this;
            stok.Show();
         
        }

        private void A_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmCari cari = new FrmCari();
            cari.MdiParent = this;
            cari.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKasa kasa = new FrmKasa();
            kasa.MdiParent = this;
            kasa.Show();

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDepo depo = new FrmDepo();
            depo.MdiParent = this;
            depo.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmOdemeTuru odeme = new FrmOdemeTuru();
            odeme.MdiParent = this;
            odeme.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmTanimlar tanim = new FrmTanimlar();
            tanim.Show();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFisler fis = new FrmFisler();
            fis.MdiParent = this;
            fis.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmStokHareketleri hareket = new FrmStokHareketleri();
            hareket.MdiParent = this;
            hareket.Show();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKasaHareketleri hareket2 = new FrmKasaHareketleri();
            hareket2.MdiParent = this;
            hareket2.Show();
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmPersonel perso = new FrmPersonel();
            perso.MdiParent = this;
            perso.Show();
        }

        private void fisIslem_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFisIslem form = new FrmFisIslem(null,e.Item.Caption);
            form.ShowDialog();
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmTopluFiyat t = new FrmTopluFiyat();
            t.MdiParent = this;
            t.Show();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmIndirimler ind = new FrmIndirimler();
            ind.MdiParent = this;
            ind.Show();

        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rptStokDurumu report = new rptStokDurumu();
            FrmRaporGoruntule g = new FrmRaporGoruntule(report);
            g.ShowDialog();
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmAjanda ajanda = new FrmAjanda();
            ajanda.MdiParent = this;
            ajanda.Show();
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmSms sms = new FrmSms();
            
            sms.ShowDialog();
        }

        private void barButtonItem31_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDovizKurlari kur = new FrmDovizKurlari();
            kur.MdiParent = this;
            kur.Show();
        }

        private void barButtonItem33_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          //  Backup backup = new Backup();
         //   backup.ShowDialog();
        }

        private void barButtonItem34_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Process.Start($"{Application.StartupPath}\\Update.exe");

        }
    }
}
