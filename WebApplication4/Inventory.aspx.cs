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
            if(textbox1.Text!=""&&textbox2.Text!="")
            if ((string)Session["userType"] == "staff")
            {
                string alertScript = "alert('ONLY ADMINS CAN PLACE ORDERS');";

                ClientScript.RegisterStartupScript(this.GetType(), "NotEnoughItemsAlert", alertScript, true);
            }
            else
            {
                dbConnection.Open();
                string iid = textbox2.Text;
                // Step 1: Retrieve the current quantity
                string selectQuery = "SELECT Quantity FROM Inventory WHERE Item_Id = @ItemId";
                SqlCommand selectCommand = new SqlCommand(selectQuery, dbConnection);
                selectCommand.Parameters.AddWithValue("@ItemId", iid);
                int currentQuantity = (int)selectCommand.ExecuteScalar();
                int newQuantity = 0;
                if (!string.IsNullOrEmpty(textbox1.Text))
                {
                    int.TryParse(textbox1.Text, out newQuantity);
                }
                // Step 2: Update the quantity
                int updatedQuantity = currentQuantity + newQuantity;
                if (updatedQuantity >= 0)
                {
                    // Step 3: Update the database
                    string updateQuery = "UPDATE Inventory SET Quantity = @UpdatedQuantity WHERE Item_Id = @ItemId";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, dbConnection);
                    updateCommand.Parameters.AddWithValue("@UpdatedQuantity", updatedQuantity);
                    updateCommand.Parameters.AddWithValue("@ItemId", iid);
                    updateCommand.ExecuteNonQuery();
                }
                textbox2.Text = "";
                textbox1.Text = "";
            }
            for (int i = 0; i < 100; i++) ;
            Response.Redirect("Inventory.aspx");

        }
        protected void btn_click1(object sender, EventArgs e)
        {


            if (textbox4.Text != "" && textbox3.Text != "")
            {




                dbConnection.Open();
                string iid = textbox3.Text;
                // Step 1: Retrieve the current quantity
                string selectQuery = "SELECT Quantity FROM Inventory WHERE Item_Id = @ItemId";
                SqlCommand selectCommand = new SqlCommand(selectQuery, dbConnection);
                selectCommand.Parameters.AddWithValue("@ItemId", iid);
                int currentQuantity = (int)selectCommand.ExecuteScalar();
                int newQuantity = 0;
                if (!string.IsNullOrEmpty(textbox4.Text))
                {
                    int.TryParse(textbox4.Text, out newQuantity);
                }
                // Step 2: Update the quantity
                int updatedQuantity = currentQuantity - newQuantity;
                if (updatedQuantity >= 0)
                {
                    // Step 3: Update the database
                    string updateQuery = "UPDATE Inventory SET Quantity = @UpdatedQuantity WHERE Item_Id = @ItemId";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, dbConnection);
                    updateCommand.Parameters.AddWithValue("@UpdatedQuantity", updatedQuantity);
                    updateCommand.Parameters.AddWithValue("@ItemId", iid);
                    updateCommand.ExecuteNonQuery();
                    for (int i = 0; i < 70; i++) ;

                    Response.Redirect("Inventory.aspx");

                }
                else
                {
                    string alertScript = "alert('Not enough items');";

                    ClientScript.RegisterStartupScript(this.GetType(), "NotEnoughItemsAlert", alertScript, true);
                    Response.Redirect("Inventory.aspx");

                }
            }
        }
        

    }

}