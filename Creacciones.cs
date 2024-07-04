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
    public partial class Creacciones : Form
    {
        public Creacciones()
        {
            InitializeComponent();
        }

        private void dtReaccion()
        {
            panelReactC.Controls.Clear();
            SqlConnection conexion = new SqlConnection(BaseDeDatos.EnlaceConexion);
            SqlDataAdapter da = new SqlDataAdapter("SPVer_reaccionesC", conexion);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@IdComentario", SqlDbType.Int);
            da.SelectCommand.Parameters["@IdComentario"].Value = BaseDeDatos.idCom;
            conexion.Open();
            da.SelectCommand.ExecuteNonQuery();
            BaseDeDatos.dtrtc.Clear();
            da.Fill(BaseDeDatos.dtrtc);
            conexion.Close();
        }

        private void llenaReaccion()
        {
            dtReaccion();
            ReactComent[] arregloReact = new ReactComent[BaseDeDatos.dtrtc.Rows.Count];
            for (int i = 0; i < arregloReact.Length; i++)
            {
                arregloReact[i] = new ReactComent();
                arregloReact[i].TopLevel = false;
                arregloReact[i].FormBorderStyle = FormBorderStyle.None;
                arregloReact[i].Dock = DockStyle.Top;
                panelReactC.Controls.Add(arregloReact[i]);
                arregloReact[i].Show();
            }
            for (int i = 0; i < arregloReact.Length; i++)
            {
                if (int.Parse(BaseDeDatos.dtrtc.Rows[i][0].ToString()) == 1)
                {
                    arregloReact[i].lblCreact.Text = "☺";
                    arregloReact[i].lblCreact.ForeColor = Color.Black;
                    arregloReact[i].lblCreact.BackColor = Color.Transparent;
                }
                else if (int.Parse(BaseDeDatos.dtrtc.Rows[i][0].ToString()) == 2)
                {
                    arregloReact[i].lblCreact.Text = "♪";
                    arregloReact[i].lblCreact.ForeColor = Color.DarkViolet;
                    arregloReact[i].lblCreact.BackColor = Color.Transparent;
                }
                else
                {
                    arregloReact[i].lblCreact.Text = "♥";
                    arregloReact[i].lblCreact.ForeColor = Color.Red;
                    arregloReact[i].lblCreact.BackColor = Color.Transparent;
                }
                arregloReact[i].lblCnombre.Text = BaseDeDatos.dtrtc.Rows[i][1].ToString();
                Byte[] myByte = new byte[0];
                myByte = (Byte[])(BaseDeDatos.dtrtc.Rows[i][2]);
                System.IO.MemoryStream ms2 = new System.IO.MemoryStream(myByte);
                arregloReact[i].pbCusuario.Image = Image.FromStream(ms2);
            }
        }

        private void btnCerrarC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Creacciones_Load(object sender, EventArgs e)
        {
            llenaReaccion();
        }
    }
}
