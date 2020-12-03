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
    class N_Venta
    {
        readonly D_Venta ObjVenta = new D_Venta();

        public static DataTable MostrarRegistro()
        {
            return new D_Venta().MostrarRegistro();
        }

        public void InsertarRegistro(E_Venta venta)
        {
            ObjVenta.InsertarRegistro(venta);
        }

        public void EditarRegistro(E_Venta venta)
        {
            ObjVenta.EditarRegistro(venta);
        }

        //public void EliminarRegistro(E_Venta venta)
        //{
        //    ObjVenta.EliminarRegistro(venta);
        //}
    }
}
