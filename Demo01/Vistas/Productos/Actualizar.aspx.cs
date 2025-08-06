using Demo01.utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo01.Vistas.Productos
{
    public partial class Actualizar : System.Web.UI.Page
    {
        crud_productos operaciones;

        public Actualizar()
        {
            operaciones = new crud_productos();
        }
        private void CargarDatos()
        {
            List<producto> lstProducto3 = operaciones.seleccionarproductosPorNombre(Lista.SelectedValue);
            foreach (var a in lstProducto3)
            {
                txtNombre.Text = a.nombre;
                txtNombre.DataBind();
                txtPvp.Text = a.pvp.ToString();
                txtPvp.DataBind();
                txtStock.Text = a.stock.ToString();
                txtStock.DataBind();
                txtCategoria.Text = a.stock.ToString();
                txtCategoria.DataBind();
                txtElaboracion.Text = a.fecha_elaboracion.ToString();
                txtElaboracion.DataBind();
                txtCaducidad.Text = a.fecha_caducidad.ToString();
                txtCaducidad.DataBind();
                txtDescripcion.Text = a.descripcion;
                txtDescripcion.DataBind();
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<producto> lstProducto3 = operaciones.seleccionarProductos();
            lstProducto3[Lista.SelectedIndex].nombre = txtNombre.Text;
            lstProducto3[Lista.SelectedIndex].pvp = Convert.ToDecimal(txtPvp.Text);
            lstProducto3[Lista.SelectedIndex].stock = Convert.ToInt32(txtStock.Text);
            lstProducto3[Lista.SelectedIndex].categoria = txtCategoria.Text;
            lstProducto3[Lista.SelectedIndex].fecha_elaboracion = Convert.ToDateTime(txtElaboracion.Text);
            lstProducto3[Lista.SelectedIndex].fecha_caducidad = Convert.ToDateTime(txtCaducidad.Text);
            lstProducto3[Lista.SelectedIndex].descripcion = txtDescripcion.Text;
            operaciones.ActualizarProducto(lstProducto3[Lista.SelectedIndex]);
            string jscript = "<script>alert('YOUR BUTTON HAS BEEN CLICKED')</script>";
            System.Type t = this.GetType();
            ClientScript.RegisterStartupScript(t, "k", jscript);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        protected void Lista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}