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

namespace MGsTok.BackOffice.Depo
{
    public partial class FrmDepoSecim : DevExpress.XtraEditors.XtraForm
    {
        MGsTOKContex context = new MGsTOKContex();//gerekli
        DepoDal DepoDal = new DepoDal();
        public Entities.Tables.Depo entity =new Entities.Tables.Depo();
        private string _stokkodu;
        public bool secildi=false;

        public FrmDepoSecim(string stokkodu)//stokkoduna göre depoları getirme
        {
            InitializeComponent();
        }

        private void FrmDepoSecim_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = DepoDal.DepobazındaStokListele(context,_stokkodu);
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount!=0)
            {
                string depokodu = gridView1.GetFocusedRowCellValue(colDepoKodu).ToString();
                entity = (context.Depolar.SingleOrDefault(c => c.DepoKodu == depokodu));
                secildi = true;
                this.Close();
            }
          
        }
    }
}