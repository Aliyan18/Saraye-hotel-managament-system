using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

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
            cmd.Parameters.AddWithValue("@user1",TextBox1.Text);
            cmd.Parameters.AddWithValue("@pass", TextBox2.Text);
            conn.Open();
            SqlDataReader dr= cmd.ExecuteReader();
            if (dr.HasRows)
            {
                Session["username"] = TextBox1.Text;
                Session["password"] = TextBox2.Text;
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('login successful')</script>");
                Response.Redirect("home.aspx");
            }
            else {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('login failed')</script>");

            }
            conn.Close();

        }

    }
}