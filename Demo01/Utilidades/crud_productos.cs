using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo01.utilidades
{
    public class crud_productos
    {
        DESARROLLOBP2Entities contexto;
        public crud_productos()
        {
            contexto = new DESARROLLOBP2Entities();
        }
        public List<string> productosNombre()
        {
            return contexto.productoes.Select(pro => pro.nombre).ToList();
        }
        public List<producto> seleccionarProductos()
        {
            return contexto.productoes.ToList();
        }
        public List<producto> seleccionarproductosPorNombre (string nombreParametro)
        {
            if (string.IsNullOrEmpty(nombreParametro))
            {
                return seleccionarProductos();
            }
            else
            {
                return contexto.productoes.Where(pro => pro.nombre.Contains(nombreParametro)).ToList();
            }
        }
        public void InsertarProducto(producto nuevoProducto)
        {
            contexto.productoes.Add(nuevoProducto);
            contexto.SaveChanges();
        }
        public bool EliminarProducto(string eliminarProducto)
        {
            producto a = contexto.productoes.Where(pro => pro.nombre == eliminarProducto).FirstOrDefault();
            if (a != null) {
                contexto.productoes.Remove(a);
                contexto.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ActualizarProducto(producto producto)
        {
            producto productoAntiguo = contexto.productoes.Where(pro => pro.id == producto.id).FirstOrDefault();
            if (productoAntiguo != null)
            {
                productoAntiguo = producto;
                contexto.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}