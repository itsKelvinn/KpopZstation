<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateProfile.aspx.cs" Inherits="KpopZstation.View.UpdateProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register | KpopZstation</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-KK94CHFLLe+nY2dmCWGMq91rCGa5gtU4mk92HdvYe+M/SXH301p5ILy+dN9+nJOZ" crossorigin="anonymous">
    <link href= CSS/Globla.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="w-100 d-flex justify-content-center align-items-center " style="height: 100vh;">
            <div class="border border-black p-5 d-flex flex-column gap-3" style="width:450px;">
                <p class="fs-1 fw-bold m-0">Update Profile</p>
                
                <asp:TextBox class="px-2" style="height: 50px;" ID="nameTxtbox" runat="server" placeholder="Full Name" type="text" ></asp:TextBox>
                <asp:Label Visible="false" class="text-danger" ID="errorNamelbl" runat="server" Text="Label"></asp:Label>
                
                <asp:TextBox class="px-2" style="height: 50px;" ID="emailTxtbox" runat="server" placeholder="Email" type="text" ></asp:TextBox>
                <asp:Label Visible="false" class="text-danger" ID="errorEmaillbl" runat="server" Text="Label"></asp:Label>
                
                <div class="p-2" id="Genderbox" runat="server">
                    <asp:RadioButtonList ID="genderRadioButtonList" RepeatDirection="Horizontal" class="d-flex" runat="server">
                        <asp:ListItem Text="Male" Value="Male" class="d-flex gap-2"></asp:ListItem>
                        <asp:ListItem Text="Female" Value="Female" class="d-flex gap-2 mx-5"></asp:ListItem>
                    </asp:RadioButtonList>
                </div>
                <asp:Label Visible="false" class="text-danger" ID="errorGenderlbl" runat="server" Text="Label"></asp:Label>
                
                <asp:TextBox class="px-2" style="height: 50px;" ID="addressTxtbox" runat="server" placeholder="Address" type="text" ></asp:TextBox>
                <asp:Label Visible="false" class="text-danger" ID="errorAddresslbl" runat="server" Text="Label"></asp:Label>
                
                <asp:TextBox class="px-2" style="height: 50px;" ID="passwordTxtbox" runat="server" placeholder="Password" type="password" ></asp:TextBox>
                <asp:Label Visible="false" class="text-danger" ID="errorPaswordLbl" runat="server" Text="Label"></asp:Label>

                <asp:Button class="btn btn-dark fw-bold" ID="Button1" runat="server" Text="Update" OnClick="Button1_Click" />
            </div>    
        </div>
    </form>
</body>
</html>
