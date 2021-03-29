﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminHome.aspx.cs" Inherits="WebMidProject.Pages.AdminHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <meta charset="utf-8"/>
    <title> Adey Admin </title>
    <link rel="stylesheet" href="../StyleSheets/AdminHome.css"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/css/bootstrap.min.css" rel="stylesheet" />
       <link rel="icon" type="image/png" href="../Images/favicon.png"/>
</head>
<body>
        <form id="form1" runat="server">
    <!--logo-->
    <div class="logo" style="  
        margin-left:250px;
        margin-top:50px;
        margin-bottom: 30px;
        ">
        <asp:Image runat="server"  src="../Images/AdminLogo.png" />
    </div>
    <div>
        <div style="display:inline-block">
                 <h1 class="headText" style="
                     margin-left:400px;
                     font-size: 3rem;
                     font-weight: bold;
                    
                     margin-top: 40px;
                     ">
                     Your Orders</h1>
        </div>

        <!-- log out -->
        <div style="display:inline-block">
            <div  style="
                     margin-left:850px;
                     font-size: 2rem;
                     font-weight: bold;
                    
                     margin-top: 40px;
                     ">
                <asp:Button ID="logoutB" class="button" runat="server" Text="Log Out" OnClick="Logout_Click" />
            </div>
            
            
        </div>
    </div>

    <!-- card -->
            <table>
                    <%foreach (var order in allOrders) { %>
                                <tr>
                                    <td>

        <div class=" container" >
            <div class="child">
                 ORDER ID<br />
                
                 <Label class="bigno" ID="OrderNo"><%=order.orderId%></Label>     
            </div>
          
            <div class="child ">
                    ORDERED BY <br/>
                <div class="name">
                          <Label ID="FirstName"><%=order.clientName%></Label> <br/>
                </div>
            
            </div>

            <div class="child ">
                    ORDER TYPE <br/>
                  <Label class="name type" ID="type"><%=order.serviceType%></Label> <br/>
                    
            </div>

            
            <div class="child ">
                    ORDER SIZE <br/>
                  <Label class="name" ID="size"><%=order.dimensions%></Label> <br/>        
            </div>
            <div class="child ">
                   Quantity <br/>
                  <Label class="name" ID="quantity" Text="15" ><%=order.quantity%></Label> <br/>        
            </div>
            <div class="child" style="float:right;vertical-align:top">
                 <div class="child" >
                  DESIGN FILE <br/>
                <asp:Button ID="downloadB" class="button" runat="server" Text="Download File" OnClick="Download_Click" />
            </div>
            <div class="child" >
                 
                <asp:ImageButton ID="deleteB" class="button" runat="server" Text="Download File" OnClick="Download_Click" src="../Images/delete.png" />
                
            </div>
            </div>
           

        </div>
               </td></tr>

                    <% } %>
                </table>
    </form>
</body>
</html>
