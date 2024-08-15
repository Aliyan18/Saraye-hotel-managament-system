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
    public partial class WebForm10 : System.Web.UI.Page
    {
        SqlConnection _conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DataBaseConnectionString"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Unnamed1_TextChanged(object sender, EventArgs e)
        {
            _conn.Open();

            SqlCommand cmd2 = new SqlCommand("SELECT MAX(event_id) FROM events", _conn);
            int eventId = 0;
            if (cmd2.ExecuteScalar() != DBNull.Value)
                eventId = (int)cmd2.ExecuteScalar();
            eventId++;

            SqlCommand cmd = new SqlCommand("insert into events values('"+eventId+"',@name,@date,@location,@capacity,@organizer)", _conn);
            cmd.Parameters.AddWithValue("@name", event_name.Text);
            cmd.Parameters.AddWithValue("@date", event_date.Text);
            cmd.Parameters.AddWithValue("@location", event_location.Text);
            cmd.Parameters.AddWithValue("@capacity", event_capacity.Text);
            cmd.Parameters.AddWithValue("@organizer", event_organizer.Text);
            cmd.ExecuteNonQuery();
            _conn.Close();
           
        }
    }
}