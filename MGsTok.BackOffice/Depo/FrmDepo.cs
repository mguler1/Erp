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

namespace MGsTok.BackOffice.Depo
{
    public partial class FrmDepo : DevExpress.XtraEditors.XtraForm
    {
        MGsTOKContex context = new MGsTOKContex();//gerekli
        DepoDal depodal = new DepoDal();
        private Entities.Tables.Depo _entity;

        public FrmDepo()
        {
            InitializeComponent();
           
        }

        private void FrmDepo_Load(object sender, EventArgs e)
        {
            listele();
        }
        public void listele()
        {
            gridControl1.DataSource = depodal.GetAll(context);
        }

        private void btnDepoGuncelle_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnDepoSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan kaydı silmek istediğinize emin misiniz?", "UYARI", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string secilen = gridView1.GetFocusedRowCellValue(colDepoKodu).ToString();
               depodal.Delete(context, c => c.DepoKodu == secilen);
                depodal.save(context);
                listele();
            }
        }

        private void btnDepoEkle_Click(object sender, EventArgs e)
        {
            FrmDepoIslem d = new FrmDepoIslem (new Entities.Tables.Depo());
            d.ShowDialog();
        }

        private void btnDepoDuzenle_Click(object sender, EventArgs e)
        {
            string secilen = gridView1.GetFocusedRowCellValue(colDepoKodu).ToString();
            FrmDepoIslem f = new FrmDepoIslem(depodal.GetByFilter(context, c => c.DepoKodu == secilen));
            f.Show();
        }

        private void btnDepoHareket_Click(object sender, EventArgs e)
        {
            string secilen = gridView1.GetFocusedRowCellValue(colDepoKodu).ToString();
            FrmDepoHareket form = new FrmDepoHareket(secilen);
            form.ShowDialog();
        }
    }
}