using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_BigPERENA
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form1 af = new Form1();
            af.Owner = this;
            af.Show();
            this.Hide();
        }
    }
}
