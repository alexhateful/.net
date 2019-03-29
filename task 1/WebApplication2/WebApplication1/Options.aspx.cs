using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Options : System.Web.UI.Page
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
                Page.Theme = "bootstrap";
            }
        }

        protected void Theme_Submit_Click(object sender, EventArgs e)
        {
            string themeName;

            themeName = bootstrap.Checked ? "bootstrap" : "uikit";

            HttpCookie cookie = new HttpCookie("Theme", themeName);

            cookie.Expires = DateTime.Now.AddHours(1);

            Response.Cookies.Add(cookie);

            Response.Redirect(Request.Url.PathAndQuery);
        }
    }
}