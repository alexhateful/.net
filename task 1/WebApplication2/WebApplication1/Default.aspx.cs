using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_PreInit(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["Theme"];

            if (cookie != null)
            {
                Page.Theme = cookie.Value;
            }
            else
            {
                Page.Theme = "Bootstrap";
            }
        }
    }
}