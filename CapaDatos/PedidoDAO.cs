using BDConexion;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class PedidoDAO
    {
        private conexionBD conn = new conexionBD();
        private SqlCommand cmdPedido = new SqlCommand();

        public string InsertarPedido(Pedido ped)
        {
            string rpta = "";
            try
            {
                cmdPedido.CommandType = CommandType.StoredProcedure;
                cmdPedido.CommandText = "SP_Insertar_Pedido";
                cmdPedido.Connection = conn.conectarBD();
                {
                    cmdPedido.Parameters.AddWithValue("@pIdPedido", ped.IdPedido);
                    cmdPedido.Parameters.AddWithValue("@pIdcliente", ped.IdCliente);
                    cmdPedido.Parameters.AddWithValue("@pIdEmpleado", ped.IdEmpleado);
                    cmdPedido.Parameters.AddWithValue("@pFechaPedido", ped.FechaPedido);
                    cmdPedido.Parameters.AddWithValue("@pSubTotal", ped.SubTotal);
                    cmdPedido.Parameters.AddWithValue("@pTotal", ped.Total);
                }
                int registros;
                registros = cmdPedido.ExecuteNonQuery();
                if (registros == 1)
                {
                    rpta = "OK";
                }
                else
                {
                    rpta = "Error al Insertar Pedido";
                }
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.Message);
            }
            return rpta;
        }
        public string ActualizarPedido(Pedido ped)
        {
            string rpta = "";
            try
            {
                cmdPedido.CommandType = CommandType.StoredProcedure;
                cmdPedido.CommandText = "SP_Actualizar_Pedido";
                cmdPedido.Connection = conn.conectarBD();
                {
                    cmdPedido.Parameters.AddWithValue("@pIdPedido", ped.IdPedido);
                    cmdPedido.Parameters.AddWithValue("@pIdcliente", ped.IdCliente);
                    cmdPedido.Parameters.AddWithValue("@pIdEmpleado", ped.IdEmpleado);
                    cmdPedido.Parameters.AddWithValue("@pFechaPedido", ped.FechaPedido);
                    cmdPedido.Parameters.AddWithValue("@pSubTotal", ped.SubTotal);
                    cmdPedido.Parameters.AddWithValue("@pTotal", ped.Total);
                }
                int registros;
                registros = cmdPedido.ExecuteNonQuery();
                if (registros == 1)
                {
                    rpta = "OK";
                }
                else
                {
                    rpta = "Error Al Actualizar";
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            return rpta;
        }
        public List<Pedido> ListarPedido()
        {
            List<Pedido> lista = new List<Pedido>();
            Pedido ped;
            SqlDataReader lector;
            try
            {
                cmdPedido.CommandType = CommandType.StoredProcedure;
                cmdPedido.CommandText = "SP_Listar_Pedido";
                cmdPedido.Connection = conn.conectarBD();

                lector = cmdPedido.ExecuteReader();

                while (lector.Read())
                {
                    ped = new Pedido();
                    ped.IdPedido = (int)lector[0];
                    ped.IdCliente = (int)lector[1];
                    ped.IdEmpleado = (int)lector[2];
                    ped.FechaPedido = (DateTime)lector[3];
                    ped.SubTotal = (float)lector[4];
                    ped.Total = (float)lector[5];
                    lista.Add(ped);
                }
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.Message);
            }
            return lista;
        }
        public Pedido BuscarPedidoById(int id)
        {
            Pedido ped = new Pedido();
            SqlDataReader lector;
            try
            {
                cmdPedido.CommandType = CommandType.StoredProcedure;
                cmdPedido.CommandText = "SP_BuscarPedidoById";
                cmdPedido.Connection = conn.conectarBD();
                {
                    cmdPedido.Parameters.AddWithValue("@pIdPedido", id);
                }
                lector = cmdPedido.ExecuteReader();
                if (lector.Read())
                {
                    ped.IdPedido = (int)lector[0];
                    ped.IdCliente = (int)lector[1];
                    ped.IdEmpleado = (int)lector[2];
                    ped.FechaPedido = (DateTime)lector[3];
                    ped.SubTotal = (float)lector[4];
                    ped.Total = (float)lector[5];
                }
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.Message);
            }
            return ped;
        }
        public int CodPedido()
        {
            int codigo = 0;
            SqlDataReader lector;
            cmdPedido.CommandType = CommandType.StoredProcedure;
            cmdPedido.CommandText = "SP_Generar_Codigo_Pedido";
            cmdPedido.Connection = conn.conectarBD();

            lector = cmdPedido.ExecuteReader();
            if (lector.Read())
            {
                codigo = (int)lector[0];
            }
            return codigo;
        }
    }
}
