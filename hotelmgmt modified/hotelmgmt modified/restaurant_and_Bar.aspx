<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="restaurant_and_Bar.aspx.cs" Inherits="restaurant_and_Bar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        #games
        {
            height: 280px;
            width: 702px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <html xmlns="http://www.w3.org/1999/xhtml">
        <head>

<link rel="SHORTCUT ICON" href="images/favicon0.htm" type="image/x-icon" />
<meta name="description" content="Coin Slider: jQuery Image Slider Plugin with Unique Effects" />

<meta name="keywords" content="jquery plugin,image slider,slideshow, slider" />

<script type="text/javascript" src="images/jquery-1.4.2.js"></script>

<script type="text/javascript" src="images/coin-slider.min.js"></script>

<link rel="stylesheet" href="images/styles.css" type="text/css" />

<link rel="stylesheet" href="images/coin-slider-styles.css" type="text/css" />

<title>Coin Slider: jQuery Image Slider Plugin with Unique Effects</title>

<meta http-equiv="Content-Type" content="text/html;charset=utf-8">

</head>

<body> 

<div id="page">

  <div id="gamesHolder">

		<div id="games">

		

			&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

		

			<a href="http://www.minininjas.com/" target="_blank">
                <img src="images/conf1.jpg" style="height: 318px; width: 471px" />

				<%--<img src="images/mini_nin.jpg" alt="Mini Ninjas" />--%>

				<span>

					<b>Conference Hall</b><br />
<%--
					Your quest to defeat the Evil Samurai Warlord has begun. Control the powers of nature, possess creatures, use your

					furious Ninja skills to free your Ninja friends.--%>

				</span>

			</a>

			

			<a href="http://www.princeofpersiagame.com/" target="_blank">
                <img src="images/conf2.jpg" />

				<%--<img src="images/prince_o.jpg" alt="Price of Persia" />--%>

			</a>

			

			<a href="http://spidermandimensions.marvel.com/" target="_blank">
                <img src="images/conf3.jpg" />

				<%--<img src="images/spiderma.jpg" alt="Spiderman: Shattered Dimensions" />--%>

			</a>

			

			<a href="http://brinkthegame.com/" target="_blank">
                <img src="images/conf4.jpg" />

				<%--<img src="images/brink.jpg" alt="Brink" />--%>

			</a>

		

			<a href="http://www.godofwar.com/" target="_blank" >
                <img src="images/conf5.jpg" />

				<%--<img src="images/god_of_w.jpg" alt="God of War III" />--%>

			</a>

			

			<a href="http://www.borderlandsthegame.com/" target="_blank">
                <img src="images/conf6.jpg" />

				<%--<img src="images/borderla.jpg" alt="Borderlands" />--%>

				<span>

					<b>Conference Hall</b><br />

					

				</span>

			</a>

			

			<a href="http://www.swtor.com/" target="_blank">
                <img src="images/conf7.jpg" />
				<%--<img src="images/star_war.jpg" alt="Star Wars: The Old Republic" />--%>

			</a>

				

			<%--<a href="http://www.batmanarkhamasylum.com/" target="_blank">

				<img src="images/batman_a.jpg" alt="Batman: Arkham Asylum" />

			</a>--%>

			

		    <span style="color: rgb(110, 97, 53); font-family: Arial, Helvetica, sans-serif; font-size: 12px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: 18px; orphans: auto; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); display: inline !important; float: none;">
      
            </span>

			

		</div>

  </div>

</div>

<script>    $(document).ready(function () {
        $('#games').coinslider({ hoverPause: false });
    });

</script>



</html>


    <p style="width: 884px; height: 188px; margin-left: 91px; margin-right: 76px;" 
    class="style14">
    Situated in Mumbai City, Suba International Hotel offers spacious accommodation 
    with an iPod dock and free Wi-Fi. Offering a free airport shuttle service, the 
    hotel also houses a restaurant. Fitted with tiled flooring, modern 
    air-conditioned rooms are equipped with a flat-screen TV and a private bathroom 
    with a hairdryer. Tea/coffee making facilities and a minibar are included. Suba 
    International is just 2 km from the Chhatrapati Shivaji International Airport. 
    Santa Cruz Railway Station and Juhu Beach are 6 km away. In addition to an 
    international buffet spread, Cinnamon Restaurant serves á la carte dishes. 
    In-room dining is possible. The hotel provides laundry and dry cleaning 
    services. Guests who drive get to enjoy free parking.</p>

    <p style="width: 884px; height: 29px; margin-left: 91px; margin-right: 76px; margin-top: 3px;">
    <asp:LinkButton ID="LinkButton10" runat="server" PostBackUrl="~/Home.aspx" 
            >Back to Home</asp:LinkButton>
            </body>
</p>
</asp:Content>

