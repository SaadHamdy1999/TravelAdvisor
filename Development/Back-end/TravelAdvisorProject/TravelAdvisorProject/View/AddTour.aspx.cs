using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TravelAdvisorProject.Controller;

namespace TravelAdvisorProject.View
{
    public partial class AddTour : System.Web.UI.Page
    {
        AddTour_controller addTourController;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            string imagePath = imageUpload.FileName;
            string secondImage = secondImgUpload.FileName;
            string tourNameTextBoxValue = tourName.Text;
            float tourCost = float.Parse(cost.Text);
            string countryName = country.SelectedItem.ToString();
            string flightDateValue = flightDate.Text.ToString();
            string endDateValue = endDate.Text.ToString();

            if (imageUpload.HasFile && secondImgUpload.HasFile)
            {
                int startDay, startMonth, startYear, endDay, endMonth, endYear;
                startDay = int.Parse(flightDateValue.Substring(flightDateValue.Length - 2));
                startYear = int.Parse(flightDateValue.Substring(0, 4));
                startMonth = int.Parse(flightDateValue.Substring(5, 2));
                endDay = int.Parse(endDateValue.Substring(endDateValue.Length - 2));
                endYear = int.Parse(endDateValue.Substring(0, 4));
                endMonth = int.Parse(endDateValue.Substring(5, 2));
                //  float duration = float.Parse(end_date.Substring(end_date.Length - 2)) - float.Parse(flight_date.Substring(flight_date.Length - 2));

                DateTime startflightDate = new DateTime(startYear, startMonth, startDay);
                DateTime endflightDate = new DateTime(endYear, endMonth, endDay);
                int result =DateTime.Compare(startflightDate, endflightDate);
                if (DateTime.Compare(startflightDate, endflightDate) > 0)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('You can’t set the end date before the start date or vice versa')", true);
                }
                else
                {

                    imageUpload.PostedFile.SaveAs(Server.MapPath("~/Upload/" + imagePath));
                    secondImgUpload.PostedFile.SaveAs(Server.MapPath("~/Upload/" + secondImage));

                    addTourController = new AddTour_controller(imagePath, secondImage, tourNameTextBoxValue, tourCost, countryName, flightDateValue, endDateValue);
                    addTour(addTourController);

                    Label1.Text = "Image Uploaded";
                    Label1.ForeColor = System.Drawing.Color.ForestGreen;


                }
            }
            else
            {
                Label1.Text = "Please Upload your Image";
                Label1.ForeColor = System.Drawing.Color.Red;
            }

        }

        private void addTour(AddTour_controller addToutC)
        {
            if(addToutC.saveTour())
            { }
            else
            {
                Response.Write("<script>alert('Adding Tour didn't complete invalid data')</script>");
            }
        }
    }
}