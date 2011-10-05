using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace DatabaseEssentials
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=devrystudentsp10.db.6077598.hostedresource.com;Persist Security Info=True;User ID=DeVryStudentSP10;Password=OidLZqBv4";
            System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
            conn.ConnectionString = connectionstring;
            conn.Open();
            //MessageBox.Show(conn.State.ToString());
            System.Data.SqlClient.SqlCommand comm = new System.Data.SqlClient.SqlCommand();
            comm.Connection = conn;
            comm.CommandText = "insert into Huber_Logon (email, lastname, firstname, password, userid)"; 
            comm.CommandText += " values (@email, @lastname, @firstname, @password, @userid)";

            comm.Parameters.AddWithValue("@email", txtemail.Text);
            comm.Parameters.AddWithValue("@lastname", txtLname.Text);
            comm.Parameters.AddWithValue("@firstname", txtfname.Text);
            comm.Parameters.AddWithValue("@password", txtpassword.Text);
            comm.Parameters.AddWithValue("@userid", txtuserid.Text);
            if (!dbLayer.isuseralreadyinthedbornot(txtuserid.Text, connectionstring))
            {   
                comm.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("You Must enter another userid, that one is in use!");
            }
            
            conn.Close();
            conn.Dispose();

        }
        
    }
}
