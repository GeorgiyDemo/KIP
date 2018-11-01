using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void частиСветаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void LoadImg(string path)
        {
            Image image = Image.FromFile(path);
            int width = image.Width;
            int height = image.Height;
            pictureBox1.Image = image;
            pictureBox1.Width = width;
            pictureBox1.Height = height;
        }

        private void сиреньToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadImg(@"\\Mac\Home\Desktop\photo\1-700x525.jpg");
        }

        private void астраToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadImg(@"\\Mac\Home\Desktop\photo\astra1.jpg");
        }

        private void пионToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadImg(@"\\Mac\Home\Desktop\photo\.jpg");
        }
    }
}
