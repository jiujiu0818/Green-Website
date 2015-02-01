<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="articleList.aspx.cs" Inherits="articleList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        onrowdeleting="GridView1_RowDeleting" onrowediting="GridView1_RowEditing" >
       <Columns>
       <asp:BoundField DataField="articleID" HeaderText="ID" />
            <asp:TemplateField HeaderText="文章列表">
                <ItemTemplate>
                    <asp:HyperLink ID="Hlink" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"title") %>' NavigateUrl='<%#"~/admin/news/articlemanage.aspx?id="+DataBinder.Eval(Container.DataItem,"articleID")%>'></asp:HyperLink>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:CommandField ShowDeleteButton="True" />
            <asp:CommandField ShowEditButton="True" />
       </Columns>
    </asp:GridView>
</asp:Content>

