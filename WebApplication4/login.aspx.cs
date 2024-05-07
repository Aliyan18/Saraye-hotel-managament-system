using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Common;
using System.Security.Cryptography;

namespace WebApplication4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["DataBaseConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cs);
            string query = "select * from UserAccounts where username=@user1 and password=@pass";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@user1", TextBox1.Text);
            cmd.Parameters.AddWithValue("@pass", TextBox2.Text);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Close(); // Close the DataReader here before executing the next query

                string selectQuery = "SELECT usertype FROM UserAccounts WHERE username = @user";
                SqlCommand selectCommand = new SqlCommand(selectQuery, conn);
                selectCommand.Parameters.AddWithValue("@user", TextBox1.Text);
                string userType = (string)selectCommand.ExecuteScalar();

                Session["username"] = TextBox1.Text;
                Session["password"] = TextBox2.Text;
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('login successful')</script>");
                if (userType == "administrator" || userType == "staff")
                {
                    Session["userType"] = userType;
                    Response.Redirect("staff.aspx");
                }
                else
                    Response.Redirect("home.aspx");
            }
            else
            {
                dr.Close(); // Ensure to close the DataReader in case of no rows returned
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('login failed')</script>");
            }
            conn.Close();
        }


    }
}