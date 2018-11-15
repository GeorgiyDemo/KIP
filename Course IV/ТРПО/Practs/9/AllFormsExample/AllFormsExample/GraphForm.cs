using System;
using System.Drawing;
using System.Windows.Forms;

namespace AllFormsExample
{
    public partial class GraphForm : Form
    {
        private const int Level = 5;
        private int _width;
        private int _height;
        private Bitmap _fractal;
        private Graphics _graph;

        public GraphForm(Color meow, FormStartPosition startscreen)
        {
            InitializeComponent();
            _width = FractalPictureBox.Width;
            _height = FractalPictureBox.Height;
            StartPosition = startscreen;
            BackColor = meow;

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

                DrawCarpet(level - 1, new RectangleF(x1, y1, width, height)); // левый 1(верхний)
                DrawCarpet(level - 1, new RectangleF(x2, y1, width, height)); // средний 1
                DrawCarpet(level - 1, new RectangleF(x3, y1, width, height)); // правый 1
                DrawCarpet(level - 1, new RectangleF(x1, y2, width, height)); // левый 2
                DrawCarpet(level - 1, new RectangleF(x3, y2, width, height)); // правый 2
                DrawCarpet(level - 1, new RectangleF(x1, y3, width, height)); // левый 3
                DrawCarpet(level - 1, new RectangleF(x2, y3, width, height)); // средний 3
                DrawCarpet(level - 1, new RectangleF(x3, y3, width, height)); // правый 3
            }
        }

        private void GraphForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GraphForm_Load(object sender, EventArgs e)
        {
            _fractal = new Bitmap(_width, _height);
            _graph = Graphics.FromImage(_fractal);
            RectangleF carpet = new RectangleF(0, 0, _width, _height);
            DrawCarpet(Level, carpet);
            FractalPictureBox.BackgroundImage = _fractal;
        }
    }
}