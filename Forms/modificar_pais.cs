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
    public partial class modificar_pais : Form
    {

        //string sConexion = "Data Source=servidorpanal.database.windows.net;Initial Catalog=BDPanal;User ID=adminPanal;Password=Panal-123";
        //string sConexion = "Data Source=WINDOWS;Initial Catalog=DBPANAL;Integrated Security=True";

        public modificar_pais()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection(BaseDeDatos.EnlaceConexion);
            string ConsultatablaUSUARIO = "select Idpais,NombrePais,CodigoTelfPais from PAIS";
            SqlDataAdapter da = new SqlDataAdapter(ConsultatablaUSUARIO, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewmodificar.DataSource = dt;
        }

        private void Baplicar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();


            SqlConnection dataConnection = new SqlConnection(BaseDeDatos.EnlaceConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_EDITARPAIS", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("@IDPAIS", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@NOMBREDELPAIS", SqlDbType.NVarChar, 50);
            da.SelectCommand.Parameters.Add("@CODIGOTELEFPAIS", SqlDbType.NVarChar, 50);


            da.SelectCommand.Parameters["@IDPAIS"].Value = TBidPais.Text;
            da.SelectCommand.Parameters["@NOMBREDELPAIS"].Value = TBnombrepais.Text;
            da.SelectCommand.Parameters["@CODIGOTELEFPAIS"].Value = TBcodpais.Text;
            da.Fill(dt);
            MessageBox.Show("pais modificado");
        }

        private void Bvolver_Click(object sender, EventArgs e)
        {
            Pais regresar = new Pais();
            regresar.Controls["Bmodificar"].Enabled = true;
            regresar.Controls["Beliminar"].Enabled = true;
            regresar.checkBox1.Visible = false;
            regresar.Show();
            this.Close();
        }

        private void Baplicar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
