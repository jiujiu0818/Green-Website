using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Timers;
using System.IO;

public partial class articlemanage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string id = Request.QueryString["id"];
            string conStr = System.Configuration.ConfigurationManager.ConnectionStrings["GrnetConnectionString"].ToString();
            SqlConnection Conn = new SqlConnection(conStr);
            string sqlStr = "select * from [Article] where articleID ='" + id + "' ";
            SqlDataAdapter Da = new SqlDataAdapter(sqlStr, Conn);
            DataSet Ds = new DataSet();
           
                try
                {
                    Da.Fill(Ds);
                     txttitle.Text = Ds.Tables[0].Rows[0]["title"].ToString();

                        FreeTextBox1.Text =Server.HtmlDecode(Ds.Tables[0].Rows[0]["contents"].ToString());
                        ddcategory.SelectedItem.Text = Ds.Tables[0].Rows[0]["article_category"].ToString();
                        //Image1.ImageUrl ="~/newsImage"+Ds.Tables[0].Rows[0]["imageUrl"].ToString();
                        Image1.ImageUrl = Ds.Tables[0].Rows[0]["imageUrl"].ToString();
                    }
                
                catch (SqlException ex)
                {
                    Response.Write(ex.Message);
                }
               

            }
        }
    
   
    protected void btnsave_Click(object sender, EventArgs e)
    {
        //if (FileUpload1.PostedFile.FileName == "")
        //{
        //    Response.Write("<script type='text/JavaScript'>alert('请上传图片！'); </script>");
        //    Response.Write("<script type='text/javascript'>location.href=location.href;</script>");
        //}
        string imagename = this.FileUpload1.FileName;
        if (imagename != "")
        {
            string path = Server.MapPath("~/newsImage/photo/");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            FileUpload1.PostedFile.SaveAs(path + imagename);
        }

       string id = Request.QueryString["id"];
        string conStr =System.Configuration.ConfigurationManager.ConnectionStrings["GrnetConnectionString"].ToString();
        SqlConnection Conn = new SqlConnection(conStr);
        string sqlStr;
        if (imagename != "")
        sqlStr = "update [Article] set title='" + txttitle.Text + "',article_category='" + ddcategory.SelectedItem.Text + "',contents='" + Server.HtmlEncode(FreeTextBox1.Text) + "',uploadtime='" + DateTime.Now + "',imageUrl='" + "~/newsImage/photo/" + imagename + "' where articleID='" + id + "'";
        else
            sqlStr = "update [Article] set title='" + txttitle.Text + "',article_category='" + ddcategory.SelectedItem.Text + "',contents='" + Server.HtmlEncode(FreeTextBox1.Text) + "',uploadtime='" + DateTime.Now + "' where articleID='" + id + "'";
        //string sqlStr = "update [Article] (writer,title,category,contents,uploadername,uploadtime) values('"+txtwriter.Text+"','"+txttitle.Text+"','"+ddcategory.SelectedItem.Value+"','"+FreeTextBox1.Text+"','"+ txtuploader.Text+"','"+DateTime.Now +"'where article='"+id+"')";
        Conn .Open ();
        SqlCommand  Comm=new SqlCommand (sqlStr,Conn);
        Comm.ExecuteNonQuery();
        Conn.Close ();
        Response.Write ("<script>alert('保存成功！')</script>");
        SqlDataAdapter Da=new SqlDataAdapter(sqlStr,Conn);

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
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
}