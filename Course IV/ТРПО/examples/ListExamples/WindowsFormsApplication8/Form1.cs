using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; textBox1.Focus(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
            textBox1.Text = "";
            textBox1.Focus(); 

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = comboBox1.SelectedIndex;
            if (i != -1)
            {
                comboBox1.Items.Insert(i, textBox1.Text);
                textBox1.Text = "";
                textBox1.Focus();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = comboBox1.SelectedIndex;
            if (i != -1)
            comboBox1.Items.RemoveAt(i); 

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i = comboBox1.SelectedIndex;
            if (i!=-1)
            listBox1.Items.Add(comboBox1.Items[i]); 

        }
 

    }
}
