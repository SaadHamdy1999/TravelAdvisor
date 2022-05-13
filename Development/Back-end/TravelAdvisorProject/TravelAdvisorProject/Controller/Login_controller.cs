using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TravelAdvisorProject.Controller
{
    public class Login_controller
    {
        string username;
        string pass;

        public Login_controller(string username, string pass){
            this.username= username;
            this.pass = pass;
        }

        public bool login(bool isAdmin, ref string userID){

            try
            {
                SqlConnection con = new SqlConnection();

                con.ConnectionString = "Server = .; Database = TravelAdvisorDB;Integrated Security = true";
                con.Open();
                SqlCommand Scmd = new SqlCommand();
                Scmd.Connection = con;
                string qry;

                if (isAdmin)
                    qry = "select * from Admin_Table where A_Username='" + username + "' and A_Password='" + pass + "'";
                else
                    qry = "select * from User_Table where U_Name='" + username + "' and U_Password='" + pass + "'";


                SqlCommand cmd = new SqlCommand(qry, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    while (sdr.Read())
                    {
                       userID= sdr["U_ID"].ToString();
                    }
                    sdr.Close();
                    con.Close();
                    return true;
                }
                else
                {
                    con.Close();
                    return false;
                }
               
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }

            return false;
            
            }

    }
}