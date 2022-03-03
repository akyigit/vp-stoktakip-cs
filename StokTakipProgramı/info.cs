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
    public partial class info : Form
    {
        public info()
        {
            InitializeComponent();
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void info_Load(object sender, EventArgs e)
        {
            TemaT cls = new TemaT();
            cls.TemaDegistir();
            this.BackColor = TemaT.tema;
            foreach (Label l in Controls.OfType<Label>())
                l.ForeColor = TemaT.font;
        }
    }
}
