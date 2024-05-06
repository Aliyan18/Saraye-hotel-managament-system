<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="food.aspx.cs" Inherits="WebApplication4.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>
        food
    </title>
<link rel="stylesheet" href="food.css"/>

</head>
<body >
    <form id="form1" runat="server">
        
         <div class="background-container">
         <div class="container">
             <div class="main">
            <div class="menu">
                <ul>
                    <li><a href="#menu">Menu</a></li>
                    <li><a href="#about">About</a></li>
                    <li><a href="#customers">Customers</a></li>
                    <li><a href="#booking">Booking</a></li>
                    <li><a href="#contact">Contact</a></li>
                </ul>
                            <div class="icon-cart">
            <svg class="w-6 h-6 text-gray-800 dark:text-white" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" width="24" height="24" fill="none" viewBox="0 0 24 24">
  <path stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M5 4h1.5L9 16m0 0h8m-8 0a2 2 0 1 0 0 4 2 2 0 0 0 0-4Zm8 0a2 2 0 1 0 0 4 2 2 0 0 0 0-4Zm-8.5-3h9.25L19 7H7.312"/>
</svg>
                </div>
            </div>
                    
                          
                              <%--<div class="title">product list</div>--%>
                
            </div>
            <div class="welcome">
                <h1>WELCOME</h1>
                <br/> <br/>
                <h4> Welcome to Saraye food section, where culinary delights await to tantalize your taste buds. Indulge in a gastronomic journey of
                    flavors crafted with passion and precision, ensuring an unforgettable
                    dining experience at every bite</h4>
                <h2>Reservation</h2>
              <%--  <div class="btn">
                   <form action="" method="post">
                        <input type="button" value="start now">
                    </form>
                </div>--%>
            </div>
        </div>

    <br><br>

    <div class="menu1" id="menu">
        <div class="menu1">
            <div class="heading">
                <br>
                <h1>HOTEL FOOD SERVICE</h1>
                <h2>---MENU---</h2>
                <br>
            </div>
        </div>

        <div class="food-container">
            <div class="food-items">
                <img src="lobster_benny.jpg">
                <div class="discription">
                    <div class="sub-details">
                        <h4>Lobster Benny</h4>
                        <h5 class="price">2500</h5>
                    </div>
                    <p>A delightful twist on classic Eggs Benedict, featuring succulent lobster meat atop toasted English muffins, poached eggs, and creamy hollandaise sauce.</p>
                    <asp:button id="Lobster_Benny" runat="server" OnClick="btn_clicked" Text="ADD TO CART"></asp:button>
                </div>
             </div>
             
             
             <div class="food-items">
                <img src="lunch1.jpg">
                <div class="discription">
                    <div class="sub-details">
                        <h4>Burger</h4>
                        <h5 class="price">1000</h5>
                    </div>
                    <p>Succulent burger with a burst of flavor.</p>
                    <asp:button id="Burger" runat="server" OnClick="btn_clicked" Text="ADD TO CART"></asp:button>
                </div>
             </div>
        
             
             <div class="food-items">
                <img src="lunch2.jpg">
                <div class="discription">
                    <div class="sub-details">
                        <h4>Rolls</h4>
                        <h5 class="price">1700</h5>
                    </div>
                    <p>Golden, crispy rolls filled with a delectable mix of savory ingredients, perfect for a quick and satisfying snack or appetizer</p>
                    <asp:button id="Rolls" runat="server" OnClick="btn_clicked" Text="ADD TO CART"></asp:button>
                </div>
             </div>
        
             
             <div class="food-items">
                <img src="kebab.jpg">
                <div class="discription">
                    <div class="sub-details">
                        <h4>Kebab</h4>
                        <h5 class="price">1500</h5>
                    </div>
                    <p>Skewered and seasoned meat, grilled to smoky perfection.</p>
                    <asp:button id="Kebab" runat="server" OnClick="btn_clicked" Text="ADD TO CART"></asp:button>
                </div>
             </div>
        
             
             <div class="food-items">
                <img src="pizza.jpg">
                <div class="discription">
                    <div class="sub-details">
                        <h4>Pizza</h4>
                        <h5 class="price">2000</h5>
                    </div>
                    <p>Freshly baked pizza topped with savory ingredients.</p>
                    <asp:button id="Pizza" runat="server" OnClick="btn_clicked" Text="ADD TO CART"></asp:button>
                </div>
             </div>
        
             
             <div class="food-items">
                <img src="fries.jpg">
                <div class="discription">
                    <div class="sub-details">
                        <h4>Fries</h4>
                        <h5 class="price">700</h5>
                    </div>
                    <p>Crispy potato wedges seasoned to perfection.</p>
                    <asp:button id="Fries" runat="server" OnClick="btn_clicked" Text="ADD TO CART"></asp:button>
                </div>
             </div>
        
        
        
             <div class="food-items">
                <img src="steak.jpg">
                <div class="discription">
                    <div class="sub-details">
                        <h4>Steak</h4>>
                        <h5 class="price">3000</h5>
                    </div>
                    <p>Juicy, tender cuts of prime beef, grilled to perfection.</p>
                    <asp:button id="Steak" runat="server" OnClick="btn_clicked" Text="ADD TO CART"></asp:button>
                </div>
             </div>
        
            
             <div class="food-items">
                <img src="pasta.jpg">
                <div class="discription">
                    <div class="sub-details">
                        <h4>Chicken skewers</h4>>
                        <h5 class="price">2000</h5>
                    </div>
                    <p> Tender pieces of meat or vegetables, grilled to perfection on skewers.</p>
                    <asp:button id="Chicken_skewers" runat="server" OnClick="btn_clicked" Text="ADD TO CART"></asp:button>
                </div>
             </div>
        
             
             <div class="food-items">
                <img src="wraps.jpg">
                <div class="discription">
                    <div class="sub-details">
                        <h4>Wrap</h4>>
                        <h5 class="price">1000</h5>
                    </div>
                    <p>Freshly grilled meat or vegetables wrapped in soft, warm flatbread.</p>
                    <asp:button id="Wrap" runat="server" OnClick="btn_clicked" Text="ADD TO CART"></asp:button>
                </div>
             </div>
        
             <div class="food-items">
                <img src="pancakes.jpg">
                <div class="discription">
                    <div class="sub-details">
                        <h4>Pancake</h4>>
                        <h5 class="price">1700</h5>
                    </div>
                    <p>Fluffy pancakes served with maple syrup and butter.</p>
                    <asp:button id="Pancakes" runat="server" OnClick="btn_clicked" Text="ADD TO CART"></asp:button>
                </div>
             </div>
             <div class="food-items">
                <img src="honey-wings.jpg">
                <div class="discription">
                    <div class="sub-details">
                        <h4>Honey Wings</h4>>
                        <h5 class="price">1400</h5>
                    </div>
                    <p> Succulent chicken wings coated in a sticky, sweet honey glaze.</p>
                    <asp:button id="Honey_Wings" runat="server" OnClick="btn_clicked" Text="ADD TO CART"></asp:button>
                </div>
             </div>
        
        
             <div class="food-items">
                <img src="platter.jpg">
                <div class="discription">
                    <div class="sub-details">
                        <h4>North Indian Platter</h4>>
                        <h5 class="price">4000</h5>
                    </div>
                    <p>A flavorful assortment of traditional Indian dishes, rich in spices and aromas.</p>
                    <asp:button id="North_Indian_Platter" runat="server" OnClick="btn_clicked" Text="ADD TO CART"></asp:button>
                </div>
             </div>
        
        </div>
    </div>
        <div class="cartTab" runat="server">
            <h1>Shopping cart</h1>
            <div class="listCart" runat="server" id="listCart">
                <div class="item">
                <div class="name">NAME</div>
                <div class="totalPrice">$200</div>
                <div class="quantity">
                    <span class="minus"><asp:button runat="server" Text="-" OnClick="remov"></asp:button></span>
                    <span>1</span>
                    <span class="plus">+</span>
                </div>
             </div>
                </div>
            <div class="btn">
                <button class="close">CLOSE</button>
                <asp:button runat="server" class="CheckOut" Text="CHECK OUT"></asp:button>
            </div>

        </div>
   
    <%--<script>
        // Smooth scrolling for navigation links
        document.querySelectorAll('a[href^="#"]').forEach(anchor => {
            anchor.addEventListener('click', function (e) {
                e.preventDefault();
    
                document.querySelector(this.getAttribute('href')).scrollIntoView({
                    behavior: 'smooth'
                });
            });
        });
    
        // Redirect to 1.html when "Start Now" button is clicked
        document.querySelector('.btn input[type="button"]').addEventListener('click', function () {
            window.location.href = '1.html';
        });
    </script>--%>
                <script src="JavaScript1.js" ></script>

    </form>
</body>
</html>
