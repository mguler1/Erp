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
    public partial class FrmKasaIslem : DevExpress.XtraEditors.XtraForm
    {
        private Entities.Tables.Kasa _entity;
        KasaDal kasadal = new KasaDal();
        MGsTOKContex context = new MGsTOKContex();
        public FrmKasaIslem(Entities.Tables.Kasa entity)
        {
            InitializeComponent();
            _entity = entity;
            txtKasaKodu.DataBindings.Add("Text", _entity, "KasaKodu");
            txtKasaAdi.DataBindings.Add("Text", _entity, "KasaAdi");
            txtYetkiliKodu.DataBindings.Add("Text", _entity, "YetkiliKodu");
            txtYetkiliAdi.DataBindings.Add("Text", _entity, "YetkiliAdi");
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama");
           
           

        }

        private void FrmKasaIslem_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            kasadal.AddOrUpdate(context, _entity);
            
                kasadal.save(context);
                this.Close();
            
        }
    }
}