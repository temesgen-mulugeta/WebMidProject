<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebMidProject.Pages.Login" %>

<!DOCTYPE html>
<html lang="en" dir="ltr"  >
  <head>
    <meta charset="utf-8">
    <title>Login Form Design </title>
    <link rel="stylesheet" href="../StyleSheets/Signup.css">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/css/bootstrap.min.css" rel="stylesheet" >
  </head>
  <body> 
      <div class="signup__container">
    <div class="container__child signup__thumbnail">
       <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/signin.jpg" /> 
        
        </div>

      <div class="signup-form container__child"" style="width: 18rem;">
  <div class="card-body">
      
      <div>
          <h1 style="margin-bottom:20px; margin-top:-50px; font-weight:bolder">Sign In</h1>
      <form id="form2" runat="server">
          
          <p class="label">
              EMAIL</p>
         
          <asp:TextBox ID="LoginEmailTB" class="form-control" runat="server" placeholder="Email"></asp:TextBox>
          <br />
          <p class="label">
              PASSWORD</p>
          <asp:TextBox ID="LoginPasswordTB" class="form-control" runat="server" placeholder="Email"></asp:TextBox>
          
          <p>
              
             <asp:Button ID="SigninB" class="button" runat="server" OnClick="Login_Click" Text="Sign In" />
          </p>
      </form>
          </div>
      </div>
          </div>
          </div>
   

  </body>
</html>


