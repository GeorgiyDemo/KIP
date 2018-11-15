using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsGraphicsExample2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //    
        private Point point1, point2, point3, point4, point5, point6;

        private double a;
        private SolidBrush blackBrush = new SolidBrush(Color.Black);
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Point[] Points =
             {  point1, point2, point3,point4, point5, point6
             };
            g.FillPolygon(blackBrush, Points);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            a = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            a -= 0.01;
            // первое положение
            point1 = new Point(50, 10);
            point2 = new Point(70, 30);
            point3 = new Point(100, 50);
            point4 = new Point(70, 70);
            point5 = new Point(50, 90);
            point6 = new Point(70, 50);

            //куда должно переместиться
            point1 = new Point(250, 210);
            point2 = new Point(270, 230);
            point3 = new Point(300, 250);
            point4 = new Point(270, 270);
            point5 = new Point(250, 290);
            point6 = new Point(270, 250);

            Invalidate();
        }
    }
}