<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true"
    CodeFile="addApplicant.aspx.cs" Inherits="joinUs_addapplicant" %>

<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .style1
        {
            width: 167px;
        }
        .style2
        {
            width: 370px;
        }
        .style3
        {
            height: 42px;
        }
        .style4
        {
            width: 370px;
            height: 42px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table style="width: 188px; height: 496px">
        <tr>
            <td colspan="2">
                在线报名
            </td>
            <tr>
                <td>
                    输入姓名：
                </td>
                <td class="style2">
                    <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    学号（1405···）：
                </td>
                <td class="style2">
                    <asp:TextBox ID="TxtNum" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    入学年份：
                </td>
                <td class="style2">
                    <asp:TextBox ID="TxtYear" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    专业：
                </td>
                <td class="style2">
                    <asp:DropDownList ID="DpMajor" runat="server">
                        <asp:ListItem Value="0">计软</asp:ListItem>
                        <asp:ListItem Value="1">计算机</asp:ListItem>
                        <asp:ListItem Value="2">电子</asp:ListItem>
                        <asp:ListItem Value="3">通信</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;&nbsp; 班级：<asp:DropDownList ID="DpClass" runat="server">
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    邮箱：
                </td>
                <td class="style2">
                    <asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    QQ：
                </td>
                <td class="style2">
                    <asp:TextBox ID="TxtQQ" runat="server"></asp:TextBox>
                </td>
                <tr>
                    <td>
                        电话：
                    </td>
                    <td class="style2">
                        <asp:TextBox ID="TxtPhoneNum" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                        所选方向：
                    </td>
                    <td class="style2">
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem Value="1">前台</asp:ListItem>
                            <asp:ListItem Value="2">后台</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        自我介绍：
                    </td>
                    <td class="style2">
                        <asp:TextBox ID="TxtIntroduction" runat="server" TextMode="MultiLine" 
                            Height="233px" Width="466px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style3">
                        &nbsp;</td>
                    <td class="style4">
                        &nbsp;
                        <asp:Button ID="ButtonSubmit" runat="server" OnClick="ButtonSubmit_Click" Text="确定提交" />
                    </td>
                </tr>
            </tr>
    </table>
</asp:Content>
