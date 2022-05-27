<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TourBooking.aspx.cs" Inherits="TravelAdvisorProject.View.TourBooking" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Tour</title>
	<meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
		<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous"/>
		<script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
		<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
		<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>
		<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"/>
		<link  rel="stylesheet" href="TourStyle.css"/>
</head>
<body>
    <form id="form1" runat="server">
    <nav>
		   <div class="logo">
			 <img src="../images/u.png" class="img-fluid"/>
		   </div>
		   <ul>
			 <li>
                 <asp:Button ID="Home" runat="server" Text="Home" OnClick="Home_Click" style="line-height: 80px;
    color: #fff;
    padding: 1px 30px;
    text-decoration: none;
    font-size: 17px;
    font-weight: bold;
    text-transform: uppercase;
    text-decoration: none;background: inherit;border: none;cursor: pointer;"/>
			 </li>
		   </ul>
		 </nav>
		 
		<div class="row">

		</div>
        <div  class="row">

        </div>
        <div  class="row">

        </div>
		
		<div class="container">
			<div class="splitview skewed">
				<div class="panel bottom">
					<div class="content">
                        <asp:Image ID="Image1" runat="server" alt="england"/>
					</div>
				</div>

				<div class="panel top">
					<div class="content">
						<div class="description">
							<h3>Tour name: </h3>
                            <asp:Label ID="tourName" runat="server" Text=""></asp:Label>
							<h3>Country name: </h3>
                            <asp:Label ID="countryName" runat="server" Text=""></asp:Label>
							<h3>Flight date: </h3>  
							<asp:Label ID="flightDate" runat="server" Text=""></asp:Label>
                            <br />
							<h3>End date: </h3>
							<asp:Label ID="endDate" runat="server" Text=""></asp:Label>
                            <br />
							<h3>Duration: </h3>
							<asp:Label ID="Duration" runat="server" Text="3"></asp:Label>
							<br/>
							<h3>Cost: </h3>
							<asp:Label ID="cost" runat="server" Text=""></asp:Label>
						</div>
                        <asp:Image ID="Image2" runat="server" />
					</div>
				</div>

				<div class="handle"></div>
			</div>
			<div class="row buttons">
				<div class="col offset-4">
					<a href=".//ThankYouLayout.html" style="text-decoration:none">
                        <asp:Button ID="book" runat="server" Text="Book"  class="btn btn-dark" OnClientClick="return confirm('Are you sure you want to book ?')" OnClick="book_Click"/>
						
					</a>
					
					<a>
						<button  onclick="myFooter()" type="button" class="btn btn-dark">About Us</button>
					</a> 
				</div>
			</div>
		</div>

		<div id="footer">
			<h4>We are a great travel agency</h4>
		</div>
	<script>
		function myFooter() {
  document.getElementById("footer").style.display = "block";
}
	</script>
		<script>
		document.addEventListener('DOMContentLoaded', function() {
		var parent = document.querySelector('.splitview'),
        topPanel = parent.querySelector('.top'),
        handle = parent.querySelector('.handle'),
        skewHack = 0,
        delta = 0;

		// If the parent has .skewed class, set the skewHack var.
		if (parent.className.indexOf('skewed') != -1) {
			skewHack = 1000;
		}

		parent.addEventListener('mousemove', function(event) {
			// Get the delta between the mouse position and center point.
			delta = (event.clientX - window.innerWidth / 2) * 0.5;

			// Move the handle.
			handle.style.left = event.clientX + delta + 'px';

			// Adjust the top panel width.
			topPanel.style.width = event.clientX + skewHack + delta + 'px';
		});
	});

	</script>
    </form>
</body>
</html>
