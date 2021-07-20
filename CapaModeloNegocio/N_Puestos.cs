using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModeloNegocio
{
    public class N_Puestos
    {
        D_Puestos puestos = new D_Puestos();
        public DataTable ListaPuestos()
        {
            return puestos.ListaPuesto();
        }
    }
}
