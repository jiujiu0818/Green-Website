<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="memberDetail.aspx.cs" Inherits="成员介绍_member_member1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>绿荫网-成员详细信息</title>
<link href="memberintroduuction.css" rel="stylesheet" type="text/css" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

<div class="total">
	<div class="main_left">
		<div class="main_left_title"><font face="幼圆">个人介绍</div>
		<div class="main_left_body">
            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label></div>
	</div>
    <div class="line"><img src="1.jpg"></div>
	<div class="main_right">
		<div class="main_right_title"><font face="幼圆">
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></div>
		<div class="main_right_img">
            <asp:Image ID="Image1" runat="server" /></div>
		<div class="main_right_id">ID:<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></div>
		<div class="main_right_intro">
			<p>格言：<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></p>
			<p>个人爱好：<asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></p>
		</div>

	</div>
</div>

</asp:Content>

