<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Banquets.aspx.cs" Inherits="Banquets" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <meta name="description" content="Coin Slider: jQuery Image Slider Plugin with Unique Effects" />
 <meta name="keywords" content="jquery plugin,image slider,slideshow, slider" />
<script type="text/javascript" src="images/jquery-1.4.2.js"></script>
<script type="text/javascript" src="images/coin-slider.min.js"></script>
<link rel="stylesheet" href="images/styles.css" type="text/css" />
<link rel="stylesheet" href="images/coin-slider-styles.css" type="text/css" />
    <link href="images/coin-slider-styles.css" rel="stylesheet" type="text/css" />
<title>Coin Slider: jQuery Image Slider Plugin with Unique Effects</title>
<meta http-equiv="Content-Type" content="text/html;charset=utf-8">
</head>
<body> 
<div id="page">
  <div id="gamesHolder">
		<div id="games">
		
			<a href="http://www.minininjas.com/" target="_blank">
                <img src="images/banq1.jpg" />
				<%--<img src="images/mini_nin.jpg" alt="Mini Ninjas" />--%>
				<span>
					<b>Banquet Hall</b><br />
					
				</span>
			</a>
			
			<a href="http://www.princeofpersiagame.com/" target="_blank">
                <img src="images/banq2.jpg" />
				<%--<img src="images/prince_o.jpg" alt="Price of Persia" />--%>
			</a>
			
			<a href="http://spidermandimensions.marvel.com/" target="_blank">
                <img src="images/banq3.jpg" />
				<%--<img src="images/spiderma.jpg" alt="Spiderman: Shattered Dimensions" />--%>
			</a>
			
			<a href="http://brinkthegame.com/" target="_blank">
                <img src="images/banq4.jpg" />
				<%--<img src="images/brink.jpg" alt="Brink" />--%>
			</a>
		
			<a href="http://www.godofwar.com/" target="_blank" >
                <img src="images/banq5.jpg" />
				<%--<img src="images/god_of_w.jpg" alt="God of War III" />--%>
			</a>

            <a href="http://www.godofwar.com/" target="_blank" >
                <img src="images/banq6.jpg" />
				<%--<img src="images/god_of_w.jpg" alt="God of War III" />--%>
			</a>

            <a href="http://www.godofwar.com/" target="_blank" >
                <img src="images/banq7.jpg" />
				<%--<img src="images/god_of_w.jpg" alt="God of War III" />--%>
			</a>
			
			<a href="http://www.borderlandsthegame.com/" target="_blank">
                <img src="images/banq5.jpg" />
				<%--<img src="images/borderla.jpg" alt="Borderlands" />--%>
				<span>
					<b>Banquet Hall</b><br />
					Fun combat and a steady flow of rewards make this journey a massively enjoyable one, especially with some fellow mercenaries along for the ride.
				</span>
			</a>
			
			<%--<a href="http://www.swtor.com/" target="_blank">
				<img src="images/star_war.jpg" alt="Star Wars: The Old Republic" />
			</a>
				
			<a href="http://www.batmanarkhamasylum.com/" target="_blank">
				<img src="images/batman_a.jpg" alt="Batman: Arkham Asylum" />
			</a>--%>
			
		</div>
More script and css style
: <%--<a href="http://www.htmldrive.net/" title="HTML DRIVE - Free DHMTL Scripts,Jquery plugins,Javascript,CSS,CSS3,Html5 Library">www.htmldrive.net </a>--%>
  </div>
</div>
<script>    $(document).ready(function () {
        $('#games').coinslider({ hoverPause: false });
    });
</script>
</body>


</asp:Content>

