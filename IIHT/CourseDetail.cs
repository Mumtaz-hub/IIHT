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
    public partial class CourseDetail : IIHT.BaseForm
    {
        public CourseDetail()
        {
            InitializeComponent();
        }

        SqlDataAdapter _CategoryAdapter;
        SqlDataAdapter _CourseAdapter;
        SqlDataAdapter _ModuleAdapter;
        DataSet _DataSet=new DataSet();
        DataTable _DataTable;

        int _categoryId;
        int _courseId;

        private void CourseDetail_Load(object sender, EventArgs e)
        {
            _CategoryAdapter = DatabaseHelper.GetAdapter("CourseCategory");
            _DataTable = new DataTable();
            _CategoryAdapter.Fill(_DataTable);
            
            _DataSet.Tables.Add(_DataTable);
            _DataSet.Tables[0].TableName = "CourseCategory";
            gridCourseCategory.DataSource = _DataSet.Tables["CourseCategory"];
            gridCourseCategory.Columns["categoryId"].Visible = false;
            gridCourseCategory.Columns["categoryName"].HeaderText = "Name";

            _CourseAdapter = DatabaseHelper.GetAdapter("Course");
            _DataTable = new DataTable();
            _CourseAdapter.Fill(_DataTable);
            _DataSet.Tables.Add(_DataTable);
            _DataSet.Tables[1].TableName = "CourseDetail";
            gridCourseDetail.DataSource = _DataSet.Tables["CourseDetail"];
            gridCourseDetail.Columns["courseId"].Visible = false;
            gridCourseDetail.Columns["categoryId"].Visible = false;
            gridCourseDetail.Columns["courseName"].HeaderText = "Name";
            gridCourseDetail.Columns["duration"].HeaderText = "Duration";
            gridCourseDetail.Columns["fees"].HeaderText = "Fees";
            gridCourseDetail.Columns["courseName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            _ModuleAdapter = DatabaseHelper.GetAdapter("CourseModule");
            _DataTable = new DataTable();
            _ModuleAdapter.Fill(_DataTable);
            _DataSet.Tables.Add(_DataTable);
            _DataSet.Tables[2].TableName = "CourseModule";
            gridCourseModule.DataSource = _DataSet.Tables["CourseModule"];
            gridCourseModule.Columns["courseId"].Visible = false;
            gridCourseModule.Columns["moduleId"].Visible = false;
            gridCourseModule.Columns["moduleName"].HeaderText = "Name";
            gridCourseModule.Columns["moduleName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            displayCourseDetail();
            //displayModules();
        }

        private void gridCourseCategory_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (_DataSet.HasChanges())
            {
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(_CategoryAdapter);
                _CategoryAdapter.UpdateCommand = cmdBuilder.GetUpdateCommand();
                _CategoryAdapter.InsertCommand = cmdBuilder.GetInsertCommand();
                _CategoryAdapter.Update(_DataSet.Tables["CourseCategory"]);

                _DataSet.Tables["CourseCategory"].Clear();
                _CategoryAdapter = DatabaseHelper.GetAdapter("CourseCategory");
                _CategoryAdapter.Fill(_DataSet.Tables["CourseCategory"]);
                //gridCourseCategory.Rows[gridCourseCategory.RowCount - 1].Selected = true;
            }
            else
                return;
                //displayCourseDetail();
        }

        private void gridCourseCategory_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                if (_DataSet.HasChanges())
                {
                    int rows = gridCourseDetail.RowCount;
                    if (rows == 0)
                    {
                        SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(_CategoryAdapter);
                        _CategoryAdapter.DeleteCommand = cmdBuilder.GetDeleteCommand();
                        _CategoryAdapter.Update(_DataSet.Tables["CourseCategory"]);
                    }
                    else
                        return;
                }
                else
                    return;
            }
            catch (Exception )
            {
                ShowMessagePrompt("Couldnot delete Category: Course and/or module exists.", "");
                
            }

        }

        private void gridCourseCategory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            displayCourseDetail();
           
            //displayModules();
        }


        private void gridCourseDetail_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (_DataSet.HasChanges())
            {
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(_CourseAdapter);
                _CourseAdapter.UpdateCommand = cmdBuilder.GetUpdateCommand();
                _CourseAdapter.InsertCommand = cmdBuilder.GetInsertCommand();
                _CourseAdapter.Update(_DataSet.Tables["CourseDetail"]);

                _DataSet.Tables["CourseDetail"].Clear();
                _CourseAdapter = DatabaseHelper.GetAdapter("Course");
                _CourseAdapter.Fill(_DataSet.Tables["CourseDetail"]);
            }
            else
                return;
                //displayModules();
        }

        private void gridCourseDetail_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (_DataSet.HasChanges())
            {
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(_CourseAdapter);
                _CourseAdapter.DeleteCommand = cmdBuilder.GetDeleteCommand();
                _CourseAdapter.Update(_DataSet.Tables["CourseDetail"]);
            }
            else
                return;
        }

        private void gridCourseDetail_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            displayModules();
          
        }


        private void displayCourseDetail()
        {
            if ((gridCourseCategory.SelectedRows.Count != 0) && (gridCourseCategory.SelectedRows[0].Cells[0].Value!=null) && (Convert.ToString(gridCourseCategory.SelectedRows[0].Cells[0].Value)!=""))
            {
                _categoryId = int.Parse(gridCourseCategory.SelectedRows[0].Cells[0].Value.ToString());
                _DataSet.Tables["CourseDetail"].DefaultView.RowFilter = "";
                _DataSet.Tables["CourseDetail"].DefaultView.RowFilter = "categoryId=" + _categoryId;
                gridCourseDetail.DataSource = _DataSet.Tables["CourseDetail"].DefaultView;

                gridCourseDetail.Columns["fees"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                gridCourseDetail.Columns["fees"].DefaultCellStyle.Format = "#.00";

                displayModules();
            }
        }

        private void displayModules()
        {
            if ((gridCourseDetail.SelectedRows.Count != 0) && (gridCourseDetail.SelectedRows[0].Cells[0].Value != null) && (Convert.ToString(gridCourseDetail.SelectedRows[0].Cells[0].Value) != ""))
            {
                _courseId = int.Parse(gridCourseDetail.SelectedRows[0].Cells["courseId"].Value.ToString());
                _DataSet.Tables["CourseModule"].DefaultView.RowFilter = "";
                _DataSet.Tables["CourseModule"].DefaultView.RowFilter = "courseId=" + _courseId;
                gridCourseModule.DataSource = _DataSet.Tables["CourseModule"].DefaultView;
            }
            else
            {
                //To clear all rows form Modules, if there is no row in CourseDetail
                if (_DataSet.Tables.Contains("CourseModule"))
                {
                    _DataSet.Tables["CourseModule"].DefaultView.RowFilter = "courseId=0";
                    gridCourseModule.DataSource = _DataSet.Tables["CourseModule"].DefaultView;
                }
            }
        }


        private void gridCourseDetail_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {

            //gridCourseDetail.Rows[
            if ((gridCourseCategory.SelectedRows.Count != 0) && (gridCourseCategory.SelectedRows[0].Cells[0].Value != null) && (Convert.ToString(gridCourseCategory.SelectedRows[0].Cells[0].Value) != ""))
            {
                e.Row.Cells["categoryId"].Value = int.Parse(gridCourseCategory.SelectedRows[0].Cells["CategoryId"].Value.ToString());
            }
            
        }


        private void gridCourseModule_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            ShowMessagePrompt("", "");
            if (_DataSet.HasChanges())
            {
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(_ModuleAdapter);
                _ModuleAdapter.UpdateCommand = cmdBuilder.GetUpdateCommand();
                _ModuleAdapter.InsertCommand = cmdBuilder.GetInsertCommand();
                _ModuleAdapter.Update(_DataSet.Tables["CourseModule"]);

                _DataSet.Tables["CourseModule"].Clear();
                _ModuleAdapter = DatabaseHelper.GetAdapter("CourseModule");
                _ModuleAdapter.Fill(_DataSet.Tables["CourseModule"]);
            }
            else
                return;
        }

        private void gridCourseModule_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (_DataSet.HasChanges())
            {
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(_ModuleAdapter);
                _ModuleAdapter.DeleteCommand = cmdBuilder.GetDeleteCommand();
                _ModuleAdapter.Update(_DataSet.Tables["CourseModule"]);
            }
            else
                return;
        }

        private void gridCourseModule_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            if ((gridCourseDetail.SelectedRows.Count != 0) && (gridCourseDetail.SelectedRows[0].Cells[0].Value != null) && (Convert.ToString(gridCourseDetail.SelectedRows[0].Cells[0].Value) != ""))
            {
                e.Row.Cells["courseId"].Value = int.Parse(gridCourseDetail.SelectedRows[0].Cells["courseId"].Value.ToString());
            }
        }

        
        private void gridCourseDetail_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int rows = gridCourseModule.RowCount;
            if (rows > 1)
            {
                ShowMessagePrompt("Couldnot delete Course: Module exists.", "");
                e.Cancel = true;
            }
        }

        private void gridCourseDetail_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            { }
            catch (Exception )
            {
                ShowMessagePrompt("Couldnot delete Category: Course and/or module exists.", "");
                e.Cancel = true;
            }
        }


        private void gridCourseCategory_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int rows = gridCourseDetail.RowCount;
            if (rows > 1)
            {
                ShowMessagePrompt("Couldnot delete Category: Course and/or module exists.", "");
                e.Cancel = true;
            }
        }
        
        private void gridCourseCategory_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(gridCourseCategory.Rows[e.RowIndex].Cells[0].Value.ToString());
            //Set CategoryId
            ShowMessagePrompt("", "");
            if (e.RowIndex < gridCourseCategory.RowCount - 1)
                _categoryId = int.Parse(gridCourseCategory.Rows[e.RowIndex].Cells["categoryId"].Value.ToString());
            else
                _categoryId = int.Parse(gridCourseCategory.Rows[0].Cells["categoryId"].Value.ToString());

            displayCourseDetail();
        }

        private void gridCourseDetail_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            ShowMessagePrompt("", "");
            if (e.RowIndex < gridCourseDetail.RowCount - 1)
            {
                //MessageBox.Show(gridCourseDetail.Rows[e.RowIndex].Cells["courseId"].Value.ToString());
                _courseId = int.Parse(gridCourseDetail.Rows[e.RowIndex].Cells["courseId"].Value.ToString());
            }
            else if(gridCourseDetail.Rows[0].Cells["courseId"].Value!=null)
            {
                _courseId = int.Parse(gridCourseDetail.Rows[0].Cells["courseId"].Value.ToString());
            }
            displayModules();
        }
    }
}
