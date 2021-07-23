using System.Data.SqlClient;

namespace BDConexion
{
    public class conexionBD
    {
        private string cadena = "Data Source=,;Initial Catalog=CarritoBD;Integrated Security=True";
        private SqlConnection conexion;
        public SqlConnection conectarBD()
        {
            conexion = new SqlConnection(cadena);
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
            else
            {
                conexion.Open();
            }
            return conexion;
        }
    }
}
