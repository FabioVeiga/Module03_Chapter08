﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RentMyWrox
{
    public partial class WeeklySpecial : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int specialItemId = 24;
            //Response.Redirect("Items/Details" + specialItemId);
            //Server.Transfer("Items/Details/" + specialItemId);
            //Server.Transfer("/Admin/UserList.aspx");
            //Server.TransferRequest("Items/Details/" + specialItemId);
        }
    }
}