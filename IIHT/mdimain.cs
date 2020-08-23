using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace IIHT
{
    public partial class mdimain : Form
    {


        public mdimain()
        {
            InitializeComponent();
        }

        private void mdimain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void mdimain_Load(object sender, EventArgs e)
        {

        }

        private void inquiryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudEnquiry obj = new frmStudEnquiry("E");
            obj.ShowDialog();
        }

        private void admissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudEnquiry obj = new frmStudEnquiry("A");
            obj.ShowDialog();
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseDetail obj = new CourseDetail();
            obj.Show();
        }

        private void employeeSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpMaster obj = new frmEmpMaster();
            obj.Show();
        }

        private void admissionDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdmissionDetail obj = new AdmissionDetail();
            obj.Show();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport obj = new frmReport();
            obj.ShowDialog();
        }

        
    }
}
