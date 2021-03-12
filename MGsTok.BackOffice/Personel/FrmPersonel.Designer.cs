namespace MGsTok.BackOffice.Personel
{
    partial class FrmPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonel));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCalisiyot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnvani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonelKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonelAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTcKimlikNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIseGirisTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIstenCikis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVergiDairesi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVergiNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCepTelefonu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIlce = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSemt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrimOrani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAylıkMaas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToplamSatis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.filterControl1 = new DevExpress.XtraEditors.FilterControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnPersonelHareket = new DevExpress.XtraEditors.SimpleButton();
            this.btnPersonelAra = new DevExpress.XtraEditors.SimpleButton();
            this.btnPersonelGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnPersonelSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnPersonelDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnPersonelEkle = new DevExpress.XtraEditors.SimpleButton();
            this.lblBaslık = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colCalisiyot,
            this.colUnvani,
            this.colPersonelKodu,
            this.colPersonelAdi,
            this.colTcKimlikNo,
            this.colIseGirisTarihi,
            this.colIstenCikis,
            this.colVergiDairesi,
            this.colVergiNo,
            this.colCepTelefonu,
            this.colFax,
            this.colEmail,
            this.colWeb,
            this.colIl,
            this.colIlce,
            this.colSemt,
            this.colAdres,
            this.colPrimOrani,
            this.colAylıkMaas,
            this.colAciklama,
            this.colToplamSatis,
            this.colPrim});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            // 
            // colCalisiyot
            // 
            this.colCalisiyot.Caption = "Çalışıyor";
            this.colCalisiyot.FieldName = "Calisiyot";
            this.colCalisiyot.Name = "colCalisiyot";
            this.colCalisiyot.OptionsColumn.AllowEdit = false;
            this.colCalisiyot.Visible = true;
            this.colCalisiyot.VisibleIndex = 0;
            // 
            // colUnvani
            // 
            this.colUnvani.Caption = "Ünvanı";
            this.colUnvani.FieldName = "Unvani";
            this.colUnvani.Name = "colUnvani";
            this.colUnvani.OptionsColumn.AllowEdit = false;
            this.colUnvani.Visible = true;
            this.colUnvani.VisibleIndex = 1;
            // 
            // colPersonelKodu
            // 
            this.colPersonelKodu.FieldName = "PersonelKodu";
            this.colPersonelKodu.Name = "colPersonelKodu";
            this.colPersonelKodu.OptionsColumn.AllowEdit = false;
            this.colPersonelKodu.Visible = true;
            this.colPersonelKodu.VisibleIndex = 2;
            // 
            // colPersonelAdi
            // 
            this.colPersonelAdi.Caption = "Personel Adı";
            this.colPersonelAdi.FieldName = "PersonelAdi";
            this.colPersonelAdi.Name = "colPersonelAdi";
            this.colPersonelAdi.OptionsColumn.AllowEdit = false;
            this.colPersonelAdi.Visible = true;
            this.colPersonelAdi.VisibleIndex = 3;
            // 
            // colTcKimlikNo
            // 
            this.colTcKimlikNo.FieldName = "TcKimlikNo";
            this.colTcKimlikNo.Name = "colTcKimlikNo";
            this.colTcKimlikNo.OptionsColumn.AllowEdit = false;
            this.colTcKimlikNo.Visible = true;
            this.colTcKimlikNo.VisibleIndex = 4;
            // 
            // colIseGirisTarihi
            // 
            this.colIseGirisTarihi.Caption = "İşe Giriş Tarihi";
            this.colIseGirisTarihi.FieldName = "IseGirisTarihi";
            this.colIseGirisTarihi.Name = "colIseGirisTarihi";
            this.colIseGirisTarihi.OptionsColumn.AllowEdit = false;
            this.colIseGirisTarihi.Visible = true;
            this.colIseGirisTarihi.VisibleIndex = 5;
            // 
            // colIstenCikis
            // 
            this.colIstenCikis.Caption = "İşten Çıkış Tarihi";
            this.colIstenCikis.FieldName = "IstenCikis";
            this.colIstenCikis.Name = "colIstenCikis";
            this.colIstenCikis.OptionsColumn.AllowEdit = false;
            this.colIstenCikis.Visible = true;
            this.colIstenCikis.VisibleIndex = 6;
            // 
            // colVergiDairesi
            // 
            this.colVergiDairesi.FieldName = "VergiDairesi";
            this.colVergiDairesi.Name = "colVergiDairesi";
            this.colVergiDairesi.OptionsColumn.AllowEdit = false;
            this.colVergiDairesi.Visible = true;
            this.colVergiDairesi.VisibleIndex = 7;
            // 
            // colVergiNo
            // 
            this.colVergiNo.FieldName = "VergiNo";
            this.colVergiNo.Name = "colVergiNo";
            this.colVergiNo.OptionsColumn.AllowEdit = false;
            this.colVergiNo.Visible = true;
            this.colVergiNo.VisibleIndex = 8;
            // 
            // colCepTelefonu
            // 
            this.colCepTelefonu.FieldName = "CepTelefonu";
            this.colCepTelefonu.Name = "colCepTelefonu";
            this.colCepTelefonu.OptionsColumn.AllowEdit = false;
            this.colCepTelefonu.Visible = true;
            this.colCepTelefonu.VisibleIndex = 9;
            // 
            // colFax
            // 
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            this.colFax.OptionsColumn.AllowEdit = false;
            this.colFax.Visible = true;
            this.colFax.VisibleIndex = 10;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.OptionsColumn.AllowEdit = false;
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 11;
            // 
            // colWeb
            // 
            this.colWeb.FieldName = "Web";
            this.colWeb.Name = "colWeb";
            this.colWeb.OptionsColumn.AllowEdit = false;
            this.colWeb.Visible = true;
            this.colWeb.VisibleIndex = 12;
            // 
            // colIl
            // 
            this.colIl.Caption = "İl";
            this.colIl.FieldName = "Il";
            this.colIl.Name = "colIl";
            this.colIl.OptionsColumn.AllowEdit = false;
            this.colIl.Visible = true;
            this.colIl.VisibleIndex = 13;
            // 
            // colIlce
            // 
            this.colIlce.Caption = "İlçe";
            this.colIlce.FieldName = "Ilce";
            this.colIlce.Name = "colIlce";
            this.colIlce.OptionsColumn.AllowEdit = false;
            this.colIlce.Visible = true;
            this.colIlce.VisibleIndex = 14;
            // 
            // colSemt
            // 
            this.colSemt.FieldName = "Semt";
            this.colSemt.Name = "colSemt";
            this.colSemt.OptionsColumn.AllowEdit = false;
            this.colSemt.Visible = true;
            this.colSemt.VisibleIndex = 15;
            // 
            // colAdres
            // 
            this.colAdres.FieldName = "Adres";
            this.colAdres.Name = "colAdres";
            this.colAdres.OptionsColumn.AllowEdit = false;
            this.colAdres.Visible = true;
            this.colAdres.VisibleIndex = 16;
            // 
            // colPrimOrani
            // 
            this.colPrimOrani.Caption = "Prim Oranı";
            this.colPrimOrani.FieldName = "PrimOrani";
            this.colPrimOrani.Name = "colPrimOrani";
            this.colPrimOrani.OptionsColumn.AllowEdit = false;
            this.colPrimOrani.Visible = true;
            this.colPrimOrani.VisibleIndex = 17;
            // 
            // colAylıkMaas
            // 
            this.colAylıkMaas.Caption = "Aylık Maaş";
            this.colAylıkMaas.FieldName = "AylıkMaas";
            this.colAylıkMaas.Name = "colAylıkMaas";
            this.colAylıkMaas.OptionsColumn.AllowEdit = false;
            this.colAylıkMaas.Visible = true;
            this.colAylıkMaas.VisibleIndex = 18;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 19;
            // 
            // colToplamSatis
            // 
            this.colToplamSatis.Caption = "Toplam Satış";
            this.colToplamSatis.Name = "colToplamSatis";
            this.colToplamSatis.Visible = true;
            this.colToplamSatis.VisibleIndex = 20;
            // 
            // colPrim
            // 
            this.colPrim.Caption = "Prim";
            this.colPrim.Name = "colPrim";
            this.colPrim.Visible = true;
            this.colPrim.VisibleIndex = 21;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1273, 268);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton3.ImageOptions.ImageIndex = 6;
            this.simpleButton3.ImageOptions.ImageList = this.ımageList1;
            this.simpleButton3.Location = new System.Drawing.Point(1207, 157);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(42, 34);
            this.simpleButton3.TabIndex = 1;
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
            this.ımageList1.Images.SetKeyName(16, "delete.png");
            this.ımageList1.Images.SetKeyName(17, "düzenle.png");
            this.ımageList1.Images.SetKeyName(18, "Ekle.png");
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.ImageOptions.ImageIndex = 8;
            this.simpleButton2.ImageOptions.ImageList = this.ımageList1;
            this.simpleButton2.Location = new System.Drawing.Point(1151, 157);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(50, 34);
            this.simpleButton2.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.ImageOptions.ImageIndex = 7;
            this.simpleButton1.ImageOptions.ImageList = this.ımageList1;
            this.simpleButton1.Location = new System.Drawing.Point(1099, 157);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(46, 34);
            this.simpleButton1.TabIndex = 1;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 38);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.simpleButton3);
            this.splitContainerControl1.Panel1.Controls.Add(this.simpleButton2);
            this.splitContainerControl1.Panel1.Controls.Add(this.simpleButton1);
            this.splitContainerControl1.Panel1.Controls.Add(this.filterControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1273, 568);
            this.splitContainerControl1.SplitterPosition = 195;
            this.splitContainerControl1.TabIndex = 9;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // filterControl1
            // 
            this.filterControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.filterControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterControl1.Location = new System.Drawing.Point(0, 0);
            this.filterControl1.Name = "filterControl1";
            this.filterControl1.Size = new System.Drawing.Size(1273, 195);
            this.filterControl1.SourceControl = this.gridControl1;
            this.filterControl1.TabIndex = 0;
            this.filterControl1.Text = "filterControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnPersonelHareket);
            this.groupControl1.Controls.Add(this.btnPersonelAra);
            this.groupControl1.Controls.Add(this.btnPersonelGuncelle);
            this.groupControl1.Controls.Add(this.btnPersonelSil);
            this.groupControl1.Controls.Add(this.btnPersonelDuzenle);
            this.groupControl1.Controls.Add(this.btnPersonelEkle);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 268);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1273, 100);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Menü";
            // 
            // btnPersonelHareket
            // 
            this.btnPersonelHareket.ImageOptions.ImageIndex = 17;
            this.btnPersonelHareket.ImageOptions.ImageList = this.ımageList1;
            this.btnPersonelHareket.Location = new System.Drawing.Point(297, 34);
            this.btnPersonelHareket.Name = "btnPersonelHareket";
            this.btnPersonelHareket.Size = new System.Drawing.Size(104, 54);
            this.btnPersonelHareket.TabIndex = 1;
            this.btnPersonelHareket.Text = "PERSONEL \r\nHAREKET";
            // 
            // btnPersonelAra
            // 
            this.btnPersonelAra.ImageOptions.ImageIndex = 15;
            this.btnPersonelAra.ImageOptions.ImageList = this.ımageList1;
            this.btnPersonelAra.Location = new System.Drawing.Point(509, 34);
            this.btnPersonelAra.Name = "btnPersonelAra";
            this.btnPersonelAra.Size = new System.Drawing.Size(89, 54);
            this.btnPersonelAra.TabIndex = 0;
            this.btnPersonelAra.Text = "ARA";
            // 
            // btnPersonelGuncelle
            // 
            this.btnPersonelGuncelle.ImageOptions.ImageIndex = 12;
            this.btnPersonelGuncelle.ImageOptions.ImageList = this.ımageList1;
            this.btnPersonelGuncelle.Location = new System.Drawing.Point(407, 34);
            this.btnPersonelGuncelle.Name = "btnPersonelGuncelle";
            this.btnPersonelGuncelle.Size = new System.Drawing.Size(96, 54);
            this.btnPersonelGuncelle.TabIndex = 0;
            this.btnPersonelGuncelle.Text = " GÜNCELLE";
            this.btnPersonelGuncelle.Click += new System.EventHandler(this.btnDepoGuncelle_Click);
            // 
            // btnPersonelSil
            // 
            this.btnPersonelSil.ImageOptions.ImageIndex = 16;
            this.btnPersonelSil.ImageOptions.ImageList = this.ımageList1;
            this.btnPersonelSil.Location = new System.Drawing.Point(202, 34);
            this.btnPersonelSil.Name = "btnPersonelSil";
            this.btnPersonelSil.Size = new System.Drawing.Size(89, 54);
            this.btnPersonelSil.TabIndex = 0;
            this.btnPersonelSil.Text = "SİL";
            this.btnPersonelSil.Click += new System.EventHandler(this.btnPersonelSil_Click);
            // 
            // btnPersonelDuzenle
            // 
            this.btnPersonelDuzenle.ImageOptions.ImageIndex = 17;
            this.btnPersonelDuzenle.ImageOptions.ImageList = this.ımageList1;
            this.btnPersonelDuzenle.Location = new System.Drawing.Point(107, 34);
            this.btnPersonelDuzenle.Name = "btnPersonelDuzenle";
            this.btnPersonelDuzenle.Size = new System.Drawing.Size(89, 54);
            this.btnPersonelDuzenle.TabIndex = 0;
            this.btnPersonelDuzenle.Text = "DÜZENLE";
            this.btnPersonelDuzenle.Click += new System.EventHandler(this.btnPersonelDuzenle_Click);
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.ImageOptions.ImageIndex = 18;
            this.btnPersonelEkle.ImageOptions.ImageList = this.ımageList1;
            this.btnPersonelEkle.Location = new System.Drawing.Point(12, 34);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(89, 54);
            this.btnPersonelEkle.TabIndex = 0;
            this.btnPersonelEkle.Text = "EKLE";
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
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
            this.lblBaslık.Size = new System.Drawing.Size(1273, 38);
            this.lblBaslık.TabIndex = 8;
            this.lblBaslık.Text = "             PERSONEL KARTLARI";
            // 
            // FrmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 606);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.lblBaslık);
            this.Name = "FrmPersonel";
            this.Text = "Personel";
            this.Load += new System.EventHandler(this.FrmPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.FilterControl filterControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnPersonelHareket;
        private DevExpress.XtraEditors.SimpleButton btnPersonelAra;
        private DevExpress.XtraEditors.SimpleButton btnPersonelGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnPersonelSil;
        private DevExpress.XtraEditors.SimpleButton btnPersonelDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnPersonelEkle;
        private DevExpress.XtraEditors.LabelControl lblBaslık;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCalisiyot;
        private DevExpress.XtraGrid.Columns.GridColumn colUnvani;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonelKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonelAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colTcKimlikNo;
        private DevExpress.XtraGrid.Columns.GridColumn colIseGirisTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colIstenCikis;
        private DevExpress.XtraGrid.Columns.GridColumn colVergiDairesi;
        private DevExpress.XtraGrid.Columns.GridColumn colVergiNo;
        private DevExpress.XtraGrid.Columns.GridColumn colCepTelefonu;
        private DevExpress.XtraGrid.Columns.GridColumn colFax;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colWeb;
        private DevExpress.XtraGrid.Columns.GridColumn colIl;
        private DevExpress.XtraGrid.Columns.GridColumn colIlce;
        private DevExpress.XtraGrid.Columns.GridColumn colSemt;
        private DevExpress.XtraGrid.Columns.GridColumn colAdres;
        private DevExpress.XtraGrid.Columns.GridColumn colPrimOrani;
        private DevExpress.XtraGrid.Columns.GridColumn colAylıkMaas;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colToplamSatis;
        private DevExpress.XtraGrid.Columns.GridColumn colPrim;
    }
}