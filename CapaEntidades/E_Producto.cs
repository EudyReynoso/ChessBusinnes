using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Producto
    {
        private int _idProducto;
        private string _nombre;
        private string _descipcion;
        private decimal _precio;

        public int IdProducto { get => _idProducto; set => _idProducto = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Descipcion { get => _descipcion; set => _descipcion = value; }
        public decimal Precio { get => _precio; set => _precio = value; }
    }
}
