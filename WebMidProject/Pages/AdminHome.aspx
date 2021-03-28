<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminHome.aspx.cs" Inherits="WebMidProject.Pages.AdminHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <meta charset="utf-8"/>
    <title> Adey Admin </title>
    <link rel="stylesheet" href="../StyleSheets/Signup.css"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/css/bootstrap.min.css" rel="stylesheet" />
       <link rel="icon" type="image/png" href="../Images/favicon.png"/>
</head>
<body>
    <form id="form1" runat="server">
        <div class="card container" >
            <div>
                 ORDER NO<br />
                 <asp:Label ID="OrderNo" runat="server" Text="45678"></asp:Label>     
            </div>
          
            <div>
                  <asp:Label ID="FirstName" runat="server" Text="Abebe"></asp:Label> <br/>
                    <asp:Label ID="lastName" runat="server" Text="Kebede"></asp:Label> 
            </div>

        </div>
    </form>
</body>
</html>
