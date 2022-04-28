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
    public partial class EditarPubl : Form
    {
        public EditarPubl()
        {
            InitializeComponent();
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            // image filters
            abrir.Filter = "Image Files(*.jpg;*.jpeg;*.gif;*.bmp)|*.jpg;*.jpeg;*.gif;*.bmp";
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                // display image in picturebox
                pbEdicImag.Image = new Bitmap(abrir.FileName);
                // image file path
                lRuta2.Text = abrir.FileName;
            }
        }

        private void btnTerminarEdicion_Click(object sender, EventArgs e)
        {
            Boolean permiso = false;
            //string cadena = "Data Source=servidorpanal.database.windows.net;Initial Catalog=BDPanal;User ID=adminPanal;Password=Panal-123";
            //string cadena = "Data Source=servidorpanal.database.windows.net;Initial Catalog=BDPanal;User ID=adminPanal;Password=Panal-123";
            string cadena = "Data Source=WINDOWS;Initial Catalog=DBPANAL;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(cadena);
            SqlDataAdapter da = new SqlDataAdapter("PEditarPublicacion", conexion);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@IdPublicacion", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@IdUsuario", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 1000);
            da.SelectCommand.Parameters.Add("@FotoPublicacion", SqlDbType.Image);
            da.SelectCommand.Parameters.Add("@Respuesta", SqlDbType.Bit);
            da.SelectCommand.Parameters.Add("@Mensaje", SqlDbType.NVarChar, 500);

            da.SelectCommand.Parameters["@IdPublicacion"].Value = Program.idPublEditar;
            da.SelectCommand.Parameters["@IdUsuario"].Value = Program.idUsuarioActual;
            da.SelectCommand.Parameters["@Descripcion"].Value = txtEditarTexto.Text;
            System.IO.MemoryStream ms = new System.IO.MemoryStream();

            if (pbEdicImag.Image == null)
            {
                da.SelectCommand.Parameters["@FotoPublicacion"].Value = (object)DBNull.Value;
            }
            else
            {
                pbEdicImag.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
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
                
            }
            Program.CrearPubl.refrescarDataGrid();
            conexion.Close();
            Program.ver11.LabelPublic.Text = txtEditarTexto.Text;
            Program.ver11.pictureBoxPublSel.Image = pbEdicImag.Image;
            Program.ver11.LabelFecha.Text = DateTime.Now.ToString();
            limpiar2();
            this.Close();

        }

        private void limpiar2()
        {
            txtEditarTexto.Text = "";
            pbEdicImag.Image = null;
            
        }
    }
}
