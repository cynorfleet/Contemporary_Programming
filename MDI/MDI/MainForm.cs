using MDI;
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
    public partial class MainForm : Form
    {
        public static Stack<ChildForm> childstack = new Stack<ChildForm>();
        public static Record record = new Record();
        public static List<Record> recordlist = new List<Record>();
        public static ChildForm tempChild;

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

            //  Set parent form for the child window
            childList.Last().MdiParent = this;
            tempChild = ActiveMdiChild as ChildForm;

            //  Stack DEBUG
            childstack.Push(childList.Last());

            //  Show the child form
            childList.Last().Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void rECORDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  Open a Record Input Dialog Window
            InputDialog entryform = new InputDialog();
            entryform.ShowDialog();
        }
    }
}