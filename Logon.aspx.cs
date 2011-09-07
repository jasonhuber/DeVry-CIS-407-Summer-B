using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class Logon : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void cmdLogon_Click(object sender, EventArgs e)
    {
        if (System.Web.Security.FormsAuthentication.Authenticate(txtUsername.Text, txtPassword.Text))
         {
             System.Web.Security.FormsAuthentication.RedirectFromLoginPage(txtUsername.Text, false);
         }
        
    }
}