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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            Home af = new Home();
            af.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Ответ неверный. Попробуй еще раз", "Неверно!");
            return;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
            Form6 af = new Form6();
            af.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Возможно, это не будет лекарство как таковое, но я очень надеюсь, что в ближайшее десятилетие мы найдём достойное средство, которое сможет модифицировать болезнь Альцгеймера. Сейчас огромные ресурсы направлены на возможность профилактики заболевания до того, как появятся первые симптомы. Ведь если удастся задержать деменцию на 5–10 лет, то многие пожилые люди смогут закончить жизнь, танцуя балет, а не в доме престарелых.", "Верно!");

            Form6 af = new Form6();
            af.Owner = this;
            af.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
