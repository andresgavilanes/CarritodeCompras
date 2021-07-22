using BDConexion;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class ProductoDAO
    {
        private conexionBD conn = new conexionBD();
        private SqlCommand cmdProducto = new SqlCommand();

        public string InsertarProducto(Producto Prd)
        {
            string rpta = "";
            try
            {
                cmdProducto.CommandType = CommandType.StoredProcedure;
                cmdProducto.CommandText = "SP_Insertar_Producto";
                cmdProducto.Connection = conn.conectarBD();
                {
                    cmdProducto.Parameters.AddWithValue("@pIdProducto", Prd.IdProducto);
                    cmdProducto.Parameters.AddWithValue("@pNombre", Prd.Nombre);
                    cmdProducto.Parameters.AddWithValue("@pDecripcion", Prd.Descripcion);
                    cmdProducto.Parameters.AddWithValue("@pPrecio", Prd.Precio);
                    cmdProducto.Parameters.AddWithValue("@pStock", Prd.Stock);
                    cmdProducto.Parameters.AddWithValue("@pFoto", Prd.Foto);
                    cmdProducto.Parameters.AddWithValue("@pIdCategoria", Prd.IdCategoria);
                }
                int registros;
                registros = cmdProducto.ExecuteNonQuery();
                if (registros == 1)
                {
                    rpta = "OK";
                }
                else
                {
                    rpta = "Error al Insertar Producto";
                }
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.Message);
            }
            return rpta;
        }
        public string ActualizarProducto(Producto Prd)
        {
            string rpta = "";
            try
            {
                cmdProducto.CommandType = CommandType.StoredProcedure;
                cmdProducto.CommandText = "SP_Actualizar_Producto";
                cmdProducto.Connection = conn.conectarBD();
                {
                    cmdProducto.Parameters.AddWithValue("@pIdProducto", Prd.IdProducto);
                    cmdProducto.Parameters.AddWithValue("@pNombre", Prd.Nombre);
                    cmdProducto.Parameters.AddWithValue("@pDecripcion", Prd.Descripcion);
                    cmdProducto.Parameters.AddWithValue("@pPrecio", Prd.Precio);
                    cmdProducto.Parameters.AddWithValue("@pStock", Prd.Stock);
                    cmdProducto.Parameters.AddWithValue("@pFoto", Prd.Foto);
                    cmdProducto.Parameters.AddWithValue("@pIdCategoria", Prd.IdCategoria);
                }
                int registros;
                registros = cmdProducto.ExecuteNonQuery();
                if (registros == 1)
                {
                    rpta = "OK";
                }
                else
                {
                    rpta = "Error al Actualizar";
                }
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.Message);
            }
            return rpta;
        }
        public List<Producto> ListarProducto()
        {
            List<Producto> lista = new List<Producto>();
            Producto Prd;
            SqlDataReader lector;
            try
            {
                cmdProducto.CommandType = CommandType.StoredProcedure;
                cmdProducto.CommandText = "SP_Listar_Productos";
                cmdProducto.Connection = conn.conectarBD();

                lector = cmdProducto.ExecuteReader();

                while (lector.Read())
                {
                    Prd = new Producto();
                    Prd.IdProducto = (int)lector[0];
                    Prd.Nombre = (string)lector[1];
                    Prd.Descripcion = (string)lector[2];
                    Prd.Precio = (double)lector[3];
                    Prd.Stock = (int)lector[4];
                    Prd.IdCategoria = (string)lector[5];

                    lista.Add(Prd);
                }
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.Message);
            }
            return lista;
        }
        public List<Producto> ListaCatalogoProductos()
        {

            List<Producto> lista = new List<Producto>();
            Producto Prd;
            SqlDataReader lector;
            try
            {
                cmdProducto.CommandType = CommandType.StoredProcedure;
                cmdProducto.CommandText = "SP_Listar_Catalogo_Productos";
                cmdProducto.Connection = conn.conectarBD();

                lector = cmdProducto.ExecuteReader();

                while (lector.Read())
                {
                    Prd = new Producto();
                    Prd.IdProducto = (int)lector[0];
                    Prd.Nombre = (string)lector[1];
                    Prd.Descripcion = (string)lector[2];
                    Prd.Precio = (double)lector[3];
                    Prd.Stock = (int)lector[4];
                    Prd.IdCategoria = (string)lector[5];

                    lista.Add(Prd);
                }
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.Message);
            }
            return lista;
        }
        public Producto BuscarProductoById(int id)
        {
            Producto Prd = new Producto();
            SqlDataReader lector;
            try
            {
                cmdProducto.CommandType = CommandType.StoredProcedure;
                cmdProducto.CommandText = "SP_BuscarProductoById";
                {
                    cmdProducto.Parameters.AddWithValue("@pIdProductos", id);
                }
                lector = cmdProducto.ExecuteReader();
                if (lector.Read())
                {
                    Prd = new Producto();
                    Prd.IdProducto = (int)lector[0];
                    Prd.Nombre = (string)lector[1];
                    Prd.Descripcion = (string)lector[2];
                    Prd.Precio = (double)lector[3];
                    Prd.Stock = (int)lector[4];
                    Prd.IdCategoria = (string)lector[5];
                }
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.Message);
            }
            return Prd;
        }
        public int CodProducto()
        {
            int codigo = 0;
            SqlDataReader lector;
            cmdProducto.CommandType = CommandType.StoredProcedure;
            cmdProducto.CommandText = "Sp_Generar_Codigo_Producto";
            cmdProducto.Connection = conn.conectarBD();

            lector = cmdProducto.ExecuteReader();
            if (lector.Read())
            {
                codigo = (int)lector[0];
            }
            return codigo;
        }

    }
}
