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
    public partial class CrearPublicacion : Form
    {
        public CrearPublicacion()
        {
            InitializeComponent();
        }

        private void btnPublicar_Click(object sender, EventArgs e)
        {
            
            Boolean permiso = false;
            //string cadena = "Data Source=servidorpanal.database.windows.net;Initial Catalog=BDPanal;User ID=adminPanal;Password=Panal-123";
            //string cadena = "Data Source=servidorpanal.database.windows.net;Initial Catalog=BDPanal;User ID=adminPanal;Password=Panal-123";
            //string cadena = "Data Source=WINDOWS;Initial Catalog=DBPANAL;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(BaseDeDatos.EnlaceConexion);
            SqlDataAdapter da = new SqlDataAdapter("PRegistrarPublicacion", conexion);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@IdUsuario", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 1000);
            da.SelectCommand.Parameters.Add("@FotoPublicacion", SqlDbType.Image);
            da.SelectCommand.Parameters.Add("@Respuesta", SqlDbType.Bit);
            da.SelectCommand.Parameters.Add("@Mensaje", SqlDbType.NVarChar,500);

            da.SelectCommand.Parameters["@IdUsuario"].Value = Program.idUsuarioActual;
            da.SelectCommand.Parameters["@Descripcion"].Value = txtTituloPubl.Text+" // "+txtPubl.Text;
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            
            if (pbImagPubl.Image == null)
            {
                da.SelectCommand.Parameters["@FotoPublicacion"].Value = (object)DBNull.Value;                
            }
            else
            {
                pbImagPubl.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                da.SelectCommand.Parameters["@FotoPublicacion"].Value = ms.GetBuffer();
            }
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
                limpiarPublicacion();
            }
            refrescarDataGrid();
            conexion.Close();

        }

        public void refrescarDataGrid()
        {
            //string cadena = "Data Source=servidorpanal.database.windows.net;Initial Catalog=BDPanal;User ID=adminPanal;Password=Panal-123";
            string cadena = "Data Source=WINDOWS;Initial Catalog=DBPANAL;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(cadena);
            SqlDataAdapter da = new SqlDataAdapter("PConsultarPublicaciones", conexion);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@IdUsuario", SqlDbType.Int);

            da.SelectCommand.Parameters["@IdUsuario"].Value = Program.idUsuarioActual;

            conexion.Open();
            da.SelectCommand.ExecuteNonQuery();
            Program.dt.Clear();
            da.Fill(Program.dt);
            Program.Principal.iniciarDatos();
            conexion.Close();
        }

        private void limpiarPublicacion()
        {
            txtPubl.Text = "";
            txtTituloPubl.Text = "";
            pbImagPubl.Image=null;
            labelRuta.Text = "";
        }

        private void btnAgrImag_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            // image filters
            abrir.Filter = "Image Files(*.jpg;*.jpeg;*.gif;*.bmp)|*.jpg;*.jpeg;*.gif;*.bmp";
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                // display image in picturebox
                pbImagPubl.Image = new Bitmap(abrir.FileName);
                // image file path
                labelRuta.Text=abrir.FileName;
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Program.CrearPubl.Hide();
            Program.Principal.Show();
        }

        private void btnQuitarImag_Click(object sender, EventArgs e)
        {

        }
    }
}
