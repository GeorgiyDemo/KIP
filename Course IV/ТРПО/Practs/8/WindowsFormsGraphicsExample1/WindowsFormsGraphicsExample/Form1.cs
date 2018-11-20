using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsGraphicsExample
{
    public partial class Form1 : Form
    {
        private const int Level = 5;
        private int _width;
        private int _height;
        private Bitmap _fractal;
        private Graphics _graph;

        public Form1()
        {
            InitializeComponent();
            _width = FractalPictureBox.Width;
            _height = FractalPictureBox.Height;
        }
        private PointF MidPoint(PointF p1, PointF p2)
        {
            return new PointF((p1.X + p2.X) / 2f, (p1.Y + p2.Y) / 2f);
        }

        private void DrawCarpet(int level, RectangleF carpet)
        {
            
            if (level == 0)
                _graph.FillRectangle(Brushes.OrangeRed, carpet);
            else
            {
                var width = carpet.Width / 3f;
                var height = carpet.Height / 3f;
               
                var x1 = carpet.Left;
                var x2 = x1 + width;
                var x3 = x1 + 2f * width;

                var y1 = carpet.Top;
                var y2 = y1 + height;
                var y3 = y1 + 2f * height;

                DrawCarpet(level - 1, new RectangleF(x1, y1, width, height));
                DrawCarpet(level - 1, new RectangleF(x2, y1, width, height));
                DrawCarpet(level - 1, new RectangleF(x3, y1, width, height));
                DrawCarpet(level - 1, new RectangleF(x1, y2, width, height));
                DrawCarpet(level - 1, new RectangleF(x3, y2, width, height));
                DrawCarpet(level - 1, new RectangleF(x1, y3, width, height));
                DrawCarpet(level - 1, new RectangleF(x2, y3, width, height));
                DrawCarpet(level - 1, new RectangleF(x3, y3, width, height));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _fractal = new Bitmap(_width, _height);
            _graph = Graphics.FromImage(_fractal);
            RectangleF carpet = new RectangleF(0, 0, _width, _height);
            DrawCarpet(Level, carpet);
            FractalPictureBox.BackgroundImage = _fractal;
        }
    }
}