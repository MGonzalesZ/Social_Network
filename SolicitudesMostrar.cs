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
    public partial class SolicitudesMostrar : Form
    {
        public int idAmigo { get; set; }
        public SolicitudesMostrar()
        {
            InitializeComponent();
        }
        private void btnAceptarSoli_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"¿Deseas aceptar la solicitud de amistad de {lNombreSoli.Text}?", "ACEPTAR SOLICITUD", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AceptarSolicitud();
            }
        }
        private void btnRechazarSoli_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"¿Deseas aceptar la rechazar de amistad de {lNombreSoli.Text}?", "RECHAZAR SOLICITUD", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RechazarSolicitud();
            }
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
            this.Close();
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
            this.Close();
        }
    }
}
