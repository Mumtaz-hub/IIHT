using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IIHT
{
    public partial class frmModule :Form
    {
        public frmModule()
        {
            InitializeComponent();
            btnEdit.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtModule.Text != "" && txtModule.Text!=" ")
            {
                lstModules.Items.Add(txtModule.Text);
                txtModule.Clear();
                txtModule.Focus();
            }
            else
            {
                MessageBox.Show("Module Name is not entred","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);   
            }
        }

        private void lstModules_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void lstModules_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEdit.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // delete selected item from list
            //paste in textbox and allow to add updated one
        }
    }
}
