using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_EntradaDeLeche
    {
        private int _identrada;
        private int _idsuplidor;
        private int _recolector;
        private decimal _cantidadbotellas;
        private int _idestado;
        private string _fechaentrada;
        private decimal _precioPorbotella;

        public int Identrada { get => _identrada; set => _identrada = value; }
        public int Idsuplidor { get => _idsuplidor; set => _idsuplidor = value; }
        public int Recolector { get => _recolector; set => _recolector = value; }
        public decimal Cantidadbotellas { get => _cantidadbotellas; set => _cantidadbotellas = value; }
        public int Idestado { get => _idestado; set => _idestado = value; }
        public string Fechaentrada { get => _fechaentrada; set => _fechaentrada = value; }
        public decimal PrecioPorbotella { get => _precioPorbotella; set => _precioPorbotella = value; }
    }
}
