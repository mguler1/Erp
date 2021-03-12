namespace MGsTok.BackOffice.Fiyat_Değiştir
{
    partial class FrmFiyatDegistir
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFiyatTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKolonAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDegistir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryDegistir = new DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch();
            this.colDegisimTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryDegisimTuru = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colDegisimYonu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryDegisimYonu = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colDegeri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryCalcDegisimMiktari = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDegistir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDegisimTuru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDegisimYonu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryCalcDegisimMiktari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(-3, 38);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryDegistir,
            this.repositoryDegisimTuru,
            this.repositoryDegisimYonu,
            this.repositoryCalcDegisimMiktari});
            this.gridControl1.Size = new System.Drawing.Size(706, 358);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFiyatTuru,
            this.colKolonAdi,
            this.colDegistir,
            this.colDegisimTuru,
            this.colDegisimYonu,
            this.colDegeri});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // colFiyatTuru
            // 
            this.colFiyatTuru.Caption = "Fiyat Türü";
            this.colFiyatTuru.FieldName = "FiyatTuru";
            this.colFiyatTuru.Name = "colFiyatTuru";
            this.colFiyatTuru.OptionsColumn.AllowEdit = false;
            this.colFiyatTuru.Visible = true;
            this.colFiyatTuru.VisibleIndex = 0;
            // 
            // colKolonAdi
            // 
            this.colKolonAdi.Caption = "Kolon Adı";
            this.colKolonAdi.FieldName = "KolonAdi";
            this.colKolonAdi.Name = "colKolonAdi";
            // 
            // colDegistir
            // 
            this.colDegistir.Caption = "Fiyat Değişecek mi?";
            this.colDegistir.ColumnEdit = this.repositoryDegistir;
            this.colDegistir.FieldName = "Degistir";
            this.colDegistir.Name = "colDegistir";
            this.colDegistir.Visible = true;
            this.colDegistir.VisibleIndex = 1;
            // 
            // repositoryDegistir
            // 
            this.repositoryDegistir.AutoHeight = false;
            this.repositoryDegistir.Name = "repositoryDegistir";
            this.repositoryDegistir.OffText = "Off";
            this.repositoryDegistir.OnText = "On";
            // 
            // colDegisimTuru
            // 
            this.colDegisimTuru.Caption = "Değişim Türü";
            this.colDegisimTuru.ColumnEdit = this.repositoryDegisimTuru;
            this.colDegisimTuru.FieldName = "DegisimTürü";
            this.colDegisimTuru.Name = "colDegisimTuru";
            this.colDegisimTuru.Visible = true;
            this.colDegisimTuru.VisibleIndex = 2;
            // 
            // repositoryDegisimTuru
            // 
            this.repositoryDegisimTuru.AutoHeight = false;
            this.repositoryDegisimTuru.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryDegisimTuru.Items.AddRange(new object[] {
            "Yüzde",
            "Tutar"});
            this.repositoryDegisimTuru.Name = "repositoryDegisimTuru";
            this.repositoryDegisimTuru.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colDegisimYonu
            // 
            this.colDegisimYonu.Caption = "Değişim Yönü";
            this.colDegisimYonu.ColumnEdit = this.repositoryDegisimYonu;
            this.colDegisimYonu.FieldName = "DegisimYonu";
            this.colDegisimYonu.Name = "colDegisimYonu";
            this.colDegisimYonu.Visible = true;
            this.colDegisimYonu.VisibleIndex = 3;
            // 
            // repositoryDegisimYonu
            // 
            this.repositoryDegisimYonu.AutoHeight = false;
            this.repositoryDegisimYonu.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryDegisimYonu.Items.AddRange(new object[] {
            "Artır",
            "Azalt"});
            this.repositoryDegisimYonu.Name = "repositoryDegisimYonu";
            this.repositoryDegisimYonu.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colDegeri
            // 
            this.colDegeri.Caption = "Değişim Miktarı";
            this.colDegeri.ColumnEdit = this.repositoryCalcDegisimMiktari;
            this.colDegeri.FieldName = "Degeri";
            this.colDegeri.Name = "colDegeri";
            this.colDegeri.Visible = true;
            this.colDegeri.VisibleIndex = 4;
            // 
            // repositoryCalcDegisimMiktari
            // 
            this.repositoryCalcDegisimMiktari.AutoHeight = false;
            this.repositoryCalcDegisimMiktari.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryCalcDegisimMiktari.DisplayFormat.FormatString = "N2";
            this.repositoryCalcDegisimMiktari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryCalcDegisimMiktari.Name = "repositoryCalcDegisimMiktari";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Location = new System.Drawing.Point(-3, 402);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(706, 62);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Menü";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(573, 23);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(70, 33);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Kaydet";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // FrmFiyatDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 461);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmFiyatDegistir";
            this.Text = "FrmFiyatDegistir";
            this.Load += new System.EventHandler(this.FrmFiyatDegistir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDegistir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDegisimTuru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDegisimYonu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryCalcDegisimMiktari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.Columns.GridColumn colFiyatTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colKolonAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colDegistir;
        private DevExpress.XtraGrid.Columns.GridColumn colDegisimTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colDegisimYonu;
        private DevExpress.XtraGrid.Columns.GridColumn colDegeri;
        private DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch repositoryDegistir;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryDegisimTuru;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryDegisimYonu;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryCalcDegisimMiktari;
    }
}