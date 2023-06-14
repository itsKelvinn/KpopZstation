<%@ Page Title="" Language="C#" MasterPageFile="~/View/Partial/Navbar.Master" AutoEventWireup="true" CodeBehind="ArtistDetail.aspx.cs" Inherits="KpopZstation.View.ArtistDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div>
            <div class="d-flex align-items-center gap-5 py-5">
                <img class="rounded-circle bg-dark" style="width:300px; height:300px;" src="<%= artist.ArtistImage %>" alt="<%= artist.ArtistName %>" />
                <p class="m-0 fs-1 fw-bold"><%= artist.ArtistName %></p>
            </div>
        </div>
        <div class="d-flex flex-column w-100 justify-content-center align-items-center gap-3 border-top border-black py-3">
            
            <div class="d-flex justify-content-between align-items-center w-100 ">
                <p class="m-0 fs-2 fw-bold">Album</p>
                <div>
                    <asp:PlaceHolder ID="newAlbumBtn" runat="server" Visible="false">
                        <%string slug = "/View/NewAlbum.aspx/?id=" + artist.ArtistID; %>
                        <a class="btn btn-outline-dark" href="<%= slug %>">New Album</a>
                    </asp:PlaceHolder>
                </div>
            </div>


            <asp:PlaceHolder ID="AlbumCollection" runat="server" Visible="false">
                <div class="w-100 d-flex flex-column justify-content-start align-items-center gap-3 border border-black p-3" style="min-height: 343px;">
                    
                    <asp:Repeater ID="Repeater" runat="server">

                        <ItemTemplate>
                        
                            <div class="border border-dark p-2 d-flex justify-content-between align-items-center gap-3 w-100">
                                <div class="d-flex justify-content-between align-items-center gap-5">
                                    <img style="width:150px; height:150px;" src="<%# Eval("AlbumImage") %>" alt="Alternate Text" />
                                    <p class="m-0 fw-bold d-flex justify-content-center" style="width:200px;"><%# Eval("AlbumName") %></p>
                                    <p class="m-0 fw-bold d-flex justify-content-center" style="width:150px;">IDR <%# Eval("AlbumPrice") %></p>

                                    <p class="m-0 fw-normal" style="width:550px;">
                                        <%# Eval("AlbumDescription") %>
                                    </p>
                                </div>
                                <div class="d-flex align-items-center justify-content-center gap-3" style="width:800px;">
                                    <a href="/View/AlbumDetail.aspx/?id=<%# Eval("AlbumID")%>" class="btn btn-dark fw-bold d-flex justify-content-center align-items-center" style="height:50px; width: 200px;" visible="false" >Album Detail</a>
                                    <asp:Button class="btn btn-warning fw-bold" CommandName="updateAlbum" OnCommand="Album_Update_btn" CommandArgument='<%# Eval("AlbumID") %>' UseSubmitBehavior="false" ID="updateBtn" runat="server" Text="Update" visible="false"/>
                                    <asp:Button class="btn btn-danger fw-bold" CommandName="deleteAlbum" OnCommand="Album_Delete_btn" CommandArgument='<%# Eval("AlbumID") %>' UseSubmitBehavior="false" ID="deleteBtn" runat="server" Text="Delete" visible="false"/>
                                </div>
                            </div>

                        </ItemTemplate>
                </asp:Repeater>


                </div>
            </asp:PlaceHolder>

            <asp:PlaceHolder ID="AlbumEmpty" runat="server" Visible="false">
                <div class="w-100 d-flex flex-column justify-content-center align-items-center gap-3 border border-black p-3" style="min-height: 343px;">
                
                    <h1 class="fs-2">Sorry , There is not Album yet !!!</h1>

                </div>
            </asp:PlaceHolder>

        </div>
    </div>
</asp:Content>
