using System;
using System.Drawing;
using System.Windows.Forms;

namespace AllFormsExample
{
    public partial class UntraditionalForms : Form
    {
        Point moveStart;

        public UntraditionalForms(Color meow)
        {
            BackColor = meow;
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UntraditionalForms_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddEllipse(0, 0, this.Width, this.Height);
            Region myRegion = new Region(myPath);
            Region = myRegion;
        }

        private void UntraditionalForms_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                moveStart = new Point(e.X, e.Y);
        }

        private void UntraditionalForms_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) != 0)
            {
                Point deltaPos = new Point(e.X - moveStart.X, e.Y - moveStart.Y);
                Location = new Point(Location.X + deltaPos.X,
                Location.Y + deltaPos.Y);
            }
        }
    }
}
