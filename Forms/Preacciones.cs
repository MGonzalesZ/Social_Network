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
    public partial class Preacciones : Form
    {
        public Preacciones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtReaccion()
        {
            panelReactM.Controls.Clear();
            SqlConnection conexion = new SqlConnection(BaseDeDatos.EnlaceConexion);
            SqlDataAdapter da = new SqlDataAdapter("SPVer_reaccionesP", conexion);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@IdPublicacion", SqlDbType.Int);
            da.SelectCommand.Parameters["@IdPublicacion"].Value = BaseDeDatos.idPublCom;
            conexion.Open();
            da.SelectCommand.ExecuteNonQuery();
            BaseDeDatos.dtrtp.Clear();
            da.Fill(BaseDeDatos.dtrtp);
            conexion.Close();
        }

        private void llenaReaccion()
        {
            dtReaccion();
            Reactmostrar[] arregloReact = new Reactmostrar[BaseDeDatos.dtrtp.Rows.Count];
            for (int i = 0; i < arregloReact.Length; i++)
            {
                arregloReact[i] = new Reactmostrar();
                arregloReact[i].TopLevel = false;
                arregloReact[i].FormBorderStyle = FormBorderStyle.None;
                arregloReact[i].Dock = DockStyle.Top;
                panelReactM.Controls.Add(arregloReact[i]);
                arregloReact[i].Show();
            }
            for (int i = 0; i < arregloReact.Length; i++)
            {
                if (int.Parse(BaseDeDatos.dtrtp.Rows[i][0].ToString()) == 1)
                {
                    arregloReact[i].lblMreact.Text = "☺";
                    arregloReact[i].lblMreact.ForeColor = Color.Black;
                    arregloReact[i].lblMreact.BackColor = Color.Transparent;
                }
                else if (int.Parse(BaseDeDatos.dtrtp.Rows[i][0].ToString()) == 2)
                {
                    arregloReact[i].lblMreact.Text = "♪";
                    arregloReact[i].lblMreact.ForeColor = Color.DarkViolet;
                    arregloReact[i].lblMreact.BackColor = Color.Transparent;
                }
                else
                {
                    arregloReact[i].lblMreact.Text = "♥";
                    arregloReact[i].lblMreact.ForeColor = Color.Red;
                    arregloReact[i].lblMreact.BackColor = Color.Transparent;
                }
                arregloReact[i].lblMnombre.Text = BaseDeDatos.dtrtp.Rows[i][1].ToString();
                Byte[] myByte = new byte[0];
                myByte = (Byte[])(BaseDeDatos.dtrtp.Rows[i][2]);
                System.IO.MemoryStream ms2 = new System.IO.MemoryStream(myByte);
                arregloReact[i].pbMusuario.Image = Image.FromStream(ms2);
            }
        }

        private void Preacciones_Load(object sender, EventArgs e)
        {
            llenaReaccion();
        }
    }
}
