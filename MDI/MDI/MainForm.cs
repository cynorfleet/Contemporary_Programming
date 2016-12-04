/*= == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == ==
| Class	:		MainForm
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
| Description : This is the main window. It will host CHILDMDI windows
|               and call an INPUTDIALOG when appropriate. Available
|               operations for records are INSERT, UPDATE, and DELETE.
|
| Known Bugs :	IF THE PROGRAM DOES NOT FUNCTION CORRECTLY IN SOME
|				SITUATIONS, DESCRIBE THE SITUATIONS AND PROBLEMS HERE
|				AND EMAIL "cynorfleet@gmail.com" per Christian Norfleet
|
*= == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == */

using MDI;
using RecordClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI
{
    public partial class MainForm : Form
    {
        public static Stack<ChildForm> childstack = new Stack<ChildForm>();

        //                          GLOBALS                           //
        private List<ChildForm> childList = new List<ChildForm>();

        public MainForm()
        {
            /*-------------------------------------------- MainForm ----------
            |  Function: 	MainForm()
            |
            |  Purpose: 	Initializer
            |
            |  Returns:  	N/A
            *---------------------------------------------------------------------*/
            InitializeComponent();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*------------------------------------- deleteToolStripMenuItem_Click ----------
            |  Function: 	deleteToolStripMenuItem_Click()
            |
            |  Purpose: 	Defines the menu operation delete. It will check the stack to find active
            |               MDIChild. It will then cont the total amount of selected items and delete them
            |               BOTTOM-UP.
            |
            |  Returns:  	N/A
            *---------------------------------------------------------------------*/

            //  if there is an active Child window
            if (childstack.Count > 0)
            {
                //  grab its ListBox
                var listbox = childstack.Peek().ListItem;

                //  if listbox is not empty
                if (listbox.SelectedItems.Count > 0)
                {
                    //  confirm deletion of selected entries
                    var confirmation = MessageBox.Show("Are you sure u want to delete?", "Confirm",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    //  if confirmed
                    if (confirmation == DialogResult.Yes)
                    {
                        //  delete each entry according to its index value in order of BOTTOM-UP
                        for (int i = listbox.SelectedItems.Count - 1; i >= 0; i--)
                        {
                            ListViewItem itm = listbox.SelectedItems[i];
                            listbox.Items[itm.Index].Remove();
                        }
                    }
                }

                //  if no items are selected display
                else
                    MessageBox.Show("No items to delete");
            }
        }

        private void Encryptit()
        {
            /////////////////////// PROTOTYPE /////////////////////////
            try
            {
                using (Stream stream = File.Open("data.bin", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    //   bin.Serialize(stream, );
                }
            }
            catch (IOException)
            {
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*-------------------------------------------- exitToolStripMenuItem_Click ----------
            |  Function: 	exitToolStripMenuItem_Click()
            |
            |  Purpose: 	Defines the EXIT menu operation. It will prompt user to save then exit
            |               application.
            |
            |  Returns:  	N/A
            *---------------------------------------------------------------------*/
            var confirmation = MessageBox.Show("Would you like to save Changes?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmation == DialogResult.Yes)
            {
                saveToolStripMenuItem_Click(this, null);
            }

            this.Close();
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*-------------------------------------------- insertToolStripMenuItem_Click ----------
            |  Function: 	insertToolStripMenuItem_Click()
            |
            |  Purpose: 	Defines the INSERT menu operation.
            |
            |  Returns:  	N/A
            *---------------------------------------------------------------------*/
            if (childstack.Count > 0)
            {
                //  Open a Record Input Dialog Window
                InputDialog entryform = new InputDialog();
                entryform.ShowDialog();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*-------------------------------------------- openToolStripMenuItem_Click ----------
            |  Function: 	openToolStripMenuItem_Click()
            |
            |  Purpose: 	Defines the open menu operation. It will open up a file dialog window.
            |               Once user opens a the file, a child MDI window is opened showing
            |               inventory data.
            |
            |  Returns:  	N/A
            *---------------------------------------------------------------------*/
            int size = 0;
            string text = "";

            /////////////////////// PROTOTYPE /////////////////////////

            // Show the dialog and get result.
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    //  Read file contents
                    text = File.ReadAllText(file);
                    size = text.Length;
                }
                catch (IOException)
                {
                }
            }
            MessageBox.Show(text); // <-- For debugging use.

            //  Add an instance of a child form to a list
            childList.Add(new ChildForm());

            childList.Last().MdiParent = this;

            //  Stack DEBUG
            childstack.Push(childList.Last());

            //  Show the child form
            childList.Last().Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*-------------------------------------------- saveToolStripMenuItem_Click ----------
            |  Function: 	saveToolStripMenuItem_Click()
            |
            |  Purpose: 	Defines the save menu operation. If a child MDI window is open, active,
            |               and its Listbox is not empty, save its entries to a string builder.
            |
            |  Returns:  	N/A
            *---------------------------------------------------------------------*/
            if (childstack.Count > 0)
            {
                string debugstring = "";
                StringBuilder sb;
                ListView tempview = childstack.Peek().ListItem;

                /////////////////////// PROTOTYPE /////////////////////////

                //  if active MDI child has items in list box
                if (childstack.Peek().ListItem.Items.Count > 0)
                {
                    // grab the data from the ListBox (tempview is a link to the active child's Listbox)
                    foreach (ListViewItem item in tempview.Items)
                    {
                        sb = new StringBuilder();

                        //  start building the string for sub items
                        foreach (ListViewItem.ListViewSubItem listViewSubItem in item.SubItems)
                        {
                            sb.Append(string.Format("{0}\t", listViewSubItem.Text));
                        }

                        //  send string builder to debug string
                        debugstring += sb.ToString();
                        debugstring += '\n';
                    }
                }

                MessageBox.Show(debugstring);
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*-------------------------------------------- updateToolStripMenuItem_Click ----------
            |  Function: 	updateToolStripMenuItem_Click()
            |
            |  Purpose: 	If a Child MDI window is open and ListBox items are selected, display
            |               confirmation dialog. If confirmed modify the selected entries in the order
            |               of BOTTOM-UP.
            |
            |  Returns:  	N/A
            *---------------------------------------------------------------------*/
            if (childstack.Count > 0)
            {
                var listbox = childstack.Peek().ListItem;
                if (listbox.SelectedItems.Count > 0)
                {
                    var confirmation = MessageBox.Show("Are you sure u want to modify row(s)", "Confirm",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirmation == DialogResult.Yes)
                    {
                        for (int i = listbox.SelectedItems.Count - 1; i >= 0; i--)
                        {
                            ListViewItem itm = listbox.SelectedItems[i];
                            insertToolStripMenuItem_Click(this, null);
                            var tempitem = listbox.Items[listbox.Items.Count - 1];
                            listbox.Items[listbox.Items.Count - 1].Remove();
                            listbox.Items[itm.Index] = tempitem;
                        }
                    }
                }
                else
                    MessageBox.Show("No items to modify");
            }
        }
    }
}