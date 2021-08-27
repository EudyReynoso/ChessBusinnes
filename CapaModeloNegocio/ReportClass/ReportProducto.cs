using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;
using System.Data;

namespace CapaModeloNegocio.ReportClass
{
    public class ReportProducto
    {
        public List<E_Producto> obtenerListadoProductos()
        {
            D_Producto _Producto = new D_Producto();
            var data = _Producto.ListaProudctos();

            List<E_Producto> Lista = new List<E_Producto>();

            foreach (DataRow dataRow in data.Rows)
            {
                E_Producto producto = new E_Producto
                {
                    IdProducto = Convert.ToInt32(dataRow[0]),
                    Nombre = Convert.ToString(dataRow[1]),
                    Descipcion = Convert.ToString(dataRow[2]),
                    Precio = Convert.ToDecimal(dataRow[3])
                };

                Lista.Add(producto);
            }

            return Lista;
        }
    }
}
