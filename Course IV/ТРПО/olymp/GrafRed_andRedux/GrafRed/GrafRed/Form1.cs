using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrafRed
{
    public partial class Form1 : Form
    {

        Graphics gr2;
        Pen kar;
        Point point;
        Bitmap npole,spole;
        bool draw = false;


        public Form1()
        {
            InitializeComponent();
        }

        

       

        public void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == openFileDialog1.ShowDialog())
            {
                pictureBox1.Load(openFileDialog1.FileName);
                maskedTextBox1.Text = openFileDialog1.FileName;
                spole = new Bitmap(openFileDialog1.FileName);
                gr2 = Graphics.FromImage(spole);
                pictureBox1.Image = spole;  
            }
             

        }

        public void карандашToolStripMenuItem_Click(object sender, EventArgs e)
        {
           kar = new Pen(Color.Black, 5);
            

        }

       public void текстToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == saveFileDialog1.ShowDialog())
            {
                spole.Save(saveFileDialog1.FileName + ".jpeg");
                
            }
            

        }

        public void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            npole = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            gr2 = Graphics.FromImage(npole);
            pictureBox1.Image = npole;
        }

        

        public void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
        }

        public void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                try
                {
                    gr2.DrawLine(kar, e.Location, point);
                    point = new Point(e.X, e.Y);
                    pictureBox1.Invalidate();
                }
                catch (ArgumentNullException)
                {
                    draw = false;
                }

            }
            else
            {

            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
            draw = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
        

        

        
        

        
       

        
    }
}
