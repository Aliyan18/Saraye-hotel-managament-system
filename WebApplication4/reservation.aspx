<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reservation.aspx.cs" Inherits="WebApplication4.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
            <link rel="stylesheet" href="res.css"/>
    <script src="JavaScript.js" ></script>
</head>
<body>
    <form id="form1" runat="server">

      <div class="outer">
          <div class="inner">
<asp:TextBox runat="server" ID="t1" placeholder="roomnum" AutoPostBack="true" CssClass="hidd select"  ></asp:TextBox>
              <asp:TextBox runat="server" ID="t2" placeholder="num" AutoPostBack="true" CssClass="hidd"></asp:TextBox>
            
              
              <asp:TextBox runat="server" ID="TextBox1" placeholder="Enter Date (YYYY-MM-DD)" AutoPostBack="true" CssClass="select"></asp:TextBox>

              <asp:TextBox runat="server" ID="TextBox2" placeholder="Enter Date (YYYY-MM-DD)" AutoPostBack="true" CssClass="select"></asp:TextBox>
          

<asp:Button runat="server" ID="btn1" Text="Click Me" OnClick="btn1_Clicked" />

              </div>
               <div class="p" style=" color:darkorange" >SARAYE</div>

      </div>
    </form>
</body>
</html>
