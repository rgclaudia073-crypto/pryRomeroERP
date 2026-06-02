using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryRomeroERP
{
    internal class clsConexiónBD
    {
        OleDbConnection ConectorBaseDatos;
        OleDbCommand CommandoBaseDatos;

        public string Estadoconexion;


        public void ConectarBaseDatos()
        {

            try
            {
                ConectorBaseDatos = new OleDbConnection();

                string rutaBase = System.IO.Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    "..", "..",
                    "BaseDeDatos", "Romero,accdb");

                rutaBase = System.IO.Path.GetFullPath(rutaBase);

                ConectorBaseDatos.ConnectionString =
                    $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={rutaBase}";

            }
            catch (Exception error)
            {
                MessageBox.Show("Erro al conectar con la base de datos: " + error.Message);

            }

        }

        public bool ProbarConexion()
        {
            try
            {
                ConectarBaseDatos();
                ConectorBaseDatos.Open();
                Estadoconexion = "Conexión exitosa";
                ConectorBaseDatos.Close();
                return true;
            }
            catch
            {
                Estadoconexion = "Sin Conexion";
                return false;
            }
        }
        public void ValidarUsuario(string nombre, string contraseña, string perfil)
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
                lector.Close();

                //Paso 2: buscar el IDPerfil que corresponde al nombre de perfil
                string sql2 = "SELECT Id FROM [Relacion/P-U] WHERE IdUsuario = ? AND IDPerfil =?";
                CommandoBaseDatos = new OleDbCommand(sql2, ConectorBaseDatos);
                CommandoBaseDatos.Parameters.Add("p1", OleDbType.VarChar).Value = nombre;

                lector = CommandoBaseDatos.ExecuteReader();
                if (lector.Read())
                {
                    lector.Close();
                    ConectorBaseDatos.Close();
                    return null; // perfil no existe
                }

             




            catch
            {

            }
        }
            
    }

    
}
