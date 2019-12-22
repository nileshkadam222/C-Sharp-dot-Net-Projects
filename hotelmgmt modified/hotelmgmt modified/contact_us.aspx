<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="contact_us.aspx.cs" Inherits="contact_us" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <body> 

<div id="page">

  <div id="gamesHolder">

		<div id="games">

		

			&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

		

			<a href="http://www.minininjas.com/" target="_blank">

				<img src="images/mini_nin.jpg" alt="Mini Ninjas" />

				<span>

					<b>Mini Ninjas</b><br />

					

				</span>

			</a>

			

			<a href="http://www.princeofpersiagame.com/" target="_blank">

				<img src="images/prince_o.jpg" alt="Price of Persia" />

			</a>

			

			<a href="http://spidermandimensions.marvel.com/" target="_blank">

				<img src="images/spiderma.jpg" alt="Spiderman: Shattered Dimensions" />

			</a>

			

			<a href="http://brinkthegame.com/" target="_blank">

				<img src="images/brink.jpg" alt="Brink" />

			</a>

		

			<a href="http://www.godofwar.com/" target="_blank" >

				<img src="images/god_of_w.jpg" alt="God of War III" />

			</a>

			

			<a href="http://www.borderlandsthegame.com/" target="_blank">

				<img src="images/borderla.jpg" alt="Borderlands" />

				<span>

					<b>Borderlands</b><br />

					Fun combat and a steady flow of rewards make this journey a massively enjoyable one, especially with some fellow mercenaries along for the ride.

				</span>

			</a>

			

			<a href="http://www.swtor.com/" target="_blank">

				<img src="images/star_war.jpg" alt="Star Wars: The Old Republic" />

			</a>

				

			<a href="http://www.batmanarkhamasylum.com/" target="_blank">

				<img src="images/batman_a.jpg" alt="Batman: Arkham Asylum" />

			</a>

			

		</div>

  </div>

</div>

<script>    $(document).ready(function () {
        $('#games').coinslider({ hoverPause: false });
    });

</script>

</body>


</asp:Content>

