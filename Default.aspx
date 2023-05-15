<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio13._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1 align = "center">MANEJO DE PRODUCTOS TIENDA LA BENDICION</h1>
        <p  class="lead">Producto:</p>
        <p  class="lead">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Código de producto:
            <asp:TextBox ID="TextBoxCodigoProducto" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp; Nombre del producto:
            <asp:TextBox ID="TextBoxNombreProducto" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp; </p>
        <p  class="lead">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Descripción del producto:
            <asp:TextBox ID="TextBoxDescripcionProducto" runat="server" Width="549px"></asp:TextBox>
        </p>
        <p  class="lead">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Precio de compra:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxPrecioCompra" runat="server" Width="197px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Precio de venta:&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxPrecioVenta" runat="server" Width="179px"></asp:TextBox>
        </p>
        <p  class="lead">Tipo de producto:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownListTipoProducto" runat="server" Width="223px">
                <asp:ListItem>Alimento</asp:ListItem>
                <asp:ListItem>Electronico</asp:ListItem>
                <asp:ListItem>Libro</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p  class="lead">Alimentos:</p>
        <p  class="lead">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Fecha de vencimiento:
            <asp:TextBox ID="TextBoxAFechaVencimiento" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp; Unidad de medida:
            <asp:TextBox ID="TextBoxAUnidadMedida" runat="server"></asp:TextBox>
        </p>
        <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButtonRegistrarProducto" class="btn btn-primary btn-lg" runat="server" Text="REGISTRAR PRODUCTO" OnClick="ButtonRegistrarProducto_Click" />
        </p>
    </div>

    <div class="row">
    </div>

</asp:Content>
