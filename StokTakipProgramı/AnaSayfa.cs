using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StokTakipProgramı
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.G && Control.ModifierKeys == Keys.Control)
            {
                this.BackColor = Color.WhiteSmoke;
            }
            else if (e.KeyCode == Keys.H && Control.ModifierKeys ==Keys.Control)
            {
                this.BackColor = Color.DimGray;
            }
        }

        private void AnaSayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*DialogResult dResult = new DialogResult(); 
            dResult = MessageBox.Show("Çıkış yapılsın mı?", "Çıkış", MessageBoxButtons.YesNo);
            if (dResult == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }*/
        }

        private void AnaSayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            //ConfigPage configPage = new ConfigPage();
            //configPage.Show();
            // Tekrar giriş yapılmazsa programı kapat
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            CariHesaplar cariHesaplar = new CariHesaplar();
            cariHesaplar.Show();
        }

        private void btnKD_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnAyar_Click(object sender, EventArgs e)
        {
            Ayarlar ayarlar = new Ayarlar();
            ayarlar.Show();
            this.Hide();
        }

        private void btnStokIslem_Click(object sender, EventArgs e)
        {
            StokIslemleri stokIslemleri = new StokIslemleri();
            stokIslemleri.Show();
        }

        private void btnStokTanim_Click(object sender, EventArgs e)
        {
            StokTanimlama stokTanimlama = new StokTanimlama();
            stokTanimlama.Show();
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            Raporlar raporlar = new Raporlar();
            raporlar.Show();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            TemaT cls = new TemaT();
            cls.TemaDegistir();
            this.BackColor = TemaT.tema;
            foreach (Label l in Controls.OfType<Label>())
                l.ForeColor = TemaT.font;
        }
    }
}
