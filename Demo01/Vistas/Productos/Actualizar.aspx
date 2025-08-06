<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Actualizar.aspx.cs" Inherits="Demo01.Vistas.Productos.Actualizar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script language="javascript" type="text/javascript">
        function ConfirmarBoton(mensaje) {
            return confirm(mensaje);
        }

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Actualizar</h1>
            <asp:DropDownList ID="Lista" runat="server" DataSourceID="SqlDataSource1" DataTextField="nombre" DataValueField="nombre" OnSelectedIndexChanged="Lista_SelectedIndexChanged"></asp:DropDownList>
            <asp:Button ID="Button2" runat="server" Text="Buscar" OnClick="Button2_Click" />
            <br />
            Nombre: <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <br />
            Pvp: <asp:TextBox ID="txtPvp" runat="server"></asp:TextBox>
            <br />
            Stock: <asp:TextBox ID="txtStock" runat="server"></asp:TextBox>
            <br />
            Categoria: <asp:TextBox ID="txtCategoria" runat="server"></asp:TextBox>
            <br />
            Fecha de elaboracion: <asp:TextBox ID="txtElaboracion" runat="server"></asp:TextBox>
            <br />
            Fecha de caducidad: <asp:TextBox ID="txtCaducidad" runat="server"></asp:TextBox>
            <br />
            Descripcion: <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1"  OnClientClick="return ConfirmaBoton('Quieres actualizar el producto?')" runat="server" Text="Actulizar" OnClick="Button1_Click" />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DESARROLLOBP2ConnectionString %>" SelectCommand="SELECT [nombre], [pvp] FROM [producto]"></asp:SqlDataSource>
        </div>
    </form>
    <a href="index.aspx">Buscar</a>
    <a href="Crear.aspx">Create</a>
    <a href="Eliminar.aspx">Eliminar</a>
</body>
</html>
