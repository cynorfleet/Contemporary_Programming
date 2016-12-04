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
        public ChildForm()
        {
            InitializeComponent();
        }

        public void ChildForm_Load(object sender, EventArgs e)
        {
            // Set the view to show details.
            ListItem.View = View.Details;
            // Display grid lines.
            ListItem.GridLines = true;
            // Select the item and subitems when selection is made.
            ListItem.FullRowSelect = true;
        }

        private void ChildForm_Click(object sender, EventArgs e)
        {
            MainForm.tempChild = this;
        }
    }
}