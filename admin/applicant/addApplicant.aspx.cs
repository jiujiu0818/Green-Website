using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class joinUs_addapplicant : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ButtonSubmit_Click(object sender, EventArgs e)
    {

        if ((TxtName.Text != "") & (TxtNum.Text != "") & (TxtYear.Text != "") & (TxtEmail.Text != "") & (TxtNum.Text != "") & (TxtIntroduction.Text != ""))
        {
            string strConn = System.Configuration.ConfigurationManager.ConnectionStrings["GrnetConnectionString"].ToString();
            SqlConnection Conn = new SqlConnection(strConn);//连接数据库
            Conn.Open();//打开数据库
            string sqlStr = "INSERT INTO [applicant](applicantID,applicantName,applicantEntranceYear,applicantNum,major,class,email,qq,phoneNum,selectedPart,introduction,createTime,deleteFlag)Values('" + TxtYear.Text + TxtNum.Text + "','" + TxtName.Text + "','" + TxtYear.Text + "','" + TxtNum.Text + "','" + DpMajor.Text + "','" + DpClass.Text + "','" + TxtEmail.Text + "','" + TxtQQ.Text + "','" + TxtPhoneNum.Text + "','" + DropDownList1 .SelectedItem.Value + "','" + TxtIntroduction.Text + "','" + DateTime.Now + "','" + false + "')";
            SqlCommand Comm = new SqlCommand(sqlStr, Conn);
            Comm.ExecuteNonQuery();
            Response.Write("<script>alert('提交成功!')</script>");
        }
        else
        {
            Response.Redirect("error.aspx");
        }
    }
}