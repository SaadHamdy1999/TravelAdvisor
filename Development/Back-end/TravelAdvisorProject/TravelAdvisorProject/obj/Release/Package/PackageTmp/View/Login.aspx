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
    <li> <button style="line-height: 80px;color: #fff;padding: 2px 30px;text-decoration: none;font-size: 14px;font-weight: bold;text-transform: uppercase;background-color: inherit;margin: 0px;"  type="button" >Home</button></li>
    <li> <button style="line-height: 80px;color: #fff;padding: 2px 30px;text-decoration: none;font-size: 14px;font-weight: bold;text-transform: uppercase;background-color: inherit;margin: 0px;"  type="button"  onclick="aboutUsBtn_Click()">About Us</button></li>
   </ul>
 
 </nav>
          <div  class="container">

    <h1>Login</h1>
    <hr/>
    <label for="userName"><b>Username</b></label>
    <asp:TextBox ID="userName" type="text"  placeholder="Enter User Name" runat="server" pattern="^[0-9]*[a-zA-Z]+[0-9]*$" title="please insert data based on the required format" required="required"></asp:TextBox>
	<label for="password"><b>Password</b></label>
    <asp:TextBox ID="password" type="password"  placeholder="Enter Password" runat="server" pattern="(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,}" title="please insert data based on the required format"  required="required"></asp:TextBox>
    <asp:CheckBox ID="isAdmin" runat="server" value="admin"/>
<label for="Admin"> Is Admin</label><br>
       
                    
      <asp:Button ID="login" runat="server" Text="Login"  class="loginbtn" OnClick="login_Click"/>
      <asp:Button ID="singUp" runat="server" Text="Sign Up" class="signupbtn" OnClick="singUp_Click" formnovalidate/>

    </form>
    <div id="DivHtmlArea" style="position: fixed;bottom:0px;left:0px;width:100%; height:40px;color: white;background: rgba(0,0,0,0.6);display: none;">
           <h4 style="margin-bottom: 35px;margin-top:20px;text-align: center;">We are a great travel agency</h4>
        </div>
 <script>
     function aboutUsBtn_Click()
    {
          document.getElementById("DivHtmlArea").style.display = "block";
    }
</script>
</body>

</html>
