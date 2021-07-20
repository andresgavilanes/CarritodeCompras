using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class DetallePedidoNE
    {
        DetallePedidoDAO Dpdao = new DetallePedidoDAO();

        public string InsertarDetalle(List<DetallePedido> listaDetalle)
        {
            return Dpdao.InsertarDetalle(listaDetalle);
        }
        public string InsertarDetallePedido(DetallePedido Dp)
        {
            return Dpdao.InsertarDetallePedido(Dp);
        }
        public string ActualizarDetallePedido(DetallePedido Dp)
        {
            return Dpdao.ActualizarDetallePedido(Dp);
        }
        public int CodDetallePedido()
        {
            return Dpdao.CodDetallePedido();
        }
    }
}
