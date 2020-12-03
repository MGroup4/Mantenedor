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
    public class D_Usuario
    {
        readonly SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        public DataTable MostrarRegistro()
        {
            DataTable DtResultado = new DataTable();
            SqlCommand SqlCmd = new SqlCommand("SPMOSTRAR_USUARIO", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);

            return DtResultado;
        }

        public void InsertarRegistro(E_Usuario usuario)
        {
            SqlCommand SqlCmd = new SqlCommand("SPINSERTAR_USUARIO", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();

            SqlCmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
            SqlCmd.Parameters.AddWithValue("@UsuarioID", usuario.UsuarioID);
            SqlCmd.Parameters.AddWithValue("@DNI", usuario.DNI);
            SqlCmd.Parameters.AddWithValue("@Contrasenia", usuario.Contraseña);
            SqlCmd.Parameters.AddWithValue("@Telefono", usuario.Telefono);
            SqlCmd.Parameters.AddWithValue("@RangoID", usuario.Rango);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }

        public void EditarRegistro(E_Usuario usuario)
        {
            SqlCommand SqlCmd = new SqlCommand("SPEDITAR_USUARIO", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

          
            conectar.Open();

            SqlCmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
            SqlCmd.Parameters.AddWithValue("@UsuarioID", usuario.UsuarioID);
            SqlCmd.Parameters.AddWithValue("@DNI", usuario.DNI);
            SqlCmd.Parameters.AddWithValue("@Contrasenia", usuario.Contraseña);
            SqlCmd.Parameters.AddWithValue("@Telefono", usuario.Telefono);
            SqlCmd.Parameters.AddWithValue("@RangoID", usuario.Rango);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
          
        }

        public void EliminarRegistro(E_Usuario usuario)
        {
            SqlCommand SqlCmd = new SqlCommand("SPELIMINAR_USUARIO", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();

            SqlCmd.Parameters.AddWithValue("@UsuarioID", usuario.UsuarioID);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }
    }
}
