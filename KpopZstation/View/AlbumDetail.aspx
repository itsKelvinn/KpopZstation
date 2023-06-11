<%@ Page Title="" Language="C#" MasterPageFile="~/View/Partial/Navbar.Master" AutoEventWireup="true" CodeBehind="AlbumDetail.aspx.cs" Inherits="KpopZstation.View.AlbumDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="w-100 d-flex align-items-center justify-content-center gap-5" style="height:821px;">
        <img src="<%= album.AlbumImage %>" style="width:500px; height:500px;" alt="Alternate Text" />
        <div class="d-flex flex-column align-items-start gap-2" style="width:900px;">
            <div class="d-flex align-items-center justify-content-between w-100">
                <p class="fs-1 fw-bold m-0"><%= album.AlbumName %></p>
                <p class="fw-bold m-0">IDR <%= album.AlbumPrice %></p>
            </div>

            <p class="m-0"> <%= album.AlbumDescription %> </p>
           
            <div class="d-flex align-items-center gap-2">
                <p class="m-0">Stock</p> <p class="m-0"><%= album.AlbumStock %></p>
            </div>

            <div class="d-flex align-items-center gap-2 p-2" id="ChartBox" runat="server">
                <asp:Button ID="decreaseButton" runat="server" Text="-" style="width:30px;" OnClick="DecreaseButton_Click" />
                <asp:Label ID="quantityTextBox" runat="server" Text="0"></asp:Label>
                <asp:Button ID="increaseButton" runat="server" Text="+" style="width:30px;" OnClick="IncreaseButton_Click" />
            </div>
            <asp:Label class="text-danger" ID="errorQuantitylbl" runat="server" Text="Label"></asp:Label>

            <asp:Button class="btn btn-dark" ID="addchartBtn" OnClick="addChart" runat="server" Text="Add Chart" />
        </div>
    </div>
</asp:Content>
