namespace Entidades
{
    public class DetallePedido
    {
        private int _IdDetalle;
        private int _IdPedido;
        private int _IdProducto;
        private int _Cantidad;
        private float _PrecioVenta;
        private float _Importe;

        public int IdDetalle
        {
            get { return _IdDetalle; }
            set { _IdDetalle = value; }
        }
        public int IdPedido
        {
            get { return _IdPedido; }
            set { _IdPedido = value; }
        }
        public int IdProducto
        {
            get { return _IdProducto; }
            set { _IdProducto = value; }
        }
        public int Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }
        }
        public float PrecioVenta
        {
            get { return _PrecioVenta; }
            set { _PrecioVenta = value; }
        }
        public float Importe
        {
            get { return _Importe; }
            set { _Importe = value; }
        }
    }
}
