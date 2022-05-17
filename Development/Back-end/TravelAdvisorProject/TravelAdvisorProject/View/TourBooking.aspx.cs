using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace TravelAdvisorProject.View
{
    public partial class TourBooking : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        string tripID;
        string userID ;
        string userEmail;

        protected void Page_Load(object sender, EventArgs e)
        {
            tripID = Request.QueryString["val"];
            userID = Request.QueryString["userId"];
            string imagePath ="";
            string secondImgPath="";
            string tour_name="";
            string country_name="";
            string flight_date="";
            string end_date="";
            string cost_s="";
            
            con.ConnectionString = "Data Source=.;Initial Catalog=TravelAdvisorDB;Integrated Security=True";
            con.Open();
                SqlCommand cmd = new SqlCommand("select * from Images where T_ID =@tripID", con);
                SqlCommand cmd2 = new SqlCommand("select * from Tour_Table where T_ID =@tripID", con);
            //    SqlCommand cmd3 = new SqlCommand("select * from User_Table where U_ID =@userID", con);
            cmd.Parameters.AddWithValue("@tripID", tripID);
            cmd2.Parameters.AddWithValue("@tripID", tripID);
           // cmd3.Parameters.AddWithValue("@userID", userID);
            SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                imagePath = sdr["Image_Path"].ToString();
                secondImgPath = sdr["Second_Image_Path"].ToString();
                }
            sdr.Close();

            sdr = cmd2.ExecuteReader();
            while (sdr.Read())
            {
               tour_name  = sdr["T_Name"].ToString();
               country_name = sdr["T_Country_Name"].ToString();
               flight_date  = sdr["T_Flight_Date"].ToString();
               end_date  = sdr["T_End_Date"].ToString();
               cost_s = sdr["T_Cost"].ToString();
            }
            sdr.Close();

         /*   sdr = cmd3.ExecuteReader();
            while (sdr.Read())
            {
                userEmail = sdr["U_Email"].ToString();
            }
            sdr.Close();
            */
            tourName.Text= tour_name;
            countryName.Text = country_name;
            flightDate.Text = flight_date;
            endDate.Text = end_date;
            cost.Text = cost_s;
            int startDay, startMonth, startYear, endDay, endMonth, endYear;
            startDay = int.Parse(flight_date.Substring(flight_date.Length - 2));
            startYear = int.Parse(flight_date.Substring(0,4));
            startMonth = int.Parse(flight_date.Substring(5, 2));
            endDay = int.Parse(end_date.Substring(end_date.Length - 2));
            endYear = int.Parse(end_date.Substring(0, 4));
            endMonth = int.Parse(flight_date.Substring(5, 2));
            //  float duration = float.Parse(end_date.Substring(end_date.Length - 2)) - float.Parse(flight_date.Substring(flight_date.Length - 2));

            DateTime startflightDate = new DateTime(startYear, startMonth, startDay);
            DateTime endflightDate = new DateTime(endYear, endMonth, endDay);

            TimeSpan duration = endflightDate.Subtract(startflightDate);
            Duration.Text = duration.ToString("%d") + " days";

            Image1.ImageUrl = imagePath;
            Image2.ImageUrl = secondImgPath;

        }

        protected void book_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update User_Table set T_ID =@tripID where U_ID=@userID", con);
            cmd.Parameters.AddWithValue("@tripID", tripID);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.ExecuteNonQuery();
            con.Close();

            /*string to = userEmail; //To address    
            string from = "TravelAdvisor123456"; //From address    
            MailMessage message = new MailMessage(from, to);
            string mailbody = "Booking successfully, Thank you for booking from our website, we hope a comfortable tour for you.";
            message.Subject = "TravelAdvisor Booking Mail";
            message.Body = mailbody;
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp    
            System.Net.NetworkCredential basicCredential1 = new
            System.Net.NetworkCredential("TravelAdvisor123456", "Tv123456");
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = basicCredential1;
            try
            {
                client.Send(message);
            }

            catch (Exception ex)
            {
                throw ex;
            }*/
            Response.Redirect("ThankYouLayout.aspx?userID=" + userID);
        }
    }
}