﻿<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="addArticle.aspx.cs" Inherits="addArticle" %>

<%@ Register assembly="FreeTextBox" namespace="FreeTextBoxControls" tagprefix="FTB" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <table style="width:100%;">
    <tr>        <td colspan="3">文章上传系统</td>    </tr>    <tr>        <td>题目：</td>        <td><asp:TextBox ID="txttitle" runat="server"></asp:TextBox></td>           <td>&nbsp;</td>        <td>&nbsp;</td>    </tr>    <tr>    <td>图片:</td><td>        <asp:FileUpload ID="FileUpload1" runat="server" />
    </tr>    <tr>        <td>类别：</td>        <td><asp:DropDownList ID="ddcategory" runat="server" AutoPostBack="True">            <asp:ListItem Value="0">新闻</asp:ListItem>            <asp:ListItem Value="1">体育</asp:ListItem>            <asp:ListItem Value="2">超人</asp:ListItem>            </asp:DropDownList>        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="添加分类：" onclick="Button1_Click" />
&nbsp;
            <asp:Panel ID="Panel1" runat="server" Visible="False">
                请输入新类别：<asp:TextBox ID="TextBox1" runat="server" style="margin-left: 0px"></asp:TextBox>
                <asp:Button ID="Button2" runat="server" Text="确定添加" Height="21px" 
                    onclick="Button2_Click" />
            </asp:Panel>
        </td>    </tr>    <tr>        <td>内容</td>        <td>            <FTB:FreeTextBox ID="FreeTextBox1" runat="server"></FTB:FreeTextBox>        </td>    </tr>    <tr>        <td></td>        <td><asp:Button ID="btnsave" runat="server" Text="确定" conclick                 onclick="btnsave_Click" AccessKey="a"></asp:Button></td>    </tr>    </table>
   
   
    </asp:Content>

