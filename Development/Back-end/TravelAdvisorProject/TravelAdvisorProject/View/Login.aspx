<%@ Page Language="C#" AutoEventWireup="true"  CodeBehind="Login.aspx.cs" Inherits="TravelAdvisorProject.View.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Form</title>
<link rel="icon" href="../Images/download.jpg"/>
<link rel="stylesheet" href="login_form.css"/>
<link rel= "stylesheet" href= "nstyle.css"/>
</head>
<body>
    <form id="form1" runat="server">
    <nav>
   <div class="logo">
     <img src="../Images/u.png" class="img-fluid"/>
   </div>
   <ul>
     <li><a href= "#">Home</a></li>
     <li><a href= "#">About Us</a></li>
   </ul>
 
 </nav>
          <div  class="container">

    <h1>Login</h1>
    <hr/>
    <label for="userName"><b>Username</b></label>
    <asp:TextBox ID="userName" type="text"  placeholder="Enter User Name" runat="server" required></asp:TextBox>
	<label for="password"><b>Password</b></label>
    <asp:TextBox ID="password" type="password"  placeholder="Enter Password" runat="server" pattern="(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,}" title="Must contain at least one number and one uppercase and lowercase letter, and at least 8 or more characters" 
 required></asp:TextBox>
    <asp:CheckBox ID="isAdmin" runat="server" value="admin"/>
<label for="Admin"> Is Admin</label><br>
       
                    
      <asp:Button ID="login" runat="server" Text="Login"  class="loginbtn" OnClick="login_Click"/>
      <asp:Button ID="singUp" runat="server" Text="Sign Up" class="signupbtn" OnClick="singUp_Click" />



  </div>
    </form>
</body>
</html>
