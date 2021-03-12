namespace MGsTok.BackOffice.Kasa
{
    partial class FrmKasa
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKasa));
            this.filterControl1 = new DevExpress.XtraEditors.FilterControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.colId = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colId = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colKasaKodu = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colKasaKodu = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colKasaAdi = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colKasaAdi = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colYetkiliKodu = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colYetkiliKodu = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colYetkiliAdi = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colYetkiliAdi = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colAciklama = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colAciklama = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colKasaGiris = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colKasaGiris = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colKasaCıkıs = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colKasaCıkıs = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colBakiye = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colBakiye = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKasaHareket = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnKasaAra = new DevExpress.XtraEditors.SimpleButton();
            this.btnKasaGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnKasaSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKasaDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnKasaEkle = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colKasaKodu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colKasaAdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colYetkiliKodu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colYetkiliAdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colAciklama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colKasaGiris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colKasaCıkıs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colBakiye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // filterControl1
            // 
            this.filterControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.filterControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterControl1.Location = new System.Drawing.Point(0, 0);
            this.filterControl1.Name = "filterControl1";
            this.filterControl1.Size = new System.Drawing.Size(1339, 683);
            this.filterControl1.SourceControl = this.gridControl1;
            this.filterControl1.TabIndex = 0;
            this.filterControl1.Text = "filterControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 235);
            this.gridControl1.MainView = this.layoutView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1339, 337);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1});
            // 
            // layoutView1
            // 
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colId,
            this.colKasaKodu,
            this.colKasaAdi,
            this.colYetkiliKodu,
            this.colYetkiliAdi,
            this.colAciklama,
            this.colKasaGiris,
            this.colKasaCıkıs,
            this.colBakiye});
            this.layoutView1.GridControl = this.gridControl1;
            this.layoutView1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colId});
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.LayoutViewField = this.layoutViewField_colId;
            this.colId.Name = "colId";
            // 
            // layoutViewField_colId
            // 
            this.layoutViewField_colId.EditorPreferredWidth = 137;
            this.layoutViewField_colId.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colId.Name = "layoutViewField_colId";
            this.layoutViewField_colId.Size = new System.Drawing.Size(203, 24);
            this.layoutViewField_colId.TextSize = new System.Drawing.Size(58, 20);
            // 
            // colKasaKodu
            // 
            this.colKasaKodu.Caption = "Kasa Kodu";
            this.colKasaKodu.FieldName = "KasaKodu";
            this.colKasaKodu.LayoutViewField = this.layoutViewField_colKasaKodu;
            this.colKasaKodu.Name = "colKasaKodu";
            // 
            // layoutViewField_colKasaKodu
            // 
            this.layoutViewField_colKasaKodu.EditorPreferredWidth = 137;
            this.layoutViewField_colKasaKodu.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colKasaKodu.Name = "layoutViewField_colKasaKodu";
            this.layoutViewField_colKasaKodu.Size = new System.Drawing.Size(203, 24);
            this.layoutViewField_colKasaKodu.TextSize = new System.Drawing.Size(58, 13);
            // 
            // colKasaAdi
            // 
            this.colKasaAdi.Caption = "Kasa Adı";
            this.colKasaAdi.FieldName = "KasaAdi";
            this.colKasaAdi.LayoutViewField = this.layoutViewField_colKasaAdi;
            this.colKasaAdi.Name = "colKasaAdi";
            // 
            // layoutViewField_colKasaAdi
            // 
            this.layoutViewField_colKasaAdi.EditorPreferredWidth = 137;
            this.layoutViewField_colKasaAdi.Location = new System.Drawing.Point(0, 24);
            this.layoutViewField_colKasaAdi.Name = "layoutViewField_colKasaAdi";
            this.layoutViewField_colKasaAdi.Size = new System.Drawing.Size(203, 24);
            this.layoutViewField_colKasaAdi.TextSize = new System.Drawing.Size(58, 13);
            // 
            // colYetkiliKodu
            // 
            this.colYetkiliKodu.Caption = "Yetkili Kodu";
            this.colYetkiliKodu.FieldName = "YetkiliKodu";
            this.colYetkiliKodu.LayoutViewField = this.layoutViewField_colYetkiliKodu;
            this.colYetkiliKodu.Name = "colYetkiliKodu";
            // 
            // layoutViewField_colYetkiliKodu
            // 
            this.layoutViewField_colYetkiliKodu.EditorPreferredWidth = 137;
            this.layoutViewField_colYetkiliKodu.Location = new System.Drawing.Point(0, 48);
            this.layoutViewField_colYetkiliKodu.Name = "layoutViewField_colYetkiliKodu";
            this.layoutViewField_colYetkiliKodu.Size = new System.Drawing.Size(203, 24);
            this.layoutViewField_colYetkiliKodu.TextSize = new System.Drawing.Size(58, 13);
            // 
            // colYetkiliAdi
            // 
            this.colYetkiliAdi.Caption = "Yetkili Adı";
            this.colYetkiliAdi.FieldName = "YetkiliAdi";
            this.colYetkiliAdi.LayoutViewField = this.layoutViewField_colYetkiliAdi;
            this.colYetkiliAdi.Name = "colYetkiliAdi";
            // 
            // layoutViewField_colYetkiliAdi
            // 
            this.layoutViewField_colYetkiliAdi.EditorPreferredWidth = 137;
            this.layoutViewField_colYetkiliAdi.Location = new System.Drawing.Point(0, 72);
            this.layoutViewField_colYetkiliAdi.Name = "layoutViewField_colYetkiliAdi";
            this.layoutViewField_colYetkiliAdi.Size = new System.Drawing.Size(203, 24);
            this.layoutViewField_colYetkiliAdi.TextSize = new System.Drawing.Size(58, 13);
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.LayoutViewField = this.layoutViewField_colAciklama;
            this.colAciklama.Name = "colAciklama";
            // 
            // layoutViewField_colAciklama
            // 
            this.layoutViewField_colAciklama.EditorPreferredWidth = 137;
            this.layoutViewField_colAciklama.Location = new System.Drawing.Point(0, 96);
            this.layoutViewField_colAciklama.Name = "layoutViewField_colAciklama";
            this.layoutViewField_colAciklama.Size = new System.Drawing.Size(203, 24);
            this.layoutViewField_colAciklama.TextSize = new System.Drawing.Size(58, 13);
            // 
            // colKasaGiris
            // 
            this.colKasaGiris.Caption = "Kasa Giriş";
            this.colKasaGiris.DisplayFormat.FormatString = "C2";
            this.colKasaGiris.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKasaGiris.FieldName = "KasaGiris";
            this.colKasaGiris.LayoutViewField = this.layoutViewField_colKasaGiris;
            this.colKasaGiris.Name = "colKasaGiris";
            // 
            // layoutViewField_colKasaGiris
            // 
            this.layoutViewField_colKasaGiris.EditorPreferredWidth = 137;
            this.layoutViewField_colKasaGiris.Location = new System.Drawing.Point(0, 120);
            this.layoutViewField_colKasaGiris.Name = "layoutViewField_colKasaGiris";
            this.layoutViewField_colKasaGiris.Size = new System.Drawing.Size(203, 24);
            this.layoutViewField_colKasaGiris.TextSize = new System.Drawing.Size(58, 13);
            // 
            // colKasaCıkıs
            // 
            this.colKasaCıkıs.Caption = "Kasa Çıkış";
            this.colKasaCıkıs.DisplayFormat.FormatString = "C2";
            this.colKasaCıkıs.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKasaCıkıs.FieldName = "KasaCikis";
            this.colKasaCıkıs.LayoutViewField = this.layoutViewField_colKasaCıkıs;
            this.colKasaCıkıs.Name = "colKasaCıkıs";
            // 
            // layoutViewField_colKasaCıkıs
            // 
            this.layoutViewField_colKasaCıkıs.EditorPreferredWidth = 137;
            this.layoutViewField_colKasaCıkıs.Location = new System.Drawing.Point(0, 144);
            this.layoutViewField_colKasaCıkıs.Name = "layoutViewField_colKasaCıkıs";
            this.layoutViewField_colKasaCıkıs.Size = new System.Drawing.Size(203, 24);
            this.layoutViewField_colKasaCıkıs.TextSize = new System.Drawing.Size(58, 13);
            // 
            // colBakiye
            // 
            this.colBakiye.Caption = "Bakiye";
            this.colBakiye.DisplayFormat.FormatString = "C2";
            this.colBakiye.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBakiye.FieldName = "Bakiye";
            this.colBakiye.LayoutViewField = this.layoutViewField_colBakiye;
            this.colBakiye.Name = "colBakiye";
            // 
            // layoutViewField_colBakiye
            // 
            this.layoutViewField_colBakiye.EditorPreferredWidth = 137;
            this.layoutViewField_colBakiye.Location = new System.Drawing.Point(0, 168);
            this.layoutViewField_colBakiye.Name = "layoutViewField_colBakiye";
            this.layoutViewField_colBakiye.Size = new System.Drawing.Size(203, 24);
            this.layoutViewField_colBakiye.TextSize = new System.Drawing.Size(58, 13);
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colKasaKodu,
            this.layoutViewField_colKasaAdi,
            this.layoutViewField_colYetkiliKodu,
            this.layoutViewField_colYetkiliAdi,
            this.layoutViewField_colAciklama,
            this.layoutViewField_colKasaGiris,
            this.layoutViewField_colKasaCıkıs,
            this.layoutViewField_colBakiye});
            this.layoutViewCard1.Name = "layoutViewCard1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKasaHareket);
            this.groupControl1.Controls.Add(this.btnKasaAra);
            this.groupControl1.Controls.Add(this.btnKasaGuncelle);
            this.groupControl1.Controls.Add(this.btnKasaSil);
            this.groupControl1.Controls.Add(this.btnKasaDuzenle);
            this.groupControl1.Controls.Add(this.btnKasaEkle);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 572);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1339, 111);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Menü";
            // 
            // btnKasaHareket
            // 
            this.btnKasaHareket.ImageOptions.ImageIndex = 6;
            this.btnKasaHareket.ImageOptions.ImageList = this.ımageList1;
            this.btnKasaHareket.Location = new System.Drawing.Point(297, 34);
            this.btnKasaHareket.Name = "btnKasaHareket";
            this.btnKasaHareket.Size = new System.Drawing.Size(89, 54);
            this.btnKasaHareket.TabIndex = 1;
            this.btnKasaHareket.Text = "KASA \r\nHAREKET";
            this.btnKasaHareket.Click += new System.EventHandler(this.btnKasaHareket_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "add.png");
            this.ımageList1.Images.SetKeyName(1, "delete.png");
            this.ımageList1.Images.SetKeyName(2, "funnel.png");
            this.ımageList1.Images.SetKeyName(3, "funnel_delete.png");
            this.ımageList1.Images.SetKeyName(4, "KasaDuzenle.png");
            this.ımageList1.Images.SetKeyName(5, "KasaEkle.png");
            this.ımageList1.Images.SetKeyName(6, "KasaHareket.png");
            this.ımageList1.Images.SetKeyName(7, "KasaSil.png");
            this.ımageList1.Images.SetKeyName(8, "pencil.png");
            this.ımageList1.Images.SetKeyName(9, "refresh.png");
            this.ımageList1.Images.SetKeyName(10, "replace2.png");
            this.ımageList1.Images.SetKeyName(11, "safe.png");
            this.ımageList1.Images.SetKeyName(12, "view.png");
            this.ımageList1.Images.SetKeyName(13, "folder_out.png");
            // 
            // btnKasaAra
            // 
            this.btnKasaAra.ImageOptions.ImageIndex = 12;
            this.btnKasaAra.ImageOptions.ImageList = this.ımageList1;
            this.btnKasaAra.Location = new System.Drawing.Point(494, 34);
            this.btnKasaAra.Name = "btnKasaAra";
            this.btnKasaAra.Size = new System.Drawing.Size(89, 54);
            this.btnKasaAra.TabIndex = 0;
            this.btnKasaAra.Text = "ARA";
            this.btnKasaAra.Click += new System.EventHandler(this.btnKasaAra_Click);
            // 
            // btnKasaGuncelle
            // 
            this.btnKasaGuncelle.ImageOptions.ImageIndex = 10;
            this.btnKasaGuncelle.ImageOptions.ImageList = this.ımageList1;
            this.btnKasaGuncelle.Location = new System.Drawing.Point(392, 34);
            this.btnKasaGuncelle.Name = "btnKasaGuncelle";
            this.btnKasaGuncelle.Size = new System.Drawing.Size(96, 54);
            this.btnKasaGuncelle.TabIndex = 0;
            this.btnKasaGuncelle.Text = " GÜNCELLE";
            this.btnKasaGuncelle.Click += new System.EventHandler(this.btnKasaGuncelle_Click);
            // 
            // btnKasaSil
            // 
            this.btnKasaSil.ImageOptions.ImageIndex = 7;
            this.btnKasaSil.ImageOptions.ImageList = this.ımageList1;
            this.btnKasaSil.Location = new System.Drawing.Point(202, 34);
            this.btnKasaSil.Name = "btnKasaSil";
            this.btnKasaSil.Size = new System.Drawing.Size(89, 54);
            this.btnKasaSil.TabIndex = 0;
            this.btnKasaSil.Text = "SİL";
            this.btnKasaSil.Click += new System.EventHandler(this.btnKasaSil_Click);
            // 
            // btnKasaDuzenle
            // 
            this.btnKasaDuzenle.ImageOptions.ImageIndex = 4;
            this.btnKasaDuzenle.ImageOptions.ImageList = this.ımageList1;
            this.btnKasaDuzenle.Location = new System.Drawing.Point(107, 34);
            this.btnKasaDuzenle.Name = "btnKasaDuzenle";
            this.btnKasaDuzenle.Size = new System.Drawing.Size(89, 54);
            this.btnKasaDuzenle.TabIndex = 0;
            this.btnKasaDuzenle.Text = "DÜZENLE";
            this.btnKasaDuzenle.Click += new System.EventHandler(this.btnKasaDuzenle_Click);
            // 
            // btnKasaEkle
            // 
            this.btnKasaEkle.ImageOptions.ImageIndex = 5;
            this.btnKasaEkle.ImageOptions.ImageList = this.ımageList1;
            this.btnKasaEkle.Location = new System.Drawing.Point(12, 34);
            this.btnKasaEkle.Name = "btnKasaEkle";
            this.btnKasaEkle.Size = new System.Drawing.Size(89, 54);
            this.btnKasaEkle.TabIndex = 0;
            this.btnKasaEkle.Text = "EKLE";
            this.btnKasaEkle.Click += new System.EventHandler(this.btnKasaEkle_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton3.ImageOptions.ImageIndex = 13;
            this.simpleButton3.ImageOptions.ImageList = this.ımageList1;
            this.simpleButton3.Location = new System.Drawing.Point(1289, 174);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(42, 34);
            this.simpleButton3.TabIndex = 7;
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.ImageOptions.ImageIndex = 3;
            this.simpleButton2.ImageOptions.ImageList = this.ımageList1;
            this.simpleButton2.Location = new System.Drawing.Point(1233, 174);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(50, 34);
            this.simpleButton2.TabIndex = 8;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.ImageOptions.ImageIndex = 2;
            this.simpleButton1.ImageOptions.ImageList = this.ımageList1;
            this.simpleButton1.Location = new System.Drawing.Point(1173, 174);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(54, 34);
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // FrmKasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 683);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.filterControl1);
            this.Name = "FrmKasa";
            this.Text = "KASALAR";
            this.Load += new System.EventHandler(this.FrmKasa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colKasaKodu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colKasaAdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colYetkiliKodu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colYetkiliAdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colAciklama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colKasaGiris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colKasaCıkıs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colBakiye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.FilterControl filterControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKasaHareket;
        private DevExpress.XtraEditors.SimpleButton btnKasaAra;
        private DevExpress.XtraEditors.SimpleButton btnKasaGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnKasaSil;
        private DevExpress.XtraEditors.SimpleButton btnKasaDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnKasaEkle;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colId;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colId;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colKasaKodu;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colKasaKodu;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colKasaAdi;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colKasaAdi;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colYetkiliKodu;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colYetkiliKodu;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colYetkiliAdi;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colYetkiliAdi;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colAciklama;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colAciklama;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colKasaGiris;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colKasaGiris;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colKasaCıkıs;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colKasaCıkıs;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colBakiye;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colBakiye;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
    }
}