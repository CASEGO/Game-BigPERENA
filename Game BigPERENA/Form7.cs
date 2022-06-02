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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Да, сможет! Так как в этой сфере ведутся масштабные разработки", "Верно!");

            MessageBox.Show(" Ответ неверный. Попробуй еще раз", "Неверно!");
            return;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Другие виды решения конфликтов уже начинают устаревать. Скоро все придет в равновесие, поэтому все недопонимания будут решаться путем переговоров.", "Верно!");

            Form8 af = new Form8();
            af.Owner = this;
            af.Show();
            this.Hide();
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
