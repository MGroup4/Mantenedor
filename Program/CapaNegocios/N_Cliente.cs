using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocios
{
    public class N_Cliente
    {
        readonly D_Cliente ObjCliente = new D_Cliente();

        public static DataTable MostrarRegistro()
        {
            return new D_Cliente().MostrarRegistro();
        }

        public void InsertarRegistro(E_Cliente cliente)
        {
            ObjCliente.InsertarRegistro(cliente);
        }

        public void EditarRegistro(E_Cliente cliente)
        {
            ObjCliente.EditarRegistro(cliente);
        }

        //public void EliminarRegistro(E_Cliente cliente)
        //{
        //    ObjCliente.EliminarRegistro(cliente);
        //}
    }
}
