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

namespace MGsTok.BackOffice.Ödeme_Türü
{
    public partial class FrmOdemeTuru : DevExpress.XtraEditors.XtraForm
    {
        MGsTOKContex context = new MGsTOKContex();//gerekli
        OdemeTuruDal odemeturudal = new OdemeTuruDal();
        public FrmOdemeTuru()
        {
            InitializeComponent();
        }

        private void FrmOdemeTuru_Load(object sender, EventArgs e)
        {
            listele();
        }
        void  listele()
        {
            gridControl1.DataSource = odemeturudal.OdemeTuruListele(context);
        }

        private void btnOdemeGuncelle_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void lblBaslık_Click(object sender, EventArgs e)
        {

        }

        private void btnOdemeSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan kaydı silmek istediğinize emin misiniz?", "UYARI", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string secilen = gridView1.GetFocusedRowCellValue(colOdemeTuruKodu).ToString();
                odemeturudal.Delete(context, c => c.OdemeTuruKodu == secilen);
                odemeturudal.save(context);
                listele();
            }
        }

        private void btnOdemeEkle_Click(object sender, EventArgs e)
        {
            FrmOdemeTuruIslemleri islem = new FrmOdemeTuruIslemleri(new Entities.Tables.OdemeTuru());
            islem.ShowDialog();
        }

        private void btnOdemeDuzenle_Click(object sender, EventArgs e)
        {
            string secilen = gridView1.GetFocusedRowCellValue(colOdemeTuruKodu).ToString();
            FrmOdemeTuruIslemleri islem = new FrmOdemeTuruIslemleri(odemeturudal.GetByFilter(context,c=>c.OdemeTuruKodu==secilen));
            islem.ShowDialog();
        }
    }
}