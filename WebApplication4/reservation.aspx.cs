using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Drawing;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Globalization;

namespace WebApplication4
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        SqlConnection dbConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DataBaseConnectionString"].ConnectionString);

       
        protected void Page_Load(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Today;
            Response.Write("<div>Current Date: " + currentDate+"</div>");

            dbConnection.Open();
            var queryString = "exec reg";
            // var dbConnection = new SqlConnection(dbConnectionstring);
            var dataAdapter = new SqlDataAdapter(queryString, dbConnection);
            var commanbuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);

             Response.Write("<div>" + Session[0] + "</div>");
             Response.Write("<div>"+ Session[1] + "</div>");

            Response.Write("<div class=\"box\">");

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                object value = ds.Tables[0].Rows[i][11];
                object val = ds.Tables[0].Rows[i][5];

                //  if (value != DBNull.Value && Session[0] != null&& ds.Tables[0].Rows[i][11].ToString() == Session[0].ToString())
                if(value != DBNull.Value && Session[0] != null&& (string)ds.Tables[0].Rows[i][2] == "no" && (string)ds.Tables[0].Rows[i][11] == Session[0].ToString()) { 
                
                
                    

                        Response.Write("<div runat=\"server\" runat=\"server\" id=\"myDiv\" class=\"item booked\" OnClick=\"cancelroom(this);\">" + ds.Tables[0].Rows[i][0] + "<br>" + ds.Tables[0].Rows[i][1] + "<br>" + ds.Tables[0].Rows[i][2] + "</div>");

                    
                }
               else if ((string)ds.Tables[0].Rows[i][2] == "yes")
                {
                    Response.Write("<div runat=\"server\" runat=\"server\" id=\"myDiv\" class=\"item styl\" OnDblClick=\"chooseRoom(this);\">" + ds.Tables[0].Rows[i][0] + "<br>" + ds.Tables[0].Rows[i][1] + "<br>" + ds.Tables[0].Rows[i][2] + "</div>");

                }
                else if(val!= DBNull.Value)
                    Response.Write("<div class=\"item\" style=\"background-color:silver\" >" + ds.Tables[0].Rows[i][0] + "<br>not available till:"+"<br>" + ds.Tables[0].Rows[i][5] + " </div>");

            }
            Response.Write("</div>");

          //  dbConnection.Close();

        }

/*        protected void t1_TextChanged(object sender, EventArgs e)
        {
          //  dbConnection.Open();

            SqlCommand cmd = new SqlCommand("update res set avaibility='no' where roomnum=('" + t1.Text + "' )", dbConnection);
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand("UPDATE res SET username = @Username WHERE roomnum = @RoomNum", dbConnection);
            cmd1.Parameters.AddWithValue("@Username", Session[0]);
            cmd1.Parameters.Add("@RoomNum", SqlDbType.VarChar).Value = t1.Text;


            cmd1.ExecuteNonQuery();

            dbConnection.Close();
            
            t1.Text = "";
        }*/

                protected void btn1_Clicked(object sender, EventArgs e)
                {
           string dateValue = TextBox1.Text.Trim(); // Get the date value from the TextBox
            string dateValue1 = TextBox2.Text.Trim(); // Get the date value from the TextBox
             
              
            if (t1.Text != "")
                    {
                if (TextBox1.Text == "" || TextBox2.Text == "")
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('must enter dates for check in and check out');</script>");

                }
                else
                {
                    DateTime currentDate = DateTime.Today;
                    DateTime dateTime1;
                    DateTime dateTime2;
                  
                    if (DateTime.TryParseExact(dateValue, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime1) && DateTime.TryParseExact(dateValue1, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime2))
                    {

                        if (dateTime1 >= currentDate && dateTime2 >= currentDate)
                            if (dateTime1 >= dateTime2)
                            {
                                Response.Write("<div>Current Date: " + dateTime1 + "</div>");
                                Response.Write("<div>Current Date: " + dateTime2 + "</div>");
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('must enter VALID dates for check in and check out');", true);
                            }
                            else
                            {


                                SqlCommand cmd2 = new SqlCommand("SELECT MAX(reservation_id) FROM reservation", dbConnection);
                                int maxReservationId = 0;
                                if (cmd2.ExecuteScalar() != DBNull.Value)
                                    maxReservationId = (int)cmd2.ExecuteScalar();
                                maxReservationId++;
                                SqlCommand cmd1 = new SqlCommand("INSERT INTO reservation (reservation_id, username, checkin_date, checkout_date, room_id)  VALUES (@ResId, @Username, @Checkin, @Checkout, @RoomNum)", dbConnection);
                                cmd1.Parameters.AddWithValue("@ResId", maxReservationId); // Incrementing the max reservation ID by 1
                                cmd1.Parameters.AddWithValue("@Username", Session[0].ToString());
                                cmd1.Parameters.AddWithValue("@Checkin", dateValue);
                                cmd1.Parameters.AddWithValue("@Checkout", dateValue1);
                                cmd1.Parameters.AddWithValue("@RoomNum", t1.Text);
                                cmd1.ExecuteNonQuery();
                                SqlCommand cmd = new SqlCommand("UPDATE room SET room_status='no' WHERE room_number=@RoomNumber;", dbConnection);
                                cmd.Parameters.AddWithValue("@RoomNumber", t1.Text);
                                cmd.ExecuteNonQuery();


                                Response.Redirect("reservation.aspx");

                                t1.Text = "";
                            } // Clearing the text box after execution
                    }
                }
                t1.Text = "";

            }
            if (t2.Text != "") {
                SqlCommand cmd1 = new SqlCommand("delete from reservation where room_id=@RoomNumber", dbConnection);
                cmd1.Parameters.AddWithValue("@RoomNumber", t2.Text);

                cmd1.ExecuteNonQuery();
                SqlCommand cmd = new SqlCommand("update room set room_status='yes'  where room_number=('" + t2.Text + "' )", dbConnection);
                        cmd.ExecuteNonQuery();
                      

                        // dbConnection.Close();

                        t2.Text = "";
                Response.Redirect("reservation.aspx");

            }
            //await Task.Delay(3000);
            dbConnection.Close();
            for (int i = 0; i < 50; i++) ;

        }
        /* protected void t2_TextChanged(object sender, EventArgs e)
{
SqlCommand cmd = new SqlCommand("update res set avaibility='yes' where roomnum=('" + t2.Text + "' )", dbConnection);
cmd.ExecuteNonQuery();
//dbConnection.Close();

t2.Text = "";
}*/

    }
}