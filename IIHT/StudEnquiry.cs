using System;
using System.Drawing;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IIHT
{
    public partial class frmStudEnquiry : BaseForm
    {
        DataSet ds = new DataSet();
        string _frmType;
        DataTable dt;
        SqlDataAdapter adpvisitor;
        SqlDataAdapter adpStudent;
        
        public frmStudEnquiry(string strFrmType)
        {
            InitializeComponent();
            _frmType = strFrmType;
        }

        #region Form Events
        private void frmStudEnquiry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                SendKeys.Send("{TAB}");
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        private void frmStudEnquiry_Load(object sender, EventArgs e)
        {
            #region Declare Events
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);

            this.btn_First.Click += new System.EventHandler(this.btn_First_Click);
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);

            this.txtContact.Validated += new System.EventHandler(this.txtContact_Validated);
            this.txtWhatsApp.Validated += new System.EventHandler(this.txtWhatsApp_Validated);

            
            
            this.cmbEmpName.Location=new Point(621,12);
            #endregion

            if (_frmType == "E")
                pnlAdmission.Visible = false;
                

            adpvisitor = DatabaseHelper.GetAdapter("Visitor");

            dt = new DataTable();
            adpvisitor.Fill(dt);
            //dt = DatabaseHelper.GetDataTable("visitor");
            
            ds.Tables.Add(dt);
            ds.Tables[0].TableName = "visitor";

            adpStudent = DatabaseHelper.GetAdapter("StudMaster");
                   

            FillComboForCourse();
            FillComboForEmployee();
            FillComboGender();

            LasRecord();
            ENABLE_DISABLE_CONTROLS(false);
        }
        #endregion

        #region Common Function
       
        private void ENABLE_DISABLE_CONTROLS(bool Val)
        {
            btn_Cancel.Enabled = Val;
            btn_Clear.Enabled = Val;
            btn_Save.Enabled = Val;
            btn_Edit.Enabled = !Val;
            btn_New.Enabled = !Val;
            btn_Delete.Enabled = !Val;

        }
        #endregion

        #region Trans Function
        private void ClearAll()
        {
            lblVisitorId.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtEducation.Text = "";
            txtContact.Text = "";
            txtWhatsApp.Text = "";
            txtEmail.Text = "";
            txtRefBy.Text = "";
            cmbGender.Text = "";
            txtEntryDate.Text = "";
            cmbCourse.Text = "";
            cmbEmpName.Text = "";
            ////ConfirmAddmission
            lblStudentId.Text = "";
            txtDOB.Text = "";
            txtDOA.Text = "";
            txtPhoto.Text = "";
            
        }
        private void NewRecord()
        {
            ClearAll();
            txtEntryDate.Text = System.DateTime.Today.ToShortDateString();
            ENABLE_DISABLE_CONTROLS(true);
            txtName.Focus();
        }
        private void SaveRecord()
        {
            if (lblVisitorId.Text == "") //Add New Record
            {

                adpvisitor.InsertCommand = new SqlCommand(@"insert into visitor(Name,address,city,contact,email,whatsapp,
                                                    referencedby,empid,education,courseid,gender,visitDate,status) 
                                                    values(@Name,@address,@city,@contact,@email,@whatsapp,@referencedby,
                                                    @empid,@education,@courseid,@gender,@visitDate,@status)", DatabaseHelper.connection);

                DatabaseHelper.connection.Open();
                adpvisitor.InsertCommand.Parameters.AddWithValue("@name", txtName.Text);
                adpvisitor.InsertCommand.Parameters.AddWithValue("@address", txtAddress.Text);
                adpvisitor.InsertCommand.Parameters.AddWithValue("@city", txtCity.Text);
                adpvisitor.InsertCommand.Parameters.AddWithValue("@contact", txtContact.Text);
                adpvisitor.InsertCommand.Parameters.AddWithValue("@email", txtEmail.Text);
                adpvisitor.InsertCommand.Parameters.AddWithValue("@whatsapp", txtWhatsApp.Text);
                adpvisitor.InsertCommand.Parameters.AddWithValue("@referencedby", txtRefBy.Text);
                adpvisitor.InsertCommand.Parameters.AddWithValue("@empid", int.Parse(cmbEmpName.SelectedValue.ToString()));
                adpvisitor.InsertCommand.Parameters.AddWithValue("@education", txtEducation.Text);
                adpvisitor.InsertCommand.Parameters.AddWithValue("@courseid", int.Parse(cmbCourse.SelectedValue.ToString()));
                adpvisitor.InsertCommand.Parameters.AddWithValue("@gender", cmbGender.SelectedValue.ToString());
                adpvisitor.InsertCommand.Parameters.AddWithValue("@visitDate", txtEntryDate.Text);
                adpvisitor.InsertCommand.Parameters.AddWithValue("@status", "V");
                adpvisitor.InsertCommand.ExecuteNonQuery();
                DatabaseHelper.connection.Close();
            }
            else ///Update Record
            {
                adpvisitor.UpdateCommand = new SqlCommand(@"update visitor set Name=@Name,address=@address,city=@city,contact=@contact,email=@email,
                                                            whatsapp=@whatsapp,referencedby=@referencedby,empid=@empid,education=@education,courseid=@courseid,
                                                            gender=@gender,visitDate=@visitDate,status=@status where VisitorID=@VisitorID", DatabaseHelper.connection);

                DatabaseHelper.connection.Open();
                adpvisitor.UpdateCommand.Parameters.AddWithValue("@name", txtName.Text);
                adpvisitor.UpdateCommand.Parameters.AddWithValue("@address", txtAddress.Text);
                adpvisitor.UpdateCommand.Parameters.AddWithValue("@city", txtCity.Text);
                adpvisitor.UpdateCommand.Parameters.AddWithValue("@contact", txtContact.Text);
                adpvisitor.UpdateCommand.Parameters.AddWithValue("@email", txtEmail.Text);
                adpvisitor.UpdateCommand.Parameters.AddWithValue("@whatsapp", txtWhatsApp.Text);
                adpvisitor.UpdateCommand.Parameters.AddWithValue("@referencedby", txtRefBy.Text);
                adpvisitor.UpdateCommand.Parameters.AddWithValue("@empid", int.Parse(cmbEmpName.SelectedValue.ToString()));
                adpvisitor.UpdateCommand.Parameters.AddWithValue("@education", txtEducation.Text);
                adpvisitor.UpdateCommand.Parameters.AddWithValue("@courseid", int.Parse(cmbCourse.SelectedValue.ToString()));
                adpvisitor.UpdateCommand.Parameters.AddWithValue("@gender", cmbGender.SelectedValue.ToString());
                adpvisitor.UpdateCommand.Parameters.AddWithValue("@visitDate", txtEntryDate.Text);
                adpvisitor.UpdateCommand.Parameters.AddWithValue("@VisitorID",int.Parse(lblVisitorId.Text));
                adpvisitor.UpdateCommand.Parameters.AddWithValue("@status","V");
                adpvisitor.UpdateCommand.ExecuteNonQuery();
                DatabaseHelper.connection.Close();
            }
            ShowMessagePrompt("Record Updated Successfully", "S");
            ds.Tables["Visitor"].Clear();
            adpvisitor.Fill(ds.Tables["Visitor"]);
        }
        private void DisplayAfterChanges()
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

                if(ds.Tables["Visitor"].Rows[Index]["gender"].ToString()=="f")
                    cmbGender.Text = "Female";
                else if(ds.Tables["Visitor"].Rows[Index]["gender"].ToString() == "m")
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
        private void DeleteRecord()
        {
            if (lblVisitorId.Text != "")
            {
                adpvisitor.DeleteCommand = new SqlCommand("delete Visitor where VisitorID=@id", DatabaseHelper.connection);
                DatabaseHelper.connection.Open();
                adpvisitor.DeleteCommand.Parameters.AddWithValue("@id", int.Parse(lblVisitorId.Text));
                adpvisitor.DeleteCommand.ExecuteNonQuery();
                DatabaseHelper.connection.Close();
                ShowMessagePrompt("Record Deleted Successfully!","S");

                ds.Tables["Visitor"].Clear();
                adpvisitor.Fill(ds.Tables["Visitor"]);
                LasRecord();  
            }
            else
            {
                ShowMessagePrompt("Please Select Record to Delete","");
            }
        }
        private void CancelRecord()
        {
            ClearAll();
            LasRecord();
            ENABLE_DISABLE_CONTROLS(false);

        }
        #endregion

        #region Navigation Function
        private void FirstRecord()
        {
            FillRecord(0);
        }
        private void LasRecord()
        {
            FillRecord(ds.Tables["Visitor"].Rows.Count - 1);
        }
        private void NextRecord()
        {
            if (lblVisitorId.Text != "")
            {
                DataRow[] row = ds.Tables["Visitor"].Select("VisitorId=" + Convert.ToInt32(lblVisitorId.Text));
                if (row.Length != 0)
                {
                    if (!row[0].IsNull("VisitorId"))
                    {
                        int rowIndex = ds.Tables["Visitor"].Rows.IndexOf(row[0]);
                        if (rowIndex >= 0 && rowIndex != ds.Tables["Visitor"].Rows.Count - 1)
                        {
                            FillRecord(rowIndex + 1);
                        }
                        else
                        {
                            FillRecord(ds.Tables["Visitor"].Rows.Count - 1);
                        }
                    }
                }
            }
            else
            {
                FillRecord(0);
            }
        }
        private void PreviousRecord()
        {
            if (lblVisitorId.Text != "")
            {
                DataRow[] row = ds.Tables["Visitor"].Select("VisitorId=" + Convert.ToInt32(lblVisitorId.Text));
                if (row.Length != 0)
                {
                    if (!row[0].IsNull("VisitorId"))
                    {
                        int rowIndex = ds.Tables["Visitor"].Rows.IndexOf(row[0]);
                        if (rowIndex > 0 && rowIndex != ds.Tables["Visitor"].Rows.Count)
                        {
                            FillRecord(rowIndex - 1);
                        }
                        else
                        {
                            FillRecord(0);
                        }
                    }
                }
            }
            else
            {
                FillRecord(0);
            }
        }
        #endregion

        #region Fill Combobox
        private void FillComboForCourse()
        {

            dt = new DataTable();
            dt = DatabaseHelper.GetDataTable("Course");
            ds.Tables.Add(dt);

            ds.Tables[1].TableName = "Course";
            cmbCourse.DisplayMember = "courseName";
            cmbCourse.ValueMember = "courseId";
            cmbCourse.DataSource = ds.Tables["Course"];

            
            AutoCompleteStringCollection strCourse = new AutoCompleteStringCollection();
            for (int i = 0; i < ds.Tables["Course"].Rows.Count; i++)
            {
                strCourse.Add(ds.Tables["Course"].Rows[i]["courseName"].ToString());
            }

            cmbCourse.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmbCourse.AutoCompleteCustomSource = strCourse;
            cmbCourse.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private void FillComboForEmployee()
        {

            dt = new DataTable();
            dt = DatabaseHelper.GetDataTable("EmpMaster");
            ds.Tables.Add(dt);

            ds.Tables[2].TableName = "EmpMaster";
            cmbEmpName.DisplayMember = "EmpName";
            cmbEmpName.ValueMember = "EmpId";
            cmbEmpName.DataSource = ds.Tables["EmpMaster"];


            AutoCompleteStringCollection stremp = new AutoCompleteStringCollection();
            for (int i = 0; i < ds.Tables["EmpMaster"].Rows.Count; i++)
            {
                stremp.Add(ds.Tables["EmpMaster"].Rows[i]["EmpName"].ToString());
            }

            cmbEmpName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmbEmpName.AutoCompleteCustomSource = stremp;
            cmbEmpName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private void FillComboGender()
        {
            dt = new DataTable();
            dt.Columns.Add("GId");
            dt.Columns.Add("GName");

            dt.Rows.Add("f", "Female");
            dt.Rows.Add("m", "Male");
            cmbGender.DisplayMember = "GName";
            cmbGender.ValueMember = "GId";
            cmbGender.DataSource = dt;

        }
        #endregion

        #region Trans Button Events
        private void btn_New_Click(object sender, EventArgs e)
        {
            NewRecord();
        }
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            ENABLE_DISABLE_CONTROLS(true);
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                ShowMessagePrompt("Enter Student Name", "");
                return;
            }
            ShowMessagePrompt("", "");
            SaveRecord();
            //GLOBAL.SaveDB();
            //NextRecord();
            ShowMessagePrompt("Record save successfully", "S");
            ENABLE_DISABLE_CONTROLS(false);
            
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DeleteRecord();
            ENABLE_DISABLE_CONTROLS(false);
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            CancelRecord();
        }
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearAll();
            ENABLE_DISABLE_CONTROLS(false);
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Navigation Events
        private void btn_First_Click(object sender, EventArgs e)
        {
            FirstRecord();
        }
        private void btn_previous_Click(object sender, EventArgs e)
        {
            PreviousRecord();
        }
        private void btn_next_Click(object sender, EventArgs e)
        {
            NextRecord();
        }
        private void btn_last_Click(object sender, EventArgs e)
        {
            LasRecord();
        }
        private void btn_Find_Click(object sender, EventArgs e)
        {
            clearAdmissionFields();

            Search obj = new Search("Visitor", "VisitorID"," Status='v'");
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
        #endregion

        #region textbox event
        private void txtContact_Validated(object sender, EventArgs e)
        {
            char[] chars = txtContact.Text.ToString().ToCharArray();
            bool IsNumeric = true;
            foreach (char c in chars)
            {
                if (char.IsDigit(c) == false)
                {
                    ShowMessagePrompt("You have to enter Mobile No only", "");
                    IsNumeric = false;
                    txtContact.Focus();
                    break;
                }
            }
            if (IsNumeric)
            {
                ShowMessagePrompt("", "S");
            }
            txtWhatsApp.Focus();
        }
        private void txtWhatsApp_Validated(object sender, EventArgs e)
        {
            char[] chars = txtWhatsApp.Text.ToString().ToCharArray();
            bool IsNumeric = true;
            foreach (char c in chars)
            {
                if (char.IsDigit(c) == false)
                {
                    ShowMessagePrompt("You have to enter Whatsup No only", "");
                    IsNumeric = false;
                    txtWhatsApp.Focus();
                    break;
                }
            }
            if (IsNumeric)
            {
                ShowMessagePrompt("", "S");
            }
            txtEmail.Focus();
        }
        #endregion

        private void btnAdmission_Click(object sender, EventArgs e)
        {
            if (lblVisitorId.Text != "" && lblStudentId.Text=="")
            {
                adpStudent.InsertCommand = new SqlCommand(@"insert into studmaster(studName,address,city,contact,whatsapp,email,
                                                    referencedby,empid,DOB,education,gender,photo,joiningDate) output inserted.StudId
                                                    values(@Name,@address,@city,@contact,@whatsapp,@email,@referencedby,
                                                    @empid,@DOB,@education,@gender,@photo,@joiningDate)", DatabaseHelper.connection);

                DatabaseHelper.connection.Open();
                adpStudent.InsertCommand.Parameters.AddWithValue("@name", txtName.Text);
                adpStudent.InsertCommand.Parameters.AddWithValue("@address", txtAddress.Text);
                adpStudent.InsertCommand.Parameters.AddWithValue("@city", txtCity.Text);
                adpStudent.InsertCommand.Parameters.AddWithValue("@contact", txtContact.Text);
                adpStudent.InsertCommand.Parameters.AddWithValue("@whatsapp", txtWhatsApp.Text);
                adpStudent.InsertCommand.Parameters.AddWithValue("@email", txtEmail.Text);
                adpStudent.InsertCommand.Parameters.AddWithValue("@referencedby", txtRefBy.Text);
                adpStudent.InsertCommand.Parameters.AddWithValue("@empid", int.Parse(cmbEmpName.SelectedValue.ToString()));
                adpStudent.InsertCommand.Parameters.AddWithValue("@DOB", txtDOB.Text);
                adpStudent.InsertCommand.Parameters.AddWithValue("@education", txtEducation.Text);
                adpStudent.InsertCommand.Parameters.AddWithValue("@gender", cmbGender.SelectedValue.ToString());
                adpStudent.InsertCommand.Parameters.AddWithValue("@photo", txtPhoto.Text);
                adpStudent.InsertCommand.Parameters.AddWithValue("@joiningDate", txtDOA.Text);
                int id = (int)adpStudent.InsertCommand.ExecuteScalar();

                lblStudentId.Text = "Student ID: " + id.ToString();

                adpvisitor.UpdateCommand = new SqlCommand(@"update visitor set status='A' where VisitorID=@VisitorID", DatabaseHelper.connection);
                adpvisitor.UpdateCommand.Parameters.AddWithValue("@VisitorID", int.Parse(lblVisitorId.Text));
                adpvisitor.UpdateCommand.ExecuteNonQuery();
                DatabaseHelper.connection.Close();

                ds.Tables["Visitor"].Clear();
                adpvisitor.Fill(ds.Tables["Visitor"]);

                
                
                LasRecord();
                

                
            }
        }

        private void btnImgUpload_Click(object sender, EventArgs e)
        {
            openFileStudImg.DefaultExt = "jpg";

            if (openFileStudImg.ShowDialog() == DialogResult.OK)
            {
                txtPhoto.Text = openFileStudImg.FileName;
            }
        }

        private void clearAdmissionFields()
        {
            txtDOA.Clear();
            txtDOB.Clear();
            txtPhoto.Clear();
            lblStudentId.Text = "";
        }

       
    }
}
