﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (System.Web.HttpContext.Current.User.Identity.IsAuthenticated)
        {
            lblUsername.Text = System.Web.HttpContext.Current.User.Identity.Name;
        }
    }
}