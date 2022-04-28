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
    public partial class Amigos : Form
    {
        //ATRIBUTOS
        private int idAmigo = 0;
        public Amigos()
        {
            InitializeComponent();
        }

        //EVENTOS
        private void Amigos_Load(object sender, EventArgs e)
        {
            MostrarAmigos();
        }
        private void btnBuscarAmigo_Click(object sender, EventArgs e)
        {
            dGVAmigos.DataSource = BuscarAmigos();
            dGVAmigos.Columns[0].Visible = false;
            tBBuscarAmigo.Clear();
        }
        private void btnEliminarAmigo_Click(object sender, EventArgs e)
        {
            try
            {
                EliminarAmigos();
                MessageBox.Show("Amigo Eliminado");
            }
            catch
            {
                MessageBox.Show("Seleccione un registro válido");
            }
            MostrarAmigos();
        }
        private void btnAniadirAmigos_Click(object sender, EventArgs e)
        {
            AniadirAmigos aniadirAmigos = new AniadirAmigos();
            aniadirAmigos.Show();
        }
        private void btnSolicitudes_Click(object sender, EventArgs e)
        {
            Solicitudes solicitudes = new Solicitudes();
            solicitudes.Show();
        }
        //almacena el numero de fila en el que hacemos click
        private void dGVAmigos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idAmigo = e.RowIndex;
        }

        //FUNCIONES
        public void MostrarAmigos()
        {
            dGVAmigos.DataSource = MandarAmigos();
            dGVAmigos.Columns[0].Visible = false;
        }
        public DataTable MandarAmigos()
        {
            DataTable dt = new DataTable();
            SqlConnection dataConnection = new SqlConnection(BaseDeDatos.EnlaceConexion);
            SqlDataAdapter da = new SqlDataAdapter("SPMostrar_Amigos", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.Fill(dt);
            return dt;
        }
        public DataTable BuscarAmigos()
        {
            DataTable dt = new DataTable();
            System.Data.SqlClient.SqlConnection dataConnection = new SqlConnection(BaseDeDatos.EnlaceConexion);
            SqlDataAdapter da = new SqlDataAdapter("SPMostrar_BuscarAmigos", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("@Nombre", SqlDbType.NVarChar);

            da.SelectCommand.Parameters["@Nombre"].Value = tBBuscarAmigo.Text;
            da.Fill(dt);
            return dt;
        }
        public void EliminarAmigos()
        {
            DataTable dt = new DataTable();
            System.Data.SqlClient.SqlConnection dataConnection = new SqlConnection(BaseDeDatos.EnlaceConexion);
            SqlDataAdapter da = new SqlDataAdapter("SPEliminar_Amigos", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("@IdAmigos", SqlDbType.Int);

            da.SelectCommand.Parameters["@IdAmigos"].Value = dGVAmigos.Rows[idAmigo].Cells[0].Value;
            da.Fill(dt);
        }

        private void tBBuscarAmigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dGVAmigos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
