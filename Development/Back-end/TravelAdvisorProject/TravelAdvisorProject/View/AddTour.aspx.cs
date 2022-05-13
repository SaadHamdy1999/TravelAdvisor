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
                imageUpload.PostedFile.SaveAs(Server.MapPath("~/Upload/" + imagePath));
                secondImgUpload.PostedFile.SaveAs(Server.MapPath("~/Upload/" + secondImage));

                addTourController = new AddTour_controller(imagePath, secondImage, tourNameTextBoxValue, tourCost, countryName, flightDateValue, endDateValue);
                addTour(addTourController);

                Label1.Text = "Image Uploaded";
                Label1.ForeColor = System.Drawing.Color.ForestGreen;

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