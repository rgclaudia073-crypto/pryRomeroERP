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
        OleDbConnection Connection;
        OleDbCommand Command;

        public string Estadoconecion;

    }
}
