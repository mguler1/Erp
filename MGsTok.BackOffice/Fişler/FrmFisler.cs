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
namespace MGsTok.BackOffice.Fişler
{
    public partial class FrmFisler : DevExpress.XtraEditors.XtraForm
    {
        MGsTOKContex context = new MGsTOKContex();
        FisDal fisdal = new FisDal();
        KasaHareketDal kasahareketdal = new KasaHareketDal();
        StokHareketDal stokhareketdal = new StokHareketDal();
        public FrmFisler()
        {
            InitializeComponent();
        }

        private void FrmFisler_Load(object sender, EventArgs e)
        {
            listele();
        }
        private void listele()
        {
            context = new MGsTOKContex();
          gridControl1.DataSource= fisdal.GetAll(context);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan kaydı silmek istediğinize emin misiniz?", "UYARI", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //fiş silinince otomatik olarak stokhareket ve kasa kaydı silinecek
                string secilen = gridView1.GetFocusedRowCellValue(colFisKodu).ToString();
                fisdal.Delete(context, c => c.FisKodu == secilen);
                kasahareketdal.Delete(context,c=>c.FisKodu==secilen);
                stokhareketdal.Delete(context, c => c.Fiskodu == secilen);
                fisdal.save(context);
                listele();
            }
        }

       
        private void FisIslem_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFisIslem form = new FrmFisIslem(null, e.Item.Caption);
            form.ShowDialog();
        }
    }
}