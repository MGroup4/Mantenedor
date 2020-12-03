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
    public class N_Usuario
    {
        readonly D_Usuario ObjUsuario = new D_Usuario();

        public static DataTable MostrarRegistro()
        {
            return new D_Usuario().MostrarRegistro();
        }

        public void InsertarRegistro(E_Usuario usuario)
        {
            ObjUsuario.InsertarRegistro(usuario);
        }

        public void EditarRegistro(E_Usuario usuario)
        {
            ObjUsuario.EditarRegistro(usuario);
        }

        public void EliminarRegistro(E_Usuario usuario)
        {
            ObjUsuario.EliminarRegistro(usuario);
        }
    }
}
