using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserAgent : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        string useragent = Request.ServerVariables["HTTP_USER_AGENT"];

        if (useragent.Contains("iPad"))
        {
            Response.Redirect("mobilesite.aspx");
        }
        

    }
}