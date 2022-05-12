using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TravelAdvisorProject.View
{
    public partial class AddTour : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            if (imageUpload.HasFile && videoUpload.HasFile)
            {
                try
                {
                    string imagePath = imageUpload.FileName;
                    string videoPath = videoUpload.FileName;
                    string tourNameTextBoxValue = tourName.Text;
                    float tourCost = float.Parse(cost.Text);
                    string countryName = country.SelectedItem.ToString();
                    string flightDateValue = flightDate.Text.ToString();
                    string endDateValue = endDate.Text.ToString();
                  //  string durationValue = duration.ToString();
                    imageUpload.PostedFile.SaveAs(Server.MapPath("~/Upload/" + imagePath));
                    videoUpload.PostedFile.SaveAs(Server.MapPath("~/Upload/" + videoPath));
                    string Image = "~/Upload/" + imagePath.ToString();
                    string Video = "~/Upload/" + videoPath.ToString();


                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Server = .; Database = TravelAdvisorDB;Integrated Security = true";
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("insert into Images(Image_Path,Video_Path) values (@Image,@Video)", con);
                    SqlCommand cmd2 = new SqlCommand("insert into Tour_Table(T_Name,T_Cost, T_Country_Name, T_Flight_Date, T_End_Date) values (@tripName,@tripCost,@tripCountryName,@tripFlightDate,@tripEndDate)", con);
                    cmd1.Parameters.AddWithValue("@Image", Image);
                    cmd1.Parameters.AddWithValue("@Video", Video);
                    cmd2.Parameters.AddWithValue("@tripName", tourNameTextBoxValue);
                    cmd2.Parameters.AddWithValue("@tripCost", tourCost);
                    cmd2.Parameters.AddWithValue("@tripCountryName", countryName);
                    cmd2.Parameters.AddWithValue("@tripFlightDate", flightDateValue);
                    cmd2.Parameters.AddWithValue("@tripEndDate", endDateValue);

                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();

                    con.Close();

                    Label1.Text = "Image Uploaded";
                    Label1.ForeColor = System.Drawing.Color.ForestGreen;
                }
                catch (Exception ex)
                {
                    Label1.Text = ex.ToString();
                }
            }
            else
            {
                Label1.Text = "Please Upload your Image";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}