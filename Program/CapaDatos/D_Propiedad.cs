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
    public class D_Propiedad
    {
        readonly SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        public DataTable MostrarRegistro()
        {
            DataTable DtResultado = new DataTable();
            SqlCommand SqlCmd = new SqlCommand("SPMOSTRAR_PROPIEDAD", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);

            return DtResultado;
        }

        public void InsertarRegistro(E_Propiedad propiedad)
        {
            SqlCommand SqlCmd = new SqlCommand("SPINSERTAR_PROPIEDAD", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();

            SqlCmd.Parameters.AddWithValue("@PropiedadID", propiedad.PropiedadID);
            SqlCmd.Parameters.AddWithValue("@AgenteDeInmobiliariaID", propiedad.AgenteDeInmobiliariaID);
            SqlCmd.Parameters.AddWithValue("@ValorDeVenta", propiedad.ValorDeVenta);
            SqlCmd.Parameters.AddWithValue("@Ubicacion", propiedad.Ubicacion);
            SqlCmd.Parameters.AddWithValue("@Dormitorios", propiedad.Dormitorios);
            SqlCmd.Parameters.AddWithValue("@Banios", propiedad.Baños);
            SqlCmd.Parameters.AddWithValue("@Estacionamiento", propiedad.Estacionamiento);
            SqlCmd.Parameters.AddWithValue("@Tamanio", propiedad.Tamaño);          

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }

        public void EditarRegistro(E_Propiedad propiedad)
        {
            SqlCommand SqlCmd = new SqlCommand("SPEDITAR_PROPIEDAD", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();

            SqlCmd.Parameters.AddWithValue("@PropiedadID", propiedad.PropiedadID);
            SqlCmd.Parameters.AddWithValue("@AgenteDeInmobiliariaID", propiedad.AgenteDeInmobiliariaID);
            SqlCmd.Parameters.AddWithValue("@ValorDeVenta", propiedad.ValorDeVenta);
            SqlCmd.Parameters.AddWithValue("@Ubicacion", propiedad.Ubicacion);
            SqlCmd.Parameters.AddWithValue("@Dormitorios", propiedad.Dormitorios);
            SqlCmd.Parameters.AddWithValue("@Banios", propiedad.Baños);
            SqlCmd.Parameters.AddWithValue("@Estacionamiento", propiedad.Estacionamiento);
            SqlCmd.Parameters.AddWithValue("@Tamanio", propiedad.Tamaño);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }

        public void EliminarRegistro(E_Propiedad propiedad)
        {
            SqlCommand SqlCmd = new SqlCommand("SPELIMINAR_PROPIEDAD", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();

            SqlCmd.Parameters.AddWithValue("@PropiedadID", propiedad.PropiedadID);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }
    }
}
