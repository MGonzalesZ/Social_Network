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
    public partial class EditarUsuario : Form
    {
        public EditarUsuario()
        {
            try
            {
                InitializeComponent();
                SqlConnection dataConnection = new SqlConnection(BaseDeDatos.EnlaceConexion);
                dataConnection.Open();
                SqlCommand cmd = new SqlCommand("select Idpais,NombrePais from PAIS where Estado = 1 order by NombrePais", dataConnection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataConnection.Close();
                DataRow fila = dt.NewRow();
                fila["NombrePais"] = "selecciona un pais";
                dt.Rows.InsertAt(fila, 0);
                cbPaises.ValueMember = "IdPais";
                cbPaises.DisplayMember = "NombrePais";
                cbPaises.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("error al cargar paises");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            //string sConexion = "Data Source=servidorpanal.database.windows.net;Initial Catalog=BDPanal;User ID=adminPanal;Password=Panal-123";
            //string sConexion = "Data Source=WINDOWS;Initial Catalog=DBPANAL;Integrated Security=True";
            SqlConnection dataConnection = new SqlConnection(BaseDeDatos.EnlaceConexion);
            SqlDataAdapter da = new SqlDataAdapter("modificarUsuario", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("@Pais", SqlDbType.NVarChar, 50);
            da.SelectCommand.Parameters.Add("@Nombre", SqlDbType.NVarChar, 50);
            da.SelectCommand.Parameters.Add("@Apellidos", SqlDbType.NVarChar, 50);
            da.SelectCommand.Parameters.Add("@NombreUsuario", SqlDbType.NVarChar, 50);
            da.SelectCommand.Parameters.Add("@Contraseña", SqlDbType.NVarChar, 50);
            da.SelectCommand.Parameters.Add("@Correo", SqlDbType.NVarChar, 50);
            da.SelectCommand.Parameters.Add("@Telefono", SqlDbType.NVarChar, 50);
            da.SelectCommand.Parameters.Add("@Genero", SqlDbType.NVarChar, 50);
            da.SelectCommand.Parameters.Add("@FechaNacimiento", SqlDbType.DateTime);
            da.SelectCommand.Parameters.Add("@FotoPerfil", SqlDbType.Image);
            da.SelectCommand.Parameters.Add("@FotoPortada", SqlDbType.Image);
            //da.SelectCommand.Parameters.Add("@IdUsuarioResultado", SqlDbType.Int);
            //da.SelectCommand.Parameters.Add("@Mensaje", SqlDbType.NVarChar, 500);

            da.SelectCommand.Parameters["@Pais"].Value = cbPaises.Text;
            da.SelectCommand.Parameters["@Nombre"].Value = txtNombre.Text;
            da.SelectCommand.Parameters["@Apellidos"].Value = txtApellido.Text;
            da.SelectCommand.Parameters["@NombreUsuario"].Value = txtUsuario.Text;
            da.SelectCommand.Parameters["@Contraseña"].Value = txtContraseña.Text;
            da.SelectCommand.Parameters["@Correo"].Value = txtCorreo.Text;
            da.SelectCommand.Parameters["@Telefono"].Value = txtTelefono.Text;
            da.SelectCommand.Parameters["@Genero"].Value = cbGenero.SelectedItem.ToString();
            da.SelectCommand.Parameters["@FechaNacimiento"].Value = dateTimePicker1.Value;

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            if (pictureBox1.Image == null)
            {
                da.SelectCommand.Parameters["@FotoPerfil"].Value = (object)DBNull.Value;
            }
            else
            {
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                da.SelectCommand.Parameters["@FotoPerfil"].Value = ms.GetBuffer();
            }

            System.IO.MemoryStream ma = new System.IO.MemoryStream();
            if (pictureBox2.Image == null)
            {
                da.SelectCommand.Parameters["@FotoPortada"].Value = (object)DBNull.Value;
            }
            else
            {
                pictureBox2.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                da.SelectCommand.Parameters["@FotoPortada"].Value = ma.GetBuffer();
            }

            //da.SelectCommand.Parameters["@IdUsuarioResultado"].Value = "@IdUsuarioResultado".Length;
            //da.SelectCommand.Parameters["@Mensaje"].Value = "@Mensaje".Length;

            da.Fill(dt);
            MessageBox.Show("Se editaron los datos correctamente");
        }

        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(BaseDeDatos.EnlaceConexion);
            SqlDataAdapter dl = new SqlDataAdapter("SPVer_Usuario_Alterno", conexion);
            dl.SelectCommand.CommandType = CommandType.StoredProcedure;
            dl.SelectCommand.Parameters.Add("@IdUsuario", SqlDbType.Int);
            dl.SelectCommand.Parameters["@IdUsuario"].Value = BaseDeDatos.usuarioActual.idUsuario;
            conexion.Open();
            dl.SelectCommand.ExecuteNonQuery();
            BaseDeDatos.dtIni.Clear();
            dl.Fill(BaseDeDatos.dtIni);
            //Byte[] mybyte = new byte[0];
            if (!string.IsNullOrEmpty(BaseDeDatos.dtIni.Rows[0][4].ToString()))
            {
                Byte[] mybyte = new byte[0];
                mybyte = (Byte[])(BaseDeDatos.dtIni.Rows[0][4]);
                System.IO.MemoryStream ms = new System.IO.MemoryStream(mybyte);
                pictureBox1.Image = Image.FromStream(ms);
            }
            if (!string.IsNullOrEmpty(BaseDeDatos.dtIni.Rows[0][9].ToString()))
            {
                Byte[] mybyte = new byte[0];
                mybyte = (Byte[])(BaseDeDatos.dtIni.Rows[0][9]);
                System.IO.MemoryStream ms = new System.IO.MemoryStream(mybyte);
                pictureBox2.Image = Image.FromStream(ms);
            }
            //mybyte = (Byte[])(BaseDeDatos.dtIni.Rows[0][4]);
            //System.IO.MemoryStream ms = new System.IO.MemoryStream(mybyte);
            //pictureBox1.Image = Image.FromStream(ms);
            conexion.Close();

            //AQUI ESTA EL MOSTRA DATOS U
            txtNombre.Text = BaseDeDatos.dtIni.Rows[0][0].ToString();
            txtApellido.Text = BaseDeDatos.dtIni.Rows[0][1].ToString();
            txtCorreo.Text = BaseDeDatos.dtIni.Rows[0][2].ToString();
            txtUsuario.Text = BaseDeDatos.dtIni.Rows[0][6].ToString();
            txtContraseña.Text = BaseDeDatos.dtIni.Rows[0][7].ToString();
            txtConfirmarContraseña.Text = BaseDeDatos.dtIni.Rows[0][7].ToString();
            txtTelefono.Text = BaseDeDatos.dtIni.Rows[0][3].ToString();
            cbGenero.Text = BaseDeDatos.dtIni.Rows[0][5].ToString();
            dateTimePicker1.Text = BaseDeDatos.dtIni.Rows[0][8].ToString();
            cbPaises.Text = BaseDeDatos.dtIni.Rows[0][10].ToString();
            //HASTA AQUI
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Image Files(*.jpg;*.jpeg;*.gif;*.bmp;)|*.jpg;*.jpeg;*.gif;*.bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Image Files(*.jpg;*.jpeg;*.gif;*.bmp;)|*.jpg;*.jpeg;*.gif;*.bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = new Bitmap(open.FileName);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            //string sConexion = "Data Source=servidorpanal.database.windows.net;Initial Catalog=BDPanal;User ID=adminPanal;Password=Panal-123";
            //string sConexion = "Data Source=WINDOWS;Initial Catalog=DBPANAL;Integrated Security=True";

            SqlConnection dataConnection = new SqlConnection(BaseDeDatos.EnlaceConexion);
            SqlDataAdapter da = new SqlDataAdapter("eliminarUsuario", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@Correo", SqlDbType.NVarChar, 50);
            da.SelectCommand.Parameters["@Correo"].Value = txtCorreo.Text;
            da.Fill(dt);
        }
    }
}
