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

        private void btnComentar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Boolean permiso = false;
            //string cadena = "Data Source=servidorpanal.database.windows.net;Initial Catalog=BDPanal;User ID=adminPanal;Password=Panal-123";
            string cadena = "Data Source=WINDOWS;Initial Catalog=DBPANAL;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(cadena);
            SqlDataAdapter da = new SqlDataAdapter("SPRegistrar_Comentario", conexion);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@IdUsuario", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@IdPublicacion", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@Comentario", SqlDbType.NVarChar, 1000);
            da.SelectCommand.Parameters.Add("@Respuesta", SqlDbType.Bit);
            da.SelectCommand.Parameters.Add("@Mensaje", SqlDbType.NVarChar, 500);

            da.SelectCommand.Parameters["@IdUsuario"].Value = Program.idUsuarioActual;
            da.SelectCommand.Parameters["@IdPublicacion"].Value = 1;
            da.SelectCommand.Parameters["@Comentario"].Value = txtComentarios.Text;
            da.SelectCommand.Parameters["@Respuesta"].Direction = ParameterDirection.Output;
            da.SelectCommand.Parameters["@Mensaje"].Direction = ParameterDirection.Output;

            conexion.Open();
            da.SelectCommand.ExecuteNonQuery();
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
            conexion.Close();
        }
    }
}
