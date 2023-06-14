<%@ Page Title="" Language="C#" MasterPageFile="~/View/Partial/Navbar.Master" AutoEventWireup="true" CodeBehind="TransactionHistory.aspx.cs" Inherits="KpopZstation.View.TransactionHistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="w-100 d-flex flex-column align-items-center justify-content-start gap-3">
        <p class="m-0 fs-1 fw-bold">Transaction History</p>
        
        <div class="w-100 d-flex flex-column align-items-center justify-content-start gap-4">

            <div class="d-flex flex-column gap-3" style="width:500px;" id="transaction" runat="server" Visible="false">
                <%foreach (var transac in listTransHeader){ %>
                <div class="d-flex flex-column border border-black px-2 w-100 ">
                    <div class="d-flex justify-content-between w-100 border-bottom border-black">
                        <p class="m-0 fw-bold"> Transaction ID :  <%=transac.TransactionID%></p>
                        <p class="m-0 fw-bold">Date : <%=transac.TransactionDate%></p>
                    </div>
                    <div class="d-flex flex-column py-2 w-100 border-bottom border-black">
                        <p class="m-0 fw-bold">Customer</p>
                        <div class="d-flex align-items-center gap-2">
                            <p class="m-0"><%=customer.CustomerName %></p>
                        </div>
                    </div>
                    <div class="d-flex flex-column border-bottom border-black w-100 py-2">
                        <p class="m-0 fw-bold">Album</p>
                        <div class="d-flex align-items-center gap-2">
                            <% 
                                KpopZstation.Model.TransactioDetail transDetail = getTransactionDetail(transac.TransactionID);
                                KpopZstation.Model.Album Album = GetAlbum(transDetail.AlbumID);
                            %>
                            <img style="width:80px; height:80px;" src="<%= Album.AlbumImage %>" alt="Alternate Text" />
                            <div class="d-flex flex-column">
                                <p class="m-0"><%= Album.AlbumName %></p>
                                <div class="d-flex gap-2">
                                    <p class="m-0">Quantity</p>
                                    <p class="m-0"><%= transDetail.Qty %></p>
                                </div>
                                <p class="m-0">Album Price : IDR <%=Album.AlbumPrice  %></p>
                                <p class="m-0">Total : IDR <%= Album.AlbumPrice * transDetail.Qty %></p>
                            </div> 
                       </div>
                    </div>
                    <div class="w-100">
                        <p class="m-0 fw-bold">Courir : Online</p>
                    </div>
                   </div>
                <%} %>
            </div>


            <%--if transaction Empty--%>
            <div class="d-flex justify-content-center align-items-center border border-black p-4" style="width:500px; height: 700px;" id="transEmpty" runat="server" Visible="false">
                <h1 class="fw-bold text-center"> There's no Transaction : )</h1>
            </div>


        </div>
    </div>
</asp:Content>
