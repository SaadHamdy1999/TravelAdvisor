using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TravelAdvisorProject.Controller;

namespace TravelAdvisorProject.View
{
    public partial class AddUser : System.Web.UI.Page
    {
        AddUser_controller addUserController;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void addU_Click(object sender, EventArgs e)
        {
            string userName = username.Text;
            string userEmail = email.Text;
            string userPassword = password.Text;
            string userConfirmPassword = cpassword.Text;
            string userMobile = phone.Text;
            string userAge = age.Text;


            addUserController = new AddUser_controller(userName, userEmail, userPassword, userConfirmPassword, userMobile, userAge);
            adduser(addUserController);
        }

        private void adduser(AddUser_controller addUserC)
        {
            if (addUserC.add_User())
            {
                Response.Write("<script>alert('User added successfully')</script>");
            }
            else
                Response.Write("<script>alert('Adding user didn't complete invalid data')</script>");
        }
    }
}
