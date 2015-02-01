using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class 新登陆模块_addUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if ((TextBox1.Text  != "") & (TextBox2.Text != "") )
        {
            string strConn = System.Configuration.ConfigurationManager.ConnectionStrings["GrnetConnectionString"].ToString();
            SqlConnection Conn = new SqlConnection(strConn);//连接数据库
            Conn.Open();//打开数据库
            string sqlStr = "INSERT INTO [user](userName,passWord)Values('" +TextBox1.Text+ "','" +TextBox2.Text+"')";
            SqlCommand Comm = new SqlCommand(sqlStr, Conn);
            Comm.ExecuteNonQuery();
            Response.Write("<script>alert('提交成功!')</script>");
        }
    }
}