using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TravelAdvisorProject.Controller
{
    public class SignUp_controller
    {
        string userName, userEmail, userPassword, userConfirmPassword, userMobile, userAge;
      public SignUp_controller(string userName, string userEmail, string userPassword, string userConfirmPassword, string userMobile, string userAge)
        {
            this.userName = userName;
            this.userEmail = userEmail;
            this.userPassword = userPassword;
            this.userConfirmPassword = userConfirmPassword;
            this.userMobile = userMobile;
            this.userAge = userAge;
        }

        public bool saveUser()
        {
            try
            {
                SqlConnection Scon = new SqlConnection();
                Scon.ConnectionString = "Data Source=LAPTOP-I64F104J\\ITI_SQL;Initial Catalog=TravelAdvisorDB;Integrated Security=True";
                Scon.Open();
                SqlCommand Scmd = new SqlCommand();
                Scmd.Connection = Scon;
                if (userPassword == userConfirmPassword)
                {
                    Scmd.CommandText = "INSERT INTO User_Table ([U_Name],[U_Email],[U_Password],[U_MobileNo],[U_Age]) VALUES (@userName,@userEmail,@userPassword,@userMobile,@UserAge)";
                    Scmd.Parameters.AddWithValue("@userName", userName);
                    Scmd.Parameters.AddWithValue("@userEmail", userEmail);
                    Scmd.Parameters.AddWithValue("@userPassword", userPassword);
                    Scmd.Parameters.AddWithValue("@userMobile", userMobile);
                    Scmd.Parameters.AddWithValue("@UserAge", userAge);
                    Scmd.ExecuteNonQuery();
                    return true;
                }

                
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