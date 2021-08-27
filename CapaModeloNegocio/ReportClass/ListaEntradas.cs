using System;

namespace CapaModeloNegocio.ReportClass
{
    public class ListaEntradas
    {
        public int IdEntrada { get; set; }
        public string NombreSuplidor { get; set; }
        public string NombreRecolector { get; set; }
        public decimal CantidadEnBotellas { get; set; }
        public decimal Precio { get; set; }
        public string Estado{ get; set; }
        public string Fecha{ get; set; }
    }
}