using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        bool drawingLine, drawingRectangle, drawingCircle, drawingEllipse, FillFigureFlag;
        int startX, startY;
        GraphicsPath currentPath;
        Rectangle currentRectangle;
        Point oldLocation;
        Pen currentPen;
        Color historyColor;
        bool flagRectangle, flagCircle, flagEllipse;
        Image figureHistory;
        TextureBrush imageBrush;
        bool drawingimage, flagimage;
        //-------------

        int historyCounter; //Счетчик истории 


        List<Image> History; //Список для истории
        public Form1() { InitializeComponent();
            drawingLine = false;
            currentPen = new Pen(Color.Black);
            currentPen.Width = trackBarPen.Value;
            History = new List<Image>(); 
        }


        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (picDrawingSurface.Image != null) {
                var result = MessageBox.Show("Сохранить текущее изображение перед созданием нового рисунка?", "Предупреждение", MessageBoxButtons.YesNoCancel);
                switch (result) { case DialogResult.No: break;
                case DialogResult.Yes: сохранитьToolStripMenuItem_Click(sender, e); break; 
                case DialogResult.Cancel: return; } }

            Bitmap pic = new Bitmap(536, 358);
            using (var g = Graphics.FromImage(pic))
                g.Clear(Color.White);
            picDrawingSurface.Image = pic;
         History.Clear(); 
            historyCounter = 0;
                History.Add(new Bitmap(picDrawingSurface.Image)); 
        }

       

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveDlg = new SaveFileDialog(); 
            SaveDlg.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png"; 
            SaveDlg.Title = "Save an Image File"; 
            SaveDlg.FilterIndex = 4; //По умолчанию будет выбрано последнее расширение *.png 
            SaveDlg.ShowDialog();
