<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/admin/MasterPage.master" CodeFile="listMember.aspx.cs" Inherits="Manage_listMember" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"
        onrowdeleting="GridView1_RowDeleting" onrowediting="GridView1_RowEditing" 
         Width="739px" onrowupdating="GridView1_RowUpdating" 
        onrowdatabound="GridView1_RowDataBound" AllowPaging="True" 
        AllowSorting="True" BackColor="White" BorderColor="#336666" 
        BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" 
        onpageindexchanging="GridView1_PageIndexChanging" 
        onselectedindexchanged="GridView1_SelectedIndexChanged" 
        PageSize="5" Height="229px">
        <Columns>
            <asp:BoundField DataField="memberID" HeaderText="届数+学号" />
            <asp:BoundField DataField="memberName" HeaderText="姓名" />
            <asp:BoundField DataField="memberEntranceYear" HeaderText="入学年份" />
            <asp:BoundField DataField="memberNum" HeaderText="学号（完整）" />
            <asp:BoundField DataField="IDName" HeaderText="昵称" />
            <asp:BoundField DataField="ImageURL" HeaderText="照片地址" />
            <asp:BoundField DataField="createTime" HeaderText="创建时间" />
            <asp:BoundField DataField="hobby" HeaderText="兴趣爱好" />
            <asp:BoundField DataField="introduction" HeaderText="自我介绍" />
            <asp:BoundField DataField="motto" HeaderText="格言" />
            <asp:BoundField DataField="deleteFlag" HeaderText="表示是否删除" />
            <asp:BoundField DataField="isWorking" HeaderText="表示是否现役" />
            <asp:CommandField ShowEditButton="True" ButtonType="Button" />
            <asp:CommandField ShowDeleteButton="True" ButtonType="Button" />

        </Columns>

        <FooterStyle BackColor="White" ForeColor="#333333" />
        <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F7F7F7" />
        <SortedAscendingHeaderStyle BackColor="#487575" />
        <SortedDescendingCellStyle BackColor="#E5E5E5" />
        <SortedDescendingHeaderStyle BackColor="#275353" />

    </asp:GridView>
    </asp:Content>


  