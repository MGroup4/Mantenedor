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
    public class D_Cliente
    {
        readonly SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        public DataTable MostrarRegistro()
        {
            DataTable DtResultado = new DataTable();
            SqlCommand SqlCmd = new SqlCommand("SPMOSTRAR_CLIENTE", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);

            return DtResultado;
        }

        public void InsertarRegistro(E_Cliente cliente)
        {
            SqlCommand SqlCmd = new SqlCommand("SPINSERTAR_CLIENTE", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();

            SqlCmd.Parameters.AddWithValue("@ClienteID", cliente.ClienteID);
            SqlCmd.Parameters.AddWithValue("@AgenteDeInmobiliariaID", cliente.AgenteDeInmobiliariaID);
            SqlCmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
            SqlCmd.Parameters.AddWithValue("@DNI", cliente.DNI);
            SqlCmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }

        public void EditarRegistro(E_Cliente cliente)
        {
            SqlCommand SqlCmd = new SqlCommand("SPEDITAR_CLIENTE", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();

            SqlCmd.Parameters.AddWithValue("@ClienteID", cliente.ClienteID);
            SqlCmd.Parameters.AddWithValue("@AgenteDeInmobiliariaID", cliente.AgenteDeInmobiliariaID);
            SqlCmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
            SqlCmd.Parameters.AddWithValue("@DNI", cliente.DNI);
            SqlCmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }

        public void EliminarRegistro(E_Cliente cliente)
        {
            SqlCommand SqlCmd = new SqlCommand("SPELIMINAR_CLIENTE", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();

            SqlCmd.Parameters.AddWithValue("@ClienteID", cliente.ClienteID);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }
    }
}
