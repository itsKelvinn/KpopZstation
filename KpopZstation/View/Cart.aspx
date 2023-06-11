<%@ Page Title="" Language="C#" MasterPageFile="~/View/Partial/Navbar.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="KpopZstation.View.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-flex w-100 justify-content-center ">
        <div class="d-flex flex-column px-4 gap-2" style="width: 900px; height: 835px;">
            <p class="fs-1 m-0 fw-bold">Cart</p>
            <div class="w-100 d-flex flex-column gap-2 border border-black p-2 overflow-auto" style="height:100%;" >

            <asp:Repeater ID="RepeaterCart" runat="server">
                <ItemTemplate>
                    <div class="d-flex align-items-center border border-black w-100 p-2 gap-2">
                        <img style="height: 100px; width:100px;" src='<%# getAlbum(Convert.ToInt32(Eval("AlbumID"))).AlbumImage %>' alt="Alternate Text" />
                        <p class="m-0 fw-bold d-flex justify-content-start gap-2" style="width: 250px;">
                            Album Name :
                            <span class="m-0 fw-normal">
                                <%# getAlbum(Convert.ToInt32(Eval("AlbumID"))).AlbumName %>
                            </span>
                        </p>
                        <p class="m-0 fw-bold d-flex justify-content-start gap-2" style="width: 150px;">
                            Quantity : <%# Eval("Qty") %>
                            <span class="m-0 fw-normal">12</span>
                        </p>
                        <p class="m-0 fw-bold d-flex justify-content-start gap-2" style="width: 150px;">
                            Price :
                            <span class="m-0 fw-normal">
                                <%# getAlbum(Convert.ToInt32(Eval("AlbumID"))).AlbumPrice %>
                            </span>
                        </p>
                        <div class="p-4 d-flex justify-content-center" style="width: 120px;">
                            <asp:Button class="btn btn-danger" ID="Button1" OnCommand="delete_cart_btn" CommandName="deleteCart" CommandArgument='<%#Eval("AlbumID")%>' UseSubmitBehavior="false" runat="server" Text="Remove" />
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>


            </div>
            <div class="d-flex justify-content-between align-items-center p-4 border border-black">
                <div class="d-flex flex-column">
                    <h1 class="fs-2 fw-bold">Total Checkout</h1>
                    <p class="fs-4 fw-normal m-0"> IDR 100000 </p>
                </div>
                <div>
                    <asp:Button class="btn btn-dark fw-bold" style="width:130px; height:50px;" ID="Button" Onclick="checkOut_btn" runat="server" Text="CheckOut" />
                </div>
            </div>
        </div>
    </div>


</asp:Content>
