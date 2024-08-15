using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Assuming you have a TextBox with ID "TextBox1"
            HtmlGenericControl myDiv = FindControl("myDiv") as HtmlGenericControl;
            HtmlGenericControl dropDown = FindControl("dropdown") as HtmlGenericControl;

            if (Session["username"] == null)
            {
                myDiv.InnerHtml = "<a href=\"login.aspx\" class=\"login\">Login</a>";
            }
            else {
                myDiv.InnerHtml = "  <div class=\"dropdown\"><button class=\"dropbtn\">BOOK</button>  <div class=\"dropdown-content\"> <a href=\"reservation.aspx\">Reservation</a>  <a href=\"events.aspx\">Event</a>  <a href=\"HtmlPage1.html\">FEEDBACK</a>\r\n  </div></div>";

                myDiv.InnerHtml+= "<a href=\"login.aspx\" class=\"login\">Logout</a>";
            }
        } 
       
    }
}