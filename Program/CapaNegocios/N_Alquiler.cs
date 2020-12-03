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
    public class N_Alquiler
    {
        readonly D_Alquiler ObjVenta = new D_Alquiler();

        public static DataTable MostrarRegistro()
        {
            return new D_Alquiler().MostrarRegistro();
        }

        public void InsertarRegistro(E_Alquiler alquiler)
        {
            ObjVenta.InsertarRegistro(alquiler);
        }

        public void EditarRegistro(E_Alquiler alquiler)
        {
            ObjVenta.EditarRegistro(alquiler);
        }

        //public void EliminarRegistro(E_Alquiler alquiler)
        //{
        //    ObjVenta.EliminarRegistro(alquiler);
        //}
    }
}
