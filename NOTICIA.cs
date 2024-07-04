using panalbase;
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

namespace Prueba_de_panel_de_noticias
{
    public partial class NOTICIA : Form
    {
        public int idPublicacion { get; set; }
        public int idUsuarioPubl { get; set; }
        public string descripcionPubl { get; set; }
        public Image fotoPubl { get; set; }

        public NOTICIA()
        {
            InitializeComponent();
            panelDeImagen.BringToFront();
            btnComentario.MouseUp += ClickComentario;
            btnpr.MouseUp += ClickReacciones;
        }
        
        private void ClickComentario(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                metodoParaFormComentario();
            }
            else if (e.Button == MouseButtons.Right)
            {
                panelcom.Visible = true;                
                panelDeImagen.SendToBack();
                //panelSuperiorNoticia.SendToBack();
                panelSuperiorNoticia.Dock = DockStyle.Top;
                //panelInferiorNoticia.SendToBack();
                contreact.SendToBack();
                btnComentario.SendToBack();
                panelcom.BringToFront();
            }
        }

        private void ClickReacciones(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (contreact.Visible == true)
                {
                    contreact.Visible = false;
                    panelDeImagen.BringToFront();
                    panelSuperiorNoticia.BringToFront();
                }
                else
                {
                    contreact.Visible = true;
                    panelDeImagen.SendToBack();
                    panelSuperiorNoticia.SendToBack();
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                Preacciones pnew = new Preacciones();
                pnew.Show();
                BaseDeDatos.idPublCom = idPublicacion;
            }
        }

        private void metodoParaFormComentario()
        {
            BaseDeDatos.idPublCom = idPublicacion;
            Comentarios mostrador = new Comentarios();
            mostrador.mostrarComentario();
            mostrador.ShowDialog();
        }
        private void metodoLlenarFormulario()
        {
            DataTable dt = new DataTable();
            SqlConnection dataConnection = new SqlConnection(BaseDeDatos.EnlaceConexion);
            SqlDataAdapter di = new SqlDataAdapter("SPcantidad_Comentario", dataConnection);
            di.SelectCommand.CommandType = CommandType.StoredProcedure;
            di.SelectCommand.Parameters.Add("@IdPublicacion", SqlDbType.Int);
            di.SelectCommand.Parameters["@IdPublicacion"].Value = idPublicacion.ToString();
            di.Fill(dt);
        }

