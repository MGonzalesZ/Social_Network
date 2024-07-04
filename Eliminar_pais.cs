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
    public partial class Eliminar_pais : Form
    {
        //string sConexion = "Data Source=servidorpanal.database.windows.net;Initial Catalog=BDPanal;User ID=adminPanal;Password=Panal-123";
        //string sConexion = "Data Source=WINDOWS;Initial Catalog=DBPANAL;Integrated Security=True";

        public Eliminar_pais()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection(BaseDeDatos.EnlaceConexion);
            string ConsultatablaUSUARIO = "select Idpais,NombrePais,CodigoTelfPais from PAIS";
            SqlDataAdapter da = new SqlDataAdapter(ConsultatablaUSUARIO, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DTGVeliminarusuario.DataSource = dt;

        }

        private void Beliminar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlConnection dataConnection = new SqlConnection(BaseDeDatos.EnlaceConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_ELIMINACIONLOGPAIS", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("@IDPAIS", SqlDbType.Int);


            da.SelectCommand.Parameters["@IDPAIS"].Value = TBseleccionarpais.Text;

            da.Fill(dt);
            MessageBox.Show("pais eliminado");
        }
        private void Bregresar_Click(object sender, EventArgs e)
        {
            Pais regresar = new Pais();
            regresar.Controls["Bmodificar"].Enabled = true;
            regresar.Controls["Beliminar"].Enabled = true;
            regresar.checkBox1.Visible = false;
            regresar.Show();
            this.Close();
        }
    }
}
