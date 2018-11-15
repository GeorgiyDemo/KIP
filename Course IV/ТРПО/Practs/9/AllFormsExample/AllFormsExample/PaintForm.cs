using System;
using System.Drawing;
using System.Windows.Forms;

namespace AllFormsExample
{
    public partial class PaintForm : Form
    {
        public PaintForm(Color meow, FormStartPosition startscreen)
        {
            StartPosition = startscreen;
            BackColor = meow;
            InitializeComponent();
        }

        private void GraphInitializer()
        {
            double Xmin = Convert.ToDouble(textBoxXmin.Text);
            double Xmax = Convert.ToDouble(textBoxXmax.Text);
            double Step = Convert.ToDouble(textBoxStep.Text);
            double b = -0.8;
            int count = (int)Math.Ceiling((Xmax - Xmin) / Step) + 1;
            double[] x = new double[count];
            double[] y1 = new double[count];

            for (int i = 0; i < count; i++)
            {
                x[i] = Xmin + Step * i;
                y1[i] = Math.Pow(i, 2) + Math.Tan((5 * i) + (b / i));
            }

            chart1.ChartAreas[0].AxisX.Minimum = Xmin; chart1.ChartAreas[0].AxisX.Maximum = Xmax;
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = Step;
            chart1.Series[0].Points.DataBindXY(x, y1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            try
            {
                GraphInitializer();
            }
            catch (Exception)
            {

            }
        }
    }
}
