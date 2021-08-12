using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_OrdenElementos
    {
        private int _iordenelemento;
        private int _idproducto;
        private int _cantidad;
        private decimal _montototal;
        private string _fecha;
        private decimal _descuento;

        public int Iordenelemento { get => _iordenelemento; set => _iordenelemento = value; }
        public int Idproducto { get => _idproducto; set => _idproducto = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }
        public decimal Montototal { get => _montototal; set => _montototal = value; }
        public string Fecha { get => _fecha; set => _fecha = value; }
        public decimal Descuento { get => _descuento; set => _descuento = value; }
    }
}
