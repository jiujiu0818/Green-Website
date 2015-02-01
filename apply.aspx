<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="apply.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<title>绿荫网-申请表单</title>
<link href="Untitled-2.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
<div class="total">
	<div class="name_main">
		<div class="name">&nbsp;&nbsp;姓名 :</div>
		<div class="name_img">
        <asp:TextBox ID="TxtName" CssClass="text" runat="server"></asp:TextBox>
            
        </div>
	</div>
    <div class="name_main">
		<div class="name">&nbsp;&nbsp;学号 : </div>
		<div class="name_img"><asp:TextBox CssClass="text"  ID="TxtNum" runat="server"></asp:TextBox></div>
	</div>
    <div class="name_main">
		<div class="name">&nbsp;&nbsp;专业 : </div>
		<div class="name_img"><asp:TextBox CssClass="text"  ID="txtMajor" runat="server"></asp:TextBox></div>
	</div>
    <div class="name_main">
		<div class="name">&nbsp;&nbsp;班级 : </div>
		<div class="name_img"><asp:TextBox CssClass="text"  ID="TxtClass" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                ControlToValidate="TxtClass" ErrorMessage="请输入一个数字" 
                ValidationExpression="^\d{1,4}$"></asp:RegularExpressionValidator>
        </div>
	  <div class="name_main">
		<div class="name">&nbsp;&nbsp;联系电话 : </div>
		<div class="name_img"><asp:TextBox CssClass="text"  ID="TxtPhone" runat="server"></asp:TextBox></div>
	</div>
	  <div class="name_main">
		<div class="name">&nbsp;&nbsp;QQ : </div>
		<div class="name_img"><asp:TextBox CssClass="text"  ID="TxtQQ" runat="server"></asp:TextBox></div>
	</div>
	<div class="name_main">
		<div class="name">&nbsp;&nbsp;所选方向：</div>
		<div class="name_img" style=" color:Black !important" ><asp:TextBox CssClass="text"  ID="TxtPart" runat="server"></asp:TextBox></div>
	</div>
	<div class="name_main">
		<div class="name">&nbsp;&nbsp;自我介绍：</div>
		<div class="inqu_img">
		  <asp:TextBox CssClass=" text2"  ID="TxtIntroduction" 
                runat="server" TextMode="MultiLine"></asp:TextBox>
		</div>
  </div>



     <div class="sub">
         <asp:ImageButton ID="ImageButton1" ImageUrl="1.jpg" runat="server" 
             onclick="ImageButton1_Click" />       
     </div>
</div>

<div class="clear">&nbsp;</div>
</div>
</asp:Content>

