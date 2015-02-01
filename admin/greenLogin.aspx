<%@ Page Language="C#" AutoEventWireup="true" CodeFile="greenLogin.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 79px;
        }
        .style4
        {
            width: 229px;
        }
        .style5
        {
            width: 138px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 373px">
    
        <asp:Label ID="Label1" runat="server" Text="后台管理系统"></asp:Label>

        <br />
        <br />

        <table style="width: 55%;">
            <tr>
                <td class="style1">
        <asp:Label ID="Label2" runat="server" Text="管理员ID:"></asp:Label>
                </td>
                <td class="style4">
        <asp:TextBox ID="tbUserName" runat="server"></asp:TextBox>
                </td>
                <td class="style5">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ErrorMessage="请输入ID" ControlToValidate="tbUserName"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style1">
        <asp:Label ID="Label3" runat="server" Text="密码："></asp:Label>
                </td>
                <td class="style4">
        <asp:TextBox ID="tbPassword" runat="server" TextMode="Password" ></asp:TextBox>
                </td>
                <td class="style5">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ErrorMessage="请输入密码" ControlToValidate="tbPassword"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;</td>
                <td class="style4">
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="确定" />
                </td>
                <td class="style5">
                    &nbsp;</td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
