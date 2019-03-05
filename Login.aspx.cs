using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace LoginApp
{
    public partial class Login : System.Web.UI.Page
    {
        string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LoginDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        protected void Page_Load(object sender, EventArgs e)
        {
            lblErrorMessage.Visible = false;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            using(SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                string query = "select count(1) from LoginTable Where UserName=@UserName AND Password=@Password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if(count==1)
                {
                    Session["UserName"] = txtUserName.Text;
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    lblErrorMessage.Visible = true;
                }
            }
        }
    }
}