using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;
using System.Data;

namespace CapaModeloNegocio.ReportClass
{
    public class ReportEmpleados
    {
        public List<E_Empleado> obtenerListadoEmpleados()
        {
            D_Empleado DataEmpleado = new D_Empleado();

            var data = DataEmpleado.ListaEmpleados();

            List<E_Empleado> Lista = new List<E_Empleado>();

            foreach (DataRow dataRow in data.Rows)
            {
                E_Empleado empleado = new E_Empleado
                {
                    Idempleado = Convert.ToInt32(dataRow[0]),
                    Nombre = Convert.ToString(dataRow[1]),
                    Apellido = Convert.ToString(dataRow[2]),
                    Direccion = Convert.ToString(dataRow[3]),
                    SexoName = Convert.ToString(dataRow[4]),
                    Departamento = Convert.ToString(dataRow[6]),
                    PuestoDescripcion=Convert.ToString(dataRow[5])
                    
                };

                Lista.Add(empleado);
            }

            return Lista;
        }
    }
}
