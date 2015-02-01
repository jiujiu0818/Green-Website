using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class newsDetail_newsDetail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = Request.QueryString["id"];
        string sqlstr = "select * from [Article] where articleID='" + id + "'";
        SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GrnetConnectionString"].ToString());
        SqlDataAdapter da = new SqlDataAdapter(sqlstr, conn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            lblTitle.Text = ds.Tables[0].Rows[0]["title"].ToString();
            lblContents.Text = Server.HtmlDecode(ds.Tables[0].Rows[0]["contents"].ToString());
            lblUploadtime.Text = ds.Tables[0].Rows[0]["uploadtime"].ToString();
            lblCount.Text = ds.Tables[0].Rows[0]["count"].ToString();
            int cnt = Convert.ToInt32(ds.Tables[0].Rows[0]["count"].ToString());

            cnt++;
            string addCount = "update [Article] set count='" + cnt + "' where articleID='" + id + "'";
            conn.Open();
            SqlCommand comm = new SqlCommand(addCount, conn);
            comm.ExecuteNonQuery();
        }
        conn.Close();
    }
}