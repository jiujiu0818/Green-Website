<%@ Page Title="" Language="C#" AutoEventWireup="true" MasterPageFile="~/admin/MasterPage.master" CodeFile="addMember.aspx.cs" Inherits="Manage_addMember" %>

<%@ Register Assembly="FreeTextBox" Namespace="FreeTextBoxControls" TagPrefix="FTB" %>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <table style="width: 100%; height: 452px; margin-bottom: 0px;">
        <tr>
            <td class="style1">
                姓名：
            </td>
            <td>
                <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style1">
                入学年份：
            </td>
            <td>
                <asp:TextBox ID="TxtYear" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style1">
                学号(完整)：
            </td>
            <td>
                <asp:TextBox ID="TxtNum" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style1">
                昵称：
            </td>
            <td>
                <asp:TextBox ID="TxtIDName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style1">
                格言：
            </td>
            <td>
                <asp:TextBox ID="TxtMotto" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style1">
                爱好：
            </td>
            <td>
                <asp:TextBox ID="TxtHobby" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style1">
                靓照：</td>
            <td>
                <asp:FileUpload ID="FileUpload1" runat="server"/>
            </td>
        </tr>
        <tr>
            <td class="style1">
                介绍：
            </td>
            <td>
                <FTB:FreeTextBox ID="FreeTextBox1" runat="server" Height="210px">
                </FTB:FreeTextBox>
</td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td>
                <asp:Button ID="submit" runat="server" Text="提交" onclick="submit_Click" />
            </td>
        </tr>
    </table>
    <br />
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .style1
        {
            width: 75px;
        }
    </style>
</asp:Content>

