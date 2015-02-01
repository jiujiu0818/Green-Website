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
        if (FileUpload1.FileName == "")
        {
            Response.Write("<script type='text/JavaScript'>alert('请上传图片！'); </script>");
            Response.Write("<script type='text/javascript'>location.href=location.href;</script>");
        }
        string imagename = DateTime.Now.ToString("yymmddhhmmss")+this.FileUpload1.FileName;
        string path = Server.MapPath("~/newsImage/photo");
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
        FileUpload1.SaveAs(path + '\\' + imagename);

        string strConn = System.Configuration.ConfigurationManager.ConnectionStrings["GrnetConnectionString"].ToString();
        SqlConnection Conn = new SqlConnection(strConn);//连接数据库
        Conn.Open();//打开数据库
        string sqlStr = "INSERT INTO [Article](title,article_category,contents,uploadtime,count,imageUrl)Values('" + txttitle.Text + "','" + ddcategory.SelectedItem.Text + "','" + Server.HtmlEncode(FreeTextBox1.Text) + "','" + DateTime.Now + "',1,'" + "~/newsImage/photo/" + imagename + "')";
        SqlCommand Comm = new SqlCommand(sqlStr, Conn);
        Comm.ExecuteNonQuery();
        Response.Write("<script>alert('upload success!')</script>");
       
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
       
        string ms = TextBox1.Text;
        if (ms != "")
        {
            ddcategory.Items.Add(ms );
            this.TextBox1.Text="";
            Panel1.Visible = false;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
    }
}