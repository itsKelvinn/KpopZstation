﻿<%@ Page Title="Home | KpopZstation" Language="C#" MasterPageFile="~/View/Partial/Navbar.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="KpopZstation.View.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="w-100 d-flex flex-column gap-2 py-5">

        <div class="w-100 d-flex flex-column justify-content-center align-items-center" style="height:210px;" > 

            <p class="display-5 fw-bold m-0 text-center">Hi <%= username %></p>
            <p class="display-5 fw-bold m-0 text-center">Welcome to the KpopZtation</p>

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

                <div class="w-100 d-flex border border-black p-3" style="min-height: 450px;">
                
                    <%--Artist Cards--%>
                    <div class="w-100 d-flex flex-wrap" id="container">
                        <asp:Repeater ID="ArtistsRepeater" runat="server">
                            <ItemTemplate>
                                <div class="card">
                                    <img src="<%# Eval("ArtistImage") %>" class="card-img-top" alt="...">
                                    <div class="card-body">
                                        <h5 class="card-title fw-bold"><%# Eval("ArtistName") %></h5>
                                        <div class="w-100 d-flex gap-2">
                                            <a href="<%# "ArtistDetail.aspx/?id=" + Eval("ArtistID") %>" class="btn btn-dark" >View Artist</a>
                                            <asp:HyperLink href='<%# "UpdateArtist.aspx/?id=" + Eval("ArtistID") %>' class="btn btn-warning" Visible="false" ID="updatebtn" runat="server" >Update</asp:HyperLink>
                                            <asp:Button 
                                                class="btn btn-danger" 
                                                ID="deletebtn" 
                                                runat="server" 
                                                CommandName="delete" 
                                                OnCommand="DeleteArtistBtn_Click" 
                                                CommandArgument='<%# Eval("ArtistID") %>'  
                                                Text="Delete" 
                                                UseSubmitBehavior="false" 
                                                Visible="false"
                                            />
                                        </div>
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
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
