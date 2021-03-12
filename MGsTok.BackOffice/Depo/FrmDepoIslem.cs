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
            cmbIl.DataBindings.Add("Text", _entity, "DepoIl");
            cmbIlce.DataBindings.Add("Text", _entity, "DepoIlce");
            txtSemt.DataBindings.Add("Text", _entity, "Semt");
            txtAdres.DataBindings.Add("Text", _entity, "Adresi");
            txtAcıklama.DataBindings.Add("Text", _entity, "Aciklama");
        }

        private void memoEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmDepoIslem_Load(object sender, EventArgs e)
        {
            cmbIl.Properties.DataSource = (from x in context.Il select new { x.Id, x.Sehir }).ToList();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            depodal.AddOrUpdate(context,_entity);
            depodal.save(context);
            this.Close();
        }

        private void cmbIl_EditValueChanged(object sender, EventArgs e)
        {
            int secilen;
            secilen = int.Parse(cmbIl.EditValue.ToString());
            cmbIlce.Properties.DataSource = (from y in context.Ilceler select new { y.Id, y.Ilce, y.sehir }).Where(z => z.sehir == secilen).ToList();
        }
    }
}