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
            ListViewItem listboxitem = new ListViewItem();

            // Create items and three sets of subitems for each item.
            listboxitem = new ListViewItem(textBoxID.Text, 0);
            listboxitem.SubItems.Add(textBoxName.Text);
            listboxitem.SubItems.Add(textBoxQtyRequired.Text);
            listboxitem.SubItems.Add(textBoxQty.Text);

            MainForm.childstack.Peek().ListItem.Items.Add(listboxitem);
            this.Close();
        }
    }
}