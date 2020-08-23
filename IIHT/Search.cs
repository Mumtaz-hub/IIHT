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
    public partial class Search : BaseForm
    {
        string _TableName;
        string _PKColName;
        string _StrCriteria;
        

        public Search(string StrTableName, string StrPKColName = "",string StrCriteria="")
        {
            InitializeComponent();
            _TableName = StrTableName;
            _PKColName = StrPKColName;
            _StrCriteria = StrCriteria;
        }

        
        DataSet dsSerch;
        DataTable dt;
        SqlDataAdapter adpTableInfo;
        string StrColName;

        private void displayRecord()
        {

            dsSerch = new DataSet();
            adpTableInfo = DatabaseHelper.GetAdapter(_TableName,_StrCriteria);
            dt = new DataTable(); 

            adpTableInfo.Fill(dt);
            dsSerch.Tables.Add(dt);

            dsSerch.Tables[0].TableName = _TableName;
            gridSearch.DataSource = null;
            gridSearch.DataSource = dsSerch.Tables[_TableName];
            gridSearch.Columns[_PKColName].Visible = false;

        }

        private void displayField()
        {
            
            adpTableInfo = DatabaseHelper.GetadpForTableColumnName(_TableName);
            dt = new DataTable();

            adpTableInfo.Fill(dt);
            dsSerch.Tables.Add(dt);
            dsSerch.Tables[1].TableName = "Columns";
            dsSerch.Tables[1].Rows[0].Delete();

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
            dsSerch.Tables[_TableName].DefaultView.RowFilter = "";
            dsSerch.Tables[_TableName].DefaultView.RowFilter = StrColName + " like '%" + txtFieldValue.Text + "%'";

            gridSearch.DataSource = dsSerch.Tables[_TableName].DefaultView;
        }

        private void Search_Load(object sender, EventArgs e)
        {
            displayRecord();
            displayField();

        }

        private void Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void gridSearch_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < gridSearch.RowCount - 1)
            {
                
                DatabaseHelper._PkColValue = int.Parse(gridSearch.Rows[e.RowIndex].Cells[_PKColName].Value.ToString());
               

            }
        }

        private void gridSearch_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

      
    }
}
