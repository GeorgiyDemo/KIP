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
            SimpleGraphForm obj1 = new SimpleGraphForm(BackColor, StartPosition);
            obj1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DatabaseForm obj2 = new DatabaseForm(BackColor, StartPosition);
            obj2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SimpleGraphForm obj3 = new SimpleGraphForm(BackColor, StartPosition);
            obj3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UntraditionalForms obj4 = new UntraditionalForms(BackColor, StartPosition);
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

        private void button5_Click(object sender, EventArgs e)
        {
            ProgressBarForm obj5 = new ProgressBarForm(BackColor, StartPosition);
            obj5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ListExampleForm obj6 = new ListExampleForm(BackColor, StartPosition);
            obj6.Show();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            PaintForm obj7 = new PaintForm(BackColor, StartPosition);
            obj7.Show();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            GraphForm obj8 = new GraphForm(BackColor, StartPosition);
            obj8.Show();
        }
        private void поУмолчанияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.WindowsDefaultLocation;
        }

        private void центрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void аАToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1000, 1000);
        }
    }
}
