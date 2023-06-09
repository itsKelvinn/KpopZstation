<%@ Page Title="" Language="C#" MasterPageFile="~/View/Partial/Navbar.Master" AutoEventWireup="true" CodeBehind="TransactionHistory.aspx.cs" Inherits="KpopZstation.View.TransactionHistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="w-100 d-flex flex-column align-items-center justify-content-start gap-3">
        <p class="m-0 fs-1 fw-bold">Transaction History</p>
        
        <div class="w-100 d-flex flex-column align-items-center justify-content-start gap-4">
            <div class="d-flex flex-column border border-black px-2" style="width:500px;">
                <div class="d-flex justify-content-between w-100 border-bottom border-black">
                    <p class="m-0 fw-bold">TRA001</p>
                    <p class="m-0 fw-bold">12-10-22</p>
                </div>
                <div class="d-flex flex-column py-2 w-100 border-bottom border-black">
                    <p class="m-0 fw-bold">Customer</p>
                    <div class="d-flex align-items-center gap-2">
                        <div class="rounded-circle bg-black" style="width:60px; height: 60px;"></div>
                        <p class="m-0">Customer Name</p>
                    </div>
                </div>
                <div class="d-flex flex-column border-bottom border-black w-100 py-2">
                    <p class="m-0 fw-bold">Album</p>
                    <div class="d-flex align-items-center gap-2">
                        <div class="bg-black" style="width:80px; height:80px;"></div>
                        <div class="d-flex flex-column">
                            <p class="m-0">Album name</p>
                            <p class="m-0">IDR 1.000.000</p>
                            <div class="d-flex gap-2">
                                <p class="m-0">Quantity</p>
                                <p class="m-0">2</p>
                            </div>
                        </div> 
                   </div>
                </div>
                <div class="w-100">
                    <p class="m-0 fw-bold">Courir</p>
                </div>
            </div>

        </div>
    </div>
</asp:Content>
