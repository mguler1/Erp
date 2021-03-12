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

namespace MGsTok.BackOffice.Cari
{
    public partial class FrmCariSec : DevExpress.XtraEditors.XtraForm
    {
        MGsTOKContex context = new MGsTOKContex();//gerekli
        CariDal caridal = new CariDal();
        public List<Entities.Tables.Cari> secilen = new List<Entities.Tables.Cari>();
       // public List<CariBakiye> secilenCariBakiye = new List<CariBakiye>();
        public bool secildi = false;
        public FrmCariSec(bool coklusecim = false)
        {
            InitializeComponent();
            if (coklusecim == true)
            {
                gridView1.OptionsSelection.MultiSelect = true;
            }
        }

        private void FrmCariSec_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = caridal.GetCariler(context);
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (gridView1.GetSelectedRows().Length != 0)
            {
                foreach (var row in gridView1.GetSelectedRows())//seçilen listenin sırası
                {
                    string cariKodu = gridView1.GetRowCellValue(row, colCariKodu).ToString();
                    secilen.Add(context.Cariler.SingleOrDefault(c => c.CariKodu == cariKodu));
                  
                }
                secildi = true;
                this.Close();
            }
       
            else
	        {
                MessageBox.Show("Cari Seçilmedi");
            }
           
        }
    }
}
