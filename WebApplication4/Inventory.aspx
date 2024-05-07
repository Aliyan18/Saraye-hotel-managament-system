<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inventory.aspx.cs" Inherits="WebApplication4.WebForm6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="inventory.css"/>
</head>
<body>
 <div class="notcover"></div>
    <form id="form1" runat="server">

<%--      <div class=".icon">  <svg class="w-6 h-6 text-gray-800 dark:text-white" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" width="24" height="24" fill="none" viewBox="0 0 24 24">
  <path stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M12 21a9 9 0 0 1-.5-17.986V3c-.354.966-.5 1.911-.5 3a9 9 0 0 0 9 9c.239 0 .254.018.488 0A9.004 9.004 0 0 1 12 21Z"/>
</svg>
</div>--%>
                    <%--  <asp:TextBox ID="TextBox2" runat="server" Height="45px" Placeholder="password" Width="175px" TextMode="Password"></asp:TextBox> 
                      <asp:TextBox ID="TextBox1" runat="server" Height="45px" Placeholder="password" Width="175px" TextMode="Password"></asp:TextBox> 
                      <asp:TextBox ID="TextBox3" runat="server" Height="45px" Placeholder="password" Width="175px" TextMode="Password"></asp:TextBox> 
                      <asp:TextBox ID="TextBox4" runat="server" Height="45px" Placeholder="password" Width="175px" TextMode="Password"></asp:TextBox> 
                      <asp:TextBox ID="TextBox5" runat="server" Height="45px" Placeholder="password" Width="175px" TextMode="Password"></asp:TextBox> --%>
<button id="btn" type="button">order</button>
        <button id="btn2" type="button">Extract</button>

        <div class="inputForm">
            <p>Item id:</p>
                      <asp:TextBox ID="textbox2" runat="server"></asp:TextBox>
                  <p>Quantity</p>

           <asp:TextBox ID="textbox1" runat="server"></asp:TextBox>
           <asp:button ID="btn1" text="submit" runat="server" OnClick="btn_click" > </asp:button>
       </div>
         <div class="inputForm f1">
     <p>Item id:</p>
               <asp:TextBox ID="textbox3" runat="server"></asp:TextBox>
           <p>Quantity</p>

    <asp:TextBox ID="textbox4" runat="server"></asp:TextBox>
    <asp:button ID="Button1" text="submit" runat="server" OnClick="btn_click1" > </asp:button>
</div>
            <script src="inventory.js" ></script>

    </form>
</body>
</html>
