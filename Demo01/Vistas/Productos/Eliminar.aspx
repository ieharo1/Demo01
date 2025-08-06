<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Eliminar.aspx.cs" Inherits="Demo01.Vistas.Productos.Eliminar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script language="javascript" type="text/javascript">
        function ConfirmaBoton(mensaje) {
            return confirm(mensaje);
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Eliminar Producto</h1>
            <asp:DropDownList ID="Lista" runat="server" OnSelectedIndexChanged="List_SelectedIndexChanged" DataSourceID="SqlDataSource1" DataTextField="nombre" DataValueField="nombre"></asp:DropDownList>
            <asp:Button ID="Button1" runat="server" Text="Buscar" OnClick="Button1_Click" style="height: 26px" />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DESARROLLOBPConnectionString %>" SelectCommand="SELECT [id], [nombre] FROM [productos]"></asp:SqlDataSource>
            <br />
            Pvp: <asp:Label ID="lbpvp" runat="server" Text=""></asp:Label>
            <br />
            Stock: <asp:Label ID="lbstock" runat="server" Text=""></asp:Label>
            <br />
            Categoria: <asp:Label ID="lbcategoria" runat="server" Text=""></asp:Label>
            <br />
            Fecha de elaboracion: <asp:Label ID="lbelaboracion" runat="server" Text=""></asp:Label>
            <br />
            Fecha de caducidad: <asp:Label ID="lbcaducidad" runat="server" Text=""></asp:Label>
            <br />
            Descripcion: <asp:Label ID="lbdescripcion" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="Button2" OnClientClick="return ConfirmaBoton('Quieres eliminar el producto?')" runat="server" Text="Eliminar" OnClick="Button2_Click" style="height: 26px" />
        </div>
    </form>
    <a href="index.aspx">Buscar</a>
    <a href="Crear.aspx">Create</a>
    <a href="Actualizar.aspx">Actualizar</a>
</body>
</html>
