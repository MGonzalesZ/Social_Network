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
    public partial class FRMBuscarUsuario : Form
    {
        public FRMBuscarUsuario()
        {
            InitializeComponent();
        }

        private void FRMBuscarUsuario_Load(object sender, EventArgs e)
        {
            MostrarUsuarios(TodosUsuarios());
        }
        private void btnBusqUs_Click(object sender, EventArgs e)
        {
            MostrarUsuarios(BuscarUsuarios());
        }

        public void MostrarUsuarios(DataTable dataTable)
        {
            FRMUsuariosMostrar[] arrayUsuariosM = new FRMUsuariosMostrar[dataTable.Rows.Count];

            panelUsuariosMostrar.Controls.Clear();
            for (int i = 0; i < arrayUsuariosM.Length; i++)
            {
                arrayUsuariosM[i] = new FRMUsuariosMostrar();
                arrayUsuariosM[i].TopLevel = false;
                arrayUsuariosM[i].Dock = DockStyle.Top;
                arrayUsuariosM[i].idUsuario = Convert.ToInt32(dataTable.Rows[i][0]);
                //Dando valores a controles
                if (dataTable.Rows[i][1] != DBNull.Value)
                {
                    Byte[] myByte = new byte[0];
                    myByte = (Byte[])(dataTable.Rows[i][1]);
                    MemoryStream ms2 = new MemoryStream(myByte);
                    arrayUsuariosM[i].pbImgPerfilUsu.Image = Image.FromStream(ms2);
                }
                arrayUsuariosM[i].lNombreUsu.Text = dataTable.Rows[i][2].ToString();
                arrayUsuariosM[i].lCorreoUsu.Text = dataTable.Rows[i][3].ToString();
                string casoUsu = "";
                switch (int.Parse(dataTable.Rows[i][4].ToString()))
                {
                    case 0:
                        casoUsu = "YO";
                        break;
                    case 1:
                        casoUsu = "AMIGO(VER PERFIL)";
                        break;
                    case 2:
                        casoUsu = "TE ENVIÓ SOLICITUD";
                        break;
                    case 3:
                        casoUsu = "PENDIENTE";
                        break;
                    case 4:
                        casoUsu = "ENVIAR SOLICITUD";
                        break;
                }
                arrayUsuariosM[i].btnAccionUsu.Text = casoUsu;
                panelUsuariosMostrar.Controls.Add(arrayUsuariosM[i]);
                arrayUsuariosM[i].Show();
            }
        }
        private DataTable TodosUsuarios()
        {
            DataTable dt = new DataTable();
            SqlConnection conexion = new SqlConnection(BaseDeDatos.EnlaceConexion);
            SqlDataAdapter da = new SqlDataAdapter("SPMostrar_Usuarios", conexion);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@IdUsuario", BaseDeDatos.usuarioActual.idUsuario);

            da.Fill(dt);
            return dt;
        }
        private DataTable BuscarUsuarios()
        {
            DataTable dt = new DataTable();
            SqlConnection conexion = new SqlConnection(BaseDeDatos.EnlaceConexion);
            SqlDataAdapter da = new SqlDataAdapter("SPMostrar_UsuariosBuscar", conexion);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@IdUsuario", BaseDeDatos.usuarioActual.idUsuario);
            da.SelectCommand.Parameters.AddWithValue("@Nombre", txtBuscarUsu.Text);

            da.Fill(dt);
            return dt;
        }
    }
}
