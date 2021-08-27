using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_VentasReport
    {
        private string _FechaReport = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
        private int _idOrden;
        private string _fecha;
        private string _productos;
        private string _subtotal;
        private string _decuento;
        private string _totalPago;

        public string FechaReport { get => _FechaReport; set => _FechaReport = value; }
        public int IdOrden { get => _idOrden; set => _idOrden = value; }
        public string Fecha { get => _fecha; set => _fecha = value; }
        public string Productos { get => _productos; set => _productos = value; }
        public string Subtotal { get => _subtotal; set => _subtotal = value; }
        public string Decuento { get => _decuento; set => _decuento = value; }
        public string TotalPago { get => _totalPago; set => _totalPago = value; }
    }
}
