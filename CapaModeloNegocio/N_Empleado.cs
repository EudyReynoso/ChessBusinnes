using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModeloNegocio
{
    public class N_Empleado
    {
        D_Empleado EmpleadosDB = new D_Empleado();
        
        public DataTable ListaEmpleados()
        {
            return EmpleadosDB.ListaEmpleados();
        }
        public DataTable ValoresComboRecolector()
        {
            return EmpleadosDB.ValoreMienbrosComboRecolector();
        }
        public void InsertarEmpleado (E_Empleado empleado)
        {
            EmpleadosDB.InsertarEmpleados(empleado);
        }
        public void EliminarEmpleado(E_Empleado empleado)
        {
            EmpleadosDB.EliminarEmpleado(empleado);
        }
        public void ActualizarEmpleado(E_Empleado empleado)
        {
            EmpleadosDB.ActualizarEmpleado(empleado);
        }
    }
}
