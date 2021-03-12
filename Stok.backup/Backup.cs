using MGsTok.Entities.Contex;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Stok.backup
{
    public partial class Backup : DevExpress.XtraEditors.XtraForm
    {
        MGsTOKContex context = new MGsTOKContex();
        public Backup()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string sqlCumle = $"USE MGsTok;BACKUP DATABASE MGsTok TO DISK='{txtYedekKonum + "\\MGsTokYedek.bak"}'";
            context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, sqlCumle);

        }

        private void txtYedekKonum_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtYedekKonum_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FolderBrowserDialog form = new FolderBrowserDialog();
            if (form.ShowDialog()==DialogResult.OK)
            {
                txtYedekKonum.Text = form.SelectedPath;

            }
                
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog geriyukle = new OpenFileDialog();
            geriyukle.Filter = "Yedekleme *.bak|*.bak";
            if (geriyukle.ShowDialog()==DialogResult.OK)
            {
                string sqlCumle = $"USE master;ALTER DATABASE MGsTok SET SINGLE_USER WITH ROLLBACK IMMEDIATE;ALTER DATABASE MGsTok SET READ_ONLY;RESTORE DATABASE MGsTok FROM DISK='{geriyukle.FileName}'";
                context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, sqlCumle);
            }
        }
    }
}
