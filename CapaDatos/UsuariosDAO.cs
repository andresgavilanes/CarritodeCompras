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
    public class UsuariosDAO
    {
        private conexionBD conn = new conexionBD();
        private SqlCommand cmdUsuario = new SqlCommand();

        public string InsertarUsuario(Usuario us)
        {
            throw new NotImplementedException();
        }

        public string ActualizarUsuario(Usuario us)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> listarUsuario()
        {
            throw new NotImplementedException();
        }

        public Usuario BuscarUsuarioById(int id)
        {
            throw new NotImplementedException();
        }

        public int CodUsuario()
        {
            int codigo = 0;
            SqlDataReader lector;
            cmdUsuario.CommandType = CommandType.StoredProcedure;
            cmdUsuario.CommandText = "SP_Generar_Codigo_Usuario";
            cmdUsuario.Connection = conn.conectarBD();

            lector = cmdUsuario.ExecuteReader();
            if (lector.Read())
            {
                codigo = (int)lector[0];
            }
            return codigo;
        }
        public Usuario AutentificarUsuario(Usuario usuario)
        {
            Usuario U = new Usuario();
            SqlDataReader lector;
            try
            {
                cmdUsuario.CommandType = CommandType.StoredProcedure;
                cmdUsuario.CommandText = "SP_Autentificar_Usuarios";
                cmdUsuario.Connection = conn.conectarBD();

                {
                    cmdUsuario.Parameters.AddWithValue("@login", usuario.Login);
                    cmdUsuario.Parameters.AddWithValue("@password", usuario.Password);
                }
                lector = cmdUsuario.ExecuteReader();
                while (lector.Read())
                {
                    U.IdUsuario = (int)lector[0];
                    U.Login = (string)lector[1];
                    U.Password = (string)lector[2];
                    U.IdEmpleado = lector[3].ToString();  //Para recuperar valores numericos
                }
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.Message);
            }
            return U;
        }
     }
}
