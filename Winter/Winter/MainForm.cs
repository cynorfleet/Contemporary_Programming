using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winter
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Init the graphics object
            Bitmap drawingSurface = new Bitmap(640, 480);
            Graphics gfx = Graphics.FromImage(drawingSurface);

            // Choose Font
            Font msgfont = new Font("Terminal", 40);

            // Set background color
            gfx.FillRectangle(Brushes.Red, 0, 0, 600, 400);

            // House
            gfx.DrawRectangle(Pens.AliceBlue, 50, 300, 200, 100);
            gfx.DrawLine(Pens.AliceBlue, 50, 300, 165, 200);
            gfx.DrawLine(Pens.AliceBlue, 165, 200, 250, 300);

            // North Pole
            gfx.FillRectangle(Brushes.Chocolate, 275, 325, 25, 75);
            gfx.FillEllipse(Brushes.AntiqueWhite, 265, 284, 40, 40);

            // Draw Message
            gfx.DrawString("MERRY CHRISTMAS", new Font("Terminal", 35),
                Brushes.LawnGreen, new Point(5, 5));

            Canvas.BackgroundImage = drawingSurface;
        }
    }
}