using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Propietario
    {
        public int PropietarioID { get; set; }
        public int AgenteDeInmobiliariaID { get; set; }
        public string Nombre { get; set; }
        public int DNI { get; set; }
        public int Telefono { get; set; }
    }
}
