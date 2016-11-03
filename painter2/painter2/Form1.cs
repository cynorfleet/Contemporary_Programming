using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Painter
{
    public partial class PainterForm : Form
    {
        enum size { small = 1, normal = 6, large = 12};

        Color color;
        bool ShouldPaint = false;
        int brushsize;

        public PainterForm()
        {
            InitializeComponent();
            Normal.Checked = true;
            Black.Checked = true;
        }

        private void Size_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton Style = sender as RadioButton;
            brushsize = Int32.Parse(Style.Tag.ToString());
       
        }

        private void MenuSize_CheckedChanged(object sender, EventArgs e)
        {
            ToolStripMenuItem Style = sender as ToolStripMenuItem;
            brushsize = Int32.Parse(Style.Tag.ToString());
            var sizeControl = StyleBox.Controls.OfType<RadioButton>();
            foreach (var cntrl in sizeControl)
            {
                if (cntrl.Tag == Style.Tag)
                    cntrl.Checked = true;
            }
        }

        private void MenuColor_Clicked(object sender, EventArgs e)
        {
            Mode.Text = "Paint";
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            color = menu.ImageTransparentColor;
            var colorcontrol = ColorBox.Controls.OfType<RadioButton>();
            foreach(var cntrl in colorcontrol)
            {
                if (cntrl.FlatAppearance.BorderColor == color)
                    cntrl.Checked = true;
            }
        }

        private void Color_CheckedChanged(object sender, EventArgs e)
        {
            Mode.Text = "Paint";
            RadioButton ColorBx = sender as RadioButton;
            color = ColorBx.FlatAppearance.BorderColor;
            if (Erase.Checked)
            {
                color = canvas.BackColor;
                Mode.Text = "Erase";
            }
        }


        private void PainterForm_MouseDown(object sender, MouseEventArgs e)
        {
            ShouldPaint = true;
        }

        private void PainterForm_MouseUp(object sender, MouseEventArgs e)
        {
            ShouldPaint = false;
        }

        private void PainterForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (ShouldPaint) 
            {
                using (Graphics graphics = this.canvas.CreateGraphics())
                {
                    graphics.FillRectangle(new SolidBrush(color), e.X, e.Y, brushsize, brushsize);
                }
            }
        }

        private void ColorWheel_event(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                color = colorDlg.Color;

                var colorcontrol = ColorBox.Controls.OfType<RadioButton>();
                foreach (var cntrl in colorcontrol)
                {
                    cntrl.Checked = false;
                }
            }
        }

        private void ClearScreen(object sender, MouseEventArgs e)
        {
            using (Graphics graphics = this.canvas.CreateGraphics())
            {
                graphics.Clear(canvas.BackColor);
            }
        }
    }
}
