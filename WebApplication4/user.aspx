<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="user.aspx.cs" Inherits="WebApplication4.user" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        td {
        background-color:red;
        }
        
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>users in our database</h1>
            <asp:GridView ID="GridView1" AutoGenerateColumns="true" runat="server">
                
            </asp:GridView>
        </div>
    </form>
</body>
</html>
