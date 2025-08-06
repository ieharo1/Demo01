<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Crear.aspx.cs" Inherits="Demo01.Vistas.Productos.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Crear un nuevo producto</h1>
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
            <asp:Button ID="Button1" runat="server" Text="Crear" OnClick="Button1_Click" />
        </div>
    </form>
    <a href="index.aspx">Buscar</a>
    <a href="Eliminar.aspx">Eliminar</a>
    <a href="Actualizar.aspx">Actualizar</a>
</body>
</html>
