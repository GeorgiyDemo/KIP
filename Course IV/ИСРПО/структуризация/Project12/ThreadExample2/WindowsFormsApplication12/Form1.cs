using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication12
{
    public partial class Form1 : Form
    {
        string filename;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxl.Multiline = true;
            textBoxl.Clear();
            textBoxl.Size = new Size(268, 112);
            buttonl.Text = "Открыть";
            buttonl.TabIndex = 0;
            button2.Text = "Сохранить";
            this.Text = "Здесь кодировка Windows 1251";
            filename = "Text2.txt";
        }

        private void buttonl_Click(object sender, EventArgs e)
        {
            try
            {
                var code = System.Text.Encoding.GetEncoding(1251);
                var read = new StreamReader(filename, code);
                textBoxl.Text = read.ReadToEnd();
                read.Close();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message + "\nНет такого файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            catch (Exception Ситуация)
            {
                MessageBox.Show(Ситуация.Message, "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var code = System.Text.Encoding.GetEncoding(1251);
                var writer = new StreamWriter(filename, false, code);
                writer.Write(textBoxl.Text);
                writer.Close();
            }
            catch (Exception azrx)
            {
                MessageBox.Show(azrx.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
} 
