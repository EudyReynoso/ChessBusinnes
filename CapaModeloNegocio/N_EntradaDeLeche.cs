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
    public class N_EntradaDeLeche
    {
        D_EntradaDeLeche D_EntradaDeLeche = new D_EntradaDeLeche();

        public DataTable ListaEntradasDeLeche()
        {
            return D_EntradaDeLeche.ListaEntradaDeLeche();
        }

        public void InsertarEntrada(E_EntradaDeLeche entradaDeLeche)
        {
            D_EntradaDeLeche.InsertarEntradaDeLeche(entradaDeLeche);
        }

        public void EliminsrEntrada(E_EntradaDeLeche entradaDeLeche)
        {
            D_EntradaDeLeche.EliminarEntradaDeLEche(entradaDeLeche);
        }
        public void EditarEntradaDeLeche(E_EntradaDeLeche EntradaDeLeche)
        {
            D_EntradaDeLeche.ActualizarEntrada(EntradaDeLeche);
        }
    }
}
