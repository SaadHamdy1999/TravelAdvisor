using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TravelAdvisorProject.Controller;

namespace TravelAdvisorProject.Model
{
    public partial class Login : System.Web.UI.Page
    {
        SignUp_controller signUpController;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void signUp_Click(object sender, EventArgs e)
        {
           string userName = user_name.Text;
           string userEmail = user_email.Text;
            string userPassword = user_password.Text;
            string userConfirmPassword = user_confirm_password.Text;
            string userMobile =user_mobile.Text; 
            string userAge = user_age.Text;

            signUpController = new SignUp_controller(userName, userEmail, userPassword, userConfirmPassword, userMobile, userAge);
            signup(signUpController);
        }

        private void signup(SignUp_controller signUpc)
        {
            if (signUpc.saveUser())
                Response.Redirect("Login.aspx");
            else
                Response.Write("<script>alert('Sign up didn't complete invalid data')</script>");
        }
    }
}