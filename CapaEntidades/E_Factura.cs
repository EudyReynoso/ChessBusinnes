using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Factura
    {
        private string _nombreVendedor;
        private decimal _totalPago;
        private decimal _descuento;
        private decimal _subtotalGeneral;
        private string _Codigofactura;
        private string fehca = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
        public string NombreVendedor { get => _nombreVendedor; set => _nombreVendedor = value; }
        public decimal TotalPago { get => _totalPago; set => _totalPago = value; }
        public decimal Descuento { get => _descuento; set => _descuento = value; }
        public decimal SubtotalGeneral { get => _subtotalGeneral; set => _subtotalGeneral = value; }
        public string Codigofactura { get => _Codigofactura; set => _Codigofactura = value; }
        public string Fehca { get => fehca; set => fehca = value; }
    }
}
