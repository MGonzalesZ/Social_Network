using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace panalbase
{
    public partial class CHAT : Form
    {
        Socket sck;
        EndPoint epLocal, epRemote;
        USUARIO user1;
        USUARIO user2;
        public CHAT(USUARIO us1, USUARIO us2)
        {
            InitializeComponent();

            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            this.user1 = us1;
            this.user2 = us2;
            textLocalIp.Text = GetLocalIP();
            textFriendsIp.Text = obtenerIPDelAmigo(user2.idUsuario);

            textLocalPort.Text = user1.idUsuario.ToString();
            textFriendsPort.Text = user2.idUsuario.ToString();

            txtMensaje.KeyDown += new KeyEventHandler(txtMensaje_KeyDown);

        }

        private void txtMensaje_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEnviar_Click(sender, e);
            }
        }

        private string obtenerIPDelAmigo(int idAmigo)
        {
            string ipAmigo;
            SqlConnection cone = new SqlConnection(BaseDeDatos.EnlaceConexion);
            SqlDataAdapter dap = new SqlDataAdapter("PLeerIP", cone);
            dap.SelectCommand.CommandType = CommandType.StoredProcedure;
            dap.SelectCommand.Parameters.Add("@IdUsuario", SqlDbType.Int);
            dap.SelectCommand.Parameters.Add("@DireccionIP", SqlDbType.NVarChar, 30);
            dap.SelectCommand.Parameters["@DireccionIP"].Direction = ParameterDirection.Output;

            dap.SelectCommand.Parameters["@IdUsuario"].Value = idAmigo;
            cone.Open();
            dap.SelectCommand.ExecuteNonQuery();
            cone.Close();
            ipAmigo = dap.SelectCommand.Parameters["@DireccionIP"].Value.ToString();
            return ipAmigo;
        }

        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            try
            {
                epLocal = new IPEndPoint(IPAddress.Parse(textLocalIp.Text), Convert.ToInt32(textLocalPort.Text));
                sck.Bind(epLocal);

                epRemote = new IPEndPoint(IPAddress.Parse(textFriendsIp.Text), Convert.ToInt32(textFriendsPort.Text));
                sck.Connect(epRemote);

                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

                btnEmpezar.Text = "Conectado";
                btnEmpezar.Enabled = false;
                btnEnviar.Enabled = true;
                txtMensaje.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                listMessage.Height = 183;
                listMessage.Location = new Point(listMessage.Location.X, listMessage.Location.Y + 116);
            }
        }

        private void verChat()
        {
            SqlConnection conexion = new SqlConnection(BaseDeDatos.EnlaceConexion);
            SqlDataAdapter de = new SqlDataAdapter("SPVer_Chat", conexion);
            de.SelectCommand.CommandType = CommandType.StoredProcedure;
            de.SelectCommand.Parameters.Add("@IdUsuario1", SqlDbType.Int);
            de.SelectCommand.Parameters.Add("@IdUsuario2", SqlDbType.Int);
            de.SelectCommand.Parameters["@IdUsuario1"].Value = BaseDeDatos.usuarioActual.idUsuario;
            de.SelectCommand.Parameters["@IdUsuario2"].Value = this.user2.idUsuario.ToString();

            conexion.Open();
            de.SelectCommand.ExecuteNonQuery();
            BaseDeDatos.dtauxi.Clear();
            de.Fill(BaseDeDatos.dtauxi);
            conexion.Close();

            //SqlDataAdapter adaptadorIp=new SqlDataAdapter("PLeerIp")
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            verChat();
            SqlConnection conexion = new SqlConnection(BaseDeDatos.EnlaceConexion);
            SqlDataAdapter das = new SqlDataAdapter("SPRegistrar_Mensaje", conexion);
            das.SelectCommand.CommandType = CommandType.StoredProcedure;
            das.SelectCommand.Parameters.Add("@IdUsuario", SqlDbType.Int);
            das.SelectCommand.Parameters.Add("@IdUsuario2", SqlDbType.Int);
            das.SelectCommand.Parameters.Add("@IdChat", SqlDbType.Int);
            das.SelectCommand.Parameters.Add("@Mensaje", SqlDbType.NVarChar, 500);
            das.SelectCommand.Parameters["@IdUsuario"].Value = BaseDeDatos.usuarioActual.idUsuario;
            das.SelectCommand.Parameters["@IdUsuario2"].Value = this.user2.idUsuario.ToString();
            das.SelectCommand.Parameters["@IdChat"].Value = (int)BaseDeDatos.dtauxi.Rows[0][0];
            das.SelectCommand.Parameters["@Mensaje"].Value = this.user1.nombreUsuario + ": " + txtMensaje.Text;
            conexion.Open();
            das.SelectCommand.ExecuteNonQuery();
            BaseDeDatos.dtauxi.Clear();
            das.Fill(BaseDeDatos.dtauxi);
            conexion.Close();

            try
            {
                ASCIIEncoding enc = new ASCIIEncoding();
                byte[] msg = new byte[1500];
                msg = enc.GetBytes(txtMensaje.Text);

                sck.Send(msg);

                listMessage.Items.Add("TÚ: " + txtMensaje.Text);
                txtMensaje.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listMessage.Items.Add("hola");
            listMessage.Items.Add(".");
            listMessage.Items.Add(".");
            listMessage.Items.Add("hola");
        }

        private void CHAT_Load(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(BaseDeDatos.EnlaceConexion);
            SqlDataAdapter de = new SqlDataAdapter("SPRegistrar_Chat", conexion);
            de.SelectCommand.CommandType = CommandType.StoredProcedure;
            de.SelectCommand.Parameters.Add("@IdUsuario1", SqlDbType.Int);
            de.SelectCommand.Parameters.Add("@IdUsuario2", SqlDbType.Int);
            de.SelectCommand.Parameters["@IdUsuario1"].Value = BaseDeDatos.usuarioActual.idUsuario;
            de.SelectCommand.Parameters["@IdUsuario2"].Value = this.user2.idUsuario.ToString();
            conexion.Open();
            de.SelectCommand.ExecuteNonQuery();
            BaseDeDatos.dtauxi.Clear();
            de.Fill(BaseDeDatos.dtauxi);
            conexion.Close();

            verChat();

            SqlDataAdapter ed = new SqlDataAdapter("SPVer_Mensaje", conexion);
            ed.SelectCommand.CommandType = CommandType.StoredProcedure;
            ed.SelectCommand.Parameters.Add("@IdChat", SqlDbType.Int);
            ed.SelectCommand.Parameters["@IdChat"].Value = (int)BaseDeDatos.dtauxi.Rows[0][0];
            conexion.Open();
            ed.SelectCommand.ExecuteNonQuery();
            BaseDeDatos.dtauxi2.Clear();
            ed.Fill(BaseDeDatos.dtauxi2);
            conexion.Close();

            int[] conteo = new int[BaseDeDatos.dtauxi2.Rows.Count];

            for (int i = 0; i < conteo.Length; i++)
            {
                if (i % 2 == 0)
                {
                    listMessage.Items.Add(BaseDeDatos.dtauxi2.Rows[i][1].ToString());
                }
            }
            // ESTO ES NUEVOOOOO
            
             btnEmpezar_Click(sender, e);
        }

        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                int size = sck.EndReceiveFrom(aResult, ref epRemote);
                if (size > 0)
                {
                    byte[] receivedData = new byte[1464];

                    receivedData = (byte[])aResult.AsyncState;

                    ASCIIEncoding eEncoding = new ASCIIEncoding();
                    string receivedMessage = eEncoding.GetString(receivedData);
                    listMessage.Items.Add(this.user2.nombre.ToString() + ": " + receivedMessage);
                }

                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


    }
}
