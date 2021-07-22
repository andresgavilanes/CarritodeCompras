using CapaDatos;
using Entidades;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class UsuarioNE
    {
        UsuariosDAO usdao = new UsuariosDAO();

        public string InsertarUsuario(Usuario us)
        {
            return usdao.InsertarUsuario(us);
        }
        public string ActualizarUsuario(Usuario us)
        {
            return usdao.ActualizarUsuario(us);
        }
        public List<Usuario> listarUsuario()
        {
            return usdao.listarUsuario();
        }
        public Usuario BuscarUsuarioById(int id)
        {
            return usdao.BuscarUsuarioById(id);
        }
        public int CodUsuario()
        {
            return usdao.CodUsuario();
        }
        public Usuario AutentificarUsuario(Usuario u)
        {
            return usdao.AutentificarUsuario(u);
        }
    }
}
