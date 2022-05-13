using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TravelAdvisorProject.Controller;

namespace TravelAdvisorProject.View
{
    public partial class Login : System.Web.UI.Page
    {
        Login_controller loginController;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void singUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignUp.aspx");
            //or
            //Server.Transfer("YourPage.aspx");
        }

        protected void login_Click(object sender, EventArgs e)
        {
            string username = userName.Text;
            string pass = password.Text;
            string userID="";
            loginController = new Login_controller(username, pass);

            if (loginController.login(isAdmin.Checked,ref userID))
            {
                if (isAdmin.Checked)
                {
                    Response.Redirect("AdminHome.aspx?adminId=" + userID);
                }
                else
                Response.Redirect("UserHome.aspx?userId=" + userID);
            }
            else
                Response.Write("<script>alert('Please create an account first and then login')</script>");
        }
    }
}