<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CUsuarioWF.aspx.cs" Inherits="MyWebForm.Consultas.CUsuarioWF" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="jumbotron">
        <h5 class="display-4">Consulta de Usuarios</h5>
        <br>
        <div class="form-row justify-content-center">
            <%--Filtro--%>
            <div class="form-group col-md-2">
                <asp:Label Text="Filtro" class="text-primary" runat="server" />
                <asp:DropDownList ID="FiltroDropDownList" CssClass="form-control" runat="server">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem>UsuarioId</asp:ListItem>
                    <asp:ListItem>Nombre</asp:ListItem>
                    <asp:ListItem>Email</asp:ListItem>
                </asp:DropDownList>
            </div>
            <%--Criterio--%>
            <div class="form-group col-md-3">
                <asp:Label ID="Label1" runat="server" Text="Buscar">Buscar:</asp:Label>
                <asp:TextBox ID="CriterioTextBox" AutoCompleteType="Disabled" class="form-control input-group" runat="server"></asp:TextBox>
            </div>
            <div class="col-lg-1 p-0">
                <asp:LinkButton ID="BuscarLinkButton" CssClass="btn btn-outline-info mt-4" runat="server">
                <span class="fas fa-search"></span>
                 Buscar
                </asp:LinkButton>
            </div>
        </div>
        <%--Rango fecha--%>
        <div class="form-row justify-content-center">
            <div class="form-group col-md-2">
                <asp:Label Text="Desde" class="text-primary" runat="server" />
                <asp:TextBox ID="DesdeTextBox" class="form-control input-group" TextMode="Date" runat="server" />
            </div>
            <div class="form-group col-md-2">
                <asp:Label Text="Hasta" class="text-primary" runat="server" />
                <asp:TextBox ID="HastaTextBox" class="form-control input-group" TextMode="Date" runat="server" />
            </div>
        </div>
    </div>
</asp:Content>
