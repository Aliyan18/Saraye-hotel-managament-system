<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link rel="stylesheet" href="/styleSheets/login.css"/>

</head>
<body>
    <form id="form1" runat="server">
           <div class="main">
        <div class="navbar">
            <div class="icon">
                <h2 class="logo">SARAYE</h2>
            </div>
            <br>
            <br>
            <br>
            <div class="content">
                <h1> A HOUSE FOR THE <br><span>ENTERTAINMENT</span><br>OF TRAVELERS</h1>
                <p class="par">Sign up now to unlock exclusive access to seamless reservations, <br>
                    personalized stays, and a world of entertainment for every traveler.
                    <br> Your journey begins here at Saraye - Where every stay is a unique <br>experience.
                     .Start your adventure with us and create lasting memories."</p>
                  
                  <div class="form">
                    <h2>Login Here</h2>
                                        <div style="padding:2vh; margin-top:12px">

                      <asp:TextBox ID="TextBox1" runat="server" Height="45px" Width="175px" Placeholder="username"></asp:TextBox>
                      </div>
                      <div style="padding:2vh; margin-bottom:6vh">
                      <asp:TextBox ID="TextBox2" runat="server" Height="45px" Placeholder="password" Width="175px" TextMode="Password"></asp:TextBox> 

                           
                      </div>
                                           <div >
<asp:Button Padding="1.5vh" margin-bottom="3vh" ID="Button1" runat="server" Text="LOGIN" BackColor="#FF6600" CssClass="btn" Height="32px" Width="256px" OnClick="Button1_Click" />
 </div>
                          <div class="link"style="margin-top:4vh"> Don't have an account</div>
                      
                        <div class="link"><a href="signup.aspx">Sign up Here</a></div>
                        <div class="link"><a href="home.aspx">Continue without login</a></div>

                      <div class="liw">Log in with
                      </div>
  
                  <br/>

                </div>
            
            
            
            
         </div>
            
        </div>
    </div>
    </form>
</body>
</html>
