using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace WindowsFormsApp2
{

    public partial class Form1 : Form
    {
        Color historyColor;
        bool drawing; GraphicsPath currentPath; Point oldLocation; Pen currentPen;

        public Form1()
        {
            InitializeComponent();
            drawing = false;
            currentPen = new Pen(Color.Black);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Bitmap pic = new Bitmap(750, 500); picDrawingSurface.Image = pic;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap pic = new Bitmap(712, 360); picDrawingSurface.Image = pic;
        }

        private void picDrawingSurface_MouseDown(object sender, MouseEventArgs e)
        {
            if (picDrawingSurface.Image == null) { MessageBox.Show("Сначала создайте новый файл!"); return; }
                if (e.Button == MouseButtons.Left) { drawing = true; oldLocation = e.Location;
                    currentPath = new GraphicsPath(); } 

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void penToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
       
        private void picDrawingSurface_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false; try { currentPath.Dispose(); } catch { }; }

        private void picDrawingSurface_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (drawing) { Graphics g = Graphics.FromImage(picDrawingSurface.Image); currentPath.AddLine(oldLocation, e.Location); g.DrawPath(currentPen, currentPath); oldLocation = e.Location; g.Dispose(); picDrawingSurface.Invalidate(); }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            open();
        }

        void open()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.BMP, *.JPG, " + "*.GIF, *.PNG)| *.bmp; *.jpg; *.gif; *.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(dialog.FileName);
                int width = image.Width;
                int height = image.Height;
                picDrawingSurface.Image = image;
                picDrawingSurface.Width = width;
                picDrawingSurface.Height = height;
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            save();
        }

        void save()
        {
            SaveFileDialog SaveDlg = new SaveFileDialog(); SaveDlg.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png"; SaveDlg.Title = "Save an Image File"; SaveDlg.FilterIndex = 4;
            if (SaveDlg.FileName != "")
            { System.IO.FileStream fs = (System.IO.FileStream)SaveDlg.OpenFile(); switch (SaveDlg.FilterIndex) {
                    case 1: this.picDrawingSurface.Image.Save(fs, ImageFormat.Jpeg); break;
                    case 2: this.picDrawingSurface.Image.Save(fs, ImageFormat.Bmp); break;
                    case 3: this.picDrawingSurface.Image.Save(fs, ImageFormat.Gif); break;
                    case 4: this.picDrawingSurface.Image.Save(fs, ImageFormat.Png); break;
            } fs.Close(); }
        }
        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            open();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }
    }

}
