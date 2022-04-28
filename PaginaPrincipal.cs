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

    public partial class PaginaPrincipal : Form
    {
        int numero = 1;
        int num2 = 1;
        private int check = 0;
        private int check2 = 0;
        public PaginaPrincipal()
        {
            InitializeComponent();
            //refrescarDataGrid();
            iniciarDatos();
            //string sConexion = "Data Source=servidorpanal.database.windows.net;Initial Catalog=BDPanal;User ID=adminPanal;Password=Panal-123";
            string sConexion = "Data Source=WINDOWS;Initial Catalog=DBPANAL;Integrated Security=True";
            var consulta1 = "select IdReaccion, TipoReaccion from Reaccion";
            var adaptador1 = new SqlDataAdapter(consulta1, sConexion);
            var commandBuilder1 = new SqlCommandBuilder(adaptador1);
            var de = new DataSet();
            adaptador1.Fill(de);
            DGreacciones.ReadOnly = true;
            DGreacciones.DataSource = de.Tables[0];
        }

        public void iniciarDatos()
        {
            dgView.AutoGenerateColumns = true;
            dgView.DataSource = Program.dt;
            
            // Resize the DataGridView columns to fit the newly loaded content.
            //dgView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
        }
        

        private void btnComentar_Click(object sender, EventArgs e)
        {
            Program.Principal.Close();
            Program.Coment.Show();
        }

        private void btnPublicar_Click(object sender, EventArgs e)
        {
            Program.Principal.Hide();
            Program.CrearPubl.Show();
            Program.CrearPubl.Refresh();
        }

        private void btnVerPubl_Click(object sender, EventArgs e)
        {
            Program.idPublEditar = Convert.ToInt32(Program.dt.Rows[dgView.CurrentCell.RowIndex][0]);
            //VerPublicacElegida ver11 = new VerPublicacElegida();
            
            Program.ver11.LabelPublic.Text=Program.dt.Rows[dgView.CurrentCell.RowIndex][2].ToString();
            Program.ver11.LabelFecha.Text = Program.dt.Rows[dgView.CurrentCell.RowIndex][3].ToString();
            //System.IO.MemoryStream ms = new System.IO.MemoryStream();
            Byte[] myByte = new byte[0];
            if (Program.dt.Rows[dgView.CurrentCell.RowIndex][4]!=DBNull.Value)
            {
                myByte = (Byte[])(Program.dt.Rows[dgView.CurrentCell.RowIndex][4]);
                System.IO.MemoryStream ms2 = new System.IO.MemoryStream(myByte);
                Program.ver11.pictureBoxPublSel.Image = Image.FromStream(ms2);
            }

            Program.ver11.ShowDialog();
        }

        private void btnEliminarPubl_Click(object sender, EventArgs e)
        {
            Boolean Eliminar = false;
            Program.idPublEditar = Convert.ToInt32(Program.dt.Rows[dgView.CurrentCell.RowIndex][0]);
            //string cadena = "Data Source=servidorpanal.database.windows.net;Initial Catalog=BDPanal;User ID=adminPanal;Password=Panal-123";
            
            DialogResult respuesta=new DialogResult();
            respuesta = MessageBox.Show("Desea eliminar la publicación seleccionada?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                //string cadena = "Data Source=servidorpanal.database.windows.net;Initial Catalog=BDPanal;User ID=adminPanal;Password=Panal-123";
                string cadena = "Data Source=WINDOWS;Initial Catalog=DBPANAL;Integrated Security=True";
                SqlConnection conexion = new SqlConnection(cadena);
                SqlDataAdapter da = new SqlDataAdapter("PEliminarLogPublicacion", conexion);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@IdPublicacion", SqlDbType.Int);
                da.SelectCommand.Parameters.Add("@IdUsuario", SqlDbType.Int);
                da.SelectCommand.Parameters.Add("@Resultado", SqlDbType.Bit);
                da.SelectCommand.Parameters.Add("@Mensaje", SqlDbType.NVarChar, 500);

                da.SelectCommand.Parameters["@IdPublicacion"].Value = Program.idPublEditar;
                da.SelectCommand.Parameters["@IdUsuario"].Value = Program.idUsuarioActual;

                da.SelectCommand.Parameters["@Resultado"].Direction = ParameterDirection.Output;
                da.SelectCommand.Parameters["@Mensaje"].Direction = ParameterDirection.Output;

                conexion.Open();
                da.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Se ha eliminado la publicación", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexion.Close();
            }
            
            Program.CrearPubl.refrescarDataGrid();
            //this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Amigos amigos = new Amigos();
            amigos.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            check = e.RowIndex;
            numero = Convert.ToInt32(this.dgView.Rows[check].Cells[0].Value);
        }
        private void DGreacciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            check2 = e.RowIndex;
            num2 = Convert.ToInt32(this.dgView.Rows[check2].Cells[0].Value);
        }

        //registrar reacciones
        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlConnection dataConnection = new SqlConnection(BaseDeDatos.EnlaceConexion);
            SqlDataAdapter da = new SqlDataAdapter("SPRegistrar_Reacciones", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@IdUsuario", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@IdPublicacion", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@IdReaccion", SqlDbType.Int);
            da.SelectCommand.Parameters["@IdUsuario"].Value = Program.idUsuarioActual;
            da.SelectCommand.Parameters["@IdPublicacion"].Value = numero;
            da.SelectCommand.Parameters["@IdReaccion"].Value = num2;
            da.Fill(dt);

            //string sConexion = "Data Source=servidorpanal.database.windows.net;Initial Catalog=BDPanal;User ID=adminPanal;Password=Panal-123";
            string sConexion = "Data Source=WINDOWS;Initial Catalog=DBPANAL;Integrated Security=True";
            var consulta = "select IdReaccion, IdPublicacion from Reacciones where EstadoAuditoria=1";
            var adaptador = new SqlDataAdapter(consulta, sConexion);
            var commandBuilder = new SqlCommandBuilder(adaptador);
            var ds = new DataSet();
            adaptador.Fill(ds);
            DGreaccion.ReadOnly = true;
            DGreaccion.DataSource = ds.Tables[0];

        }

        //abrir la ventana reaccion
        private void button1_Click(object sender, EventArgs e)
        {
            React rect = new React();
            rect.Show();
            this.Close();
        }

        //modificar
        private void DGreaccion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            check2 = e.RowIndex;
            num2 = Convert.ToInt32(dgView.Rows[check2].Cells[0].Value);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlConnection dataConnection = new SqlConnection(BaseDeDatos.EnlaceConexion);
            SqlDataAdapter da = new SqlDataAdapter("SPEliminar_Reacciones", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@IdPublicacion", SqlDbType.Int);
            da.SelectCommand.Parameters["@IdPublicacion"].Value = num2;
            da.Fill(dt);
        }
    }
}
