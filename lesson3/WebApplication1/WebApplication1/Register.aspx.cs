using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Register : System.Web.UI.Page
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

        }

        protected void Button_Register_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["DB"].ConnectionString);

            try
            {
                con.Open();

                con.CreateCommand()
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}