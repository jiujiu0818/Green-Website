using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class admin_applicantList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["GrnetConnectionString"].ToString();//连接数据库字符串
            SqlConnection Conn = new SqlConnection(conString);//连接数据库
            string sqlStr = "SELECT * FROM applicant where deleteFlag = 'false'";
            SqlDataAdapter Da = new SqlDataAdapter(sqlStr, Conn);//打开数据库
            DataSet Ds = new DataSet();
            Da.Fill(Ds);
            GridViewList.DataSource = Ds.Tables[0];
            GridViewList.DataBind();
        }
    }
    protected void GridViewList_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string id = GridViewList.Rows[e.RowIndex].Cells[0].Text.ToString();
        string sqlstr = "update applicant set deleteFlag='true' where applicantID='" + id + "'";
        string conString = System.Configuration.ConfigurationManager.ConnectionStrings["GrnetConnectionString"].ToString();//连接数据库字符串
        SqlConnection Conn = new SqlConnection(conString);//连接数据库 
        Conn.Open();
        SqlCommand comm = new SqlCommand(sqlstr, Conn);
        comm.ExecuteNonQuery();
        GridViewList.DataBind();
        Response.Redirect("applicantList.aspx");
    }
    protected void GridViewList_RowEditing(object sender, GridViewEditEventArgs e)
    {
        string id=GridViewList.Rows[e.NewEditIndex].Cells[0].Text.ToString();
        Response.Redirect("alterApplicant.aspx?id="+id);
    }
}

/*
 using System;using System.Collections.Generic;using System.Linq;using System.Web;using System.Web.UI;using System.Web.UI.WebControls;using System.Data;using System.Data.SqlClient ;using System.Configuration;public partial class articleList : System.Web.UI.Page{    protected void Page_Load(object sender, EventArgs e)    {        Bind();    }    public void Bind()    {        //ArticleDataClassesDataContext ar = new ArticleDataClassesDataContext(ConfigurationManager.ConnectionStrings["GrnetConnectionString"].ToString());        /ar result = from r in ar.Article        //             select r;        //GridView1.DataSource = result;        //GridView1.DataBind();        string strConn = @"Data Source=.;Initial Catalog=Grnet;Integrated Security=True";        SqlConnection Conn = new SqlConnection(strConn);        string sqlStr = "select * from [Article]";        SqlDataAdapter Da = new SqlDataAdapter(sqlStr, Conn);        DataSet Ds = new DataSet();        Da.Fill(Ds);        GridView1.DataSource = Ds.Tables[0];       //GridView1.DataKeyNames = new string[] { "articleID" };//主键        GridView1.DataBind();    }    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)    {        string id = GridView1.Rows[e.RowIndex].Cells[0].Text.ToString();         //string id = GridView1.DataKeys[e.RowIndex].Value.ToString();        string sqlStr = "delete  from [Article] where articleID='" + id + "'";        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Grnet;Integrated Security=True;");        conn.Open();        SqlCommand comm = new SqlCommand(sqlStr, conn);        try        {            comm.ExecuteNonQuery();        }        catch (SqlException ex)        {            Response.Write(ex.Message);        }        finally        {            conn.Close();        }        Bind();    }    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)    {        string id = GridView1.Rows[e.NewEditIndex].Cells[0].Text.ToString();        Response.Redirect("articlemanage.aspx?id=" + id + "");    }}
 */