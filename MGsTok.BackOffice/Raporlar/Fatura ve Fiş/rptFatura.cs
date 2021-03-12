using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using MGsTok.Entities.Contex;
using MGsTok.Entities.DataAccess;
using DevExpress.DataAccess.ObjectBinding;

namespace MGsTok.BackOffice.Raporlar.Fatura_ve_Fiş
{
    public partial class rptFatura : DevExpress.XtraReports.UI.XtraReport
    {
        public rptFatura(string fiskodu)
        {
            InitializeComponent();
            MGsTOKContex conetext = new MGsTOKContex();
            StokDal stokdal = new StokDal();
            FisDal fisdal = new FisDal();
            ObjectDataSource fisDatasource = new ObjectDataSource { DataSource = fisdal.GetAll(conetext,c=>c.FisKodu==fiskodu) };
            ObjectDataSource stokDatasource = new ObjectDataSource { DataSource = stokdal.GetAlljoin(conetext) };
            this.DataSource = stokDatasource;
            lblCariAdi.DataBindings.Add("Text", fisDatasource, "CariAdi");
            lblAdres.DataBindings.Add("Text", fisDatasource, "Adres");

            colStokAdi.DataBindings.Add("Text", this.DataSource, "StokAdi");
            colMiktar.DataBindings.Add("Text", this.DataSource, "Miktar");
            colBirimFiyat.DataBindings.Add("Text", this.DataSource, "BirimFiyat");

        }

    }
}
