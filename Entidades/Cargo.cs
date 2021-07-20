using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cargo
    {
        private int _IdCargo;
        private string _Nombre;
        private string _Estado;

        public int IdCargo
        {
            get { return _IdCargo; }
            set { _IdCargo = value; }
        }
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        public string Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }
    }
}
