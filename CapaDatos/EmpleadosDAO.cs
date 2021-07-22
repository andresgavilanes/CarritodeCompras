using BDConexion;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class EmpleadosDAO
    {
        private conexionBD conn = new conexionBD();
        private SqlCommand cmdEmpleados = new SqlCommand();

        public string InsertarEmpleados(Empleados E)
        {
            string rpta = "";
            try
            {
                cmdEmpleados.CommandType = CommandType.StoredProcedure;
                cmdEmpleados.CommandText = "SP_Insertar_Empleados";
                cmdEmpleados.Connection = conn.conectarBD();
                {
                    cmdEmpleados.Parameters.AddWithValue("@pIdEmpleado", E.IdEmpleado);
                    cmdEmpleados.Parameters.AddWithValue("@pNombres", E.Nombres);
                    cmdEmpleados.Parameters.AddWithValue("@pApellidos", E.Apellidos);
                    cmdEmpleados.Parameters.AddWithValue("@pCargo", E.Cargo);

                }
                int registros;
                registros = cmdEmpleados.ExecuteNonQuery();
                if (registros == 1)
                {
                    rpta = "OK";
                }
                else
                {
                    rpta = "Error al Insertar Empleado";
                }
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.Message);
            }
            return rpta;
        }

        public string ActualizarEmpleados(Empleados e)
        {
            throw new NotImplementedException();
        }

        public string ActualizarEmpleado(Empleados E)
        {
            string rpta = "";
            try
            {
                cmdEmpleados.CommandType = CommandType.StoredProcedure;
                cmdEmpleados.CommandText = "SP_Actualizar_Empleados";
                cmdEmpleados.Connection = conn.conectarBD();
                {
                    cmdEmpleados.Parameters.AddWithValue("@pIdEmpleado", E.IdEmpleado);
                    cmdEmpleados.Parameters.AddWithValue("@pNombres", E.Nombres);
                    cmdEmpleados.Parameters.AddWithValue("@pApellidos", E.Apellidos);
                    cmdEmpleados.Parameters.AddWithValue("@pCargo", E.Cargo);
                }
                int registros;
                registros = cmdEmpleados.ExecuteNonQuery();
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
        public List<Empleados> ListarEmpleados()
        {
            List<Empleados> lista = new List<Empleados>();
            Empleados E;
            SqlDataReader lector;
            try
            {
                cmdEmpleados.CommandType = CommandType.StoredProcedure;
                cmdEmpleados.CommandText = "SP_Listar_Empleados";
                cmdEmpleados.Connection = conn.conectarBD();

                lector = cmdEmpleados.ExecuteReader();

                while (lector.Read())
                {
                    E = new Empleados();
                    E.IdEmpleado = (int)lector[0];
                    E.Nombres = (string)lector[1];
                    E.Apellidos = (string)lector[2];
                    E.Cargo = (string)lector[3];
                    lista.Add(E);
                }
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.Message);
            }
            return lista;
        }
        public Empleados BuscarEmpleadosById(int id)
        {
            Empleados E = new Empleados();
            SqlDataReader lector;
            try
            {
                cmdEmpleados.CommandType = CommandType.StoredProcedure;
                cmdEmpleados.CommandText = "SP_BuscarEmpleadosById";
                cmdEmpleados.Connection = conn.conectarBD();
                {
                    cmdEmpleados.Parameters.AddWithValue("@pIdEmpleados", id);
                }
                lector = cmdEmpleados.ExecuteReader();
                if (lector.Read())
                {
                    E.IdEmpleado = (int)lector[0];
                    E.Nombres = (string)lector[1];
                    E.Apellidos = (string)lector[2];
                    E.Cargo = (string)lector[3];
                }
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.Message);
            }
            return E;
        }
        public int CodEmpleado()
        {
            int codigo = 0;
            SqlDataReader lector;
            cmdEmpleados.CommandType = CommandType.StoredProcedure;
            cmdEmpleados.CommandText = "SP_Generar_Codigo_Empleado";
            cmdEmpleados.Connection = conn.conectarBD();

            lector = cmdEmpleados.ExecuteReader();
            if (lector.Read())
            {
                codigo = (int)lector[0];
            }
            return codigo;
        }
    }
}
