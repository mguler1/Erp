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
using MGsTok.Entities.interfaces;

namespace MGsTok.BackOffice.Cari
{
    public partial class FrmCariIslem : DevExpress.XtraEditors.XtraForm
    {
        private Entities.Tables.Cari _entity;//ben oluştrdum
        private CariDal Caridal = new CariDal();
        private MGsTOKContex context = new MGsTOKContex();
        public FrmCariIslem(Entities.Tables.Cari entity)
        {
            InitializeComponent();
             _entity = entity;
            toggleDurum.DataBindings.Add("EditValue", _entity, "Durumu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCariKodu.DataBindings.Add("Text", _entity, "CariKodu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCariAdi.DataBindings.Add("Text", _entity, "CariAdi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtFaturaUnvani.DataBindings.Add("Text", _entity, "FaturaUnvani", false, DataSourceUpdateMode.OnPropertyChanged);
            txtVergiDairesi.DataBindings.Add("Text", _entity, "VergiDairesi", false, DataSourceUpdateMode.OnPropertyChanged);
            cmbCariTuru.DataBindings.Add("Text", _entity, "CariTuru", false, DataSourceUpdateMode.OnPropertyChanged);
            txtVergiNo.DataBindings.Add("Text", _entity, "VergiNo", false, DataSourceUpdateMode.OnPropertyChanged);
            txtYetkiliKisi.DataBindings.Add("Text", _entity, "YetkiliKisi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCep.DataBindings.Add("Text", _entity, "CepTelefonu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSabitTel.DataBindings.Add("Text", _entity, "Telefon", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAdres.DataBindings.Add("Text", _entity, "Adres",false, DataSourceUpdateMode.OnPropertyChanged);
            txtİl.DataBindings.Add("Text", _entity, "Il", false, DataSourceUpdateMode.OnPropertyChanged);
            txtİlce.DataBindings.Add("Text", _entity, "Ilce", false, DataSourceUpdateMode.OnPropertyChanged);
            txtFax.DataBindings.Add("Text", _entity, "Fax", false, DataSourceUpdateMode.OnPropertyChanged);
            txtMail.DataBindings.Add("Text", _entity, "EMail", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSemt.DataBindings.Add("Text", _entity, "Semt", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAcıklama.DataBindings.Add("Text", _entity, "Aciklama",false, DataSourceUpdateMode.OnPropertyChanged);
            btnCariGrubu.DataBindings.Add("Text", _entity, "CariGrubu", false, DataSourceUpdateMode.OnPropertyChanged);
            btnCariAltGrubu.DataBindings.Add("Text", _entity, "CariAltGrubu",false, DataSourceUpdateMode.OnPropertyChanged);
            btnOzelKod1.DataBindings.Add("Text", _entity, "OzelKod1", false, DataSourceUpdateMode.OnPropertyChanged);
            btnOzelKod2.DataBindings.Add("Text", _entity, "OzelKod2", false, DataSourceUpdateMode.OnPropertyChanged);
            btnOzelKod3.DataBindings.Add("Text", _entity, "OzelKod3", false, DataSourceUpdateMode.OnPropertyChanged);
            btnOzelKod4.DataBindings.Add("Text", _entity, "OzelKod4", false, DataSourceUpdateMode.OnPropertyChanged);
            
            calcAlısOzelFiyatı.DataBindings.Add("Text", _entity, "AlisOzelFiyati", true, DataSourceUpdateMode.OnPropertyChanged);
            calcSatısOzelFiyatı.DataBindings.Add("Text", _entity, "SatisOzelFiyati", true, DataSourceUpdateMode.OnPropertyChanged);

            calcİskontoOrani.DataBindings.Add("Text", _entity, "IskontoOrani", true, DataSourceUpdateMode.OnPropertyChanged);
            calcİskontoOrani.DataBindings[0].FormattingEnabled = true;
            calcİskontoOrani.DataBindings[0].FormatString ="'%'0";
            calcİskontoOrani.DataBindings[0].DataSourceNullValue = "0";

            calcRiskLimit.DataBindings.Add("Text", _entity, "RiskLimit", true, DataSourceUpdateMode.OnPropertyChanged);
            calcRiskLimit.DataBindings[0].FormattingEnabled = true;
            calcRiskLimit.DataBindings[0].FormatString ="C2";
            calcRiskLimit.DataBindings[0].DataSourceNullValue = "0";

        }

        private void btnOzelKod3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Caridal.AddOrUpdate(context, _entity);

            Caridal.save(context);
            this.Close();
        }

        private void FrmCariIslem_Load(object sender, EventArgs e)
        {

        }
    }
}