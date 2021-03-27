<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="WebMidProject.Pages.Home" %>


<!DOCTYPE html>
<html lang="en" dir="ltr"  >
  <head>
    <meta charset="utf-8">
    <title>Login Form Design | Code4Education</title>
    <link rel="stylesheet" href="../StyleSheets/Signup.css">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-eOJMYsd53ii+scO/bJGFsiCZc+5NDVN2yr8+0RDqr0Ql0h+rP48ckxlpbzKgwra6" crossorigin="anonymous">
  </head>
  <body> 
      <div class="signup__container">
    <div class="container__child signup__thumbnail">
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/signup.jpg" />
        
        </div>

      <div class="signup-form container__child"" style="width: 18rem;">
  <div class="card-body">
      
      <div>
          <h1 style="margin-bottom:20px; margin-top:-50px; font-weight:bolder">Sign Up</h1>
      <form id="form1" runat="server">
          <p class="label">
              NAME</p>
          <asp:TextBox ID="NameTB" class="form-control" runat="server" placeholder="Full Name" ></asp:TextBox>
          <br />
          <p class="label">
              PHONE NUMBER</p>
          <asp:TextBox ID="PhoneTB" class="form-control" runat="server" placeholder="Phone Number"></asp:TextBox>
          <br />
          <p class="label">
              EMAIL</p>
          <asp:TextBox ID="EmailTB"  class="form-control" runat="server" placeholder="Email"></asp:TextBox>
          <br />
          <p class="label">
              PASSWORD</p>
          <asp:TextBox ID="PasswordTB"  class="form-control" runat="server" placeholder="Password"></asp:TextBox>
          <p>
              <asp:Button ID="SignupB" class="button" runat="server" Text="Sign Up" />
          </p>
      </form>
          </div>
      </div>
          </div>
          </div>
   

  </body>
</html>


