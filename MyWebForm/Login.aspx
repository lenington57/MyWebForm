<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MyWebForm.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h5 class="display-4" style="font-weight: bold; background-color: #0000FF">Iniciar Sesión</h5>
    <br>
    <div class="form-group col-md-3">
        <asp:Label ID="Label1" runat="server" Text="Email">Email</asp:Label>
        <asp:TextBox ID="CriterioTextBox" AutoCompleteType="Disabled" class="form-control input-group" placeholder="micorreo@gmail.com" runat="server"></asp:TextBox>
    </div>    
    <asp:Image ID="UsuarioImage" runat="server" Height="510px" ImageUrl="~/Resources/factura.jpg" runat="server" Width="705px" AlternateText="Imagen no disponible" ImageAlign="right" />
    <div class="col-md-3">
        <asp:Label ID="Label2" runat="server" Text="Contraseña">Contraseña</asp:Label>
        <asp:TextBox ID="TextBox1" AutoCompleteType="Disabled" class="form-control input-group" type="password" runat="server"></asp:TextBox>
        <br>
        <asp:Button class="form-control btn btn-primary col-sm-4 " ID="entrarButton" runat="server" Text="Entrar" />
    </div>
    <br>
    <br>
    <br>
    <br>
    <br>
    <br>
    <br>
    <br>
    <br>
    <br>
    <br>
    <br>
    <br>
</asp:Content>

