using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class 新登陆模块_alterUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
         if (!IsPostBack)
        {
            string id = Request.QueryString["id"];
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["GrnetConnectionString"].ToString();//连接数据库字符串
            SqlConnection Conn = new SqlConnection(conString);//连接数据库
            string sqlStr = "SELECT * FROM [user] where userID='" + id + "'";
            SqlDataAdapter Da = new SqlDataAdapter(sqlStr, Conn);//打开数据库
            DataSet Ds = new DataSet();
            Da.Fill(Ds);
            TextBox1.Text = Ds.Tables[0].Rows[0]["userName"].ToString();
            TextBox3.Text = Ds.Tables[0].Rows[0]["passWord"].ToString();
            
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       
        string id = Request.QueryString["id"];
        string conString = System.Configuration.ConfigurationManager.ConnectionStrings["GrnetConnectionString"].ToString();//连接数据库字符串
        SqlConnection Conn = new SqlConnection(conString);//连接数据库
        string sqlStr = "update [user] set userName='" + TextBox1.Text + "',passWord='"+TextBox3.Text+"' where userID='" + id +"'";
        Conn.Open();//打开数据库
        SqlCommand Comm = new SqlCommand(sqlStr, Conn);      
        Comm.ExecuteNonQuery();
        Response.Write("<script>alert('修改成功')</script>");
        Conn.Close();
         }

 }


