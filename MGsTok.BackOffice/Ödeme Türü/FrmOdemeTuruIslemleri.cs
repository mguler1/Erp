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
using MGsTok.Entities.Tables;

namespace MGsTok.BackOffice.Ödeme_Türü
{
    public partial class FrmOdemeTuruIslemleri : DevExpress.XtraEditors.XtraForm
    {
        MGsTOKContex context = new MGsTOKContex();//gerekli
        OdemeTuruDal odemeturudal = new OdemeTuruDal();
        private OdemeTuru _entity;

        public FrmOdemeTuruIslemleri(OdemeTuru entity)
        {
            InitializeComponent();
            _entity = entity;
            txtOdemeTuru.DataBindings.Add("Text", _entity, "OdemeTuruKodu");
            txtOdemeAdi.DataBindings.Add("Text", _entity, "OdemeTuruAdi");
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama");
        }

        private void FrmOdemeTuruIslemleri_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            odemeturudal.AddOrUpdate(context,_entity);
            odemeturudal.save(context);
            this.Close();
        }
    }
}