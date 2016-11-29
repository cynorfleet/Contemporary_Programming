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
        // Init the graphics object
        Bitmap drawingSurface = new Bitmap(640, 480);
        Bitmap drawingSurface2 = new Bitmap(640, 480);

        public main_form()
        {
            InitializeComponent();

        }
        protected override void OnPaint(PaintEventArgs e)
        {

            Graphics gfx = Graphics.FromImage(drawingSurface);
            Graphics gfx2 = Graphics.FromImage(drawingSurface2);

            // Setup the brushes
            Pen pencil = new Pen(Color.Black);
            SolidBrush paintbrush = new SolidBrush(Color.Red);

            // Testing
            gfx.FillRectangle(Brushes.Red, 0, 0, 600, 400);

            // House
            gfx.DrawRectangle(Pens.AliceBlue, 50, 300, 200, 100);
            gfx.DrawLine(Pens.AliceBlue, 50, 300, 165, 200);
            gfx.DrawLine(Pens.AliceBlue, 165, 200, 250, 300);

            // North Pole
            gfx.FillRectangle(Brushes.Chocolate, 275, 325, 25, 75);
            gfx.DrawEllipse(Pens.AntiqueWhite, 265, 284, 40, 40);

            Canvas.BackgroundImage = drawingSurface;

            // 2nd picture
           // gfx2.CopyFromScreen(Canvas.Location, Point.Empty, Canvas.Size);
            // Fill globe
            gfx2.FillEllipse(Brushes.LawnGreen, 265, 284, 40, 40);

            Canvas.BackgroundImage = drawingSurface2;
        }
    }
}
