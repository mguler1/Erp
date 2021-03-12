namespace MGsTok.BackOffice.Fişler
{
    partial class FrmFisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFisler));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dropDownButton1 = new DevExpress.XtraEditors.DropDownButton();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barAlisFisi = new DevExpress.XtraBars.BarButtonItem();
            this.barSatisFaturasi = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.fisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFisKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFisTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBelgeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlasiyerKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlasiyerAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIskontoOrani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIskontoTutari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToplamTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.filterControl1 = new DevExpress.XtraEditors.FilterControl();
            this.simpleButton8 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dropDownButton1);
            this.groupControl1.Controls.Add(this.simpleButton5);
            this.groupControl1.Controls.Add(this.simpleButton4);
            this.groupControl1.Controls.Add(this.simpleButton3);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 655);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1329, 86);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Menü";
            // 
            // dropDownButton1
            // 
            this.dropDownButton1.DropDownControl = this.popupMenu1;
            this.dropDownButton1.ImageOptions.ImageIndex = 12;
            this.dropDownButton1.ImageOptions.ImageList = this.ımageList1;
            this.dropDownButton1.Location = new System.Drawing.Point(5, 31);
            this.dropDownButton1.Name = "dropDownButton1";
            this.dropDownButton1.Size = new System.Drawing.Size(93, 45);
            this.dropDownButton1.TabIndex = 5;
            this.dropDownButton1.Text = "EKLE";
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barAlisFisi),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSatisFaturasi),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem6),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem7),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem8),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem9)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // barAlisFisi
            // 
            this.barAlisFisi.Caption = "Alış Faturası";
            this.barAlisFisi.DropDownControl = this.popupMenu1;
            this.barAlisFisi.Id = 0;
            this.barAlisFisi.Name = "barAlisFisi";
            this.barAlisFisi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FisIslem_Click);
            // 
            // barSatisFaturasi
            // 
            this.barSatisFaturasi.Caption = "Perakende Satış Faturası";
            this.barSatisFaturasi.DropDownControl = this.popupMenu1;
            this.barSatisFaturasi.Id = 1;
            this.barSatisFaturasi.Name = "barSatisFaturasi";
            this.barSatisFaturasi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FisIslem_Click);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Toptan Satış Faturası";
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FisIslem_Click);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Satış İade Faturası ";
            this.barButtonItem2.Id = 3;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FisIslem_Click);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Alış İade Faturası";
            this.barButtonItem3.Id = 4;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FisIslem_Click);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Tahsilat Fişi";
            this.barButtonItem4.Id = 5;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FisIslem_Click);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Ödeme Fişi";
            this.barButtonItem5.Id = 6;
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FisIslem_Click);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Cari Devir Fişi";
            this.barButtonItem6.Id = 7;
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FisIslem_Click);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Sayım Fazlası Fişi";
            this.barButtonItem7.Id = 8;
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FisIslem_Click);
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Sayım Eksiği Fişi";
            this.barButtonItem8.Id = 9;
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FisIslem_Click);
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Stok Devir Fişi";
            this.barButtonItem9.Id = 10;
            this.barButtonItem9.Name = "barButtonItem9";
            this.barButtonItem9.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FisIslem_Click);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barAlisFisi,
            this.barSatisFaturasi,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8,
            this.barButtonItem9});
            this.barManager1.MaxItemId = 11;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1329, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 741);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1329, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 741);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1329, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 741);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Alım Faturası.fw.png");
            this.ımageList1.Images.SetKeyName(1, "arrow_left_red.png");
            this.ımageList1.Images.SetKeyName(2, "brush.png");
            this.ımageList1.Images.SetKeyName(3, "delete.png");
            this.ımageList1.Images.SetKeyName(4, "factory.png");
            this.ımageList1.Images.SetKeyName(5, "folder_out.png");
            this.ımageList1.Images.SetKeyName(6, "funnel.png");
            this.ımageList1.Images.SetKeyName(7, "funnel_delete.png");
            this.ımageList1.Images.SetKeyName(8, "İade Faturaları.png");
            this.ımageList1.Images.SetKeyName(9, "money.png");
            this.ımageList1.Images.SetKeyName(10, "money48.png");
            this.ımageList1.Images.SetKeyName(11, "note.png");
            this.ımageList1.Images.SetKeyName(12, "note_add.png");
            this.ımageList1.Images.SetKeyName(13, "note_delete.png");
            this.ımageList1.Images.SetKeyName(14, "note_edit.png");
            this.ımageList1.Images.SetKeyName(15, "note_information.png");
            this.ımageList1.Images.SetKeyName(16, "note_ok.png");
            this.ımageList1.Images.SetKeyName(17, "refresh.png");
            this.ımageList1.Images.SetKeyName(18, "safe.png");
            this.ımageList1.Images.SetKeyName(19, "Satış Faturası.fw.png");
            this.ımageList1.Images.SetKeyName(20, "scroll.png");
            this.ımageList1.Images.SetKeyName(21, "shopping_basket.png");
            this.ımageList1.Images.SetKeyName(22, "shopping_cart.png");
            this.ımageList1.Images.SetKeyName(23, "ticket_blue.png");
            this.ımageList1.Images.SetKeyName(24, "user.png");
            this.ımageList1.Images.SetKeyName(25, "user_headset.png");
            this.ımageList1.Images.SetKeyName(26, "view.png");
            // 
            // simpleButton5
            // 
            this.simpleButton5.ImageOptions.ImageIndex = 26;
            this.simpleButton5.ImageOptions.ImageList = this.ımageList1;
            this.simpleButton5.Location = new System.Drawing.Point(388, 31);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(89, 45);
            this.simpleButton5.TabIndex = 4;
            this.simpleButton5.Text = "ARA";
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.ImageIndex = 17;
            this.simpleButton4.ImageOptions.ImageList = this.ımageList1;
            this.simpleButton4.Location = new System.Drawing.Point(287, 31);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(95, 45);
            this.simpleButton4.TabIndex = 3;
            this.simpleButton4.Text = "GÜNCELLE";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.ImageIndex = 13;
            this.simpleButton3.ImageOptions.ImageList = this.ımageList1;
            this.simpleButton3.Location = new System.Drawing.Point(196, 31);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(85, 45);
            this.simpleButton3.TabIndex = 2;
            this.simpleButton3.Text = "SİL";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.ImageIndex = 14;
            this.simpleButton2.ImageOptions.ImageList = this.ımageList1;
            this.simpleButton2.Location = new System.Drawing.Point(104, 31);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(86, 45);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "DÜZENLE";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.fisBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 263);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1329, 392);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // fisBindingSource
            // 
            this.fisBindingSource.DataSource = typeof(MGsTok.Entities.Tables.Fis);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colFisKodu,
            this.colFisTuru,
            this.colCariTuru,
            this.colCariKodu,
            this.colCariAdi,
            this.colBelgeNo,
            this.colTarih,
            this.colPlasiyerKodu,
            this.colPlasiyerAdi,
            this.colIskontoOrani,
            this.colIskontoTutari,
            this.colToplamTutar,
            this.colAciklama});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colFisKodu
            // 
            this.colFisKodu.FieldName = "FisKodu";
            this.colFisKodu.Name = "colFisKodu";
            this.colFisKodu.Visible = true;
            this.colFisKodu.VisibleIndex = 1;
            // 
            // colFisTuru
            // 
            this.colFisTuru.FieldName = "FisTuru";
            this.colFisTuru.Name = "colFisTuru";
            this.colFisTuru.Visible = true;
            this.colFisTuru.VisibleIndex = 2;
            // 
            // colCariTuru
            // 
            this.colCariTuru.FieldName = "CariTuru";
            this.colCariTuru.Name = "colCariTuru";
            this.colCariTuru.Visible = true;
            this.colCariTuru.VisibleIndex = 3;
            // 
            // colCariKodu
            // 
            this.colCariKodu.FieldName = "CariKodu";
            this.colCariKodu.Name = "colCariKodu";
            this.colCariKodu.Visible = true;
            this.colCariKodu.VisibleIndex = 4;
            // 
            // colCariAdi
            // 
            this.colCariAdi.FieldName = "CariAdi";
            this.colCariAdi.Name = "colCariAdi";
            this.colCariAdi.Visible = true;
            this.colCariAdi.VisibleIndex = 5;
            // 
            // colBelgeNo
            // 
            this.colBelgeNo.FieldName = "BelgeNo";
            this.colBelgeNo.Name = "colBelgeNo";
            this.colBelgeNo.Visible = true;
            this.colBelgeNo.VisibleIndex = 6;
            // 
            // colTarih
            // 
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 7;
            // 
            // colPlasiyerKodu
            // 
            this.colPlasiyerKodu.FieldName = "PlasiyerKodu";
            this.colPlasiyerKodu.Name = "colPlasiyerKodu";
            this.colPlasiyerKodu.Visible = true;
            this.colPlasiyerKodu.VisibleIndex = 8;
            // 
            // colPlasiyerAdi
            // 
            this.colPlasiyerAdi.FieldName = "PlasiyerAdi";
            this.colPlasiyerAdi.Name = "colPlasiyerAdi";
            this.colPlasiyerAdi.Visible = true;
            this.colPlasiyerAdi.VisibleIndex = 9;
            // 
            // colIskontoOrani
            // 
            this.colIskontoOrani.FieldName = "IskontoOrani";
            this.colIskontoOrani.Name = "colIskontoOrani";
            this.colIskontoOrani.Visible = true;
            this.colIskontoOrani.VisibleIndex = 10;
            // 
            // colIskontoTutari
            // 
            this.colIskontoTutari.FieldName = "IskontoTutari";
            this.colIskontoTutari.Name = "colIskontoTutari";
            this.colIskontoTutari.Visible = true;
            this.colIskontoTutari.VisibleIndex = 11;
            // 
            // colToplamTutar
            // 
            this.colToplamTutar.FieldName = "ToplamTutar";
            this.colToplamTutar.Name = "colToplamTutar";
            this.colToplamTutar.Visible = true;
            this.colToplamTutar.VisibleIndex = 12;
            // 
            // colAciklama
            // 
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 13;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(190, 19);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "FİŞLER VE FATURALAR";
            // 
            // filterControl1
            // 
            this.filterControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.filterControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.filterControl1.Location = new System.Drawing.Point(0, 22);
            this.filterControl1.Name = "filterControl1";
            this.filterControl1.Size = new System.Drawing.Size(1329, 241);
            this.filterControl1.TabIndex = 6;
            this.filterControl1.Text = "filterControl1";
            // 
            // simpleButton8
            // 
            this.simpleButton8.ImageOptions.ImageIndex = 5;
            this.simpleButton8.ImageOptions.ImageList = this.ımageList1;
            this.simpleButton8.Location = new System.Drawing.Point(1267, 221);
            this.simpleButton8.Name = "simpleButton8";
            this.simpleButton8.Size = new System.Drawing.Size(43, 36);
            this.simpleButton8.TabIndex = 9;
            this.simpleButton8.Click += new System.EventHandler(this.simpleButton8_Click);
            // 
            // simpleButton7
            // 
            this.simpleButton7.ImageOptions.ImageIndex = 7;
            this.simpleButton7.ImageOptions.ImageList = this.ımageList1;
            this.simpleButton7.Location = new System.Drawing.Point(1218, 221);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(43, 36);
            this.simpleButton7.TabIndex = 8;
            // 
            // simpleButton6
            // 
            this.simpleButton6.ImageOptions.ImageIndex = 6;
            this.simpleButton6.ImageOptions.ImageList = this.ımageList1;
            this.simpleButton6.Location = new System.Drawing.Point(1169, 221);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(43, 36);
            this.simpleButton6.TabIndex = 7;
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // FrmFisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 741);
            this.Controls.Add(this.simpleButton8);
            this.Controls.Add(this.simpleButton7);
            this.Controls.Add(this.simpleButton6);
            this.Controls.Add(this.filterControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmFisler";
            this.Text = "Fişler ve Faturalar";
            this.Load += new System.EventHandler(this.FrmFisler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.FilterControl filterControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton8;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.DropDownButton dropDownButton1;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem barAlisFisi;
        private DevExpress.XtraBars.BarButtonItem barSatisFaturasi;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource fisBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colFisKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colFisTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colCariTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colCariKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colCariAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colBelgeNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colPlasiyerKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colPlasiyerAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colIskontoOrani;
        private DevExpress.XtraGrid.Columns.GridColumn colIskontoTutari;
        private DevExpress.XtraGrid.Columns.GridColumn colToplamTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
    }
}