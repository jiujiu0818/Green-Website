using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Default2 : System.Web.UI.Page
{
    string part;
    protected void Page_Load(object sender, EventArgs e)
    {
        part = Request["part"];
        TxtPart.Text = part;
        TxtPart.Enabled = false;

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        if (TxtName.Text == "" || TxtNum.Text == "" || TxtPart.Text == "")
        {
            Response.Write("<script>alert('请输入姓名、学号、选择方向等信息');window.location.href=window.location.href;</script>");
            
        }
        else
        {
            int intpart;
            if (part == "前台")
                intpart = 1;
            else if (part == "后台")
                intpart = 2;
            else
                intpart = 3;
            string strConn = System.Configuration.ConfigurationManager.ConnectionStrings["GrnetConnectionString"].ToString();
            SqlConnection Conn = new SqlConnection(strConn);//连接数据库
            Conn.Open();//打开数据库
            string sqlStr = "INSERT INTO [applicant](applicantID,applicantName,applicantNum,major,class,qq,phoneNum,selectedPart,introduction,createTime,deleteFlag)Values('" + TxtNum.Text + "','" + TxtName.Text + "','" + TxtNum.Text + "','" + txtMajor.Text + "','" + TxtClass.Text + "','" + TxtQQ.Text + "','" + TxtPhone.Text + "','" + intpart + "','" + TxtIntroduction.Text + "','" + DateTime.Now.ToString() + "','" + false + "')";
            SqlCommand Comm = new SqlCommand(sqlStr, Conn);
            Comm.ExecuteNonQuery();
            Response.Write("<script>alert('提交成功!')</script>");
        }
    }
}