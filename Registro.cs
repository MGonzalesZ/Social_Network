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

        public Registro()
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

        private void Bagregarpais_Click(object sender, EventArgs e)
        {
            Pais iniciar = new Pais();
            iniciar.Show();
            this.Close();
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlConnection dataConnection = new SqlConnection(BaseDeDatos.EnlaceConexion);
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
            //da.SelectCommand.Parameters["@Respuesta"].Value = "@Respuesta".Length;
            //da.SelectCommand.Parameters["@Mensaje"].Value = "@Mensaje".Length;

            da.Fill(dt);
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

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            //string sConexion = "Data Source=servidorpanal.database.windows.net;Initial Catalog=BDPanal;User ID=adminPanal;Password=Panal-123";
            //string sConexion = "Data Source=WINDOWS;Initial Catalog=DBPANAL;Integrated Security=True";
            SqlConnection dataConnection = new SqlConnection(BaseDeDatos.EnlaceConexion);
            SqlDataAdapter da = new SqlDataAdapter("SPRegistrar_Usuario", dataConnection);
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
            da.SelectCommand.Parameters.Add("@RoldeUsuario", SqlDbType.NVarChar, 50);
            da.SelectCommand.Parameters.Add("@IdUsuarioResultado", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@Mensaje", SqlDbType.NVarChar, 500);

            da.SelectCommand.Parameters["@Pais"].Value = cbPaises.Text;
            da.SelectCommand.Parameters["@Nombre"].Value = txtNombre.Text;
            da.SelectCommand.Parameters["@Apellidos"].Value = txtApellido.Text;
            da.SelectCommand.Parameters["@NombreUsuario"].Value = txtUsuario.Text;
            da.SelectCommand.Parameters["@Contraseña"].Value = txtContraseña.Text;
            da.SelectCommand.Parameters["@Correo"].Value = txtCorreo.Text;
            da.SelectCommand.Parameters["@Telefono"].Value = txtTelefono.Text;
            da.SelectCommand.Parameters["@Genero"].Value = cbGenero.SelectedItem.ToString();
            da.SelectCommand.Parameters["@RoldeUsuario"].Value = txtRol.Text;
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

            da.SelectCommand.Parameters["@IdUsuarioResultado"].Value = "@IdUsuarioResultado".Length;
            da.SelectCommand.Parameters["@Mensaje"].Value = "@Mensaje".Length;

            string mensajeError = "";
            DataTable dt2 = new DataTable();
            SqlConnection conexion = new SqlConnection(BaseDeDatos.EnlaceConexion);
            SqlDataAdapter da2 = new SqlDataAdapter("SPValidar_NombreUsuario", conexion);
            da2.SelectCommand.CommandType = CommandType.StoredProcedure;
            da2.SelectCommand.Parameters.AddWithValue("@NombreUsuario", txtUsuario.Text);
            da2.Fill(dt2);
            if (Int32.Parse(dt2.Rows.Count.ToString()) > 0)
            {
                mensajeError = "El NOMBRE DE USUARIO ya esta en uso!, prueba otro nombre\n";
            }



            DataTable dt3 = new DataTable();
            SqlConnection conexion2 = new SqlConnection(BaseDeDatos.EnlaceConexion);
            SqlDataAdapter da3 = new SqlDataAdapter("SPValidar_Correo", conexion2);
            da3.SelectCommand.CommandType = CommandType.StoredProcedure;
            da3.SelectCommand.Parameters.AddWithValue("@Correo", txtCorreo.Text);
            da3.Fill(dt3);
            if (Int32.Parse(dt3.Rows.Count.ToString()) > 0)
            {
                mensajeError += "El CORREO ya esta en uso!, prueba otro correo";
            }
            if (mensajeError == "")
            {
                da.Fill(dt);
                MessageBox.Show("La cuenta se creo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show(mensajeError);

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

        private void cargarPais(object sender, EventArgs e)
        {
            /*
            cbPaises.Items.Add("Bolivia");
            cbPaises.Items.Add("Peru");
            cbPaises.Items.Add("Chile");
            cbPaises.Items.Add("Brasil");
            */
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloLetras(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloLetras(e);
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.NoEspacios(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
        }

        private void ValidarVacio()
        {
            if ((txtNombre.Text == "" || txtApellido.Text == "" || txtCorreo.Text == "" || txtUsuario.Text == "" || txtContraseña.Text == "" || txtConfirmarContraseña.Text == "" || txtTelefono.Text == "" || cbGenero.Text == "" || cbPaises.Text == "") || (txtContraseña.Text != txtConfirmarContraseña.Text))
            {
                button3.Enabled = false;
            }
            else
            {
                button3.Enabled = true;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarVacio();
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            ValidarVacio();
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            ValidarVacio();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            ValidarVacio();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            ValidarVacio();
        }

        private void txtConfirmarContraseña_TextChanged(object sender, EventArgs e)
        {
            ValidarVacio();
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            ValidarVacio();
        }

        private void cbGenero_TextChanged(object sender, EventArgs e)
        {
            ValidarVacio();
        }

        private void cbPaises_TextChanged(object sender, EventArgs e)
        {
            ValidarVacio();
        }

        private void txtNombre_Validated(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                errorProvider1.SetError(txtNombre, "Introduce Tu Nombre");
                txtNombre.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtApellido_Validated(object sender, EventArgs e)
        {
            if (txtApellido.Text.Trim() == "")
            {
                errorProvider1.SetError(txtApellido, "Introduce Tu Apellido");
                txtApellido.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtCorreo_Validated(object sender, EventArgs e)
        {
            if (txtCorreo.Text.Trim() == "")
            {
                errorProvider1.SetError(txtCorreo, "Introduce Tu Correo");
                txtCorreo.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtUsuario_Validated(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() == "")
            {
                errorProvider1.SetError(txtUsuario, "Introduce Tu Usuario");
                txtUsuario.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtContraseña_Validated(object sender, EventArgs e)
        {
            if (txtContraseña.Text.Trim() == "")
            {
                errorProvider1.SetError(txtContraseña, "Introduce Tu Contraseña");
                txtContraseña.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtConfirmarContraseña_Validated(object sender, EventArgs e)
        {
            if (txtConfirmarContraseña.Text.Trim() == "")
            {
                errorProvider1.SetError(txtConfirmarContraseña, "Introduce Tu Contraseña otra vez");
                txtConfirmarContraseña.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtTelefono_Validated(object sender, EventArgs e)
        {
            if (txtTelefono.Text.Trim() == "")
            {
                errorProvider1.SetError(txtTelefono, "Introduce Tu Telefono");
                txtTelefono.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}