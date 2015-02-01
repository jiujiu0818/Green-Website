using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data; 
using System.Data.SqlClient;//操作数据库时要用到的名称空间（C#中，名称空间类似于C++里的#include<sth.h>
using System.Configuration;
using System.IO;


public partial class addArticle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        if (FileUpload1.FileName == ""||txttitle.Text=="")//判断用户是否上传了图片、填写了标题
        {
            Response.Write("<script type='text/JavaScript'>alert('请填全文章信息！'); </script>");
            //Response.Write()方法用于向客户端浏览器输出信息，可以输出普通的文字，也可以输出js代码（一种运行于浏览器的脚本程序）
            Response.Write("<script type='text/javascript'>location.href=location.href;</script>");
            //<script type='text/javascript'>location.href=location.href;</script>这段js表示刷新客户端页面
        }
            string imagename = DateTime.Now.ToString("yymmddhhmmss") + this.FileUpload1.FileName;
        //通过将图片名称与当前时间绑定来保证文件名的唯一性，不然的话，同名图片将被覆盖。
            string path = Server.MapPath("~/newsImage/photo");
            //Server.MapPath()方法，根据虚拟路径获取物理路径，就是将上述路径转化成比如D:\GRNET\newsImage\photo的形式
            if (!Directory.Exists(path))//如果不存在该文件，创建之
            {
                Directory.CreateDirectory(path);
            }
            FileUpload1.SaveAs(path + '\\' + imagename);
            //通过FileUpload1.SaveAs()方法，将上传的图片保存在“path + '\\' + imagename”目录下
            string strConn = System.Configuration.ConfigurationManager.ConnectionStrings["GrnetConnectionString"].ToString();
            //通过ConfigurationManager.ConnectionStrings["GrnetConnectionString"]获取web.config文件（在网站根目录下）中存放的数据库连接字符串
            //strConn实际上是"Data Source=.;Initial Catalog=Grnet;Integrated Security=True"，请到web.cofig中自行查看
            //其中，“Data Source=.”表示数据库存在于本地服务器，“Initial Catalog=Grnet”表示连接到名为Grnet的数据库，
            //“Integrated Security=True”表示通过windows身份认证连接（另外一个方式就是提供登陆数据库系统用的账号和密码）
            SqlConnection Conn = new SqlConnection(strConn);//通过SqlConnection对象连接数据库
            Conn.Open();//打开数据库
        try//try-catch块用于异常处理，跟C++类似
        {
            string sqlStr = "INSERT INTO [Article](title,article_category,contents,uploadtime,count,imageUrl)Values(@title,@article_category,@contents,@uploadtime,@count,@imageUrl)";
            //上句为sql语句，用于添加数据到数据库中，其中的@title表示参数，将在下文中进行传参
            SqlCommand Comm = new SqlCommand(sqlStr, Conn);
            //SqlCommand对象用于真正地执行上述sql语句
            Comm.Parameters.Add("@title", SqlDbType.NVarChar, 100);//为SqlCommand对象定义参数，下同
            Comm.Parameters.Add("@article_category", SqlDbType.NVarChar, 30);
            Comm.Parameters.Add("@contents", SqlDbType.Text);
            Comm.Parameters.Add("@uploadtime", SqlDbType.DateTime);
            Comm.Parameters.Add("@count", SqlDbType.Int);
            Comm.Parameters.Add("@imageUrl", SqlDbType.NVarChar, 200);
            Comm.Parameters["@title"].Value = txttitle.Text;//将用户在前台页面填写的数据赋值给sql语句参数
            Comm.Parameters["@article_category"].Value = ddcategory.SelectedItem.Text;
            Comm.Parameters["@contents"].Value = Server.HtmlEncode(FreeTextBox1.Text);
            Comm.Parameters["@uploadtime"].Value = DateTime.Now;
            Comm.Parameters["@count"].Value = 1;
            Comm.Parameters["@imageUrl"].Value = "~/newsImage/photo/" + imagename;
            Comm.ExecuteNonQuery();
            //执行数据库操作
            Response.Write("<script>alert('upload success!');location.href=location.href</script>");
            //客户端弹出对话框，提示上传成功
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
        finally
        {
            Conn.Close();//关闭数据库，释放服务器相关资源，大家要养成这个好习惯^_^
        }
    }
}