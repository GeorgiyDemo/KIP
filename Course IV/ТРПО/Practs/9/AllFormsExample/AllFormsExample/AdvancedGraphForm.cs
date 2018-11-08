using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllFormsExample
{
    public partial class AdvancedGraphForm : Form
    {
        bool drawing; GraphicsPath currentPath; Point oldLocation; Pen currentPen;

        public AdvancedGraphForm()
        {
            InitializeComponent();
            drawing = false;
            currentPen = new Pen(Color.Black);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void picDrawingSurface_MouseDown(object sender, MouseEventArgs e)
        {
            if (picDrawingSurface.Image == null)
            {
                MessageBox.Show("Сначала создайте новый файл!");
                return;
            }
            if (e.Button == MouseButtons.Left)
            {
                drawing = true;
                oldLocation = e.Location;
                currentPath = new GraphicsPath();
            }
        }

        private void picDrawingSurface_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
            try
            {
                currentPath.Dispose();
            }

            catch
            {
            };
        }


        private void picDrawingSurface_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                Graphics g = Graphics.FromImage(picDrawingSurface.Image);
                currentPath.AddLine(oldLocation, e.Location);
                g.DrawPath(currentPen, currentPath);
                oldLocation = e.Location; g.Dispose();
                picDrawingSurface.Invalidate();
            }
        }
        private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (picDrawingSurface.Image != null)
            {
                var result = MessageBox.Show("Сохранить текущее изображение перед созданием нового рисунка?", "Предупреждение", MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.No:
                        break;
                    case DialogResult.Yes:
                        сохранитьToolStripMenuItem_Click(sender, e);
                        break;
                    case DialogResult.Cancel:
                        return;
                }
            }
            Bitmap pic = new Bitmap(614, 300);
            picDrawingSurface.Image = pic;
            Graphics grf = Graphics.FromImage(pic);
            grf.Clear(Color.White);
            picDrawingSurface.Image = pic;
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveDlg = new SaveFileDialog();
            SaveDlg.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png";
            SaveDlg.Title = "Save an Image File";
            SaveDlg.FilterIndex = 4;
            SaveDlg.ShowDialog();


            if (SaveDlg.FileName != "")

            {
                System.IO.FileStream fs = (System.IO.FileStream)SaveDlg.OpenFile();
                switch (SaveDlg.FilterIndex)
                {
                    case 1:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Jpeg);
                        break;
                    case 2:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Bmp);
                        break;
                    case 3:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Gif);
                        break;
                    case 4:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Png);
                        break;
                }
                fs.Close();
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OP = new OpenFileDialog();
            OP.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png";
            OP.Title = "Open an Image File";
            OP.FilterIndex = 1;
            if (OP.ShowDialog() != DialogResult.Cancel)
                picDrawingSurface.Load(OP.FileName);
            picDrawingSurface.AutoSize = true;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            новыйToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            сохранитьToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            открытьToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
        }
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void пунктирToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void твердыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void точечныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void карандашToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void шагНазадToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void шагВпередToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

    }
}
