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
        string theme = "uikit";

        protected void Get_Theme()
        {
            object obj = ViewState["theme"];

            if (obj != null)
            {
                theme = (string)obj;
            }
        }

        protected void Page_PreInit(object sender, EventArgs e)
        {
            Get_Theme();
            Page.Theme = theme;
        }
    }
}