using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginForm
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-7PGB5UI;Initial Catalog=normsoft;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid(); 
            }
        }

    
        protected void btninsert_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand(
                "INSERT INTO Login (UserName, Password) VALUES (@username, @password)", con);

            cmd.Parameters.AddWithValue("@username", txtusername.Text);
            cmd.Parameters.AddWithValue("@password", txtpassword.Text);

            int i = cmd.ExecuteNonQuery();

            if (i > 0)
            {
                lblmsg.Text = "Inserted Successfully";
               
                BindGrid(); 
            }
            else
            {
                lblmsg.Text = "Insert Failed";
          
            }

            con.Close();

            txtusername.Text = "";
            txtpassword.Text = "";
        }

        public void BindGrid()
        {        

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Login", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            GridView1.DataSource = dt;
            GridView1.DataBind();

           
        }
    }
}
