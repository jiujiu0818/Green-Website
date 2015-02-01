<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="message.aspx.cs" Inherits="_Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
<br/>
    <img src="head.png" style="width: 900px; height: 55px;" />
<br /><br />
    <asp:DataList ID="DataList1" runat="server" Height="873px" Width="929px" OnSelectedIndexChanged="DataList1_SelectedIndexChanged">
        <ItemTemplate>
            <div>
                <table class="box100">
                    <tr>
                        <td style="width: 81px; height: 55px">
                            <img alt="a" style="position: relative" src="images/face/10.png" />
                            <br />
                            <asp:Label ID="Label10" runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"userName") %>'></asp:Label>
                        </td>
                        <td style="width: 566px; height: 55px">
                            <asp:Label ID="Label11" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "content")%>'></asp:Label>
                            <br />
                            <asp:Label ID="Label14" runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"postTime") %>'></asp:Label>
                        </td>
                    </tr>
                    <caption>
                        </tr> &nbsp;<div class="line_white">
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src="line.png" style="width: 680px;
                                height: 2px" />
                        </div>
                        <tr>
                            <td style="width: 81px; height: 19px">
                            </td>
                            <td style="width: 566px; height: 19px">
                                &nbsp;<img src="line.png" style="width: 680px; height: 2px" />
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 81px; height: 55px">
                                <img src="gsmanager.png" style="width: 150px; height: 150px" />
                            </td>
                            <td style="width: 566px; height: 55px">
                                <asp:Label ID="Label13" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "reply")%>'></asp:Label>
                                <%-- <br />
                                <asp:Label ID="Label15" runat="server" Text=<%#DataBinder.Eval(Container.DataItem, "postTime")%> Visible="False"></asp:Label>
                            </td>--%>
                        </tr>
                    </caption>
                    <tr>
                        <td style="width: 81px; height: 55px">
                            &nbsp;
                        </td>
                        <td>
                            &nbsp;<img src="line.png" style="width: 680px; height: 2px" />
                        </td>
                    </tr>
                </table>
            </div>
        </ItemTemplate>
    </asp:DataList>
    <%--  <asp:Button ID="Button10" runat="server" Text="我要留言" BackColor="#33CC33" 
        ForeColor="#003300" />

        <tr>
                <td align="right">
                    共<asp:Label ID="lblMesTotal" runat="server" Style="position: relative" Text="Label"></asp:Label>条留言&nbsp;
                    第<asp:Label ID="lblPageCur" runat="server" Style="position: relative" Text="Label"></asp:Label>页&nbsp;
                    共<asp:Label ID="lblPageTotal" runat="server" Style="position: relative" Text="Label"></asp:Label>页&nbsp;
                    <asp:Button ID="Button3" runat="server" Style="position: relative" Text="首页" OnClick="Button3_Click" />
                    <asp:Button ID="Button1" runat="server" Style="position: relative" Text="上一页" OnClick="Button1_Click" />
                    <asp:Button ID="Button2" runat="server" Style="position: relative" Text="下一页" OnClick="Button2_Click" />
                    <asp:Button ID="Button4" runat="server" Style="position: relative" Text="尾页" OnClick="Button4_Click" />
                    &nbsp; 转到<asp:DropDownList ID="DropDownList1" runat="server" Style="position: relative">
                    </asp:DropDownList>&nbsp;
                    <asp:Button ID="Button5" runat="server" Style="position: relative" Text="GO" OnClick="Button5_Click" /></td>
            </tr>
    --%>
    <table class="box100">
        <tr>
            <td>
                <%--<asp:Button ID="Button10" runat="server" Text="我要留言" BackColor="#33CC33" 
        ForeColor="#003300"  />--%>
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/messages/images/click .jpg"
                    OnClick="ImageButton1_Click2" />
                &nbsp;
            </td>
            <td>
                <img src="images/共.png" />&nbsp;
                <asp:Label ID="lblMesTotal" runat="server" Style="position: relative; font-size:25" Text="Label"></asp:Label>
            </td>
            <td>
                <img src="images/条留言.png" />
            </td>
            <td>
                &nbsp; &nbsp; &nbsp; &nbsp;<img src="images/第.png" />
            </td>
            <td style="width: 154px">
                <asp:Label  ID="lblPageCur" runat="server" Style="position: relative; font-size:25;  "></asp:Label>
                <img src="images/页.png" />
            </td>
            <%--<td>
                <asp:Label ID="lblPageCur" runat="server" Style="position: relative" 
                    Text="Label" Visible="False"></asp:Label>&nbsp;</td>--%>
            <%-- <td>
                <asp:Label ID="Label3" runat="server" Text="页 " Visible="False"></asp:Label>&nbsp;</td>--%>
            <td>
                <img src="images/共.png" /><asp:Label ID="lblPageTotal" runat="server" Style="position: relative; font-size:25"
                    Text="Label" /><img src="images/页.png" />&nbsp;
            </td>
        </tr>
        <tr>
            <td>
                <asp:ImageButton ID="Button3" runat="server" ImageUrl="~/messages/新建文件夹留言板/images/default.jpg"
                    OnClick="Button3_Click" />
                &nbsp;
            </td>
            <td>
                <asp:ImageButton ID="Button1" runat="server" ImageUrl="~/messages/新建文件夹留言板/images/up.jpg"
                    OnClick="Button1_Click" />
                &nbsp;
            </td>
            <td>
                <asp:ImageButton ID="Button2" runat="server" ImageUrl="~/messages/新建文件夹留言板/images/down.jpg"
                    OnClick="Button2_Click" />&nbsp;
            </td>
            <td>
                <asp:Button ID="Button4" runat="server" Style="position: relative" Text="尾页" OnClick="Button4_Click" />&nbsp
            </td>
            <td style="width: 154px">
                <asp:Label ID="Label5" runat="server" Text="转到第：" Visible="False"></asp:Label>
                <asp:DropDownList ID="DropDownList1" runat="server" Style="position: relative" Visible="False">
                </asp:DropDownList>
                <asp:Label ID="Label6" runat="server" Text="页" Visible="False"></asp:Label>&nbsp
            </td>
            <td>
                <asp:Button ID="Button5" runat="server" Style="position: relative" Text="GO" OnClick="Button5_Click"
                    Visible="False" />&nbsp
            </td>
        </tr>
    </table>

</asp:Content>
