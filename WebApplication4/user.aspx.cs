using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebApplication4
{
    public partial class user : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
string dbConnectionstring = ConfigurationManager.ConnectionStrings["dataBaseConnectionString"].ConnectionString;
            var queryString = "SELECT * FROM users";
            var dbConnection = new SqlConnection(dbConnectionstring);
            var dataAdapter = new SqlDataAdapter(queryString, dbConnection);
            var commanbuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
          dataAdapter.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            Response.Write("<div>" + @ds.Tables[0].Rows[0][0]  +" <div>");
            GridView1.DataBind();
            
        }
    }
}