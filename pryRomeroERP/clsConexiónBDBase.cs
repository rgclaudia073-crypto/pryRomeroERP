using System.Data.OleDb;

namespace pryRomeroERP
{
    internal class clsConexiónBDBase
    {
        public object ValidarUsuario(string nombre, string contraseña, string perfil)
        {
            try
            {
                ConectarBaseDatos();
                ConectorBaseDatos.Open();

                //Paso 1: Validar usuario y contraseña
                string sql1 = "SELECT IdUsuario, Nombre,Apellido FROM Usuario" + "WHERE Nombre = ? AND Contrasenia = ?";
                CommandoBaseDatos = new OleDbCommand(sql1, ConectorBaseDatos);
                CommandoBaseDatos.Parameters.Add("p1", OleDbType.VarWChar).Value = nombre;
                CommandoBaseDatos.Parameters.Add("p2", OleDbType.VarWChar).Value = contraseña;

                OleDbDataReader lector = CommandoBaseDatos.ExecuteReader();
                if (!lector.Read())
                {
                    lector.Close();
                    ConectorBaseDatos.Close();
                    return null; //usuario y contraseña incorrecta
                }

                string idUsuario = lector["IdUsuario"].ToString();
                string nombreCompleto = lector["Nombre"].ToString() + " " + lector["Apellido"].ToString();



            }
            catch
            {

            }
        }
    }
}