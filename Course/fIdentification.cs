using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Course
{
    public partial class fIdentification : Form
    {
        public fIdentification()
        {
            InitializeComponent();
        }

        private void tBPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.Close();

        }

        private void fIdentification_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (tBPassword.Text == "1")
                this.DialogResult = DialogResult.OK;  

        }

        
    }
}
