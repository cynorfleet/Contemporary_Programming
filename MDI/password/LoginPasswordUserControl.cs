﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace password
{
    public partial class LoginPasswordUser : UserControl
    {
        public LoginPasswordUser()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("ACCESS GRANTED");
            this.ParentForm.Close();
        }
    }
}