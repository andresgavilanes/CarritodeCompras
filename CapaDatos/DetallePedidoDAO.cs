using BDConexion;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DetallePedidoDAO
    {
        private conexionBD conn = new conexionBD();
        private SqlCommand cmdDetallePedido = new SqlCommand();

        public string InsertarDetalle(List<DetallePedido> listaDetalle)
        {
            string rpta = "";
            int registros = 0;
            try
            {
                cmdDetallePedido.CommandType = CommandType.StoredProcedure;
                cmdDetallePedido.CommandText = "SP_Insertar_DetallePedido";
                cmdDetallePedido.Connection = conn.conectarBD();
                foreach (DetallePedido det in listaDetalle)
                {
                    cmdDetallePedido.Parameters.Clear();
                    cmdDetallePedido.Parameters.AddWithValue("@pIdDetalle", det.IdDetalle);
                    cmdDetallePedido.Parameters.AddWithValue("@pIdPedido", det.IdPedido);
                    cmdDetallePedido.Parameters.AddWithValue("@pIdProducto", det.IdProducto);
                    cmdDetallePedido.Parameters.AddWithValue("@pCantidad", det.Cantidad);
                    cmdDetallePedido.Parameters.AddWithValue("@pPrecioVenta", det.PrecioVenta);
                    cmdDetallePedido.Parameters.AddWithValue("@pImporte", det.Importe);
                    registros = cmdDetallePedido.ExecuteNonQuery();
                }
            
                if (registros>0)
                {
                    rpta = "OK";
                }
                else
                {
                    rpta = "Error en la Transaccion";
                }
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.Message);
            }
            return rpta;
        }

        public string ActualizarDetallePedido(DetallePedido dp)
        {
            throw new NotImplementedException();
        }

        public string InsertarDetallePedido(DetallePedido dp)
        {
            throw new NotImplementedException();
        }

        public int CodDetallePedido()
        {
            int codigo = 0;
            SqlDataReader lector;
            cmdDetallePedido.CommandType = CommandType.StoredProcedure;
            cmdDetallePedido.CommandText = "SP_Generar_Codigo_DetallePedido";
            cmdDetallePedido.Connection = conn.conectarBD();

            lector = cmdDetallePedido.ExecuteReader();
            if (lector.Read())
            {
                codigo = (int)lector[0];
            }
            return codigo;
        }
    }
}
