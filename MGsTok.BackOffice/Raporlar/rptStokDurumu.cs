using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using MGsTok.Entities.Contex;
using MGsTok.Entities.DataAccess;
using DevExpress.DataAccess.ObjectBinding;

namespace MGsTokReports.Stok
{
    public partial class rptStokDurumu : DevExpress.XtraReports.UI.XtraReport
    {
        public rptStokDurumu()
        {
            InitializeComponent();
            MGsTOKContex conetext = new MGsTOKContex();
            StokDal stokdal = new StokDal();

            ObjectDataSource stokDatasource = new ObjectDataSource {DataSource= stokdal.GetAlljoin(conetext)};
            this.DataSource = stokDatasource;
           // colStokGrubu.DataBindings.Add("Text", this.DataSource, "StokKodu");
            colBarkod.DataBindings.Add("Text", this.DataSource, "Barkod");
            colStokAdi.DataBindings.Add("Text", this.DataSource, "StokAdi");
            colBirimi.DataBindings.Add("Text", this.DataSource, "StokBirimi");
            colStokGrubu.DataBindings.Add("Text", this.DataSource, "StokGrubu");
            colSatisKdv.DataBindings.Add("Text", this.DataSource, "SatisKdv");
            colStokGiris.DataBindings.Add("Text", this.DataSource, "StokGiris");
            colStokCikis.DataBindings.Add("Text", this.DataSource, "StokCikis");

        }

    }
}
