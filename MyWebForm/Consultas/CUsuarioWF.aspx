<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CUsuarioWF.aspx.cs" Inherits="MyWebForm.Consultas.CUsuarioWF" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h5 class="display-4" style="font-weight: bold; background-color: #0000FF">Consulta de Usuarios</h5>
    <div class="form-row justify-content-center">
        <%--Filtro--%>
        <div class="form-group col-md-2">
            <asp:Label Text="Filtro" class="text-primary" runat="server" />
            <asp:DropDownList ID="FiltroDropDownList" CssClass="form-control" runat="server">
                <asp:ListItem>Todo</asp:ListItem>
                <asp:ListItem>UsuarioId</asp:ListItem>
                <asp:ListItem>Nombre</asp:ListItem>
                <asp:ListItem>Email</asp:ListItem>
            </asp:DropDownList>
        </div>
        <%--Criterio--%>
        <div class="form-group col-md-3">
            <asp:Label ID="Label1" class="text-primary" runat="server" Text="Criterio">Criterio</asp:Label>
            <asp:TextBox ID="CriterioTextBox" AutoCompleteType="Disabled" class="form-control input-group" runat="server"></asp:TextBox>
        </div>
        <div class="col-lg-1 p-0">
            <asp:LinkButton ID="BuscarLinkButton" CssClass="btn btn-outline-info mt-4" runat="server" OnClick="BuscarLinkButton_Click">
                <span class="fas fa-search"></span>
                 Buscar
            </asp:LinkButton>
        </div>
    </div>
    <%--GRID--%>
    <div class="form-row justify-content-center">
        <asp:GridView ID="UsuarioGridView" runat="server" class="table table-condensed table-bordered table-responsive" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="LightSkyBlue" />
            <Columns>
                <asp:BoundField DataField="UsuarioId" HeaderText="Usuario Id" />
                <asp:BoundField DataField="Nombres" HeaderText="Nombre" />
                <asp:BoundField DataField="NoTelefono" HeaderText="No. Telefónico" />
                <asp:BoundField DataField="Email" HeaderText="Email" />
                <asp:BoundField DataField="Password" HeaderText="Contraseña" />
                <asp:BoundField DataField="CPassword" HeaderText="Confirmación" />
                <asp:BoundField DataField="TipoUsuario" HeaderText="Tipo" />
            </Columns>
            <HeaderStyle BackColor="LightGreen" Font-Bold="True" />
        </asp:GridView>
    </div>
</asp:Content>
