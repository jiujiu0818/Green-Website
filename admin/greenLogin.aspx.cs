using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Collections;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {        
        try
        {
            if (tbUserName.Text.Length > 15)
            {
                Response.Write("<script>alert('用户名或密码错误！')</script>");
                return;
            }
            string conStr = System.Configuration.ConfigurationManager.ConnectionStrings["GrnetConnectionString"].ToString();
            string strSql = "SELECT passWord FROM [user] WHERE userName='" + tbUserName.Text.ToString() + "'";
            SqlConnection sqlconn = new SqlConnection(conStr);
            SqlDataAdapter da = new SqlDataAdapter(strSql, sqlconn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (tbPassword.Text.Equals(ds.Tables[0].Rows[0][0].ToString()))
            {
                Session["userInfo"] = tbUserName.Text;
                if (Request.QueryString.Count != 0)
                {
                    string from = Request.QueryString["from"];
                    Response.Redirect(from);
                }
                else
                {
                    Response.Redirect("~/admin/welcome.aspx?name=" + tbUserName.Text);
                }
            }
            else
            {
                Response.Write("<script>alert('用户名或密码错误！')</script>");
            }
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('用户名或密码错误！')</script>");
        }
    }
}