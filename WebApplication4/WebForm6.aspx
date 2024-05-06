<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="WebApplication4.WebForm6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="StyleSheet1.css"/>
</head>
<body>
    <form id="form1" runat="server">
                    <%--  <asp:TextBox ID="TextBox2" runat="server" Height="45px" Placeholder="password" Width="175px" TextMode="Password"></asp:TextBox> 
                      <asp:TextBox ID="TextBox1" runat="server" Height="45px" Placeholder="password" Width="175px" TextMode="Password"></asp:TextBox> 
                      <asp:TextBox ID="TextBox3" runat="server" Height="45px" Placeholder="password" Width="175px" TextMode="Password"></asp:TextBox> 
                      <asp:TextBox ID="TextBox4" runat="server" Height="45px" Placeholder="password" Width="175px" TextMode="Password"></asp:TextBox> 
                      <asp:TextBox ID="TextBox5" runat="server" Height="45px" Placeholder="password" Width="175px" TextMode="Password"></asp:TextBox> --%>
       <div id="inputForm">
                      <asp:TextBox ID="textbox2" runat="server"></asp:TextBox>
                  <p>Quantity</p>

           <asp:TextBox ID="textbox1" runat="server"></asp:TextBox>
           <asp:button text="submit" runat="server" OnClick="btn_click" > </asp:button>
       </div>
    </form>
</body>
</html>
