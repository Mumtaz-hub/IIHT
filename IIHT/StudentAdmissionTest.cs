using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IIHT
{
    public partial class StudentAdmission : BaseForm
    {
        public StudentAdmission()
        {
            InitializeComponent();
        }

        SqlDataAdapter adpStudentInfo;
        //SqlDataAdapter adpStudentDetail;
        DataSet ds;
        DataTable dt;
        string StrColName;
        

        private void frmStudentAdmission_Load(object sender, EventArgs e)
        {
                        
        }

        private void displayStudentRecord()
        {
           
            adpStudentInfo = DatabaseHelper.GetAdapter("Visitor");
            dt = new DataTable();

            adpStudentInfo.Fill(dt);
            ds.Tables.Add(dt);

            ds.Tables[0].TableName = "Visitor";
            dgvName.DataSource = null;
            dgvName.DataSource = ds.Tables["Visitor"];
            dgvName.Columns["VisitorID"].Visible = false;

        }

        private void displayField()
        {
            adpStudentInfo = DatabaseHelper.GetadpForTableColumnName("Visitor");
            dt = new DataTable();

            adpStudentInfo.Fill(dt);
            ds.Tables.Add(dt);
            ds.Tables[1].TableName = "VisitorColumns";

            cmbFieldName.DisplayMember = "FieldName";
            cmbFieldName.ValueMember = "FieldName";
            cmbFieldName.DataSource = ds.Tables["VisitorColumns"];

        }

        private void btnNameSearch_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            panel1.Visible = true;
            displayStudentRecord();
            displayField();
        }

        private void cmbFieldName_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbFieldName.SelectedValue != null)
            {
                StrColName = cmbFieldName.SelectedValue.ToString();
            }
        }

        

        private void txtFieldValue_TextChanged(object sender, EventArgs e)
        {
            ds.Tables["Visitor"].DefaultView.RowFilter = "";
            ds.Tables["Visitor"].DefaultView.RowFilter = StrColName + " like '%" + txtFieldValue.Text + "%'";

            dgvName.DataSource = ds.Tables["Visitor"].DefaultView;
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            ds.Tables["Visitor"].DefaultView.RowFilter = "";
            ds.Tables["Visitor"].DefaultView.RowFilter = StrColName + " like '%" + txtFieldValue.Text + "%'";

            dgvName.DataSource = ds.Tables["Visitor"].DefaultView;
        }

        private void dgvName_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < dgvName.RowCount - 1)
            {
                //txtName.Text = dgvName.Rows[e.RowIndex].Cells["name"].Value.ToString();
                //txtAddress.Text = dgvName.Rows[e.RowIndex].Cells["address"].Value.ToString();
                //txtCity.Text = dgvName.Rows[e.RowIndex].Cells["city"].Value.ToString();
                //txtEducation.Text = dgvName.Rows[e.RowIndex].Cells["education"].Value.ToString();
                //txtContact.Text = dgvName.Rows[e.RowIndex].Cells["contact"].Value.ToString();
                //txtWhatsApp.Text = dgvName.Rows[e.RowIndex].Cells["whatsApp"].Value.ToString();
                //txtEmail.Text = dgvName.Rows[e.RowIndex].Cells["email"].Value.ToString();
                //txtRefBy.Text = dgvName.Rows[e.RowIndex].Cells["referencedBy"].Value.ToString();

                //string gender = dgvName.Rows[e.RowIndex].Cells["gender"].Value.ToString();
                //if (gender == "F" || gender == "f")
                //    cmbGender.SelectedItem = "Female";
                //else
                //    cmbGender.SelectedItem = "Male";
            }
            else
            {
                //txtName.Text = ""; txtAddress.Text = ""; txtCity.Text = ""; txtEducation.Text = "";
                //txtContact.Text = ""; txtWhatsApp.Text = ""; txtEmail.Text = ""; txtRefBy.Text = "";
                
            }
        }

        
     
    }
}
