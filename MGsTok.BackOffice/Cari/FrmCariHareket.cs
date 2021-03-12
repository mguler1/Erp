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

namespace MGsTok.BackOffice.Cari
{
    public partial class FrmCariHareket : DevExpress.XtraEditors.XtraForm
    {
        public FrmCariHareket(string cariKodu)
        {
            InitializeComponent();
            _cariKodu = cariKodu;
        }
        CariDal caridal = new CariDal();
        MGsTOKContex context = new MGsTOKContex();
      private  string _cariKodu = null;
        private void FrmCariHareket_Load(object sender, EventArgs e)
        {
            guncelle();
        }
        private void guncelle()
        {
            gridControl1.DataSource = caridal.CariFisGenelToplam(context, _cariKodu);
            gridControl3.DataSource = caridal.CariGenelToplam(context, _cariKodu);
            gridControl2.DataSource= caridal.CariFisAyrinti(context, _cariKodu);
        }

        private void btnStokAra_Click(object sender, EventArgs e)
        {
            if (gridView1.OptionsView.ShowAutoFilterRow == true)
            {
                gridView1.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                gridView1.OptionsView.ShowAutoFilterRow = true;
            }
        }

        private void btnStokGuncelle_Click(object sender, EventArgs e)
        {
            guncelle();
        }
    }
}