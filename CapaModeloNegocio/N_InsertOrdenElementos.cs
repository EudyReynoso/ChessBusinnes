using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;
using System.Data;

namespace CapaModeloNegocio
{
    public class N_InsertOrdenElementos
    {
        D_Ordenes Ordenes = new D_Ordenes();

        public DataTable ListadoVentas()
        {
            return Ordenes.ListaOrdenesVentas();
        }
        public DataTable BuscarVentasPorCodigo( string valor)
        {
            return Ordenes.BuscarFactura(valor);
        }
        public void InsertarOrdenElmemtos(E_OrdenElementos ordenElementos)
        {
            Ordenes.InsertarOrden(ordenElementos);
        }
        public void InsertarOrdendate(E_Orden OrdenDate)
        {
            Ordenes.InsertarOrdenFecha(OrdenDate);
        }
        public int GetIdOrden()
        {
            return Ordenes.GetOrdenId();
        }
        public int GetCodigoOrden()
        {
            return Ordenes.GetOrdenElemntosId();
        }
    }
}
