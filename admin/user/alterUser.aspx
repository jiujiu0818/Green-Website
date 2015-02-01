<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="alterUser.aspx.cs" Inherits="新登陆模块_alterUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        管理员姓名：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
        管理员密码：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="修改" />
    </p>
</asp:Content>

