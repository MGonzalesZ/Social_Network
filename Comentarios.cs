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
    public partial class Comentarios : Form
    {
        public Comentarios()
        {
            InitializeComponent();

        }

        private void verComentario()
        {
            panel1.Controls.Clear();
            SqlConnection conexion = new SqlConnection(BaseDeDatos.EnlaceConexion);
            SqlDataAdapter da = new SqlDataAdapter("SPver_Comentario", conexion);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@IdPublicacion", SqlDbType.Int);

            da.SelectCommand.Parameters["@IdPublicacion"].Value = BaseDeDatos.idPublCom;

            conexion.Open();
            da.SelectCommand.ExecuteNonQuery();
            BaseDeDatos.dtComnt.Clear();
            da.Fill(BaseDeDatos.dtComnt);
            conexion.Close();
        }
        private void actualizarComentario()
        {
            verComentario();
            Comentario[] arregloCom = new Comentario[BaseDeDatos.dtComnt.Rows.Count];

            for (int i = 0; i < arregloCom.Length; i++)
            {
                arregloCom[i] = new Comentario();
                arregloCom[i].TopLevel = false;
                arregloCom[i].FormBorderStyle = FormBorderStyle.None;
                arregloCom[i].BackColor = Color.White;
                arregloCom[i].Dock = DockStyle.Top;
                panel1.Controls.Add(arregloCom[i]);
                arregloCom[i].Show();
            }
            panel1.AutoScroll = true;
            for (int i = 0; i < arregloCom.Length; i++)
            {
                arregloCom[i].lblnusuarioc.Text = BaseDeDatos.dtComnt.Rows[i][2].ToString();
                arregloCom[i].lblcomentar.Text = BaseDeDatos.dtComnt.Rows[i][3].ToString();
                arregloCom[i].lblfecha.Text = BaseDeDatos.dtComnt.Rows[i][4].ToString();
                arregloCom[i].lblidcom.Text = BaseDeDatos.dtComnt.Rows[i][5].ToString();

                SqlConnection conexion = new SqlConnection(BaseDeDatos.EnlaceConexion);
                SqlDataAdapter de = new SqlDataAdapter("SPVer_reaccionesCom", conexion);
                de.SelectCommand.CommandType = CommandType.StoredProcedure;
                de.SelectCommand.Parameters.Add("@IdUsuario", SqlDbType.Int);
                de.SelectCommand.Parameters.Add("@IdComentario", SqlDbType.Int);
                de.SelectCommand.Parameters["@IdUsuario"].Value = BaseDeDatos.usuarioActual.idUsuario;
                de.SelectCommand.Parameters["@IdComentario"].Value = BaseDeDatos.dtComnt.Rows[i][5].ToString();
                conexion.Open();
                de.SelectCommand.ExecuteNonQuery();
                BaseDeDatos.dtReactCom.Clear();
                de.Fill(BaseDeDatos.dtReactCom);
                conexion.Close();

                if (int.Parse(BaseDeDatos.dtReactCom.Rows[0][0].ToString()) == 0)
                {
                    arregloCom[i].btnreactcom.Text = "☺";
                    arregloCom[i].btnreactcom.ForeColor = Color.Black;
                    arregloCom[i].btnreactcom.BackColor = Color.White;
                }
                if (int.Parse(BaseDeDatos.dtReactCom.Rows[0][0].ToString()) == 1)
                {
                    arregloCom[i].btnreactcom.Text = "☺";
                    arregloCom[i].btnreactcom.ForeColor = Color.Black;
                    arregloCom[i].btnreactcom.BackColor = Color.Silver;
                }
                if (int.Parse(BaseDeDatos.dtReactCom.Rows[0][0].ToString()) == 2)
                {
                    arregloCom[i].btnreactcom.Text = "♪";
                    arregloCom[i].btnreactcom.ForeColor = Color.DarkViolet;
                    arregloCom[i].btnreactcom.BackColor = Color.Silver;
                }
                if (int.Parse(BaseDeDatos.dtReactCom.Rows[0][0].ToString()) == 3)
                {
                    arregloCom[i].btnreactcom.Text = "♥";
                    arregloCom[i].btnreactcom.ForeColor = Color.Red;
                    arregloCom[i].btnreactcom.BackColor = Color.Silver;
                }
            }
        }

        public void mostrarComentario()
        {
            actualizarComentario();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Boolean permiso = false;
            SqlConnection conexion = new SqlConnection(BaseDeDatos.EnlaceConexion);
            SqlDataAdapter da = new SqlDataAdapter("SPRegistrar_Comentario", conexion);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@IdUsuario", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@IdPublicacion", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@Comentario", SqlDbType.NVarChar, 1000);
            da.SelectCommand.Parameters.Add("@Respuesta", SqlDbType.Bit);
            da.SelectCommand.Parameters.Add("@Mensaje", SqlDbType.NVarChar, 500);
            da.SelectCommand.Parameters["@IdUsuario"].Value = BaseDeDatos.usuarioActual.idUsuario;
            da.SelectCommand.Parameters["@IdPublicacion"].Value = BaseDeDatos.idPublCom;
            da.SelectCommand.Parameters["@Comentario"].Value = txtComentario.Text;
            da.SelectCommand.Parameters["@Respuesta"].Direction = ParameterDirection.Output;
            da.SelectCommand.Parameters["@Mensaje"].Direction = ParameterDirection.Output;
            conexion.Open();
            da.SelectCommand.ExecuteNonQuery();
            /*
            permiso = Boolean.Parse(Convert.ToString(da.SelectCommand.Parameters["@Respuesta"].Value));
            if (permiso == false)
            {
                MessageBox.Show("El comentario no pudo ser almacenado!!!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (permiso == true)
            {
                MessageBox.Show("Comentario guardado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Program.Ingreso.Close();
                //Program.Principal.Show();
            }
            */
            conexion.Close();

            txtComentario.Text = " ";
            actualizarComentario();
        }
    }
}
