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

            if (Session["username"] == null)
            {
                myDiv.InnerHtml = "<a href=\"login.aspx\" class=\"login\">Login</a>";
            }
            else {
                myDiv.InnerHtml="<a href =\"reservation.aspx\">P</a>";

            }
        }
       
    }
}