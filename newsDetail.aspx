<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="newsDetail.aspx.cs" Inherits="newsDetail_newsDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>绿荫网-新闻展示</title>
    <link href="detail.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <div class="main">
            <div class="title">
                <asp:Label ID="lblTitle" runat="server" Text="Label"></asp:Label>
            </div>
        <div class="main_page">
            <asp:Label ID="lblContents" runat="server" Text="Label"></asp:Label>
        </div>
        <div class="time_num">
            上传时间：<asp:Label ID="lblUploadtime" runat="server" Text="Label"></asp:Label><br />
            点击次数：<asp:Label ID="lblCount" runat="server" Text="Label"></asp:Label></div>
    </div>
</asp:Content>
