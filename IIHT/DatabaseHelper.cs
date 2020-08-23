using System;
using System.Data;
using System.Data.SqlClient;

namespace IIHT
{
    public class DatabaseHelper
    {
        public static string connstring = "server=ADMIN-PC\\SQLEXPRESS;database=IIHTDemo;Integrated Security=true;";
        public static SqlConnection connection = new SqlConnection(connstring);
        public static SqlCommand command;
        static SqlDataAdapter adp;
        public static int _PkColValue;

        public static SqlDataAdapter GetadpForTableColumnName(string TableName)
        {
            connection = new SqlConnection(connstring);
            string query = "select c.name as FieldName  from sys.columns c inner join sys.tables t on t.object_id=c.object_id where t.name='" + TableName + "'";

            connection.Open();
            command = new SqlCommand(query, connection);
            adp = new SqlDataAdapter(command);
            connection.Close();
            return adp;
        }


        public static SqlDataAdapter GetAdapter(string TableName,string StrCriteria="")
        {
            //connection = new SqlConnection(connstring);
            string query = "Select *from "+ TableName;
            if (StrCriteria != "" && StrCriteria!=null)
            {
                query = query + " Where " + StrCriteria;
            }

            command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataAdapter adp = new SqlDataAdapter(command);
            connection.Close();
            return adp;
        }

        public static DataTable GetDataTable(string TableName)
        {
            //connection = new SqlConnection(connstring);
            string query = "Select * from " + TableName ;
            command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataAdapter adp = new SqlDataAdapter(command);
            connection.Close();

            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }

        public static DataTable GetQueryResultTable(string strquery)
        {
            DataTable dt = new DataTable();
            //connection = new SqlConnection(connstring);
            if (strquery != "")
            {
                command = new SqlCommand(strquery, connection);

                connection.Open();
                SqlDataAdapter adp = new SqlDataAdapter(command);
                connection.Close();
                adp.Fill(dt);
            }
            return dt;
        }

        public static SqlDataAdapter GetAdapter(string TableName, string field, int id)
        {
            //connection = new SqlConnection(connstring);
            string query = "Select * from " + TableName + " where " + field + "=" + id;
            command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataAdapter adp = new SqlDataAdapter(command);
            connection.Close();
            return adp;
        }

        public static string GetCellValue(string TableName, string field, string Criteria)
        {
            string query = "Select " + field + " from " + TableName + " where " + Criteria;
            command = new SqlCommand(query, connection);

            connection.Open();
            object obj = command.ExecuteScalar();
            connection.Close();

            return obj.ToString();
            
        }
    }
}
