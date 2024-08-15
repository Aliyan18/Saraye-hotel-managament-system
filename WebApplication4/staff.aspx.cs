using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void inv_clicked(object sender, EventArgs e)
        {
            Response.Redirect("inventory.aspx");
        }

        protected void staff_clicked(object sender, EventArgs e)
        {
            Response.Redirect("staff.aspx");
        }
        protected void res_clicked(object sender, EventArgs e)
        {
            Response.Redirect("resinfo.aspx");
        }

    }
}