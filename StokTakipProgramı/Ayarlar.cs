using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipProgramı
{
    public partial class Ayarlar : Form
    {
        public Ayarlar()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }

        private void btniletisim_Click(object sender, EventArgs e)
        {
            info info = new info();
            info.Show();
        }

        private void Ayarlar_Load(object sender, EventArgs e)
        {
            TemaT cls = new TemaT();
            cls.TemaDegistir();
            this.BackColor = TemaT.tema;
            foreach (Label l in Controls.OfType<Label>())
                l.ForeColor = TemaT.font;
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            KullaniciAyarlari kullaniciA = new KullaniciAyarlari();
            kullaniciA.Show();
        }

        private void btnTema_Click(object sender, EventArgs e)
        {
            TemaTercih temaTercih = new TemaTercih();
            temaTercih.Show();
            this.Hide();
        }
    }
}
