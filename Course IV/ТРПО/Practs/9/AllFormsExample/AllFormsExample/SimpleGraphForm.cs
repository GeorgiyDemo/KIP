using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace AllFormsExample
{
    public partial class SimpleGraphForm : Form
    {
        public SimpleGraphForm(Color meow)
        {
            this.BackColor = meow;
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
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

        private void ВолгаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainLabel.Text = "На картинке река Волга";
            LoadImg("../../../jpg/volga.jpg");
        }

        private void МоскваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainLabel.Text = "На картинке река Москва";
            LoadImg("../../../jpg/moskva.jpg");
        }

        private void ОкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainLabel.Text = "На картинке река Ока";
            LoadImg("../../../jpg/oka.jpg");
        }

        private void ЧерноеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainLabel.Text = "На картинке Черное море";
            LoadImg("../../../jpg/black.jpg");
        }

        private void БалтийскоеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainLabel.Text = "На картинке Балтийское море";
            LoadImg("../../../jpg/balta.jpg");
        }

        private void АзовскоеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainLabel.Text = "На картинке Азовское море";
            LoadImg("../../../jpg/azov.jpg");
        }

        private void ЛадожскоеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainLabel.Text = "На картинке Ладожское озеро";
            LoadImg("../../../jpg/ladoshskoye.jpg");
        }

        private void ОнежскоеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainLabel.Text = "На картинке Онежское озеро";
            LoadImg("../../../jpg/oneshskoye.jpg");
        }

        private void БайкалToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainLabel.Text = "На картинке озеро Байкал";
            LoadImg("../../../jpg/baykal.jpg");
        }

        private void открытьИзФайлаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.PNG)| *.bmp; *.jpg; *.gif; *.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(dialog.FileName);
                int width = image.Width;
                int height = image.Height;
                pictureBox1.Width = width;
                pictureBox1.Height = height;
                pictureBox1.Image = image;
                MainLabel.Text = "Ваше загруженное изображение:";
            }

        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image.Save("../../../output.jpg", ImageFormat.Jpeg);
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Не загружено изображение");
            }
        }

        private void рисункиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

