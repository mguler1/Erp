using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MGsTok.Entities.Contex;
using MGsTok.Entities.DataAccess;
using MGsTok.Entities.Tables;

namespace MGsTok.BackOffice
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
            using (var contex=new MGsTOKContex())
            {
                contex.Database.CreateIfNotExists();//veritabanı varsa oluşturma yoksa oluştur.
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MGsTOKContex contex = new MGsTOKContex();

            CariDal cd = new CariDal();

            Cari entity = new Cari()
            {
                CariKodu = "123456",
                CariAdi="Deneme",
                YetkiliKisi="Erhan",
                FaturaUnvani="deneem"
        
        };
            cd.AddOrUpdate(contex,entity);
            cd.save(contex);
        }
    }
}
