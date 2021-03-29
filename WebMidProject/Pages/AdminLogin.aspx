<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="WebMidProject.Pages.AdminLogin"
    %>

    <!DOCTYPE html>

    <html xmlns="http://www.w3.org/1999/xhtml">

    <head>
        <meta charset="utf-8" />
        <title>Login to Adey </title>
        <link rel="stylesheet" href="../StyleSheets/Signup.css" />
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/css/bootstrap.min.css" rel="stylesheet" />
        <link rel="icon" type="image/png" href="../Images/favicon.png" />
    </head>

    <body>
        <div class="signup__container">
            <div class="container__child signup__thumbnail">
                <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/admin.jpg" />

            </div>

            <div class="signup-form container__child" style="width: 18rem;">
                <div class="card-body">

                    <div>
                        <h1 style="margin-bottom:20px; margin-top:-50px; font-weight:bolder">Sign In</h1>
                        <form id="form2" runat="server">

                            <p class="label">
                                EMAIL</p>

                            <asp:TextBox ID="LoginEmailTB" class="form-control" runat="server" placeholder="Email">
                            </asp:TextBox>
                            <asp:RequiredFieldValidator Display="Dynamic" ID="RequiredFieldValidator2" runat="server"
                                ErrorMessage="Email cannot be blank" ControlToValidate="LoginEmailTB" ForeColor="Red">
                            </asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator Display="Dynamic" ID="RegularExpressionValidator1"
                                runat="server" ControlToValidate="LoginEmailTB" ErrorMessage="Incorrect format"
                                ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
                            </asp:RegularExpressionValidator>
                            <br />
                            <p class="label">
                                PASSWORD</p>
                            <asp:TextBox ID="LoginPasswordTB" class="form-control" runat="server" placeholder="Password">
                            </asp:TextBox>
                            <asp:RequiredFieldValidator Display="Dynamic" ID="RequiredFieldValidator4" runat="server"
                                ErrorMessage="Password cannot be blank" ControlToValidate="LoginPasswordTB"
                                ForeColor="Red"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator Display="Dynamic" ID="RegularExpressionValidator3"
                                runat="server" ControlToValidate="LoginPasswordTB"
                                ErrorMessage="Password must contain 8-15 characters" ForeColor="Red"
                                ValidationExpression="^(?=.*[A-Za-z0-9])(?=.*\d)[A-Za-z0-9\d]{8,15}">
                            </asp:RegularExpressionValidator>

                            <p>

                                <asp:Button ID="AdminSignB" class="button" runat="server" OnClick="Admin_Login_Click"
                                    Text="Sign In" />
                            </p>
                            <a href="Login.aspx"
                                style="color:#febe19; margin-top:-30px;margin-left:10px; font-weight:bold">Login as
                                User</a>

                        </form>
                    </div>
                </div>
            </div>
        </div>


    </body>

    </html>