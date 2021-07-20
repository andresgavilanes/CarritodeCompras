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
    public class CargoDAO
    {
        private conexionBD conn = new conexionBD();
        private SqlCommand cmdCargo = new SqlCommand();

        public string InsertarCargo(Cargo c)
        {
            throw new NotImplementedException();
        }

        public string ActualizarCargo(Cargo c)
        {
            throw new NotImplementedException();
        }

        public List<Cargo> listarCargo()
        {
            List<Cargo> lista = new List<Cargo>();
            Cargo C;
            SqlDataReader lector;
            try
            {
                cmdCargo.CommandType = CommandType.StoredProcedure;
                cmdCargo.CommandText = "SP_Listar_Cargo";
                cmdCargo.Connection = conn.conectarBD();

                lector = cmdCargo.ExecuteReader();

                while (lector.Read())
                {
                    C = new Cargo();
                    C.IdCargo = (int)lector[0];
                    C.Nombre = (string)lector[1];
                    C.Estado = (string)lector[2];
                    lista.Add(C);
                }

            }
            catch (Exception ex)
            {
                System.Console.Write(ex.Message);
            }
            return lista;
        }

        public Cargo BuscarCargoById(int id)
        {
            throw new NotImplementedException();
        }

        public int CodCargo()
        {
            int codigo = 0;
            SqlDataReader lector;
            cmdCargo.CommandType = CommandType.StoredProcedure;
            cmdCargo.CommandText = "SP_Generar_Codigo_Cargo";
            cmdCargo.Connection = conn.conectarBD();

            lector = cmdCargo.ExecuteReader();
            if (lector.Read())
            {
                codigo = (int)lector[0];
            }
            return codigo;
        }
    }
}
