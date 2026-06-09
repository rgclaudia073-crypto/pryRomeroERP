using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryRomeroERP
{
    public class AuditoriaInfo
    {
        public int IdSesion { get; set; }
        public string Usuario { get; set; }
        public string Perfil { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public string Accion { get; set; }
    }
    public class clsAuditoria
    {
        // ── Helpers de conexión ──────────────────────────────────────────────
        private OleDbConnection AbrirConexion()
        {
            string ruta = System.IO.Path.GetFullPath(
                System.IO.Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    "..", "..", "BaseDeDatos", "Molina.accdb"));

            var cn = new OleDbConnection(
                $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={ruta}");
            cn.Open();
            return cn;

        }
        // ── Crear tabla si no existe ─────────────────────────────────────────
        public void AsegurarTabla()
        {
            try
            {
                using (var cn = AbrirConexion())
                {
                    // Intenta crear; si ya existe Access lanza error → ignoramos
                    string sql = @"CREATE TABLE Auditoria (
                        IdSesion   AUTOINCREMENT PRIMARY KEY,
                        Usuario    TEXT(50),
                        Perfil     TEXT(50),
                        Nombre     TEXT(100),
                        Fecha      DATETIME,
                        Hora       DATETIME,
                        Accion     TEXT(100))";
                    new OleDbCommand(sql, cn).ExecuteNonQuery();
                }
            }
            catch { /* tabla ya existe */ }
        }
        // ── Registra un evento(inicio sesión, ingreso a opción, etc.) ───────
        public int RegistrarEvento(string usuario, string perfil, string nombre, string accion)
        {
            AsegurarTabla();
            try
            {
                using (var cn = AbrirConexion())
                {
                    DateTime ahora = DateTime.Now;
                    string sql = "INSERT INTO Auditoria (Usuario, Perfil, Nombre, Fecha, Hora, Accion) " +
                                 "VALUES (?, ?, ?, ?, ?, ?)";
                    var cmd = new OleDbCommand(sql, cn);
                    cmd.Parameters.Add("p1", OleDbType.VarWChar).Value = usuario;
                    cmd.Parameters.Add("p2", OleDbType.VarWChar).Value = perfil;
                    cmd.Parameters.Add("p3", OleDbType.VarWChar).Value = nombre;
                    cmd.Parameters.Add("p4", OleDbType.Date).Value = ahora.Date;
                    cmd.Parameters.Add("p5", OleDbType.Date).Value = ahora;
                    cmd.Parameters.Add("p6", OleDbType.VarWChar).Value = accion;
                    cmd.ExecuteNonQuery();

                    // Retorna el IdSesion recién insertado
                    int id = 0;
                    var cmdId = new OleDbCommand("SELECT @@IDENTITY", cn);
                    object res = cmdId.ExecuteScalar();
                    if (res != null && res != DBNull.Value) id = Convert.ToInt32(res);
                    return id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar auditoría: " + ex.Message);
                return 0;
            }
        }

        // Alias para mantener compatibilidad con frmInicio.cs existente
        public int IniciarSesion(string usuario) =>
            RegistrarEvento(usuario, "", "", "Inicio de sesión");

        // ── Obtener datos de una sesión (para la vista de auditoría) ─────────
        public AuditoriaInfo ObtenerDatosSesion(int idSesion)
        {
            try
            {
                using (var cn = AbrirConexion())
                {
                    string sql = "SELECT * FROM Auditoria WHERE IdSesion = ?";
                    var cmd = new OleDbCommand(sql, cn);
                    cmd.Parameters.Add("p1", OleDbType.Integer).Value = idSesion;
                    var rd = cmd.ExecuteReader();
                    if (rd.Read())
                        return MapRow(rd);
                }
            }
            catch { }
            return null;
        }


        // ── Obtener todos los registros, con filtros opcionales ───────────────
        public List<AuditoriaInfo> ObtenerRegistros(
            string usuario = "",
            string accion = "",
            DateTime? desde = null,
            DateTime? hasta = null)
        {
            var lista = new List<AuditoriaInfo>();
            try
            {
                using (var cn = AbrirConexion())
                {
                    string sql = "SELECT * FROM Auditoria WHERE 1=1";
                    var cmd = new OleDbCommand();
                    cmd.Connection = cn;

                    if (!string.IsNullOrWhiteSpace(usuario))
                    {
                        sql += " AND Usuario LIKE ?";
                        cmd.Parameters.Add("pu", OleDbType.VarWChar).Value = "%" + usuario.Trim() + "%";
                    }
                    if (!string.IsNullOrWhiteSpace(accion))
                    {
                        sql += " AND Accion LIKE ?";
                        cmd.Parameters.Add("pa", OleDbType.VarWChar).Value = "%" + accion.Trim() + "%";
                    }
                    if (desde.HasValue)
                    {
                        sql += " AND Fecha >= ?";
                        cmd.Parameters.Add("pd", OleDbType.Date).Value = desde.Value.Date;
                    }
                    if (hasta.HasValue)
                    {
                        sql += " AND Fecha <= ?";
                        cmd.Parameters.Add("ph", OleDbType.Date).Value = hasta.Value.Date;
                    }

                    sql += " ORDER BY IdSesion DESC";
                    cmd.CommandText = sql;

                    var rd = cmd.ExecuteReader();
                    while (rd.Read())
                        lista.Add(MapRow(rd));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener auditoría: " + ex.Message);
            }
            return lista;
        }
        private AuditoriaInfo MapRow(OleDbDataReader rd) => new AuditoriaInfo
        {
            IdSesion = Convert.ToInt32(rd["IdSesion"]),
            Usuario = rd["Usuario"].ToString(),
            Perfil = rd["Perfil"].ToString(),
            Nombre = rd["Nombre"].ToString(),
            Fecha = rd["Fecha"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(rd["Fecha"]),
            Hora = rd["Hora"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(rd["Hora"]),
            Accion = rd["Accion"].ToString()
        };
    }
}
