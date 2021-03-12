namespace MGsTok.BackOffice.Raporlar.Fatura_ve_Fiş
{
    partial class rptFatura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.colStokAdi = new DevExpress.XtraReports.UI.XRTableCell();
            this.colMiktar = new DevExpress.XtraReports.UI.XRTableCell();
            this.colBirimFiyat = new DevExpress.XtraReports.UI.XRTableCell();
            this.colToplamTutar = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.lblAdres = new DevExpress.XtraReports.UI.XRLabel();
            this.lblCariAdi = new DevExpress.XtraReports.UI.XRLabel();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.lblAraToplam = new DevExpress.XtraReports.UI.XRLabel();
            this.colToplamKdv = new DevExpress.XtraReports.UI.XRLabel();
            this.colGenelToplam = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.Detail.HeightF = 20.83333F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable1
            // 
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(535.4167F, 18.75F);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.colStokAdi,
            this.colMiktar,
            this.colBirimFiyat,
            this.colToplamTutar});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 0.75D;
            // 
            // colStokAdi
            // 
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.Text = "Stok Adı";
            this.colStokAdi.Weight = 1.78125D;
            // 
            // colMiktar
            // 
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.Text = "Miktar";
            this.colMiktar.Weight = 0.76041671752929685D;
            // 
            // colBirimFiyat
            // 
            this.colBirimFiyat.Name = "colBirimFiyat";
            this.colBirimFiyat.Text = "Birim Fiyat";
            this.colBirimFiyat.Weight = 1.3229167175292971D;
            // 
            // colToplamTutar
            // 
            this.colToplamTutar.Name = "colToplamTutar";
            this.colToplamTutar.Text = "Toplam Tutar";
            this.colToplamTutar.Weight = 1.4895834350585937D;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 100F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 100F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblAdres,
            this.lblCariAdi});
            this.ReportHeader.HeightF = 190.625F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // lblAdres
            // 
            this.lblAdres.LocationFloat = new DevExpress.Utils.PointFloat(502.0833F, 45.79166F);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblAdres.SizeF = new System.Drawing.SizeF(137.9166F, 68.83332F);
            this.lblAdres.Text = "Adres";
            // 
            // lblCariAdi
            // 
            this.lblCariAdi.LocationFloat = new DevExpress.Utils.PointFloat(502.0833F, 10.00001F);
            this.lblCariAdi.Name = "lblCariAdi";
            this.lblCariAdi.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblCariAdi.SizeF = new System.Drawing.SizeF(137.9166F, 23F);
            this.lblCariAdi.Text = "CariAdi";
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel4,
            this.colGenelToplam,
            this.colToplamKdv,
            this.lblAraToplam});
            this.PageFooter.HeightF = 100F;
            this.PageFooter.Name = "PageFooter";
            // 
            // lblAraToplam
            // 
            this.lblAraToplam.LocationFloat = new DevExpress.Utils.PointFloat(502.0833F, 0F);
            this.lblAraToplam.Name = "lblAraToplam";
            this.lblAraToplam.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblAraToplam.SizeF = new System.Drawing.SizeF(137.9166F, 23F);
            this.lblAraToplam.Text = "Ara Toplam";
            // 
            // colToplamKdv
            // 
            this.colToplamKdv.LocationFloat = new DevExpress.Utils.PointFloat(502.0833F, 23.00002F);
            this.colToplamKdv.Name = "colToplamKdv";
            this.colToplamKdv.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.colToplamKdv.SizeF = new System.Drawing.SizeF(137.9166F, 23F);
            this.colToplamKdv.Text = "Toplam Kdv";
            // 
            // colGenelToplam
            // 
            this.colGenelToplam.LocationFloat = new DevExpress.Utils.PointFloat(502.0833F, 46.00003F);
            this.colGenelToplam.Name = "colGenelToplam";
            this.colGenelToplam.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.colGenelToplam.SizeF = new System.Drawing.SizeF(137.9166F, 23F);
            this.colGenelToplam.Text = "Genel Toplam";
            // 
            // xrLabel4
            // 
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(502.0833F, 69.00005F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(137.9166F, 23F);
            this.xrLabel4.Text = "CariAdi";
            // 
            // rptFatura
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.PageFooter});
            this.Version = "17.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRLabel lblAdres;
        private DevExpress.XtraReports.UI.XRLabel lblCariAdi;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell colStokAdi;
        private DevExpress.XtraReports.UI.XRTableCell colMiktar;
        private DevExpress.XtraReports.UI.XRTableCell colBirimFiyat;
        private DevExpress.XtraReports.UI.XRTableCell colToplamTutar;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel colGenelToplam;
        private DevExpress.XtraReports.UI.XRLabel colToplamKdv;
        private DevExpress.XtraReports.UI.XRLabel lblAraToplam;
    }
}
