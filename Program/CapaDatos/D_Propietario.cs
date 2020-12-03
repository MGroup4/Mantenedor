using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using CapaEntidades;

namespace CapaDatos
{
    public class D_Propietario
    {
        readonly SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        public DataTable MostrarRegistro()
        {
            DataTable DtResultado = new DataTable();
            SqlCommand SqlCmd = new SqlCommand("SPMOSTRAR_PROPIETARIO", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);

            return DtResultado;
        }

        public void InsertarRegistro(E_Propietario propietario)
        {
            SqlCommand SqlCmd = new SqlCommand("SPINSERTAR_PROPIETARIO", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();

            SqlCmd.Parameters.AddWithValue("@PropietarioID", propietario.PropietarioID);
            SqlCmd.Parameters.AddWithValue("@AgenteDeInmobiliariaID", propietario.AgenteDeInmobiliariaID);
            SqlCmd.Parameters.AddWithValue("@Nombre", propietario.Nombre);
            SqlCmd.Parameters.AddWithValue("@DNI", propietario.DNI);
            SqlCmd.Parameters.AddWithValue("@Telefono", propietario.Telefono);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }

        public void EditarRegistro(E_Propietario propietario)
        {
            SqlCommand SqlCmd = new SqlCommand("SPEDITAR_PROPIETARIO", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();

            SqlCmd.Parameters.AddWithValue("@PropietarioID", propietario.PropietarioID);
            SqlCmd.Parameters.AddWithValue("@AgenteDeInmobiliariaID", propietario.AgenteDeInmobiliariaID);
            SqlCmd.Parameters.AddWithValue("@Nombre", propietario.Nombre);
            SqlCmd.Parameters.AddWithValue("@DNI", propietario.DNI);
            SqlCmd.Parameters.AddWithValue("@Telefono", propietario.Telefono);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }

        public void EliminarRegistro(E_Propietario propietario)
        {
            SqlCommand SqlCmd = new SqlCommand("SPELIMINAR_PROPIETARIO", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();

            SqlCmd.Parameters.AddWithValue("@PropietarioID", propietario.PropietarioID);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }
    }
}
