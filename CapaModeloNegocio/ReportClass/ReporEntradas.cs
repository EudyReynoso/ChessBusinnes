using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.DataAccesReports;

namespace CapaModeloNegocio.ReportClass
{
    public class ReporEntradas
    {
        public DateTime FechaReporte { get; private set; }
        public DateTime FechaCominezo { get; private set; }
        public DateTime FechaFinal { get; private set; }
        public List<ListaEntradas> ListaEntradas { get; private set; }
        public List<ListaEntradasNeta> ListaEntradasNetas { get; private set; }

        public double TotalEntradasNeta { get; private set; }


        public List<ListaEntradas> ObtenerListado()
        {
            EntradaDeLecheData entradaDeLecheData = new EntradaDeLecheData();
            
            var Resultado = entradaDeLecheData.EntradaDelecheListado();

            ListaEntradas = new List<ListaEntradas>();

            foreach  (System.Data.DataRow dataRow in Resultado.Rows)
            {
                var ListadoEntradas1 = new ListaEntradas()
                {
                    IdEntrada = Convert.ToInt32(dataRow[0].ToString()),
                    NombreSuplidor = dataRow[1].ToString(),
                    NombreRecolector = dataRow[2].ToString(),
                    CantidadEnBotellas = Convert.ToInt32(dataRow[3]),
                    Precio = Convert.ToDecimal(dataRow[4]),
                    Estado = dataRow[5].ToString(),
                    Fecha = dataRow[6].ToString()
                };

                ListaEntradas.Add(ListadoEntradas1);
            }

            return ListaEntradas;
        }
        
    }
}
