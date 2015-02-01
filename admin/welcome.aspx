<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="welcome.aspx.cs" Inherits="admin_welcome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<p style="font-family: 楷体; font-size: xx-large; color: #0066FF;" align="center">欢迎你，<%=Request.QueryString["name"] %></p>
</asp:Content>

