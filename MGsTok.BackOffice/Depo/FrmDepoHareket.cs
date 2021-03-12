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

namespace MGsTok.BackOffice.Depo
{
    public partial class FrmDepoHareket : DevExpress.XtraEditors.XtraForm
    {
        MGsTOKContex context = new MGsTOKContex();//gerekli
        StokHareketDal stokHareketDal = new StokHareketDal();
        private string _depokodu;
        public FrmDepoHareket(string depokodu)
        {
            InitializeComponent();
            _depokodu = depokodu;
        }

        private void FrmDepoHareket_Load(object sender, EventArgs e)
        {
            Guncelle();
        }
        private void Guncelle()
        {
            gridControl1.DataSource = stokHareketDal.GetAll(context, c => c.DepoKodu == _depokodu);
            gridControl2.DataSource = stokHareketDal.DepoStokListele(context,_depokodu);
            gridControl3.DataSource = stokHareketDal.DepoIstatistik(context, _depokodu);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Guncelle();
        }
    }
}