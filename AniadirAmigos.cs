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
    public partial class AniadirAmigos : Form
    {
        //ATRIBUTOS
        private int idUsuario = 0;
        public AniadirAmigos()
        {
            InitializeComponent();
        }

        //EVENTOS
        private void AniadirAmigos_Load(object sender, EventArgs e)
        {
            dGVUsuarios.DataSource = MostrarUsuarios();
            dGVUsuarios.Columns[0].Visible = false;
        }
        private void btnBuscarUsuarios_Click(object sender, EventArgs e)
        {
            dGVUsuarios.DataSource = BuscarUsuarios();
            dGVUsuarios.Columns[0].Visible = false;
        }
        private void btnEnviarSoli_Click(object sender, EventArgs e)
        {
            try
            {
                EnviarSoli();
                MessageBox.Show("Solicitud enviada");
            }
            catch
            {
                MessageBox.Show("Seleccione un registro válido");
            }
        }
        //almacena el numero de fila en el que hacemos click
        private void dGVUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idUsuario = e.RowIndex;
        }

        //FUNCIONES
        public DataTable MostrarUsuarios()
        {
            DataTable dt = new DataTable();
            SqlConnection dataConnection = new SqlConnection(BaseDeDatos.EnlaceConexion);
            SqlDataAdapter da = new SqlDataAdapter("SPMostrar_Usuarios", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.Fill(dt);
            return dt;
        }
        public DataTable BuscarUsuarios()
        {
            DataTable dt = new DataTable();
            System.Data.SqlClient.SqlConnection dataConnection = new SqlConnection(BaseDeDatos.EnlaceConexion);
            SqlDataAdapter da = new SqlDataAdapter("SPMostrar_buscarUsuarios", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("@Nombre", SqlDbType.NVarChar);

            da.SelectCommand.Parameters["@Nombre"].Value = tBBuscarUsuarios.Text;
            da.Fill(dt);
            return dt;
        }
        public void EnviarSoli()
        {
            DataTable dt = new DataTable();
            System.Data.SqlClient.SqlConnection dataConnection = new SqlConnection(BaseDeDatos.EnlaceConexion);
            SqlDataAdapter da = new SqlDataAdapter("SPRegistrar_EnvioSolicitud", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("@IdUsuario", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@IdUsuario2", SqlDbType.Int);

            da.SelectCommand.Parameters["@IdUsuario"].Value = 1; //Este será el id del usuario actual
            da.SelectCommand.Parameters["@IdUsuario2"].Value = dGVUsuarios.Rows[idUsuario].Cells[0].Value;

            da.Fill(dt);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tBBuscarUsuarios_TextChanged(object sender, EventArgs e)
        {

        }

        private void dGVUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
