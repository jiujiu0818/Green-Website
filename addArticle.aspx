﻿<%@ Page Title="" Language="C#"  AutoEventWireup="true" CodeFile="addArticle.aspx.cs" Inherits="addArticle" %><%@ Register assembly="FreeTextBox" namespace="FreeTextBoxControls" tagprefix="FTB" %><html xmlns="http://www.w3.org/1999/xhtml">
<head  runat="server">
    <title>文章上传系统</title>
</head> <body>
    <form id="form1" runat="server">     <table style="width:100%;">    <tr>        <td colspan="3">文章上传系统</td>    </tr>    <tr>        <td>题目：</td>        <td><asp:TextBox ID="txttitle" runat="server"></asp:TextBox></td>           <td>&nbsp;</td>        <td>&nbsp;</td>    </tr>    <tr>    <td>图片:</td><td>        <asp:FileUpload ID="FileUpload1" runat="server" />    </tr>    <tr>        <td>类别：</td>        <td><asp:DropDownList ID="ddcategory" runat="server" AutoPostBack="True">            <asp:ListItem Value="0">新闻</asp:ListItem>            <asp:ListItem Value="1">体育</asp:ListItem>            <asp:ListItem Value="2">超人</asp:ListItem>            </asp:DropDownList>            </td>    </tr>    <tr>        <td>内容</td>        <td>            <FTB:FreeTextBox ID="FreeTextBox1" runat="server"></FTB:FreeTextBox>        </td>    </tr>    <tr>        <td></td>        <td><asp:Button ID="btnsave" runat="server" Text="确定"  onclick="btnsave_Click" AccessKey="s"></asp:Button></td>    </tr>    </table> 
    </form>
</body>
</html>