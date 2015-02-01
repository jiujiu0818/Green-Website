using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Manage_listMember : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Bind();
    }
    public void Bind()
    {
        string conStr = System.Configuration.ConfigurationManager.ConnectionStrings["GrnetConnectionString"].ToString();
        SqlConnection Conn = new SqlConnection(conStr);
        string sqlStr = "SELECT * FROM [member] where deleteFlag='false'";
        SqlDataAdapter Da = new SqlDataAdapter(sqlStr,Conn);
        DataSet Ds = new DataSet();
        Da.Fill(Ds);
        //把数据库绑定到GridView1
        GridView1.DataSource = Ds.Tables[0];
        GridView1.DataBind();
    }
    //删除
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string id = GridView1.Rows[e.RowIndex].Cells[0].Text.ToString();
        string sqlStr = "update [member]  set deleteFlag='true' WHERE memberID='" + id + "'";
        SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GrnetConnectionString"].ToString());
        conn.Open();
        SqlCommand comm = new SqlCommand(sqlStr, conn);
        comm.ExecuteNonQuery();
        GridView1.DataBind();
       // Response.Redirect("listMember.aspx");
        //conn.Close();
        //删除后再次邦定
       // Bind();
    }
    //编辑
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        string id = GridView1.Rows[e.NewEditIndex].Cells[0].Text.ToString();
      Response.Redirect("altermember.aspx?id="+id+"");
        GridView1.EditIndex = e.NewEditIndex;
        Bind();
    }
    //更新
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GrnetConnectionString"].ToString());
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        int i;
        //执行循环，保证每条数据都可以更新
        for (i = 0; i <= GridView1.Rows.Count; i++)
        {
            //首先判断是否是数据行
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //当鼠标停留时更改背景色
                e.Row.Attributes.Add("onmouseover", "c=this.style.backgroundColor;this.style.backgroundColor='#00A9FF'");
                //当鼠标移开时还原背景色
                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=c");
            }
        }
        if (e.Row.RowType == DataControlRowType.DataRow)
            e.Row.Cells[13].Attributes.Add("onclick", "javascript:return confirm('你确认要删除吗？')");//13为“删除”所在的列号
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        //GridView1.DataSource = "";
        GridView1.DataBind();
    }
}