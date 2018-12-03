using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace ThreadExample1
{
    public partial class Forml : Form
    {
      
        string ИмяФайла;

        public Forml()
        {
            InitializeComponent();
        }

        private void Forml_Load(object sender, EventArgs e)
        {
            textBoxl.Multiline = true; textBoxl.Clear();
            textBoxl.Size = new Size(268, 112);
            buttonl.Text = "Открыть";
            buttonl.TabIndex = 0;
            button2.Text = "Сохранить";
            this.Text = "Здесь кодировка Unicode";
            ИмяФайла = "../../../input.txt";
        }

        private void buttonl_Click(object sender, EventArgs e)
        {
            try
            {
                var Читатель = new StreamReader(ИмяФайла);
                textBoxl.Text = Читатель.ReadToEnd();
                Читатель.Close();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message + "\n" +"Такого файла не существует ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception otherex)
            {  
                MessageBox.Show(otherex.Message, "Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var Писатель = new StreamWriter(ИмяФайла, false);
                Писатель.Write(textBoxl.Text);
                Писатель.Close();
                File.WriteAllText(@"D:\tmp.tmp", textBoxl.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}