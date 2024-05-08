using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        SqlConnection dbConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DataBaseConnectionString"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("div style=\"background-color: red\">" + Session["cancelRoom"]+"</div>");
            t2.Text = (string)Session["cancelRoom"];
            Session["cancelRoom"] = "";
        }

        protected void btn_clicked(object sender, EventArgs e)
        {
            dbConnection.Open();

            SqlCommand cmd1 = new SqlCommand("delete from reservation where room_id=@RoomNumber", dbConnection);
            int roomNumber = 0;
            if (int.TryParse(t2.Text, out roomNumber))
                cmd1.Parameters.AddWithValue("@RoomNumber", roomNumber);

            cmd1.ExecuteNonQuery();
            SqlCommand cmd = new SqlCommand("update room set room_status='yes'  where room_number=('" + t2.Text + "' )", dbConnection);
            cmd.ExecuteNonQuery();


             dbConnection.Close();

            t2.Text = "";
        }
    }
}