<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UsuarioWF.aspx.cs" Inherits="MyWebForm.Registros.UsuarioWF" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="jumbotron">
        <h5 align="center">Registro de Usuarios</h5>
        <div class="col-md-6 col-md-offset-3">
            <div class="container">
                <div class="form-group">
                    <asp:Label ID="Label1" runat="server" Text="UsuarioId"></asp:Label>
                    <asp:Button class="btn btn-primary" ID="BuscarButton" runat="server" Text="Buscar" />
                    <asp:TextBox class="form-control" ID="usuarioIdTextBox" placeholder="0" runat="server"></asp:TextBox>
                </div>
            </div>
        </div>
        <asp:Image id="UsuarioImage" runat="server" Height="59px" ImageUrl="~/Imagenes/img_logo_01.jpg" runat="server" Width="190px" AlternateText="Imagen no disponible" ImageAlign="right" />
        <div class="col-md-6 col-md-offset-3">
            <div class="container">
                <div class="form-group">
                    <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
                    <asp:TextBox class="form-control" ID="nombreTextBox" placeholder="Nombre" runat="server"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="col-md-6 col-md-offset-3">
            <div class="container">
                <div class="form-group">
                    <asp:Label ID="Label3" runat="server" Text="Número de Teléfono"></asp:Label>
                    <asp:TextBox class="form-control" ID="noTelefonoTextBox" placeholder="###-###-####" runat="server"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="col-md-6 col-md-offset-3">
            <div class="container">
                <div class="form-group">
                    <asp:Label ID="Label4" runat="server" Text="Email"></asp:Label>
                    <asp:TextBox class="form-control" ID="emailTextBox" placeholder="micorreo@gmail.com" runat="server"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="col-md-6 col-md-offset-3">
            <div class="container">
                <div class="form-group">
                    <asp:Label ID="Label5" runat="server" Text="Contraseña"></asp:Label>
                    <asp:TextBox class="form-control" ID="passwordTextBox" runat="server"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="col-md-6 col-md-offset-3">
            <div class="container">
                <div class="form-group">
                    <asp:Label ID="Label6" runat="server" Text="Confirmar Contraseña"></asp:Label>
                    <asp:TextBox class="form-control" ID="cpasswordTextBox" runat="server"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="col-md-6 col-md-offset-3">
            <div class="container">
                <div class="form-group">
                    <asp:Label ID="Label7" runat="server" Text="Tipo de Usuario"></asp:Label>
                    <asp:DropDownList class="form-control" ID="DropDownList1" runat="server"></asp:DropDownList>
                </div>
            </div>
        </div>
        <div class="col-md-4 col-md-offset-3">
            <div class="container">
                <div class="form-group">
                    <asp:Button class="btn btn-primary" ID="nuevoButton" runat="server" Text="Nuevo" />
                    <asp:Button class="btn btn-success" ID="guardarButton" runat="server" Text="Guardar" />
                    <asp:Button class="btn btn-danger" ID="eliminarutton" runat="server" Text="Eliminar" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
