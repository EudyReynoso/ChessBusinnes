using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CapaModeloNegocio.ReportClass
{
    public class ReportSuplidores
    {
        public List<E_Suplidor> obtenerListadoProductos()
        {
            D_Suplidor suplidor = new D_Suplidor();
            var data = suplidor.ListaSuplidores();

            List<E_Suplidor> Lista = new List<E_Suplidor>();

            foreach (DataRow dataRow in data.Rows)
            {
                E_Suplidor suplidor1 = new E_Suplidor
                {
                    Idsuplidor = Convert.ToInt32(dataRow[0]),
                    Nombre = Convert.ToString(dataRow[1]),
                    Apellido = Convert.ToString(dataRow[2]),
                    Direccion = Convert.ToString(dataRow[3]),
                    NumeroTel = Convert.ToString(dataRow[4])
                    //Descipcion = Convert.ToString(dataRow[2]),
                    //Precio = Convert.ToDecimal(dataRow[3])
                };

                Lista.Add(suplidor1);
            }

            return Lista;
        }
    }
}
