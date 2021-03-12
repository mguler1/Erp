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
    public partial class FrmKasaHareket : DevExpress.XtraEditors.XtraForm
    {
         MGsTOKContex context = new MGsTOKContex();//gerekli
        KasaDal kasadal = new KasaDal();
        private string _kasakodu;
        public FrmKasaHareket()
        {
            InitializeComponent();
        }

        private void FrmKasaHareket_Load(object sender, EventArgs e)
        {
            Guncelle();
        }
        public void Guncelle()
        {
            gridControl1.DataSource = kasadal.GetAll(context, c => c.KasaKodu == _kasakodu);
            gridControl2.DataSource = kasadal.OdemeTuruToplamListele(context,_kasakodu);
            gridControl3.DataSource = kasadal.GenelToplamListele(context, _kasakodu);
        }
    }
}