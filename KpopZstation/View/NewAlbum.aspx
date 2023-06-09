<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewAlbum.aspx.cs" Inherits="KpopZstation.View.NewAlbum" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login | KpopZstation</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-KK94CHFLLe+nY2dmCWGMq91rCGa5gtU4mk92HdvYe+M/SXH301p5ILy+dN9+nJOZ" crossorigin="anonymous">
    <link href="CSS/Globla.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="w-100 d-flex justify-content-center align-items-center " style="height: 100vh;">
            <div class="border border-black p-5 d-flex flex-column gap-3" style="width:500px;">
                <p class="fs-1 fw-bold m-0">New Album</p>
                <asp:TextBox class="px-2" style="height: 50px;" ID="AlbumNameTxtbox" runat="server" placeholder="Album Name" type="text" ></asp:TextBox>
                <asp:Label class="text-danger" ID="errorAlbumNameLabel" runat="server" Text="Label" Visible="false">Must be filled and smaller than 50 characters</asp:Label>
                
                <asp:TextBox class="px-2" style="height: 50px;" ID="AlbumPriceTxtbox" runat="server" placeholder="Album Price" type="text" ></asp:TextBox>
                <asp:Label class="text-danger" ID="errorAlbumPriceLabel" runat="server" Text="Label" Visible="false"></asp:Label>
                
                <asp:TextBox class="px-2" style="height: 50px;" ID="AlbumStockTxtbox" runat="server" placeholder="Album Stock" type="text" ></asp:TextBox>
                <asp:Label class="text-danger" ID="errorAlbumStockLabel" runat="server" Text="Label" Visible="false"></asp:Label>   
                
                <div class="d-flex flex-column">
                    <asp:Label  ID="Label1" runat="server" Text="AlbumDescText" Visible="true"></asp:Label>
                    <textarea id="albumDescTextArea" class="py-2 px-2" style="height:100px;" cols="20" rows="2" runat="server"></textarea>
                </div>
                <asp:Label class="text-danger" ID="errorAlbumDescLabel" runat="server" Text="Label" Visible="false"></asp:Label>
                
                <div class="w-100 d-flex px-2 justify-content-center align-items-center" style="height:50px;" id ="uploadFileBorder" runat="server">
                    <asp:FileUpload class="d-flex w-100" ID="FileUpload" runat="server" />
                </div>
                <asp:Label class="text-danger" ID="errorAlbumFileLabel" runat="server" Text="Label" Visible="false"></asp:Label>
                <asp:Button class="btn btn-dark fw-bold" ID="AddAlbumBtn" runat="server" Text="Add Album" OnClick="addAlbumBtn"/>
            </div>    
        </div>
    </form>
</body>
</html>