using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient ;
using System.Configuration;

public partial class articleList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Bind();
    }
    public void Bind()
    {
        //ArticleDataClassesDataContext ar = new ArticleDataClassesDataContext(ConfigurationManager.ConnectionStrings["GrnetConnectionString"].ToString());
        //var result = from r in ar.Article
        //             select r;
        //GridView1.DataSource = result;
        //GridView1.DataBind();
        string strConn = System.Configuration.ConfigurationManager.ConnectionStrings["GrnetConnectionString"].ToString();
        SqlConnection Conn = new SqlConnection(strConn);
        string sqlStr = "select * from [Article]";
        SqlDataAdapter Da = new SqlDataAdapter(sqlStr, Conn);
        DataSet Ds = new DataSet();
        Da.Fill(Ds);
        GridView1.DataSource = Ds.Tables[0];
       GridView1.DataKeyNames = new string[] { "articleID" };//主键
        GridView1.DataBind();
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string id = GridView1.Rows[e.RowIndex].Cells[0].Text.ToString();
        //string id = GridView1.DataKeys[e.RowIndex].Value.ToString();
        string sqlStr = "delete  from [Article] where articleID='" + id + "'";
        string strConn = System.Configuration.ConfigurationManager.ConnectionStrings["GrnetConnectionString"].ToString();
        SqlConnection conn = new SqlConnection(strConn);
        conn.Open();
        SqlCommand comm = new SqlCommand(sqlStr, conn);
        try
        {
            comm.ExecuteNonQuery();
        }
        catch (SqlException ex)
        {
            Response.Write(ex.Message);
        }
        finally
        {
            conn.Close();
        }
        Bind();

    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        string id = GridView1.Rows[e.NewEditIndex].Cells[0].Text.ToString();
        Response.Redirect("articlemanage.aspx?id=" + id + "");

    }
}