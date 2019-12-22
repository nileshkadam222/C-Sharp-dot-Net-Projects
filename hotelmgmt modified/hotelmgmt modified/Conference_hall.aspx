<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Conference_hall.aspx.cs" Inherits="Conference_hall" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
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

		<div id="games" style="background-image: url('images/background.jpg')">

		

			&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

		

			<a href="http://www.minininjas.com/" target="_blank">
                <img src="images/conf1.jpg" />

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

			

		</div>

  </div>

</div>

<script>    $(document).ready(function () {
        $('#games').coinslider({ hoverPause: false });
    });

</script>

</body>

</html>


</asp:Content>

