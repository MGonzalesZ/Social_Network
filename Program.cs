using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace panalbase
{
    static class Program
    {
        [STAThread]
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>

        //public static Login Ingreso = new Login();
        //public static PaginaPrincipal Principal = new PaginaPrincipal();
        //public static CrearPublicacion CrearPubl = new CrearPublicacion();
        //public static Comentarios Coment = new Comentarios();
        //public static int idUsuarioActual;
        
        static void Main()
        {
            
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());

        }
        public static Login Ingreso = new Login();
        public static PaginaPrincipal Principal = new PaginaPrincipal();
        public static CrearPublicacion CrearPubl = new CrearPublicacion();
        public static Comentarios Coment = new Comentarios();
        public static int idUsuarioActual;
        public static DataTable dt = new DataTable
        {
            Locale = System.Globalization.CultureInfo.InvariantCulture
        };
        public static int idPublEditar;
        public static VerPublicacElegida ver11 = new VerPublicacElegida();
    }
}
