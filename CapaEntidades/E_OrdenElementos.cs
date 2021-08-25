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
        private int _idOrden;
        private decimal _subTotal;
        private int _cantidad;

        public int Iordenelemento { get => _iordenelemento; set => _iordenelemento = value; }
        public int Idproducto { get => _idproducto; set => _idproducto = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }
        public int IdOrden { get => _idOrden; set => _idOrden = value; }
        public decimal SubTotal { get => _subTotal; set => _subTotal = value; }
    }
}
