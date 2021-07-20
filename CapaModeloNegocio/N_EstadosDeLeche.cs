using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaModeloNegocio
{
    public class N_EstadosDeLeche
    {
        D_EstadosDeLeche estadosDeLeche = new D_EstadosDeLeche();

        public DataTable ListaEstados()
        {
            return estadosDeLeche.ListaDeEstados();
        }
    }
}
