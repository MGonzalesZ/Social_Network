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
    public partial class Pais : Form
    {
        //string sConexion = "Data Source=servidorpanal.database.windows.net;Initial Catalog=BDPanal;User ID=adminPanal;Password=Panal-123";
        public Pais()
        {
            InitializeComponent();
        }

        private void Baniadirpais_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlConnection dataConnection = new SqlConnection(BaseDeDatos.EnlaceConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_REGISTRARPAIS", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@NOMBREPAIS", SqlDbType.NVarChar, 50);
            da.SelectCommand.Parameters.Add("@CODIGODELPAIS", SqlDbType.NVarChar, 50);
            da.SelectCommand.Parameters["@NOMBREPAIS"].Value = TBnombrepais.Text.ToUpper();
            da.SelectCommand.Parameters["@CODIGODELPAIS"].Value = TBpais.Text;
            da.Fill(dt);
            MessageBox.Show("pais registrado");
        }

        private void Click(object sender, EventArgs e)
        {
            Activar_edicion_pais entrar = new Activar_edicion_pais();
            entrar.Show();
            this.Close();
        }

        private void Bmodificar_Click(object sender, EventArgs e)
        {
            modificar_pais entrar = new modificar_pais();
            entrar.Show();
            this.Close();
        }

        private void Beliminar_Click(object sender, EventArgs e)
        {
            Eliminar_pais entrar = new Eliminar_pais();
            entrar.Show();
            this.Close();
        }

        private void Bregresarpais_Click(object sender, EventArgs e)
        {
            Registro regresar = new Registro();
            regresar.Show();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Activar_edicion_pais entrar = new Activar_edicion_pais();
            entrar.Show();
            this.Close();
        }

        private void Bmodificar_Click_1(object sender, EventArgs e)
        {

        }

        private void Beliminar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
