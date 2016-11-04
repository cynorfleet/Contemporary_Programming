/*= == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == ==
| Class	:		PAINTER
|
| Author :		Christian Norfleet
|
| Language :	CS
|
| Class :		Contemporary Programming
|
| Instructor :	Dr. Stringfellow
|
| Due Date :	11/3/2016
|
+--------------------------------------------------------------------------------------------------------- -
|
| Description : This program will allow user to select color and brush sizes via menu-option/radio button. User is also
|               able to chose an eraser or clear the canvas entirely. Custom colors may be chosen by clicking on the
|               color wheel. The label on top will indicate corresponding mode, depending on whether the user is
|               PAINTING, ERASEING, or using CUSTOM color.
|
| Data Sets :   Brush size and color values are embedded in corresponding CONTROLS. They will be located at either
|               IMAGETRANSPARENTCOLOR or TAG properties.
|
| Known Bugs :	IF THE PROGRAM DOES NOT FUNCTION CORRECTLY IN SOME
|				SITUATIONS, DESCRIBE THE SITUATIONS AND PROBLEMS HERE
|				AND EMAIL "cynorfleet@gmail.com" per Christian Norfleet
|
*= == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == */

using painter2.Properties;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Painter
{
    public partial class PainterForm : Form
    {
        /*     GLOBALS      */
        private int brushsize;
        private bool CanWePaint = false;
        private Color color;
        /*      MAIN        */

        public PainterForm()
        {
            InitializeComponent();
            Normal.Checked = true;
            Black.Checked = true;
            LoadColorWheel();
        }

        private void Brush_hover(object sender, EventArgs e)
        /*-------------------------------------------- Brush_hover ----------
        |  Function: 	Brush_hover()
        |
        |  Purpose: 	Will auto-MAGIK-ly change the icon to a paint brush on hover
        |
        |  Returns:  	N/A
        *---------------------------------------------------------------------*/
        {
            //  Capture panel object
            Panel canvas = sender as Panel;

            //  Change the cursor
            try
            {
                Cursor myCursor = new Cursor("../../assets/cursor.cur");
                canvas.Cursor = myCursor;
            }
            catch
            {
                Cursor myCursor = new Cursor("cursor.cur");
                canvas.Cursor = myCursor;
            }
        }

        private void ClearScreen(object sender, MouseEventArgs e)
        /*-------------------------------------------- ClearScreen ----------
        |  Function: 	ClearScreen()
        |
        |  Purpose: 	Clears the canvas of all graphics.
        |
        |  Returns:  	N/A
        *---------------------------------------------------------------------*/
        {
            using (Graphics graphics = this.canvas.CreateGraphics())
            {
                graphics.Clear(canvas.BackColor);
            }
        }

        private void Color_CheckedChanged(object sender, EventArgs e)
        /*-------------------------------------------- Color_CheckedChanged ----------
        |  Function: 	Color_CheckedChanged()
        |
        |  Purpose: 	Sets the appropriate color from Color Box
        |
        |  Returns:  	N/A
        *---------------------------------------------------------------------*/
        {
            //  If Color is picked set color and change mode to "Paint"
            Mode.Text = "Paint";

            //  Set color
            RadioButton ColorBx = sender as RadioButton;
            color = ColorBx.FlatAppearance.BorderColor;

            //  If Eraser is picked set color and change mode to "Eraser"
            if (Erase.Checked)
            {
                color = canvas.BackColor;
                Mode.Text = "Erase";
            }

            //  Reset the color wheel graphic
            LoadColorWheel();
        }

        private void ColorWheel_event(object sender, EventArgs e)
        /*-------------------------------------------- ColorWheel_event ----------
        |  Function: 	ColorWheel_event()
        |
        |  Purpose: 	Allow User to select a custom color by clicking wheel
        |
        |  Returns:  	N/A
        *----------------------------------------------------------------------*/
        {
            ColorDialog colorDlg = new ColorDialog();

            //  Show Color Dialog and capture selected color
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                color = colorDlg.Color;
                var colorcontrol = ColorBox.Controls.OfType<RadioButton>();

                //  Clear all radio buttons due to custom color
                foreach (var cntrl in colorcontrol)
                {
                    cntrl.Checked = false;
                }
            }

            //  Set mode to indicate custom color
            Mode.Text = "Custom";
            LoadColorWheel();
        }

        private void LoadColorWheel()
        /*-------------------------------------------- LoadColorWheel ----------
        |  Function: 	LoadColorWheel()
        |
        |  Purpose: 	Changes the background of color wheel to indicate active color
        |
        |  Returns:  	N/A
        *---------------------------------------------------------------------*/
        {
            ColorWheelBox.BackColor = color;
        }

        private void MenuColor_Clicked(object sender, EventArgs e)
        /*-------------------------------------------- MenuColor_Clicked ----------
        |  Function: 	MenuColor_Clicked()
        |
        |  Purpose: 	Sets color according to selected menu option
        |
        |  Returns:  	N/A
        *---------------------------------------------------------------------*/
        {
            //  Change mode to "Paint"
            Mode.Text = "Paint";

            //  Set the color
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            color = menu.ImageTransparentColor;

            //  Activate the corresponding radio button
            var colorcontrol = ColorBox.Controls.OfType<RadioButton>();
            foreach (var cntrl in colorcontrol)
            {
                //  Use the predefined Border Color to find correct radio button
                if (cntrl.FlatAppearance.BorderColor == color)
                    cntrl.Checked = true;
            }

            //  Reset the color wheel graphic
            LoadColorWheel();
        }

        private void MenuSize_CheckedChanged(object sender, EventArgs e)
        /*-------------------------------------------- MenuSize_CheckedChanged ----------
        |  Function: 	MenuSize_CheckedChanged()
        |
        |  Purpose:     Sets the brush size according to selected menu option
        |
        |  Returns:  	N/A
        *---------------------------------------------------------------------*/
        {
            //  Grab the brush size from the Tag of the selected option
            ToolStripMenuItem Style = sender as ToolStripMenuItem;
            brushsize = Int32.Parse(Style.Tag.ToString());

            //  Activate the corresponding radio button
            var sizeControl = StyleBox.Controls.OfType<RadioButton>();
            foreach (var cntrl in sizeControl)
            {
                //  Use the predefined Tag to find correct radio button
                if (cntrl.Tag == Style.Tag)
                    cntrl.Checked = true;
            }
        }

        private void PainterForm_MouseDown(object sender, MouseEventArgs e)
        /*-------------------------------------------- PainterForm_MouseDown ----------
        |  Function: 	PainterForm_MouseDown()
        |
        |  Purpose: 	Determines when the canvas should allow painting
        |
        |  Returns:  	N/A
        *---------------------------------------------------------------------*/
        {
            CanWePaint = true;
        }

        private void PainterForm_MouseMove(object sender, MouseEventArgs e)
        /*-------------------------------------------- PainterForm_MouseMove ----------
        |  Function: 	PainterForm_MouseMove()
        |
        |  Purpose: 	Determines when the canvas should allow painting
        |
        |  Returns:  	N/A
        *---------------------------------------------------------------------*/
        {
            //  If painting is allowed and mouse is moving paint with appropriate color
            if (CanWePaint)
            {
                using (Graphics graphics = this.canvas.CreateGraphics())
                {
                    graphics.FillRectangle(new SolidBrush(color), e.X, e.Y, brushsize, brushsize);
                }
            }
        }

        private void PainterForm_MouseUp(object sender, MouseEventArgs e)
        /*-------------------------------------------- PainterForm_MouseUp ----------
        |  Function: 	PainterForm_MouseUp()
        |
        |  Purpose: 	Determines when the canvas should allow painting
        |
        |  Returns:  	N/A
        *---------------------------------------------------------------------*/
        {
            CanWePaint = false;
        }

        private void Size_CheckedChanged(object sender, EventArgs e)
        /*-------------------------------------------- Size_CheckedChanged ----------
        |  Function: 	Size_CheckedChanged()
        |
        |  Purpose: 	Sets the brush size according to the selected radio button
        |               in the Style box
        |
        |  Returns:  	N/A
        *---------------------------------------------------------------------*/
        {
            //  Use the predefined Tag to grab correct brush size
            RadioButton Style = sender as RadioButton;
            brushsize = Int32.Parse(Style.Tag.ToString());
        }
    }
}