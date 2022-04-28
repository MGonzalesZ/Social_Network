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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            int permiso = 0;
            //string cadena = "Data Source=servidorpanal.database.windows.net;Initial Catalog=BDPanal;User ID=adminPanal;Password=Panal-123";
            //string cadena = "Data Source=servidorpanal.database.windows.net;Initial Catalog=BDPanal;User ID=adminPanal;Password=Panal-123";
            string cadena = "Data Source=WINDOWS;Initial Catalog=DBPANAL;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(cadena);
            SqlDataAdapter da = new SqlDataAdapter("PLoginUsuario",conexion);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@nombreUsuario",SqlDbType.NVarChar,50);
            da.SelectCommand.Parameters.Add("@password",SqlDbType.NVarChar,50);
            da.SelectCommand.Parameters.Add("@salida", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@idUsuario", SqlDbType.Int);

            da.SelectCommand.Parameters["@nombreUsuario"].Value=txtUsuario.Text.Trim();
            da.SelectCommand.Parameters["@password"].Value=txtContrasenia.Text;
            da.SelectCommand.Parameters["@salida"].Direction = ParameterDirection.Output;
            da.SelectCommand.Parameters["@idUsuario"].Direction = ParameterDirection.Output;

            conexion.Open();
            da.SelectCommand.ExecuteNonQuery();
            permiso = int.Parse(Convert.ToString(da.SelectCommand.Parameters["@salida"].Value));
            if (permiso == 0)
            {
                MessageBox.Show("Usuario o Contraseña Incorrectos!!!","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if(permiso==1)
            {
                Program.idUsuarioActual = int.Parse(Convert.ToString(da.SelectCommand.Parameters["@idUsuario"].Value));
                MessageBox.Show("Bienvenido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.Ingreso.Close();
                Program.Principal.Show();
                Program.CrearPubl.refrescarDataGrid();
            }
            conexion.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registro res = new Registro();
            res.Show();
        }
    }
}
