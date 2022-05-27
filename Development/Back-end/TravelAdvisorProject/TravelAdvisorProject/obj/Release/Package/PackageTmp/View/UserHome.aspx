<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserHome.aspx.cs" Inherits="TravelAdvisorProject.View.UserHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
		<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous"/>
		<script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
		<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
		<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>
	<link  rel="stylesheet" href="UserHomeStyle.css"/>
    <title>User Home</title>
</head>
<body>
    <form id="form1" runat="server">
			<nav>
			   <div class="logo">
				 <img src="../images/u.png" class="img-fluid">
			   </div>
		   </nav>
	<div class="slide">

  <!-- Panels -->
  <div class="swipe">
    <div class="panel">
        
    </div>

    <div class="panel">
    </div>

    </div>
  </div>
        <asp:Image ID="firstImg" runat="server" class="imgs"/>
        <asp:Image ID="secondImg" runat="server"  class="imgs"/>
  <!-- Info -->
  <div class="info">
    <div class="inner">
        <asp:Label ID="tourName" runat="server" Text=""></asp:Label>
    </div>

    <div class="buttons">
        <asp:Button ID="prevBtn" runat="server" Text= &larr; class="btn-prev" OnClick="prevBtn_Click"/>
        <asp:Button ID="nextBtn" runat="server" Text= &rarr; class="btn-next" OnClick="nextBtn_Click"/>
    </div>
  </div>
        <asp:Button ID="view" runat="server" Text="View" class="btn btn-dark view-button" OnClick="view_Click"/>
</div>

<!-- 
==================
==================
Optional Content 
==================
==================
<div class="optional">  
  <h3>Lorem ipsum dolor sit amet.</h3>
  <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Possimus asperiores natus minus ab sit. Ipsum iste, doloribus suscipit ducimus ea repudiandae consequatur soluta repellat saepe fuga, velit odit odio facilis, at sunt quis quo molestias quae. Ullam nisi, error facilis nobis maxime numquam quaerat, voluptatibus sit debitis ea quasi incidunt?</p>
</div>
-->

<!-- Google Font -->
<link href="https://fonts.googleapis.com/css?family=Roboto+Slab" rel="stylesheet">



<script>
	/*
===============================================================

Hi! Welcome to my little playground!

My name is Tobias Bogliolo. 'Open source' by default and always 'responsive',
I'm a publicist, visual designer and frontend developer based in Barcelona. 

Here you will find some of my personal experiments. Sometimes usefull,
sometimes simply for fun. You are free to use them for whatever you want 
but I would appreciate an attribution from my work. I hope you enjoy it.

===============================================================
*/
$(document).ready(function(){

  //Swipe speed:
  var tolerance = 100; //px.
  var speed = 650; //ms.

  //Elements:
  var interactiveElements = $('input, button, a');
  var itemsLength = $('.panel').length;
  var active = 1;

  //Background images:
  for (i=1; i<=itemsLength; i++){
    var $layer = $(".panel:nth-child("+i+")");
    var bgImg = $layer.attr("data-img");
    $layer.css({
      "background": "url("+bgImg+") no-repeat center / cover"
    });
  };

  //Transitions:
  setTimeout(function() {
    $(".panel").css({
      "transition": "cubic-bezier(.4,.95,.5,1.5) "+speed+"ms"
    });
  }, 200);

  //Presets:
  $(".panel:not(:first)").addClass("right");

  //Swipe:
  function swipeScreen() {
    $('.swipe').on('mousedown touchstart', function(e) {

      var touch = e.originalEvent.touches;
      var start = touch ? touch[0].pageX : e.pageX;
      var difference;

      $(this).on('mousemove touchmove', function(e) {
        var contact = e.originalEvent.touches,
        end = contact ? contact[0].pageX : e.pageX;
        difference = end-start;
      });

      //On touch end:
      $(window).one('mouseup touchend', function(e) {
        e.preventDefault();

        //Swipe right:
        if (active < itemsLength && difference < -tolerance) {
          $(".panel:nth-child("+active+")").addClass("left");
          $(".panel:nth-child("+(active+1)+")").removeClass("right");
          active += 1;
          btnDisable();
        };

        // Swipe left:
        if (active > 1 && difference > tolerance) {
          $(".panel:nth-child("+(active-1)+")").removeClass("left");
          $(".panel:nth-child("+active+")").addClass("right");
          active -= 1;
          btnDisable();
        };

        $('.swipe').off('mousemove touchmove');
      });

    });
  };
  swipeScreen();

  //Prevent swipe on interactive elements:
  interactiveElements.on('touchstart touchend touchup', function(e) {
    e.stopPropagation();
  });

  //Buttons:
  $(".btn-prev").click(function(){
    // Swipe left:
    if (active > 1) {
      $(".panel:nth-child("+(active-1)+")").removeClass("left");
      $(".panel:nth-child("+active+")").addClass("right");
      active -= 1;
      btnDisable();
    };
  });

  $(".btn-next").click(function(){
    //Swipe right:
    if (active < itemsLength) {
      $(".panel:nth-child("+active+")").addClass("left");
      $(".panel:nth-child("+(active+1)+")").removeClass("right");
      active += 1;
      btnDisable();
    };
  });


});
</script>
    </form>
</body>
</html>
