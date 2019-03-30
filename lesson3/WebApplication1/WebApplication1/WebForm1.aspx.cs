using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private String MD5Hash(String str, String salt = "")
        {
            using (var hasher = System.Security.Cryptography.MD5.Create())
            {

                byte[] src = Encoding.UTF8.GetBytes(str + salt);

                byte[] hash = hasher.ComputeHash(src);

                var sb = new StringBuilder();

                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2"));
                }

                return sb.ToString();
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["DB"].ConnectionString);

            text.Text = MD5Hash("123");

            try
            {
                con.Open();

                //text.Text = con.State.ToString();
            }
            catch (Exception ex)
            {
                text.Text = ex.Message;
                throw;
            }
        }
    }
}