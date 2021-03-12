namespace MGsTok.BackOffice.Stok
{
    partial class FrmStokSec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStokSec));
            this.lblBaslık = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnSec = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurumu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkodTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokBirimi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokGrubu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAltGrubu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOzelKod1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOzelKod2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOzelKod3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOzelKod4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGarantiSuresi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUreticiKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlisKdv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSatisKdv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlisFiyati1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlisFiyati2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlisFiyati3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSatisFiyati1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSatisFiyati2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSatisFiyati3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMinStokMiktari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaxStokMiktari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslık
            // 
            this.lblBaslık.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslık.Appearance.Image = global::MGsTok.BackOffice.Properties.Resources.package;
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
            this.lblBaslık.Size = new System.Drawing.Size(1149, 45);
            this.lblBaslık.TabIndex = 2;
            this.lblBaslık.Text = "             STOK SEÇİM EKRANI";
            this.lblBaslık.Click += new System.EventHandler(this.lblBaslık_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnSec);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 437);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1149, 100);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Menü";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // btnSec
            // 
            this.btnSec.ImageOptions.ImageIndex = 0;
            this.btnSec.Location = new System.Drawing.Point(1057, 34);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(87, 54);
            this.btnSec.TabIndex = 0;
            this.btnSec.Text = "SEÇ";
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 45);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1149, 392);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colDurumu,
            this.colStokKodu,
            this.colStokAdi,
            this.colBarkod,
            this.colBarkodTuru,
            this.colStokBirimi,
            this.colStokGrubu,
            this.colStokAltGrubu,
            this.colMarka,
            this.colModel,
            this.colOzelKod1,
            this.colOzelKod2,
            this.colOzelKod3,
            this.colOzelKod4,
            this.colGarantiSuresi,
            this.colUreticiKodu,
            this.colAlisKdv,
            this.colSatisKdv,
            this.colAlisFiyati1,
            this.colAlisFiyati2,
            this.colAlisFiyati3,
            this.colSatisFiyati1,
            this.colSatisFiyati2,
            this.colSatisFiyati3,
            this.colMinStokMiktari,
            this.colMaxStokMiktari,
            this.colAciklama,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            // 
            // colDurumu
            // 
            this.colDurumu.Caption = "Durumu";
            this.colDurumu.FieldName = "Durumu";
            this.colDurumu.Name = "colDurumu";
            this.colDurumu.Visible = true;
            this.colDurumu.VisibleIndex = 0;
            // 
            // colStokKodu
            // 
            this.colStokKodu.Caption = "Stok Kodu";
            this.colStokKodu.FieldName = "StokKodu";
            this.colStokKodu.Name = "colStokKodu";
            this.colStokKodu.Visible = true;
            this.colStokKodu.VisibleIndex = 1;
            // 
            // colStokAdi
            // 
            this.colStokAdi.Caption = "Stok Adı";
            this.colStokAdi.FieldName = "StokAdi";
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.Visible = true;
            this.colStokAdi.VisibleIndex = 2;
            // 
            // colBarkod
            // 
            this.colBarkod.Caption = "Barkod";
            this.colBarkod.FieldName = "Barkod";
            this.colBarkod.Name = "colBarkod";
            this.colBarkod.Visible = true;
            this.colBarkod.VisibleIndex = 3;
            // 
            // colBarkodTuru
            // 
            this.colBarkodTuru.Caption = "Barkod Türü";
            this.colBarkodTuru.FieldName = "BarkodTuru";
            this.colBarkodTuru.Name = "colBarkodTuru";
            this.colBarkodTuru.Visible = true;
            this.colBarkodTuru.VisibleIndex = 4;
            // 
            // colStokBirimi
            // 
            this.colStokBirimi.Caption = "Stok Birimi";
            this.colStokBirimi.FieldName = "StokBirimi";
            this.colStokBirimi.Name = "colStokBirimi";
            this.colStokBirimi.Visible = true;
            this.colStokBirimi.VisibleIndex = 5;
            // 
            // colStokGrubu
            // 
            this.colStokGrubu.Caption = "Stok Grubu";
            this.colStokGrubu.FieldName = "StokGrubu";
            this.colStokGrubu.Name = "colStokGrubu";
            this.colStokGrubu.Visible = true;
            this.colStokGrubu.VisibleIndex = 6;
            // 
            // colStokAltGrubu
            // 
            this.colStokAltGrubu.Caption = "Stok Alt Grubu";
            this.colStokAltGrubu.FieldName = "StokAltGrubu";
            this.colStokAltGrubu.Name = "colStokAltGrubu";
            this.colStokAltGrubu.Visible = true;
            this.colStokAltGrubu.VisibleIndex = 7;
            // 
            // colMarka
            // 
            this.colMarka.Caption = "Marka";
            this.colMarka.FieldName = "Marka";
            this.colMarka.Name = "colMarka";
            // 
            // colModel
            // 
            this.colModel.Caption = "Model";
            this.colModel.FieldName = "Model";
            this.colModel.Name = "colModel";
            // 
            // colOzelKod1
            // 
            this.colOzelKod1.Caption = "Özel Kod 1";
            this.colOzelKod1.FieldName = "OzelKod1";
            this.colOzelKod1.Name = "colOzelKod1";
            // 
            // colOzelKod2
            // 
            this.colOzelKod2.Caption = "Özel Kod 2";
            this.colOzelKod2.FieldName = "OzelKod2";
            this.colOzelKod2.Name = "colOzelKod2";
            // 
            // colOzelKod3
            // 
            this.colOzelKod3.Caption = "Özel Kod 3";
            this.colOzelKod3.FieldName = "OzelKod3";
            this.colOzelKod3.Name = "colOzelKod3";
            // 
            // colOzelKod4
            // 
            this.colOzelKod4.Caption = "Özel Kod 4";
            this.colOzelKod4.FieldName = "OzelKod4";
            this.colOzelKod4.Name = "colOzelKod4";
            // 
            // colGarantiSuresi
            // 
            this.colGarantiSuresi.Caption = "Garanti Süresi";
            this.colGarantiSuresi.FieldName = "GarantiSuresi";
            this.colGarantiSuresi.Name = "colGarantiSuresi";
            // 
            // colUreticiKodu
            // 
            this.colUreticiKodu.Caption = "Üretici Kodu";
            this.colUreticiKodu.FieldName = "UreticiKodu";
            this.colUreticiKodu.Name = "colUreticiKodu";
            // 
            // colAlisKdv
            // 
            this.colAlisKdv.Caption = "Alış Kdv";
            this.colAlisKdv.FieldName = "AlisKdv";
            this.colAlisKdv.Name = "colAlisKdv";
            // 
            // colSatisKdv
            // 
            this.colSatisKdv.Caption = "Satış Kdv";
            this.colSatisKdv.FieldName = "SatisKdv";
            this.colSatisKdv.Name = "colSatisKdv";
            // 
            // colAlisFiyati1
            // 
            this.colAlisFiyati1.Caption = "Alış Fiyatı 1";
            this.colAlisFiyati1.FieldName = "AlisFiyati1";
            this.colAlisFiyati1.Name = "colAlisFiyati1";
            // 
            // colAlisFiyati2
            // 
            this.colAlisFiyati2.Caption = "Alış Fiyatı 2";
            this.colAlisFiyati2.FieldName = "AlisFiyati2";
            this.colAlisFiyati2.Name = "colAlisFiyati2";
            // 
            // colAlisFiyati3
            // 
            this.colAlisFiyati3.Caption = "Alış Fiyatı 3";
            this.colAlisFiyati3.FieldName = "AlisFiyati3";
            this.colAlisFiyati3.Name = "colAlisFiyati3";
            // 
            // colSatisFiyati1
            // 
            this.colSatisFiyati1.Caption = "Satış Fiyatı 1";
            this.colSatisFiyati1.FieldName = "SatisFiyati1";
            this.colSatisFiyati1.Name = "colSatisFiyati1";
            // 
            // colSatisFiyati2
            // 
            this.colSatisFiyati2.Caption = "Satış Fiyatı 2";
            this.colSatisFiyati2.FieldName = "SatisFiyati2";
            this.colSatisFiyati2.Name = "colSatisFiyati2";
            // 
            // colSatisFiyati3
            // 
            this.colSatisFiyati3.Caption = "Satış Fiyatı 3";
            this.colSatisFiyati3.FieldName = "SatisFiyati3";
            this.colSatisFiyati3.Name = "colSatisFiyati3";
            // 
            // colMinStokMiktari
            // 
            this.colMinStokMiktari.Caption = "Min Stok Miktarı";
            this.colMinStokMiktari.FieldName = "MinStokMiktari";
            this.colMinStokMiktari.Name = "colMinStokMiktari";
            this.colMinStokMiktari.Visible = true;
            this.colMinStokMiktari.VisibleIndex = 8;
            // 
            // colMaxStokMiktari
            // 
            this.colMaxStokMiktari.Caption = "Max Stok Miktarı";
            this.colMaxStokMiktari.FieldName = "MaxStokMiktari";
            this.colMaxStokMiktari.Name = "colMaxStokMiktari";
            this.colMaxStokMiktari.Visible = true;
            this.colMaxStokMiktari.VisibleIndex = 9;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 10;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Stok Giriş";
            this.gridColumn1.FieldName = "StokGiris";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 11;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Stok Çıkış";
            this.gridColumn2.FieldName = "StokCıkıs";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 12;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Mevcut Stok";
            this.gridColumn3.FieldName = "MevcutStok";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 13;
            // 
            // FrmStokSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 537);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.lblBaslık);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmStokSec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Seç";
            this.Load += new System.EventHandler(this.FrmStokSec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslık;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnSec;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDurumu;
        private DevExpress.XtraGrid.Columns.GridColumn colStokKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkodTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colStokBirimi;
        private DevExpress.XtraGrid.Columns.GridColumn colStokGrubu;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAltGrubu;
        private DevExpress.XtraGrid.Columns.GridColumn colMarka;
        private DevExpress.XtraGrid.Columns.GridColumn colModel;
        private DevExpress.XtraGrid.Columns.GridColumn colOzelKod1;
        private DevExpress.XtraGrid.Columns.GridColumn colOzelKod2;
        private DevExpress.XtraGrid.Columns.GridColumn colOzelKod3;
        private DevExpress.XtraGrid.Columns.GridColumn colOzelKod4;
        private DevExpress.XtraGrid.Columns.GridColumn colGarantiSuresi;
        private DevExpress.XtraGrid.Columns.GridColumn colUreticiKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colAlisKdv;
        private DevExpress.XtraGrid.Columns.GridColumn colSatisKdv;
        private DevExpress.XtraGrid.Columns.GridColumn colAlisFiyati1;
        private DevExpress.XtraGrid.Columns.GridColumn colAlisFiyati2;
        private DevExpress.XtraGrid.Columns.GridColumn colAlisFiyati3;
        private DevExpress.XtraGrid.Columns.GridColumn colSatisFiyati1;
        private DevExpress.XtraGrid.Columns.GridColumn colSatisFiyati2;
        private DevExpress.XtraGrid.Columns.GridColumn colSatisFiyati3;
        private DevExpress.XtraGrid.Columns.GridColumn colMinStokMiktari;
        private DevExpress.XtraGrid.Columns.GridColumn colMaxStokMiktari;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}