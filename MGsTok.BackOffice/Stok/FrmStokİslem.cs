using MGsTok.Entities.Contex;
using MGsTok.Entities.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MGsTok.Entities.Tables;

namespace MGsTok.BackOffice.Stok
{
    public partial class FrmStokİslem : Form
    {
        private Entities.Tables.Stok _entity;//ben oluştrdum
        private   StokDal stokdal = new StokDal();
      private MGsTOKContex context = new MGsTOKContex();
      

        public FrmStokİslem(Entities.Tables.Stok entity)//dışardan parametre ile aldım
        {
            InitializeComponent();
            _entity = entity;
           
            toggleDurum.DataBindings.Add("EditValue", _entity, "Durumu");
            txtStokKodu.DataBindings.Add("Text", _entity, "StokKodu");
            txtStokAdi.DataBindings.Add("Text", _entity, "StokAdi");
            txtBarkod.DataBindings.Add("Text", _entity, "Barkod");
            cmbBarkodTuru.DataBindings.Add("Text", _entity, "BarkodTuru");
            txtStokBirimi.DataBindings.Add("Text", _entity, "StokBirimi");
            btnStokGrubu.DataBindings.Add("Text", _entity, "StokGrubu");
            txtAcıklama.DataBindings.Add("Text", _entity, "Aciklama");
            btnStokAltGrubu.DataBindings.Add("Text", _entity, "StokAltGrubu");
            btnMarka.DataBindings.Add("Text", _entity, "Marka");
            btnModel.DataBindings.Add("Text", _entity, "Model");
            btnOzelKod1.DataBindings.Add("Text", _entity, "OzelKod1");
            btnOzelKod2.DataBindings.Add("Text", _entity, "OzelKod2");
            btnOzelKod3.DataBindings.Add("Text", _entity, "OzelKod3");
            btnOzelKod4.DataBindings.Add("Text", _entity, "OzelKod4");
            txtGarantiSuresi.DataBindings.Add("Text", _entity, "GarantiSuresi");
            txtUreticiKodu.DataBindings.Add("Text", _entity, "UreticiKodu");

            calcAlısFiyatı1.DataBindings.Add("Text", _entity, "AlisFiyati1");
            calcAlısFiyatı1.DataBindings[0].FormattingEnabled = true;
            calcAlısFiyatı1.DataBindings[0].FormatString = "C2";

            calcAlısFiyatı2.DataBindings.Add("Text", _entity, "AlisFiyati2");
            calcAlısFiyatı2.DataBindings[0].FormattingEnabled = true;
            calcAlısFiyatı2.DataBindings[0].FormatString = "C2";

            calcAlısFiyatı3.DataBindings.Add("Text", _entity, "AlisFiyati3");
            calcAlısFiyatı3.DataBindings[0].FormattingEnabled = true;
            calcAlısFiyatı3.DataBindings[0].FormatString = "C2";


            calcAlısKdv.DataBindings.Add("Text", _entity, "AlisKdv");
            calcAlısKdv.DataBindings[0].FormattingEnabled = true;
            calcAlısKdv.DataBindings[0].FormatString = "%###";

            calcSatısKdv.DataBindings.Add("Text", _entity, "SatisKdv");
            calcSatısKdv.DataBindings[0].FormattingEnabled = true;
            calcSatısKdv.DataBindings[0].FormatString = "%###";

            calcMaxStok.DataBindings.Add("Text", _entity, "MaxStokMiktari");
            calcMaxStok.DataBindings[0].FormattingEnabled = true;
            calcMaxStok.DataBindings[0].FormatString = "N3";

            calcMinStok.DataBindings.Add("Text", _entity, "MinStokMiktari");
            calcMinStok.DataBindings[0].FormattingEnabled = true;
            calcMinStok.DataBindings[0].FormatString = "N3";
           

            calcSatısFiyati1.DataBindings.Add("Text", _entity, "SatisFiyati1");
            calcSatısFiyati1.DataBindings[0].FormattingEnabled = true;
            calcSatısFiyati1.DataBindings[0].FormatString = "C2";

            calcSatısFiyati2.DataBindings.Add("Text", _entity, "SatisFiyati2");
            calcSatısFiyati2.DataBindings[0].FormattingEnabled = true;
            calcSatısFiyati2.DataBindings[0].FormatString = "C2";

            calcSatısFiyati3.DataBindings.Add("Text", _entity, "SatisFiyati3");
            calcSatısFiyati3.DataBindings[0].FormattingEnabled = true;
            calcSatısFiyati3.DataBindings[0].FormatString = "C2";
        }

        private void labelControl21_Click(object sender, EventArgs e)
        {

        }

        private void FrmStokİslem_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            stokdal.AddOrUpdate(context, _entity);
            
                stokdal.save(context);
                this.Close();
            
            
      
            
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
