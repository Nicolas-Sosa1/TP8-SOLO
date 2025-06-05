<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoSucursales.aspx.cs" Inherits="Vistas.ListadoSucursales" %>

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
            <h1>Listado de sucursales</h1>
            Búsqueda ingrese Id sucursal:
            <asp:TextBox ID="txtIdSucursal" runat="server" Width="211px" ValidationGroup="1"></asp:TextBox>
&nbsp;
            <asp:Button ID="btnFiltrar" runat="server" Text="Filtrar" OnClick="btnFiltrar_Click" ValidationGroup="1" />
&nbsp;<asp:Button ID="btnMostrarTodos" runat="server" Text="Mostrar todos" OnClick="btnMostrarTodos_Click" />
            &nbsp;&nbsp;<asp:RegularExpressionValidator ID="revBuscar" runat="server" ControlToValidate="txtIdSucursal" ErrorMessage="Solo se permiten numeros" ForeColor="Black" ValidationExpression="^\d+$" ValidationGroup="1">*</asp:RegularExpressionValidator>
            <br />
            <br />
            <asp:GridView ID="gvSucursales" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:TemplateField HeaderText="ID_SUCURSAL">
                        <ItemTemplate>
                            <asp:Label ID="lbl_ite_Id_Sucursal" runat="server" Text='<%# Bind("Id_Sucursal") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="NOMBRE">
                        <ItemTemplate>
                            <asp:Label ID="lbl_ite_NombreSucursal" runat="server" Text='<%# Bind("NombreSucursal") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="DESCRIPCIÓN">
                        <ItemTemplate>
                            <asp:Label ID="lbl_ite_DescripcionSucursal" runat="server" Text='<%# Bind("DescripcionSucursal") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="PROVINCIA">
                        <ItemTemplate>
                            <asp:Label ID="lbl_ite_Id_ProvinciaSucursal" runat="server" Text='<%# Bind("Id_ProvinciaSucursal") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="DIRECCIÓN">
                        <ItemTemplate>
                            <asp:Label ID="lbl_ite_DireccionSucursal" runat="server" Text='<%# Bind("DireccionSucursal") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <br />
            <asp:ValidationSummary ID="vsValidaciones" runat="server" ValidationGroup="1" />
        </div>
    </form>
</body>
</html>
