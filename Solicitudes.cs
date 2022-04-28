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

    public partial class Solicitudes : Form
    {
        //ATRIBUTOS
        private int idAmigos = 0;
        public Solicitudes()
        {
            InitializeComponent();
        }

        //EVENTOS
        private void Solicitudes_Load(object sender, EventArgs e)
        {
            MostrarSolicitudes();
        }
        private void btnAceptarSoli_Click(object sender, EventArgs e)
        {
            try
            {
                AceptarSolicitud();
                MessageBox.Show("Solicitud aceptada");
            }
            catch
            {
                MessageBox.Show("Seleccione un registro válido");
            }
            MostrarSolicitudes();
        }
        private void btnRechazarSoli_Click(object sender, EventArgs e)
        {
            try
            {
                RechazarSolicitud();
                MessageBox.Show("Solicitud rechazada");
            }
            catch
            {
                MessageBox.Show("Seleccione un registro válido");
            }
            MostrarSolicitudes();
        }
        //almacena el numero de fila en el que hacemos click
        private void dGVSoli_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idAmigos = e.RowIndex;
        }

        //FUNCIONES
        public void MostrarSolicitudes()
        {
            dGVSoli.DataSource = MandarSolicitudes();
            dGVSoli.Columns[0].Visible = false;
        }
        public DataTable MandarSolicitudes()
        {
            DataTable dt = new DataTable();
            SqlConnection dataConnection = new SqlConnection(BaseDeDatos.EnlaceConexion);
            SqlDataAdapter da = new SqlDataAdapter("SPMostrar_Solicitudes", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.Fill(dt);
            return dt;
        }
        public void AceptarSolicitud()
        {
            DataTable dt = new DataTable();
            System.Data.SqlClient.SqlConnection dataConnection = new SqlConnection(BaseDeDatos.EnlaceConexion);
            SqlDataAdapter da = new SqlDataAdapter("SPRegistrar_SolicitudAceptada", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("@IdAmigos", SqlDbType.Int);

            da.SelectCommand.Parameters["@IdAmigos"].Value = dGVSoli.Rows[idAmigos].Cells[0].Value;

            da.Fill(dt);
        }
        public void RechazarSolicitud()
        {
            DataTable dt = new DataTable();
            System.Data.SqlClient.SqlConnection dataConnection = new SqlConnection(BaseDeDatos.EnlaceConexion);
            SqlDataAdapter da = new SqlDataAdapter("SPRegistrar_SolicitudRechazada", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("@IdAmigos", SqlDbType.Int);

            da.SelectCommand.Parameters["@IdAmigos"].Value = dGVSoli.Rows[idAmigos].Cells[0].Value;

            da.Fill(dt);
        }

        private void dGVSoli_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAceptarSoli_Click_1(object sender, EventArgs e)
        {

        }
    }
}
