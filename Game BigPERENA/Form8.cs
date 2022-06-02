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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Уже в наше время идут обширные работы по сохранению природного достояния", "Верно!");

            Form9 af = new Form9();
            af.Owner = this;
            af.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Ответ неверный. Попробуй еще раз", "Неверно!");
            return;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Ответ неверный. Попробуй еще раз", "Неверно!");
            return;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            Home af = new Home();
            af.Show();
        }
    }
}
