using Demo01.utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo01.Vistas.Productos
{
    public partial class index : System.Web.UI.Page
    {
        private void cargarDatos()
        {
            crud_productos operaciones = new crud_productos();
            List<producto> lstProducto = operaciones.seleccionarproductosPorNombre(TextoParametro.Text);
            tablaDatos.DataSource = lstProducto;
            tablaDatos.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            cargarDatos();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}