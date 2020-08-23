using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IIHT
{
    public partial class AdmissionDetail : IIHT.BaseForm
    {
        public AdmissionDetail()
        {
            InitializeComponent();
        }

        DataSet _dsStudent;
        DataSet dsSerch;
        DataSet dsCourse_Module;
        DataTable _DataTable;
        SqlDataAdapter _adpStudent;
        SqlDataAdapter adpTableInfo;
        SqlDataAdapter adpStudCourse;
        SqlDataAdapter adpStudCourseModule;
        SqlDataAdapter adpCourse;
        SqlDataAdapter adpModule;
        SqlDataAdapter adpEmp;
        SqlDataAdapter adpFees;
        SqlDataAdapter adpFeesDetail;

        string StrColName;
        int _studId;
        int _CenterId;
        int _CourseId;
        int _FeesId;
        decimal _CourseFees;

        #region Form Events
        private void AdmissionDetail_Load(object sender, EventArgs e)
        {

            #region Declare Events
            this.gridStudent.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridStudent_RowEnter);
            this.gridStudent.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridStudent_MouseDoubleClick);
                        
            this.dgvStudCourse.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvStudCourse_DefaultValuesNeeded);
            this.dgvStudCourse.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudCourse_RowValidated);
            this.dgvStudCourse.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvStudCourse_UserDeletedRow);
            this.dgvStudentCourseModuleDetail.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvStudentCourseModuleDetail_DefaultValuesNeeded);
            this.dgvStudentCourseModuleDetail.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentCourseModuleDetail_RowValidated);
            this.dgvStudentCourseModuleDetail.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvStudentCourseModuleDetail_UserDeletedRow);
            this.txtFieldValue.TextChanged += new System.EventHandler(this.txtFieldValue_TextChanged);
            this.cmbFieldName.SelectedValueChanged += new System.EventHandler(this.cmbFieldName_SelectedValueChanged);
            #endregion

            #region Fill Adapter ,Set Dataset, Set Grid


            // dsCourse_Module Fill

            adpCourse = DatabaseHelper.GetAdapter("Course");
            dsCourse_Module = new DataSet();
            adpCourse.Fill(dsCourse_Module);
            dsCourse_Module.Tables[0].TableName = "Course";

            adpModule = DatabaseHelper.GetAdapter("CourseModule");
            adpModule.Fill(dsCourse_Module);
            dsCourse_Module.Tables[1].TableName = "CourseModule";

            adpEmp = DatabaseHelper.GetAdapter("EmpMaster");
            adpEmp.Fill(dsCourse_Module);
            dsCourse_Module.Tables[2].TableName = "EmpMaster";

            DataTable dt = new DataTable();
            dt.Columns.Add("status");
            dt.Rows.Add("Running");
            dt.Rows.Add("Complete");
            dt.Rows.Add("Drop");
            dt.Rows.Add("InComplete");
            dsCourse_Module.Tables.Add(dt);
            dsCourse_Module.Tables[3].TableName = "status";

            dt = new DataTable();
            dt.Columns.Add("batchTime");
            dt.Rows.Add("08AM-10AM");
            dt.Rows.Add("08AM-09AM");
            dt.Rows.Add("09AM-10AM");

            dt.Rows.Add("10AM-12AM");
            dt.Rows.Add("10AM-11AM");
            dt.Rows.Add("11AM-12AM");

            dt.Rows.Add("12AM-02PM");
            dt.Rows.Add("12AM-01PM");
            dt.Rows.Add("01PM-02PM");

            dt.Rows.Add("02PM-04PM");
            dt.Rows.Add("02PM-03PM");
            dt.Rows.Add("03PM-04PM");

            dt.Rows.Add("04PM-06PM");
            dt.Rows.Add("04PM-05PM");
            dt.Rows.Add("05PM-06PM");

            dt.Rows.Add("06PM-08PM");
            dt.Rows.Add("06PM-07PM");
            dt.Rows.Add("07PM-08PM");

            dsCourse_Module.Tables.Add(dt);
            dsCourse_Module.Tables[4].TableName = "BatchTime";


            //_dsStudent Fill
            _adpStudent = DatabaseHelper.GetAdapter("StudMaster");
            _DataTable = new DataTable();
            _adpStudent.Fill(_DataTable);

            _dsStudent = new DataSet();
            _dsStudent.Tables.Add(_DataTable);
            _dsStudent.Tables[0].TableName = "StudMaster";

            SetGrid_StudentMaster();
            displayField();

            adpStudCourse = DatabaseHelper.GetAdapter("StudCourse");
            adpStudCourse.Fill(_dsStudent);
            _dsStudent.Tables[1].TableName = "StudCourse";

            SetGrid_StudCourse();
            displayStudentCourseRecord();

            adpStudCourseModule = DatabaseHelper.GetAdapter("StudCourseDetail");
            adpStudCourseModule.Fill(_dsStudent);
            _dsStudent.Tables[2].TableName = "StudCourseDetail";

            SetGrid_StudCourseModuleDetails();
            displayStudentCourseModuleRecord();

            adpFees = DatabaseHelper.GetAdapter("StudCourseFees");
            adpFees.Fill(_dsStudent);
            _dsStudent.Tables[3].TableName = "StudCourseFees";
            gridFees.DataSource = _dsStudent.Tables["StudCourseFees"];
            //gridFees.Columns["feesId"].Visible = false;
            //gridFees.Columns["centerId"].Visible = false;
            gridFees.Columns[2].HeaderText = "Discount";
            gridFees.Columns[3].HeaderText = "Payable Fees";
            gridFees.Columns[4].HeaderText = "No of Installments";
            gridFees.Columns[5].HeaderText = "FeesPerInstallments";

            adpFeesDetail = DatabaseHelper.GetAdapter("StudCourseFeesDetail");
            adpFeesDetail.Fill(_dsStudent);
            _dsStudent.Tables[4].TableName = "StudCourseFeesDetail";
            gridFeesDetail.DataSource = _dsStudent.Tables["StudCourseFeesDetail"];
            filterFeesDetail();
            #endregion


        }
        

        private void AdmissionDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        #endregion

        #region Student Addmission Details
        private void SetGrid_StudentMaster()
        {
            gridStudent.DataSource = _dsStudent.Tables["StudMaster"];

            gridStudent.Columns["StudId"].HeaderText = "Id";
            gridStudent.Columns["StudId"].Width = 30;
            gridStudent.Columns["StudId"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridStudent.Columns["StudId"].Visible = true;

            gridStudent.Columns["studName"].HeaderText = "Name";
            gridStudent.Columns["studName"].Width = 200;
            gridStudent.Columns["studName"].Visible = true;
            gridStudent.Columns["studName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            gridStudent.Columns["address"].HeaderText = "Address";
            gridStudent.Columns["address"].Width = 60;
            gridStudent.Columns["address"].Visible = false;

            gridStudent.Columns["city"].HeaderText = "City";
            gridStudent.Columns["city"].Width = 100;
            gridStudent.Columns["city"].Visible = true;

            gridStudent.Columns["contact"].HeaderText = "Contact";
            gridStudent.Columns["contact"].Width = 100;
            gridStudent.Columns["contact"].Visible = true;

            gridStudent.Columns["Whatsapp"].HeaderText = "Whatsapp";
            gridStudent.Columns["Whatsapp"].Width = 100;
            gridStudent.Columns["Whatsapp"].Visible = true;

            gridStudent.Columns["email"].HeaderText = "Email";
            gridStudent.Columns["email"].Width = 100;
            gridStudent.Columns["email"].Visible = true;

            gridStudent.Columns["referencedBy"].HeaderText = "Ref.by";
            gridStudent.Columns["referencedBy"].Width = 50;
            gridStudent.Columns["referencedBy"].Visible = false;

            gridStudent.Columns["empid"].HeaderText = "emp id";
            gridStudent.Columns["empid"].Width = 30;
            gridStudent.Columns["empid"].Visible = false;

            gridStudent.Columns["DOB"].HeaderText = "Birthdate";
            gridStudent.Columns["DOB"].Width = 80;
            gridStudent.Columns["DOB"].Visible = false;

            gridStudent.Columns["education"].HeaderText = "Education";
            gridStudent.Columns["education"].Width = 150;
            gridStudent.Columns["education"].Visible = true;

            gridStudent.Columns["gender"].HeaderText = "Gender";
            gridStudent.Columns["gender"].Width = 30;
            gridStudent.Columns["gender"].Visible = false;

            gridStudent.Columns["photo"].HeaderText = "Photo";
            gridStudent.Columns["photo"].Width = 30;
            gridStudent.Columns["photo"].Visible = false;

            gridStudent.Columns["JoiningDate"].HeaderText = "Joining Date";
            gridStudent.Columns["JoiningDate"].Width = 120;
            gridStudent.Columns["JoiningDate"].Visible = true;

        }
        private void displayField()
        {

            adpTableInfo = DatabaseHelper.GetadpForTableColumnName("StudMaster");
            _DataTable = new DataTable();
            dsSerch = new DataSet();

            adpTableInfo.Fill(_DataTable);
            dsSerch.Tables.Add(_DataTable);
            dsSerch.Tables[0].TableName = "Columns";
            dsSerch.Tables[0].Rows[0].Delete();

            cmbFieldName.DisplayMember = "FieldName";
            cmbFieldName.ValueMember = "FieldName";
            cmbFieldName.DataSource = dsSerch.Tables["Columns"];

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
            _dsStudent.Tables["StudMaster"].DefaultView.RowFilter = "";
            _dsStudent.Tables["StudMaster"].DefaultView.RowFilter = StrColName + " like '%" + txtFieldValue.Text + "%'";

            gridStudent.DataSource = _dsStudent.Tables["StudMaster"].DefaultView;
        }
        private void gridStudent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            displayStudentCourseRecord();
            displayStudentCourseModuleRecord();
        }
        private void gridStudent_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            ShowMessagePrompt("", "");
            if (e.RowIndex < gridStudent.RowCount - 1)
               _studId = int.Parse(gridStudent.Rows[e.RowIndex].Cells["studId"].Value.ToString());
            else
                _studId = int.Parse(gridStudent.Rows[0].Cells["studId"].Value.ToString());

            displayStudentCourseRecord();
            displayStudentCourseModuleRecord();
            filterStudCourseFees();
            filterFeesDetail();
        }
        #endregion

        #region Student Course Details
        private void SetGrid_StudCourse()
        {
            dgvStudCourse.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn CenterIdColumn = new DataGridViewTextBoxColumn();
            CenterIdColumn.Name = "centerId";
            CenterIdColumn.DataPropertyName = "centerId";
            CenterIdColumn.HeaderText = "centerId";
            CenterIdColumn.ReadOnly = true;
            dgvStudCourse.Columns.Add(CenterIdColumn);

            DataGridViewTextBoxColumn StudIdColumn = new DataGridViewTextBoxColumn();
            StudIdColumn.Name = "studId";
            StudIdColumn.DataPropertyName = "studId";
            StudIdColumn.HeaderText = "studId";
            StudIdColumn.ReadOnly = true;
            dgvStudCourse.Columns.Add(StudIdColumn);

            DataGridViewComboBoxColumn CourseColumn = new DataGridViewComboBoxColumn();
            CourseColumn.Name = "courseId";
            CourseColumn.DataPropertyName = "courseId";
            CourseColumn.HeaderText = "Course";
            CourseColumn.ReadOnly = false;
            CourseColumn.DataSource = dsCourse_Module.Tables["Course"];
            CourseColumn.DisplayMember = "courseName";
            CourseColumn.ValueMember = "courseId";
            dgvStudCourse.Columns.Add(CourseColumn);

            DataGridViewTextBoxColumn DOJColumn = new DataGridViewTextBoxColumn();
            DOJColumn.Name = "joiningDate";
            DOJColumn.DataPropertyName = "joiningDate";
            DOJColumn.HeaderText = "Joining Date";
            DOJColumn.ReadOnly = false;
            dgvStudCourse.Columns.Add(DOJColumn);


            dgvStudCourse.Columns["centerId"].DataPropertyName = "centerId";
            dgvStudCourse.Columns["studId"].DataPropertyName = "studId";
            dgvStudCourse.Columns["courseId"].DataPropertyName = "courseId";
            dgvStudCourse.Columns["courseId"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvStudCourse.Columns["joiningDate"].DataPropertyName = "joiningDate";

            
            dgvStudCourse.DataSource = _dsStudent.Tables["StudCourse"];
            //dgvStudCourse.Columns["CenterId"].Visible = false;
            //dgvStudCourse.Columns["StudId"].Visible = false;
            dgvStudCourse.Columns["courseId"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvStudCourse.Columns["joiningDate"].Width = 100;
        }
        private void displayStudentCourseRecord()
        {
            if ((gridStudent.SelectedRows.Count != 0) && (gridStudent.SelectedRows[0].Cells[0].Value != null) && (Convert.ToString(gridStudent.SelectedRows[0].Cells[0].Value) != ""))
            {
                //_studId = int.Parse(gridStudent.SelectedRows[0].Cells["studId"].Value.ToString());
                
                _dsStudent.Tables["StudCourse"].DefaultView.RowFilter = "";
                _dsStudent.Tables["StudCourse"].DefaultView.RowFilter = "studId=" + _studId;
                dgvStudCourse.DataSource = _dsStudent.Tables["StudCourse"].DefaultView;

            }

        }
        private void dgvStudCourse_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            if ((gridStudent.SelectedRows.Count != 0) && (gridStudent.SelectedRows[0].Cells[0].Value != null) && (Convert.ToString(gridStudent.SelectedRows[0].Cells[0].Value) != ""))
            {
                e.Row.Cells["StudId"].Value = int.Parse(gridStudent.SelectedRows[0].Cells["StudId"].Value.ToString());
                e.Row.Cells["joiningDate"].Value = gridStudent.SelectedRows[0].Cells["joiningDate"].Value.ToString();
            }
            
        }
        private void dgvStudCourse_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            ShowMessagePrompt("", "");
            if (_dsStudent.HasChanges())
            {
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adpStudCourse);
                adpStudCourse.UpdateCommand = cmdBuilder.GetUpdateCommand();
                adpStudCourse.InsertCommand = cmdBuilder.GetInsertCommand();
                adpStudCourse.Update(_dsStudent.Tables["StudCourse"]);

                _dsStudent.Tables["StudCourse"].Clear();
                adpStudCourse = DatabaseHelper.GetAdapter("StudCourse");
                adpStudCourse.Fill(_dsStudent.Tables["StudCourse"]);
            }
            else
                return;   
        }
        private void dgvStudCourse_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (_dsStudent.HasChanges())
            {
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adpStudCourse);
                adpStudCourse.DeleteCommand = cmdBuilder.GetDeleteCommand();
                adpStudCourse.Update(_dsStudent.Tables["StudCourse"]);
            }
            else
                return;
        }
        
        #endregion

        #region Student Course Module Details
        private void SetGrid_StudCourseModuleDetails()
        {
            dgvStudentCourseModuleDetail.DataSource = null;
            dgvStudentCourseModuleDetail.Columns.Clear();
            dgvStudentCourseModuleDetail.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn StudCourseIdColumn = new DataGridViewTextBoxColumn();
            StudCourseIdColumn.Name = "StudCourseId";
            StudCourseIdColumn.DataPropertyName = "StudCourseId";
            StudCourseIdColumn.HeaderText = "StudCourseId";
            StudCourseIdColumn.ReadOnly = true;
            dgvStudentCourseModuleDetail.Columns.Add(StudCourseIdColumn);

            DataGridViewTextBoxColumn CenterIdColumn = new DataGridViewTextBoxColumn();
            CenterIdColumn.Name = "centerId";
            CenterIdColumn.DataPropertyName = "centerId";
            CenterIdColumn.HeaderText = "centerId";
            CenterIdColumn.ReadOnly = true;
            dgvStudentCourseModuleDetail.Columns.Add(CenterIdColumn);

            DataGridViewComboBoxColumn ModuleIdColumn = new DataGridViewComboBoxColumn();
            ModuleIdColumn.Name = "ModuleId";
            ModuleIdColumn.DataPropertyName = "ModuleId";
            ModuleIdColumn.HeaderText = "Module";
            ModuleIdColumn.ReadOnly = false;


            //dsCourse_Module.Tables["CourseModule"].DefaultView.RowFilter = "";
            //dsCourse_Module.Tables["CourseModule"].DefaultView.RowFilter = "courseId=" + _CourseId;
            DataTable dt = new DataTable();
            dt = DatabaseHelper.GetDataTable("CourseModule");
            dt.DefaultView.RowFilter = "";
            dt.DefaultView.RowFilter = "courseId=" + _CourseId;
            //dsCourse_Module.Tables["CourseModule"].Clear();
            //adpModule = DatabaseHelper.GetAdapter("CourseModule","courseId="+_CourseId);
            //adpModule.Fill(dsCourse_Module.Tables["CourseModule"]);

            ModuleIdColumn.DisplayMember = "ModuleName";
            ModuleIdColumn.ValueMember = "ModuleId";
            ModuleIdColumn.DataSource = dt;
            //ModuleIdColumn.DataSource = dsCourse_Module.Tables["CourseModule"];

            
            dgvStudentCourseModuleDetail.Columns.Add(ModuleIdColumn);

            DataGridViewComboBoxColumn EmpIdColumn = new DataGridViewComboBoxColumn();
            EmpIdColumn.Name = "EmpId";
            EmpIdColumn.DataPropertyName = "EmpId";
            EmpIdColumn.HeaderText = "Faculty Name";
            EmpIdColumn.ReadOnly = false;
            EmpIdColumn.DataSource = dsCourse_Module.Tables["EmpMaster"];
            EmpIdColumn.DisplayMember = "EmpName";
            EmpIdColumn.ValueMember = "EmpId";
            dgvStudentCourseModuleDetail.Columns.Add(EmpIdColumn);

            DataGridViewComboBoxColumn batchTimeColumn = new DataGridViewComboBoxColumn();
            batchTimeColumn.Name = "batchTime";
            batchTimeColumn.DataPropertyName = "batchTime";
            batchTimeColumn.HeaderText = "Batch time";
            batchTimeColumn.ReadOnly = false;
            batchTimeColumn.DataSource = dsCourse_Module.Tables["batchTime"];
            batchTimeColumn.DisplayMember = "batchTime";
            batchTimeColumn.ValueMember = "batchTime";
            dgvStudentCourseModuleDetail.Columns.Add(batchTimeColumn);

            DataGridViewTextBoxColumn StartDateColumn = new DataGridViewTextBoxColumn();
            StartDateColumn.Name = "startDate";
            StartDateColumn.DataPropertyName = "startDate";
            StartDateColumn.HeaderText = "Start Date";
            StartDateColumn.ReadOnly = false;
            dgvStudentCourseModuleDetail.Columns.Add(StartDateColumn);

            DataGridViewTextBoxColumn EndDateColumn = new DataGridViewTextBoxColumn();
            EndDateColumn.Name = "endDate";
            EndDateColumn.DataPropertyName = "endDate";
            EndDateColumn.HeaderText = "End Date";
            EndDateColumn.ReadOnly = false;
            dgvStudentCourseModuleDetail.Columns.Add(EndDateColumn);

            DataGridViewComboBoxColumn statusColumn = new DataGridViewComboBoxColumn();
            statusColumn.Name = "status";
            statusColumn.DataPropertyName = "status";
            statusColumn.HeaderText = "Status";
            statusColumn.ReadOnly = false;
            statusColumn.DataSource = dsCourse_Module.Tables["status"];
            statusColumn.DisplayMember = "status";
            statusColumn.ValueMember = "status";
            dgvStudentCourseModuleDetail.Columns.Add(statusColumn);


            dgvStudentCourseModuleDetail.Columns["studCourseId"].DataPropertyName = "studCourseId";
            dgvStudentCourseModuleDetail.Columns["centerId"].DataPropertyName = "centerId";
            dgvStudentCourseModuleDetail.Columns["moduleId"].DataPropertyName = "moduleId";
            dgvStudentCourseModuleDetail.Columns["empId"].DataPropertyName = "empId";
            dgvStudentCourseModuleDetail.Columns["startDate"].DataPropertyName = "startDate";
            dgvStudentCourseModuleDetail.Columns["endDate"].DataPropertyName = "endDate";
            dgvStudentCourseModuleDetail.Columns["status"].DataPropertyName = "status";
            dgvStudentCourseModuleDetail.Columns["ModuleId"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvStudentCourseModuleDetail.Columns["empId"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            

            dgvStudentCourseModuleDetail.DataSource = _dsStudent.Tables["StudCourseDetail"];
            dgvStudentCourseModuleDetail.Columns["CenterId"].Visible = false;
            dgvStudentCourseModuleDetail.Columns["studCourseId"].Visible = false;
            dgvStudentCourseModuleDetail.Columns["startDate"].Width = 100;
            dgvStudentCourseModuleDetail.Columns["endDate"].Width = 100;
            dgvStudentCourseModuleDetail.Columns["batchTime"].Width = 100;
            dgvStudentCourseModuleDetail.Columns["status"].Width = 200;
        }
        private void displayStudentCourseModuleRecord()
        {
            if ((dgvStudCourse.SelectedRows.Count != 0) && (dgvStudCourse.SelectedRows[0].Cells[0].Value != null) && (Convert.ToString(dgvStudCourse.SelectedRows[0].Cells[0].Value) != ""))
            {
                //_CenterId = int.Parse(dgvStudCourse.SelectedRows[0].Cells["centerId"].Value.ToString());
                _dsStudent.Tables["StudCourseDetail"].DefaultView.RowFilter = "";
                _dsStudent.Tables["StudCourseDetail"].DefaultView.RowFilter = "centerId=" + _CenterId;
                dgvStudentCourseModuleDetail.DataSource = _dsStudent.Tables["StudCourseDetail"].DefaultView;
            }
        }
        

        private void dgvStudentCourseModuleDetail_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            if ((dgvStudCourse.SelectedRows.Count != 0) && (dgvStudCourse.SelectedRows[0].Cells["centerId"].Value != null) && (Convert.ToString(dgvStudCourse.SelectedRows[0].Cells["centerID"].Value) != ""))
            {
                e.Row.Cells["centerId"].Value = int.Parse(dgvStudCourse.SelectedRows[0].Cells["centerId"].Value.ToString());
            }
        }

        private void dgvStudentCourseModuleDetail_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            ShowMessagePrompt("", "");
            if (_dsStudent.HasChanges())
            {
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adpStudCourseModule);
                adpStudCourseModule.UpdateCommand = cmdBuilder.GetUpdateCommand();
                adpStudCourseModule.InsertCommand = cmdBuilder.GetInsertCommand();
                adpStudCourseModule.Update(_dsStudent.Tables["StudCourseDetail"]);

                _dsStudent.Tables["StudCourseDetail"].Clear();
                adpStudCourseModule = DatabaseHelper.GetAdapter("StudCourseDetail");
                adpStudCourseModule.Fill(_dsStudent.Tables["StudCourseDetail"]);
            }
            else
                return;   
        }

        private void dgvStudentCourseModuleDetail_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (_dsStudent.HasChanges())
            {
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adpStudCourseModule);
                adpStudCourseModule.DeleteCommand = cmdBuilder.GetDeleteCommand();
                adpStudCourseModule.Update(_dsStudent.Tables["StudCourseDetail"]);
            }
            else
                return;
        }

        #endregion

        private void dgvStudCourse_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            ShowMessagePrompt("", "");
            if (e.RowIndex < dgvStudCourse.RowCount - 1)
            {
                _CenterId = int.Parse(dgvStudCourse.Rows[e.RowIndex].Cells["centerId"].Value.ToString());
                _CourseId = int.Parse(dgvStudCourse.Rows[e.RowIndex].Cells["courseId"].Value.ToString());
            }
            else
            {
                _CenterId = int.Parse(dgvStudCourse.Rows[0].Cells["centerId"].Value.ToString());
                _CourseId = int.Parse(dgvStudCourse.Rows[0].Cells["courseId"].Value.ToString());
            }

            SetGrid_StudCourseModuleDetails();
            displayStudentCourseModuleRecord();

            txtCourseFees.Text = DatabaseHelper.GetCellValue("Course", "fees", "courseId=" + _CourseId);
            filterStudCourseFees();
            filterFeesDetail();
        }

        private void dgvStudCourse_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void dgvStudentCourseModuleDetail_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void gridFees_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            _CourseFees = decimal.Parse(txtCourseFees.Text);

            if (e.RowIndex >= 0 && e.RowIndex < gridFees.Rows.Count - 1)
            {
                if (gridFees.Columns[e.ColumnIndex].Name.ToString().ToUpper() == "DISCOUNT")
                {
                    if (gridFees.Rows[e.RowIndex].Cells["discount"].Value != null)
                    {
                        gridFees.Rows[e.RowIndex].Cells["Payablefees"].Value = Convert.ToDecimal(_CourseFees - ((_CourseFees * decimal.Parse(gridFees.Rows[e.RowIndex].Cells["discount"].Value.ToString())) / 100));
                    }
                }

                if (gridFees.Columns[e.ColumnIndex].Name.ToString().ToUpper() == "PAYABLEFEES")
                {
                    if (gridFees.Rows[e.RowIndex].Cells["payableFees"].Value != null)
                    {
                        gridFees.Rows[e.RowIndex].Cells["discount"].Value = Convert.ToDecimal(((_CourseFees - decimal.Parse(gridFees.Rows[e.RowIndex].Cells["payableFees"].Value.ToString())) * 100) / _CourseFees);
                    }
                }

                if (gridFees.Columns[e.ColumnIndex].Name.ToString().ToUpper() == "INSTALLMENTNO")
                {
                    if (gridFees.Rows[e.RowIndex].Cells["installmentNo"].Value != null)
                    {
                        gridFees.Rows[e.RowIndex].Cells["feesPerInstallment"].Value = Convert.ToDecimal(decimal.Parse(gridFees.Rows[e.RowIndex].Cells["payableFees"].Value.ToString()) / decimal.Parse(gridFees.Rows[e.RowIndex].Cells["installmentNo"].Value.ToString()));
                    }
                }

                if (gridFees.Columns[e.ColumnIndex].Name.ToString().ToUpper() == "FEESPERINSTALLMENT")
                {
                    if (gridFees.Rows[e.RowIndex].Cells["FEESPERINSTALLMENT"].Value != null)
                    {
                        gridFees.Rows[e.RowIndex].Cells["installmentNo"].Value = Convert.ToDecimal(decimal.Parse(gridFees.Rows[e.RowIndex].Cells["payableFees"].Value.ToString()) / decimal.Parse(gridFees.Rows[e.RowIndex].Cells["feesPerInstallment"].Value.ToString()));
                    }
                }

            }
        }

        private void dgvStudentCourseModuleDetail_DataSourceChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("DataSource Changhed");
        }

        private void gridFees_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            ShowMessagePrompt("", "");
            if (_dsStudent.HasChanges())
            {
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adpFees);
                adpFees.UpdateCommand = cmdBuilder.GetUpdateCommand();
                adpFees.InsertCommand = cmdBuilder.GetInsertCommand();
                adpFees.Update(_dsStudent.Tables["StudCourseFees"]);

                _dsStudent.Tables["StudCourseFees"].Clear();
                adpFees = DatabaseHelper.GetAdapter("StudCourseFees");
                adpFees.Fill(_dsStudent.Tables["StudCourseFees"]);
            }
            else
                return;   
        }


        private void filterStudCourseFees()
        {
            if ((dgvStudCourse.SelectedRows.Count != 0) && (dgvStudCourse.SelectedRows[0].Cells[0].Value != null) && (Convert.ToString(dgvStudCourse.SelectedRows[0].Cells[0].Value) != ""))
            {

                _dsStudent.Tables["StudCourseFees"].DefaultView.RowFilter = "";
                _dsStudent.Tables["StudCourseFees"].DefaultView.RowFilter = "centerId=" + _CenterId;
                gridFees.DataSource = _dsStudent.Tables["StudCourseFees"].DefaultView;
            }
        }

        private void filterFeesDetail()
        {
            if ((gridFees.SelectedRows.Count != 0) && (gridFees.SelectedRows[0].Cells[0].Value != null) && (Convert.ToString(gridFees.SelectedRows[0].Cells[0].Value) != ""))
            {
                //  ShowMessagePrompt(_FeesId.ToString(), "");

                _dsStudent.Tables["StudCourseFeesDetail"].DefaultView.RowFilter = "";
                _dsStudent.Tables["StudCourseFeesDetail"].DefaultView.RowFilter = "feesId=" + _FeesId;
                gridFeesDetail.DataSource = _dsStudent.Tables["StudCourseFeesDetail"].DefaultView;

            }
        }
        

        private void gridFees_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void gridFees_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            if ((dgvStudCourse.SelectedRows.Count != 0) && (dgvStudCourse.SelectedRows[0].Cells["centerId"].Value != null) && (Convert.ToString(dgvStudCourse.SelectedRows[0].Cells["centerID"].Value) != ""))
            {
                e.Row.Cells["centerId"].Value = int.Parse(dgvStudCourse.SelectedRows[0].Cells["centerId"].Value.ToString());
            }
        }

        private void gridFees_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            ShowMessagePrompt("", "");
            if (e.RowIndex < gridFees.RowCount - 1)
            {
               
                _FeesId = int.Parse(gridFees.Rows[e.RowIndex].Cells["feesId"].Value.ToString());
            }
            else
            {
             
                _FeesId = int.Parse(gridFees.Rows[0].Cells["feesId"].Value.ToString());
               
            }

            filterFeesDetail();
        }

        
    }
}
