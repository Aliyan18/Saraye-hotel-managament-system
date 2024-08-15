using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        
        SqlConnection dbConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DataBaseConnectionString"].ConnectionString);


        protected void Page_Load(object sender, EventArgs e)
        {
            dbConnection.Open();
            string query = "Alter view res_record as select* from reservation inner join room on room.Room_number=reservation.room_id";
            SqlCommand cmd = new SqlCommand(query, dbConnection);
             cmd.ExecuteNonQuery();
            //dbConnection.Close();
            //dbConnection.Open();
            var queryString = "select* from res_record";
            // var dbConnection = new SqlConnection(dbConnectionstring);
            var dataAdapter = new SqlDataAdapter(queryString, dbConnection);
            var commanbuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            Response.Write("<div>" + (string)Session["userType"] + "</div>");

            Response.Write("<Table>");
            Response.Write("<tr \".trr\">");
            Response.Write("<td>RES_ID</td>");
            Response.Write("<td>checkin date</td>");
            Response.Write("<td>checkout date</td>");
            Response.Write("<td>room_number</td>");
            Response.Write("<td>owner</td></tr>");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Response.Write("<tr class=\".trr\">");
                Response.Write("<td>" + ds.Tables[0].Rows[i][0] + "</td>");
                Response.Write("<td>" + ds.Tables[0].Rows[i][1] + "</td>");
                Response.Write("<td>" + ds.Tables[0].Rows[i][2] + "</td>");
                 Response.Write("<td>" + ds.Tables[0].Rows[i][5] + "</td>");
                Response.Write("<td>" + ds.Tables[0].Rows[i][8] + "</td></tr>");




            }

            Response.Write("</Table>");
            dbConnection.Close();


        }

        protected void btn_clicked(object sender, EventArgs e)
        {


        }
    }
}
