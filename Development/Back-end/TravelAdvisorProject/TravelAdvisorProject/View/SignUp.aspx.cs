﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TravelAdvisorProject.Controller;

namespace TravelAdvisorProject.View
{
    public partial class SignUp : System.Web.UI.Page
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
            string userMobile = user_mobile.Text;
            string userAge = user_age.Text;
            int vlaue = String.Compare(userPassword, userConfirmPassword);
            if (String.Compare(userPassword, userConfirmPassword) !=0)
            {
                //Response.Write("<script>alert('') ; location.href='Login.aspx'</script>");
                //  ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('confirm password doesn't match to the password');", true);
                //Response.Write("<script>alert('confirm password doesn't match to the password') ;</script>");

                //Response.Write("<script>alert()</script>");
                checkPassword.Text= "confirm password doesn't match to the password";
                checkPassword.ForeColor = System.Drawing.Color.Red;



            }
            else
            {
                signUpController = new SignUp_controller(userName, userEmail, userPassword, userConfirmPassword, userMobile, userAge);
                signup(signUpController);
            }
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