using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace IIHT
{
    public partial class AddViewUser : Form
    {
        string connString = "Data Source=ADMIN-PC\\SQLEXPRESS;Initial Catalog=IIHTDemo;Integrated Security=True";
        SqlConnection cn;
        //SqlCommand cmd;
        SqlDataAdapter da;
        String sql;
        DataSet ds;

        public AddViewUser()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //string connString = "Data Source=ADMIN.PC\\SQLExpress; Initial Catalog=IIHTDemo; Integrated Security=True";
            //SqlCommand cmd;
            //SqlDataAdapter da;
            //String sql;

            try
            {
                cn = new SqlConnection(connString);
                cn.Open();
                sql = "INSERT INTO UserMaster(userName,password) values('" + txtUserName.Text + "','" + txtPassword.Text + "')";
                da = new SqlDataAdapter(sql, cn);
                da.SelectCommand.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("User is added successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                cn = new SqlConnection(connString);
                cn.Open();
                sql = "SELECT * FROM UserMaster";
                da = new SqlDataAdapter(sql, cn);
                ds = new DataSet();
                da.Fill(ds);

                gridUser.DataSource = ds.Tables[0];
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtUserName.Text = "";
        }

        
    }
}
