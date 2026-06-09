using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        }

            
    }
}
