using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TravelAdvisorProject.Controller;

namespace TravelAdvisorProject.View
{
    public partial class AddAdmin : System.Web.UI.Page
    {
        AddAdmin_controller addAdminController;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addA_Click(object sender, EventArgs e)
        {
            string adminName = admin_name.Text;
            string adminEmail = admin_email.Text;
            string adminPassword = admin_password.Text;
            string adminConfirmPassword = admin_cpassword.Text;


            addAdminController = new AddAdmin_controller(adminName, adminEmail, adminPassword, adminConfirmPassword);
            addadmin(addAdminController);
        }
        private void addadmin(AddAdmin_controller addAdminC)
        {
            if (addAdminC.add_Admin())
            {
                Response.Write("<script>alert('Admin added successfully')</script>");
            }
            else
                Response.Write("<script>alert('Adding admin didn't complete invalid data')</script>");
        }
    }
}