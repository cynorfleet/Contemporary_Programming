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
| Description : This is the main window. It will host CHILD MDI windows
|               and call an INPUTDIALOG when appropriate. Available
|               operations for records are INSERT, UPDATE, and DELETE.
|
|               UPDATE -- Will update multiple selected fields to ACTIVE child appropriately
|               DELETE -- Will delete multiple selected fields to ACTIVE child appropriately
|               INSERT -- Will add a new field to ACTIVE child appropriately
|
|               This program implements a static STACK to keep track of the ACTIVE MDI child
|
| Known Bugs :	IF THE PROGRAM DOES NOT FUNCTION CORRECTLY IN SOME
|				SITUATIONS, DESCRIBE THE SITUATIONS AND PROBLEMS HERE
|				AND EMAIL "cynorfleet@gmail.com" per Christian Norfleet
|
*= == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == */

using MDI;
using password;
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
using System.Windows;
using System.Windows.Forms;

namespace MDI
{
    public partial class MainForm : Form
    {
        public static Stack<ChildForm> childstack = new Stack<ChildForm>();

        //                          GLOBALS                           //
        private List<ChildForm> childList = new List<ChildForm>();

        private Record record = new Record();
        private List<Record> recordlist = new List<Record>();

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
            new LoginForm().ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*------------------------------------- deleteToolStripMenuItem_Click ----------
            |  Function: 	deleteToolStripMenuItem_Click()
            |
            |  Purpose: 	Defines the menu operation delete. It will check the stack to
            |               find active MDIChild. It will then cont the total amount of
            |               selected items and delete them BOTTOM-UP.
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
            recordlist.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*------------------------------ exitToolStripMenuItem_Click ----------
            |  Function: 	exitToolStripMenuItem_Click()
            |
            |  Purpose: 	Defines the EXIT menu operation. It will prompt user
            |               to save then exit application.
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

        private void GetList()
        {
            /*-------------------------------------------- GetList ----------
            |  Function: 	GetList()
            |
            |  Purpose: 	Gets an itemized record list
            |
            |  Returns:  	N/A
            *---------------------------------------------------------------------*/
            var list = childstack.Peek().ListItem;
            foreach (ListViewItem item in list.Items)
            {
                record.ID = Int32.Parse(item.Text);
                record.Name = item.SubItems[1].Text;
                record.QtyReq = Int32.Parse(item.SubItems[2].Text);
                record.Quantity = Int32.Parse(item.SubItems[3].Text);
                recordlist.Add(record);
                MessageBox.Show("Record: " + record.ToString());
            }
        }
        private void GrabData(ListViewItem e, InputDialog t = null)
        {
            /*-------------------------------------------- GrabData ----------
            |  Function: 	GrabData()
            |
            |  Purpose: 	Captures data from e (Child MDI Listview)
            |
            |  Returns:  	N/A
            *---------------------------------------------------------------------*/
            if (t == null)
            {
                record.ID = Int32.Parse(e.Text);
                record.Name = e.SubItems[1].Text;
                record.QtyReq = Int32.Parse(e.SubItems[2].Text);
                record.Quantity = Int32.Parse(e.SubItems[3].Text);
            }
            if (t != null)
            {
                t.textBoxID.Text = e.Text;
                t.textBoxName.Text = e.SubItems[1].Text;
                t.textBoxQty.Text = e.SubItems[2].Text;
                t.textBoxQtyRequired.Text = e.SubItems[3].Text;
            }
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*--------------------------- insertToolStripMenuItem_Click ----------
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

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  Add an instance of a child form to a list
            childList.Add(new ChildForm());

            childList.Last().MdiParent = this;

            childstack.Push(childList.Last());

            childstack.Peek().Show();
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
            string file = "";

            // Show the dialog and get result.
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                file = openFileDialog1.FileName;
            }

            //  Add an instance of a child form to a list
            childList.Add(new ChildForm());

            childList.Last().MdiParent = this;

            //  Stack DEBUG
            childstack.Push(childList.Last());

            try
            {
                //  Decrypt data
                using (Stream stream = File.Open(file, FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    recordlist = (List<Record>)bin.Deserialize(stream);
                    foreach (Record parsed in recordlist)
                    {
                        var thisone = childstack.Peek().ListItem.Items;
                        var index = thisone.Add(parsed.ID + "").Index;
                        thisone[index].SubItems.Add(parsed.Name);
                        thisone[index].SubItems.Add(parsed.QtyReq + "");
                        thisone[index].SubItems.Add(parsed.Quantity + "");
                    }
                    stream.Close();
                }
            }
            catch
            {
                MessageBox.Show("Could not open file");
            }

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
                string savefilepath = "";
                ListView tempview = childstack.Peek().ListItem;

                //  if active MDI child has items in list box
                if (childstack.Peek().ListItem.Items.Count > 0)

                //  Open Save to window
                {
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.Title = "Save inventory File";
                    saveFileDialog1.CheckPathExists = true;
                    saveFileDialog1.DefaultExt = "dab";
                    saveFileDialog1.Filter = "Dank Database files (*.dab)|*.dab|All files (*.*)|*.*";
                    saveFileDialog1.FilterIndex = 0;
                    saveFileDialog1.RestoreDirectory = true;

                    //  On OK store path and delete existing file
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        savefilepath = saveFileDialog1.FileName;
                        File.Delete(savefilepath);
                    }

                    try
                    {
                        //  Encrypt the Data
                        using (Stream stream = File.Open(savefilepath, FileMode.Create))
                        {
                            GetList();
                            BinaryFormatter encrypt = new BinaryFormatter();
                            encrypt.Serialize(stream, recordlist);
                        }
                    }
                    catch
                    {
                        //  Show Message on Failure
                        var retry = MessageBox.Show("Change your mind huh?", "WARNING", MessageBoxButtons.RetryCancel,
                            MessageBoxIcon.Warning);
                        if (retry == DialogResult.Retry)
                            this.saveToolStripMenuItem_Click(sender, e);
                    }
                }
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*------------------------------------- updateToolStripMenuItem_Click ----------
            |  Function: 	updateToolStripMenuItem_Click()
            |
            |  Purpose: 	If a Child MDI window is open and ListBox items are selected,
            |               display confirmation dialog. If confirmed modify the selected
            |               entries in the order of BOTTOM-UP.
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
                        //  Loop through the selected items by index
                        for (int i = listbox.SelectedItems.Count - 1; i >= 0; i--)
                        {
                            //  Grab an element
                            ListViewItem itm = listbox.SelectedItems[i];

                            //  Open a Input Dialog Window
                            InputDialog entryform = new InputDialog(itm, true);
                            //  Grab Child's ListView contents and write to Input Form
                            GrabData(itm, entryform);
                            //  Show the Input Form
                            entryform.ShowDialog();
                        }
                    }
                }
                else
                    MessageBox.Show("No items to modify");
            }
        }
    }
}