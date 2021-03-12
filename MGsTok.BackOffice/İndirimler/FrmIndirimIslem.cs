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
using System.Data.Entity;
using MGsTok.BackOffice.Stok;
using MGsTok.Entities.Tables;

namespace MGsTok.BackOffice.İndirimler
{
    public partial class FrmIndirimIslem : DevExpress.XtraEditors.XtraForm
    {
        MGsTOKContex context = new MGsTOKContex();
        IndirimDal indirimdal = new IndirimDal();

        public FrmIndirimIslem()
        {
            InitializeComponent();
            gridControl1.DataSource = context.Indirimler.Local.ToBindingList();
        }

        private void FrmIndirimIslem_Load(object sender, EventArgs e)
        {

        }
        private Indirim stokEkle(Entities.Tables.Stok entity)
        {
            Indirim _entity = new Indirim();
            _entity.StokKodu = entity.StokKodu;
            _entity.Barkod = entity.Barkod;
            _entity.StokAdi = entity.StokAdi;
            return _entity;
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmStokSec form = new FrmStokSec();
            form.ShowDialog();
            if (form.secildi)
            {
                foreach (var itemStok in form.secilen)
                {
                    Indirim _entity = new Indirim();
                    _entity = stokEkle(itemStok);
                    var count = context.Indirimler.Count(c => c.StokKodu == itemStok.StokKodu);
                    if (count !=0)
                    {
                        if (MessageBox.Show("Seçili olan stoğa daha önceden eklenmiş bir indirim vardır Varolan indirimi güncellemek istermisiniz","Uyarı",MessageBoxButtons.YesNo)==DialogResult.Yes)
                        {
                            var secilenID = context.Indirimler.SingleOrDefault(c => c.StokKodu == itemStok.StokKodu);
                            _entity.Id = secilenID.Id;
                            indirimdal.AddOrUpdate(context, _entity);
                        }
                        else
                        {
                            indirimdal.AddOrUpdate(context, _entity);
                        }
                    }
                   
                }
            }
        }

        private void wizardControl1_FinishClick(object sender, CancelEventArgs e)
        {
            foreach (var itemIndirim in context.Indirimler.Local.ToList())
            {
                itemIndirim.Durumu = true;
                itemIndirim.Aciklama = memoEdit1.Text;
                if (checkButton1.Checked)
                {
                    itemIndirim.IndirimTuru="Süresiz";
                }
                itemIndirim.BaslangicTarihi = calendarControl1.DateTime;
                itemIndirim.BitisTarihi = calendarControl2.DateTime;
                itemIndirim.Aciklama = memoEdit1.Text;
                itemIndirim.IndirimTuru = "Belirli Tarihler Arasında ";


            }
            indirimdal.save(context);
        }
    }
}