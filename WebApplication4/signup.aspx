<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="WebApplication4.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SARAYE</title>
    <link rel="stylesheet" href="/styleSheets/snp.css"/>
    <style>
        .btn a {
            color: #fff; 
            text-decoration: none; 
        }
        .btn a:hover {
            color: #ff7200; 
        }
    </style>
</head>

<body>

        <form id="form1" runat="server">

    <div class="main">
        <h2>Sign Up Here</h2> 
        <asp:Textbox runat="server" ID="username" placeholder="Enter Username"></asp:Textbox> 
        <asp:Textbox runat="server" ID="email" placeholder="Enter Email"></asp:Textbox> 
        <asp:Textbox runat="server" Id="Passowed" placeholder="Enter Password"></asp:Textbox> 
        <asp:Textbox runat="server" Id="date_of_birth" placeholder="Enter Date of Birth"></asp:Textbox> 
        <asp:Textbox runat="server" ID="country" placeholder="Enter Country/Region"></asp:Textbox> 
        <asp:Textbox runat="server" ID="phone_number" placeholder="Enter Phone Number"></asp:Textbox> 

        <select id="signupType"> 
            <option value="guest">Guest</option>
            <option value="staff">Staff</option>
        </select>
        <br />
        <asp:button runat="server" ID="btn1" OnClick="Unnamed1_Click" class="btn" Text="Signup"></asp:button>
        
        <p class="link"> Already have an account?<br/>
        <a href="login.aspx">Log in Here</a></p>
    </div>
            </form>
</body>
</html>
