using CapaDatos;
using Entidades;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CargoNE
    {
        CargoDAO cdao = new CargoDAO();

        public string InsertarCargo(Cargo c)
        {
            return cdao.InsertarCargo(c);
        }
        public string ActualizarCargo(Cargo c)
        {
            return cdao.ActualizarCargo(c);
        }
        public List<Cargo> ListarCargo()
        {
            return cdao.listarCargo();
        }
        public Cargo BuscarCargoById(int id)
        {
            return cdao.BuscarCargoById(id);
        }
        public int CodCargo()
        {
            return cdao.CodCargo();
        }
    }
}
