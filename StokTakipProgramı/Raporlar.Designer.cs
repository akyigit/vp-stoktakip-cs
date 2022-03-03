
namespace StokTakipProgramı
{
    partial class Raporlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Raporlar));
            this.btnKasaDurum = new System.Windows.Forms.Button();
            this.btnKarAnaliz = new System.Windows.Forms.Button();
            this.btnIslemKontrol = new System.Windows.Forms.Button();
            this.btnStokDurum = new System.Windows.Forms.Button();
            this.gridRapor = new System.Windows.Forms.DataGridView();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.gridRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKasaDurum
            // 
            this.btnKasaDurum.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnKasaDurum.Location = new System.Drawing.Point(195, 50);
            this.btnKasaDurum.Margin = new System.Windows.Forms.Padding(2);
            this.btnKasaDurum.Name = "btnKasaDurum";
            this.btnKasaDurum.Size = new System.Drawing.Size(124, 38);
            this.btnKasaDurum.TabIndex = 2;
            this.btnKasaDurum.Text = "Kasa Durum Raporu";
            this.btnKasaDurum.UseVisualStyleBackColor = false;
            this.btnKasaDurum.Click += new System.EventHandler(this.btnKasaDurum_Click);
            // 
            // btnKarAnaliz
            // 
            this.btnKarAnaliz.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnKarAnaliz.Location = new System.Drawing.Point(542, 50);
            this.btnKarAnaliz.Margin = new System.Windows.Forms.Padding(2);
            this.btnKarAnaliz.Name = "btnKarAnaliz";
            this.btnKarAnaliz.Size = new System.Drawing.Size(124, 38);
            this.btnKarAnaliz.TabIndex = 4;
            this.btnKarAnaliz.Text = "Kar Analiz Raporu";
            this.btnKarAnaliz.UseVisualStyleBackColor = false;
            this.btnKarAnaliz.Click += new System.EventHandler(this.btnKarAnaliz_Click);
            // 
            // btnIslemKontrol
            // 
            this.btnIslemKontrol.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnIslemKontrol.Location = new System.Drawing.Point(18, 50);
            this.btnIslemKontrol.Margin = new System.Windows.Forms.Padding(2);
            this.btnIslemKontrol.Name = "btnIslemKontrol";
            this.btnIslemKontrol.Size = new System.Drawing.Size(124, 38);
            this.btnIslemKontrol.TabIndex = 1;
            this.btnIslemKontrol.Text = "Islem Kontrol Raporu";
            this.btnIslemKontrol.UseVisualStyleBackColor = false;
            this.btnIslemKontrol.Click += new System.EventHandler(this.btnIslemKontrol_Click);
            // 
            // btnStokDurum
            // 
            this.btnStokDurum.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnStokDurum.Location = new System.Drawing.Point(366, 50);
            this.btnStokDurum.Margin = new System.Windows.Forms.Padding(2);
            this.btnStokDurum.Name = "btnStokDurum";
            this.btnStokDurum.Size = new System.Drawing.Size(124, 38);
            this.btnStokDurum.TabIndex = 3;
            this.btnStokDurum.Text = "Stok Durum Raporu";
            this.btnStokDurum.UseVisualStyleBackColor = false;
            this.btnStokDurum.Click += new System.EventHandler(this.btnStokDurum_Click);
            // 
            // gridRapor
            // 
            this.gridRapor.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gridRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRapor.Location = new System.Drawing.Point(18, 142);
            this.gridRapor.Margin = new System.Windows.Forms.Padding(2);
            this.gridRapor.Name = "gridRapor";
            this.gridRapor.ReadOnly = true;
            this.gridRapor.RowHeadersVisible = false;
            this.gridRapor.RowHeadersWidth = 51;
            this.gridRapor.RowTemplate.Height = 24;
            this.gridRapor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridRapor.Size = new System.Drawing.Size(647, 384);
            this.gridRapor.TabIndex = 12;
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnExcel.Location = new System.Drawing.Point(134, 548);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(214, 33);
            this.btnExcel.TabIndex = 13;
            this.btnExcel.Text = "Mevcut Tabloyu Excel Oluştur";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnYazdir
            // 
            this.btnYazdir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnYazdir.Location = new System.Drawing.Point(354, 548);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(214, 33);
            this.btnYazdir.TabIndex = 14;
            this.btnYazdir.Text = "Mevcut Tabloyu Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = false;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Raporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(686, 599);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.gridRapor);
            this.Controls.Add(this.btnStokDurum);
            this.Controls.Add(this.btnIslemKontrol);
            this.Controls.Add(this.btnKarAnaliz);
            this.Controls.Add(this.btnKasaDurum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Raporlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Takip Programı - Raporlar";
            this.Load += new System.EventHandler(this.Raporlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridRapor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKasaDurum;
        private System.Windows.Forms.Button btnKarAnaliz;
        private System.Windows.Forms.Button btnIslemKontrol;
        private System.Windows.Forms.Button btnStokDurum;
        private System.Windows.Forms.DataGridView gridRapor;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnYazdir;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}