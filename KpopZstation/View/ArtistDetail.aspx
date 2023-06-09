<%@ Page Title="" Language="C#" MasterPageFile="~/View/Partial/Navbar.Master" AutoEventWireup="true" CodeBehind="ArtistDetail.aspx.cs" Inherits="KpopZstation.View.ArtistDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div>
            <div class="d-flex align-items-center gap-5 py-5">
                <div class="rounded-circle bg-dark" style="width:300px; height:300px;"></div>
                <p class="m-0 fs-1 fw-bold">Artist Name</p>
            </div>
        </div>
        <div class="d-flex flex-column w-100 justify-content-center align-items-center gap-3 border-top border-black py-3">
            
            <div class="d-flex justify-content-between align-items-center w-100 ">
                <p class="m-0 fs-2 fw-bold">Album</p>
                <div>
                    <a class="btn btn-outline-dark" href="#">New Album</a>
                </div>
            </div>


            <div class="w-100 d-flex flex-column justify-content-center align-items-center gap-3">
                
                <div class="border border-dark p-2 d-flex justify-content-between align-items-center gap-3 w-100">
                    <div class="d-flex justify-content-between align-items-center gap-5">
                        <div class="bg-dark" style="width:150px; height:150px;"></div>
                        <p class="m-0 fw-bold d-flex justify-content-center" style="width:200px;">Album Name</p>
                        <p class="m-0 fw-bold d-flex justify-content-center" style="width:150px;">IDR 1.000.000</p>

                        <p class="m-0 fw-normal" style="width:550px;">
                            Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galle
                        </p>
                    </div>
                    <div class="d-flex align-items-center justify-content-center gap-3" style="width:800px;">
                        <asp:Button class="btn btn-dark fw-bold" style="height:50px; width: 200px;" ID="detailBtn" runat="server" Text="View Detail" />

                        <%--<asp:Button class="btn btn-dark fw-bold" ID="updateBtn" runat="server" Text="Update" />--%>
                        <%--<asp:Button class="btn btn-danger fw-bold" ID="deleteBtn" runat="server" Text="Delete" />--%>
                    </div>
                </div>

                <div class="border border-dark p-2 d-flex justify-content-between align-items-center gap-3 w-100">
                    <div class="d-flex justify-content-between align-items-center gap-5">
                        <div class="bg-dark" style="width:150px; height:150px;"></div>
                        <p class="m-0 fw-bold d-flex justify-content-center" style="width:200px;">Album Name</p>
                        <p class="m-0 fw-bold d-flex justify-content-center" style="width:150px;">IDR 1.000.000</p>

                        <p class="m-0 fw-normal" style="width:550px;">
                            Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galle
                        </p>
                    </div>
                    <div class="d-flex align-items-center justify-content-center gap-3" style="width:800px;">
                        <asp:Button class="btn btn-dark fw-bold" style="height:50px; width: 200px;" ID="Button1" runat="server" Text="View Detail" />

                        <%--<asp:Button class="btn btn-dark fw-bold" ID="updateBtn" runat="server" Text="Update" />--%>
                        <%--<asp:Button class="btn btn-danger fw-bold" ID="deleteBtn" runat="server" Text="Delete" />--%>
                    </div>
                </div>

                <div class="border border-dark p-2 d-flex justify-content-between align-items-center gap-3 w-100">
                    <div class="d-flex justify-content-between align-items-center gap-5">
                        <div class="bg-dark" style="width:150px; height:150px;"></div>
                        <p class="m-0 fw-bold d-flex justify-content-center" style="width:200px;">Album Name</p>
                        <p class="m-0 fw-bold d-flex justify-content-center" style="width:150px;">IDR 1.000.000</p>

                        <p class="m-0 fw-normal" style="width:550px;">
                            Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galle
                        </p>
                    </div>
                    <div class="d-flex align-items-center justify-content-center gap-3" style="width:800px;">
                        <asp:Button class="btn btn-dark fw-bold" style="height:50px; width: 200px;" ID="Button2" runat="server" Text="View Detail" />

                        <%--<asp:Button class="btn btn-dark fw-bold" ID="updateBtn" runat="server" Text="Update" />--%>
                        <%--<asp:Button class="btn btn-danger fw-bold" ID="deleteBtn" runat="server" Text="Delete" />--%>
                    </div>
                </div>

            </div>

        </div>
    </div>
</asp:Content>
