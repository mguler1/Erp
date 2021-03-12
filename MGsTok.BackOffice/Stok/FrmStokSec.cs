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

namespace MGsTok.BackOffice.Stok
{
    public partial class FrmStokSec : DevExpress.XtraEditors.XtraForm
    {
        MGsTOKContex context = new MGsTOKContex();//gerekli
        StokDal stokdal = new StokDal();
         public  List<Entities.Tables.Stok> secilen=new List<Entities.Tables.Stok>();
        public bool secildi = false;

        public FrmStokSec(bool coklusecim=false)
        {
            InitializeComponent();
            if (coklusecim==true)
            {
                gridView1.OptionsSelection.MultiSelect = true;
            }
            
        }

        private void FrmStokSec_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = stokdal.GetAlljoin(context);
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (gridView1.GetSelectedRows().Length!=0)
            {
                foreach (var row in gridView1.GetSelectedRows())//seçilen listenin sırası
                {
                    string stokkodu = gridView1.GetRowCellValue(row, colStokKodu).ToString();
                    secilen.Add(context.Stoklar.SingleOrDefault(c => c.StokKodu == stokkodu));
                }
                secildi = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Seçilen Bir Ürün Bulunamadı");
            }
          
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblBaslık_Click(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}