using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class 新登陆模块_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

         if (!IsPostBack)
        {
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["GrnetConnectionString"].ToString();//连接数据库字符串
            SqlConnection Conn = new SqlConnection(conString);//连接数据库
            string sqlStr = "SELECT * FROM [user] ";
            SqlDataAdapter Da = new SqlDataAdapter(sqlStr, Conn);//打开数据库
            DataSet Ds = new DataSet();
            Da.Fill(Ds);
            GridView1.DataSource = Ds.Tables[0];
            GridView1.DataBind();
        }
    }
  
    protected void GridView1_RowDeleting1(object sender, GridViewDeleteEventArgs e)
    {
        string id = GridView1.Rows[e.RowIndex].Cells[0].Text.ToString();
        string sqlstr = "delete  from [user] where userID='" + id + "'";
        string conString = System.Configuration.ConfigurationManager.ConnectionStrings["GrnetConnectionString"].ToString();//连接数据库字符串
        SqlConnection Conn = new SqlConnection(conString);//连接数据库 
        Conn.Open();
        SqlCommand comm = new SqlCommand(sqlstr, Conn);
        comm.ExecuteNonQuery();
        GridView1.DataBind();
        Response.Redirect("userList.aspx");

    }
    protected void GridView1_RowEditing1(object sender, GridViewEditEventArgs e)
    {
        string id = GridView1.Rows[e.NewEditIndex].Cells[0].Text.ToString();
        Response.Redirect("alterUser.aspx?id=" + id);
        
    }
}
