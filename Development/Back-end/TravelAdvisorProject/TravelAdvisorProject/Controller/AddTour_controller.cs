using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TravelAdvisorProject.Controller
{
    public class AddTour_controller
    {
        string imagePath;
        string secondImage;
        string tourNameTextBoxValue;
        float tourCost;
        string countryName;
        string flightDateValue;
        string endDateValue;
        private string Image;
        private string SecondImage;
        private string tripID;
        private SqlConnection con;
        public AddTour_controller(string imagePath, string secondImage, string tourNameTextBoxValue, float tourCost, string countryName, string flightDateValue, string endDateValue)
        {
            this.imagePath = imagePath;
            this.secondImage = secondImage;
            this.tourNameTextBoxValue = tourNameTextBoxValue;
            this.tourCost = tourCost;
            this.countryName = countryName;
            this.flightDateValue = flightDateValue;
            this.endDateValue = endDateValue;

        }
        public bool saveTour()
        {
             Image = "~/Upload/" + imagePath.ToString();
             SecondImage = "~/Upload/" + secondImage.ToString();
            try{
                //  string durationValue = duration.ToString();
               
                 con = new SqlConnection();
                con.ConnectionString = "workstation id=TravelAdvisorDB.mssql.somee.com;packet size=4096;user id=ossayed17_SQLLogin_1;pwd=trtnuvf8kw;data source=TravelAdvisorDB.mssql.somee.com;persist security info=False;initial catalog=TravelAdvisorDB";
                con.Open();

                addTour();


                setTourID();


                addImage();


               

                con.Close();
                return true;
                
            }
            catch (Exception ex)
            {
                Console.WriteLine( ex.ToString());
                return false;
            }
       
            
        }

        private void addTour()
        {
            SqlCommand cmd2 = new SqlCommand("insert into Tour_Table(T_Name,T_Cost, T_Country_Name, T_Flight_Date, T_End_Date) values (@tripName,@tripCost,@tripCountryName,@tripFlightDate,@tripEndDate)", con);
            cmd2.Parameters.AddWithValue("@tripName", tourNameTextBoxValue);
            cmd2.Parameters.AddWithValue("@tripCost", tourCost);
            cmd2.Parameters.AddWithValue("@tripCountryName", countryName);
            cmd2.Parameters.AddWithValue("@tripFlightDate", flightDateValue);
            cmd2.Parameters.AddWithValue("@tripEndDate", endDateValue);
            cmd2.ExecuteNonQuery();
        }

        private void setTourID()
        {
            SqlCommand cmd3 = new SqlCommand("select * from Tour_Table where T_Name = @tripName", con);
            cmd3.Parameters.AddWithValue("@tripName", tourNameTextBoxValue);
           // cmd3.Parameters.AddWithValue("@tripFlightDate", flightDateValue);
            SqlDataReader sdr = cmd3.ExecuteReader();
            while (sdr.Read())
            {
                tripID = sdr["T_ID"].ToString();
            }
            sdr.Close();
        }
        private void addImage()
        {
            SqlCommand cmd1 = new SqlCommand("insert into Images(Image_Path,T_ID,Second_Image_Path) values (@Image,@TripID,@SecondImg)", con);
            cmd1.Parameters.AddWithValue("@Image", Image);
            cmd1.Parameters.AddWithValue("@SecondImg", SecondImage);
            cmd1.Parameters.AddWithValue("@TripID", tripID);
            cmd1.ExecuteNonQuery();
        }
    }
}