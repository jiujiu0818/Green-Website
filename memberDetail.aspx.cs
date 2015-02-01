using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class 成员介绍_member_member1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
         int id = Convert.ToInt32(Request.Params["id"]);
         if (id == 0)
         {
             Response.Redirect("~/Default.aspx");
         }
        ViewState["id"] = id;
       string str=ViewState["id"].ToString();
       string conStr = System.Configuration.ConfigurationManager.ConnectionStrings["GrnetConnectionString"].ToString();//连接数据库字符串
        string strSql = "SELECT * FROM [member] WHERE memberID= '"+str+"' ";
        //创建一个数据库连接
        SqlConnection sqlconn = new SqlConnection(conStr);
        SqlDataAdapter da = new SqlDataAdapter(strSql, sqlconn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            try
            {

                Label1.Text = ds.Tables[0].Rows[0]["memberName"].ToString();
                Label5.Text = ds.Tables[0].Rows[0]["introduction"].ToString();
                Image1.ImageUrl = ds.Tables[0].Rows[0]["ImageURL"].ToString();
                Label2.Text = ds.Tables[0].Rows[0]["memberID"].ToString();
                Label3.Text = ds.Tables[0].Rows[0]["motto"].ToString();
                Label4.Text = ds.Tables[0].Rows[0]["hobby"].ToString();

            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }
    }
    }
