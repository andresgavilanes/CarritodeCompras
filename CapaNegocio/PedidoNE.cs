using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    class PedidoNE
    {
        PedidoDAO pedao = new PedidoDAO();

        public string InsertarPedido(Pedido pe)
        {
            return pedao.InsertarPedido(pe);
        }
        public string ActualizarPedido(Pedido pe)
        {
            return pedao.ActualizarPedido(pe);
        }
        public List<Pedido> ListarPedido()
        {
            return pedao.ListarPedido();
        }
        public Pedido BuscarPedidoById(int id)
        {
            return pedao.BuscarPedidoById(id);
        }
        public int CodPedido()
        {
            return pedao.CodPedido();
        }
    }
}
    

