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
    public partial class AmigosMostrar : Form
    {
        public int idAmigo { get; set; }
        public int idUsuarioAmigo { get; set;}
        public string nombreAmigo { get; set; }
        //public static int puertoAmigo = 1;
        public AmigosMostrar()
        {
            InitializeComponent();
            //puertoAmigo++;
        }

        private void bntEliminarAmigo_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show($"¿Deseas eliminar a {lNombreAmigo.Text} de tus amigos?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SPEliminar_Amigos();
            }
        }

        private void SPEliminar_Amigos()
        {
            SqlConnection conexion = new SqlConnection(BaseDeDatos.EnlaceConexion);
            conexion.Open();
            SqlCommand comando = new SqlCommand("SPEliminar_Amigos", conexion);
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdAmigos", idAmigo);

            comando.ExecuteNonQuery();
            conexion.Close();
            this.Close();
        }

        private void BtnIrChat_Click(object sender, EventArgs e)
        {
            BaseDeDatos.usuarioCHAT.idUsuario = idUsuarioAmigo;
            BaseDeDatos.usuarioCHAT.idPais = 1;
            BaseDeDatos.usuarioCHAT.nombre = nombreAmigo;
            BaseDeDatos.usuarioCHAT.apellidos = "Carlson";
            BaseDeDatos.usuarioCHAT.nombreUsuario = "Carl";
            BaseDeDatos.usuarioCHAT.contraseniaUsuario = "123";
            CHAT nuevoChat = new CHAT(BaseDeDatos.usuarioActual, BaseDeDatos.usuarioCHAT);
            nuevoChat.Show();
            BaseDeDatos.soli = false;
            BaseDeDatos.auxii = false;
        }
    }
}
