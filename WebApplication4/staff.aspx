<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="staff.aspx.cs" Inherits="WebApplication4.WebForm7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
                <link rel="stylesheet" href="/styleSheets/staff.css"/>

</head>
<body>
    <form id="form1" runat="server">
        <h1>ADMIN/STAFF VIEW</h1>
        <div runat="server" id="div1" class="container inventory" onclick="divClicked()">
            <asp:button runat="server" Text="INVENTORY" OnClick="inv_clicked" CssClass="bt"></asp:button>
            
        </div>
          
         <div runat="server" id="div2" class="container staff" >
     <asp:button runat="server" onclick="staff_clicked" Text="STAFF INFO" CssClass="bt"></asp:button>
     
 </div>
                 <div runat="server" id="div3" class="container res" >
    <asp:button runat="server" onclick="res_clicked" Text="Reservation INFO" CssClass="bt"></asp:button>
    
</div>
    




        
    </form>
</body>
</html>
