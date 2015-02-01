using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;


public partial class Manage_addMember : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    
    protected void submit_Click(object sender, EventArgs e)
    {
        //string path=UploadFile();
        //string conStr = @"Data Source=.;Initial Catalog=Grnet;Integrated Security=True";
        //SqlConnection Conn= new SqlConnection(conStr);
        //string sqlStr = "INSERT INTO[member](memberID,memberName,memberEntranceYear,memberNum,IDName,ImageURL,createTime,hobby,introduction,motto,isWorking) VALUES('@TxtID','@TxtName','@TxtYear','@TxtNum','@TxtIDName','@ImageURL','@createTime','@TxtHobby','@FreeTextBox1','@TxtMotto','0','1')";
        //SqlCommand Comn = new SqlCommand(sqlStr, Conn);
        //Comn.CommandText = "addMember";
        //Comn.CommandType = CommandType.StoredProcedure;
        //SqlParameter parm0= new SqlParameter("TxtID", SqlDbType.NVarChar,100);
        //parm0.Value = this.TxtYear.Text + this.TxtNum.Text;
        //SqlParameter parm1 = new SqlParameter("@TxtName", SqlDbType.NVarChar,100);
        //parm1.Value =this.TxtName.Text;
        //SqlParameter parm2 = new SqlParameter("@TxtYear", SqlDbType.Int);
        //parm2.Value =Convert.ToInt32(this.TxtYear.Text); 
        //SqlParameter parm3 = new SqlParameter("@TxtNum", SqlDbType.NVarChar,30);
        //parm3.Value = this.TxtNum.Text;
        //SqlParameter parm4= new SqlParameter("@TxtIDName", SqlDbType.NVarChar,100);
        //parm4.Value = this.TxtIDName.Text;
        //SqlParameter parm5 = new SqlParameter("@TxtMotto", SqlDbType.NVarChar, 30);
        //parm5.Value = this.TxtMotto.Text;
        //SqlParameter parm6 = new SqlParameter("@TxtHobby", SqlDbType.NVarChar,500);
        //parm6.Value = this.TxtHobby.Text;
        // SqlParameter parm7= new SqlParameter("@FreeTextBox1",SqlDbType.NVarChar,500);
        // parm7.Value =this.FreeTextBox1.Text;
        // SqlParameter parm8= new SqlParameter("@ImageURL", SqlDbType.NVarChar,200);
        // parm8.Value =path;
        //SqlParameter parm9= new SqlParameter("@createTime", SqlDbType.DateTime);
        //parm9.Value =DateTime.Now.ToString();
        //Comn.Parameters.Add(parm0);
        //Comn.Parameters.Add(parm1);
        //Comn.Parameters.Add(parm2);
        //Comn.Parameters.Add(parm3);
        //Comn.Parameters.Add(parm4);
        //Comn.Parameters.Add(parm5);
        //Comn.Parameters.Add(parm6);
        //Comn.Parameters.Add(parm7);
        //Comn.Parameters.Add(parm8);
        //Comn.Parameters.Add(parm9);
        //Conn.Open();
        //Comn.ExecuteNonQuery();
        //Conn.Close();
        //Response.Write("上传成功");
        if (FileUpload1.PostedFile.FileName == "")
        {
            Response.Write("<script type='text/JavaScript'>alert('请上传图片！'); </script>");
            Response.Write("<script type='text/javascript'>location.href=location.href;</script>");
        }
        string imagename = this.FileUpload1.FileName;
        string path = Server.MapPath("~/成员介绍/memberpicture/");
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
        FileUpload1.PostedFile.SaveAs(path +imagename);

        string strConn = System.Configuration.ConfigurationManager.ConnectionStrings["GrnetConnectionString"].ToString();
        SqlConnection Conn = new SqlConnection(strConn);//连接数据库
        Conn.Open();//打开数据库
        string sqlStr = "INSERT INTO[member](memberID,memberName,memberEntranceYear,memberNum,IDName,ImageURL,createTime,hobby,introduction,motto,deleteFlag,isWorking) VALUES('" + TxtNum.Text + "','" + TxtName.Text + "','" + TxtYear.Text + "','" + TxtNum.Text + "','" + TxtIDName.Text + "','" + "~/成员介绍/memberpicture/" + imagename + "','" + DateTime.Now + "','" + TxtHobby.Text + "','" + FreeTextBox1.Text + "','" + TxtMotto.Text + "','0','1')";
        //string sqlStr = "INSERT INTO [Article](title,article_category,contents,uploadtime,imageUrl)Values('" + txttitle.Text + "','" + ddcategory.SelectedItem.Text + "','" + FreeTextBox1.Text + "','" + DateTime.Now + "','" + "~/newsImage/photo/" + imagename + "')";
        SqlCommand Comm = new SqlCommand(sqlStr, Conn);
        try
        {
            Comm.ExecuteNonQuery();
            Response.Write("<script>alert('upload success!')</script>");
        }
        catch (Exception ex)
        { Response.Write(ex); }
     }
}