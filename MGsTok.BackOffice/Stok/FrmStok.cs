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
using MGsTok.Entities.Tables;
using MGsTok.Entities.DataAccess;

namespace MGsTok.BackOffice.Stok
{
    public partial class FrmStok : DevExpress.XtraEditors.XtraForm
    {
        MGsTOKContex context = new MGsTOKContex();//gerekli
        StokDal stokdal = new StokDal();
        public FrmStok()
        {
            InitializeComponent();
        }

        private void lblBaslık_Click(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //YAPIM AŞAMASINDA EKRANDA KAYBOLDU KULLANILMAYACAK
        }

        private void filterControl1_Click(object sender, EventArgs e)
        {

        }

        private void FrmStok_Load(object sender, EventArgs e)
        {
            GetAll();
        }
        public void GetAll()//gridde verileri listelemek için yazdığım metod.
=>
           
        gridControl1.DataSource=   stokdal.GetAlljoin(context);//methodun orjinali stok dalın içinde
          

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

        private void btnStokAra_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;//2 panel aynı anda görülsün
        }

        private void btnStokGuncelle_Click(object sender, EventArgs e)
        {
            GetAll();
        }

        private void btnStokSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan kaydı silmek istediğinize emin misiniz?", "UYARI", MessageBoxButtons.YesNo) == DialogResult.Yes) 
            {
                string secilen = gridView1.GetFocusedRowCellValue(colStokKodu).ToString();
                stokdal.Delete(context, c => c.StokKodu == secilen);
                stokdal.save(context);
                GetAll();
            }
         

        }

        private void btnStokEkle_Click(object sender, EventArgs e)
        {
            FrmStokİslem f = new FrmStokİslem(new Entities.Tables.Stok());
            f.ShowDialog();
            GetAll();
        }

        private void btnStokDuzenle_Click(object sender, EventArgs e)
        {
            string secilen = gridView1.GetFocusedRowCellValue(colStokKodu).ToString();
            FrmStokİslem f = new FrmStokİslem(stokdal.GetByFilter(context,c=>c.StokKodu==secilen));
            f.Show();
        }

        private void btnStokKopyala_Click(object sender, EventArgs e)
        {
            //var olan kaydı seçip koyalayıp  üzerinde tekrar kayıt yapmak için  id -1 dedik stokkodu benzersiz olacağı için null atadım.
            string secilen = gridView1.GetFocusedRowCellValue(colStokKodu).ToString();
            Entities.Tables.Stok stokEntity = new Entities.Tables.Stok();
            stokEntity = stokdal.GetByFilter(context, c => c.StokKodu == secilen);
            stokEntity.Id = -1;
            stokEntity.StokKodu = null;
            FrmStokİslem f = new FrmStokİslem(stokEntity);
            f.ShowDialog();
        }

        private void btnStokHareket_Click(object sender, EventArgs e)
        {
            string secilen = gridView1.GetFocusedRowCellValue(colStokKodu).ToString();
             FrmStokHareket form = new FrmStokHareket(secilen);
            form.ShowDialog();
        }
    }
}