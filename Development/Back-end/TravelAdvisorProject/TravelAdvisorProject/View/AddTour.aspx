<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddTour.aspx.cs" Inherits="TravelAdvisorProject.View.AddTour" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>Add Tour</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
	<link href="https://fonts.googleapis.com/css?family=Archivo+Black&display=swap" rel="stylesheet"/>
  <link rel="stylesheet" type= "text/css" href= "style.css"/>
</head>
<body id="t">
        <div class="gradient-text">
	<h1 id="head">  Add Tour</h1>
	</div>
    <form id="form1" runat="server">

	  <div id="content1">

	    
        <asp:Label ID="tourNameLable" runat="server" Text="Tour Name"></asp:Label><br/><br/>
        <asp:TextBox ID="tourName" type ="text" runat="server" class= "box"></asp:TextBox><br/><br/>
          <asp:Label ID="costLabel" runat="server" Text="Cost"></asp:Label><br/><br/>
          <asp:TextBox ID="cost" type = "text" runat="server" class= "box"></asp:TextBox><br/><br/>
          <asp:Label ID="countryLabel" runat="server" Text="Country"></asp:Label><br/><br/>
          
	  <div id= "option1">
       <asp:DropDownList ID="country" runat="server">
           <asp:ListItem Value="PL">Poland</asp:ListItem>
           <asp:ListItem Value="PK">Pakistan</asp:ListItem>
           <asp:ListItem Value="TH">Thailand</asp:ListItem>
           <asp:ListItem Value="TR">Turkey</asp:ListItem>
           <asp:ListItem Value="ID">Indonesia</asp:ListItem>
           <asp:ListItem Value="GR">Greece</asp:ListItem>
           <asp:ListItem Value="BS">Bahamas</asp:ListItem>
           <asp:ListItem Value="ZW">Zimbabwe</asp:ListItem>
           <asp:ListItem Value="NL">Netherlands</asp:ListItem>
           <asp:ListItem Value="CH">Switzerland</asp:ListItem>
           <asp:ListItem Value="SE">Sweden</asp:ListItem>
          </asp:DropDownList>
	  <br/><br/>

          <asp:Label ID="flightDataLabel" runat="server" Text="Flight Date"></asp:Label><br/><br/>
          
          <asp:TextBox ID="flightDate" type ="date" runat="server" class= "box"></asp:TextBox> <br/><br/>
       <asp:Label ID="endDateLabel" runat="server" Text="End Date"></asp:Label><br/><br/>
          <asp:TextBox ID="endDate" type ="date" runat="server" class= "box"></asp:TextBox> <br/><br/>
          <asp:Label ID="durationLabel" runat="server" Text="Duration"></asp:Label><br/><br/>
          <asp:TextBox ID="duration" type ="Text" runat="server" class= "box"></asp:TextBox> <br/><br/>
	  <br/><br/>

        <asp:Label ID="uploadImageLable" runat="server" Text="Add First Image"></asp:Label><br /> <asp:FileUpload ID="imageUpload" runat="server" />
          <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
          <br /><br />
        <asp:Label ID="uploadSecondImgLable" runat="server" Text="Add Second Image"></asp:Label><br /> <asp:FileUpload ID="secondImgUpload" runat="server" />

	      <asp:Label ID="Label2" runat="server" Text=""></asp:Label>

	  <br/><br/>
          <asp:Button ID="submit" runat="server" Text="Submit" OnClick="submit_Click" />
	  </div>
	  </div>
    </form>
</body>
</html>
