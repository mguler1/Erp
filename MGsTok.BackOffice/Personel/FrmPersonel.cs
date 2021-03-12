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
namespace MGsTok.BackOffice.Personel
{
    public partial class FrmPersonel : DevExpress.XtraEditors.XtraForm
    {
        MGsTOKContex context = new MGsTOKContex();
        PersonelDal personeldal = new PersonelDal();
        string secilen = null;
        public FrmPersonel()
        {
            InitializeComponent();
        }
        private void listele()
        {
            gridControl1.DataSource = personeldal.PersonelListele(context);
        }
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnDepoGuncelle_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan kaydı silmek istediğinize emin misiniz?", "UYARI", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string secilen = gridView1.GetFocusedRowCellValue(colPersonelKodu).ToString();
                personeldal.Delete(context, c => c.PersonelKodu == secilen);
                personeldal.save(context);
                listele();
            }
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {

            Personelislemleri f = new Personelislemleri (new Entities.Tables.Personel());
            f.ShowDialog();

        }

        private void btnPersonelDuzenle_Click(object sender, EventArgs e)
        {

            string secilen = gridView1.GetFocusedRowCellValue(colPersonelKodu).ToString();
           Personelislemleri f = new Personelislemleri(personeldal.GetByFilter(context, c => c.PersonelKodu == secilen));
            f.Show();
        }
    }
}