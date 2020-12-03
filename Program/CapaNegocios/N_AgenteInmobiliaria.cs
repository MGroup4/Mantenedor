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
    public class N_AgenteInmobiliaria
    {
        readonly D_AgenteDeInmobiliaria ObjAgente = new D_AgenteDeInmobiliaria();

        public static DataTable MostrarRegistro()
        {
            return new D_AgenteDeInmobiliaria().MostrarRegistro();
        }

        public void InsertarRegistro(E_AgenteDeInmobiliaria agente)
        {
            ObjAgente.InsertarRegistro(agente);
        }

        public void EditarRegistro(E_AgenteDeInmobiliaria agente)
        {
            ObjAgente.EditarRegistro(agente);
        }

        public void EliminarRegistro(E_AgenteDeInmobiliaria agente)
        {
            ObjAgente.EliminarRegistro(agente);
        }
    }
}
