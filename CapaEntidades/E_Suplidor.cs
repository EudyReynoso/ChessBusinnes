using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Suplidor
    {
        private int _idsuplidor;
        private string _nombre;
        private string _apellido;
        private string _direccion;
        private string _numeroTel;
        private string _FechaReport = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");

        public int Idsuplidor { get => _idsuplidor; set => _idsuplidor = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string NumeroTel { get => _numeroTel; set => _numeroTel = value; }
        public string FechaReport { get => _FechaReport; set => _FechaReport = value; }
    }
}
