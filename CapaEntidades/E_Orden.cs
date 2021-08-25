using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Orden
    {
        private decimal _subTotal;
        private decimal _montototal;
        private decimal _descuento;
        private int _ordenID;
        private string _fecha;

        public decimal SubTotal { get => _subTotal; set => _subTotal = value; }
        public decimal Montototal { get => _montototal; set => _montototal = value; }
        public int OrdenID { get => _ordenID; set => _ordenID = value; }
        public string Fecha { get => _fecha; set => _fecha = value; }
        public decimal Descuento { get => _descuento; set => _descuento = value; }
    }
}
