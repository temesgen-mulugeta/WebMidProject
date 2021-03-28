<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/UserMaster.Master" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="WebMidProject.Pages.Order" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../StyleSheets/Orders.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    

      <div class="signup__container">
    <div class="container__child signup__thumbnail">
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/order.jpg" />
        
        </div>

      <div class="signup-form container__child"" style="width: 18rem;">
  <div class="card-body">
      
      <div>
          <h1 style="margin-bottom:20px; margin-top:-50px; font-weight:bolder">Order Now</h1>
      
          <p class="label">
              ORDER TYPE</p>
          <asp:DropDownList ID="orderType" class="form-control" runat="server" placeholder="Order Type">
              <asp:ListItem>Business Card</asp:ListItem>
              <asp:ListItem>Post Card</asp:ListItem>
              <asp:ListItem>Brochure</asp:ListItem>
              <asp:ListItem>Sticker</asp:ListItem>
          </asp:DropDownList>
          
          <br />
          <p class="label">
             ORDER SIZE</p>
          <asp:DropDownList ID="orderSize" class="form-control" runat="server" placeholder="Order Type">
              <asp:ListItem>Business Card</asp:ListItem>
              <asp:ListItem>Post Card</asp:ListItem>
              <asp:ListItem>Brochure</asp:ListItem>
              <asp:ListItem>Sticker</asp:ListItem>
          </asp:DropDownList>
          
          
          <p class="label" style="margin-top:15px;">
              Quantity</p>
          <asp:TextBox ID="QuantityTB"  class="form-control" runat="server" placeholder="Quantity"></asp:TextBox>
          <br />
        
          <p>
              <asp:Button ID="OrderB" class="button" runat="server" Text="Order" OnClick="orderB_Click" />
          </p>
     
          </div>
      </div>
          </div>
          </div>
   

</asp:Content>


