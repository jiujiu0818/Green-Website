using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class jionUs_alterApplicant : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string id = Request.QueryString["id"];
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["GrnetConnectionString"].ToString();//连接数据库字符串
            SqlConnection Conn = new SqlConnection(conString);//连接数据库
            string sqlStr = "SELECT * FROM applicant where deleteFlag = 'false' and applicantID='" + id + "'";
            SqlDataAdapter Da = new SqlDataAdapter(sqlStr, Conn);//打开数据库
            DataSet Ds = new DataSet();
            Da.Fill(Ds);
            TxtName.Text = Ds.Tables[0].Rows[0]["applicantName"].ToString();
            TxtNum.Text = Ds.Tables[0].Rows[0]["applicantNum"].ToString();
            TxtYear.Text = Ds.Tables[0].Rows[0]["applicantEntranceYear"].ToString();
            TxtEmail.Text = Ds.Tables[0].Rows[0]["email"].ToString();
            TxtQQ.Text = Ds.Tables[0].Rows[0]["qq"].ToString();
            TxtPhoneNum.Text = Ds.Tables[0].Rows[0]["phoneNum"].ToString();
            TxtIntroduction.Text = Ds.Tables[0].Rows[0]["introduction"].ToString();
            DpMajor.SelectedValue = Ds.Tables[0].Rows[0]["major"].ToString();
            DpClass.SelectedValue = Ds.Tables[0].Rows[0]["class"].ToString();
            DpSelectedPart.SelectedValue = Ds.Tables[0].Rows[0]["selectedPart"].ToString();
        }
    }
    protected void ButtonSubmit_Click(object sender, EventArgs e)
    {
        string id = Request.QueryString["id"];
        string conString = System.Configuration.ConfigurationManager.ConnectionStrings["GrnetConnectionString"].ToString();//连接数据库字符串
        SqlConnection Conn = new SqlConnection(conString);//连接数据库
        string sqlStr = "update applicant set applicantName='" + TxtName.Text + "',applicantNum='" + TxtNum.Text + "',applicantEntranceYear='" + TxtYear.Text + "',email='" + TxtEmail.Text + "',qq='" + TxtQQ.Text +"',phoneNum='" + TxtPhoneNum.Text + "',introduction='" + TxtIntroduction.Text + "',major='" + DpMajor.SelectedValue + "',class='" + DpClass.SelectedValue + "',selectedPart='" + DpSelectedPart.SelectedValue + "' where applicantID='" + id + "'";
        Conn.Open();//打开数据库
        SqlCommand Comm = new SqlCommand(sqlStr, Conn);
        Comm.ExecuteNonQuery();
        Response.Write("<script>alert('修改成功')</script>");
        Conn.Close();
    }
}