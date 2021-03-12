namespace MGsTok.BackOffice.Cari
{
    partial class FrmCariSec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCariSec));
            this.btnSec = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblBaslık = new DevExpress.XtraEditors.LabelControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurumu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYetkiliKisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFaturaUnvani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCepTelefonu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWebAdresi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIlce = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSemt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariGrubu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariAltGrubu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOzelKod1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOzelKod2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOzelKod3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOzelKod4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVergiDairesi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVergiNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIskontoOrani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRiskLimit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlisOzelFiyati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSatisOzelFiyati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.cariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colAlacak = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBorc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBakiye = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cariBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnSec);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 462);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1166, 94);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Menü";
            // 
            // lblBaslık
            // 
            this.lblBaslık.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
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
            this.lblBaslık.Size = new System.Drawing.Size(1166, 34);
            this.lblBaslık.TabIndex = 5;
            this.lblBaslık.Text = "             CARİ SEÇİM EKRANI";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colDurumu,
            this.colCariTuru,
            this.colCariKodu,
            this.colCariAdi,
            this.colYetkiliKisi,
            this.colFaturaUnvani,
            this.colCepTelefonu,
            this.colTelefon,
            this.colFax,
            this.colEmail,
            this.colWebAdresi,
            this.colIl,
            this.colIlce,
            this.colSemt,
            this.colAdres,
            this.colCariGrubu,
            this.colCariAltGrubu,
            this.colOzelKod1,
            this.colOzelKod2,
            this.colOzelKod3,
            this.colOzelKod4,
            this.colVergiDairesi,
            this.colVergiNo,
            this.colIskontoOrani,
            this.colRiskLimit,
            this.colAlisOzelFiyati,
            this.colSatisOzelFiyati,
            this.colAciklama,
            this.colAlacak,
            this.colBorc,
            this.colBakiye});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colDurumu
            // 
            this.colDurumu.FieldName = "Durumu";
            this.colDurumu.Name = "colDurumu";
            this.colDurumu.Visible = true;
            this.colDurumu.VisibleIndex = 1;
            // 
            // colCariTuru
            // 
            this.colCariTuru.FieldName = "CariTuru";
            this.colCariTuru.Name = "colCariTuru";
            this.colCariTuru.Visible = true;
            this.colCariTuru.VisibleIndex = 2;
            // 
            // colCariKodu
            // 
            this.colCariKodu.FieldName = "CariKodu";
            this.colCariKodu.Name = "colCariKodu";
            this.colCariKodu.Visible = true;
            this.colCariKodu.VisibleIndex = 3;
            // 
            // colCariAdi
            // 
            this.colCariAdi.FieldName = "CariAdi";
            this.colCariAdi.Name = "colCariAdi";
            this.colCariAdi.Visible = true;
            this.colCariAdi.VisibleIndex = 4;
            // 
            // colYetkiliKisi
            // 
            this.colYetkiliKisi.FieldName = "YetkiliKisi";
            this.colYetkiliKisi.Name = "colYetkiliKisi";
            this.colYetkiliKisi.Visible = true;
            this.colYetkiliKisi.VisibleIndex = 5;
            // 
            // colFaturaUnvani
            // 
            this.colFaturaUnvani.FieldName = "FaturaUnvani";
            this.colFaturaUnvani.Name = "colFaturaUnvani";
            this.colFaturaUnvani.Visible = true;
            this.colFaturaUnvani.VisibleIndex = 6;
            // 
            // colCepTelefonu
            // 
            this.colCepTelefonu.FieldName = "CepTelefonu";
            this.colCepTelefonu.Name = "colCepTelefonu";
            this.colCepTelefonu.Visible = true;
            this.colCepTelefonu.VisibleIndex = 7;
            // 
            // colTelefon
            // 
            this.colTelefon.FieldName = "Telefon";
            this.colTelefon.Name = "colTelefon";
            this.colTelefon.Visible = true;
            this.colTelefon.VisibleIndex = 8;
            // 
            // colFax
            // 
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            this.colFax.Visible = true;
            this.colFax.VisibleIndex = 9;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 10;
            // 
            // colWebAdresi
            // 
            this.colWebAdresi.FieldName = "WebAdresi";
            this.colWebAdresi.Name = "colWebAdresi";
            this.colWebAdresi.Visible = true;
            this.colWebAdresi.VisibleIndex = 11;
            // 
            // colIl
            // 
            this.colIl.FieldName = "Il";
            this.colIl.Name = "colIl";
            this.colIl.Visible = true;
            this.colIl.VisibleIndex = 12;
            // 
            // colIlce
            // 
            this.colIlce.FieldName = "Ilce";
            this.colIlce.Name = "colIlce";
            this.colIlce.Visible = true;
            this.colIlce.VisibleIndex = 13;
            // 
            // colSemt
            // 
            this.colSemt.FieldName = "Semt";
            this.colSemt.Name = "colSemt";
            this.colSemt.Visible = true;
            this.colSemt.VisibleIndex = 14;
            // 
            // colAdres
            // 
            this.colAdres.FieldName = "Adres";
            this.colAdres.Name = "colAdres";
            this.colAdres.Visible = true;
            this.colAdres.VisibleIndex = 15;
            // 
            // colCariGrubu
            // 
            this.colCariGrubu.FieldName = "CariGrubu";
            this.colCariGrubu.Name = "colCariGrubu";
            this.colCariGrubu.Visible = true;
            this.colCariGrubu.VisibleIndex = 16;
            // 
            // colCariAltGrubu
            // 
            this.colCariAltGrubu.FieldName = "CariAltGrubu";
            this.colCariAltGrubu.Name = "colCariAltGrubu";
            this.colCariAltGrubu.Visible = true;
            this.colCariAltGrubu.VisibleIndex = 17;
            // 
            // colOzelKod1
            // 
            this.colOzelKod1.FieldName = "OzelKod1";
            this.colOzelKod1.Name = "colOzelKod1";
            this.colOzelKod1.Visible = true;
            this.colOzelKod1.VisibleIndex = 18;
            // 
            // colOzelKod2
            // 
            this.colOzelKod2.FieldName = "OzelKod2";
            this.colOzelKod2.Name = "colOzelKod2";
            this.colOzelKod2.Visible = true;
            this.colOzelKod2.VisibleIndex = 19;
            // 
            // colOzelKod3
            // 
            this.colOzelKod3.FieldName = "OzelKod3";
            this.colOzelKod3.Name = "colOzelKod3";
            this.colOzelKod3.Visible = true;
            this.colOzelKod3.VisibleIndex = 20;
            // 
            // colOzelKod4
            // 
            this.colOzelKod4.FieldName = "OzelKod4";
            this.colOzelKod4.Name = "colOzelKod4";
            this.colOzelKod4.Visible = true;
            this.colOzelKod4.VisibleIndex = 21;
            // 
            // colVergiDairesi
            // 
            this.colVergiDairesi.FieldName = "VergiDairesi";
            this.colVergiDairesi.Name = "colVergiDairesi";
            this.colVergiDairesi.Visible = true;
            this.colVergiDairesi.VisibleIndex = 22;
            // 
            // colVergiNo
            // 
            this.colVergiNo.FieldName = "VergiNo";
            this.colVergiNo.Name = "colVergiNo";
            this.colVergiNo.Visible = true;
            this.colVergiNo.VisibleIndex = 23;
            // 
            // colIskontoOrani
            // 
            this.colIskontoOrani.FieldName = "IskontoOrani";
            this.colIskontoOrani.Name = "colIskontoOrani";
            this.colIskontoOrani.Visible = true;
            this.colIskontoOrani.VisibleIndex = 24;
            // 
            // colRiskLimit
            // 
            this.colRiskLimit.FieldName = "RiskLimit";
            this.colRiskLimit.Name = "colRiskLimit";
            this.colRiskLimit.Visible = true;
            this.colRiskLimit.VisibleIndex = 25;
            // 
            // colAlisOzelFiyati
            // 
            this.colAlisOzelFiyati.FieldName = "AlisOzelFiyati";
            this.colAlisOzelFiyati.Name = "colAlisOzelFiyati";
            this.colAlisOzelFiyati.Visible = true;
            this.colAlisOzelFiyati.VisibleIndex = 26;
            // 
            // colSatisOzelFiyati
            // 
            this.colSatisOzelFiyati.FieldName = "SatisOzelFiyati";
            this.colSatisOzelFiyati.Name = "colSatisOzelFiyati";
            this.colSatisOzelFiyati.Visible = true;
            this.colSatisOzelFiyati.VisibleIndex = 27;
            // 
            // colAciklama
            // 
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 28;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.cariBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1166, 556);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // cariBindingSource
            // 
            this.cariBindingSource.DataSource = typeof(MGsTok.Entities.Tables.Cari);
            // 
            // colAlacak
            // 
            this.colAlacak.Caption = "gridColumn1";
            this.colAlacak.Name = "colAlacak";
            this.colAlacak.Visible = true;
            this.colAlacak.VisibleIndex = 29;
            // 
            // colBorc
            // 
            this.colBorc.Caption = "gridColumn1";
            this.colBorc.Name = "colBorc";
            this.colBorc.Visible = true;
            this.colBorc.VisibleIndex = 30;
            // 
            // colBakiye
            // 
            this.colBakiye.Caption = "gridColumn1";
            this.colBakiye.Name = "colBakiye";
            this.colBakiye.Visible = true;
            this.colBakiye.VisibleIndex = 31;
            // 
            // FrmCariSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 556);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.lblBaslık);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmCariSec";
            this.Text = "FrmCariSec";
            this.Load += new System.EventHandler(this.FrmCariSec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cariBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSec;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl lblBaslık;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDurumu;
        private DevExpress.XtraGrid.Columns.GridColumn colCariTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colCariKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colCariAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colYetkiliKisi;
        private DevExpress.XtraGrid.Columns.GridColumn colFaturaUnvani;
        private DevExpress.XtraGrid.Columns.GridColumn colCepTelefonu;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefon;
        private DevExpress.XtraGrid.Columns.GridColumn colFax;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colWebAdresi;
        private DevExpress.XtraGrid.Columns.GridColumn colIl;
        private DevExpress.XtraGrid.Columns.GridColumn colIlce;
        private DevExpress.XtraGrid.Columns.GridColumn colSemt;
        private DevExpress.XtraGrid.Columns.GridColumn colAdres;
        private DevExpress.XtraGrid.Columns.GridColumn colCariGrubu;
        private DevExpress.XtraGrid.Columns.GridColumn colCariAltGrubu;
        private DevExpress.XtraGrid.Columns.GridColumn colOzelKod1;
        private DevExpress.XtraGrid.Columns.GridColumn colOzelKod2;
        private DevExpress.XtraGrid.Columns.GridColumn colOzelKod3;
        private DevExpress.XtraGrid.Columns.GridColumn colOzelKod4;
        private DevExpress.XtraGrid.Columns.GridColumn colVergiDairesi;
        private DevExpress.XtraGrid.Columns.GridColumn colVergiNo;
        private DevExpress.XtraGrid.Columns.GridColumn colIskontoOrani;
        private DevExpress.XtraGrid.Columns.GridColumn colRiskLimit;
        private DevExpress.XtraGrid.Columns.GridColumn colAlisOzelFiyati;
        private DevExpress.XtraGrid.Columns.GridColumn colSatisOzelFiyati;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private System.Windows.Forms.BindingSource cariBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colAlacak;
        private DevExpress.XtraGrid.Columns.GridColumn colBorc;
        private DevExpress.XtraGrid.Columns.GridColumn colBakiye;
    }
}