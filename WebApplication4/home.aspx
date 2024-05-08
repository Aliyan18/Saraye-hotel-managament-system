<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="WebApplication4.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <title>hotel</title>
  <link rel="stylesheet" href="hms.css">
  <script src="https://kit.fontawesome.com/dbed6b6114.js" crossorigin="anonymous"></script>
    <script>
        document.onreadystatechange = function () {
            if (document.readyState !== "complete") {
                document.querySelector(
                    "body").style.visibility = "hidden";
                document.querySelector(
                    "#spinner").style.visibility = "visible";
            } else {
                document.querySelector(
                    "#spinner").style.display = "none";
                document.querySelector(
                    "body").style.visibility = "visible";
            }
        };
    </script>
    <style>
        #spinner   {  
           
            animation: spin 1s linear infinite;
            color: red;
        }
          
        @keyframes spin {
            100% {
                transform: rotate(360deg);
            }
        }
          
.inline{
    display: flex;
}
.center{
    flex:left;
}
.spinner i{
    margin-top: 10px;
    margin-left: 50px;

    
}
       </style>
</head>
<body>
     <div>  
           <p class="spinner" id="spinner"><i class="fa fa-spinner fa-5x"></i></p>
    </div>
    <form id="form1" runat="server">
       
    <div class="main">
        <div class="navbar">
            <div class="icon">
                <h2 class="logo">SARAYE</h2>
            </div>
        
            <div class="menu">
                <ul>
                    <li><a href="#about">About</a></li>
                    <li><a href="#services">Services</a></li>
                    <li><a href="#customers">Customers</a></li>
                    <li><a href="#contact">Contact</a></li>
                    <li><a href="#rooms">Rooms</a></li>
                
                </ul>
                
            </div>
            
            <div runat="server" class="login" id="myDiv">
            </div>
        </div>
        
        <div class="head-bottom flex">
            <h2>NICE AND COMFORTABLE PLACE TO STAY</h2>
            <p>Unlock the door to exceptional hospitality – where every moment is tailored to perfection</p>
        </div>
    </div>

    <section id="about" class="bg-light py-3">
        <div class="container">
            <div class="info-left">
                <h1 class="l.heading"> <span class="text-primary">About</span> Our Hotel</h1>
                <br>
                <p>Welcome to Saraye, where every stay is a journey of luxury and tranquility. <br>
                Our hotel offers a seamless blend of elegance, comfort, and impeccable <br>service.
                From our meticulously designed rooms to our world-class amenities,<br> every detail is
                crafted to ensure a memorable experience for our guests. </p>

                <br>

                <p>Whether you're here for business or leisure, our dedicated staff is committed to providing <br>you with personalized attention and
                  creating moments of unparalleled hospitality.<br> Discover a sanctuary of relaxation and refinement 
                  at Saraye, where indulgence knows no bounds.</p>
            </div>
            <div class="info-right">
            <img src="./3.jpeg" alt="Hotel">
        </div>
    </section>

    <section class="services sec-width" id="services">
        <div class = "title">
          
            <h3>Services</h3>

        </div>

        <div class = "services-container">
            <!-- single service -->
            <article class = "service">
                <div class = "service-icon">
                    <span>
                        <i class = "fas fa-concierge-bell"></i>
                    </span>
                </div>
                <div class = "service-content">
                    <h2>Room Service</h2>
                    <p>Experience convenience at its finest with our prompt and personalized room service at SARAYE. Indulge in delicious meals and essential amenities delivered straight to your door, ensuring a hassle-free and enjoyable stay. Sit back, relax, and let us take care of the details, enhancing your experience with top-notch service.</p>
                  
                </div>
            </article>
           
            <article class = "service">
                <div class = "service-icon">
                    <span>
                        <i class = "fas fa-tshirt"></i>
                    </span>
                </div>
                <div class = "service-content">
                    <h2>Laundry</h2>
                    <p>Enjoy effortless freshness during your stay with our efficient laundry service at SARAYE. Leave the hassle of laundry behind as our dedicated team ensures your garments are expertly cleaned and cared for. Experience convenience and comfort, allowing you to focus on what truly matters during your time with us</p>
                   
                </div>
            </article>
       
            <article class = "service">
                <div class = "service-icon">
                    <span>
                        <i class = "fas fa-truck-pickup"></i>
                    </span>
                </div>
                <div class = "service-content">
                    <h2>Pick And Drop</h2>
                    <p>Simplify your travel experience with our convenient pick and drop service at SARAYE. Whether arriving or departing, our reliable transportation ensures a seamless journey to and from your destination. Sit back, relax, and let us handle the logistics, allowing you to enjoy a stress-free stay with us</p>
                 
                </div>
            </article>
          
            <article class = "service">
                <div class = "service-icon">
                    <span>
                        <i class = "fas fa-door-closed"></i>
                    </span>
                </div>
                <div class = "service-content">
                    <h2>Room Security</h2>
                    <p>Rest easy knowing your safety is our priority with our robust room security measures at SARAYE. From secure keycard access to vigilant surveillance, we ensure peace of mind throughout your stay. Enjoy a worry-free experience, knowing that your comfort and security are paramount to us.</p>
                 
                </div>
            </article>
        
        </div>
    </section>

    <section class = "rooms sec-width" id = "rooms">
        <div class = "title">
            <h3>rooms</h3>
        </div>
        <div class = "rooms-container">
        
            <article class = "room">
                <div class = "room-image">
                    <img src = "img1.jpg" alt = "room image">
                </div>
                <div class = "room-text">
                    <h3>Luxury Rooms</h3>
                    <p>Experience unparalleled comfort and sophistication in our meticulously crafted hotel rooms. Each room is designed to provide a serene oasis where guests can unwind and recharge. From elegant furnishings to modern amenities, every detail is thoughtfully curated to ensure a memorable stay. Whether you're traveling for business or leisure, our rooms offer the perfect blend of luxury and functionality, allowing you to relax and enjoy your time with us to the fullest.</p>
                   
                </div>
            </article>
          
            <article class = "room">
                <div class = "room-image">
                    <img src = "img2.jpg" alt = "room image">
                </div>
                <div class = "room-text">
                    <h3>Luxury Rooms</h3>
                    <p>Step into a world of refined luxury with our stylish hotel rooms. Designed with your comfort in mind, each room exudes warmth and hospitality, providing a welcoming retreat after a day of exploration. Sink into plush bedding, catch up on your favorite shows, or simply take in the breathtaking views of the city skyline. With attentive service and a range of amenities at your fingertips, your stay with us promises to be nothing short of extraordinary.</p>
                   
                </div>
            </article>
        </div>
    </section>

    <section class="customers" id="customers">
        <div class = "sec-width">
            <div class = "title">
                <h3>customers</h3>
            </div>
            <div class = "customers-container">
              
                <div class = "customer">
                    <div class = "rating">
                        <span><i class = "fas fa-star"></i></span>
                        <span><i class = "fas fa-star"></i></span>
                        <span><i class = "fas fa-star"></i></span>
                        <span><i class = "fas fa-star"></i></span>
                        <span><i class = "far fa-star"></i></span>
                    </div>
                    <h3>We Loved it</h3>
                    <p>Saraye's attention to detail and commitment to guest satisfaction set it apart. Can't wait to visit again!</p>
                    <img src = "cus1.jpg" alt = "customer image">
                    <span>Sara, Pakitan</span>
                </div>
                <div class = "customer">
                    <div class = "rating">
                        <span><i class = "fas fa-star"></i></span>
                        <span><i class = "fas fa-star"></i></span>
                        <span><i class = "fas fa-star"></i></span>
                        <span><i class = "fas fa-star"></i></span>
                        <span><i class = "far fa-star"></i></span>
                    </div>
                    <h3>Comfortable Living</h3>
                    <p>From the warm welcome to the elegant rooms, Saraye exceeded all my expectations.</p>
                    <img src = "cus2.jpg" alt = "customer image">
                    <span>Malala bitch, pakistan</span>
                </div>
            
                <div class = "customer">
                    <div class = "rating">
                        <span><i class = "fas fa-star"></i></span>
                        <span><i class = "fas fa-star"></i></span>
                        <span><i class = "fas fa-star"></i></span>
                        <span><i class = "fas fa-star"></i></span>
                        <span><i class = "far fa-star"></i></span>
                    </div>
                    <h3>Nice Place</h3>
                    <p>Impeccable service and luxurious amenities made my stay at Saraye truly memorable!</p>
                    <img src = "cus3.jpg" alt = "customer image">
                    <span>paul, USA</span>
                </div>
                
            </div>
        </div>
    </section>

    <section id="contact" class="footer">
        <div class = "footer-container">
            <div>
                <h2>About Us </h2>
                <br>
                <p> our commitment to excellence extends beyond our facilities. We are dedicated to creating memorable experiences for our guests, ensuring that every moment spent with us is filled with warmth, luxury, and unparalleled hospitality.</p>
                <ul class = "social-icons">
                    <li class = "flex">
                        <i class = "fa fa-twitter fa-2x"></i>
                    </li>
                    <li class = "flex">
                        <i class = "fa fa-facebook fa-2x"></i>
                    </li>
                    <li class = "flex">
                        <i class = "fa fa-instagram fa-2x"></i>
                    </li>
                </ul>
            </div>
    
            <div>
                <h2>Useful Links</h2>
                <br>
                <a href = "#">Reservations</a>
                <a href = "#">Rooms</a>
                <a href = "#">Bookings</a>
                  
            
            </div>
    
            <div>
                <h2>Privacy</h2>
                <br>
                <a href = "#">About Us</a>
                <a href = "#">Contact Us</a>
                <a href = "#">Services</a>
            </div>
    
            <div>
                <h2>Have A Question?</h2>
                <br>
                <div class = "contact-item">
                    <span>
                        <i class = "fas fa-map-marker-alt"></i>
                    </span>
                    <span>
                        kiranchi,Pakistan
                    </span>
                </div>
                <div class = "contact-item">
                    <span>
                        <i class = "fas fa-phone-alt"></i>
                    </span>
                    <span>
                        +0342-1484624
                    </span>
                </div>
                <div class = "contact-item">
                    <span>
                        <i class = "fas fa-envelope"></i>
                    </span>
                    <span>
                        saraye69@gmail.com
                    </span>
                </div>
                
            </div>
        </div>
    
    </section>


    <script>
        // JavaScript for smooth scrolling
        document.addEventListener("DOMContentLoaded", function() {
            // Select all navbar links
            const navbarLinks = document.querySelectorAll('.navbar ul li a');

            // Loop through each link and add click event listener
            navbarLinks.forEach(link => {
                link.addEventListener('click', function(event) {
                    event.preventDefault(); // Prevent default behavior

                    // Get the target section's ID from the href attribute
                    const targetId = this.getAttribute('href').substring(1);
                    const targetSection = document.getElementById(targetId);

                    // Scroll smoothly to the target section
                    targetSection.scrollIntoView({ behavior: 'smooth' });
                });
            });
        });
    </script>

    </form>
</body>
</html>
