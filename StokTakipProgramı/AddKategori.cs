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
    public partial class AddKategori : Form
    {
        public DateTime tarih = DateTime.Now;
        public AddKategori()
        {
            InitializeComponent();
        }
        STOKTAKIPEntities db = new STOKTAKIPEntities();
        private void txtKategori_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                Kategoriler kategori = new Kategoriler();
                kategori.Ad = txtKategori.Text;
                kategori.InsertDate = tarih;
                kategori.IsDeleted = false;
                db.Kategoriler.Add(kategori);
                db.SaveChanges();
                txtKategori.Text = null;
                MessageBox.Show("Kayıt gerçekleşti. Yenile butonuna basmanız gerekmektedir.");
                
                
                
            }
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            Kategoriler kategori = new Kategoriler();
            kategori.Ad = txtKategori.Text;
            kategori.InsertDate = tarih;
            kategori.IsDeleted = false;
            db.Kategoriler.Add(kategori);
            db.SaveChanges();
            txtKategori.Text = null;
            MessageBox.Show("Kayıt gerçekleşti. Yenile butonuna basmanız gerekmektedir.");
           
        }

        private void AddKategori_Load(object sender, EventArgs e)
        {
            TemaT cls = new TemaT();
            cls.TemaDegistir();
            this.BackColor = TemaT.tema;
            foreach (Label l in Controls.OfType<Label>())
                l.ForeColor = TemaT.font;
        }
    }
}
