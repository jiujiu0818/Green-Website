using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data .SqlClient;
using System.Data;

public partial class admin_altermember : System.Web.UI.Page
{
        protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string id = Request.QueryString["id"];
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["GrnetConnectionString"].ToString();//连接数据库字符串
            SqlConnection Conn = new SqlConnection(conString);//连接数据库
            string sqlStr = "SELECT * FROM member  where deleteFlag = 'false' and memberID='" + id + "'";
            SqlDataAdapter Da = new SqlDataAdapter(sqlStr, Conn);//打开数据库
            DataSet Ds = new DataSet();
            Da.Fill(Ds);
            TxtName.Text = Ds.Tables[0].Rows[0]["memberName"].ToString();
            TxtNum.Text = Ds.Tables[0].Rows[0]["memberNum"].ToString();
            TxtYear.Text = Ds.Tables[0].Rows[0]["memberEntranceYear"].ToString();
            FreeTextBox1.Text = Ds.Tables[0].Rows[0]["introduction"].ToString();
            TxtIDName.Text=Ds.Tables[0].Rows[0]["IDName"].ToString();
            TxtMotto.Text=Ds.Tables[0].Rows[0]["motto"].ToString();
            TxtHobby.Text=Ds.Tables[0].Rows[0]["hobby"].ToString();
            //此处原照片的地址不显示出来

            
            
        }
    }
    protected void submit_Click(object sender, EventArgs e)
    {
        string id = Request.QueryString["id"];
        string conString = System.Configuration.ConfigurationManager.ConnectionStrings["GrnetConnectionString"].ToString();//连接数据库字符串
        SqlConnection Conn = new SqlConnection(conString);//连接数据库
        string sqlStr = "update member set memberName='" + TxtName.Text + "',IDName='"+ TxtIDName.Text+"',motto='"+TxtMotto.Text+"',hobby='"+ TxtHobby.Text+"',memberNum='" + TxtNum.Text + "',memberEntranceYear='" + TxtYear.Text + "',introduction='" + FreeTextBox1.Text  + "' where memberID='" + id + "'";
        Conn.Open();//打开数据库
        SqlCommand Comm = new SqlCommand(sqlStr, Conn);
        Comm.ExecuteNonQuery();
        Response.Write("<script>alert('修改成功')</script>");
        Conn.Close();
        //Response.Redirect("listmember.aspx");
    }
    }
