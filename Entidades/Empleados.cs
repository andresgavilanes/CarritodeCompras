using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleados
    {
        private int _IdEmpleado;
        private string _Nombres;
        private string _Apellidos;
        private string _Cargo;

        public int IdEmpleado
        {
            get { return _IdEmpleado; }
            set { _IdEmpleado = value; }
        }
        public string Nombres
        {
            get { return _Nombres; }
            set { _Nombres = value; }
        }
        public string Apellidos
        {
            get { return _Apellidos; }
            set { _Apellidos = value; }
        }
        public string Cargo
        {
            get { return _Cargo; }
            set { _Cargo = value; }
        }
    }
}
