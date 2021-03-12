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

namespace MGsTok.BackOffice.Depo
{
    public partial class FrmDepoIslem : DevExpress.XtraEditors.XtraForm
    {

        MGsTOKContex context = new MGsTOKContex();//gerekli
        DepoDal depodal = new DepoDal();
        private Entities.Tables.Depo _entity;
        public FrmDepoIslem(Entities.Tables.Depo entity)
        {
            InitializeComponent();
            _entity = entity;
            txtDepoKodu.DataBindings.Add("Text", _entity, "DepoKodu");
            txtDepoAdi.DataBindings.Add("Text", _entity, "DepoAdi");
            txtYetkiliKodu.DataBindings.Add("Text", _entity, "YetkiliKodu");
            txtYetkiliAdi.DataBindings.Add("Text", _entity, "YetkiliAdi");
            txtTelefon.DataBindings.Add("Text", _entity, "Telefon");
            txtIl.DataBindings.Add("Text", _entity, "DepoIl");
            txtIlce.DataBindings.Add("Text", _entity, "DepoIlce");
            txtSemt.DataBindings.Add("Text", _entity, "Semt");
            txtAdres.DataBindings.Add("Text", _entity, "Adresi");
            txtAcıklama.DataBindings.Add("Text", _entity, "Aciklama");
        }

        private void memoEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmDepoIslem_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            depodal.AddOrUpdate(context,_entity);
            depodal.save(context);
            this.Close();
        }
    }
}