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
using DevExpress.XtraScheduler;
using MGsTok.Entities.Contex;
using System.Data.Entity;

namespace MGsTok.BackOffice.Ajanda
{
    public partial class FrmAjanda : DevExpress.XtraEditors.XtraForm
    {
        MGsTOKContex context = new MGsTOKContex();

        public FrmAjanda()
        {
            InitializeComponent();
            
            context.EFAppointments.Load();
            context.EFResources.Load();
            schedulerControl1.DataStorage.Appointments.DataSource = context.EFAppointments.Local.ToBindingList();
            schedulerControl1.DataStorage.Resources.DataSource = context.EFResources.Local.ToBindingList();

        }

        private void FrmAjanda_Load(object sender, EventArgs e)
        {

        }

        private void FrmAjanda_FormClosing(object sender, FormClosingEventArgs e)
        {
            context.SaveChanges();
        }
    }
}