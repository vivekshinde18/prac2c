﻿<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Pract2c" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title></title></head>
<body>
<form id="form1" runat="server">
<div align="center">
<asp:Label ID="Label1" runat="server" Text="Enter value of a:"></asp:Label>
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
<asp:Label ID="Label2" runat="server" Text="Enter value of b:"></asp:Label>
<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
<asp:Label ID="Label3" runat="server" Text="Enter value of c:"></asp:Label>
<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
<asp:Button ID="Button1" runat="server" Height="45px"
onclick="Button1_Click" Text="Button" Width="79px" />
</div></form>
</body>
</html>
