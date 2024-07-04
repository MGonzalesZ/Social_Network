using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panalbase
{
    class BaseDeDatos
    {
        //public static string EnlaceConexion = "Data Source=servidorpanal.database.windows.net;Initial Catalog=BDPanal;User ID=adminPanal;Password=Panal-123";
        //public static string EnlaceConexion = "Data Source=WINDOWS;Initial Catalog=DBPANAL;Integrated Security=True";
        //public static string EnlaceConexion = "Data Source=SQL8001.site4now.net;Initial Catalog=db_a8608d_adminpanal;User Id=db_a8608d_adminpanal_admin;Password=Panal-123";
        //public static string EnlaceConexion = "Data Source = SQL8001.site4now.net; Initial Catalog = db_a86310_adminpanal; User ID = db_a86310_adminpanal_admin; Password=Panal-7823";
        public static string EnlaceConexion = "Data Source=MAURICIOGZ;Initial Catalog=db_a86310_adminpanal;Integrated Security=True";
        public static USUARIO usuarioActual = new USUARIO();
        public static USUARIO usuarioCHAT = new USUARIO();
        public static Login Ingreso=new Login();
        public static DataTable dtLogin = new DataTable();
        public static DataTable dtIni = new DataTable();
        public static DataTable dtNotic = new DataTable();
        public static DataTable dtReact = new DataTable();
        public static DataTable dtReactCom = new DataTable();
        public static DataTable dtComnt = new DataTable();
        public static DataTable dtbqa = new DataTable();
        public static DataTable dtrtp = new DataTable();
        public static DataTable dtrtc = new DataTable();
        public static DataTable dtauxi = new DataTable();
        public static DataTable dtauxi2 = new DataTable();
        public static int idPublEditar;
        public static int idPublCom;
        public static int idCom;
        public static bool soli;
        public static bool chatt;
        public static bool auxii;
    }
}
