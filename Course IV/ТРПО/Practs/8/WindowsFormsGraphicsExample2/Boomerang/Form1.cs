using System;
using System.Drawing;
using System.Windows.Forms;

namespace Boomerang
{
    public partial class MainForm : Form
	{
		PointF posB = new PointF();
		float R = 300;
		PointF Center = new PointF(500, 500);
		float Ang = 0f;
		float RotAng = 0f;


		public MainForm()
		{
			InitializeComponent();

			var t = new Timer();
			t.Interval = 30;
			t.Enabled = true;
			t.Tick += (s, o) => { MoveB(); };
		}

		private void MoveB()
		{
			RotAng += 30f;
			Ang += 0.1f;

			var x = Center.X + R * (float)Math.Cos(Ang);
			var y = Center.Y + R * (float)Math.Sin(Ang);
			posB = new PointF(x, y);
			Invalidate();
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			e.Graphics.TranslateTransform(posB.X / 2, posB.Y / 2);
			e.Graphics.RotateTransform(RotAng);
			e.Graphics.DrawImage(Res.bu, new PointF(-Res.bu.Width / 2, -Res.bu.Height / 2));
		}
	}
}
