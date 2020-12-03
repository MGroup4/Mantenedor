using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class N_Propiedad
    {
        readonly D_Propiedad ObjPropiedad = new D_Propiedad();

        public static DataTable MostrarRegistro()
        {
            return new D_Propiedad().MostrarRegistro();
        }

        public void InsertarRegistro(E_Propiedad propiedad)
        {
            ObjPropiedad.InsertarRegistro(propiedad);
        }

        public void EditarRegistro(E_Propiedad propiedad)
        {
            ObjPropiedad.EditarRegistro(propiedad);
        }

        public void EliminarRegistro(E_Propiedad propiedad)
        {
            ObjPropiedad.EliminarRegistro(propiedad);
        }
    }
}
