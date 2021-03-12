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
using MGsTok.BackOffice.Tanımlar;

namespace MGsTok.BackOffice.Personel
{
    public partial class Personelislemleri : DevExpress.XtraEditors.XtraForm
    {
        private Entities.Tables.Personel _entity;
        private PersonelDal personeldal =new PersonelDal();
        private MGsTOKContex context = new MGsTOKContex();
        public bool saved = false;
        public Personelislemleri(Entities.Tables.Personel entity)
        {
            InitializeComponent();
            _entity = entity;
            toggleCalisiyor.DataBindings.Add("EditValue", _entity,"Calisiyot", false, DataSourceUpdateMode.OnPropertyChanged);
            txtPersonelKodu.DataBindings.Add("Text", _entity, "PersonelKodu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtPersonelAdi.DataBindings.Add("Text", _entity, "PersonelAdi", false, DataSourceUpdateMode.OnPropertyChanged);
            cmbUnvani.DataBindings.Add("Text", _entity, "Unvani", false, DataSourceUpdateMode.OnPropertyChanged);
            txtIseGiris.DataBindings.Add("Text", _entity, "IseGirisTarihi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtIstenCikis.DataBindings.Add("Text", _entity, "IstenCikis", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAdres.DataBindings.Add("Text", _entity, "Adres",false,DataSourceUpdateMode.OnPropertyChanged);
            cmbIl.DataBindings.Add("Text", _entity, "Il",false, DataSourceUpdateMode.OnPropertyChanged);
            cmbIlce.DataBindings.Add("Text", _entity, "Ilce", false, DataSourceUpdateMode.OnPropertyChanged);
            txtFax.DataBindings.Add("Text", _entity, "Fax", false, DataSourceUpdateMode.OnPropertyChanged);
            txtMail.DataBindings.Add("Text", _entity, "EMail", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSemt.DataBindings.Add("Text", _entity, "Semt", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAcıklama.DataBindings.Add("Text", _entity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
            txtVergiNo.DataBindings.Add("Text", _entity, "VergiNo",false,DataSourceUpdateMode.OnPropertyChanged);
            txtKimlikNo.DataBindings.Add("Text", _entity, "TcKimlikNo", false, DataSourceUpdateMode.OnPropertyChanged);
            calcAylıkMaas.DataBindings.Add("EditValue", _entity, "AylıkMaas", true, DataSourceUpdateMode.OnPropertyChanged, 0, "C2");
            calcPrimOrani.DataBindings.Add("EditValue", _entity, "PrimOrani", true, DataSourceUpdateMode.OnPropertyChanged,0,"C2");
        }

        private void PersonelIslemleri_Load(object sender, EventArgs e)
        {
            textEdit1.Visible = false;
            simpleButton2.Visible = false;

            cmbIl.Properties.DataSource = (from x in context.Il select new { x.Id, x.Sehir }).ToList();
           
        }

        private void calcAylıkMaas_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            saved = true;
            personeldal.AddOrUpdate(context, _entity);
            personeldal.save(context);
            this.Close();

            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            textEdit1.Visible = true;
            simpleButton2.Visible = true;
            

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            cmbUnvani.Properties.Items.Add(textEdit1.Text);
            MessageBox.Show("İşlem Başarılı");
            textEdit1.Visible = false;
            simpleButton2.Visible = false;
        }

        private void cmbUnvani_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbIl_EditValueChanged(object sender, EventArgs e)
        {
            int secilen;
            secilen = int.Parse(cmbIl.EditValue.ToString());
            cmbIlce.Properties.DataSource = (from y in context.Ilceler select new { y.Id, y.Ilce, y.sehir }).Where(z => z.sehir == secilen).ToList();
        }
    }
}