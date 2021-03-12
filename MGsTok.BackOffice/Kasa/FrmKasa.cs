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
using MGsTok.Entities.DataAccess;
using MGsTok.Entities.Contex;

namespace MGsTok.BackOffice.Kasa
{
    public partial class FrmKasa : DevExpress.XtraEditors.XtraForm
    {
        public FrmKasa()
        {
            InitializeComponent();
        }
        MGsTOKContex context = new MGsTOKContex();//gerekli
        KasaDal kasadal = new KasaDal();
        public void Guncelle()
        {
            gridControl1.DataSource = kasadal.KasaListele(context);
        }

        private void btnKasaAra_Click(object sender, EventArgs e)
        {

            //splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;//2 panel aynı anda görülsün
            //split container eklemedim gerekirse ilerde eklneir yada buton kaldırılabilir.
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            filterControl1.ApplyFilter();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            filterControl1.FilterString = null; //önce filitreyi içini null yap
            filterControl1.ApplyFilter();//sonra uygula
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKasaGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void FrmKasa_Load(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnKasaEkle_Click(object sender, EventArgs e)
        {
            FrmKasaIslem kasaIslem = new FrmKasaIslem(new Entities.Tables.Kasa());
            kasaIslem.ShowDialog();

        }

        private void btnKasaDuzenle_Click(object sender, EventArgs e)
        {
            string secilen = layoutView1. GetFocusedRowCellValue(colKasaKodu).ToString();
            FrmKasaIslem f = new FrmKasaIslem(kasadal.GetByFilter(context, c => c.KasaKodu == secilen));
            f.Show();
        }

        private void btnKasaSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan kaydı silmek istediğinize emin misiniz?", "UYARI", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string secilen = layoutView1.GetFocusedRowCellValue(colKasaKodu).ToString();
                kasadal.Delete(context, c => c.KasaKodu == secilen);
                kasadal.save(context);
                Guncelle();
            }
        }

        private void btnKasaHareket_Click(object sender, EventArgs e)
        {
            FrmKasaHareket hareket = new FrmKasaHareket();
            hareket.Show();
        }
    }
}