using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    public partial class Converter : Form
    {
        // This function performs conversion to decimal
        public static int ConvertD(int bin_value)
        {
            // Initialize variables
            int dec_value = 0;
            dec_value = Do_ConvertD(bin_value);
           
            return dec_value;
        }
        101
        public static int Do_ConvertD(int value)
        {
            if(value % 10)
        }

        public Converter()
        {
            InitializeComponent();
        }

        private void convert_button_Click(object sender, EventArgs e)
        {
            result_instruction_label.Enabled = true;
            
        }
    }
}
