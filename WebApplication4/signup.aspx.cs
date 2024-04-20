using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication4
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection _conn= new SqlConnection(ConfigurationManager.ConnectionStrings["DataBaseConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            _conn.Open();
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into login(username,password) values ('"+username.Text+"','"+Passowed.Text+"')",_conn);
            cmd.ExecuteNonQuery();
            _conn.Close();
            username.Text = "";
            Passowed.Text = "";
            
          
        }
    }
}