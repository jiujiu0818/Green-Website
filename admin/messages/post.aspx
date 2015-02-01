<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="post.aspx.cs" Inherits="admin_messages_post" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
    AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="ID" 
    DataSourceID="SqlDataSource1">
    <Columns>
        <asp:CommandField ShowSelectButton="True" />
        <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" 
            ReadOnly="True" SortExpression="ID" />
        <asp:BoundField DataField="userName" HeaderText="userName" 
            SortExpression="userName" />
        <asp:BoundField DataField="sex" HeaderText="sex" SortExpression="sex" />
        <asp:BoundField DataField="url" HeaderText="url" SortExpression="url" />
        <asp:BoundField DataField="qq" HeaderText="qq" SortExpression="qq" />
        <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
        <asp:BoundField DataField="content" HeaderText="content" 
            SortExpression="content" />
        <asp:BoundField DataField="reply" HeaderText="reply" SortExpression="reply" />
        <asp:BoundField DataField="postTime" HeaderText="postTime" 
            SortExpression="postTime" />
        <asp:BoundField DataField="imageUrl" HeaderText="imageUrl" 
            SortExpression="imageUrl" />
        <asp:CommandField ShowDeleteButton="True" />
        <asp:CommandField ShowEditButton="True" />
    </Columns>
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" 
    ConnectionString="<%$ ConnectionStrings:GrnetConnectionString %>" 
    SelectCommand="SELECT * FROM [guest]" 
        DeleteCommand="DELETE FROM [guest] WHERE [ID] = @ID" 
        InsertCommand="INSERT INTO [guest] ([userName], [sex], [url], [qq], [email], [content], [reply], [postTime], [imageUrl]) VALUES (@userName, @sex, @url, @qq, @email, @content, @reply, @postTime, @imageUrl)" 
        UpdateCommand="UPDATE [guest] SET [userName] = @userName, [sex] = @sex, [url] = @url, [qq] = @qq, [email] = @email, [content] = @content, [reply] = @reply, [postTime] = @postTime, [imageUrl] = @imageUrl WHERE [ID] = @ID">
    <DeleteParameters>
        <asp:Parameter Name="ID" Type="Int32" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="userName" Type="String" />
        <asp:Parameter Name="sex" Type="String" />
        <asp:Parameter Name="url" Type="String" />
        <asp:Parameter Name="qq" Type="String" />
        <asp:Parameter Name="email" Type="String" />
        <asp:Parameter Name="content" Type="String" />
        <asp:Parameter Name="reply" Type="String" />
        <asp:Parameter Name="postTime" Type="DateTime" />
        <asp:Parameter Name="imageUrl" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="userName" Type="String" />
        <asp:Parameter Name="sex" Type="String" />
        <asp:Parameter Name="url" Type="String" />
        <asp:Parameter Name="qq" Type="String" />
        <asp:Parameter Name="email" Type="String" />
        <asp:Parameter Name="content" Type="String" />
        <asp:Parameter Name="reply" Type="String" />
        <asp:Parameter Name="postTime" Type="DateTime" />
        <asp:Parameter Name="imageUrl" Type="String" />
        <asp:Parameter Name="ID" Type="Int32" />
    </UpdateParameters>
</asp:SqlDataSource>
</asp:Content>

