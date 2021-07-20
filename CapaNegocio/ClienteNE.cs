using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class ClienteNE
    {
        ClienteDAO Cldao = new ClienteDAO();

        public string InsertarCliente(Cliente Cl)
        {
            return Cldao.InsertarClientes(Cl);
        }
        public string ActualizarCliente(Cliente Cl)
        {
            return Cldao.ActualizarClientes(Cl);
        }
        public List<Cliente> ListarCliente()
        {
            return Cldao.ListarClientes();
        }
        public Cliente BuscarClienteById(int id)
        {
            return Cldao.BuscarClienteById(id);
        }
        public Cliente AutentificarCliente(Cliente cli)
        {
            return Cldao.AutentificarCliente(cli);
        }
        public string EliminarCliente(int id)
        {
            return Cldao.EliminarCliente(id);
        }
        public int CodCliente()
        {
            return Cldao.CodCliente();
        }
    }
}
