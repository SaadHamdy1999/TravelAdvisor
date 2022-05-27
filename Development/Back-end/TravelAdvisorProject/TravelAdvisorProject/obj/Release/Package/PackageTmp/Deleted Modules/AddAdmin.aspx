
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Admin</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="icon" href="../images/u.png">
    <link rel="stylesheet" href="astyle.css">
    <link href="https://fonts.googleapis.com/css?family=Archivo+Black&display=swap" rel="stylesheet">
    <link rel="stylesheet" href="css/bootsrap.min.css">
   <!--<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.1/dist/css/bootstrap.min.css">-->
</head>
<body>
    <form id="form1" runat="server">
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
      <h1 id="header">Add Admin</h1>
    </div>
    <div id="content1">
    <label for="userName"><b>Username</b></label><br/>
    <asp:TextBox ID="admin_name" placeholder="" class="box" runat="server" required></asp:TextBox><br/><br/><br/>

    <label for="email"><b>Email</b></label><br/>
    <asp:TextBox ID="admin_email" type="text" placeholder="" class="box" runat="server" required></asp:TextBox><br/><br/><br/>

	<label for="password"><b>Password</b></label><br/>
    <asp:TextBox ID="admin_password" type="password" placeholder="" class="box" runat="server" required></asp:TextBox><br/><br/><br/>
    
 	<label for="confirmPassword"><b>Confirm Password</b></label><br/>
    <asp:TextBox ID="admin_cpassword" type="password" placeholder="" class="box" runat="server" required></asp:TextBox><br/><br/><br/>

   
    <asp:Button ID="reset" runat="server" Text="Reset" type="reset"  class="btn"/>
    <asp:Button ID="addU" runat="server" Text="Add Admin"  class="resetbtn" OnClick="addA_Click"/>
 </div>
</form>
</body>
</html>

    </form>
</body>
</html>
