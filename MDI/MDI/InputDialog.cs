/*= == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == ==
| Class	:		InputDialog
|
| Author :		Christian Norfleet
|
| Language :	CS
|
| Class :		Contemporary Programming
|
| Instructor :	Dr. Stringfellow
|
| Due Date :	12/6/2016
|
+---------------------------------------------------------------------------- -
|
| Description : This form will capture user input
|
| Known Bugs :	IF THE PROGRAM DOES NOT FUNCTION CORRECTLY IN SOME
|				SITUATIONS, DESCRIBE THE SITUATIONS AND PROBLEMS HERE
|				AND EMAIL "cynorfleet@gmail.com" per Christian Norfleet
|
*= == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == */

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
        public ListViewItem entryitem;
        private bool isUpdate = false;
        private List<Record> recordList = new List<Record>();

        public InputDialog(ListViewItem e = null, bool update = false)
        {
            /*-------------------------------------------- InputDialog ----------
            |  Function: 	InputDialog()
            |
            |  Purpose: 	Overloaded Constructor
            |
            |               Its parameters specify whether the OK button adds new fields
            |               or modify existing data within a Child MDI ListBox
            |
            |  Parameters:
            |               e       -- a reference to a Child MDI's ListView control
            |               update  -- a bool flag representing the behavior of OK button
            |
            |  Returns:  	N/A
            *---------------------------------------------------------------------*/
            InitializeComponent();

            isUpdate = update;

            if (e != null)
                entryitem = e;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            /*-------------------------------------------- buttonCancel_Click ----------
            |  Function: 	buttonCancel_Click()
            |
            |  Purpose: 	Defines Cancel button action. Will close input dialog window
            |
            |  Returns:  	N/A
            *---------------------------------------------------------------------*/
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            /*-------------------------------------------- buttonOK_Click ----------
            |  Function: 	buttonOK_Click()
            |
            |  Purpose: 	Defines OK button behavior.
            |
            |  Returns:  	N/A
            *---------------------------------------------------------------------*/

            ListViewItem listboxitem = new ListViewItem();

            if (!isUpdate)
            {
                // Create items and three sets of sub items
                listboxitem = new ListViewItem(textBoxID.Text, 0);
                listboxitem.SubItems.Add(textBoxName.Text);
                listboxitem.SubItems.Add(textBoxQtyRequired.Text);
                listboxitem.SubItems.Add(textBoxQty.Text);

                //  Send data to active Child Form
                MainForm.childstack.Peek().ListItem.Items.Add(listboxitem);
            }
            else
            {
                entryitem.Text = textBoxID.Text;
                entryitem.SubItems[1].Text = textBoxName.Text;
                entryitem.SubItems[2].Text = textBoxQtyRequired.Text;
                entryitem.SubItems[3].Text = textBoxQty.Text;
            }
            //  Close the form
            this.Close();
        }
    }
}