if (SaveDlg.FileName != "") //Если введено не пустое имя 
            { System.IO.FileStream fs = (System.IO.FileStream)SaveDlg.OpenFile(); 
                switch (SaveDlg.FilterIndex) 
                { case 1: this.picDrawingSurface.Image.Save(fs, ImageFormat.Jpeg);
                    break; case 2: this.picDrawingSurface.Image.Save(fs, ImageFormat.Bmp);
                        break; case 3: this.picDrawingSurface.Image.Save(fs, ImageFormat.Gif); break;
                    case 4: this.picDrawingSurface.Image.Save(fs, ImageFormat.Png); break;   } 
    fs.Close(); }
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

        private void создатьToolStripButton_Click(object sender, EventArgs e)
        {
            if (picDrawingSurface.Image != null)
            {
                var result = MessageBox.Show("Сохранить текущее изображение перед созданием нового рисунка?", "Предупреждение", MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.No: break;
                    case DialogResult.Yes: сохранитьToolStripMenuItem_Click(sender, e); break;
                    case DialogResult.Cancel: return;
                }
            }

            Bitmap pic = new Bitmap(536, 358);
            using (var g = Graphics.FromImage(pic))
                g.Clear(Color.White);
            picDrawingSurface.Image = pic;
            History.Clear();
            historyCounter = 0;
            History.Add(new Bitmap(picDrawingSurface.Image)); 
        }

        private void picDrawingSurface_MouseUp(object sender, MouseEventArgs e)
        {
            if (drawingLine == true)
            {
                drawingLine = false;
                if (e.Button == MouseButtons.Right)
                {
                    currentPen.Color = historyColor;
                }

                try
                {
                    currentPath.Dispose();
                    History.RemoveRange(historyCounter + 1, History.Count - historyCounter - 1);
                    History.Add(new Bitmap(picDrawingSurface.Image));
                    if (historyCounter + 1 < 10) historyCounter++;
                    if (History.Count - 1 == 10)
                        History.RemoveAt(0);

                }
                catch { };
            }


            if (drawingRectangle == true)
            {
                drawingRectangle = false;
                flagRectangle = false;
            }



            if (drawingEllipse == true)
            {
                drawingEllipse = false;
                flagEllipse = false;
            }


            if (drawingCircle == true)
            {
                drawingCircle = false;
                flagCircle = false;
            }

            if (drawingimage == true)
            {
                flagimage = false;
                drawingimage = false;
            }

            try
            {
                History.RemoveRange(historyCounter + 1, History.Count - historyCounter - 1);
                History.Add(new Bitmap(picDrawingSurface.Image));
                if (historyCounter + 1 < 10) historyCounter++;
                if (History.Count - 1 == 10)
                    History.RemoveAt(0);
            }
            catch (Exception)
            {

            }
        }

        private void picDrawingSurface_MouseDown(object sender, MouseEventArgs e)
        {
            if (picDrawingSurface.Image == null)
            {
                MessageBox.Show("Сначала создайте новый файл!");
                return;
            }

            //----------

            if (flagRectangle == true)
            {
                drawingRectangle = true;
                figureHistory = new Bitmap(picDrawingSurface.Image);
                currentRectangle = new Rectangle();
                currentRectangle.X = e.X;
                currentRectangle.Y = e.Y;
                startX = e.X;
                startY = e.Y;
                return;
            }

            if (flagimage == true)
            {
                drawingimage = true;
                figureHistory = new Bitmap(picDrawingSurface.Image);
                currentRectangle = new Rectangle();
                currentRectangle.X = e.X;
                currentRectangle.Y = e.Y;
                startX = e.X;
                startY = e.Y;
                return;
            }

            if (flagEllipse == true)
            {
                drawingEllipse = true;
                figureHistory = new Bitmap(picDrawingSurface.Image);
                currentRectangle = new Rectangle();
                currentRectangle.X = e.X;
                currentRectangle.Y = e.Y;
                startX = e.X;
                startY = e.Y;
                return;
            }


            if (flagCircle == true)
            {
                drawingEllipse = true;
                figureHistory = new Bitmap(picDrawingSurface.Image);
                currentRectangle = new Rectangle();
                currentRectangle.X = e.X;
                currentRectangle.Y = e.Y;
                startX = e.X;
                startY = e.Y;
                return;
            }

            if (e.Button == MouseButtons.Left)
            {
                drawingLine = true;
                oldLocation = e.Location;
                currentPath = new GraphicsPath();
            }
            else if (e.Button == MouseButtons.Right)
            {
                historyColor = currentPen.Color;
                currentPen.Color = Color.White;
                drawingLine = true;
                oldLocation = e.Location;
                currentPath = new GraphicsPath();
            }

        }

        private void picDrawingSurface_MouseMove(object sender, MouseEventArgs e)
        {
            label_XY.Text = e.X.ToString() + ", " + e.Y.ToString();
            if (drawingLine)
            {
                Graphics g = Graphics.FromImage(picDrawingSurface.Image);
                currentPath.AddLine(oldLocation, e.Location);
                g.DrawPath(currentPen, currentPath);
                oldLocation = e.Location; g.Dispose();
                picDrawingSurface.Invalidate();

            }

            
            //----------------
            if (drawingRectangle)
            {
                picDrawingSurface.Image = new Bitmap(figureHistory);
                Graphics g = Graphics.FromImage(picDrawingSurface.Image);

                if (e.X < startX)
                {
                    currentRectangle.X = e.X;
                    currentRectangle.Width = startX - e.X;
                }
                else
                {
                    currentRectangle.Width = e.X - startX;
                }
                if (e.Y < startY)
                {
                    currentRectangle.Y = e.Y;
                    currentRectangle.Height = startY - e.Y;
                }
                else
                {
                    currentRectangle.Height = e.Y - startY;
                }

                if (FillFigureFlag == true)
                {
                    SolidBrush brush = new SolidBrush(currentPen.Color);
                    g.FillRectangle(brush, currentRectangle);
                }

                else
                {
                    g.DrawRectangle(currentPen, currentRectangle);
                }
    
            }

            if (drawingEllipse)
            {
                picDrawingSurface.Image = new Bitmap(figureHistory);
                Graphics g = Graphics.FromImage(picDrawingSurface.Image);

                if (e.X < startX)
                {
                    currentRectangle.X = e.X;
                    currentRectangle.Width = startX - e.X;
                }
                else
                {
                    currentRectangle.Width = e.X - startX;
                }
                if (e.Y < startY)
                {
                    currentRectangle.Y = e.Y;
                    currentRectangle.Height = startY - e.Y;
                }
                else
                {
                    currentRectangle.Height = e.Y - startY;
                }

                if (FillFigureFlag == true)
                {
                    SolidBrush brush = new SolidBrush(currentPen.Color);
                    g.FillRectangle(brush, currentRectangle);
                }

                else
                {
                    g.DrawRectangle(currentPen, currentRectangle);
                }
            }
            if (drawingimage == true)
                {
                picDrawingSurface.Image = new Bitmap(figureHistory);
                Graphics g = Graphics.FromImage(picDrawingSurface.Image);

                if (e.X < startX)
                {
                    currentRectangle.X = e.X;
                    currentRectangle.Width = startX - e.X;
                }
                else
                {
                    currentRectangle.Width = e.X - startX;
                }
                if (e.Y < startY)
                {
                    currentRectangle.Y = e.Y;
                    currentRectangle.Height = startY - e.Y;
                }
                else
                {
                    currentRectangle.Height = e.Y - startY;
                }

                    g.FillRectangle(imageBrush, currentRectangle);
               
            }

        }


        private void trackBarPen_Scroll(object sender, EventArgs e)
        {
            currentPen.Width = trackBarPen.Value;
        }

        private void отменадействияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (History.Count != 0 && historyCounter != 0) { 
                picDrawingSurface.Image = new Bitmap(History[--historyCounter]); } 
            else MessageBox.Show("История пуста"); 
        }

        private void отменадействияToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (historyCounter < History.Count - 1) 
            { picDrawingSurface.Image = new Bitmap(History[++historyCounter]); } 
            else MessageBox.Show("История пуста"); 
        }

        private void solidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPen.DashStyle = DashStyle.Solid;
            solidToolStripMenuItem.Checked = true;
            dotToolStripMenuItem.Checked = false;
            dashDotDotToolStripMenuItem.Checked = false;
        }

        private void dotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPen.DashStyle = DashStyle.Dot;
            solidToolStripMenuItem.Checked = false;
            dotToolStripMenuItem.Checked = true;
            dashDotDotToolStripMenuItem.Checked = false;
        }

        private void dashDotDotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPen.DashStyle = DashStyle.DashDotDot;
            solidToolStripMenuItem.Checked = false;
            dotToolStripMenuItem.Checked = false;
            dashDotDotToolStripMenuItem.Checked = true;
        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveDlg = new SaveFileDialog();
            SaveDlg.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png";
            SaveDlg.Title = "Save an Image File";
            SaveDlg.FilterIndex = 4; //По умолчанию будет выбрано последнее расширение *.png 
            SaveDlg.ShowDialog();
            if (SaveDlg.FileName != "") //Если введено не пустое имя 
            {
                System.IO.FileStream fs = (System.IO.FileStream)SaveDlg.OpenFile();
                switch (SaveDlg.FilterIndex)
                {
                    case 1: this.picDrawingSurface.Image.Save(fs, ImageFormat.Jpeg);
                        break;
                    case 2: this.picDrawingSurface.Image.Save(fs, ImageFormat.Bmp);
                        break;
                    case 3: this.picDrawingSurface.Image.Save(fs, ImageFormat.Gif);
                        break;
                    case 4: this.picDrawingSurface.Image.Save(fs, ImageFormat.Png);
                        break;
                }
                fs.Close();
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (currentPen.Color == Color.Black)
            {
                currentPen.Color = Color.Red;
            }
            else if (currentPen.Color == Color.Red)
            {
                currentPen.Color = Color.Black;
            }
        }

        private void открытьToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog OP = new OpenFileDialog();
            OP.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png";
            OP.Title = "Open an Image File";
            OP.FilterIndex = 1; //По умолчанию будет выбрано первое расширение *.jpg И, когда пользователь укажет нужный путь к картинке, ее нужно будет загрузить в PictureBox:
            if (OP.ShowDialog() != DialogResult.Cancel)
                picDrawingSurface.Load(OP.FileName);
            picDrawingSurface.AutoSize = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void picDrawingSurface_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void picDrawingSurface_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void LightGreyColor_Click(object sender, EventArgs e)
        {
            currentPen.Color = Color.LightGray;
            ThisColor.BackColor = Color.LightGray;
        }

        private void PurplePanel_Click(object sender, EventArgs e)
        {
            currentPen.Color = Color.Purple;
            ThisColor.BackColor = Color.Purple;
        }

        private void LightBlueColor_Click(object sender, EventArgs e)
        {
            currentPen.Color = Color.LightSkyBlue;
            ThisColor.BackColor = Color.LightSkyBlue;
        }

        private void DarkBlueColor_Click(object sender, EventArgs e)
        {
            currentPen.Color = Color.Blue;
            ThisColor.BackColor = Color.Blue;
        }

        private void RedColor_Click(object sender, EventArgs e)
        {
            currentPen.Color = Color.Red;
            ThisColor.BackColor = Color.Red;
        }

        private void MaroonColor_Click(object sender, EventArgs e)
        {
            currentPen.Color = Color.Maroon;
            ThisColor.BackColor = Color.Maroon;
        }

        private void DeepSkyBlueColor_Click(object sender, EventArgs e)
        {
            currentPen.Color = Color.DeepSkyBlue;
            ThisColor.BackColor = Color.DeepSkyBlue;
        }

        private void PowderBlueColor_Click(object sender, EventArgs e)
        {
            currentPen.Color = Color.PowderBlue;
            ThisColor.BackColor = Color.PowderBlue;
        }

        private void DownloadTemplate_Click(object sender, EventArgs e)
        {
            if (picDrawingSurface.Image != null)
            {
                OpenFileDialog OP = new OpenFileDialog();
                OP.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png";
                OP.Title = "Open an Image File";
                OP.FilterIndex = 1;
                if (OP.ShowDialog() != DialogResult.Cancel)
                {
                    Bitmap image1 = (Bitmap)Image.FromFile(OP.FileName);
                    imageBrush = new TextureBrush(image1);
                }
                flagimage = true;
            }
        }

        private void ZalivkapictureBox_Click(object sender, EventArgs e)
        {
            FillFigureFlag = (FillFigureFlag == true) ? false : true;
        }

        private void ElipseFigure_Click(object sender, EventArgs e)
        {
            flagEllipse = true;
            flagCircle = false;
            flagRectangle = false;

        }

        private void SquareFigure_Click(object sender, EventArgs e)
        {
            flagRectangle = true;
            flagEllipse = false;
            flagCircle = false;
        }


        private void GreenColor_Click(object sender, EventArgs e)
        {
            currentPen.Color = Color.Green;
            ThisColor.BackColor = Color.Green;
        }

        private void LightGreenColor_Click(object sender, EventArgs e)
        {
            currentPen.Color = Color.GreenYellow;
            ThisColor.BackColor = Color.GreenYellow;
        }

        private void BlackColor_Click(object sender, EventArgs e)
        {
            currentPen.Color = Color.Black;
            ThisColor.BackColor = Color.Black;
        }

    }
}
