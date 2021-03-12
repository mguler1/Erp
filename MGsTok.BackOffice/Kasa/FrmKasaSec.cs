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
    
    public partial class FrmKasaSec : DevExpress.XtraEditors.XtraForm
    {
        MGsTOKContex context = new MGsTOKContex();//gerekli
        KasaDal kasadal = new KasaDal();
        public Entities.Tables.Kasa entity =new Entities.Tables.Kasa();
        public bool secildi=false;
        public FrmKasaSec()
        {
            InitializeComponent();
        }

        private void FrmKasaSec_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = kasadal.KasaListele(context);
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (gridView1.GetSelectedRows().Length!=0)
            {
                string kasaKodu = gridView1.GetFocusedRowCellValue(colKasaKodu).ToString();
                entity = context.kasalar.SingleOrDefault(c => c.KasaKodu == kasaKodu);
                secildi = true;
                this.Close();
            }
       
        }
        
    }
}