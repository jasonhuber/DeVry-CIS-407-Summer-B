using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Upload : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void cmdUpload_Click1(object sender, EventArgs e)
    {
        string theFile = System.Web.HttpContext.Current.User.Identity.Name + txtFile.PostedFile.FileName;
        //Response.Write(theFile);
        string filepath = MapPath("uploadedfiles/") + theFile;
        //Response.Write(filepath);
        try
        {
            txtFile.PostedFile.SaveAs(filepath);
        }
        catch (Exception)
        {
            throw new Exception("File was not saved!");
        }

        string connectionstring = "Data Source=devrystudentsp10.db.6077598.hostedresource.com;Persist Security Info=True;User ID=DeVryStudentSP10;Password=OidLZqBv4";
        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
        conn.ConnectionString = connectionstring;
        conn.Open();
        //MessageBox.Show(conn.State.ToString());
        System.Data.SqlClient.SqlCommand comm = new System.Data.SqlClient.SqlCommand();
        comm.Connection = conn;

        comm.CommandText = "update Huber_Logon set photo = ";
        comm.CommandText += " @photo where userid = @userid";

        comm.Parameters.AddWithValue("@photo", theFile);
        comm.Parameters.AddWithValue("@userid", System.Web.HttpContext.Current.User.Identity.Name);

        comm.ExecuteNonQuery();

        conn.Close();
        conn.Dispose();
    }
}