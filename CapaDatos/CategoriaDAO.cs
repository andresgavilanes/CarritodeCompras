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
    public class CategoriaDAO
    {
        private conexionBD conn = new conexionBD();
        private SqlCommand cmdCategoria = new SqlCommand();

        public string InsertarCategoria(Categoria cat)
        {
            string rpta = "";
            try
            {
                cmdCategoria.CommandType = CommandType.StoredProcedure;
                cmdCategoria.CommandText = "SP_Insertar_Categorias";
                cmdCategoria.Connection = conn.conectarBD();
                {
                    cmdCategoria.Parameters.AddWithValue("@pIdCategoria", cat.IdCategoria);
                    cmdCategoria.Parameters.AddWithValue("@pNombre", cat.Nombre);
                    cmdCategoria.Parameters.AddWithValue("@pDescripcion", cat.Descripcion);
                }
                int registros;
                registros = cmdCategoria.ExecuteNonQuery();
                if (registros == 1)
                {
                    rpta = "OK";
                }
                else
                {
                    rpta = "Error al Insertar el Registro";
                }
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.Message);
            }
            return rpta;
        }
        public string ActualizarCategoria(Categoria cat)
        {
            string rpta = "";
            try
            {
                cmdCategoria.CommandType = CommandType.StoredProcedure;
                cmdCategoria.CommandText = "SP_Actualizar_Categorias";
                cmdCategoria.Connection = conn.conectarBD();
                {
                    cmdCategoria.Parameters.AddWithValue("@pIdCategoria", cat.IdCategoria);
                    cmdCategoria.Parameters.AddWithValue("@pNombre", cat.Nombre);
                    cmdCategoria.Parameters.AddWithValue("@pDescripcion", cat.Descripcion);
                }
                int registros;
                registros = cmdCategoria.ExecuteNonQuery();
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
        public List<Categoria> ListarCategoria()
        {
            List<Categoria> lista = new List<Categoria>();
            Categoria c;
            SqlDataReader lector;
            try
            {
                cmdCategoria.CommandType = CommandType.StoredProcedure;
                cmdCategoria.CommandText = "SP_Listar_Categorias";
                cmdCategoria.Connection = conn.conectarBD();

                lector = cmdCategoria.ExecuteReader();

                while (lector.Read())
                {
                    c = new Categoria();
                    c.IdCategoria = (int)lector[0];
                    c.Nombre = (string) lector[1];
                    c.Descripcion = (string)lector[2];
                    lista.Add(c);
                }
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.Message);
            }
            return lista;
        }
        public Categoria BuscarCategoriaById(int id)
        {
            Categoria c = new Categoria();
            SqlDataReader lector;
            try
            {
                cmdCategoria.CommandType = CommandType.StoredProcedure;
                cmdCategoria.CommandText = "SP_BuscarCategoriaById";
                cmdCategoria.Connection = conn.conectarBD();
                {
                    cmdCategoria.Parameters.AddWithValue("@pIdCategoria", id);
                }
                lector = cmdCategoria.ExecuteReader();
                if (lector.Read())
                {
                    c.IdCategoria = (int)lector[0];
                    c.Nombre = (string)lector[1];
                    c.Descripcion = (string)lector[2];
                }
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.Message);
            }
            return c;
        }
        public int CodCategoria()
        {
            int codigo = 0;
            SqlDataReader lector;
            cmdCategoria.CommandType = CommandType.StoredProcedure;
            cmdCategoria.CommandText = "SP_Generar_Codigo_Categoria";
            cmdCategoria.Connection = conn.conectarBD();

            lector = cmdCategoria.ExecuteReader();
            if (lector.Read())
            {
                codigo = (int)lector[0];
            }
            return codigo;
        }
    }
}