        private void metodoParaReacciones(int react)
        {
            DataTable dt = new DataTable();
            SqlConnection dataConnection = new SqlConnection(BaseDeDatos.EnlaceConexion);
            SqlDataAdapter da = new SqlDataAdapter("SPRegistrar_Reacciones", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@IdUsuario", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@IdPublicacion", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@IdReaccion", SqlDbType.Int);
            da.SelectCommand.Parameters["@IdUsuario"].Value = BaseDeDatos.usuarioActual.idUsuario;
            da.SelectCommand.Parameters["@IdPublicacion"].Value = idPublicacion.ToString(); 
            da.SelectCommand.Parameters["@IdReaccion"].Value = react;
            da.Fill(dt);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            metodoParaReacciones(1);
            contreact.Visible = false;
            btnpr.Text = "☺";
            btnpr.ForeColor = Color.Black;
            btnpr.BackColor = Color.Silver;
            panelDeImagen.BringToFront();
            panelSuperiorNoticia.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            metodoParaReacciones(2);
            contreact.Visible = false;
            btnpr.Text = "♪";
            btnpr.ForeColor = Color.DarkViolet;
            btnpr.BackColor = Color.Silver;
            panelDeImagen.BringToFront();
            panelSuperiorNoticia.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            metodoParaReacciones(3);
            contreact.Visible = false;
            btnpr.Text = "♥";
            btnpr.ForeColor = Color.Red;
            btnpr.BackColor = Color.Silver;
            panelDeImagen.BringToFront();
            panelSuperiorNoticia.BringToFront();
        }



        private void btncoment_Click(object sender, EventArgs e)
        {
            panelcom.Visible = false;
            panelDeImagen.BringToFront();
            panelSuperiorNoticia.BringToFront();

            //comentar
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
            da.SelectCommand.Parameters["@IdPublicacion"].Value = idPublicacion.ToString(); //BaseDeDatos.idPublCom;
            da.SelectCommand.Parameters["@Comentario"].Value = textBox1.Text;
            da.SelectCommand.Parameters["@Respuesta"].Direction = ParameterDirection.Output;
            da.SelectCommand.Parameters["@Mensaje"].Direction = ParameterDirection.Output;
            conexion.Open();
            da.SelectCommand.ExecuteNonQuery();
            conexion.Close();
            textBox1.Text = " ";
            panelcom.Visible = false;
        }

        private void btncomx_Click(object sender, EventArgs e)
        {
            panelcom.Visible = false;
            panelDeImagen.BringToFront();
            panelSuperiorNoticia.BringToFront();            
            panelInferiorNoticia.Dock = DockStyle.Bottom;
            panelSuperiorNoticia.Dock = DockStyle.Top;
        }

        private void btnEditarPublicacion_Click(object sender, EventArgs e)
        {
            //Program.idPublEditar = Convert.ToInt32(Program.dt.Rows[dgView.CurrentCell.RowIndex][0]);
            //VerPublicacElegida ver11 = new VerPublicacElegida();

            //Program.ver11.LabelPublic.Text = Program.dt.Rows[dgView.CurrentCell.RowIndex][2].ToString();
            //Program.ver11.LabelFecha.Text = Program.dt.Rows[dgView.CurrentCell.RowIndex][3].ToString();
            Program.ver11.LabelPublic.Text = descripcionPubl;
            //System.IO.MemoryStream ms = new System.IO.MemoryStream();
            Program.ver11.pictureBoxPublSel.Image = fotoPubl;
            BaseDeDatos.idPublEditar = idPublicacion;
            //Byte[] myByte = new byte[0];
            //if (IsNull(fotoPubl))
            //{
            //    //myByte = (Byte[])(fotoPubl);
            //    //System.IO.MemoryStream ms2 = new System.IO.MemoryStream(myByte);

            //}

            Program.ver11.ShowDialog();
        }

        private void btnEliminarPublicacion_Click(object sender, EventArgs e)
        {
            Boolean Eliminar = false;
            //Program.idPublEditar = Convert.ToInt32(Program.dt.Rows[dgView.CurrentCell.RowIndex][0]);
            //string cadena = "Data Source=servidorpanal.database.windows.net;Initial Catalog=BDPanal;User ID=adminPanal;Password=Panal-123";

            DialogResult respuesta = new DialogResult();
            respuesta = MessageBox.Show("Desea eliminar la publicación seleccionada?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                //string cadena = "Data Source=servidorpanal.database.windows.net;Initial Catalog=BDPanal;User ID=adminPanal;Password=Panal-123";
                //string cadena = "Data Source=WINDOWS;Initial Catalog=DBPANAL;Integrated Security=True";
                SqlConnection conexion = new SqlConnection(BaseDeDatos.EnlaceConexion);
                SqlDataAdapter da = new SqlDataAdapter("PEliminarLogPublicacion", conexion);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@IdPublicacion", SqlDbType.Int);
                da.SelectCommand.Parameters.Add("@IdUsuario", SqlDbType.Int);
                da.SelectCommand.Parameters.Add("@Resultado", SqlDbType.Bit);
                da.SelectCommand.Parameters.Add("@Mensaje", SqlDbType.NVarChar, 500);

                da.SelectCommand.Parameters["@IdPublicacion"].Value = idPublicacion;
                da.SelectCommand.Parameters["@IdUsuario"].Value = BaseDeDatos.usuarioActual.idUsuario;

                da.SelectCommand.Parameters["@Resultado"].Direction = ParameterDirection.Output;
                da.SelectCommand.Parameters["@Mensaje"].Direction = ParameterDirection.Output;

                conexion.Open();
                da.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Se ha eliminado la publicación", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexion.Close();
            }
            Program.Principal.refrescarGranPanel();
            Program.CrearPubl.refrescarDataGrid();
            //this.Close();
        }

    }
}
