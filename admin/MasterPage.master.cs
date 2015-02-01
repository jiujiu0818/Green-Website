using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
            if (Session["userInfo"] == null)
                Response.Redirect("~/admin/greenLogin.aspx?from="+Request.Url.AbsoluteUri);
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session["userInfo"] = null;
        Response.Write("<script>self.close();</script>");
    }
}
