using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3_working
{
    public partial class Binary_Converter_form : Form
    {
        public Binary_Converter_form()
        {
            InitializeComponent();
        }

        // This function performs conversion to decimal
        public static int ConvertD(int bin_value)
        {
            // Initialize local variables
            int dec_result = 0;
            int exp = 0;

            while (bin_value != 0)
            {
                int bin_tail = bin_value % 10;
                dec_result += (int)Math.Pow(2, exp) * bin_tail;
                exp++;
                bin_value = bin_value / 10;
            }
            return dec_result;
        }

        private void GUI_description_Enable(object sender, EventArgs e)
        {
            // Enable convert button if text is entered
            convert_button.Enabled = true;
            // Hide result description label on GUI
            result_description_label.Visible = false;
            // Hide result on GUI
            result_label.Visible = false;

        }


        private void convert_button_Click(object sender, EventArgs e)
        {
            // Reveal result description label on GUI
            result_description_label.Visible = true;
            // Hide result on GUI
            result_label.Visible = true;

            // Send integer to GUI
            result_label.Text = ConvertD(Int32.Parse(user_input.Text)) + "";

            // Disable Button until new value is entered
            convert_button.Enabled = false;
        }
    }
}
