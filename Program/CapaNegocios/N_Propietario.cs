using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocios
{
    class N_Propietario
    {
        readonly D_Propietario ObjPropietario = new D_Propietario();

        public static DataTable MostrarRegistro()
        {
            return new D_Propietario().MostrarRegistro();
        }

        public void InsertarRegistro(E_Propietario propietario)
        {
            ObjPropietario.InsertarRegistro(propietario);
        }

        public void EditarRegistro(E_Propietario propietario)
        {
            ObjPropietario.EditarRegistro(propietario);
        }

        public void EliminarRegistro(E_Propietario propietario)
        {
            ObjPropietario.EliminarRegistro(propietario);
        }
    }
}
