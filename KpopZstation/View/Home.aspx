<%@ Page Title="" Language="C#" MasterPageFile="~/View/Partial/Navbar.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="KpopZstation.View.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="w-100 d-flex flex-column gap-2 py-5">

        <div class="w-100 d-flex flex-column justify-content-center" style="height:210px;" > 

            <p class="display-5 fw-bold m-0">Hi <%= username %></p>
            <p class="display-5 fw-bold m-0">Welcome to the KpopZtation</p>

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

            <asp:PlaceHolder runat="server" ID="ArtistCollect" Visible="false">

                <div class="w-100 d-flex align-items-center flex-wrap gap-3 border border-black p-3" style="min-height: 450px;">
                
                    <%--Artist Cards--%>

                    <%foreach (var artist in Artists) {  %>

                        <div class="card">
                            <img src="<%=artist.ArtistImage%>" class="card-img-top" alt="...">
                            <div class="card-body">
                                <h5 class="card-title"><%= artist.ArtistName %></h5>
                                <% string slug = "ArtistDetail.aspx" + "/?id=" + artist.ArtistID; %>
                                <a href="<%=slug%>" class="btn btn-dark">View Artist</a>
                            </div>
                        </div>

                    <%}%>

                </div>
            </asp:PlaceHolder>

            <asp:PlaceHolder runat="server" ID="ArtistEmpty" Visible="false">
                <div class="w-100 d-flex justify-content-center align-items-center border border-black p-3" style="min-height: 450px;">
                    <h1 class="fs-2">There is not Artist yet !!!</h1>
                </div>
            </asp:PlaceHolder>


        </div>

    </div>

</asp:Content>
