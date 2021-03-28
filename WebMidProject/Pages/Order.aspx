<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/UserMaster.Master" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="WebMidProject.Pages.Order" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../StyleSheets/Orders.css" rel="stylesheet" type="text/css" />
    <title>Make Orders</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
   
      <div class="order__container" style="
              right: 0;
              left: 0;
              margin-right: auto;
              margin-left: auto;
              overflow: hidden;
              display: flex;
              margin-top: 150px;
              margin-bottom: 210px;
              align-items: center;
              justify-content: center;
              width: 750px;
              height: 550px;
              border-radius: 1rem;
              box-shadow: 0px 2px 6px rgba(0,0,0,.25);
          ">
    <div class="container__child signup__thumbnail">
        
       <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/order.jpg" />
        
        </div>

      <div class="signup-form container__child"" style="width: 18rem;">
  <div class="card-body">
      
      <div>
          <h1 style="margin-bottom:20px; margin-top:-50px; font-weight:bolder">Order Now</h1>
      
          <p class="label">
              ORDER TYPE</p>
          <asp:DropDownList ID="orderTypeList" AutoPostBack="true" OnSelectedIndexChanged="orderTypeList_TextChanged" class="form-control" runat="server" placeholder="Order Type">
          </asp:DropDownList>
          
          <br />
          <p class="label">
             ORDER SIZE</p>
          <asp:DropDownList ID="orderDimensionsList" AutoPostBack="true" OnSelectedIndexChanged="orderDimensionsList_TextChanged" class="form-control" runat="server" placeholder="Order Type">
          </asp:DropDownList>
          
          
          <p class="label" style="margin-top:15px;">
              Quantity</p>
          <asp:TextBox ID="QuantityTB" class="form-control" runat="server" placeholder="Quantity"></asp:TextBox>

          <p class="label" style="margin-top:15px;">
              Upload Design</p>
          <asp:FileUpload ID="FileUpload" class="form-control" runat="server" placeholder="Upload FIle" />
          <br />
        
          <p>
              <asp:Button ID="OrderB" class="button" runat="server" Text="Order" OnClick="OrderB_Click"/>
              <asp:Label ID="TotalAmountLabel" runat="server"/>
          </p>
            
          </div>
      </div>
          </div>
          </div>
   
    
   
</asp:Content>


