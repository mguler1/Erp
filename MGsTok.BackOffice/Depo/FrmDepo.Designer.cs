namespace MGsTok.BackOffice.Depo
{
    partial class FrmDepo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepo));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblBaslık = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnDepoHareket = new DevExpress.XtraEditors.SimpleButton();
            this.btnDepoAra = new DevExpress.XtraEditors.SimpleButton();
            this.btnDepoGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnDepoSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnDepoDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnDepoEkle = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.filterControl1 = new DevExpress.XtraEditors.FilterControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepoKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepoAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYetkiliKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYetkiliAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepoIl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepoIlce = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSemt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdresi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "add.png");
            this.ımageList1.Images.SetKeyName(1, "bilgi.png");
            this.ımageList1.Images.SetKeyName(2, "delete.png");
            this.ımageList1.Images.SetKeyName(3, "düzenle.png");
            this.ımageList1.Images.SetKeyName(4, "ekle.png");
            this.ımageList1.Images.SetKeyName(5, "factory.png");
            this.ımageList1.Images.SetKeyName(6, "folder_out.png");
            this.ımageList1.Images.SetKeyName(7, "funnel.png");
            this.ımageList1.Images.SetKeyName(8, "funnel_delete.png");
            this.ımageList1.Images.SetKeyName(9, "hareket.png");
            this.ımageList1.Images.SetKeyName(10, "information.png");
            this.ımageList1.Images.SetKeyName(11, "pencil.png");
            this.ımageList1.Images.SetKeyName(12, "refresh.png");
            this.ımageList1.Images.SetKeyName(13, "replace2.png");
            this.ımageList1.Images.SetKeyName(14, "sil.png");
            this.ımageList1.Images.SetKeyName(15, "view.png");
            // 
            // lblBaslık
            // 
            this.lblBaslık.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslık.Appearance.Image = global::MGsTok.BackOffice.Properties.Resources.user;
            this.lblBaslık.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBaslık.Appearance.Options.UseFont = true;
            this.lblBaslık.Appearance.Options.UseImage = true;
            this.lblBaslık.Appearance.Options.UseImageAlign = true;
            this.lblBaslık.AppearancePressed.Image = ((System.Drawing.Image)(resources.GetObject("lblBaslık.AppearancePressed.Image")));
            this.lblBaslık.AppearancePressed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBaslık.AppearancePressed.Options.UseImage = true;
            this.lblBaslık.AppearancePressed.Options.UseImageAlign = true;
            this.lblBaslık.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBaslık.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaslık.Location = new System.Drawing.Point(0, 0);
            this.lblBaslık.Name = "lblBaslık";
            this.lblBaslık.Size = new System.Drawing.Size(1323, 38);
            this.lblBaslık.TabIndex = 6;
            this.lblBaslık.Text = "             DEPO KARTLARI";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnDepoHareket);
            this.groupControl1.Controls.Add(this.btnDepoAra);
            this.groupControl1.Controls.Add(this.btnDepoGuncelle);
            this.groupControl1.Controls.Add(this.btnDepoSil);
            this.groupControl1.Controls.Add(this.btnDepoDuzenle);
            this.groupControl1.Controls.Add(this.btnDepoEkle);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 264);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1323, 100);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Menü";
            // 
            // btnDepoHareket
            // 
            this.btnDepoHareket.ImageOptions.ImageIndex = 9;
            this.btnDepoHareket.ImageOptions.ImageList = this.ımageList1;
            this.btnDepoHareket.Location = new System.Drawing.Point(297, 34);
            this.btnDepoHareket.Name = "btnDepoHareket";
            this.btnDepoHareket.Size = new System.Drawing.Size(89, 54);
            this.btnDepoHareket.TabIndex = 1;
            this.btnDepoHareket.Text = "DEPO \r\nHAREKET";
            this.btnDepoHareket.Click += new System.EventHandler(this.btnDepoHareket_Click);
            // 
            // btnDepoAra
            // 
            this.btnDepoAra.ImageOptions.ImageIndex = 15;
            this.btnDepoAra.ImageOptions.ImageList = this.ımageList1;
            this.btnDepoAra.Location = new System.Drawing.Point(494, 34);
            this.btnDepoAra.Name = "btnDepoAra";
            this.btnDepoAra.Size = new System.Drawing.Size(89, 54);
            this.btnDepoAra.TabIndex = 0;
            this.btnDepoAra.Text = "ARA";
            // 
            // btnDepoGuncelle
            // 
            this.btnDepoGuncelle.ImageOptions.ImageIndex = 12;
            this.btnDepoGuncelle.ImageOptions.ImageList = this.ımageList1;
            this.btnDepoGuncelle.Location = new System.Drawing.Point(392, 34);
            this.btnDepoGuncelle.Name = "btnDepoGuncelle";
            this.btnDepoGuncelle.Size = new System.Drawing.Size(96, 54);
            this.btnDepoGuncelle.TabIndex = 0;
            this.btnDepoGuncelle.Text = " GÜNCELLE";
            this.btnDepoGuncelle.Click += new System.EventHandler(this.btnDepoGuncelle_Click);
            // 
            // btnDepoSil
            // 
            this.btnDepoSil.ImageOptions.ImageIndex = 14;
            this.btnDepoSil.ImageOptions.ImageList = this.ımageList1;
            this.btnDepoSil.Location = new System.Drawing.Point(202, 34);
            this.btnDepoSil.Name = "btnDepoSil";
            this.btnDepoSil.Size = new System.Drawing.Size(89, 54);
            this.btnDepoSil.TabIndex = 0;
            this.btnDepoSil.Text = "SİL";
            this.btnDepoSil.Click += new System.EventHandler(this.btnDepoSil_Click);
            // 
            // btnDepoDuzenle
            // 
            this.btnDepoDuzenle.ImageOptions.ImageIndex = 3;
            this.btnDepoDuzenle.ImageOptions.ImageList = this.ımageList1;
            this.btnDepoDuzenle.Location = new System.Drawing.Point(107, 34);
            this.btnDepoDuzenle.Name = "btnDepoDuzenle";
            this.btnDepoDuzenle.Size = new System.Drawing.Size(89, 54);
            this.btnDepoDuzenle.TabIndex = 0;
            this.btnDepoDuzenle.Text = "DÜZENLE";
            this.btnDepoDuzenle.Click += new System.EventHandler(this.btnDepoDuzenle_Click);
            // 
            // btnDepoEkle
            // 
            this.btnDepoEkle.ImageOptions.ImageIndex = 0;
            this.btnDepoEkle.ImageOptions.ImageList = this.ımageList1;
            this.btnDepoEkle.Location = new System.Drawing.Point(12, 34);
            this.btnDepoEkle.Name = "btnDepoEkle";
            this.btnDepoEkle.Size = new System.Drawing.Size(89, 54);
            this.btnDepoEkle.TabIndex = 0;
            this.btnDepoEkle.Text = "EKLE";
            this.btnDepoEkle.Click += new System.EventHandler(this.btnDepoEkle_Click);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.simpleButton3);
            this.splitContainerControl1.Panel1.Controls.Add(this.simpleButton2);
            this.splitContainerControl1.Panel1.Controls.Add(this.simpleButton1);
            this.splitContainerControl1.Panel1.Controls.Add(this.filterControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1323, 564);
            this.splitContainerControl1.SplitterPosition = 195;
            this.splitContainerControl1.TabIndex = 7;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton3.ImageOptions.ImageIndex = 6;
            this.simpleButton3.ImageOptions.ImageList = this.ımageList1;
            this.simpleButton3.Location = new System.Drawing.Point(1257, 157);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(42, 34);
            this.simpleButton3.TabIndex = 1;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.ImageOptions.ImageIndex = 8;
            this.simpleButton2.ImageOptions.ImageList = this.ımageList1;
            this.simpleButton2.Location = new System.Drawing.Point(1201, 157);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(50, 34);
            this.simpleButton2.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.ImageOptions.ImageIndex = 7;
            this.simpleButton1.ImageOptions.ImageList = this.ımageList1;
            this.simpleButton1.Location = new System.Drawing.Point(1149, 157);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(46, 34);
            this.simpleButton1.TabIndex = 1;
            // 
            // filterControl1
            // 
            this.filterControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.filterControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterControl1.Location = new System.Drawing.Point(0, 0);
            this.filterControl1.Name = "filterControl1";
            this.filterControl1.Size = new System.Drawing.Size(1323, 195);
            this.filterControl1.SourceControl = this.gridControl1;
            this.filterControl1.TabIndex = 0;
            this.filterControl1.Text = "filterControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1323, 264);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colDepoKodu,
            this.colDepoAdi,
            this.colYetkiliKodu,
            this.colYetkiliAdi,
            this.colDepoIl,
            this.colDepoIlce,
            this.colSemt,
            this.colAdresi,
            this.colTelefon,
            this.colAciklama});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            // 
            // colDepoKodu
            // 
            this.colDepoKodu.FieldName = "DepoKodu";
            this.colDepoKodu.Name = "colDepoKodu";
            this.colDepoKodu.OptionsColumn.AllowEdit = false;
            this.colDepoKodu.Visible = true;
            this.colDepoKodu.VisibleIndex = 0;
            // 
            // colDepoAdi
            // 
            this.colDepoAdi.Caption = "Depo Adı";
            this.colDepoAdi.FieldName = "DepoAdi";
            this.colDepoAdi.Name = "colDepoAdi";
            this.colDepoAdi.OptionsColumn.AllowEdit = false;
            this.colDepoAdi.Visible = true;
            this.colDepoAdi.VisibleIndex = 1;
            // 
            // colYetkiliKodu
            // 
            this.colYetkiliKodu.FieldName = "YetkiliKodu";
            this.colYetkiliKodu.Name = "colYetkiliKodu";
            this.colYetkiliKodu.OptionsColumn.AllowEdit = false;
            this.colYetkiliKodu.Visible = true;
            this.colYetkiliKodu.VisibleIndex = 2;
            // 
            // colYetkiliAdi
            // 
            this.colYetkiliAdi.Caption = "Yetkili Adı";
            this.colYetkiliAdi.FieldName = "YetkiliAdi";
            this.colYetkiliAdi.Name = "colYetkiliAdi";
            this.colYetkiliAdi.OptionsColumn.AllowEdit = false;
            this.colYetkiliAdi.Visible = true;
            this.colYetkiliAdi.VisibleIndex = 3;
            // 
            // colDepoIl
            // 
            this.colDepoIl.Caption = "Depo İl";
            this.colDepoIl.FieldName = "DepoIl";
            this.colDepoIl.Name = "colDepoIl";
            this.colDepoIl.OptionsColumn.AllowEdit = false;
            this.colDepoIl.Visible = true;
            this.colDepoIl.VisibleIndex = 4;
            // 
            // colDepoIlce
            // 
            this.colDepoIlce.Caption = "Depo İlçe";
            this.colDepoIlce.FieldName = "DepoIlce";
            this.colDepoIlce.Name = "colDepoIlce";
            this.colDepoIlce.OptionsColumn.AllowEdit = false;
            this.colDepoIlce.Visible = true;
            this.colDepoIlce.VisibleIndex = 5;
            // 
            // colSemt
            // 
            this.colSemt.FieldName = "Semt";
            this.colSemt.Name = "colSemt";
            this.colSemt.OptionsColumn.AllowEdit = false;
            this.colSemt.Visible = true;
            this.colSemt.VisibleIndex = 6;
            // 
            // colAdresi
            // 
            this.colAdresi.FieldName = "Adresi";
            this.colAdresi.Name = "colAdresi";
            this.colAdresi.OptionsColumn.AllowEdit = false;
            this.colAdresi.Visible = true;
            this.colAdresi.VisibleIndex = 7;
            // 
            // colTelefon
            // 
            this.colTelefon.FieldName = "Telefon";
            this.colTelefon.Name = "colTelefon";
            this.colTelefon.OptionsColumn.AllowEdit = false;
            this.colTelefon.Visible = true;
            this.colTelefon.VisibleIndex = 8;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 9;
            // 
            // FrmDepo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 564);
            this.Controls.Add(this.lblBaslık);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FrmDepo";
            this.Text = "DEPO";
            this.Load += new System.EventHandler(this.FrmDepo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.LabelControl lblBaslık;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnDepoHareket;
        private DevExpress.XtraEditors.SimpleButton btnDepoAra;
        private DevExpress.XtraEditors.SimpleButton btnDepoGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnDepoSil;
        private DevExpress.XtraEditors.SimpleButton btnDepoDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnDepoEkle;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.FilterControl filterControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDepoKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colDepoAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colYetkiliKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colYetkiliAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colDepoIl;
        private DevExpress.XtraGrid.Columns.GridColumn colDepoIlce;
        private DevExpress.XtraGrid.Columns.GridColumn colSemt;
        private DevExpress.XtraGrid.Columns.GridColumn colAdresi;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefon;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
    }
}