namespace MGsTok.BackOffice.Döviz_Kurları
{
    partial class FrmDovizKurlari
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIsim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSembol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colForexBuying = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colForexSelling = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBanknoteBuying = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBanknoteSelling = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 463);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(861, 62);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Menü";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(636, 23);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(85, 34);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Güncelle";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(861, 463);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIsim,
            this.colSembol,
            this.colForexBuying,
            this.colForexSelling,
            this.colBanknoteBuying,
            this.colBanknoteSelling});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colIsim
            // 
            this.colIsim.Caption = "İsim";
            this.colIsim.FieldName = "Isim";
            this.colIsim.Name = "colIsim";
            this.colIsim.Visible = true;
            this.colIsim.VisibleIndex = 0;
            // 
            // colSembol
            // 
            this.colSembol.Caption = "Sembol";
            this.colSembol.FieldName = "CurrencyCode";
            this.colSembol.Name = "colSembol";
            this.colSembol.Visible = true;
            this.colSembol.VisibleIndex = 1;
            // 
            // colForexBuying
            // 
            this.colForexBuying.Caption = "Forex Alış";
            this.colForexBuying.FieldName = "ForexBuying";
            this.colForexBuying.Name = "colForexBuying";
            this.colForexBuying.Visible = true;
            this.colForexBuying.VisibleIndex = 2;
            // 
            // colForexSelling
            // 
            this.colForexSelling.Caption = "Forex Satış";
            this.colForexSelling.FieldName = "ForexSelling";
            this.colForexSelling.Name = "colForexSelling";
            this.colForexSelling.Visible = true;
            this.colForexSelling.VisibleIndex = 3;
            // 
            // colBanknoteBuying
            // 
            this.colBanknoteBuying.Caption = "Banknot Alış";
            this.colBanknoteBuying.FieldName = "BanknoteBuying";
            this.colBanknoteBuying.Name = "colBanknoteBuying";
            this.colBanknoteBuying.Visible = true;
            this.colBanknoteBuying.VisibleIndex = 4;
            // 
            // colBanknoteSelling
            // 
            this.colBanknoteSelling.Caption = "Banknot Satış";
            this.colBanknoteSelling.FieldName = "BanknoteSelling";
            this.colBanknoteSelling.Name = "colBanknoteSelling";
            this.colBanknoteSelling.Visible = true;
            this.colBanknoteSelling.VisibleIndex = 5;
            // 
            // FrmDovizKurlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 525);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmDovizKurlari";
            this.Text = "Döviz Kurları";
            this.Load += new System.EventHandler(this.FrmDovizKurlari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIsim;
        private DevExpress.XtraGrid.Columns.GridColumn colSembol;
        private DevExpress.XtraGrid.Columns.GridColumn colForexBuying;
        private DevExpress.XtraGrid.Columns.GridColumn colForexSelling;
        private DevExpress.XtraGrid.Columns.GridColumn colBanknoteBuying;
        private DevExpress.XtraGrid.Columns.GridColumn colBanknoteSelling;
    }
}