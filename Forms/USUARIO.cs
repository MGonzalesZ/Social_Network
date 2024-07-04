using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panalbase
{
    public class USUARIO
    {
        public int idUsuario { get; set; }
        public int idPais { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string nombreUsuario { get; set; }
        public string contraseniaUsuario { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public string genero { get; set; }
        public string fechaCreacion { get; set; }
        public string fechaNacimiento { get; set; }                
        public Image fotoPerfil { get; set; }
        public Image fotoPortada { get; set; }
        public string rolUsuario { get; set; }

        public static int puertoChat;
      
        public void borrarDatos() 
        {
            idUsuario = -1;
            idPais = -1;
            nombre = " ";
            apellidos = " ";
            nombreUsuario = " ";
            contraseniaUsuario = " ";
            correo = " ";
            telefono = " ";
            genero = " ";
            fechaCreacion = " ";
            fechaNacimiento = " ";
            rolUsuario = " ";
    }
    }
}
