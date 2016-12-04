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
        private List<Record> recordList = new List<Record>();

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
            Record temprecord = new Record();

            temprecord.Name = textBoxName.Text;
            temprecord.ID = Int32.Parse(textBoxID.Text);
            temprecord.QtyReq = Int32.Parse(textBoxQtyRequired.Text);
            temprecord.Quantity = Int32.Parse(textBoxQty.Text);

            ListViewItem[] listboxitem = new ListViewItem[1];

            // Create items and three sets of subitems for each item.
            listboxitem[0] = new ListViewItem(temprecord.ID + "", 0);
            listboxitem[0].SubItems.Add(temprecord.Name);
            listboxitem[0].SubItems.Add(temprecord.QtyReq + "");
            listboxitem[0].SubItems.Add(temprecord.Quantity + "");

            MainForm.childstack.Peek().ListItem.Items.AddRange(listboxitem);
            this.Close();
        }
    }
}