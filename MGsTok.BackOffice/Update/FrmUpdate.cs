using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Update
{
    public partial class FrmUpdate : DevExpress.XtraEditors.XtraForm
    {
        public static bool calısıyor(string program)
        {
            return Process.GetProcessesByName(program).Length > 0;
        }
        public FrmUpdate()
        {
            InitializeComponent();
            if (calısıyor("MGsTok.BackOffice"))
            {
                if (MessageBox.Show("Açık olan Uygulamalar Kapatılacaktır","Uyarı",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    foreach (var process in Process.GetProcessesByName("MGsTok.BackOffice"))
                    {
                        process.CloseMainWindow();
                        process.Kill();
                    }
                }
            }
        }

        private void FrmUpdate_Load(object sender, EventArgs e)
        {

        }
    }
}
