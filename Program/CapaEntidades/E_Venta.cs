using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Venta
    {
        public int VentaID { get; set; }
        public int AgenteDeInmobiliariaID { get; set; }
        public DateTime Fecha { get; set; }
        public int Precio { get; set; }
    }
}
