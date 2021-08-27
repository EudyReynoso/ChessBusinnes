using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;
using CapaEntidades;

namespace CapaModeloNegocio.ReportVentasClass
{
    public class ReportVentas
    {
        public List<E_VentasReport> ListadoVentas()
        {
            D_Ordenes Ordenes = new D_Ordenes();

            var data = Ordenes.ListaOrdenesVentas();

            List<E_VentasReport> lista = new List<E_VentasReport>();

            foreach (DataRow da in data.Rows)
            {
                E_VentasReport ventasReport = new E_VentasReport
                {
                    IdOrden = Convert.ToInt32(da[0]),
                    Fecha = Convert.ToString(da[1]),
                    Productos = Convert.ToString(da[2]),
                    Subtotal = Convert.ToString(da[3]),
                    Decuento = Convert.ToString(da[4]),
                    TotalPago = Convert.ToString(da[5])
                };

                lista.Add(ventasReport);
            }
            return lista;
        }
    }
}
