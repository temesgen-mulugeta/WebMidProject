<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderComplete.aspx.cs"
    Inherits="WebMidProject.Pages.OrderComplete" %>

    <!DOCTYPE html>

    <html xmlns="http://www.w3.org/1999/xhtml">

    <head runat="server">
        <title>Order Completed</title>
        <link rel="icon" type="image/png" href="../Images/favicon.png" />
        <style>
            body {
                font: 100% / 1.414 "Open Sans", "Roboto", arial, sans-serif;

            }
        </style>
    </head>

    <body>
        <form id="form1" runat="server">
            <!--logo-->
            <div class="logo" style="  
        margin-left:250px;
        margin-top:50px;
        margin-bottom: 30px;
        ">
                <asp:Image runat="server" src="../Images/AdminLogo.png" />
            </div>

            <!--succ-->

            <div style=" ">

                <img style="  display: block;   margin-left: auto;   margin-right: auto;   width: 500px;"
                    src="../Images/success.png" />
                <a href="UserHome.aspx" style="font-size:2rem;font-weight:bold; color:#febe19">
                    <p style="text-align:center">Go Back to Home Page</p>
                </a>
            </div>


        </form>
    </body>

    </html>