using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRomeroERP
{
    public partial class frmPersonal : Form
    {
        private readonly UsuarioInfo _usuario;
        private int _contadorRedes = 1;
        private int _contadorDoms = 1;

        public frmPersonal(UsuarioInfo usuario)
        {
            InitializeComponent();
            _usuario = usuario; 
        }

        private void frmPersonal_Load(object sender, EventArgs e)
        {
            
        }
    }
}
