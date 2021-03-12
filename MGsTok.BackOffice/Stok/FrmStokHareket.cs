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
    public partial class FrmStokHareket : DevExpress.XtraEditors.XtraForm
    {
        
        StokHareketDal stokHareket = new StokHareketDal();
        MGsTOKContex context = new MGsTOKContex();//gerekli
        private string _stokkodu;

        public FrmStokHareket(string stokkodu)
        {
            InitializeComponent();
            _stokkodu = stokkodu;
        }

        private void FrmStokHareket_Load(object sender, EventArgs e)
        {
            guncelle();
        }
        private void guncelle()
        {
            gridControl3.DataSource = stokHareket.GetGenelStok(context, _stokkodu);
            gridControl2.DataSource = stokHareket.GetDepoStok(context, _stokkodu);
            gridControl1.DataSource = stokHareket.GetAll(context, c => c.StokKodu == _stokkodu);

        }

        private void btnStokGuncelle_Click(object sender, EventArgs e)
        {
            guncelle();
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
    }
}