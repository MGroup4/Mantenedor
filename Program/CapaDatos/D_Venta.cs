using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class D_Venta
    {
        readonly SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        public DataTable MostrarRegistro()
        {
            DataTable DtResultado = new DataTable();
            SqlCommand SqlCmd = new SqlCommand("SPMOSTRAR_VENTA", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);

            return DtResultado;
        }

        public void InsertarRegistro(E_Venta venta)
        {
            SqlCommand SqlCmd = new SqlCommand("SPINSERTAR_VENTA", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();

            SqlCmd.Parameters.AddWithValue("@VentaID", venta.VentaID);
            SqlCmd.Parameters.AddWithValue("@AgenteDeInmobiliariaID", venta.AgenteDeInmobiliariaID);
            SqlCmd.Parameters.AddWithValue("@Fecha", venta.Fecha);
            SqlCmd.Parameters.AddWithValue("@Precio", venta.Precio);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }

        public void EditarRegistro(E_Venta venta)
        {
            SqlCommand SqlCmd = new SqlCommand("SPEDITAR_VENTA", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();

            SqlCmd.Parameters.AddWithValue("@VentaID", venta.VentaID);
            SqlCmd.Parameters.AddWithValue("@AgenteDeInmobiliariaID", venta.AgenteDeInmobiliariaID);
            SqlCmd.Parameters.AddWithValue("@Fecha", venta.Fecha);
            SqlCmd.Parameters.AddWithValue("@Precio", venta.Precio);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }

        public void EliminarRegistro(E_Venta venta)
        {
            SqlCommand SqlCmd = new SqlCommand("SPELIMINAR_VENTA", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();

            SqlCmd.Parameters.AddWithValue("@VentaID", venta.VentaID);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }
    }
}
