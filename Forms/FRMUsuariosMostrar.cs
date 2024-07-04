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
    public partial class FRMUsuariosMostrar : Form
    {
        public int idUsuario { get; set; }

        private int idAmigo { get; set; }

        public FRMUsuariosMostrar()
        {
            InitializeComponent();
        }

        private void btnAccionUsu_Click(object sender, EventArgs e)
        {
            switch (btnAccionUsu.Text)
            {
                case "YO":
                    MessageBox.Show("SOY YO");
                    break;
                case "AMIGO(VER PERFIL)":
                    MessageBox.Show("AMIGO(VER PERFIL)");
                    break;
                case "TE ENVIÓ SOLICITUD":
                    ConsultarIdAmigos();
                    if (MessageBox.Show($"¿Deseas añadir a {lNombreUsu.Text}?", "RESPONDER SOLICITUD", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        AceptarSolicitud();
                    else
                        RechazarSolicitud();
                    break;
                case "PENDIENTE":
                    ConsultarIdAmigos2();
                    if (MessageBox.Show($"¿Deseas cancelar la solicitud enviada a {lNombreUsu.Text}?", "CANCELAR SOLICITUD", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        CancelarSolicitud();
                    break;
                case "ENVIAR SOLICITUD":
                    if (MessageBox.Show($"¿Deseas enviar solicitud de amistad a {lNombreUsu.Text}?", "ENVIAR SOLICITUD", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        SPRegistrar_SolicitudEnvio();
                    break;
            }
        }

        private void ConsultarIdAmigos()
        {
            SqlConnection conexion = new SqlConnection(BaseDeDatos.EnlaceConexion);
            conexion.Open();
            SqlCommand comando = new SqlCommand("SPConsultar_IdAmigos", conexion);
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdUsuario", BaseDeDatos.usuarioActual.idUsuario);
            comando.Parameters.AddWithValue("@IdUsuario2", idUsuario);
            comando.Parameters.Add("IdAmigos", SqlDbType.Int).Direction = ParameterDirection.Output;

            comando.ExecuteNonQuery();
            idAmigo = Convert.ToInt32(comando.Parameters["IdAmigos"].Value);
            conexion.Close();
        }
        public void AceptarSolicitud()
        {
            SqlConnection conexion = new SqlConnection(BaseDeDatos.EnlaceConexion);
            conexion.Open();
            SqlCommand comando = new SqlCommand("SPRegistrar_SolicitudAceptada", conexion);
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdAmigos", idAmigo);

            comando.ExecuteNonQuery();
            conexion.Close();
            btnAccionUsu.Text = "AMIGO(VER PERFIL)";
        }
        public void RechazarSolicitud()
        {
            SqlConnection conexion = new SqlConnection(BaseDeDatos.EnlaceConexion);
            conexion.Open();
            SqlCommand comando = new SqlCommand("SPRegistrar_SolicitudRechazada", conexion);
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdAmigos", idAmigo);

            comando.ExecuteNonQuery();
            conexion.Close();
            btnAccionUsu.Text = "ENVIAR SOLICITUD";
        }

        private void ConsultarIdAmigos2()
        {
            SqlConnection conexion = new SqlConnection(BaseDeDatos.EnlaceConexion);
            conexion.Open();
            SqlCommand comando = new SqlCommand("SPConsultar_IdAmigos2", conexion);
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdUsuario", BaseDeDatos.usuarioActual.idUsuario);
            comando.Parameters.AddWithValue("@IdUsuario2", idUsuario);
            comando.Parameters.Add("IdAmigos", SqlDbType.Int).Direction = ParameterDirection.Output;

            comando.ExecuteNonQuery();
            idAmigo = Convert.ToInt32(comando.Parameters["IdAmigos"].Value);
            conexion.Close();
        }
        private void CancelarSolicitud()
        {
            SqlConnection conexion = new SqlConnection(BaseDeDatos.EnlaceConexion);
            conexion.Open();
            SqlCommand comando = new SqlCommand("SPRegistrar_SolicitudCancelada", conexion);
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdAmigos", idAmigo);

            comando.ExecuteNonQuery();
            conexion.Close();
            btnAccionUsu.Text = "ENVIAR SOLICITUD";
        }

        private void SPRegistrar_SolicitudEnvio()
        {
            SqlConnection conexion = new SqlConnection(BaseDeDatos.EnlaceConexion);
            conexion.Open();
            SqlCommand comando = new SqlCommand("SPRegistrar_SolicitudEnvio", conexion);
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdUsuario", BaseDeDatos.usuarioActual.idUsuario);
            comando.Parameters.AddWithValue("@IdUsuario2", idUsuario);

            comando.ExecuteNonQuery();
            conexion.Close();
            btnAccionUsu.Text = "PENDIENTE";
        }
    }
}
