namespace MGsTok.BackOffice.Fiyat_Değiştir
{
    partial class FrmTopluFiyat
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.stokBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.stokBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1124, 619);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // stokBindingSource
            // 
            this.stokBindingSource.DataSource = typeof(MGsTok.Entities.Tables.Stok);
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
            this.colAciklama});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colDurumu
            // 
            this.colDurumu.FieldName = "Durumu";
            this.colDurumu.Name = "colDurumu";
            this.colDurumu.Visible = true;
            this.colDurumu.VisibleIndex = 0;
            // 
            // colStokKodu
            // 
            this.colStokKodu.FieldName = "StokKodu";
            this.colStokKodu.Name = "colStokKodu";
            this.colStokKodu.Visible = true;
            this.colStokKodu.VisibleIndex = 1;
            // 
            // colStokAdi
            // 
            this.colStokAdi.FieldName = "StokAdi";
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.Visible = true;
            this.colStokAdi.VisibleIndex = 2;
            // 
            // colBarkod
            // 
            this.colBarkod.FieldName = "Barkod";
            this.colBarkod.Name = "colBarkod";
            this.colBarkod.Visible = true;
            this.colBarkod.VisibleIndex = 3;
            // 
            // colBarkodTuru
            // 
            this.colBarkodTuru.FieldName = "BarkodTuru";
            this.colBarkodTuru.Name = "colBarkodTuru";
            this.colBarkodTuru.Visible = true;
            this.colBarkodTuru.VisibleIndex = 4;
            // 
            // colStokBirimi
            // 
            this.colStokBirimi.FieldName = "StokBirimi";
            this.colStokBirimi.Name = "colStokBirimi";
            this.colStokBirimi.Visible = true;
            this.colStokBirimi.VisibleIndex = 5;
            // 
            // colStokGrubu
            // 
            this.colStokGrubu.FieldName = "StokGrubu";
            this.colStokGrubu.Name = "colStokGrubu";
            // 
            // colStokAltGrubu
            // 
            this.colStokAltGrubu.FieldName = "StokAltGrubu";
            this.colStokAltGrubu.Name = "colStokAltGrubu";
            // 
            // colMarka
            // 
            this.colMarka.FieldName = "Marka";
            this.colMarka.Name = "colMarka";
            // 
            // colModel
            // 
            this.colModel.FieldName = "Model";
            this.colModel.Name = "colModel";
            // 
            // colOzelKod1
            // 
            this.colOzelKod1.FieldName = "OzelKod1";
            this.colOzelKod1.Name = "colOzelKod1";
            // 
            // colOzelKod2
            // 
            this.colOzelKod2.FieldName = "OzelKod2";
            this.colOzelKod2.Name = "colOzelKod2";
            // 
            // colOzelKod3
            // 
            this.colOzelKod3.FieldName = "OzelKod3";
            this.colOzelKod3.Name = "colOzelKod3";
            // 
            // colOzelKod4
            // 
            this.colOzelKod4.FieldName = "OzelKod4";
            this.colOzelKod4.Name = "colOzelKod4";
            // 
            // colGarantiSuresi
            // 
            this.colGarantiSuresi.FieldName = "GarantiSuresi";
            this.colGarantiSuresi.Name = "colGarantiSuresi";
            // 
            // colUreticiKodu
            // 
            this.colUreticiKodu.FieldName = "UreticiKodu";
            this.colUreticiKodu.Name = "colUreticiKodu";
            // 
            // colAlisKdv
            // 
            this.colAlisKdv.FieldName = "AlisKdv";
            this.colAlisKdv.Name = "colAlisKdv";
            // 
            // colSatisKdv
            // 
            this.colSatisKdv.FieldName = "SatisKdv";
            this.colSatisKdv.Name = "colSatisKdv";
            // 
            // colAlisFiyati1
            // 
            this.colAlisFiyati1.FieldName = "AlisFiyati1";
            this.colAlisFiyati1.Name = "colAlisFiyati1";
            this.colAlisFiyati1.Visible = true;
            this.colAlisFiyati1.VisibleIndex = 6;
            // 
            // colAlisFiyati2
            // 
            this.colAlisFiyati2.FieldName = "AlisFiyati2";
            this.colAlisFiyati2.Name = "colAlisFiyati2";
            this.colAlisFiyati2.Visible = true;
            this.colAlisFiyati2.VisibleIndex = 7;
            // 
            // colAlisFiyati3
            // 
            this.colAlisFiyati3.FieldName = "AlisFiyati3";
            this.colAlisFiyati3.Name = "colAlisFiyati3";
            this.colAlisFiyati3.Visible = true;
            this.colAlisFiyati3.VisibleIndex = 8;
            // 
            // colSatisFiyati1
            // 
            this.colSatisFiyati1.FieldName = "SatisFiyati1";
            this.colSatisFiyati1.Name = "colSatisFiyati1";
            this.colSatisFiyati1.Visible = true;
            this.colSatisFiyati1.VisibleIndex = 9;
            // 
            // colSatisFiyati2
            // 
            this.colSatisFiyati2.FieldName = "SatisFiyati2";
            this.colSatisFiyati2.Name = "colSatisFiyati2";
            this.colSatisFiyati2.Visible = true;
            this.colSatisFiyati2.VisibleIndex = 10;
            // 
            // colSatisFiyati3
            // 
            this.colSatisFiyati3.FieldName = "SatisFiyati3";
            this.colSatisFiyati3.Name = "colSatisFiyati3";
            this.colSatisFiyati3.Visible = true;
            this.colSatisFiyati3.VisibleIndex = 11;
            // 
            // colMinStokMiktari
            // 
            this.colMinStokMiktari.FieldName = "MinStokMiktari";
            this.colMinStokMiktari.Name = "colMinStokMiktari";
            // 
            // colMaxStokMiktari
            // 
            this.colMaxStokMiktari.FieldName = "MaxStokMiktari";
            this.colMaxStokMiktari.Name = "colMaxStokMiktari";
            // 
            // colAciklama
            // 
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton5);
            this.groupControl1.Controls.Add(this.simpleButton4);
            this.groupControl1.Controls.Add(this.simpleButton3);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 552);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1124, 67);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Menü";
            // 
            // simpleButton5
            // 
            this.simpleButton5.Location = new System.Drawing.Point(400, 23);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(91, 39);
            this.simpleButton5.TabIndex = 4;
            this.simpleButton5.Text = "KAYDET";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(303, 23);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(91, 39);
            this.simpleButton4.TabIndex = 3;
            this.simpleButton4.Text = "FİYAT DEĞİŞTİR";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(206, 23);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(91, 39);
            this.simpleButton3.TabIndex = 2;
            this.simpleButton3.Text = "GÜNCELLE";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(109, 23);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(91, 39);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "ÇIKAR";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 23);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(91, 39);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "EKLE";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(32, 32);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FrmTopluFiyat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 619);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmTopluFiyat";
            this.Text = "Toplu Fiyat Düzenleme";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.BindingSource stokBindingSource;
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
        private System.Windows.Forms.ImageList ımageList1;
    }
}