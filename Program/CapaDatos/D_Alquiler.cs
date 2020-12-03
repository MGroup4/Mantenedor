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
    public class D_Alquiler
    {
        readonly SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        public DataTable MostrarRegistro()
        {
            DataTable DtResultado = new DataTable();
            SqlCommand SqlCmd = new SqlCommand("SPMOSTRAR_ALQUILER", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);

            return DtResultado;
        }

        public void InsertarRegistro(E_Alquiler alquiler)
        {
            SqlCommand SqlCmd = new SqlCommand("SPINSERTAR_ALQUILER", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();

            SqlCmd.Parameters.AddWithValue("@AlquilerID",alquiler.AlquilerID);           
            SqlCmd.Parameters.AddWithValue("@FechaInicio", alquiler.FechaInicio);
            SqlCmd.Parameters.AddWithValue("@FechaFin", alquiler.FechaFin);
            SqlCmd.Parameters.AddWithValue("@Precio", alquiler.Precio);
            SqlCmd.Parameters.AddWithValue("@DNICliente", alquiler.DNICliente);
            SqlCmd.Parameters.AddWithValue("@Cuotas", alquiler.Cuotas);
            SqlCmd.Parameters.AddWithValue("@PrecioPorCuotas", alquiler.PrecioPorCuotas);   

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }

        public void EditarRegistro(E_Alquiler alquiler)
        {
            SqlCommand SqlCmd = new SqlCommand("SPEDITAR_ALQUILER", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();

            SqlCmd.Parameters.AddWithValue("@AlquilerID", alquiler.AlquilerID);
            SqlCmd.Parameters.AddWithValue("@AgenteDeInmobiliariaID", alquiler.AgenteDeInmobiliariaID);
            SqlCmd.Parameters.AddWithValue("@FechaInicio", alquiler.FechaInicio);
            SqlCmd.Parameters.AddWithValue("@FechaFin", alquiler.FechaFin);
            SqlCmd.Parameters.AddWithValue("@Precio", alquiler.Precio);
            SqlCmd.Parameters.AddWithValue("@DNICliente", alquiler.DNICliente);
            SqlCmd.Parameters.AddWithValue("@Cuotas", alquiler.Cuotas);
            SqlCmd.Parameters.AddWithValue("@PrecioPorCuotas", alquiler.PrecioPorCuotas);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }

        public void EliminarRegistro(E_Alquiler alquiler)
        {
            SqlCommand SqlCmd = new SqlCommand("SPELIMINAR_ALQUILER", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();

            SqlCmd.Parameters.AddWithValue("@AlquilerID", alquiler.AlquilerID);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }
    }
}
