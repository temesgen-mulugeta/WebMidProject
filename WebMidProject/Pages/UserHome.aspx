<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/UserMaster.Master" AutoEventWireup="true"
    CodeBehind="UserHome.aspx.cs" Inherits="WebMidProject.Pages.UserHome" %>
    <asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

        <link href="../StyleSheets/UserHome.css" rel="stylesheet" type="text/css" />
        <title>Adey Printing</title>
    </asp:Content>

    <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="container first-container">
            <div class=" first-container-left">
                <h1 class="headText">Print Your Ideas</h1>
                <p>Welcome to adey online printing service. <br /> High Quality Printing Service
                </p>
                <asp:Button ID="orderNowB" class="button" runat="server" Text="Order Now" />
            </div>
            <div class="first-container-right">
                <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/Home.png" />
            </div>
        </div>

        <!--services head -->
        <div class="container services">
            <h1 class="headText">Our Services</h1>
        </div>
        <p style="text-align:center;margin-top:-15px;">We provide high quality printing services for</p>

        <!--services -->
        <div class="container">
            <!--business card -->
            <a href="Pricing.aspx">

                <div class="card" style="width: 18rem;">
                    <img class="card-img-top" src="../Images/UserHome/businesscard.jpg" alt="Card image cap">
                    <div class="card-body">
                        <h5 class="card-title">Business Cards</h5>
                        <p class="card-text"></p>

                    </div>
                </div>
            </a>


            <!--post Card -->
            <a href="Pricing.aspx">
                <div class="card" style="width: 18rem;">
                    <img class="card-img-top" src="../Images/UserHome/postcard.jpg" alt="Card image cap">
                    <div class="card-body">
                        <h5 class="card-title">Post Cards</h5>
                        <p class="card-text"></p>

                    </div>
                </div>

            </a>

            <!--Brochures -->
            <a href="Pricing.aspx">
                <div class="card" style="width: 18rem;">
                    <img class="card-img-top" src="../Images/UserHome/brochure.jpg" alt="Card image cap">
                    <div class="card-body">
                        <h5 class="card-title">Brochures</h5>
                        <p class="card-text"></p>

                    </div>
                </div>

            </a>

            <!--Stickers -->
            <a href="Pricing.aspx">
                <div class="card" style="width: 18rem;">
                    <img class="card-img-top" src="../Images/UserHome/sticker.jpg" alt="Card image cap">
                    <div class="card-body">
                        <h5 class="card-title">Stickers</h5>
                        <p class="card-text"></p>

                    </div>
                </div>
            </a>

        </div>

        <!-- -->


        <!--quality head -->

        <!--Quality -->
        <div>
            <h1 class="qualityHead">We Believe in Quality</h1>
            <p style="text-align:center;margin-bottom:30px;">We don't compromise quality.<br /> We always deliver the
                quality you desire!</p>
            <div class="container gifcontainer">
                <div class="gifimage">
                    <img src="../Images/UserHome/gifImage.jpg" alt="Card image cap">
                </div>
                <div class="gifthumb">
                    <img src="../Images/UserHome/homegif.gif" alt="Card image cap">
                </div>
            </div>
        </div>


    </asp:Content>