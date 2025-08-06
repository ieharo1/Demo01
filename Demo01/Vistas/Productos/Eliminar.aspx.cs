using Demo01.utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo01.Vistas.Productos
{
    public partial class Eliminar : System.Web.UI.Page
    {
        
        private void CargarDatos()
        {
            crud_productos operaciones = new crud_productos();
            List<producto> lstProducto3 = operaciones.seleccionarproductosPorNombre(Lista.SelectedValue);
            foreach (var a in lstProducto3)
            {
                lbpvp.Text = a.pvp.ToString();
                lbstock.Text = a.stock.ToString();
                lbcategoria.Text = a.categoria.ToString();
                lbelaboracion.Text = a.fecha_elaboracion.ToString();
                lbcaducidad.Text = a.fecha_caducidad.ToString();
                lbdescripcion.Text = a.descripcion;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void List_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            CargarDatos();
            crud_productos operaciones = new crud_productos();
            operaciones.EliminarProducto(Lista.SelectedValue);
            string jscript = "<script>alert('YOUR BUTTON HAS BEEN CLICKED')</script>";
            System.Type t = this.GetType();
            ClientScript.RegisterStartupScript(t, "k", jscript);
            CargarDatos();
        }
    }
}