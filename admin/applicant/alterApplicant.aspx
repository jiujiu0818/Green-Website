<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="alterApplicant.aspx.cs" Inherits="jionUs_alterApplicant" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>    <tr>        <td colspan="3">在线报名</td>       <tr>        <td>输入姓名：</td>        <td class="style2"><asp:TextBox ID="TxtName" runat="server"></asp:TextBox></td>    </tr>    <tr>        <td>学号（1405···）：</td>        <td class="style2"><asp:TextBox ID="TxtNum" runat="server"></asp:TextBox></td>    </tr>    <tr>        <td>入学年份：</td>        <td class="style2"><asp:TextBox ID="TxtYear" runat="server"></asp:TextBox></td>    </tr>    <tr>        <td>专业：</td>        <td class="style2"><asp:DropDownList ID="DpMajor" runat="server">            <asp:ListItem Value="0">计软</asp:ListItem>            <asp:ListItem Value="1">计算机</asp:ListItem>            <asp:ListItem Value="2">电子</asp:ListItem>             <asp:ListItem Value="3">通信</asp:ListItem>            </asp:DropDownList>               &nbsp;&nbsp;               班级：<asp:DropDownList ID="DpClass" runat="server">                <asp:ListItem>1</asp:ListItem>                <asp:ListItem>2</asp:ListItem>                <asp:ListItem>3</asp:ListItem>                <asp:ListItem>4</asp:ListItem>            </asp:DropDownList>        </td>    </tr>    <tr>        <td>邮箱：</td>        <td class="style2">            <asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox>        </td>    </tr>    <tr>        <td>QQ：</td>        <td class="style2">            <asp:TextBox ID="TxtQQ" runat="server"></asp:TextBox>        </td>         <tr>        <td>电话：</td>        <td class="style2">            <asp:TextBox ID="TxtPhoneNum" runat="server"></asp:TextBox>        </td>    </tr>     <tr>        <td class="style1">所选方向：</td>        <td class="style3">                        <asp:DropDownList ID="DpSelectedPart" runat="server">
                <asp:ListItem Value="1">前台</asp:ListItem>
                <asp:ListItem Value="2">后台</asp:ListItem>
                <asp:ListItem Value="3">美工</asp:ListItem>
            </asp:DropDownList>
            
        </td>    </tr>      <tr>        <td>自我介绍：</td>        <td class="style2">                        <asp:TextBox ID="TxtIntroduction" runat="server" TextMode="MultiLine" 
                Height="146px" Width="499px"></asp:TextBox>                    </td>    </tr>     <tr>               <td>                        <asp:Button ID="ButtonSubmit" runat="server" onclick="ButtonSubmit_Click"                 Text="确定修改" />                    </td>    </tr>    </tr>    </table>
</asp:Content>

