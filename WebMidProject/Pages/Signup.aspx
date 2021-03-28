<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="WebMidProject.Pages.Home" %>


<!DOCTYPE html>
<html lang="en" dir="ltr"  >
  <head>
    <meta charset="utf-8">
    <title>Login Form Design | Code4Education</title>
    <link rel="stylesheet" href="../StyleSheets/Signup.css">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/css/bootstrap.min.css" rel="stylesheet">
  </head>
  <body> 
      <div class="signup__container">
    <div class="container__child signup__thumbnail">
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/signup.jpg" />
        
        </div>

      <div class="signup-form container__child"" style="width: 18rem;">
  <div class="card-body">
      
      <div>
          <h1 style="margin-bottom:5px; margin-top:-50px; font-weight:bolder">Sign Up</h1>
      <form id="form1" runat="server">
          <p class="label">NAME</p>
          <asp:TextBox ID="NameTB" class="form-control" runat="server" placeholder="Full Name" ></asp:TextBox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name cannot be blank" ControlToValidate="NameTB" ForeColor="Red"></asp:RequiredFieldValidator>  
          <br />
          <p class="label" style="margin-top:5px;">PHONE NUMBER</p>
          <asp:TextBox Display="Dynamic" ID="PhoneTB" class="form-control" runat="server" placeholder="Phone Number"></asp:TextBox>
                     <asp:RequiredFieldValidator Display="Dynamic" ID="RequiredFieldValidator3" runat="server" ErrorMessage="Mobile cannot be blank" ControlToValidate="PhoneTB" ForeColor="Red"></asp:RequiredFieldValidator>  
           <asp:RegularExpressionValidator Display="Dynamic" ID="RegularExpressionValidator2" runat="server" ControlToValidate="PhoneTB" ErrorMessage="Mobile number must be 10 digit" ForeColor="Red" ValidationExpression="\d{10}"></asp:RegularExpressionValidator>  
          <br />

          <p class="label" style="margin-top:5px;">EMAIL</p>
          <asp:TextBox ID="EmailTB"  class="form-control" runat="server" placeholder="Email"></asp:TextBox>
            <asp:RequiredFieldValidator Display="Dynamic" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Email cannot be blank" ControlToValidate="EmailTB" ForeColor="Red"></asp:RequiredFieldValidator>  
            <asp:RegularExpressionValidator  Display="Dynamic" ID="RegularExpressionValidator1" runat="server" ControlToValidate="EmailTB" ErrorMessage="Incorrect format" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator> 
          <p style="margin-top:5px;" class="label">
              PASSWORD</p>
          <asp:TextBox ID="PasswordTB"  class="form-control" runat="server" placeholder="Password"></asp:TextBox>
          <asp:RequiredFieldValidator Display="Dynamic" ID="RequiredFieldValidator4" runat="server" ErrorMessage="Password cannot be blank" ControlToValidate="PasswordTB" ForeColor="Red"></asp:RequiredFieldValidator>  
            <asp:RegularExpressionValidator  Display="Dynamic" ID="RegularExpressionValidator3" runat="server" ControlToValidate="PasswordTB" ErrorMessage="Password must contain 8-15 characters" ForeColor="Red" ValidationExpression="^(?=.*[A-Za-z0-9])(?=.*\d)[A-Za-z0-9\d]{8,15}"></asp:RegularExpressionValidator> 
          <p>
              <asp:Button ID="SignupB" class="button" runat="server" Text="Sign Up" OnClick="SignupB_Click" />
          </p>
      </form>
          </div>
      </div>
          </div>
          </div>
   

  </body>
</html>


