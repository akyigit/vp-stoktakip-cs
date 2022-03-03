
namespace StokTakipProgramı
{
    partial class AddMarka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMarka));
            this.lblBilgi = new System.Windows.Forms.Label();
            this.btnKayit = new System.Windows.Forms.Button();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblBilgi
            // 
            this.lblBilgi.AutoSize = true;
            this.lblBilgi.Location = new System.Drawing.Point(16, 20);
            this.lblBilgi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(121, 13);
            this.lblBilgi.TabIndex = 5;
            this.lblBilgi.Text = "Yeni Marka Adını Giriniz:";
            // 
            // btnKayit
            // 
            this.btnKayit.Location = new System.Drawing.Point(105, 78);
            this.btnKayit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(72, 27);
            this.btnKayit.TabIndex = 4;
            this.btnKayit.Text = "Kayıt";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(18, 44);
            this.txtMarka.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(160, 20);
            this.txtMarka.TabIndex = 3;
            this.txtMarka.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMarka_KeyDown);
            // 
            // AddMarka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 116);
            this.Controls.Add(this.lblBilgi);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.txtMarka);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddMarka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marka Ekle";
            this.Load += new System.EventHandler(this.AddMarka_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.TextBox txtMarka;
    }
}