using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Usuario
    {
        public int UsuarioID { get; set; }
        public string Contraseña { get; set; }
        public int Rango { get; set; }
        public string Nombre { get; set; }
        public int DNI { get; set; }
        public int Telefono { get; set; }
    }
}
