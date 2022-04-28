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
    public partial class Registro : Form
    {
        string sConexion = "Data Source=servidorpanal.database.windows.net;Initial Catalog=BDPanal;User ID=adminPanal;Password=Panal-123";
        public Registro()
        {
            InitializeComponent();
            string ConsultatablaUSUARIO = "select Idpais,NombrePais,CodigoTelfPais from PAIS where Estado = 1";
            SqlDataAdapter da = new SqlDataAdapter(ConsultatablaUSUARIO, sConexion);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewregistro.DataSource = dt;
        }

        private void Bagregarpais_Click(object sender, EventArgs e)
        {
            Pais iniciar = new Pais();
            iniciar.Show();
            this.Close();
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            //string sConexion = "Data Source=servidorpanal.database.windows.net;Initial Catalog=BDPanal;User ID=adminPanal;Password=Panal-123";
            string sConexion = "Data Source=WINDOWS;Initial Catalog=DBPANAL;Integrated Security=True";

            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("modificarUsuario", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

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
            //da.SelectCommand.Parameters.Add("@Respuesta", SqlDbType.Bit);
            //da.SelectCommand.Parameters.Add("@Mensaje", SqlDbType.NVarChar, 500);

            da.SelectCommand.Parameters["@Nombre"].Value = txtNombre.Text;
            da.SelectCommand.Parameters["@Apellidos"].Value = txtApellido.Text;
            da.SelectCommand.Parameters["@NombreUsuario"].Value = txtUsuario.Text;
            da.SelectCommand.Parameters["@Contraseña"].Value = txtContraseña.Text;
            da.SelectCommand.Parameters["@Correo"].Value = txtCorreo.Text;
            da.SelectCommand.Parameters["@Telefono"].Value = txtTelefono.Text;
            da.SelectCommand.Parameters["@Genero"].Value = radioButton1.Checked.ToString();
            da.SelectCommand.Parameters["@FechaNacimiento"].Value = dateTimePicker1.Value;

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            da.SelectCommand.Parameters["@FotoPerfil"].Value = ms.GetBuffer();

            System.IO.MemoryStream ma = new System.IO.MemoryStream();
            pictureBox2.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Jpeg);

            da.SelectCommand.Parameters["@FotoPortada"].Value = ma.GetBuffer();
            //da.SelectCommand.Parameters["@IdUsuarioResultado"].Value = "@IdUsuarioResultado".Length;
            //da.SelectCommand.Parameters["@Respuesta"].Value = "@Respuesta".Length;
            //da.SelectCommand.Parameters["@Mensaje"].Value = "@Mensaje".Length;

            da.Fill(dt);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            //string sConexion = "Data Source=servidorpanal.database.windows.net;Initial Catalog=BDPanal;User ID=adminPanal;Password=Panal-123";
            string sConexion = "Data Source=WINDOWS;Initial Catalog=DBPANAL;Integrated Security=True";

            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("eliminarUsuario", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@Correo", SqlDbType.NVarChar, 50);
            da.SelectCommand.Parameters["@Correo"].Value = txtCorreo.Text;
            da.Fill(dt);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            //string sConexion = "Data Source=servidorpanal.database.windows.net;Initial Catalog=BDPanal;User ID=adminPanal;Password=Panal-123";
            string sConexion = "Data Source=WINDOWS;Initial Catalog=DBPANAL;Integrated Security=True";

            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SPRegistrar_Usuario", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

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
            da.SelectCommand.Parameters.Add("@RoldeUsuario", SqlDbType.NVarChar, 50);
            da.SelectCommand.Parameters.Add("@IdUsuarioResultado", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@Mensaje", SqlDbType.NVarChar, 500);

            da.SelectCommand.Parameters["@Nombre"].Value = txtNombre.Text;
            da.SelectCommand.Parameters["@Apellidos"].Value = txtApellido.Text;
            da.SelectCommand.Parameters["@NombreUsuario"].Value = txtUsuario.Text;
            da.SelectCommand.Parameters["@Contraseña"].Value = txtContraseña.Text;
            da.SelectCommand.Parameters["@Correo"].Value = txtCorreo.Text;
            da.SelectCommand.Parameters["@Telefono"].Value = txtTelefono.Text;
            da.SelectCommand.Parameters["@Genero"].Value = radioButton1.Checked.ToString();
            da.SelectCommand.Parameters["@RoldeUsuario"].Value = txtRol.Text;
            da.SelectCommand.Parameters["@FechaNacimiento"].Value = dateTimePicker1.Value;

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            da.SelectCommand.Parameters["@FotoPerfil"].Value = ms.GetBuffer();

            System.IO.MemoryStream ma = new System.IO.MemoryStream();
            pictureBox2.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Jpeg);

            da.SelectCommand.Parameters["@FotoPortada"].Value = ma.GetBuffer();
            da.SelectCommand.Parameters["@IdUsuarioResultado"].Value = "@IdUsuarioResultado".Length;
            da.SelectCommand.Parameters["@Mensaje"].Value = "@Mensaje".Length;

            da.Fill(dt);
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
            Login log = new Login();
            log.Show();
            this.Close();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
