using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        private int _IdCliente;
        private string _Nombres;
        private string _Apellidos;
        private string _Direccion;
        private string _Telefono;
        private string _DNI;
        private string _Email;
        private string _Usuario;
        private string _Clave;
        public int idCliente
        {
            get { return _IdCliente; }
            set { _IdCliente = value; }
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
        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }
        public string Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }
        public string DNI
        {
            get { return _DNI; }
            set { _DNI = value; }
        }
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        public string Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }
        public string Clave
        {
            get { return _Clave; }
            set { _Clave = value; }
        }


    }
}
