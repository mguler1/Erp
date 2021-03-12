namespace MGsTok.BackOffice.Ödeme_Türü
{
    partial class FrmOdemeTuru
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOdemeTuru));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnOdemeHareket = new DevExpress.XtraEditors.SimpleButton();
            this.imgMenu = new System.Windows.Forms.ImageList(this.components);
            this.btnOdemeAra = new DevExpress.XtraEditors.SimpleButton();
            this.btnOdemeGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnOdemeSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnOdemeDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnOdemeEkle = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.filterControl1 = new DevExpress.XtraEditors.FilterControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdemeTuruKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdemeTuruAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnOdemeHareket);
            this.groupControl1.Controls.Add(this.btnOdemeAra);
            this.groupControl1.Controls.Add(this.btnOdemeGuncelle);
            this.groupControl1.Controls.Add(this.btnOdemeSil);
            this.groupControl1.Controls.Add(this.btnOdemeDuzenle);
            this.groupControl1.Controls.Add(this.btnOdemeEkle);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 408);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1277, 100);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Menü";
            // 
            // btnOdemeHareket
            // 
            this.btnOdemeHareket.ImageOptions.ImageIndex = 0;
            this.btnOdemeHareket.ImageOptions.ImageList = this.imgMenu;
            this.btnOdemeHareket.Location = new System.Drawing.Point(297, 34);
            this.btnOdemeHareket.Name = "btnOdemeHareket";
            this.btnOdemeHareket.Size = new System.Drawing.Size(89, 54);
            this.btnOdemeHareket.TabIndex = 1;
            this.btnOdemeHareket.Text = "ÖDEME\r\n HAREKET";
            // 
            // imgMenu
            // 
            this.imgMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgMenu.ImageStream")));
            this.imgMenu.TransparentColor = System.Drawing.Color.Transparent;
            this.imgMenu.Images.SetKeyName(0, "Hareketler.png");
            this.imgMenu.Images.SetKeyName(1, "replace2.png");
            this.imgMenu.Images.SetKeyName(2, "wallet_closed.png");
            this.imgMenu.Images.SetKeyName(3, "wallet_closed_add.png");
            this.imgMenu.Images.SetKeyName(4, "wallet_closed_delete.png");
            this.imgMenu.Images.SetKeyName(5, "wallet_closed_edit.png");
            this.imgMenu.Images.SetKeyName(6, "folder_out.png");
            this.imgMenu.Images.SetKeyName(7, "funnel.png");
            this.imgMenu.Images.SetKeyName(8, "funnel_delete.png");
            this.imgMenu.Images.SetKeyName(9, "view.png");
            // 
            // btnOdemeAra
            // 
            this.btnOdemeAra.ImageOptions.ImageIndex = 9;
            this.btnOdemeAra.ImageOptions.ImageList = this.imgMenu;
            this.btnOdemeAra.Location = new System.Drawing.Point(494, 34);
            this.btnOdemeAra.Name = "btnOdemeAra";
            this.btnOdemeAra.Size = new System.Drawing.Size(89, 54);
            this.btnOdemeAra.TabIndex = 0;
            this.btnOdemeAra.Text = "ARA";
            // 
            // btnOdemeGuncelle
            // 
            this.btnOdemeGuncelle.ImageOptions.ImageIndex = 1;
            this.btnOdemeGuncelle.ImageOptions.ImageList = this.imgMenu;
            this.btnOdemeGuncelle.Location = new System.Drawing.Point(392, 34);
            this.btnOdemeGuncelle.Name = "btnOdemeGuncelle";
            this.btnOdemeGuncelle.Size = new System.Drawing.Size(96, 54);
            this.btnOdemeGuncelle.TabIndex = 0;
            this.btnOdemeGuncelle.Text = " GÜNCELLE";
            this.btnOdemeGuncelle.Click += new System.EventHandler(this.btnOdemeGuncelle_Click);
            // 
            // btnOdemeSil
            // 
            this.btnOdemeSil.ImageOptions.ImageIndex = 4;
            this.btnOdemeSil.ImageOptions.ImageList = this.imgMenu;
            this.btnOdemeSil.Location = new System.Drawing.Point(202, 34);
            this.btnOdemeSil.Name = "btnOdemeSil";
            this.btnOdemeSil.Size = new System.Drawing.Size(89, 54);
            this.btnOdemeSil.TabIndex = 0;
            this.btnOdemeSil.Text = "SİL";
            this.btnOdemeSil.Click += new System.EventHandler(this.btnOdemeSil_Click);
            // 
            // btnOdemeDuzenle
            // 
            this.btnOdemeDuzenle.ImageOptions.ImageIndex = 5;
            this.btnOdemeDuzenle.ImageOptions.ImageList = this.imgMenu;
            this.btnOdemeDuzenle.Location = new System.Drawing.Point(107, 34);
            this.btnOdemeDuzenle.Name = "btnOdemeDuzenle";
            this.btnOdemeDuzenle.Size = new System.Drawing.Size(89, 54);
            this.btnOdemeDuzenle.TabIndex = 0;
            this.btnOdemeDuzenle.Text = "DÜZENLE";
            this.btnOdemeDuzenle.Click += new System.EventHandler(this.btnOdemeDuzenle_Click);
            // 
            // btnOdemeEkle
            // 
            this.btnOdemeEkle.ImageOptions.ImageIndex = 3;
            this.btnOdemeEkle.ImageOptions.ImageList = this.imgMenu;
            this.btnOdemeEkle.Location = new System.Drawing.Point(12, 34);
            this.btnOdemeEkle.Name = "btnOdemeEkle";
            this.btnOdemeEkle.Size = new System.Drawing.Size(89, 54);
            this.btnOdemeEkle.TabIndex = 0;
            this.btnOdemeEkle.Text = "EKLE";
            this.btnOdemeEkle.Click += new System.EventHandler(this.btnOdemeEkle_Click);
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
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1277, 708);
            this.splitContainerControl1.SplitterPosition = 195;
            this.splitContainerControl1.TabIndex = 5;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton3.ImageOptions.ImageIndex = 6;
            this.simpleButton3.ImageOptions.ImageList = this.imgMenu;
            this.simpleButton3.Location = new System.Drawing.Point(1211, 157);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(42, 34);
            this.simpleButton3.TabIndex = 1;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.ImageOptions.ImageIndex = 8;
            this.simpleButton2.ImageOptions.ImageList = this.imgMenu;
            this.simpleButton2.Location = new System.Drawing.Point(1155, 157);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(50, 34);
            this.simpleButton2.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.ImageOptions.ImageIndex = 7;
            this.simpleButton1.ImageOptions.ImageList = this.imgMenu;
            this.simpleButton1.Location = new System.Drawing.Point(1103, 157);
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
            this.filterControl1.Size = new System.Drawing.Size(1277, 195);
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
            this.gridControl1.Size = new System.Drawing.Size(1277, 508);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colOdemeTuruKodu,
            this.colOdemeTuruAdi,
            this.colAciklama});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colOdemeTuruKodu
            // 
            this.colOdemeTuruKodu.FieldName = "OdemeTuruKodu";
            this.colOdemeTuruKodu.Name = "colOdemeTuruKodu";
            this.colOdemeTuruKodu.Visible = true;
            this.colOdemeTuruKodu.VisibleIndex = 0;
            // 
            // colOdemeTuruAdi
            // 
            this.colOdemeTuruAdi.FieldName = "OdemeTuruAdi";
            this.colOdemeTuruAdi.Name = "colOdemeTuruAdi";
            this.colOdemeTuruAdi.Visible = true;
            this.colOdemeTuruAdi.VisibleIndex = 1;
            // 
            // colAciklama
            // 
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 2;
            // 
            // FrmOdemeTuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 708);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FrmOdemeTuru";
            this.Text = "Ödeme Türü";
            this.Load += new System.EventHandler(this.FrmOdemeTuru_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnOdemeHareket;
        private System.Windows.Forms.ImageList imgMenu;
        private DevExpress.XtraEditors.SimpleButton btnOdemeAra;
        private DevExpress.XtraEditors.SimpleButton btnOdemeGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnOdemeSil;
        private DevExpress.XtraEditors.SimpleButton btnOdemeDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnOdemeEkle;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.FilterControl filterControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colOdemeTuruKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colOdemeTuruAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
    }
}