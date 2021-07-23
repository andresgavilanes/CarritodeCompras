namespace Entidades
{
    public class Usuario
    {
        private int _IdUsuario;
        private string _Login;
        private string _Password;
        private string _IdEmpleado;

        public int IdUsuario
        {
            get { return _IdUsuario; }
            set { _IdUsuario = value; }
        }
        public string Login
        {
            get { return _Login; }
            set { _Login = value; }
        }
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
        public string IdEmpleado
        {
            get { return _IdEmpleado; }
            set { _IdEmpleado = value; }
        }
    }
}
