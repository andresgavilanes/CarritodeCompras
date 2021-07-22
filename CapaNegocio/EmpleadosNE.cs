using CapaDatos;
using Entidades;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class EmpleadosNE
    {
        EmpleadosDAO edao = new EmpleadosDAO();

        public string InsertarEmpleados(Empleados e)
        {
            return edao.InsertarEmpleados(e);
        }
        public string ActualizarEmpleados(Empleados e)
        {
            return edao.ActualizarEmpleado(e);
        }
        public List<Empleados> ListarEmpleados()
        {
            return edao.ListarEmpleados();
        }
        public Empleados BuscarEmppleadosByiD(int id)
        {
            return edao.BuscarEmpleadosById(id);
        }
        public int CodEmpleado()
        {
            return edao.CodEmpleado();
        }
    }
}
