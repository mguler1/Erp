using DevExpress.XtraEditors;
using MGsTok.Entities.Contex;
using MGsTok.Entities.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MGsTok.BackOffice.Cari
{
    public partial class FrmCari : Form
    {
        public FrmCari()
        {
            InitializeComponent();
        }
        MGsTOKContex context = new MGsTOKContex();//gerekli
        CariDal caridal = new CariDal();
        private void GetAll()
        {
            gridControl1.DataSource = caridal.GetCariler(context);
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
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
        }

        private void btnCariAra_Click(object sender, EventArgs e)
        {

            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;//2 panel aynı anda görülsün
        }

        private void FrmCari_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        private void btnCariGuncelle_Click(object sender, EventArgs e)
        {
            GetAll();
        }

        private void btnCariSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan kaydı silmek istediğinize emin misiniz?", "UYARI", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string secilen = gridView1.GetFocusedRowCellValue(colCariKodu).ToString();
                caridal.Delete(context, c => c.CariKodu == secilen);
                caridal.save(context);
                GetAll();
            }
        }

        private void btnCariEkle_Click(object sender, EventArgs e)
        {
            FrmCariIslem f = new FrmCariIslem(new Entities.Tables.Cari());
            f.ShowDialog();
        }

        private void btnCariDuzenle_Click(object sender, EventArgs e)
        {
            string secilen = gridView1.GetFocusedRowCellValue(colCariKodu).ToString();
            FrmCariIslem f = new FrmCariIslem(caridal.GetByFilter(context, c => c.CariKodu == secilen));
            f.Show();
        }

        private void btnCariKopyala_Click(object sender, EventArgs e)
        {
            //var olan kaydı seçip koyalayıp  üzerinde tekrar kayıt yapmak için  id -1 dedik stokkodu benzersiz olacağı için null atadım.
            string secilen = gridView1.GetFocusedRowCellValue(colCariKodu).ToString();
            Entities.Tables.Cari cariEntity = new Entities.Tables.Cari();
            cariEntity = caridal.GetByFilter(context, c => c.CariKodu == secilen);
            cariEntity.Id = -1;
            cariEntity.CariKodu = null;
            FrmCariIslem ca = new FrmCariIslem(cariEntity);
            ca.ShowDialog();
        }

        private void btnCariHareket_Click(object sender, EventArgs e)
        {
            string secilen = gridView1.GetFocusedRowCellValue(colCariKodu).ToString();
            FrmCariHareket form = new FrmCariHareket(secilen);
            form.ShowDialog();
        }
    }
}
