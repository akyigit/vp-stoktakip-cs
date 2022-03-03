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
    public partial class AddMarka : Form
    {
        public DateTime tarih = DateTime.Now;
        public AddMarka()
        {
            InitializeComponent();
        }
        STOKTAKIPEntities db = new STOKTAKIPEntities();
        private void btnKayit_Click(object sender, EventArgs e)
        {
            Markalar marka = new Markalar();
            marka.Adi = txtMarka.Text;
            marka.InsertDate = tarih;
            marka.IsDeleted = false;
            db.Markalar.Add(marka);
            db.SaveChanges();
            txtMarka.Text = null;
           MessageBox.Show("Kayıt gerçekleşti. Yenile butonuna basmanız gerekmektedir.");
            
        }

        private void txtMarka_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==Keys.Enter)
            {
                Markalar marka = new Markalar();
                marka.Adi = txtMarka.Text;
                marka.InsertDate = tarih;
                marka.IsDeleted = false;
                db.Markalar.Add(marka);
                db.SaveChanges();
                txtMarka.Text = null;
                MessageBox.Show("Kayıt gerçekleşti. Yenile butonuna basmanız gerekmektedir.");
                
            }
        }

        private void AddMarka_Load(object sender, EventArgs e)
        {
            TemaT cls = new TemaT();
            cls.TemaDegistir();
            this.BackColor = TemaT.tema;
            foreach (Label l in Controls.OfType<Label>())
                l.ForeColor = TemaT.font;
        }
    }
}
