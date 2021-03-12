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
using MGsTok.Entities.Tables;
using MGsTok.BackOffice.Fişler;

namespace MGsTok.BackOffice.Stok_Hareketleri
{
    public partial class FrmStokHareketleri : DevExpress.XtraEditors.XtraForm
    {
        MGsTOKContex context = new MGsTOKContex();
        StokHareketDal stokhareketdal = new StokHareketDal();
        public FrmStokHareketleri()
        {
            InitializeComponent();
        }

        private void listele()
        {
          gridControl1.DataSource=  stokhareketdal.GetAll(context);
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmStokHareketleri_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
           
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            filterControl1.ApplyFilter();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            filterControl1.FilterString = null; //önce filitreyi içini null yap
            filterControl1.ApplyFilter();//sonra uygula
        }

        private void repositorySeriNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string veri = Convert.ToString(gridView1.GetFocusedRowCellValue(colSeriNo));
            FrmSeriNoBilgileri form = new FrmSeriNoBilgileri(veri);
            form.ShowDialog();
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmFisIslem form = new FrmFisIslem(gridView1.GetFocusedRowCellValue(colDepoAdi).ToString());
            form.ShowDialog();
        }
    }
}