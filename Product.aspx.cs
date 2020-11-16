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
    public partial class WebForm5 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=dppadmaja;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=dppadmaja;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into AddProduct(ProductName,ProductPrice,ProductQty)values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')", con);
            cmd.ExecuteNonQuery();
            Label4.Text = "Items Added Successfully.....";
            //Response.Redirect(".aspx");
        }
        private void Bind()
        {
            SqlDataAdapter ad = new SqlDataAdapter("select * from AddProduct", con);
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
            
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=dppadmaja;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from AddProduct where ProductName='" + TextBox1.Text + "'", con);
            cmd.ExecuteNonQuery();
            Label4.Text = "Item Deleated Successfully.....";

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=dppadmaja;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update AddProduct SET ProductName='"+TextBox1.Text+"',ProductPrice='"+TextBox2.Text+"',ProductQty='"+TextBox3.Text+ "' where ProductName='" + TextBox1.Text + "'", con);
            cmd.ExecuteNonQuery();
            Label4.Text = "Data Updated Successfully.....";
        }
    }
}