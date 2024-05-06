using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using System.Collections;
using System.Drawing;
using System.Data.Common;

namespace WebApplication4
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["DataBaseConnectionString"].ConnectionString;
        Dictionary<string, int> hashMap = new Dictionary<string, int>();
        //Dictionary<string, int> cart = new Dictionary<string, int>();
        string[] cart = new string[20];
        protected void Page_Load(object sender, EventArgs e)
        {
            hashMap["Lobster Benny"] = 2500;
            hashMap["Burger"] = 1000;
            hashMap["Rolls"] = 1700;
            hashMap["Kebab"] = 1500;
            hashMap["Pizza"] = 2000;
            hashMap["Fries"] = 700;
            hashMap["Steak"] = 3000;
            hashMap["Chicken skewers"] = 2000;
            hashMap["Wrap"] = 1000;
            hashMap["Pancake"] = 1700;
            hashMap["Honey Wings"] = 1400;
            hashMap["North Indian Platter"] = 4000;
            SqlConnection conn = new SqlConnection(cs);
            string query = "select * from cart";
            SqlCommand cmd = new SqlCommand(query, conn);
            //cmd.Parameters.AddWithValue("@product", buttonID);
            conn.Open();int i = 0;
            SqlDataReader dr = cmd.ExecuteReader();
            // Assuming "name" is the column name in your database table
            // Initialize index outside the loop
            while (dr.Read() && i < cart.Length)
            {
                cart[i] = dr["name"].ToString();
                i++;
            }



            conn.Close();
            for (int j = 0; j < i; j++)
            {
                HtmlGenericControl newDiv = new HtmlGenericControl("div");

                // Set attributes or content for the new div if needed
                newDiv.Attributes["class"] = "item";
                string buttonID = cart[j].Replace(' ','_');

                newDiv.InnerHtml = "<div class=\"name\">" + cart[j] + "</div><div class=\"totalPrice\">" + hashMap[cart[j]] + "</div> <span class=\"minus\"><asp:button color=\"white\"runat=\"server\" Text=\"-\" OnClick=\"remov\" ID="+buttonID+"></asp:button></span>\r\n                    <span>1</span>\r\n                    <span class=\"plus\">+</span>";

                // Find the listCart div by its ID
                HtmlGenericControl listCartDiv = (HtmlGenericControl)FindControl("listCart");
                // Add the new div as a child control to the listCart div
                listCartDiv.Controls.Add(newDiv);
            }
        }

        protected void btn_clicked(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string buttonID = clickedButton.ID;
            buttonID = buttonID.Replace('_', ' '); // Replace underscores with spaces
            
            // Create a new HtmlGenericControl for the div element
            // HtmlGenericControl div = new HtmlGenericControl("div");

            // // Set attributes for the div element
            // div.ID = "myDiv"; // Set the ID attribute
            // div.Attributes["class"] = "item"; // Set the class attribute
            // // Create inner HTML content for the div
            // string innerHtml = "<div class=\"name\">" + buttonID + "</div>\r\n" +
            //                    "<div class=\"totalPrice\">$200</div>\r\n" +
            //                    "<div class=\"quantity\">\r\n" +
            //                    "    <span class=\"minus\">-</span>\r\n" +
            //                    "    <span>1</span>\r\n" +
            //                    "    <span class=\"plus\">+</span>\r\n" +
            //                    "</div>";

            // // Set the InnerHtml property of the div
            // div.InnerHtml = innerHtml;

            // // Find the "listCart" div using its class name
            // HtmlGenericControl listCartDiv = (HtmlGenericControl)FindControl("listCart");
            //// listCart.Controls.Add(div);

            // // Add the dynamically created div as a child of the "listCart" div
            // if (listCartDiv != null)
            // {
            //     listCartDiv.Controls.Add(div);
            // }
            // Create a new instance of HtmlGenericControl representing a <div> element
            HtmlGenericControl newDiv = new HtmlGenericControl("div");

            // Set attributes or content for the new div if needed
            newDiv.Attributes["class"] = "item";
            newDiv.InnerHtml = "<div class=\"name\">"+buttonID+ "</div><div class=\"totalPrice\">$100</div> <span class=\"minus\"><asp:button runat=\"server\" Text=\"-\" OnClick=\"remov\"  ID="+buttonID+ "></asp:button></span>\n                    <span>1</span>\n                    <span class=\"plus\"><span class=\"minus\">+</span>";
            HtmlGenericControl listCartDiv = (HtmlGenericControl)FindControl("listCart");

            listCartDiv.Controls.Add(newDiv);

            SqlConnection conn = new SqlConnection(cs);

            conn.Open();
            // Find the listCart div by its ID
            // Add the new div as a child control to the listCart div
            SqlCommand cmd = new SqlCommand("insert into cart(name,price) values ('"+ buttonID +"','" + hashMap[buttonID] + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        protected void remov(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string buttonID = clickedButton.ID;
            buttonID = buttonID.Replace('_', ' ');


            SqlConnection conn = new SqlConnection(cs);

            conn.Open();
            // Find the listCart div by its ID
            // Add the new div as a child control to the listCart div
            SqlCommand cmd = new SqlCommand("delete from cart where name= '" + buttonID + "'" , conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}