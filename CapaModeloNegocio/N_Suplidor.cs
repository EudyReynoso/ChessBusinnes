using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaModeloNegocio
{
    public class N_Suplidor
    {
        D_Suplidor Suplidor = new D_Suplidor();
        
        public DataTable ListaSuplidores()
        {
            return Suplidor.ListaSuplidores();
        }
        public DataTable ValoresComboboxSuplido()
        {
            return Suplidor.ValoreMienbrosComoSuplidores();
        }
        public void InsertarSuplidor(E_Suplidor suplidor)
        {
            Suplidor.InsertarSuplidor(suplidor);
        }
        public void ActualizarSuplidor(E_Suplidor suplidor)
        {
            Suplidor.ActualizarSuplidor(suplidor);
        }
        public void EliminarSuplidor(E_Suplidor suplidor)
        {
            Suplidor.ElimininarSuplidor(suplidor);
        }
        public DataTable BuscarSuplidor(string valor)
        {
            return Suplidor.BuscarSuplidorPorNombres(valor);
        }
    }
}
