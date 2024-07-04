using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace panalbase
{
    public partial class Amigos : Form
    {
        string respuesta, respuesta2, tipo, tipo2;
        int resp, resp2, tp1, tp2;
        public Amigos()
        {
            InitializeComponent();
            buscarNoti();
        }

        private void buscarNoti()
        {
            SqlConnection conexion = new SqlConnection(BaseDeDatos.EnlaceConexion);
            SqlCommand comando = new SqlCommand("SPConsultaNotiChat", conexion);
            comando.Parameters.Add("@IdUsuario", SqlDbType.Int);
            comando.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
            comando.Parameters.Add("tipo", SqlDbType.Int).Direction = ParameterDirection.Output;
            comando.Parameters["@IdUsuario"].Value = BaseDeDatos.usuarioActual.idUsuario;
            comando.CommandType = CommandType.StoredProcedure;

            conexion.Open();
            comando.ExecuteNonQuery();
            respuesta = (comando.Parameters["resultado"].Value).ToString();
            resp = int.Parse(respuesta);
            //label2.Text = (comando.Parameters["tipo"].Value).ToString();
            if ((comando.Parameters["tipo"].Value) != DBNull.Value)
            {
                tipo = (comando.Parameters["tipo"].Value).ToString();
                tp1 = int.Parse(tipo);
            }
            conexion.Close();
        }



        //EVENTOS
        private void Amigos_Load(object sender, EventArgs e)
        {
            if (BaseDeDatos.soli)
            {
                notisoli.Visible = true;
            }
            else
            {
                notisoli.Visible = false;
            }
            MostrarAmigos(TodosAmigos());
        }
        private void btnBuscarAmigo_Click(object sender, EventArgs e)
        {
            MostrarAmigos(BuscarAmigos());
        }
        private void btnAniadirAmigos_Click(object sender, EventArgs e)
        {
            //AniadirAmigos aniadirAmigos = new AniadirAmigos();
            //aniadirAmigos.Show();
        }
        private void btnAmigos_Click(object sender, EventArgs e)
        {
            MostrarAmigos(TodosAmigos());
            btnAmigos.Enabled = false;
            tBBuscarAmigo.Enabled = true;
            btnBuscarAmigo.Enabled = true;
            btnSolicitudes.Enabled = true;
        }
        private void btnSolicitudes_Click(object sender, EventArgs e)
        {
            MostrarSolicitudes(TodasSolicitudes());
            tBBuscarAmigo.Enabled = false;
            btnBuscarAmigo.Enabled = false;
            btnSolicitudes.Enabled = false;
            btnAmigos.Enabled = true;
        }

        //FUNCIONES
        public void MostrarAmigos(DataTable dataTable)
        {
            AmigosMostrar[] arrayAmigosM = new AmigosMostrar[dataTable.Rows.Count];

            panelAmigosMostrar.Controls.Clear();
            for (int i = 0; i < arrayAmigosM.Length; i++)
            {
                arrayAmigosM[i] = new AmigosMostrar();
                arrayAmigosM[i].TopLevel = false;
                arrayAmigosM[i].Dock = DockStyle.Top;
                arrayAmigosM[i].idAmigo = Convert.ToInt32(dataTable.Rows[i][0]);
                arrayAmigosM[i].idUsuarioAmigo = Convert.ToInt32(dataTable.Rows[i][3]);
                if (arrayAmigosM[i].idUsuarioAmigo == resp)
                {
                    arrayAmigosM[i].notichat.Visible = true;
                }
                if (!BaseDeDatos.auxii)
                {
                    arrayAmigosM[i].notichat.Visible = false;
                }
                //Dando valores a controles
                if (dataTable.Rows[i][1] != DBNull.Value)
                {
                    Byte[] myByte = new byte[0];
                    myByte = (Byte[])(dataTable.Rows[i][1]);
                    MemoryStream ms2 = new MemoryStream(myByte);
                    arrayAmigosM[i].pbImgPerfilAmigo.Image = Image.FromStream(ms2);
                }
                arrayAmigosM[i].lNombreAmigo.Text = dataTable.Rows[i][2].ToString();
                // ESTA ELEGIR
                arrayAmigosM[i].nombreAmigo = dataTable.Rows[i][2].ToString();
                panelAmigosMostrar.Controls.Add(arrayAmigosM[i]);
                arrayAmigosM[i].Show();
            }
        }
        private DataTable TodosAmigos()
        {
            DataTable dt = new DataTable();
            SqlConnection conexion = new SqlConnection(BaseDeDatos.EnlaceConexion);
            SqlDataAdapter da = new SqlDataAdapter("SPMostrar_Amigos", conexion);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@IdUsuario", BaseDeDatos.usuarioActual.idUsuario);

            da.Fill(dt);
            return dt;
        }
        private DataTable BuscarAmigos()
        {
            DataTable dt = new DataTable();
            SqlConnection conexion = new SqlConnection(BaseDeDatos.EnlaceConexion);
            SqlDataAdapter da = new SqlDataAdapter("SPMostrar_AmigosBuscar", conexion);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@IdUsuario", BaseDeDatos.usuarioActual.idUsuario);
            da.SelectCommand.Parameters.AddWithValue("@Nombre", tBBuscarAmigo.Text);

            da.Fill(dt);
            return dt;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            buscarNoti();
            MostrarAmigos(TodosAmigos());
        }

        public void MostrarSolicitudes(DataTable dataTable)
        {
            SolicitudesMostrar[] arraySolicitudesM = new SolicitudesMostrar[dataTable.Rows.Count];

            panelAmigosMostrar.Controls.Clear();
            for (int i = 0; i < arraySolicitudesM.Length; i++)
            {
                arraySolicitudesM[i] = new SolicitudesMostrar();
                arraySolicitudesM[i].TopLevel = false;
                arraySolicitudesM[i].Dock = DockStyle.Top;
                arraySolicitudesM[i].idAmigo = Convert.ToInt32(dataTable.Rows[i][0]);
                //Dando valores a controles
                if (dataTable.Rows[i][1] != DBNull.Value)
                {
                    Byte[] myByte = new byte[0];
                    myByte = (Byte[])(dataTable.Rows[i][1]);
                    MemoryStream ms2 = new MemoryStream(myByte);
                    arraySolicitudesM[i].pbImgPerfilSoli.Image = Image.FromStream(ms2);
                }
                arraySolicitudesM[i].lNombreSoli.Text = dataTable.Rows[i][2].ToString();
                panelAmigosMostrar.Controls.Add(arraySolicitudesM[i]);
                arraySolicitudesM[i].Show();
            }
        }
        private DataTable TodasSolicitudes()
        {
            DataTable dt = new DataTable();
            SqlConnection dataConnection = new SqlConnection(BaseDeDatos.EnlaceConexion);
            SqlDataAdapter da = new SqlDataAdapter("SPMostrar_Solicitudes", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@IdUsuario", BaseDeDatos.usuarioActual.idUsuario);

            da.Fill(dt);
            return dt;
        }
    }
}

