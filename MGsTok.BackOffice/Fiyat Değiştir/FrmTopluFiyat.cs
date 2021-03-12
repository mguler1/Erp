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
using MGsTok.BackOffice.Stok;
using MGsTok.Entities.Contex;
using MGsTok.Entities.DataAccess;
using System.Data.Entity;

namespace MGsTok.BackOffice.Fiyat_Değiştir
{
    public partial class FrmTopluFiyat : DevExpress.XtraEditors.XtraForm
    {
        MGsTOKContex context = new MGsTOKContex();
        StokDal stokdal = new StokDal();
        public FrmTopluFiyat()
        {
            InitializeComponent();
            listele();

        }
        void listele()
        {
            gridControl1.DataSource = context.Stoklar.Local.ToBindingList();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmStokSec sec = new FrmStokSec();
            sec.ShowDialog();
            if (sec.secildi)
            {
                foreach (var itemStok in sec.secilen)
                {
                    stokdal.AddOrUpdate(context, itemStok);
                }
            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            stokdal.save(context);
            listele();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var secilen = gridView1.GetFocusedRowCellValue(colStokKodu).ToString();
            var result = stokdal.GetByFilter(context, c => c.StokKodu == secilen);
            context.Entry(result).State = EntityState.Detached;//gridviewden çıkart databaseden silme
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount==0)
            {
                MessageBox.Show("Seçilen Bir Stok Bulunamadı");
                return;
            }
            FrmFiyatDegistir frm = new FrmFiyatDegistir();
            frm.ShowDialog();
            if (frm.secildi)
            {
                foreach (var itemDegistir in frm.list)
                {
                    if (itemDegistir.Degistir)
                    {
                        for (int i = 0; i < gridView1.RowCount; i++)
                        {
                            decimal kolondeger = 0;
                            decimal degisen = 0;
                            kolondeger = Convert.ToDecimal(gridView1.GetRowCellValue(i, itemDegistir.kolonAdi));
                            if (itemDegistir.DegisimTuru=="Yüzde")
                            {
                                degisen =itemDegistir.DegisimYonu=="Arttır"? kolondeger + kolondeger / 100 * itemDegistir.Degeri: kolondeger - kolondeger / 100 * itemDegistir.Degeri;
                            }
                            else
                            {
                                degisen = itemDegistir.DegisimYonu == "Arttır" ? kolondeger +itemDegistir.Degeri: kolondeger - itemDegistir.Degeri / 100 * itemDegistir.Degeri;

                            }
                            gridView1.SetRowCellValue(i, itemDegistir.kolonAdi, degisen);
                        }
                    }
                }
            }
        }
    }
}