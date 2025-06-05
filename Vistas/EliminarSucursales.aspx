<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EliminarSucursales.aspx.cs" Inherits="Vistas.EliminarSucursales" %>

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
            <br />
           <h1>Eliminar Sucursal</h1>
            Ingrese ID sucursal

            :
            <asp:TextBox ID="txtIdSucursal" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
            &nbsp;<asp:RegularExpressionValidator ID="revEliminar" runat="server" ControlToValidate="txtIdSucursal" ErrorMessage="Solo se permiten numeros" ForeColor="Black" ValidationExpression="^\d+$" ValidationGroup="1">*</asp:RegularExpressionValidator>
            &nbsp;&nbsp;<asp:RequiredFieldValidator ID="rfvEliminar" runat="server" ControlToValidate="txtIdSucursal" ErrorMessage="Debe ingresar un ID" ForeColor="Black" ValidationGroup="1">*</asp:RequiredFieldValidator>
            &nbsp;<br />
            <br />
            <asp:Label ID="lblMensaje" runat="server"></asp:Label>

        </div>
    </form>
</body>
</html>
