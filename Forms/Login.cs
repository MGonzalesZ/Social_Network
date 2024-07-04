using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace panalbase
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int permiso = 0;
            //string cadena = "Data Source=servidorpanal.database.windows.net;Initial Catalog=BDPanal;User ID=adminPanal;Password=Panal-123";
            //string cadena = "Data Source=servidorpanal.database.windows.net;Initial Catalog=BDPanal;User ID=adminPanal;Password=Panal-123";
            //string cadena = "Data Source=WINDOWS;Initial Catalog=DBPANAL;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(BaseDeDatos.EnlaceConexion);
            SqlDataAdapter da = new SqlDataAdapter("PLoginUsuario22", conexion);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@nombreUsuario", SqlDbType.NVarChar, 50);
            da.SelectCommand.Parameters.Add("@password", SqlDbType.NVarChar, 50);
            da.SelectCommand.Parameters.Add("@salida", SqlDbType.Int);
            //da.SelectCommand.Parameters.Add("@idUsuario", SqlDbType.Int);

            da.SelectCommand.Parameters["@nombreUsuario"].Value = txtUsuario.Text.Trim();
            da.SelectCommand.Parameters["@password"].Value = txtContrasenia.Text;
            da.SelectCommand.Parameters["@salida"].Direction = ParameterDirection.Output;
            //da.SelectCommand.Parameters["@idUsuario"].Direction = ParameterDirection.Output;

            conexion.Open();
            da.SelectCommand.ExecuteNonQuery();
            da.Fill(BaseDeDatos.dtLogin);
            permiso = int.Parse(Convert.ToString(da.SelectCommand.Parameters["@salida"].Value));
            conexion.Close();
            if (permiso == 0)
            {
                MessageBox.Show("Usuario o Contraseña Incorrectos!!!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (permiso == 1)
            {
                //Program.idUsuarioActual = int.Parse(Convert.ToString(da.SelectCommand.Parameters["@idUsuario"].Value));
                MessageBox.Show("Bienvenido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BaseDeDatos.usuarioActual.idUsuario = int.Parse(BaseDeDatos.dtLogin.Rows[0][0].ToString());
                BaseDeDatos.usuarioActual.nombreUsuario = BaseDeDatos.dtLogin.Rows[0][4].ToString();
                BaseDeDatos.usuarioActual.contraseniaUsuario = BaseDeDatos.dtLogin.Rows[0][5].ToString();
                BaseDeDatos.usuarioActual.nombre = BaseDeDatos.dtLogin.Rows[0][5].ToString();
                BaseDeDatos.usuarioActual.nombre = BaseDeDatos.dtLogin.Rows[0][5].ToString();


                // ESTO ES NUEVO =====================================================================================================
                // ===================================================================================================================
                try
                {
                    SqlConnection con = new SqlConnection(BaseDeDatos.EnlaceConexion);
                    SqlDataAdapter adaptIp = new SqlDataAdapter("PGuardarIP", con);
                    adaptIp.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adaptIp.SelectCommand.Parameters.Add("@IdUsuario", SqlDbType.Int);
                    adaptIp.SelectCommand.Parameters.Add("@DireccionIP", SqlDbType.NVarChar, 30);

                    adaptIp.SelectCommand.Parameters["@IdUsuario"].Value = BaseDeDatos.usuarioActual.idUsuario;
                    adaptIp.SelectCommand.Parameters["@DireccionIP"].Value = GetLocalIP();

                    con.Open();
                    adaptIp.SelectCommand.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                // HASTA AQUI ========================================================================================================
                // ===================================================================================================================

                //Program.Ingreso.Close();
                //this.Close();
                
                Program.Principal.Show();
                //PaginaPrincipal Principal = new PaginaPrincipal();
                //Principal.Show();
                //BaseDeDatos.Ingreso.Hide();
                Program.CrearPubl.refrescarDataGrid();
                Program.Principal.refrescarGranPanel();
                this.Hide();

            }

            //this.Hide();
        }

        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Registro res = new Registro();
            res.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            EnviarCodigo sc = new EnviarCodigo();
            this.Hide();
            sc.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtContrasenia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            accesoEnter(sender, e);
        }

        private void txtContrasenia_KeyPress(object sender, KeyPressEventArgs e)
        {
            accesoEnter(sender, e);
        }

        private void accesoEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnIngresar_Click(sender, e);
            }
        }
    }
}
