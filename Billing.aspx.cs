using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Billing
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=dppadmaja;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=dppadmaja;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Billings(CustName,Contact,ProdName,Qnty,Price,TotalAmt)values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox7.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox6.Text + "')", con);
            cmd.ExecuteNonQuery();
            Label9.Text = "Bill Generated Successfully.....";
            //Response.Redirect(".aspx");
        }
        private void Bind()
        {
            SqlDataAdapter ad = new SqlDataAdapter("select * from Billings where CustName='" + TextBox1.Text + "'", con);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        private void BindAll()
        {
            SqlDataAdapter ad = new SqlDataAdapter("select * from Billings", con);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Bind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            BindAll();
        }
    }
}