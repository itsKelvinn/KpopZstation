<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="KpopZstation.View.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login | KpopZstation</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-KK94CHFLLe+nY2dmCWGMq91rCGa5gtU4mk92HdvYe+M/SXH301p5ILy+dN9+nJOZ" crossorigin="anonymous">
    <link href="css/Globla.css" rel="stylesheet" />
</head>

<body>
    <form id="form1" runat="server">
        <div class="w-100 d-flex justify-content-center align-items-center " style="height: 100vh;">
            <div class="border border-black p-5 d-flex flex-column gap-3" style="width:455px;">
                <p class="fs-1 fw-bold m-0">Login</p>
  
                <asp:Label ID="ErrorLabel" runat="server" Text="Label" class="alert alert-danger m-0" role="alert" Visible="false">
                    Invalid email or password. Please try again.
                </asp:Label>
                
                <asp:TextBox class="px-2" style="height: 50px;" ID="emailTxtbox" runat="server" placeholder="Username" type="text" ></asp:TextBox>
                <asp:TextBox class="px-2" style="height: 50px;" ID="passwordTxtbox" runat="server" placeholder="Password" type="password" ></asp:TextBox>
                
                <div class="w-100 d-flex align-items-center gap-2" >
                    <asp:CheckBox ID="CheckBox" runat="server" />
                    <p class="m-0">Remmeber me</p>
                </div>
                
                <asp:Button class="btn btn-dark fw-bold" style="height: 50px;" ID="loginbtn" runat="server" Text="Login" OnClick="loginBtn" />
                <p class="m-0 "> Tidak punya akun ? sini <a href="Register.aspx">register</a></p>
            </div>    
        </div>
    </form>
</body>
</html>