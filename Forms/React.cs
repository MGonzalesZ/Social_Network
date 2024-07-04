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
    public partial class React : Form
    {
        //string sConexion = "Data Source=servidorpanal.database.windows.net;Initial Catalog=BDPanal;User ID=adminPanal;Password=Panal-123";
        //string sConexion = "Data Source=WINDOWS;Initial Catalog=DBPANAL;Integrated Security=True";

        public React()
        {
            InitializeComponent();
        }

        private void txtInsertar_Click(object sender, EventArgs e)
        {
            string tiporeaccion = textBox2.Text;
            DataTable dt = new DataTable();

            SqlConnection dataConnection = new SqlConnection(BaseDeDatos.EnlaceConexion);
            SqlDataAdapter da = new SqlDataAdapter("SPRegistrar_Reaccion", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@TipoReaccion", SqlDbType.VarChar, (50));
            da.SelectCommand.Parameters["@TipoReaccion"].Value = tiporeaccion;
            da.Fill(dt);
        }

        private void txtModificar_Click(object sender, EventArgs e)
        {
            int idreaccion = int.Parse(textBox1.Text);
            string tiporeaccion = textBox2.Text;
            DataTable dt = new DataTable();
            SqlConnection dataConnection = new SqlConnection(BaseDeDatos.EnlaceConexion);
            SqlDataAdapter da = new SqlDataAdapter("SPModificar_Reaccion", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@IdReaccion", SqlDbType.Int);
            da.SelectCommand.Parameters["@IdReaccion"].Value = idreaccion;
            da.SelectCommand.Parameters.Add("@TipoReaccion", SqlDbType.VarChar, (50));
            da.SelectCommand.Parameters["@TipoReaccion"].Value = tiporeaccion;
            da.Fill(dt);
        }

        private void txtEliminar_Click(object sender, EventArgs e)
        {
            int idreaccion = int.Parse(textBox1.Text);
            DataTable dt = new DataTable();
            SqlConnection dataConnection = new SqlConnection(BaseDeDatos.EnlaceConexion);
            SqlDataAdapter da = new SqlDataAdapter("SPEliminar_Reaccion", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@IdReaccion", SqlDbType.Int);
            da.SelectCommand.Parameters["@IdReaccion"].Value = idreaccion;
            da.Fill(dt);
        }

        private void txtActualizar_Click(object sender, EventArgs e)
        {
            SqlConnection dataConnection = new SqlConnection(BaseDeDatos.EnlaceConexion);
            var consulta = "select TipoReaccion from Reaccion where EstadoAuditoria = 0";
            var adaptador = new SqlDataAdapter(consulta, dataConnection);
            var commandBuilder = new SqlCommandBuilder(adaptador);
            var ds = new DataSet();
            adaptador.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PaginaPrincipal pg1 = new PaginaPrincipal();
            pg1.Show();
            this.Close();
        }
    }
}
