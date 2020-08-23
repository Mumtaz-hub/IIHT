using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace IIHT
{
    public partial class frmCourse : Form
    {
        string connString="DATA SOURCE=ADMIN-PC; Initial Catalog=IIHTDemo; Integrated Security=True";
        string sql;
        SqlConnection cn;
        SqlDataAdapter da;
        DataSet ds;
        //DataTable dt;
        int scrollVal = 0;
        SqlCommand cmd;
        //SqlCommandBuilder bcmd;

       

        public frmCourse()
        {
            InitializeComponent();
        }

          
        private void Course_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void frmCourse_Load(object sender, EventArgs e)
        {
            try
            {
                sql = "SELECT * FROM CourseCategory";
                 cn = new SqlConnection(connString);
                 da = new SqlDataAdapter(sql, cn);
                 ds = new DataSet();
                 cmd = new SqlCommand();
                cn.Open();

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = sql;
                cmd.Connection = cn;

                da = new SqlDataAdapter(cmd.CommandText, cn);
                da.InsertCommand = cmd;
                
                da.Fill(ds, "CourseCategory");

                sql = "SELECT * FROM Course";
                cn = new SqlConnection(connString);
                da = new SqlDataAdapter(sql, cn);
                ds = new DataSet();
                cmd = new SqlCommand();
                cn.Open();

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = sql;
                cmd.Connection = cn;

                da = new SqlDataAdapter(cmd.CommandText, cn);
                da.InsertCommand = cmd;

                da.Fill(ds, "Course");

                //dt = ds.Tables["Course"];

                
                cn.Close();

                cmbCourseCategory.DisplayMember = "CategoryName";
                cmbCourseCategory.ValueMember = "CategoryId";
                cmbCourseCategory.DataSource = ds.Tables[0];
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnViewCourses_Click(object sender, EventArgs e)
        {
            try
            {
                ds.Tables["Course"].DefaultView.RowFilter = "";
                //ds.DefaultViewManager
                /*DataGridViewRow row = this.gridCourse.RowTemplate;
                //row.DefaultCellStyle.BackColor = Color.Bisque;
                row.Height = 35;
                row.MinimumHeight = 20;
                */
                

                //cn.Close();

                //sprCourse.DataSource = ds.Tables[0];

                gridCourse.DataSource=ds.Tables["Course"];
                gridCourse.Columns[0].HeaderText = "Course Name";
                gridCourse.Columns[1].HeaderText = "Duration";
                gridCourse.Columns[2].HeaderText = "Fees";

                //gridCourse.RowsDefaultCellStyle.BackColor = Color.Bisque;
                //gridCourse.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
                //gridCourse.CellBorderStyle = DataGridViewCellBorderStyle.None;

                //gridCourse.DefaultCellStyle.SelectionBackColor = Color.Red;
                //gridCourse.DefaultCellStyle.SelectionForeColor = Color.Yellow;

                //gridCourse.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                //gridCourse.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

         //       gridCourse.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                //gridCourse.ReadOnly = true;
                //btnSave.Enabled = false;
                

                //gridCourse.Rows[0].ReadOnly = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
            }

        }

        private void cmbCourseCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

            //if((


            try
            {
                if (cmbCourseCategory.SelectedValue != null)
                {
                    //sql = "SELECT courseName FROM Course where categoryId=" + cmbCourseCategory.SelectedItem;
                    sql = "SELECT courseName as Course_Name FROM Course where categoryid=" + int.Parse(cmbCourseCategory.SelectedValue.ToString());
                    cn = new SqlConnection(connString);
                    da = new SqlDataAdapter(sql, cn);
                    ds = new DataSet();

                    cn.Open();
                    da.Fill(ds, scrollVal, 3, "Course");
                    cn.Close();

                    gridCourse.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            //MessageBox.Show(cmbCourseCategory.SelectedValue.ToString());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //sorting
            //gridCourse.Sort(gridCourse.Columns[1], ListSortDirection.Ascending);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            /*scrollVal -= 3;
            if (scrollVal <= 0)
                scrollVal = 0;
            ds.Clear();
            da.Fill(ds, scrollVal, 3, "Course");*/
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            /*scrollVal += 3;
            if (scrollVal > 5)
                scrollVal = 3;
            ds.Clear();
            da.Fill(ds, scrollVal, 3, "Course");*/
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;

            object misValue = System.Reflection.Missing.Value;

            Int16 i, j;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            for (i = 0; i <= gridCourse.RowCount - 2; i++)
            {
                for (j = 0; j <= gridCourse.ColumnCount - 1; j++)
                {
                    xlWorkSheet.Cells[i + 1, j + 1] = gridCourse[j, i].Value.ToString();
                }
            }

            xlWorkBook.SaveAs(@"d:\SONAL\course.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);

            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            //gridCourse.ReadOnly = false;
            //btnSave.Enabled = true;
            //btnAddNew.Enabled = false;
            //btnDelete.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            /*if (MessageBox.Show("Do you want to delete this row?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
               // gridCourse.Rows.RemoveAt(gridCourse.SelectedRows[0].Index);
                //gridCourse
                //SqlCommandBuilder builder= new SqlCommandBuilder(da);
                //da.UpdateCommand = builder.GetUpdateCommand();
                this.Validate();
                this.ds.EndInit();

                da.Update(ds.Tables["Course"]);
            }*/
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //ds.Tables["Course"].Rows.Add(gridCourse.Rows[gridCourse.RowCount - 1]);
            //int last = gridCourse.RowCount - 1;

            this.Validate();
            this.ds.EndInit();
            //da.Update(dt);
            da.Update(ds.Tables["Course"]);

            //try
            //{
            //    sql = "INSERT INTO Course VALUES('" + gridCourse.Rows[last].Cells[0] + "'," + gridCourse.Rows[last].Cells[1] + "," + gridCourse.Rows[last].Cells[2] + ")"; 
            //    cn = new SqlConnection(connString);
            //    da = new SqlDataAdapter(sql, cn);

            //    cn.Open();
            //    da.SelectCommand.ExecuteNonQuery();
               
            //    cn.Close();

            //    gridCourse.DataSource = ds.Tables[0];
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}

            //gridCourse.ReadOnly = true;
            //btnSave.Enabled = false;
            btnAddNew.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void cmbCourseCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            /*try
            {
                if (cmbCourseCategory.SelectedValue!=null)
                {
                    //sql = "SELECT courseName FROM Course where categoryId=" + cmbCourseCategory.SelectedItem;
                    sql = "SELECT courseName as Course_Name FROM Course where categoryid=" + int.Parse(cmbCourseCategory.SelectedValue.ToString());
                    cn = new SqlConnection(connString);
                    da = new SqlDataAdapter(sql, cn);
                    ds = new DataSet();

                    cn.Open();
                    da.Fill(ds, scrollVal, 3, "Course");
                    cn.Close();

                    gridCourse.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }*/
        }
    }
}
