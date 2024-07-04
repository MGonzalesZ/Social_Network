using Prueba_de_panel_de_noticias;
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

    public partial class PaginaPrincipal : Form
    {
        int numero = 1;
        int num2 = 1;
        string respuesta, respuesta2, tipo, tipo2;
        int res1, res2, tp1, tp2;
        private int check = 0;
        private int check2 = 0;
        public PaginaPrincipal()
        {
            InitializeComponent();
            //refrescarDataGrid();
            
            //string sConexion = "Data Source=servidorpanal.database.windows.net;Initial Catalog=BDPanal;User ID=adminPanal;Password=Panal-123";
            //string sConexion = "Data Source=WINDOWS;Initial Catalog=DBPANAL;Integrated Security=True";
            var consulta1 = "select IdReaccion, TipoReaccion from Reaccion";
            SqlConnection conn = new SqlConnection(BaseDeDatos.EnlaceConexion);
            var adaptador1 = new SqlDataAdapter(consulta1, conn);
            var commandBuilder1 = new SqlCommandBuilder(adaptador1);
            var de = new DataSet();
            adaptador1.Fill(de);
        }

        public void consultNoti()
        {
            SqlConnection conexion = new SqlConnection(BaseDeDatos.EnlaceConexion);
            SqlCommand comando = new SqlCommand("SPConsultaNoti", conexion);
            comando.Parameters.Add("@IdUsuario", SqlDbType.Int);
            comando.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
            comando.Parameters.Add("tipo", SqlDbType.Int).Direction = ParameterDirection.Output;
            comando.Parameters["@IdUsuario"].Value = BaseDeDatos.usuarioActual.idUsuario;
            comando.CommandType = CommandType.StoredProcedure;

            conexion.Open();
            comando.ExecuteNonQuery();
            respuesta = (comando.Parameters["resultado"].Value).ToString();
            res1 = int.Parse(respuesta);
            //label2.Text = (comando.Parameters["tipo"].Value).ToString();
            if ((comando.Parameters["tipo"].Value) != DBNull.Value)
            {
                tipo = (comando.Parameters["tipo"].Value).ToString();
                tp1 = int.Parse(tipo);
            }
            conexion.Close();
        }

        public void comprobarNoti()
        {
            DataTable dt = new DataTable();
            SqlConnection dataConnection = new SqlConnection(BaseDeDatos.EnlaceConexion);
            SqlDataAdapter da = new SqlDataAdapter("SPMostrar_Solicitudes", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@IdUsuario", BaseDeDatos.usuarioActual.idUsuario);

            da.Fill(dt);

            SolicitudesMostrar[] arraySolicitudesM = new SolicitudesMostrar[dt.Rows.Count];
            //array numero de notificaciones label1.Text = arraySolicitudesM.Length.ToString();
            if (arraySolicitudesM.Length != 0)
            {
                noti.Visible = true;
            }
            if(!BaseDeDatos.auxii)
            {
                if (arraySolicitudesM.Length == 0)
                {
                    noti.Visible = false;
                }
            }

            SqlConnection conexion = new SqlConnection(BaseDeDatos.EnlaceConexion);
            SqlCommand comando2 = new SqlCommand("SPConsultaNoti", conexion);
            comando2.Parameters.Add("@IdUsuario", SqlDbType.Int);
            comando2.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
            comando2.Parameters.Add("tipo", SqlDbType.Int).Direction = ParameterDirection.Output;
            comando2.Parameters["@IdUsuario"].Value = BaseDeDatos.usuarioActual.idUsuario;
            comando2.CommandType = CommandType.StoredProcedure;

            conexion.Open();
            comando2.ExecuteNonQuery();
            respuesta2 = (comando2.Parameters["resultado"].Value).ToString();
            res2 = int.Parse(respuesta2);
            if ((comando2.Parameters["tipo"].Value) != DBNull.Value)
            {
                tipo2 = (comando2.Parameters["tipo"].Value).ToString();
                tp2 = int.Parse(tipo2);
            }
            conexion.Close();


            if (res2 > res1)
            {
                noti.Visible = true;
                res1 = res2;
                if (tp2 == 1)
                {
                    BaseDeDatos.soli = true;
                }
                if (tp2 == 2)
                {
                    BaseDeDatos.chatt = true;
                    BaseDeDatos.auxii = true;
                }
            }
        }

        private void btnPublicar_Click(object sender, EventArgs e)
        {
            Program.Principal.Hide();
            Program.CrearPubl.Show();
            Program.CrearPubl.Refresh();
        }

        private void btnVerPubl_Click(object sender, EventArgs e)
        {
            Program.idPublEditar = Convert.ToInt32(Program.dt.Rows[dgView.CurrentCell.RowIndex][0]);
            //VerPublicacElegida ver11 = new VerPublicacElegida();
            Program.ver11.LabelPublic.Text=Program.dt.Rows[dgView.CurrentCell.RowIndex][2].ToString();
            Program.ver11.LabelFecha.Text = Program.dt.Rows[dgView.CurrentCell.RowIndex][3].ToString();
            //System.IO.MemoryStream ms = new System.IO.MemoryStream();
            Byte[] myByte = new byte[0];
            if (Program.dt.Rows[dgView.CurrentCell.RowIndex][4]!=DBNull.Value)
            {
                myByte = (Byte[])(Program.dt.Rows[dgView.CurrentCell.RowIndex][4]);
                System.IO.MemoryStream ms2 = new System.IO.MemoryStream(myByte);
                Program.ver11.pictureBoxPublSel.Image = Image.FromStream(ms2);
            }

            Program.ver11.ShowDialog();
        }

        private void btnEliminarPubl_Click(object sender, EventArgs e)
        {
            Boolean Eliminar = false;
            Program.idPublEditar = Convert.ToInt32(Program.dt.Rows[dgView.CurrentCell.RowIndex][0]);
            //string cadena = "Data Source=servidorpanal.database.windows.net;Initial Catalog=BDPanal;User ID=adminPanal;Password=Panal-123";
            
            DialogResult respuesta=new DialogResult();
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

                da.SelectCommand.Parameters["@IdPublicacion"].Value = Program.idPublEditar;
                da.SelectCommand.Parameters["@IdUsuario"].Value = BaseDeDatos.usuarioActual.idUsuario;

                da.SelectCommand.Parameters["@Resultado"].Direction = ParameterDirection.Output;
                da.SelectCommand.Parameters["@Mensaje"].Direction = ParameterDirection.Output;

                conexion.Open();
                da.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Se ha eliminado la publicación", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexion.Close();
            }
            
            Program.CrearPubl.refrescarDataGrid();
            //this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Amigos amigos = new Amigos();
            amigos.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            check = e.RowIndex;
            numero = Convert.ToInt32(this.dgView.Rows[check].Cells[0].Value);
        }
        private void DGreacciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            check2 = e.RowIndex;
            num2 = Convert.ToInt32(this.dgView.Rows[check2].Cells[0].Value);
        }

        //registrar reacciones
        private void button3_Click(object sender, EventArgs e)
        {

        }

        //abrir la ventana reaccion
        private void button1_Click(object sender, EventArgs e)
        {
            React rect = new React();
            rect.Show();
            this.Close();
        }

        //modificar
        private void DGreaccion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            check2 = e.RowIndex;
            num2 = Convert.ToInt32(dgView.Rows[check2].Cells[0].Value);
            */
        }
        private void button5_Click(object sender, EventArgs e)
        {
        }

        public void refrescarGranPanel()
        {
            SqlConnection conexion = new SqlConnection(BaseDeDatos.EnlaceConexion);
            try
            {
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
                //mybyte = (Byte[])(BaseDeDatos.dtIni.Rows[0][4]);
                //System.IO.MemoryStream ms = new System.IO.MemoryStream(mybyte);
                //pictureBox1.Image = Image.FromStream(ms);
                conexion.Close();
                string definicionGenero;
                if (BaseDeDatos.dtIni.Rows[0][5].ToString() == "Masculino")
                {
                    definicionGenero = "o";
                }
                else if (BaseDeDatos.dtIni.Rows[0][5].ToString() == "False")
                {
                    definicionGenero = "a";
                }
                else
                {
                    definicionGenero = "@";
                }
                //AQUI ESTA EL MOSTRA DATOS U
                lblnombreuu.Text = "Bienvenid" + definicionGenero + "\n" + BaseDeDatos.dtIni.Rows[0][0].ToString() + "\n" + BaseDeDatos.dtIni.Rows[0][1].ToString() + "\n" + BaseDeDatos.dtIni.Rows[0][2].ToString() +
                "\n" + BaseDeDatos.dtIni.Rows[0][3].ToString();
                //HASTA AQUI
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conexion.Close();
            }
            //
            PanelPublicaciones.Controls.Clear();
            SqlDataAdapter da = new SqlDataAdapter("PConsultarPublicaciones22", conexion);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@IdUsuario", SqlDbType.Int);

            da.SelectCommand.Parameters["@IdUsuario"].Value = BaseDeDatos.usuarioActual.idUsuario;

            conexion.Open();
            da.SelectCommand.ExecuteNonQuery();
            BaseDeDatos.dtNotic.Clear();
            da.Fill(BaseDeDatos.dtNotic);
            conexion.Close();

            NOTICIA[] arregloNot = new NOTICIA[BaseDeDatos.dtNotic.Rows.Count];

            for (int i = 0; i < arregloNot.Length; i++)
            {
                //generado de los paneles NOTICIA
                arregloNot[i] = new NOTICIA();
                arregloNot[i].TopLevel = false;
                arregloNot[i].FormBorderStyle = FormBorderStyle.None;
                arregloNot[i].BackColor = Color.PaleGoldenrod;
                arregloNot[i].Dock = DockStyle.Top;
                //arregloNot[i].Dock = DockStyle.Bottom;
                PanelPublicaciones.Controls.Add(arregloNot[i]);
                arregloNot[i].Show();
            }
            for (int i = 0; i < arregloNot.Length; i++)
            {
                arregloNot[i].LabelAutor.Text = BaseDeDatos.dtNotic.Rows[i][5].ToString()+" publicó el: "
                                        + Convert.ToDateTime(BaseDeDatos.dtNotic.Rows[i][3]).AddHours(3).ToString();
                arregloNot[i].LabelDescripcion.Text = BaseDeDatos.dtNotic.Rows[i][2].ToString();
                arregloNot[i].idPublicacion = int.Parse(BaseDeDatos.dtNotic.Rows[i][0].ToString());
                arregloNot[i].idUsuarioPubl = int.Parse(BaseDeDatos.dtNotic.Rows[i][1].ToString());
                arregloNot[i].descripcionPubl = BaseDeDatos.dtNotic.Rows[i][2].ToString();
                arregloNot[i].lblcomususn.Text = "Comentaras como: " + BaseDeDatos.usuarioActual.nombreUsuario.ToString();
                Byte[] myByte = new byte[0];
                if (BaseDeDatos.dtNotic.Rows[i][4] == DBNull.Value)
                {
                    //arregloNot[i].panelDeImagen.Hide();
                    //
                    arregloNot[i].pbNoticia.Hide();
                    arregloNot[i].panelDeImagen.Height = 0;
                    arregloNot[i].panelSuperiorNoticia.Dock = DockStyle.Top;
                    //arregloNot[i].panelcom.Dock = DockStyle.Top;
                    arregloNot[i].panelInferiorNoticia.Dock = DockStyle.Top;
                    //arregloNot[i].panelDeImagen.AutoSize = true;
                    //arregloNot[0].Left += 10;
                    arregloNot[i].Size = new Size(0, 0);
                    arregloNot[i].AutoSize = true;
                }
                else
                {
                    myByte = (Byte[])(BaseDeDatos.dtNotic.Rows[i][4]);
                    System.IO.MemoryStream ms2 = new System.IO.MemoryStream(myByte);
                    arregloNot[i].pbNoticia.Image = Image.FromStream(ms2);
                    arregloNot[i].fotoPubl = Image.FromStream(ms2);
                }
                if (arregloNot[i].idUsuarioPubl != BaseDeDatos.usuarioActual.idUsuario)
                {
                    arregloNot[i].btnEditarPublicacion.Visible = false;
                    arregloNot[i].btnEliminarPublicacion.Visible = false;
                }
                // PARA LA FOTO DE PERFIL
                Byte[] myBytePerfil = new byte[0];
                if (BaseDeDatos.dtNotic.Rows[i][8] != DBNull.Value)
                {
                    myBytePerfil = (Byte[])(BaseDeDatos.dtNotic.Rows[i][8]);
                    System.IO.MemoryStream ms3 = new System.IO.MemoryStream(myBytePerfil);
                    arregloNot[i].pbPerfilPubl.Image = Image.FromStream(ms3);
                    //arregloNot[i].fotoPubl = Image.FromStream(ms3);

                    //arregloNot[i].panelDeImagen.Hide();
                    //arregloNot[i].panelDeImagen.Height = 0;
                    //arregloNot[i].panelInferiorNoticia.Dock = DockStyle.Top;
                    ////arregloNot[0].Left += 10;
                    //arregloNot[i].Size = new Size(0, 0);
                    //arregloNot[i].AutoSize = true;
                }
                //parte prueba rara

                SqlDataAdapter de = new SqlDataAdapter("SPVer_reacciones", conexion);
                de.SelectCommand.CommandType = CommandType.StoredProcedure;
                de.SelectCommand.Parameters.Add("@IdUsuario", SqlDbType.Int);
                de.SelectCommand.Parameters.Add("@IdPublicacion", SqlDbType.Int);
                de.SelectCommand.Parameters["@IdUsuario"].Value = BaseDeDatos.usuarioActual.idUsuario;
                de.SelectCommand.Parameters["@IdPublicacion"].Value = arregloNot[i].idPublicacion;
                conexion.Open();
                de.SelectCommand.ExecuteNonQuery();
                BaseDeDatos.dtReact.Clear();
                de.Fill(BaseDeDatos.dtReact);
                conexion.Close();

                if (int.Parse(BaseDeDatos.dtReact.Rows[0][0].ToString()) == 0)
                {
                    arregloNot[i].btnpr.Text = "☺";
                    arregloNot[i].btnpr.ForeColor = Color.Black;
                    arregloNot[i].btnpr.BackColor = Color.White;
                }
                    if (int.Parse(BaseDeDatos.dtReact.Rows[0][0].ToString()) == 1)
                    {
                        arregloNot[i].btnpr.Text = "☺";
                        arregloNot[i].btnpr.ForeColor = Color.Black;
                        arregloNot[i].btnpr.BackColor = Color.Silver;
                    }
                    if (int.Parse(BaseDeDatos.dtReact.Rows[0][0].ToString()) == 2)
                    {
                        arregloNot[i].btnpr.Text = "♪";
                        arregloNot[i].btnpr.ForeColor = Color.DarkViolet;
                        arregloNot[i].btnpr.BackColor = Color.Silver;
                    }
                    if (int.Parse(BaseDeDatos.dtReact.Rows[0][0].ToString()) == 3)
                    {
                        arregloNot[i].btnpr.Text = "♥";
                        arregloNot[i].btnpr.ForeColor = Color.Red;
                        arregloNot[i].btnpr.BackColor = Color.Silver;
                    }
            }
            PanelPublicaciones.AutoScroll = true;
            consultNoti();
            //arregloNot[0].panelDeImagen.Hide();
            //arregloNot[0].panelDeImagen.Height = 0;            
            //arregloNot[0].panelInferiorNoticia.Dock=DockStyle.Top;


            //arregloNot[0].panelInferiorNoticia.Anchor=AnchorStyles.Bottom;
            //arregloNot[0].panelInferiorNoticia.Top-=200;


            //arregloNot[0].Left += 10;
            //arregloNot[0].Size = new Size(0, 0);
            //arregloNot[0].AutoSize = true;


            //arregloNot[0].panelInferiorNoticia.Dock = DockStyle.None;
            //arregloNot[0].panelInferiorNoticia.Left +=20;
            //arregloNot[0].panelInferiorNoticia.Left += 50;
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            FRMBuscarUsuario BuscarUs = new FRMBuscarUsuario();
            BuscarUs.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Program.Principal.refrescarGranPanel();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            comprobarNoti();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {

            //Login log = new Login();
            //log.Show();
           
            cerrarSesion();
           
        }

        private void cerrarSesion()
        {
            BaseDeDatos.usuarioActual.borrarDatos();
            this.Hide();
            BaseDeDatos.dtNotic.Clear();
            BaseDeDatos.dtReact.Clear();
            BaseDeDatos.dtComnt.Clear();
            BaseDeDatos.dtbqa.Clear();
            BaseDeDatos.dtLogin.Clear();

            
            BaseDeDatos.Ingreso.txtUsuario.Clear();
            BaseDeDatos.Ingreso.txtContrasenia.Clear();
            BaseDeDatos.Ingreso.Show();
            //Application.Exit();
            //Application.Restart();
        }

        private void iniciarDatos(object sender, EventArgs e)
        {
            Program.Principal.refrescarGranPanel();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarUsuario ed = new EditarUsuario();
            ed.Show();
        }

        private void btnAccesoChat_Click(object sender, EventArgs e)
        {
            frmElegirChat listaChats= new frmElegirChat();
            listaChats.Show();
            this.Hide();
        }

        private void PaginaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Program.Principal.Hide();
            //cerrarSesion();
            Application.Exit();
            //Application.Run(BaseDeDatos.Ingreso);
        }
    }
}


