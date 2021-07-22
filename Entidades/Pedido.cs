using System;

namespace Entidades
{
    public class Pedido
    {
        private int _IdPedido;
        private int _IdCliente;
        private int _IdEmpleado;
        private DateTime _FechaPedido;
        private float _SubTotal;
        private float _Total;

        public int IdPedido
        {
            get { return _IdPedido; }
            set { _IdPedido = value; }
        }
        public int IdCliente
        {
            get { return _IdCliente; }
            set { _IdCliente = value; }
        }
        public int IdEmpleado
        {
            get { return _IdEmpleado; }
            set { _IdEmpleado = value; }
        }
        public DateTime FechaPedido
        {
            get { return _FechaPedido; }
            set { _FechaPedido = value; }
        }
        public float SubTotal
        {
            get { return _SubTotal; }
            set { _SubTotal = value; }
        }
        public float Total
        {
            get { return _Total; }
            set { _Total = value; }
        }
    }
}
