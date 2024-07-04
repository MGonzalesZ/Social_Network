using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace panalbase
{
    public partial class ResetPassword : Form
    {
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            //string sConexion = "Data Source=servidorpanal.database.windows.net;Initial Catalog=BDPanal;User ID=adminPanal;Password=Panal-123";
            //string sConexion = "Data Source=WINDOWS;Initial Catalog=DBPANAL;Integrated Security=True";
            SqlConnection dataConnection = new SqlConnection(BaseDeDatos.EnlaceConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_CambiarContraseña", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("@Correo", SqlDbType.NVarChar, 50);
            da.SelectCommand.Parameters.Add("@Contraseña", SqlDbType.NVarChar, 50);
            

            da.SelectCommand.Parameters["@Correo"].Value = txtRecuperarCorreo.Text;
            da.SelectCommand.Parameters["@Contraseña"].Value = txtResetPass.Text;
          
            da.Fill(dt);
            MessageBox.Show("Se cambio la contraseña correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
