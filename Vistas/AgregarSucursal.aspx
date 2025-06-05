<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarSucursal.aspx.cs" Inherits="Vistas.AgregarSucursal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:HyperLink ID="hlAgregarSucursal" runat="server" NavigateUrl="~/AgregarSucursal.aspx">Agregar Sucursal</asp:HyperLink>
                    </td>
                    <td>
                        <asp:HyperLink ID="hlListadoSucursales" runat="server" NavigateUrl="~/ListadoSucursales.aspx">Listado de Sucursales</asp:HyperLink>
                    </td>
                    <td>
                        <asp:HyperLink ID="hlEliminarSucursal" runat="server" NavigateUrl="~/EliminarSucursales.aspx">Eliminar Sucursal</asp:HyperLink>
                    </td>
                </tr>
            </table>
            <h1>GRUPO N°</h1>
            <h2>Agregar Sucursal</h2>
            Nombre Sucursal: 

            <asp:TextBox ID="txtNombreSucursal" runat="server"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="rfvNombreSucursal" runat="server" ErrorMessage="Debe ingresar un Nombre de Sucursal" ValidationGroup="1" ControlToValidate="txtNombreSucursal">*</asp:RequiredFieldValidator>
            <br />
            <br />
            Descripción: <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="rfvDescripcion" runat="server" ErrorMessage="Debe ingresar una Descripción" ValidationGroup="1" ControlToValidate="txtDescripcion">*</asp:RequiredFieldValidator>
            <br />
            <br />
            Provincia: <asp:DropDownList ID="ddlProvincia" runat="server">
            </asp:DropDownList>
&nbsp;<asp:RequiredFieldValidator ID="rfvProvincia" runat="server" ErrorMessage="Debe ingresar una provincia" ValidationGroup="1" ControlToValidate="ddlProvincia">*</asp:RequiredFieldValidator>
            <br />
            <br />
            Dirección:<asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="rfvDireccion" runat="server" ErrorMessage="Debe ingresar una Dirección" ValidationGroup="1" ControlToValidate="txtDireccion">*</asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Button ID="btnAceptar" runat="server" OnClick="btnAceptar_Click" Text="Aceptar" ValidationGroup="1" />
            <br />
            <br />
            <asp:Label ID="lblMensaje" runat="server"></asp:Label>
            <br />
            <asp:ValidationSummary ID="vsValidaciones" runat="server" ValidationGroup="1" />

        </div>
    </form>
</body>
</html>
