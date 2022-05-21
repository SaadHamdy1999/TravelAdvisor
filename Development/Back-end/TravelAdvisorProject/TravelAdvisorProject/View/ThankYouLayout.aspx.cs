using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TravelAdvisorProject.View
{
    public partial class ThankYou : System.Web.UI.Page
    {

        String userID;
        protected void Page_Load(object sender, EventArgs e)
        {
            userID = Request.QueryString["userId"];
        
        }

        protected void Home_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserHome.aspx?userId=" + userID);
        }
    }
}