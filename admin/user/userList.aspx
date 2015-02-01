<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="userList.aspx.cs" Inherits="新登陆模块_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        Height="292px" onrowdeleting="GridView1_RowDeleting1" 
        onrowediting="GridView1_RowEditing1" Width="474px">
        <Columns>
            <asp:BoundField DataField="userID" HeaderText="管理员ID" />
            <asp:BoundField DataField="userName" HeaderText="管理员姓名" />
            <asp:CommandField ShowEditButton="True" />
            <asp:CommandField ShowDeleteButton="True" />
        </Columns>
    </asp:GridView>
</asp:Content>

