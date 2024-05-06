using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        SqlConnection dbConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DataBaseConnectionString"].ConnectionString);


        protected void Page_Load(object sender, EventArgs e)
        {
            dbConnection.Open();
            var queryString = "select* from inventory";
            // var dbConnection = new SqlConnection(dbConnectionstring);
            var dataAdapter = new SqlDataAdapter(queryString, dbConnection);
            var commanbuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);

            Response.Write("<Table>");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++) {
                Response.Write("<tr>");
                Response.Write("<td>"+    ds.Tables[0].Rows[i][0]+"</td>");
                Response.Write("<td>" + ds.Tables[0].Rows[i][1] + "</td>");
                Response.Write("<td>" + ds.Tables[0].Rows[i][2] + "</td>");
                Response.Write("<td>" + ds.Tables[0].Rows[i][3] + "</td>");
                Response.Write("<td>" + ds.Tables[0].Rows[i][4] + "</td>");
                object value = ds.Tables[0].Rows[i][5];
                if (value != DBNull.Value && int.TryParse(value.ToString(), out int intValue) && intValue > 0)
                    Response.Write("<td>" + ds.Tables[0].Rows[i][5] + "</td>");
                else
                    Response.Write("<td color=\"red\" > OUT OF STOCK  </td>");

                Response.Write("</tr>");



            }

            Response.Write("</Table>");
            dbConnection.Close();

        }

        
            protected void btn_click(object sender, EventArgs e)
            {
                SqlCommand cmd = new SqlCommand("update inventory set quantity= @q where item_id=@id", dbConnection);
                cmd.Parameters.AddWithValue("@id", textbox2.Text);
                cmd.Parameters.AddWithValue("@q", textbox1.Text);
                dbConnection.Open(); // Open the connection before executing the command
                cmd.ExecuteNonQuery(); // Execute the update command
                dbConnection.Close(); // Close the connection after executing the command
                textbox2.Text = "";
                textbox1.Text = "";
            Response.Redirect("WebForm6.aspx");
            }
           
        
    }
}