<%@ Page Title=""  ValidateRequest="false" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="articlemanage.aspx.cs" Inherits="articlemanage" %>

<%@ Register assembly="FreeTextBox" namespace="FreeTextBoxControls" tagprefix="FTB" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            height: 18px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style ="width:100%;">
<tr>
        <td colspan="3">文章上传系统</td>
    </tr>
    <tr>
        <td>题目：</td>
        <td><asp:TextBox ID="txttitle" runat="server"></asp:TextBox></td>
    
    </tr>
    <tr> <td>图片：</td> <td>
        <asp:Image ID="Image1" runat="server" />
        <asp:FileUpload ID="FileUpload1" runat="server" />
        </td>
    </tr>
    <tr>
        <td>类别：</td>
        <td><asp:DropDownList ID="ddcategory" runat="server">
            <asp:ListItem Value="0">新闻</asp:ListItem>
            <asp:ListItem Value="1">体育</asp:ListItem>
            <asp:ListItem Value="2">超人</asp:ListItem>
            </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;            
            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="添加分类" />
            <asp:Panel ID="Panel1" runat="server" Visible="False">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:Button ID="Button2" runat="server" Text="Button" onclick="Button2_Click" />
            </asp:Panel>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>内容</td>
        <td>
            <FTB:FreeTextBox ID="FreeTextBox1" runat="server"></FTB:FreeTextBox>
            <td>
                &nbsp;</td></td>
    </tr>
    <tr>
        <td class="style1"></td>
        <td class="style1">
            <asp:Button ID="btnsave" runat="server" Text="确定" conclick 
                AccessKey="a" onclick="btnsave_Click"></asp:Button></td>    </tr>
</asp:Content>

