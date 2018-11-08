using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllFormsExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MainTextLabel.Text = "Изучение основ языка программирования Visual С#\nКомплекс практических работ по ТРПО\nCтудента группы 4ПКС-115 Деменчука Г.М.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SimpleGraphForm obj1 = new SimpleGraphForm(BackColor);
            obj1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Не работает");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SimpleGraphForm obj3 = new SimpleGraphForm(BackColor);
            obj3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UntraditionalForms obj4 = new UntraditionalForms(BackColor);
            obj4.Show();
        }

        private void синийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void сбросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
        }

        private void красныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void зеленыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void белыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
