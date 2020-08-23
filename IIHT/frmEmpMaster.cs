using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace IIHT
{
    public partial class frmEmpMaster : BaseForm
    {
        public frmEmpMaster()
        {
            InitializeComponent();
        }

        SqlDataAdapter adpEmpInfo;
        DataSet ds;

        private void frmEmpMaster_Load(object sender, EventArgs e)
        {
            displayEmployeeRecord();
        }

        private void displayEmployeeRecord()
        {
            adpEmpInfo = DatabaseHelper.GetAdapter("EmpMaster");
            ds = new DataSet();

            adpEmpInfo.Fill(ds);
            ds.Tables[0].TableName = "EmpMaster";
            dgvEmpMaster.DataSource = null;
            dgvEmpMaster.DataSource = ds.Tables["EmpMaster"];
            dgvEmpMaster.Columns["EmpId"].Visible = false;

        }
        private void dgvEmpMaster_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (!ds.HasChanges()) return;
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adpEmpInfo);
            adpEmpInfo.UpdateCommand = commandBuilder.GetUpdateCommand();
            adpEmpInfo.InsertCommand = commandBuilder.GetInsertCommand();
            adpEmpInfo.Update(ds.Tables["EmpMaster"]);
        }

        private void dgvEmpMaster_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (!ds.HasChanges()) return;
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adpEmpInfo);
            adpEmpInfo.DeleteCommand = commandBuilder.GetDeleteCommand();
            
        }

        private void frmEmpMaster_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
