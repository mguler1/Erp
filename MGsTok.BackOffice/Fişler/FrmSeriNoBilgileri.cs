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

namespace MGsTok.BackOffice.Fişler
{
    public partial class FrmSeriNoBilgileri : DevExpress.XtraEditors.XtraForm
    {
        public string veriSeriNo;
        public FrmSeriNoBilgileri(string veri)
        {
            InitializeComponent();
            if (veri!=null)
            {
                string[] veriLİstesi = veri.Split(new[] { System.Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);//boş kayıt dönmesini engelledim
                foreach (var item in veriLİstesi)
                {
                    listBoxControl1.Items.Add(item);
                }
            }
           
        }
        void KayıtAc()
        {
            btnYeni.Enabled = false;
            btnSil.Enabled = false;
            btnKaydet.Enabled = true;
            btnVazgeç.Enabled = true;
            textEdit1.Focus();
        }
        void KayıtKapat()
        {
            btnYeni.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
            btnVazgeç.Enabled = false;
            textEdit1.Text = null;
        }
        private void FrmSeriNoBilgileri_Load(object sender, EventArgs e)
        {

        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            KayıtAc();
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            listBoxControl1.Items.Remove(listBoxControl1.SelectedItems);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            listBoxControl1.Items.Add(textEdit1.Text);
            KayıtKapat();
        }

        private void btnVazgeç_Click(object sender, EventArgs e)
        {
            KayıtKapat();
        }

        private void FrmSeriNoBilgileri_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (listBoxControl1.Items.Count!=0)
            {
                foreach (var item in listBoxControl1.Items)
                {
                    veriSeriNo += item + System.Environment.NewLine;
                }
            }
          
        }
    }
}