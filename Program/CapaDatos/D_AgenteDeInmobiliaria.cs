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
    public class D_AgenteDeInmobiliaria
    {
        readonly SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        public DataTable MostrarRegistro()
        {
            DataTable DtResultado = new DataTable();
            SqlCommand SqlCmd = new SqlCommand("SPMOSTRAR_AGDIM", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);

            return DtResultado;
        }

        public void InsertarRegistro(E_AgenteDeInmobiliaria agdim)
        {
            SqlCommand SqlCmd = new SqlCommand("SPINSERTAR_AGDIM", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();

            SqlCmd.Parameters.AddWithValue("@AgenteDeInmobiliariaID", agdim.AgenteDeInmobiliariaID);
            SqlCmd.Parameters.AddWithValue("@Nombre", agdim.Nombre);
            SqlCmd.Parameters.AddWithValue("@UsuarioID", agdim.UsuarioID);
            SqlCmd.Parameters.AddWithValue("@DNI", agdim.DNI);
            SqlCmd.Parameters.AddWithValue("@Telefono", agdim.Telefono);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }

        public void EditarRegistro(E_AgenteDeInmobiliaria agdim)
        {
            SqlCommand SqlCmd = new SqlCommand("SPEDITAR_AGDIM", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();

            SqlCmd.Parameters.AddWithValue("@AgenteDeInmobiliariaID", agdim.AgenteDeInmobiliariaID);
            SqlCmd.Parameters.AddWithValue("@Nombre", agdim.Nombre);
            SqlCmd.Parameters.AddWithValue("@UsuarioID", agdim.UsuarioID);
            SqlCmd.Parameters.AddWithValue("@DNI", agdim.DNI);
            SqlCmd.Parameters.AddWithValue("@Telefono", agdim.Telefono);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }

        public void EliminarRegistro(E_AgenteDeInmobiliaria agdim)
        {
            SqlCommand SqlCmd = new SqlCommand("SPELIMINAR_AGDIM", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();

            SqlCmd.Parameters.AddWithValue("@AgenteDeInmobiliariaID", agdim.AgenteDeInmobiliariaID);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }
    }
}
