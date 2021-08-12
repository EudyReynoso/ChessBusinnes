using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using CapaEntidades;


namespace CapaModeloNegocio
{
    public class N_Producto
    {
        D_Producto Producto = new D_Producto();
        public DataTable ListadoProductos()
        {
            return Producto.ListaProudctos();
        }

        public void InsertarPorducto(E_Producto producto)
        {
            Producto.InsertarProducto(producto);
        }

        public void ActualizarProducto(E_Producto producto)
        {
            Producto.ActualizarProducto(producto);
        }
        public void EliminarProducto(E_Producto producto)
        {
            Producto.EliminarProducto(producto);
        }
    }
}
