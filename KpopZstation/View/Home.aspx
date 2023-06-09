<%@ Page Title="" Language="C#" MasterPageFile="~/View/Partial/Navbar.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="KpopZstation.View.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="w-100 d-flex flex-column gap-5">
        <div class="w-100 d-flex flex-column"> 

            <p class="fs-1 fw-bold m-0">Hi <%= username %></p>
            <p class="fs-1 fw-bold m-0">Welcome to the KpopZtation</p>

        </div>

        <div class="w-100 d-flex flex-column">

            <div class="w-100 d-flex justify-content-between">

                <p class="fs-2 fw-bold">Artists</p>

                <asp:PlaceHolder runat="server" ID="AddNewArtistBtn" Visible="false">
                    <div>
                        <a href="InsertArtist.aspx" class="btn btn-outline-dark">Add New Artist</a>
                    </div>
                </asp:PlaceHolder>

            </div>

            <div class="w-100 d-flex flex-wrap gap-3">
                
                <%--Artist Cards--%>

                <div class="card" style="width: 18rem;">
                    <img src="..." class="card-img-top" alt="...">
                    <div class="card-body">
                        <h5 class="card-title">Card title</h5>
                        <a href="#" class="btn btn-dark">View Artist</a>
                    </div>
                </div>

                

            </div>

        </div>

    </div>

</asp:Content>
