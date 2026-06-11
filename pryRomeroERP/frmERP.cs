using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static pryRomeroERP.clsConexiónBD;

namespace pryRomeroERP
{
    public partial class frmMain : Form
    {
        private readonly UsuarioInfo _usuario;
        //Contructor que recibe la información del usuario
        public frmMain(UsuarioInfo usuario)
        {
            InitializeComponent();
            _usuario = usuario;
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // ── 1. Mostrar bienvenida con datos reales de la BD ───────────────
            if (_usuario != null)
            {
                lblBienvenida.Text =
                    $"Bienvenido: {_usuario.NombreCompleto}   |   " +
                    $"Perfil: {_usuario.Perfil}   |   " +
                    $"Ingreso: {_usuario.FechaIngreso:dd/MM/yyyy HH:mm:ss}";
            }

            // ── 2. Probar conexión con animación de ProgressBar ───────────────
            IniciarProgresoConexion();
        }

        private void IniciarProgresoConexion()
        {
            toolStripStatusLabel1.Text = "Conectando a la base de datos...";
            toolStripStatusLabel1.ForeColor = Color.DarkGoldenrod;
            toolStripStatusLabel1.BackColor = Color.Transparent;
            progressBarConexion.Visible = true;
            progressBarConexion.Value = 0;


            Thread hilo = new Thread(() =>
            {
                // Animación 0 → 80
                for (int i = 0; i <= 80; i += 10)
                {
                    Thread.Sleep(80);
                    int valor = i;
                    this.Invoke((MethodInvoker)(() => progressBarConexion.Value = valor));
                }
                // Prueba real de conexión
                clsConexiónBD conexion = new clsConexiónBD();
                bool conectado = conexion.ProbarConexion();

                this.Invoke((MethodInvoker)(() =>
                {
                    progressBarConexion.Value = 100;

                    if (conectado)
                    {
                        toolStripStatusLabel1.Text = "● Conectado a la base de datos";
                        toolStripStatusLabel1.ForeColor = Color.White;
                        toolStripStatusLabel1.BackColor = Color.Green;
                    }
                    else
                    {
                        toolStripStatusLabel1.Text = "● Sin conexión a la base de datos";
                        toolStripStatusLabel1.ForeColor = Color.White;
                        toolStripStatusLabel1.BackColor = Color.Red;
                    }

                    progressBarConexion.Visible = false;
                }));
            });
        }
    }

            
    
}
