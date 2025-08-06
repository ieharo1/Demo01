using Demo01.utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo01.Vistas.Productos
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            producto nuevoProducto = new producto();
            nuevoProducto.nombre = txtNombre.Text;
            nuevoProducto.pvp = Convert.ToDecimal(txtPvp.Text);
            nuevoProducto.stock = Convert.ToInt32(txtStock.Text);
            nuevoProducto.categoria = txtCategoria.Text;
            nuevoProducto.fecha_elaboracion = Convert.ToDateTime(txtElaboracion.Text);
            nuevoProducto.fecha_caducidad = Convert.ToDateTime(txtCaducidad.Text);
            nuevoProducto.descripcion = txtDescripcion.Text;
            crud_productos operaciones = new crud_productos();
            operaciones.InsertarProducto(nuevoProducto);

        }
    }
}