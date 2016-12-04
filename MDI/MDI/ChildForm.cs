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
    public partial class ChildForm : Form
    {
        public Record record;
        private ListViewItem templist = new ListViewItem();

        public ChildForm()
        {
            InitializeComponent();
        }

        public void UpdateData()
        {
            for (int i = 0; i < MainForm.recordlist.Count; i++)
            {
                ListItem.Items.Add(record.ID + "");
                ListItem.Items.Add(record.Name);
                ListItem.Items.Add(record.QtyReq + "");
                ListItem.Items.Add(record.Quantity + "");
            }
        }

        private void ChildForm_Load(object sender, EventArgs e)
        {
            // Set the view to show details.
            ListItem.View = View.Details;
            // Display grid lines.
            ListItem.GridLines = true;
            // Select the item and subitems when selection is made.
            ListItem.FullRowSelect = true;

            try
            {
                record = MainForm.record;
                ListItem.Items.Add(record.ID + "");
                ListItem.Items.Add(record.Name);
                ListItem.Items.Add(record.QtyReq + "");
                ListItem.Items.Add(record.Name + "");
            }
            catch
            {
                MessageBox.Show("MISSING DATA ENTRY");
            }
        }
    }
}