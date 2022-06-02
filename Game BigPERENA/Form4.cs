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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ответ на этот вопрос, как ни странно, зависит от того, чем тёмная материя окажется. Одни её формы можно вычислить из-за мельчайших контактов с обычным веществом, а в остальное время они окажутся неуловимы. Другие же могут быть обнаружены по их воздействию на огромные структуры вроде галактик. Узнать новые детали мы сможем только в процессе наблюдений и экспериментов. Но результат предсказать трудно.", "Верно!");

            Form5 af = new Form5();
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

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            Home af = new Home();
            af.Show();
        }
    }
}
