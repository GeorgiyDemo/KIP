using System;
using System.Drawing;
using System.Windows.Forms;

namespace AllFormsExample
{
    public partial class ListExampleForm : Form
    {
        public ListExampleForm(Color meow, FormStartPosition startscreen)
        {
            StartPosition = startscreen;
            BackColor = meow;
            InitializeComponent();
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
            if (i != -1)
                listBox1.Items.Add(comboBox1.Items[i]);

        }
    }
}
