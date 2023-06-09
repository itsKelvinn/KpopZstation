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
            <div class="border border-black p-5 d-flex flex-column gap-3">
                <p class="fs-1 fw-bold m-0">Update Artist</p>
                <div class="d-flex align-items-center gap-2">
                    <div class="rounded-circle bg-black" style="width: 60px; height: 60px;"></div>
                    <p class="m-0 fw-bold">Artist Name</p>
                </div>
                <asp:TextBox class="px-2" ID="nameTxtbox" runat="server" placeholder="Username" type="text" ></asp:TextBox>
                <asp:FileUpload ID="FileUpload" runat="server" />
                
                <asp:Button class="btn btn-dark fw-bold" ID="Button1" runat="server" Text="Update Artist" />
            </div>    
        </div>
    </form>
</body>
</html>