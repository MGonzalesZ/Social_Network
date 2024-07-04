using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace panalbase
{
    public partial class frmElegirChat : Form
    {
        public frmElegirChat()
        {
            InitializeComponent();
        }

        private void btnIrChat_Click(object sender, EventArgs e)
        {
            BaseDeDatos.usuarioCHAT.idUsuario = 9;
            BaseDeDatos.usuarioCHAT.idPais = 1;
            BaseDeDatos.usuarioCHAT.nombre = "Carl";
            BaseDeDatos.usuarioCHAT.apellidos = "Carlson";
            BaseDeDatos.usuarioCHAT.nombreUsuario = "Carl";
            BaseDeDatos.usuarioCHAT.contraseniaUsuario = "123";
            CHAT nuevoChat = new CHAT(BaseDeDatos.usuarioActual,BaseDeDatos.usuarioCHAT);
            nuevoChat.Show();
        }
    }
}
