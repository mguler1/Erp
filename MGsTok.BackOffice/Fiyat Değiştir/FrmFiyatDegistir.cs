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
using MGsTok.Entities.Tables.Other_Tables;

namespace MGsTok.BackOffice.Fiyat_Değiştir
{
    public partial class FrmFiyatDegistir : DevExpress.XtraEditors.XtraForm
    {
        public List<FiyatDegistir> list;
        public bool secildi = false;
        public FrmFiyatDegistir()
        {
            InitializeComponent();

            list = new List<FiyatDegistir>
            {
                  new FiyatDegistir
                  {
                      FiyatTuru="AlışFiyati-1",
                      kolonAdi="AlişFiyati1",
                      Degistir=false,
                      DegisimTuru="Yüzde",
                      DegisimYonu="Arttır",
                      Degeri=0
                  },
                   new FiyatDegistir
                  {
                      FiyatTuru="AlışFiyati-2",
                      kolonAdi="AlişFiyati2",
                      Degistir=false,
                      DegisimTuru="Yüzde",
                      DegisimYonu="Arttır",
                      Degeri=0
                  },
                    new FiyatDegistir
                  {
                      FiyatTuru="AlışFiyati-3",
                      kolonAdi="AlişFiyati3",
                      Degistir=false,
                      DegisimTuru="Yüzde",
                      DegisimYonu="Arttır",
                      Degeri=0
                  },
                     new FiyatDegistir
                  {
                      FiyatTuru="SatışFiyati-1",
                      kolonAdi="SatişFiyati1",
                      Degistir=false,
                      DegisimTuru="Yüzde",
                      DegisimYonu="Arttır",
                      Degeri=0
                  },
                        new FiyatDegistir
                  {
                      FiyatTuru="SatışFiyati-2",
                      kolonAdi="SatişFiyati2",
                      Degistir=false,
                      DegisimTuru="Yüzde",
                      DegisimYonu="Arttır",
                      Degeri=0
                  },
                           new FiyatDegistir
                  {
                      FiyatTuru="SatışFiyati-3",
                      kolonAdi="SatişFiyati3",
                      Degistir=false,
                      DegisimTuru="Yüzde",
                      DegisimYonu="Arttır",
                      Degeri=0
                  },
        };
            gridControl1.DataSource = list;

        }

        private void FrmFiyatDegistir_Load(object sender, EventArgs e)
        {

        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
        
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            secildi = true;
            this.Close();
        }
    }
}