<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateArtist.aspx.cs" Inherits="KpopZstation.View.UpdateArtist" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login | KpopZstation</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-KK94CHFLLe+nY2dmCWGMq91rCGa5gtU4mk92HdvYe+M/SXH301p5ILy+dN9+nJOZ" crossorigin="anonymous">
    <link href="css/Globla.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="w-100 d-flex justify-content-center align-items-center " style="height: 100vh;">
            <div class="border border-black p-5 d-flex flex-column gap-3" style="width:600px;">
                <p class="fs-1 fw-bold m-0">Update Artist</p>

                <div class="d-flex align-items-center gap-2">
                    <img src="<%= arImage %>" class="rounded-circle bg-black" style="width: 60px; height: 60px;" alt="Alternate Text" />
                    <p class="m-0 fw-bold"><%= arName %></p>
                </div>

                <asp:TextBox class="px-2" style="height: 50px;" ID="nameTxtbox" runat="server" placeholder="Username" type="text" ></asp:TextBox>
                <asp:Label class="text-danger" ID="errorArtistNamelbl" runat="server" Text="Label" Visible="false"></asp:Label>

                <div class="p-2" id="FileUploadBox" runat="server">
                    <asp:FileUpload ID="FileUpload" runat="server" />
                </div>
                <asp:Label class="text-danger" ID="errorArtistFilelbl" runat="server" Text="Label" Visible="false"></asp:Label>
                
                <asp:Button class="btn btn-dark fw-bold" ID="Button1" OnClick="UpdateArtistBtn" runat="server" Text="Update Artist" />
            </div>    
        </div>
    </form>
</body>
</html>