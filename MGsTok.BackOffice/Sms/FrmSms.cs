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
using System.Net;
using MGsTok.Entities.Tools;

namespace MGsTok.BackOffice.KasaHareketleri
{
    public partial class FrmSms : DevExpress.XtraEditors.XtraForm
    {
        MGsTOKContex context = new MGsTOKContex();
        CariDal caridal = new CariDal();
        List<Entities.Tables.Cari> cariList = new List<Entities.Tables.Cari>();
        public FrmSms()
        {
            InitializeComponent();
        }

        private void FrmSms_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = caridal.CariTelefonlari(context);
            gridControl2.DataSource = cariList;
        }
         
        
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue(colCepTelefonu)!=null)
            {
                cariList.Add(new Entities.Tables.Cari
                {
                    CariKodu = gridView1.GetFocusedRowCellValue(colCariKodu).ToString(),
                    CariAdi=gridView1.GetFocusedRowCellValue(colCariAdi).ToString(),
                   CepTelefonu= gridView1.GetFocusedRowCellValue(colCepTelefonu).ToString()
            });
                gridView2.RefreshData();
            }
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            gridView2.DeleteSelectedRows();
        }

        private void memoEdit1_TextChanged(object sender, EventArgs e)
        {
            label2.Text = memoEdit1.Text.Length.ToString() + "\\" +( memoEdit1.Text.Length / 160+1);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
            string ss = "";
            ss += "<?xml version='1.0' encoding='UTF-8'?>";
            ss += "<mainbody>";
            ss += "<header>";
            ss += "<company dil='TR'>Netgsm</company>";
            ss += "<usercode>Kullanici_adi</usercode>";
            ss += "<password>Sifre</password>";
            ss += "<type>1:n</type>";
            ss += "<msgheader>Baslik</msgheader>";
            ss += "</header>";
            ss += "<body>";
            ss += "<msg>";
            ss += "<![CDATA[Mesaj Metnim]]>";
            ss += "</msg>";
            ss += "<no>051212312312</no>";
            ss += "<no>051212312312</no>";
            ss += "</body>  ";
            ss += "</mainbody>";
            label3.Text = XMLPOST("https://api.netgsm.com.tr/sms/send/xml", ss);
        }
        private string XMLPOST(string PostAddress, string xmlData)
        {
            try
            {
                WebClient wUpload = new WebClient();
                HttpWebRequest request = WebRequest.Create(PostAddress) as HttpWebRequest;
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                Byte[] bPostArray = Encoding.UTF8.GetBytes(xmlData);
                Byte[] bResponse = wUpload.UploadData(PostAddress, "POST", bPostArray);
                Char[] sReturnChars = Encoding.UTF8.GetChars(bResponse);
                string sWebPage = new string(sReturnChars);
                return sWebPage;
            }
            catch
            {
                return "-1";
            }
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            SettingTool ayarlar = new SettingTool();
            ayarlar.AyarDegistir("Sms Ayarları","Kullanıcı Ayarları",textBox1.Text);
            ayarlar.AyarDegistir("Sms Ayarları", "Parola", textBox2.Text);
            ayarlar.Save();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //
        }
    }
}