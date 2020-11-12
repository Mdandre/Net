<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListaUsuarios.aspx.cs" Inherits="Lab5._4.ListaUsuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="grdUsuarios" runat="server" OnSelectedIndexChanged="grdUsuarios_SelectedIndexChanged">
            </asp:GridView>
        </div>
        <table style="width:100%;">
            <tr>
                <td colspan="2" align="center">
                    <asp:Label ID="lblAccion" runat="server" Text="Label"></asp:Label>    
                </td>
            </tr>
            <tr>
                <td style="width: 150px" align="right">Apellido</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 150px" align="right">Nombre</td>
                <td>
                    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 150px" align="right">Tipo de documento</td>
                <td>
                    <asp:RadioButtonList ID="rblTipoDocumento" runat="server">
                        <asp:ListItem Value="1">DNI</asp:ListItem>
                        <asp:ListItem Value="2">LC</asp:ListItem>
                        <asp:ListItem Value="3">Cédula de identidad</asp:ListItem>
                        <asp:ListItem Value="4">Pasaporte</asp:ListItem>
                        <asp:ListItem Value="5">Otro</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td style="width: 150px" align="right">Número de documento</td>
                <td>
                    <asp:TextBox ID="txtNumeroDocumento" runat="server" BorderStyle="None"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 150px" align="right">Fecha de nacimiento</td>
                <td>
                    <asp:DropDownList ID="ddlDiaFechaNacimiento" runat="server"></asp:DropDownList>
                    <asp:DropDownList ID="ddlMesFechaNacimiento" runat="server">
                        <asp:ListItem>Enero</asp:ListItem>
                        <asp:ListItem>Febrero</asp:ListItem>
                        <asp:ListItem>Marzo</asp:ListItem>
                        <asp:ListItem>Abril</asp:ListItem>
                        <asp:ListItem>Mayo</asp:ListItem>
                        <asp:ListItem>Junio</asp:ListItem>
                        <asp:ListItem>Julio</asp:ListItem>
                        <asp:ListItem>Agosto</asp:ListItem>
                        <asp:ListItem>Septiembre</asp:ListItem>
                        <asp:ListItem>Octubre</asp:ListItem>
                        <asp:ListItem>Noviembre</asp:ListItem>
                        <asp:ListItem>Diciembre</asp:ListItem>
                    </asp:DropDownList>
                    <asp:TextBox ID="txtAñoNacimiento" runat="server" MaxLength="4" Width="50px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 150px" align="right">Dirección</td>
                <td>
                    <asp:TextBox ID="txtDireccion" runat="server" Rows="5" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 150px" align="right">Teléfono</td>
                <td>
                    <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 150px" align="right">Email</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 150px" align="right">Celular</td>
                <td>
                    <asp:TextBox ID="txtCelular" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 150px" align="right">Nombre de usuario</td>
                <td>
                    <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 150px" align="right">Clave</td>
                <td>
                    <asp:TextBox ID="txtClave" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 150px" align="right">Confirmar clave</td>
                <td>
                    <asp:TextBox ID="txtConfirmarClave" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Guardar" />
                </td>
                <td>
                    <asp:Button ID="Button2" runat="server" Text="Cancelar" />
                </td>
            </tr>
        </table>
        <asp:ObjectDataSource ID="odsUsuarios" runat="server"></asp:ObjectDataSource>
    </form>
</body>
</html>
