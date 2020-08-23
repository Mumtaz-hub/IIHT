using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IIHT
{
    public partial class frmStudentAdmission : BaseForm
    {
        public frmStudentAdmission()
        {
            InitializeComponent();
        }

        
        //SqlDataAdapter adpStudentDetail;
        DataSet ds=new DataSet();
        
        
        

        private void frmStudentAdmission_Load(object sender, EventArgs e)
        {
                        
        }

        
        private void FillRecord(int Index)
        {
            if (ds.Tables["Visitor"].Rows.Count > 0)
            {
                #region Fill Visitor Details
                lblVisitorId.Text = ds.Tables["Visitor"].Rows[Index]["VisitorId"].ToString();
                txtName.Text = ds.Tables["Visitor"].Rows[Index]["name"].ToString();
                txtAddress.Text = ds.Tables["Visitor"].Rows[Index]["address"].ToString();
                txtCity.Text = ds.Tables["Visitor"].Rows[Index]["city"].ToString();
                txtEducation.Text = ds.Tables["Visitor"].Rows[Index]["education"].ToString();
                txtContact.Text = ds.Tables["Visitor"].Rows[Index]["contact"].ToString();
                txtWhatsApp.Text = ds.Tables["Visitor"].Rows[Index]["whatsapp"].ToString();
                txtEmail.Text = ds.Tables["Visitor"].Rows[Index]["email"].ToString();
                txtRefBy.Text = ds.Tables["Visitor"].Rows[Index]["referencedby"].ToString();
                txtEntryDate.Text = ds.Tables["Visitor"].Rows[Index]["visitDate"].ToString();

                if (ds.Tables["Visitor"].Rows[Index]["gender"].ToString() == "f")
                    cmbGender.Text = "Female";
                else if (ds.Tables["Visitor"].Rows[Index]["gender"].ToString() == "m")
                    cmbGender.Text = "Male";

                #region Fill Course
                DataRow[] rowCourse = ds.Tables["course"].Select("courseid=" + Convert.ToInt32(ds.Tables["Visitor"].Rows[Index]["courseid"].ToString()));
                if (rowCourse.Length != 0)
                {
                    if (!rowCourse[0].IsNull("courseid"))
                    {
                        int rowIndex = ds.Tables["course"].Rows.IndexOf(rowCourse[0]);
                        cmbCourse.Text = ds.Tables["course"].Rows[rowIndex]["courseName"].ToString();
                    }
                }
                #endregion

                #region Fill Counselor
                DataRow[] rowEmp = ds.Tables["EmpMaster"].Select("empid=" + Convert.ToInt32(ds.Tables["Visitor"].Rows[Index]["empid"].ToString()));
                if (rowEmp.Length != 0)
                {
                    if (!rowEmp[0].IsNull("empid"))
                    {
                        int rowIndex = ds.Tables["EmpMaster"].Rows.IndexOf(rowEmp[0]);
                        cmbEmpName.Text = ds.Tables["EmpMaster"].Rows[rowIndex]["EmpName"].ToString();
                    }
                }
                #endregion



                #endregion

            }
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            Search obj = new Search("Visitor", "VisitorID");
            obj.ShowDialog();

            DataRow[] rowVisitor = ds.Tables["Visitor"].Select("VisitorID=" + int.Parse(DatabaseHelper._PkColValue.ToString()));
            if (rowVisitor.Length != 0)
            {
                if (!rowVisitor[0].IsNull("VisitorID"))
                {
                    int rowIndex = ds.Tables["Visitor"].Rows.IndexOf(rowVisitor[0]);
                    FillRecord(rowIndex);
                }
            }
        }

     }
}
