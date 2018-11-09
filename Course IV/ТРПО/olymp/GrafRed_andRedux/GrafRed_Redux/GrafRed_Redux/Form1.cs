using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace GrafRed_Redux
{

    public partial class Form1 : Form
    {
        Kist kk = new Kist();
        Pramlin pr = new Pramlin();
        Kvadrat kv = new Kvadrat();
        Treugolnik tr = new Treugolnik();
        Kruzok krg = new Kruzok();

        Bitmap novpole, sushpole; // новое/сущевстующее поле
        // просто дохрена булеонов 
        Boolean draw = false;
        Boolean provpole, karkist, pram, kvadr,treug,krug;
        Point toch1, toch2;


        Int32 tol; // тощина линии, юзается в цикле





        public Form1()
        {
            InitializeComponent();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e) // Открытие файла
        {
            if (DialogResult.OK == openFileDialog1.ShowDialog())
            {
                pictureBox1.Load(openFileDialog1.FileName);
                sushpole = new Bitmap(openFileDialog1.FileName);
                provpole = true;
                pictureBox1.Image = sushpole;
                label3.Text = openFileDialog1.FileName;

            }

        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e) // создание
        {
            novpole = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            provpole = false;
            pictureBox1.Image = novpole;

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e) // сохранение
        {
            if (DialogResult.OK == saveFileDialog1.ShowDialog())
            {
                try
                {

                    novpole.Save(saveFileDialog1.FileName + ".jpg");

                }
                catch (NullReferenceException)
                {
                    sushpole.Save(saveFileDialog1.FileName + ".jpg");
                }
            }
        }

        private void карандашToolStripMenuItem_Click(object sender, EventArgs e) // толщина карандаша
        {
            karkist = true;
            tol = 2;

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e1) // выбор инструментов посредством тру/фолс
        {
           
            if (draw)
            {
                // if (karkist == true)
               //  {
                //     kk.Kist_kar(ref novpole, ref sushpole, ref draw, ref provpole, ref tol, ref pictureBox1, ref colorDialog1, ref e1);
               //  }
               
                
            }




        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e1)
        {
            draw = false;
            toch2 = new Point(e1.X, e1.Y);
        //    if (kvadr == true)
          //  {
          //      kv.Kvadr(ref novpole, ref sushpole, ref draw, ref provpole, ref tol, ref pictureBox1, ref colorDialog1, ref e1, ref toch1, ref toch2);
          //  }
        //    if (pram == true)
        //    {
          //      pr.Pramaya(ref novpole, ref sushpole, ref draw, ref provpole, ref tol, ref pictureBox1, ref colorDialog1, ref e1, ref toch1, ref toch2);
          //  }
              //  if (treug == true)
             //   {
              //      tr.Treug(ref novpole, ref sushpole, ref draw, ref provpole, ref tol, ref pictureBox1, ref colorDialog1, ref e1, ref toch1, ref toch2);
             //   }
          //  if (krug == true)
         //   {

            krg.Kruzishe(ref novpole, ref sushpole, ref draw, ref provpole, ref tol, ref pictureBox1, ref colorDialog1, ref e1, ref toch1, ref toch2);

       //     }


            

            


        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e1)
        {  
            
            draw = true;
            toch1 = new Point(e1.X, e1.Y);
          
        }

        private void цветToolStripMenuItem_Click(object sender, EventArgs e) // выбор цвета, очевидно
        {
            if (DialogResult.OK == colorDialog1.ShowDialog())
            {


            }
        }


        private void поВертикалиToolStripMenuItem_Click(object sender, EventArgs e) // Отражение по оси У
        {
            try
            {
                novpole.RotateFlip(RotateFlipType.RotateNoneFlipY);
                pictureBox1.Update();
            }
            catch (NullReferenceException)
            {
                sushpole.RotateFlip(RotateFlipType.RotateNoneFlipY);
                pictureBox1.Update();
            }

        }

        private void поГоризонталиToolStripMenuItem_Click(object sender, EventArgs e) // Отражение по оси Х
        {
            try
            {
                novpole.RotateFlip(RotateFlipType.RotateNoneFlipX);
                pictureBox1.Update();
            }
            catch (NullReferenceException)
            {
                sushpole.RotateFlip(RotateFlipType.RotateNoneFlipX);
                pictureBox1.Update();
            }

        }

        private void кистьToolStripMenuItem_Click(object sender, EventArgs e) //толщина кисти
        {
            karkist = true;
            pram = false;
            kvadr = false;
            treug = false;
            krug = false;
           


            tol = 6;

        }



        private void прямаяЛинияToolStripMenuItem_Click(object sender, EventArgs e, MouseEventArgs e1) //   Прямая линия
        {

            pram = true;
            karkist = false;
            kvadr = false;
            treug = false;
            krug = false;

        }

        private void Form1_Load(object sender, EventArgs e, MouseEventArgs e1) // пустой и пока ненужный лоад формы
        {
           

        }



        private void квадратToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kvadr = true;
            pram = false;
            karkist = false;
            treug = false;
            krug = false;

        }

        private void треуольникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treug = true;
            kvadr = false;
            pram = false;
            karkist = false;
              krug = false;

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e1)
        {
           
            
            

        }

        private void кругToolStripMenuItem_Click(object sender, EventArgs e)
        {
            krug = true;
            treug = false;
            kvadr = false;
            pram = false;
            karkist = false;

        }
}
    public partial class Kist
    {

        public void Kist_kar(ref Bitmap novpole, ref Bitmap sushpole, ref Boolean draw, ref Boolean provpole, ref Int32 tol, ref PictureBox pictureBox1, ref ColorDialog colorDialog1, ref MouseEventArgs e1)
        {
            if (provpole == true)
            {

                sushpole.SetPixel(e1.X, e1.Y, colorDialog1.Color);
                for (Int32 ifor = 0; ifor < tol; ifor++)
                {
                    sushpole.SetPixel(e1.X - ifor, e1.Y - ifor, colorDialog1.Color);
                }
                pictureBox1.Invalidate();
            }
            else
            {
                novpole.SetPixel(e1.X, e1.Y, colorDialog1.Color);
                for (Int32 ifor = 0; ifor < tol; ifor++)
                {
                    novpole.SetPixel(e1.X - ifor, e1.Y - ifor, colorDialog1.Color);
                }
                pictureBox1.Invalidate();
            }

        }

    }
    public partial class Pramlin
    {
        public void Pramaya(ref Bitmap novpole, ref Bitmap sushpole, ref Boolean draw, ref Boolean provpole, ref Int32 tol, ref PictureBox pictureBox1, ref ColorDialog colorDialog1, ref MouseEventArgs e1, ref Point toch1, ref Point toch2)
        {
            if (provpole == true)
            {

                sushpole.SetPixel(toch1.X, toch1.Y, colorDialog1.Color);
                sushpole.SetPixel(toch2.X, toch2.Y, colorDialog1.Color);
                pictureBox1.Invalidate();
            }
            else
            {
                novpole.SetPixel(toch1.X, toch1.Y, colorDialog1.Color);
                novpole.SetPixel(toch2.X, toch2.Y, colorDialog1.Color);
                
                pictureBox1.Invalidate();
            }
        }
    }
    public partial class Kvadrat
    {
        public void Kvadr(ref Bitmap novpole, ref Bitmap sushpole, ref Boolean draw, ref Boolean provpole, ref Int32 tol, ref PictureBox pictureBox1, ref ColorDialog colorDialog1, ref MouseEventArgs e1,ref Point toch1,ref Point toch2)
        {
         if (provpole == true)
            {
                sushpole.SetPixel(toch1.X, toch1.Y, colorDialog1.Color);
                sushpole.SetPixel(toch2.X, toch2.Y, colorDialog1.Color);
                sushpole.SetPixel(toch2.X, toch1.Y, colorDialog1.Color);
                sushpole.SetPixel(toch1.X, toch2.X, colorDialog1.Color);
                for (Int32 ifor = toch1.Y; ifor < toch2.Y; ifor++)
                {
                    sushpole.SetPixel(toch1.X, ifor, colorDialog1.Color);
                    sushpole.SetPixel(toch2.X, ifor, colorDialog1.Color);
                }
                for (Int32 ifor = toch1.X; ifor < toch2.X; ifor++)
                {
                    sushpole.SetPixel(ifor, toch1.Y, colorDialog1.Color);
                    sushpole.SetPixel(ifor, toch2.Y, colorDialog1.Color);
                }
                pictureBox1.Invalidate();
            }
            else
            {
                novpole.SetPixel(toch1.X, toch1.Y, colorDialog1.Color);
                novpole.SetPixel(toch2.X, toch2.Y, colorDialog1.Color);
                novpole.SetPixel(toch2.X, toch1.Y, colorDialog1.Color);
                novpole.SetPixel(toch1.X, toch2.X, colorDialog1.Color);
                for (Int32 ifor = toch1.Y; ifor < toch2.Y; ifor++)
                {
                    novpole.SetPixel(toch1.X, ifor, colorDialog1.Color);
                    novpole.SetPixel(toch2.X, ifor, colorDialog1.Color);
                }
                for (Int32 ifor = toch1.X; ifor < toch2.X; ifor++)
                {
                    novpole.SetPixel(ifor, toch1.Y, colorDialog1.Color);
                    novpole.SetPixel(ifor, toch2.Y, colorDialog1.Color);

                }
                pictureBox1.Invalidate();
                
            }

        }
       


    }
    public partial class Treugolnik
    {
        public void Treug(ref Bitmap novpole, ref Bitmap sushpole, ref Boolean draw, ref Boolean provpole, ref Int32 tol, ref PictureBox pictureBox1, ref ColorDialog colorDialog1, ref MouseEventArgs e1, ref Point toch1, ref Point toch2)
        {

            Point t1 = new Point(e1.X, e1.Y);
            Point t2 = new Point(e1.X, e1.Y);


            if (provpole == true)
            {
                sushpole.SetPixel(toch1.X, toch1.Y, colorDialog1.Color);
                
                sushpole.SetPixel(toch2.X, toch1.Y, colorDialog1.Color);
                sushpole.SetPixel(toch1.X, toch2.X, colorDialog1.Color);
                for (Int32 ifor = toch1.Y; ifor < toch2.Y; ifor++)
                {
                    sushpole.SetPixel(toch1.X, ifor, colorDialog1.Color);
                    
                }
                for (Int32 ifor = toch1.X; ifor < toch2.X; ifor++)
                {
                    sushpole.SetPixel(ifor, toch1.Y, colorDialog1.Color);
                 


                }

                
            }
            else
            {

                novpole.SetPixel(toch1.X, toch1.Y, colorDialog1.Color);
                novpole.SetPixel(toch2.X, toch1.Y, colorDialog1.Color);
                novpole.SetPixel(toch1.X, toch2.X, colorDialog1.Color);
                for (Int32 ifor = toch1.Y; ifor < toch2.Y; ifor++)
                {
                    novpole.SetPixel(toch1.X, ifor, colorDialog1.Color);
                   
                }
                for (Int32 ifor = toch1.X; ifor < toch2.X; ifor++)
                {
                    novpole.SetPixel(ifor, toch1.Y, colorDialog1.Color);
                }


                pictureBox1.Invalidate();
            }




        }
    }
    public partial class Kruzok
    {
        public void Kruzishe(ref Bitmap novpole, ref Bitmap sushpole, ref Boolean draw, ref Boolean provpole, ref Int32 tol, ref PictureBox pictureBox1, ref ColorDialog colorDialog1, ref MouseEventArgs e1, ref Point toch1, ref Point toch2)
        {
           
            




        }


    }
}
