using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TravelAdvisorProject.View
{
    public partial class TourBooking : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string tripID = Request.QueryString["val"];
            string imagePath="";
            string secondImgPath="";
            string tour_name="";
            string country_name="";
            string flight_date="";
            string end_date="";
            string cost_s="";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server = .; Database = TravelAdvisorDB;Integrated Security = true";
            con.Open();
                SqlCommand cmd = new SqlCommand("select * from Images where T_ID =@tripID", con);
                SqlCommand cmd2 = new SqlCommand("select * from Tour_Table where T_ID =@tripID", con);
            cmd.Parameters.AddWithValue("@tripID", tripID);
            cmd2.Parameters.AddWithValue("@tripID", tripID);

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

        }
    }
}