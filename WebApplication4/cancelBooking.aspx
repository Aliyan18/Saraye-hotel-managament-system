<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cancelBooking.aspx.cs" Inherits="WebApplication4.WebForm8" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>CANCEL BOOKING</h1>    
        
        room num:
                          <asp:TextBox ID="t2" runat="server"></asp:TextBox>
            
    <asp:button ID="btn" Text="submit" runat="server" OnClick="btn_clicked"></asp:button>
 </form>
</body>
</html>
