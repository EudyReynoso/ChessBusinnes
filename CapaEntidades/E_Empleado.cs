using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Empleado
    {
        private int _idempleado;
        private string _nombre;
        private string _direccion;
        private int _sexo;
        private int _puesto;
        private string _departamento;

        public int Idempleado { get => _idempleado; set => _idempleado = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public int Sexo { get => _sexo; set => _sexo = value; }
        public int Puesto { get => _puesto; set => _puesto = value; }
        public string Departamento { get => _departamento; set => _departamento = value; }
    }
}
