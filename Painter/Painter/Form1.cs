// Fig. 14.38: PainterForm.cs
// Using the mouse to draw on a Form.
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Painter
{
    // creates a Form that’s a drawing surface
    public partial class PainterForm : Form
    {
        bool ShouldPaint = false; // whether to paint
                                  //bool ShouldErase = false; // whether to erase
        int thickness = 3;
        System.Drawing.Color PaintColor = System.Drawing.Color.Black;


        // default constructor
        public PainterForm()
        {
            InitializeComponent();

        }

        // a list of line widths
        private enum lineWidth
        {
            fine = 3,
            medium = 8,
            bold = 12,
            roller = 48
        }


        private void sizeRdoBtns_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton szRdoBtn = sender as RadioButton;

            if (fineRdoBtn.Checked)
            {
                thickness = (int)lineWidth.fine;
            }
            else if (medRdoBtn.Checked)
            {
                thickness = (int)lineWidth.medium;
            }
            else if (boldRdoBtn.Checked)
            {
                thickness = (int)lineWidth.bold;
            }
            else // roller button is checked
            {
                thickness = (int)lineWidth.roller;
            }
        }

        private void colorRdoBtns_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton colorRdoBtn = sender as RadioButton;

            if (redRdoBtn.Checked)
            {
                PaintColor = System.Drawing.Color.Red;
            }
            else if (greenRdoBtn.Checked)
            {
                PaintColor = System.Drawing.Color.Green;
            }
            else if (blueRdoBtn.Checked)
            {
                PaintColor = System.Drawing.Color.Blue;
            }
            else if (yellowRdoBtn.Checked)
            {
                PaintColor = System.Drawing.Color.Yellow;
            }
            else if (blackRdoBtn.Checked)
            {
                PaintColor = System.Drawing.Color.Black;
            }
            else // ERASE is checked
            {
                PaintColor = System.Drawing.Color.White;
            }
        }


        // should paint when mouse button is pressed down
        private void PainterForm_MouseDown(object sender, MouseEventArgs e)
        {
            // indicate that user is dragging the mouse
            ShouldPaint = true;
        }

        // stop painting when mouse button is released
        private void PainterForm_MouseUp(object sender, MouseEventArgs e)
        {
            // indicate that user released the mouse button
            ShouldPaint = false;
        }

        // draw circle whenever mouse moves with its button held down  
        private void PainterForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (ShouldPaint) // check if mouse button is being pressed   
            {



                // draw a circle where the mouse pointer is present         
                using (Graphics graphics = this.ImagePanel.CreateGraphics())
                {


                    graphics.FillRectangle(
                                       new SolidBrush(PaintColor), e.X, e.Y, thickness, thickness);


                }
            }
        }










    }
}


/**************************************************************************
 * (C) Copyright 1992-2017 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/
