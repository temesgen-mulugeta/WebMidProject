<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminHome.aspx.cs" Inherits="WebMidProject.Pages.AdminHome" %>

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

        <div class=" container" >
            <div class="child">
                 ORDER ID<br />
                 <asp:Label class="bigno" ID="OrderNo" runat="server" Text="112"></asp:Label>     
            </div>
          
            <div class="child ">
                    ORDERED BY <br/>
                <div class="name">
                          <asp:Label  ID="FirstName" runat="server" Text="Abebe"></asp:Label> <br/>
                    <asp:Label ID="lastName" runat="server" Text="Kebede"></asp:Label> 
                </div>
            
            </div>

            <div class="child ">
                    ORDER TYPE <br/>
                  <asp:Label class="name type" ID="type" runat="server" Text="Business Card" ></asp:Label> <br/>
                    
            </div>

            
            <div class="child ">
                    ORDER SIZE <br/>
                  <asp:Label class="name" ID="size" runat="server" Text="50x50" ></asp:Label> <br/>        
            </div>
            <div class="child ">
                   Quantity <br/>
                  <asp:Label class="name" ID="quantity" runat="server" Text="15" ></asp:Label> <br/>        
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
    </form>
</body>
</html>
