using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace TravelAdvisorProject.Controller
{
    public class AddAdmin_controller
    {

        string adminName, adminEmail, adminPassword, adminConfirmPassword;

        public AddAdmin_controller(string adminName, string adminEmail, string adminPassword, string adminConfirmPassword)
        {
            this.adminName = adminName;
            this.adminEmail = adminEmail;
            this.adminPassword = adminPassword;
            this.adminConfirmPassword = adminConfirmPassword;
        }
        public bool add_Admin()
        {
            //try{
                SqlConnection Scon = new SqlConnection();
                Scon.ConnectionString = "Data Source=.;Initial Catalog=TravelAdvisorDB;Integrated Security=True";
                SqlCommand Scmd = new SqlCommand();
                Scmd.Connection = Scon;
                Scon.Open();

                Scmd.CommandText = "INSERT INTO Admin_Table (A_Username, A_Email, A_Password) VALUES (@adminName, @adminEmail, @adminPassword)";
                Scmd.Parameters.AddWithValue("@adminName", adminName);
                Scmd.Parameters.AddWithValue("@adminEmail", adminEmail);
                Scmd.Parameters.AddWithValue("@adminPassword", adminPassword);
                Scmd.ExecuteNonQuery();
                return true;


         //   }
          /*  catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }*/
            //return false;
        }
    }
}
