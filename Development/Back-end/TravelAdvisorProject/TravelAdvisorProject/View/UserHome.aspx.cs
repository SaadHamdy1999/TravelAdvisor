using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TravelAdvisorProject.View
{
    
    public partial class UserHome : System.Web.UI.Page
    {
        List<string> toursName = new List<string>();
        List<string> toursIDs = new List<string>();
        string firstImagePaths ;
        string secondImagePaths ;
        SqlConnection con = new SqlConnection();
        SqlCommand cmd;
        SqlDataReader sdr;
        static int index = 0;
        string prev;
        string next;
        string userIdentifier = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            userIdentifier = Request.QueryString["userId"];
            if (!IsPostBack)
            {
                // load index from cache
                Int32.TryParse((Session["index"] ?? 0).ToString(), out index);
            }
            
            con.ConnectionString = "workstation id=TravelAdvisorDB.mssql.somee.com;packet size=4096;user id=ossayed17_SQLLogin_1;pwd=trtnuvf8kw;data source=TravelAdvisorDB.mssql.somee.com;persist security info=False;initial catalog=TravelAdvisorDB";
            con.Open();
            cmd = new SqlCommand("select * from Tour_Table", con);
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                toursName.Add(sdr["T_Name"].ToString());
                toursIDs.Add( sdr["T_ID"].ToString());
            }
            sdr.Close();
            getImagesUrls(toursIDs[index]);
        }

        protected void prevBtn_Click(object sender, EventArgs e)
        {

            
            if (index -1 > -1)
            {
                index -= 1;
                Session["index"] = index;
                prev = toursName[index];
                getImagesUrls(toursIDs[index]);
                tourName.Text = prev;
            }
           
        }

        protected void nextBtn_Click(object sender, EventArgs e)
        {
           
            if (index + 1 < toursName.Count)
            {
                index += 1;
                Session["index"] = index;
                next = toursName[index];
                getImagesUrls(toursIDs[index]);
                tourName.Text = next;
            }

        }

        private void getImagesUrls(string tripID)
        {
            tourName.Text = toursName[index];
            cmd = new SqlCommand("select * from Images where T_ID = @TID", con);
            cmd.Parameters.AddWithValue("@TID", tripID);
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                firstImagePaths= sdr["Image_Path"].ToString();
                secondImagePaths= sdr["Second_Image_Path"].ToString();
            }
            sdr.Close();
            firstImg.ImageUrl = firstImagePaths;
            secondImg.ImageUrl = secondImagePaths;
        }

        protected void view_Click(object sender, EventArgs e)
        {
            Response.Redirect("TourBooking.aspx?val=" + toursIDs[index]+ "&userId="+ userIdentifier);
        }
    }
}