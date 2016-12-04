using RecordClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI
{
    public partial class InputDialog : Form
    {
        public InputDialog()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Record record = new Record();
            record.ID = Int32.Parse(textBoxID.Text);
            record.QtyReq = Int32.Parse(textBoxQtyRequired.Text);
            record.Quantity = Int32.Parse(textBoxQty.Text);
            record.Name = textBoxName.Text;

            //  Send Record to main form
            MainForm.GrabInput(record);

            this.Close();
        }
    }
}