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
    public partial class Activar_edicion_pais : Form
    {
        //string sConexion = "Data Source=servidorpanal.database.windows.net;Initial Catalog=BDPanal;User ID=adminPanal;Password=Panal-123";
        //string sConexion = "Data Source=servidorpanal.database.windows.net;Initial Catalog=BDPanal;User ID=adminPanal;Password=Panal-123";
        public Activar_edicion_pais()
        {
            InitializeComponent();
        }

        private void Brealizado_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            

            SqlConnection dataConnection = new SqlConnection(BaseDeDatos.EnlaceConexion);
            SqlDataAdapter da = new SqlDataAdapter("SP_login", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("@Usersql", SqlDbType.NVarChar, 100);
            da.SelectCommand.Parameters.Add("@Contraseniasql", SqlDbType.NVarChar, 100);


            da.SelectCommand.Parameters["@Usersql"].Value = TBuser.Text;
            da.SelectCommand.Parameters["@Contraseniasql"].Value = TBpass.Text;
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {

                Pais modificar = new Pais();
                modificar.Controls["Bmodificar"].Enabled = true;
                modificar.Controls["Beliminar"].Enabled = true;
                modificar.checkBox1.Visible = false;
                modificar.Show();

                this.Close();

            }
            else
            {

                MessageBox.Show("error de datos");
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pais regresar = new Pais();
            regresar.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
