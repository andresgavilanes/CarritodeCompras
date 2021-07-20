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
    public class ClienteDAO
    {
        private conexionBD conn = new conexionBD();
        private SqlCommand cmdCliente = new SqlCommand();

        public string InsertarClientes(Cliente cl)
        {
            string rpta = "";
            try
            {
                cmdCliente.CommandType = CommandType.StoredProcedure;
                cmdCliente.CommandText = "SP_Insertar_Cliente";
                cmdCliente.Connection = conn.conectarBD();

                {
                    cmdCliente.Parameters.AddWithValue("@pidCliente", cl.idCliente);
                    cmdCliente.Parameters.AddWithValue("@pNombres", cl.Nombres);
                    cmdCliente.Parameters.AddWithValue("@aApellidos", cl.Apellidos);
                    cmdCliente.Parameters.AddWithValue("@pDireccion", cl.Direccion);
                    cmdCliente.Parameters.AddWithValue("@pTelefono", cl.Telefono);
                    cmdCliente.Parameters.AddWithValue("@pDNI", cl.DNI);
                    cmdCliente.Parameters.AddWithValue("@pEmail", cl.Email);
                    cmdCliente.Parameters.AddWithValue("@pUsuario", cl.Usuario);
                    cmdCliente.Parameters.AddWithValue("@pClave", cl.Clave);
                }
                int registros;
                registros = cmdCliente.ExecuteNonQuery();
                if (registros == 1)
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
        public string ActualizarClientes(Cliente cl)
        {
            string rpta = "";
            try
            {
                cmdCliente.CommandType = CommandType.StoredProcedure;
                cmdCliente.CommandText = "SP_Actualizar_Cliente";
                cmdCliente.Connection = conn.conectarBD();

                {
                    cmdCliente.Parameters.AddWithValue("@pidCliente", cl.idCliente);
                    cmdCliente.Parameters.AddWithValue("@pNombres", cl.Nombres);
                    cmdCliente.Parameters.AddWithValue("@aApellidos", cl.Apellidos);
                    cmdCliente.Parameters.AddWithValue("@pDireccion", cl.Direccion);
                    cmdCliente.Parameters.AddWithValue("@pTelefono", cl.Telefono);
                    cmdCliente.Parameters.AddWithValue("@pDNI", cl.DNI);
                    cmdCliente.Parameters.AddWithValue("@pEmail", cl.Email);
                    cmdCliente.Parameters.AddWithValue("@pUsuario", cl.Usuario);
                    cmdCliente.Parameters.AddWithValue("@pClave", cl.Clave);
                }
                int registros;
                registros = cmdCliente.ExecuteNonQuery();
                if (registros == 1)
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
        public List<Cliente> ListarClientes()
        {
            List<Cliente> lista = new List<Cliente>();
            SqlDataReader lector;
            try
            {
                cmdCliente.CommandType = CommandType.StoredProcedure;
                cmdCliente.CommandText = "SP_Listar_Clientes";
                cmdCliente.Connection = conn.conectarBD();
                lector = cmdCliente.ExecuteReader();

                while (lector.Read())
                {
                    Cliente c = new Cliente();
                    c.idCliente = (int)lector[0];
                    c.Nombres = lector[1].ToString();
                    c.Apellidos = lector[2].ToString();
                    c.Direccion = lector[3].ToString();
                    c.Telefono = lector[4].ToString();
                    c.DNI = lector[5].ToString();
                    c.Email = lector[6].ToString();
                    c.Usuario = lector[7].ToString();
                    c.Clave = lector[8].ToString();
                    lista.Add(c);
                }
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.Message);
            }
            return lista;
        }
        public Cliente BuscarClienteById(int id)
        {
            Cliente c = new Cliente();
            SqlDataReader lector;
            try
            {
                cmdCliente.CommandType = CommandType.StoredProcedure;
                cmdCliente.CommandText = "SP_BuscarClienteById";
                cmdCliente.Connection = conn.conectarBD();
                {
                    cmdCliente.Parameters.AddWithValue("@pidcliente", id);
                }
                lector = cmdCliente.ExecuteReader();

                if (lector.Read())
                {
                    c.idCliente = (int)lector[0];
                    c.Nombres = lector[1].ToString();
                    c.Apellidos = lector[2].ToString();
                    c.Direccion = lector[3].ToString();
                    c.Telefono = lector[4].ToString();
                    c.DNI = lector[5].ToString();
                    c.Email = lector[6].ToString();
                    c.Usuario = lector[7].ToString();
                    c.Clave = lector[8].ToString();
                    
                }
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.Message);
            }
            return c;
        }
        public Cliente AutentificarCliente(Cliente cli)
        {
            Cliente c = new Cliente();
            SqlDataReader lector;
            try
            {
                cmdCliente.CommandType = CommandType.StoredProcedure;
                cmdCliente.CommandText = "SP_Autentificar_Clientes";
                cmdCliente.Connection = conn.conectarBD();
                {
                    cmdCliente.Parameters.AddWithValue("@Usuario", cli.Usuario);
                    cmdCliente.Parameters.AddWithValue("@Clave", cli.Clave);
                }
                lector = cmdCliente.ExecuteReader();
                if (lector.Read())
                {
                    c.idCliente = (int)lector[0];
                    c.Nombres = lector[1].ToString();
                    c.Apellidos = lector[2].ToString();
                    c.Direccion = lector[3].ToString();
                    c.Telefono = lector[4].ToString();
                    c.DNI = lector[5].ToString();
                    c.Email = lector[6].ToString();
                    c.Usuario = lector[7].ToString();
                    c.Clave = lector[8].ToString();

                }
            }
            catch (Exception)
            {
                throw;
            }
            return c;
        }
        public string EliminarCliente(int id)
        {
            string rpta = "";
            try
            {
                cmdCliente.CommandType = CommandType.StoredProcedure;
                cmdCliente.CommandText = "SP_Eliminar_Cliente";
                cmdCliente.Connection = conn.conectarBD();
                {
                    cmdCliente.Parameters.AddWithValue("@pIdCliente", id);
                }
                int registros;
                registros = cmdCliente.ExecuteNonQuery();
                if (registros == 1)
                {
                    rpta = "OK";
                }
                else
                {
                    rpta = "Error en Eliminar Cliente";
                }
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.Message);
            }
            return rpta;   
        }
        public int CodCliente()
        {
            int codigo = 0;
            SqlDataReader lector;
            cmdCliente.CommandType = CommandType.StoredProcedure;
            cmdCliente.CommandText = "SP_Generar_Codigo_Cliente";
            cmdCliente.Connection = conn.conectarBD();

            lector = cmdCliente.ExecuteReader();
            if (lector.Read())
            {
                codigo = (int)lector[0];
            }
            return codigo;
        }
    
    }
}
