using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Billing
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click1(object sender, EventArgs e)
        {
            string q = "select * from ELogin where username='" + TextBox2.Text + "'AND password='" + TextBox1.Text + "' ";
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=dppadmaja;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Response.Redirect("Logout.aspx");
            }
            else
            {
                Label1.Text = "Kindly check your username and password..........";
            }
        }
    }
}