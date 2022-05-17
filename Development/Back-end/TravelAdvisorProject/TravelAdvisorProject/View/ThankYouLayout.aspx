<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ThankYouLayout.aspx.cs" Inherits="TravelAdvisorProject.View.ThankYou" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>Thank You</title>

    <link rel="stylesheet" href="ThankYouStyle.css">
</head>
<body>
    <form id="form1" runat="server">
		<nav>
		   <div class="logo">
			 <img src="../images/u.png" class="img-fluid">
		   </div>
		   <ul>
			 <li>
                 <asp:Button ID="Home" class="HomeBtn" runat="server" Text="Home" OnClick="Home_Click" style="line-height: 80px;color: #fff; padding: 12px 30px; text-decoration: none; font-size: 14px;font-weight: bold; text-transform: uppercase;"/></li>
		   </ul>
		 </nav>
		 <div class="header"><h1><span>Thank You<span><h1/></div>
		<div id="footer">
			<h4>We are a great travel agency</h4>
		</div>
		
		
		
		<script>
			function myFunction()
			{
				document.getElementById("Footer").style.display = "block";
			}
		</script>
    </form>
</body>
</html>
