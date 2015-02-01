using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;


public partial class addArticle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        if (FileUpload1.FileName == ""||txttitle.Text=="")
        {
            Response.Write("<script type='text/JavaScript'>alert('请填全文章信息！'); </script>");
            Response.Write("<script type='text/javascript'>location.href=location.href;</script>");
        }
            string imagename = DateTime.Now.ToString("yymmddhhmmss") + this.FileUpload1.FileName;
            string path = Server.MapPath("~/newsImage/photo");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            FileUpload1.SaveAs(path + '\\' + imagename);

            string strConn = System.Configuration.ConfigurationManager.ConnectionStrings["GrnetConnectionString"].ToString();
            SqlConnection Conn = new SqlConnection(strConn);//连接数据库
            Conn.Open();//打开数据库
        try
        {
            string sqlStr = "INSERT INTO [Article](title,article_category,contents,uploadtime,count,imageUrl)Values(@title,@article_category,@contents,@uploadtime,@count,@imageUrl)";
            SqlCommand Comm = new SqlCommand(sqlStr, Conn);
            Comm.Parameters.Add("@title", SqlDbType.NVarChar, 100);
            Comm.Parameters.Add("@article_category", SqlDbType.NVarChar, 30);
            Comm.Parameters.Add("@contents", SqlDbType.Text);
            Comm.Parameters.Add("@uploadtime", SqlDbType.DateTime);
            Comm.Parameters.Add("@count", SqlDbType.Int);
            Comm.Parameters.Add("@imageUrl", SqlDbType.NVarChar, 200);
            Comm.Parameters["@title"].Value = txttitle.Text;
            Comm.Parameters["@article_category"].Value = ddcategory.SelectedItem.Text;
            Comm.Parameters["@contents"].Value = Server.HtmlEncode(FreeTextBox1.Text);
            Comm.Parameters["@uploadtime"].Value = DateTime.Now;
            Comm.Parameters["@count"].Value = 1;
            Comm.Parameters["@imageUrl"].Value = "~/newsImage/photo/" + imagename;
            Comm.ExecuteNonQuery();
            Response.Write("<script>alert('upload success!');location.href=location.href</script>");
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
        finally
        {
            Conn.Close();
        }
    }
}