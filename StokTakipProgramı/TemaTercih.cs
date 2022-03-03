using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Collections;

namespace StokTakipProgramı
{
    public partial class TemaTercih : Form
    {

        //string connString = @"Data Source=localhost\sqlexpress; Initial Catalog=STOKTAKIP; Integrated Security=True;";
        SqlConnection con = new SqlConnection("Data Source=localhost\\sqlexpress; Initial Catalog=STOKTAKIP; Integrated Security=True;");

        public TemaTercih()
        {
            InitializeComponent();
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            this.Close();
            Ayarlar ayarlar = new Ayarlar();
            ayarlar.Show();
        }

        TemaT temaT = new TemaT();

        

        private void dnzToggleButton2_CheckedChanged(object sender, EventArgs e)
        {
            /*if (dnzToggleButton2.Checked)
            {
                this.BackColor = Color.SlateGray;
                cbTema1.ForeColor = Color.WhiteSmoke;
                cbTema2.ForeColor = Color.WhiteSmoke;
                cbTema3.ForeColor = Color.WhiteSmoke;
                lblAciklama.ForeColor = Color.WhiteSmoke;
            }
            else
            {
                this.BackColor = Color.LightBlue;
                cbTema1.ForeColor = Color.Black;
                cbTema2.ForeColor = Color.Black;
                cbTema3.ForeColor = Color.Black;
                lblAciklama.ForeColor = Color.Black;
            }*/
        }

        private void dnzToggleButton3_CheckedChanged(object sender, EventArgs e)
        {
           /* if (dnzToggleButton3.Checked)
            {
                this.BackColor = Color.Black;
                cbTema1.ForeColor = Color.WhiteSmoke;
                cbTema2.ForeColor = Color.WhiteSmoke;
                cbTema3.ForeColor = Color.WhiteSmoke;
                lblAciklama.ForeColor = Color.WhiteSmoke;
            }
            else
            {
                this.BackColor = Color.DarkGray;
                cbTema1.ForeColor = Color.Black;
                cbTema2.ForeColor = Color.Black;
                cbTema3.ForeColor = Color.Black;
                lblAciklama.ForeColor = Color.Black;
            }*/
        }

        private void btnKoyu_Click(object sender, EventArgs e)
        {
            SqlCommand degistir = new SqlCommand("UPDATE Temalar SET TEMA = @tema WHERE ID='1'", con);
            degistir.Parameters.AddWithValue("@tema", "1");
            con.Open();
            degistir.ExecuteNonQuery();
            con.Close();
            temaT.TemaDegistir();
            this.BackColor = TemaT.tema;
            foreach (Label l in Controls.OfType<Label>())
                l.ForeColor = TemaT.font;

        }

        private void btnAcik_Click(object sender, EventArgs e)
        {
            //this.BackColor = Color.Red;
            SqlCommand degistir = new SqlCommand("UPDATE Temalar SET TEMA = @tema WHERE ID='1'", con);
            degistir.Parameters.AddWithValue("@tema", "2");
            con.Open();
            degistir.ExecuteNonQuery();
            con.Close();
            temaT.TemaDegistir();
            this.BackColor = TemaT.tema;
            foreach (Label l in Controls.OfType<Label>())
                l.ForeColor = TemaT.font;

        }

        private void TemaTercih_Load(object sender, EventArgs e)
        {
            TemaT cls = new TemaT();
            cls.TemaDegistir();
            this.BackColor = TemaT.tema;
            foreach (Label l in Controls.OfType<Label>())
                l.ForeColor = TemaT.font;
        }
    }
}
