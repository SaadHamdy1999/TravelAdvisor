using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
namespace TravelAdvisorProject.Controller
{
    public class AddUser_controller
    {
        string userName, userEmail, userPassword, userConfirmPassword, userMobile, userAge;
        public AddUser_controller(string userName, string userEmail, string userPassword, string userConfirmPassword,string userMobile, string userAge)
        {
            this.userName = userName;
            this.userEmail = userEmail;
            this.userPassword = userPassword;
            this.userConfirmPassword = userConfirmPassword;
            this.userMobile = userMobile;
            this.userAge = userAge;
        }

        public bool add_User()
        {
            try
            {
                SqlConnection Scon = new SqlConnection();
                Scon.ConnectionString = "Data Source=.;Initial Catalog=TravelAdvisorDB;Integrated Security=True";
                SqlCommand Scmd = new SqlCommand();
                Scmd.Connection = Scon;
                Scon.Open();

                Scmd.CommandText = "INSERT INTO User_Table ([U_Name],[U_Email],[U_Password],[U_MobileNo],[U_Age]) VALUES (@userName,@userEmail,@userPassword,@userMobile,@UserAge)";
                Scmd.Parameters.AddWithValue("@userName", userName);
                Scmd.Parameters.AddWithValue("@userEmail", userEmail);
                Scmd.Parameters.AddWithValue("@userPassword", userPassword);
                Scmd.Parameters.AddWithValue("@userMobile", userMobile);
                Scmd.Parameters.AddWithValue("@UserAge", userAge);
                Scmd.ExecuteNonQuery();
                return true;


            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            return false;
        }
    }
}