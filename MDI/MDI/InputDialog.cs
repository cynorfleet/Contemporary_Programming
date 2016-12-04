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
| Description : This form will capture user input and send data to the
|               ACTIVE MDI CHILD's ListBox.
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
        //                    GLOBALS                   //
        private List<Record> recordList = new List<Record>();

        public InputDialog()
        {
            /*-------------------------------------------- InputDialog ----------
            |  Function: 	InputDialog()
            |
            |  Purpose: 	Initializer
            |
            |  Returns:  	N/A
            *---------------------------------------------------------------------*/
            InitializeComponent();
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
            |  Purpose: 	Defines OK button behavior. Will add user input into
            |               ListView format and send them to Child ListView form.
            |               The window will then close.
            |
            |  Returns:  	N/A
            *---------------------------------------------------------------------*/
            ListViewItem listboxitem = new ListViewItem();

            // Create items and three sets of sub items
            listboxitem = new ListViewItem(textBoxID.Text, 0);
            listboxitem.SubItems.Add(textBoxName.Text);
            listboxitem.SubItems.Add(textBoxQtyRequired.Text);
            listboxitem.SubItems.Add(textBoxQty.Text);

            //  Send data to active Child Form
            MainForm.childstack.Peek().ListItem.Items.Add(listboxitem);

            //  Close the form
            this.Close();
        }
    }
}