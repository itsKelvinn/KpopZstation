<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AlbumUpdate.aspx.cs" Inherits="KpopZstation.View.AlbumUpdate" %>

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
         
            
            <div class="border border-black p-4 d-flex flex-column gap-3">
                
                <div class="d-flex align-items-center border border-black p-2 gap-4">
                    <img src="<%=album.AlbumImage %>" alt="Alternate Text" style="width:100px; height: 100px;" />
                    <p class="m-0 fw-bold"><%= album.AlbumName %></p>
                    <p class="m-0 fw-bold">IDR <%= album.AlbumPrice %></p>
                    <p class="m-0 fw-bold" style="width:600px;"><%= album.AlbumDescription %></p>
                </div>

                <p class="fs-1 fw-bold m-0">Update Album</p>
                <asp:TextBox style="height:50px;" class="px-2" ID="albumNameTxtbox" runat="server" placeholder="Album Name" type="text" ></asp:TextBox>
                <asp:Label class="text-danger" ID="errorAlbumNamelbl" runat="server" Text="Label" Visible="false" ></asp:Label>

                <asp:TextBox style="height:50px;" class="px-2" ID="albumPriceTxtbox" runat="server" placeholder="Album Price" type="text" ></asp:TextBox>
                <asp:Label class="text-danger" ID="errorAlbumPricelbl" runat="server" Text="Label" Visible="false" ></asp:Label>

                <asp:TextBox style="height:50px;" class="px-2" ID="albumStockTxtbox" runat="server" placeholder="Album Stock" type="text" ></asp:TextBox>
                <asp:Label class="text-danger" ID="errorAlbumStocklbl" runat="server" Text="Label" Visible="false" ></asp:Label>

                <div class="d-flex flex-column">
                    <asp:Label  ID="Label1" runat="server" Text="Descripton" ></asp:Label>
                    <textarea class="px-2" style="height:100px;" id="albumDescTxtarea" runat="server" cols="20" rows="2" ></textarea>
                </div>    
                <asp:Label class="text-danger" ID="errorAlbumDesclbl" runat="server" Text="Label" Visible="false" ></asp:Label>

                <div id="FileUploadBox" class="p-2" runat="server">
                    <asp:FileUpload ID="FileUpload" runat="server" />
                </div>
                <asp:Label class="text-danger" ID="errorAlbumFileUploadlbl" runat="server" Text="Label" Visible="false"></asp:Label>

                <asp:Button class="btn btn-dark fw-bold" ID="Button1" OnClick="Update_Album_Button" runat="server" Text="Update Album" />
            </div>    
        </div>
    </form>
</body>
</html>