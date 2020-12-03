using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Alquiler
    {
        public int AlquilerID { get; set; }
        public int AgenteDeInmobiliariaID { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public float Precio { get; set; }
        public int DNICliente { get; set; }
        public int Cuotas { get; set; }
        public float PrecioPorCuotas { get; set; }
    }
}
