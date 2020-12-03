using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Propiedad
    {
        public int PropiedadID { get; set; }
        public int AgenteDeInmobiliariaID { get; set; }
        public int ValorDeVenta { get; set; }
        public string Ubicacion { get; set; }
        public int Dormitorios { get; set; }
        public int Baños { get; set; }
        public int Estacionamiento { get; set; }
        public int Tamaño { get; set; }
        public string Descripcion { get; set; }
    }
}
