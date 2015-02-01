﻿using System;
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
 
 */