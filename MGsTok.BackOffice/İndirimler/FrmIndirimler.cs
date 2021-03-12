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

namespace MGsTok.BackOffice.İndirimler
{
    public partial class FrmIndirimler : DevExpress.XtraEditors.XtraForm
    {
        MGsTOKContex context = new MGsTOKContex();
        IndirimDal indirimdal = new IndirimDal();
        public FrmIndirimler()
        {
            InitializeComponent();
            listele();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            FrmIndirimIslem ii = new FrmIndirimIslem();
            ii.ShowDialog();
        }
         private void listele ()
        {
            MGsTOKContex context = new MGsTOKContex();
            gridControl1.DataSource = indirimdal.GetAll(context);
        }
        private void FrmIndirimler_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçilen Kaydı Silmek İstediğinize Emin misiniz?","Uyarı",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                var secilen = gridView1.GetFocusedRowCellValue(colStokKodu).ToString();
                indirimdal.Delete(context,c=>c.StokKodu==secilen);
                indirimdal.save(context);
            }
        }
    }
}