<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddUser.aspx.cs" Inherits="TravelAdvisorProject.View.AddUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add User</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="icon" href="../images/u.png">
    <link rel="stylesheet" href="bstyle.css">
    <link href="https://fonts.googleapis.com/css?family=Archivo+Black&display=swap" rel="stylesheet">
    <link rel="stylesheet" href="css/bootsrap.min.css">
   <!--<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.1/dist/css/bootstrap.min.css">-->
</head>
<body>
   
 <form id="form" runat="server">
      <nav>
   <div class="logo">
     <img src="../images/u.png" class="img-fluid">
   </div>
   <ul>
     <li><a href= "#">Home</a></li>
     <li><a href= "#">About Us</a></li>
   </ul>
</nav>
  <div  class="container">
      <h1 id="header">Add User</h1>
    </div>
    <div id="content1">
    <label for="userName"><b>Username</b></label><br/>
     <asp:TextBox ID="username" placeholder="" class="box" runat="server" required></asp:TextBox><br/><br/><br />

    <label for="email"><b>Email</b></label><br/>
    <asp:TextBox ID="email" type="text" placeholder="" class="box" runat="server" required></asp:TextBox><br/><br/><br/>

	<label for="password"><b>Password</b></label><br/>
    <asp:TextBox ID="password" type="password" placeholder="" class="box" runat="server" required></asp:TextBox><br/><br/><br/>
    
 	<label for="confirmPassword"><b>Confirm Password</b></label><br/>
    <asp:TextBox ID="cpassword" type="password" placeholder="" class="box" runat="server" required></asp:TextBox><br/><br/><br/>

     <label for="phone"><b>Mobile Number</b></label><br/>
    <asp:TextBox ID="phone" type="text" placeholder="" class="box" pattern="[0-9]+" title="a phone can't have characters" runat="server" required></asp:TextBox><br/><br/><br/>
   
    <label for="age"><b>Age</b></label><br/>
    <asp:TextBox ID="age" type="text" placeholder=""  class="box" runat ="server" required></asp:TextBox><br/><br/><br/>

   
    <asp:Button ID="reset" runat="server" Text="Reset"   class="btn"/>
    <asp:Button ID="addU" runat="server" Text="Add User"  OnClick="addU_Click" class="resetbtn"/>
 </div>
</form>
</body>
</html>
