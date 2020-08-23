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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

       
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string connString = "Data Source=ADMIN-PC\\SQLEXPRESS;Initial Catalog=IIHTDemo;Integrated Security=True";
                string sql = "SELECT * FROM UserMaster WHERE userName='" + txtName.Text + "' AND password='" + txtPassword.Text + "'";
                SqlConnection conn = new SqlConnection(connString);
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();

                da.Fill(ds);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    //mdimain obj = new mdimain();
                    //obj.Show();
                    //this.Hide();
                    //this.Close();
                    
                }
                else
                    MessageBox.Show("Invalid UserName or Password");

                conn.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
