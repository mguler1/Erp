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
using System.Xml.Linq;
using MGsTok.Entities.Tables.Other_Tables;

namespace MGsTok.BackOffice.Döviz_Kurları
{
    public partial class FrmDovizKurlari : DevExpress.XtraEditors.XtraForm
    {
        public FrmDovizKurlari()
        {
            InitializeComponent();
        }

        private void FrmDovizKurlari_Load(object sender, EventArgs e)
        {
            guncelle();
        }
        private void guncelle()
        {
            using (System.Net.WebClient kurIndir=new System.Net.WebClient())//İnternet olmadığı zaman  null döndürmesin diye 
            {
                kurIndir.DownloadFile("https://www.tcmb.gov.tr/kurlar/today.xml", Application.StartupPath + "\\Kurlar.xml");
            }

            XElement kurlar = XElement.Load(Application.StartupPath + "\\Kurlar.xml");
            List<DovizKurlari> listKurlar = new List<DovizKurlari>();
            foreach (var itemElement in kurlar.Elements().Where(c=>c.Attribute("CurrencyCode").Value!="XDR").ToList())//xml de sonda xdr var boş olduğu çin hata vermekteydi o yüzden where koşuluna ekledim
            {
                listKurlar.Add(new DovizKurlari
                {
                    CurrencyCode = itemElement.Attribute("CurrencyCode").Value,
                    Isim=itemElement.Element("Isim").Value,
                    ForexBuying= itemElement.Element("ForexBuying").Value==""?0: Convert.ToDecimal(itemElement.Element("ForexBuying").Value.Replace(".",",")),
                    ForexSelling = itemElement.Element("ForexSelling").Value == "" ? 0: Convert.ToDecimal(itemElement.Element("ForexSelling").Value.Replace(".", ",")),
                    BanknoteBuying = itemElement.Element("BanknoteBuying").Value == "" ? 0 : Convert.ToDecimal(itemElement.Element("BanknoteBuying").Value.Replace(".", ",")),
                    BanknoteSelling = itemElement.Element("BanknoteSelling").Value == "" ? 0: Convert.ToDecimal(itemElement.Element("BanknoteSelling").Value.Replace(".", ",")),

                });
            }
            gridControl1.DataSource = listKurlar;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            guncelle();
        }
    }
}