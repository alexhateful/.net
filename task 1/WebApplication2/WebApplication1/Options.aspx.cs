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
        string theme = "uikit";

        protected void Get_Theme()
        {
            object obj = ViewState["theme"];

            if (obj != null)
            {
                theme = (string)obj;
            }
        }

        protected void Set_Theme()
        {
            Theme_Submit.Text = theme;
            ViewState["theme"] = theme;
        }

        protected void Page_PreInit(object sender, EventArgs e)
        {
            Get_Theme();
            Page.Theme = theme;
        }

        protected void Theme_Submit_Click(object sender, EventArgs e)
        {
            theme = bootstrap.Checked ? bootstrap.ID : uikit.ID;
            Set_Theme();
        }
    }
}