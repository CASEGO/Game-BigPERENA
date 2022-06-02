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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            Home af = new Home();
            af.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Ответ неверный. Попробуй еще раз", "Неверно!");
            return;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Температура большаая, да и техники на данный момент нету, которая может ее выдержать.", "Верно!");
            
            Form2 af = new Form2();
            af.Owner = this;
            af.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Ответ неверный. Попробуй еще раз", "Неверно!");
            return;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form2 af = new Form2();
            af.Owner = this;
            af.Show();
            this.Hide();
        }
    }
}
