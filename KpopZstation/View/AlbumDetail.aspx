<%@ Page Title="" Language="C#" MasterPageFile="~/View/Partial/Navbar.Master" AutoEventWireup="true" CodeBehind="AlbumDetail.aspx.cs" Inherits="KpopZstation.View.AlbumDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="w-100 d-flex align-items-center justify-content-center gap-5" style="height:821px;">
        <div class="bg-black" style="width:500px; height:500px;"></div>
        <div class="d-flex flex-column align-items-start gap-2" style="width:900px;">
            <div class="d-flex align-items-center justify-content-between w-100">
                <p class="fs-1 fw-bold m-0">Album Name</p>
                <p class="fw-bold m-0">IDR 1.000.000</p>
            </div>

            <p class="m-0">Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.</p>
           
            <div class="d-flex align-items-center gap-2">
                <p class="m-0">Stock</p> <p class="m-0">20</p>
            </div>

            <div class="d-flex align-items-center gap-2">
                <asp:Button ID="decreaseButton" runat="server" Text="-" style="width:30px;" OnClick="DecreaseButton_Click" />
                <asp:Label ID="valueTextBox" runat="server" Text="0"></asp:Label>
                <asp:Button ID="increaseButton" runat="server" Text="+" style="width:30px;" OnClick="IncreaseButton_Click" />
            </div>

            <asp:Button class="btn btn-dark" ID="addchartBtn" runat="server" Text="Add Chart" />
        </div>
    </div>
</asp:Content>
