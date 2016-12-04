/*= == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == ==
| Class	:		ChildForm
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
| Description : Defines the Child MDI window which will display the inventory
|               data in a list view. It receives its data from the InputDialog.
|
| Required Features Not Included : DESCRIBE HERE ANY REQUIREMENTS OF
|				THE ASSIGNMENT THAT THE PROGRAM DOES NOT ATTEMPT TO SOLVE.
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
    public partial class ChildForm : Form
    {
        private Record record = new Record();

        public ChildForm()
        {
            /*-------------------------------------------- ChildForm ----------
            |  Function: 	ChildForm()
            |
            |  Purpose: 	Initializer
            |
            |  Returns:  	N/A
            *---------------------------------------------------------------------*/
            InitializeComponent();
        }

        public void ChildForm_Load(object sender, EventArgs e)
        {
            /*-------------------------------------------- ChildForm_Load ----------
            |  Function: 	ChildForm_Load()
            |
            |  Purpose: 	Defines OnLoad behavior. Will set the default view of the
            |               ListBox.
            |
            |  Returns:  	N/A
            *---------------------------------------------------------------------*/

            // Set the view to show details.
            ListItem.View = View.Details;
            // Display grid lines.
            ListItem.GridLines = true;
            // Select the item and sub items when selection is made.
            ListItem.FullRowSelect = true;
        }

        private void ChildForm_Enter(object sender, EventArgs e)
        {
            /*-------------------------------------------- ChildForm_Enter ----------
            |  Function: 	ChildForm_Enter()
            |
            |  Purpose: 	When focused will PUSH the current Child MDI window to
            |               the stack marking it active.
            |
            |  Returns:  	N/A
            *---------------------------------------------------------------------*/
            MainForm.childstack.Push(this);
        }

        private void ChildForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*-------------------------------------------- ChildForm_Enter ----------
            |  Function: 	ChildForm_Enter()
            |
            |  Purpose: 	On exit will POP the current Child MDI window to
            |               the stack marking it active.
            |
            |  Returns:  	N/A
            *---------------------------------------------------------------------*/
            MainForm.childstack.Pop();
        }

        private void ChildForm_Leave(object sender, EventArgs e)
        {
            /*-------------------------------------------- ChildForm_Enter ----------
            |  Function: 	ChildForm_Enter()
            |
            |  Purpose: 	When LEAVING will POP the current Child MDI window to
            |               the stack marking it active.
            |
            |  Returns:  	N/A
            *---------------------------------------------------------------------*/
            MainForm.childstack.Pop();
        }
    }
}