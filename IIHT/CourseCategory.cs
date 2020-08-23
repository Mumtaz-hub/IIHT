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
    public partial class frmCourseCategory : Form
    {
        public frmCourseCategory()
        {
            InitializeComponent();
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstCategory.Items.Add(txtDept.Text);
            txtDept.Clear();
            txtDept.Focus();
        }
    }
}
