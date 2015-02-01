<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="applicantList.aspx.cs" Inherits="admin_applicantList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:GridView ID="GridViewList" runat="server" AutoGenerateColumns="False" 
        onrowdeleting="GridViewList_RowDeleting" onrowediting="GridViewList_RowEditing">
        <Columns>
            <asp:BoundField DataField="applicantID" HeaderText="申请人ID" />
            <asp:BoundField DataField="applicantName" HeaderText="姓名" />
            <asp:BoundField DataField="selectedPart" HeaderText="所选方向 1-美工 2-后台 " />
            <asp:CommandField ShowEditButton="True" EditText="查看/编辑" />
            <asp:CommandField ShowDeleteButton="True" />
        </Columns>
    </asp:GridView>

</asp:Content>

