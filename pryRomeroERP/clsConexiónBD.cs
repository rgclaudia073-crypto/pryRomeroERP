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
        OleDbCommand ComandoBaseDatos;

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
        public UsuarioInfo ValidarUsuario(string nombre, string contraseña, string perfil)
        {
            try
            {
                ConectarBaseDatos();
                ConectorBaseDatos.Open();

                //Paso 1: Validar usuario y contraseña
                string sql1 = "SELECT IdUsuario, Nombre,Apellido FROM Usuario" +
                             "WHERE Nombre = ? AND Contrasenia = ?";
                ComandoBaseDatos = new OleDbCommand(sql1, ConectorBaseDatos);
                ComandoBaseDatos.Parameters.Add("p1", OleDbType.VarWChar).Value = nombre;
                ComandoBaseDatos.Parameters.Add("p2", OleDbType.VarWChar).Value = contraseña;

                OleDbDataReader lector = ComandoBaseDatos.ExecuteReader();
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
                ComandoBaseDatos = new OleDbCommand(sql2, ConectorBaseDatos);
                ComandoBaseDatos.Parameters.Add("p1", OleDbType.VarChar).Value = nombre;

                lector = ComandoBaseDatos.ExecuteReader();
                if (lector.Read())
                {
                    lector.Close();
                    ConectorBaseDatos.Close();
                    return null; // perfil no existe
                }

                string idPerfil = lector["IdPerfil"].ToString();
                lector.Close();

                //Paso 3: verificar que el perfil corresponde al nombre de perfil ingresado
                string sql3 = "SELECT Nombre FROM [Relacion/P-U] WHERE IdUsuario = ? AND IDPerfil = ?";
                ComandoBaseDatos = new OleDbCommand(sql3, ConectorBaseDatos);
                ComandoBaseDatos.Parameters.Add("p1", OleDbType.VarChar).Value = idUsuario;
                ComandoBaseDatos.Parameters.Add("p2", OleDbType.VarChar).Value = idPerfil;

                lector = ComandoBaseDatos.ExecuteReader();
                bool tieneRelacion = lector.Read();
                lector.Close();
                ConectorBaseDatos.Close();

                if (!tieneRelacion)
                {
                    return new UsuarioInfo
                    {
                        NombreCompleto = nombreCompleto,
                        Perfil = perfil,
                        FechaIngreso = DateTime.Now
                    };
                }
            }

            catch (Exception error) 
            
            {
                MessageBox.Show("Error al validar usuario; " + error.Message);
                return null;
            }
            
        }
        public class UsuarioInfo
        {
            public string NombreCompleto { get; set; }
            public string Perfil { get; set; }
            public DateTime? FechaIngreso { get; set; }
            public int IdSesion {  get; set; }
        }
            
    }

    
}
