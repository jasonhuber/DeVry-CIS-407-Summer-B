using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
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
            comm.Parameters.AddWithValue("@lastname", txtlname.Text);
            comm.Parameters.AddWithValue("@firstname", txtfname.Text);
            comm.Parameters.AddWithValue("@password", txtpassword.Text);
            comm.Parameters.AddWithValue("@userid", txtuserid.Text);
            if (!dbLayer.stuff.isuseralreadyinthedbornot(txtuserid.Text, connectionstring))
            {
                comm.ExecuteNonQuery();
            }
            else
            {
                Response.Write("You Must enter another userid, that one is in use!");
            }

            conn.Close();
            conn.Dispose();
        }
    }
}