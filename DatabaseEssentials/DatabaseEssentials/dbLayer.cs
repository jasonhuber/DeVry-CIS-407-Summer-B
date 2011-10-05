using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseEssentials
{
    static class dbLayer
    {
        //private string _connectionstring;

       /* public static string connectionstring { 
            get
            {
                return _connectionstring;
            } 
            
            set
            {
                _connectionstring = value;
            } }*/

        public static bool executesomesqlplease(string sql)
        {
            return true;
        }
        public static bool isuseralreadyinthedbornot(string userid, string connectionstring)
        {
            
            System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
            conn.ConnectionString = connectionstring;
            conn.Open();
            //MessageBox.Show(conn.State.ToString());
            System.Data.SqlClient.SqlCommand comm = new System.Data.SqlClient.SqlCommand();
            comm.Connection = conn;
            comm.CommandText = "select userid from Huber_logon where userid = @userid ";
            comm.Parameters.AddWithValue("@userid", userid);

            var resp = comm.ExecuteScalar();

            conn.Close();
            conn.Dispose();

            if (resp != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
