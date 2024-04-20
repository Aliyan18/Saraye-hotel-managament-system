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

namespace WebApplication4
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        SqlConnection dbConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DataBaseConnectionString"].ConnectionString);

       
        protected void Page_Load(object sender, EventArgs e)
        {
            dbConnection.Open();
           var queryString = "SELECT * FROM res";
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
                object value = ds.Tables[0].Rows[i][5];

                if (value != DBNull.Value && Session[0] != null&& ds.Tables[0].Rows[i][5].ToString() == Session[0].ToString())
                {
                    

                        Response.Write("<div runat=\"server\" runat=\"server\" id=\"myDiv\" class=\"item booked\" OnClick=\"cancelroom(this);\">" + ds.Tables[0].Rows[i][0] + "<br>" + ds.Tables[0].Rows[i][1] + "<br>" + ds.Tables[0].Rows[i][4] + "</div>");

                    
                }
               else if ((string)ds.Tables[0].Rows[i][1] == "yes")
                {
                    Response.Write("<div runat=\"server\" runat=\"server\" id=\"myDiv\" class=\"item styl\" OnDblClick=\"chooseRoom(this);\">" + ds.Tables[0].Rows[i][0] + "<br>" + ds.Tables[0].Rows[i][1] + "<br>" + ds.Tables[0].Rows[i][4] + "</div>");

                }
                else
                    Response.Write("<div class=\"item\" style=\"background-color:silver\" >" + ds.Tables[0].Rows[i][0] + "<br>not available till:"+"<br>" + ds.Tables[0].Rows[0][2] + " </div>");

            }
            Response.Write("</div>");

          //  dbConnection.Close();

        }

        protected void t1_TextChanged(object sender, EventArgs e)
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
        }

      /*  protected void t2_TextChanged(object sender, EventArgs e)
        {
         //   dbConnection.Open();

            SqlCommand cmd = new SqlCommand("update res set avaibility='yes' where roomnum=('" + t2.Text + "' )", dbConnection);
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand("update res set username=NULL where roomnum=('" + t2.Text + "' )", dbConnection);
            cmd1.ExecuteNonQuery();

           // dbConnection.Close();

            t2.Text = "";
        }

        protected async void btn1_Clicked(object sender, EventArgs e)
        {
            if (t1.Text != "")
            {
                SqlCommand cmd = new SqlCommand("update res set avaibility='no' where roomnum=('" + t1.Text + "' )", dbConnection);
                cmd.ExecuteNonQuery();
                SqlCommand cmd1 = new SqlCommand("UPDATE res SET username = @Username WHERE roomnum = @RoomNum", dbConnection);
                cmd1.Parameters.AddWithValue("@Username", Session[0]);
                cmd1.Parameters.Add("@RoomNum", SqlDbType.VarChar).Value = t1.Text;

                cmd1.ExecuteNonQuery();

                dbConnection.Close();

                t1.Text = "";
            }

            if (t2.Text != "")
            {
                SqlCommand cmd = new SqlCommand("update res set avaibility='yes' where roomnum=('" + t2.Text + "' )", dbConnection);
                cmd.ExecuteNonQuery();
                SqlCommand cmd1 = new SqlCommand("update res set username=NULL where roomnum=('" + t2.Text + "' )", dbConnection);
                cmd1.ExecuteNonQuery();

                t2.Text = "";
            }

           // await Task.Delay(8000); // Introduce a delay of 3 seconds

            Response.Redirect("reservation.aspx");
        }*/
                protected void btn1_Clicked(object sender, EventArgs e)
                {
            string dateValue = TextBox1.Text.Trim(); // Get the date value from the TextBox
            string dateValue1 = TextBox2.Text.Trim(); // Get the date value from the TextBox


            if (t1.Text != "")
                    {
                        SqlCommand cmd = new SqlCommand("update res set avaibility='no' where roomnum=('" + t1.Text + "' )", dbConnection);
                        cmd.ExecuteNonQuery();
                SqlCommand cmd1 = new SqlCommand("UPDATE res SET username=@Username, checkin=@Checkin, checkout=@Checkout WHERE roomnum=@RoomNum", dbConnection);
                cmd1.Parameters.AddWithValue("@Username", Session[0]);
                cmd1.Parameters.AddWithValue("@Checkin", dateValue);
                cmd1.Parameters.AddWithValue("@Checkout", dateValue1);
                cmd1.Parameters.AddWithValue("@RoomNum", t1.Text);
                cmd1.ExecuteNonQuery();


                        t1.Text = "";
                    }
                    if (t2.Text != "") {
                        SqlCommand cmd = new SqlCommand("update res set avaibility='yes' where roomnum=('" + t2.Text + "' )", dbConnection);
                        cmd.ExecuteNonQuery();
                        SqlCommand cmd1 = new SqlCommand("update res set username=NULL where roomnum=('" + t2.Text + "' )", dbConnection);
                        cmd1.ExecuteNonQuery();

                        // dbConnection.Close();

                        t2.Text = "";
                    }
            //await Task.Delay(3000);
            dbConnection.Close();

            Response.Redirect("reservation.aspx");
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