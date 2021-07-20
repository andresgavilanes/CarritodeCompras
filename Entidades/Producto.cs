using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        private int _IdProducto;
        private string _Nombre;
        private string _Descripcion;
        private double _Precio;
        private int _Stock;
        private string _foto;
        private string _idCategoria;

        public int IdProducto
        {
            get { return _IdProducto; }
            set { _IdProducto = value; }
        }
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }
        public double Precio
        {
            get { return _Precio; }
            set { _Precio = value; }
        }
        public int Stock
        {
            get { return _Stock; }
            set { _Stock = value; }
        }
        public string Foto
        {
            get { return _foto; }
            set { _foto = value; }
        }
        public string IdCategoria
        {
            get { return _idCategoria; }
            set { _idCategoria = value; }
        }
    }
}
