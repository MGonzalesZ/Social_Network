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
    public partial class Comentario : Form
    {
        int num;
        public Comentario()
        {
            InitializeComponent();
            btnreactcom.MouseUp += ClickReaccionesC;
        }
        private void metodoParaReaccionesCom(int react)
        {
            num = int.Parse(lblidcom.Text);
            DataTable dt = new DataTable();
            SqlConnection dataConnection = new SqlConnection(BaseDeDatos.EnlaceConexion);
            SqlDataAdapter da = new SqlDataAdapter("SPRegistrar_ReaccionesCom", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@IdUsuario", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@IdComentario", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@IdReaccion", SqlDbType.Int);
            da.SelectCommand.Parameters["@IdUsuario"].Value = BaseDeDatos.usuarioActual.idUsuario;
            da.SelectCommand.Parameters["@IdComentario"].Value = num;
            da.SelectCommand.Parameters["@IdReaccion"].Value = react;
            da.Fill(dt);
        }

        private void ClickReaccionesC(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pnlreactcom.Visible = true;
            }
            if (e.Button == MouseButtons.Right)
            {
                Creacciones pnew = new Creacciones();
                pnew.Show();
                BaseDeDatos.idCom = num;
            }
        }

        private void btncoms_Click(object sender, EventArgs e)
        {
            metodoParaReaccionesCom(1);
            pnlreactcom.Visible=false;
            btnreactcom.Text = "☺";
            btnreactcom.BackColor= Color.Silver;
            btnreactcom.ForeColor = Color.Black;
        }

        private void btncomn_Click(object sender, EventArgs e)
        {
            metodoParaReaccionesCom(2);
            pnlreactcom.Visible = false;
            btnreactcom.Text = "♪";
            btnreactcom.BackColor = Color.Silver;
            btnreactcom.ForeColor = Color.DarkViolet;
        }

        private void btncomc_Click(object sender, EventArgs e)
        {
            metodoParaReaccionesCom(3);
            pnlreactcom.Visible = false;
            btnreactcom.Text = "♥";
            btnreactcom.BackColor = Color.Silver;
            btnreactcom.ForeColor = Color.Red;
        }
    }
}
