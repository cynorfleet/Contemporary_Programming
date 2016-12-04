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

        //          GLOBALS         //
        private List<ChildForm> childList = new List<ChildForm>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void cHILDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  Add an instance of a child form to a list
            childList.Add(new ChildForm());

            childList.Last().MdiParent = this;

            //  Stack DEBUG
            childstack.Push(childList.Last());

            //  Show the child form
            childList.Last().Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (childstack.Count > 0)
            {
                var listbox = childstack.Peek().ListItem;
                if (listbox.SelectedItems.Count > 0)
                {
                    var confirmation = MessageBox.Show("Are you sure u want to delete?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmation == DialogResult.Yes)
                    {
                        for (int i = listbox.SelectedItems.Count - 1; i >= 0; i--)
                        {
                            ListViewItem itm = listbox.SelectedItems[i];
                            listbox.Items[itm.Index].Remove();
                        }
                    }
                }
                else
                    MessageBox.Show("No items to delete");
            }
        }

        private void Encryptit()
        {
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
            var confirmation = MessageBox.Show("Would you like to save Changes?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {
                saveToolStripMenuItem_Click(this, null);
            }
            this.Close();
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (childstack.Count > 0)
            {
                //  Open a Record Input Dialog Window
                InputDialog entryform = new InputDialog();
                entryform.ShowDialog();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int size = 0;
            string text = "";

            // Show the dialog and get result.
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
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

        private void rECORDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  Open a Record Input Dialog Window
            InputDialog entryform = new InputDialog();
            entryform.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (childstack.Count > 0)
            {
                string debugstring = "";
                StringBuilder sb;
                ListView tempview = childstack.Peek().ListItem;

                if (childstack.Peek().ListItem.Items.Count > 0)
                {
                    // the actual data
                    foreach (ListViewItem item in tempview.Items)
                    {
                        sb = new StringBuilder();

                        foreach (ListViewItem.ListViewSubItem listViewSubItem in item.SubItems)
                        {
                            sb.Append(string.Format("{0}\t", listViewSubItem.Text));
                        }
                        debugstring += sb.ToString();
                        debugstring += '\n';
                    }
                }

                MessageBox.Show(debugstring);
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (childstack.Count > 0)
            {
                var listbox = childstack.Peek().ListItem;
                if (listbox.SelectedItems.Count > 0)
                {
                    var confirmation = MessageBox.Show("Are you sure u want to modify row(s)", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmation == DialogResult.Yes)
                    {
                        for (int i = listbox.SelectedItems.Count - 1; i >= 0; i--)
                        {
                            ListViewItem itm = listbox.SelectedItems[i];
                            rECORDToolStripMenuItem_Click(this, null);
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