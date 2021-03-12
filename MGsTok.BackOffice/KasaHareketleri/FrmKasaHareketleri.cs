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
using MGsTok.BackOffice.Fişler;

namespace MGsTok.BackOffice.KasaHareketleri
{
    public partial class FrmKasaHareketleri : DevExpress.XtraEditors.XtraForm
    {
        MGsTOKContex context = new MGsTOKContex();
        KasaHareketDal kasahareketdal = new KasaHareketDal();
        public FrmKasaHareketleri()
        {
            InitializeComponent();
        }
        private void listele()
        {
            gridControl1.DataSource = kasahareketdal.GetAll(context);
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmKasaHareketleri_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmFisIslem form = new FrmFisIslem(gridView1.GetFocusedRowCellValue(colFisKodu).ToString());
            form.ShowDialog();
        }
    }
}