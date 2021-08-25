using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaModeloNegocio
{
    public class N_InsertOrdenElementos
    {
        D_Ordenes Ordenes = new D_Ordenes();
        public void InsertarOrdenElmemtos(E_OrdenElementos ordenElementos)
        {
            Ordenes.InsertarOrden(ordenElementos);
        }
        public void InsertarOrdendate(E_Orden OrdenDate)
        {
            Ordenes.InsertarOrdenFecha(OrdenDate);
        }

    }
}
