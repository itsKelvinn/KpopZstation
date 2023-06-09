<%@ Page Title="" Language="C#" MasterPageFile="~/View/Partial/Navbar.Master" AutoEventWireup="true" CodeBehind="UpdateUser.aspx.cs" Inherits="KpopZstation.View.UpdateUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-flex flex-column align-items-center w-100">
        <p class="m-0 fs-1 fw-bold m-3">User Profile</p>
        <div class="border border-black p-4 d-flex align-items-center gap-2" style="width:600px;">
            <div class="bg-black" style="width:150px; height:150px;"></div>
            <div class="d-flex flex-column gap-2">
                <div class="d-flex gap-2">
                    <asp:TextBox class="px-2" ID="nameTxtbox" runat="server" placeholder="Full Name"></asp:TextBox>
                    <asp:TextBox class="px-2" ID="addressTxtbox" runat="server" placeholder="Address"></asp:TextBox>
                </div>
                <div class="d-flex gap-2">
                    <asp:TextBox class="px-2" ID="emailTxtbox" runat="server" placeHolder="Email"></asp:TextBox>
                    <asp:TextBox class="px-2" ID="passwordTxtbox" runat="server" placeHolder="Password"></asp:TextBox>
                </div>
                <asp:RadioButtonList ID="genderRadioButtonList" RepeatDirection="Horizontal" cssClass="test" runat="server">
                    <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                    <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
                </asp:RadioButtonList>
                
                <asp:Button class="btn btn-dark" ID="Update" runat="server" Text="Update" />
            </div>
        </div>
    </div>
</asp:Content>
