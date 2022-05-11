using System;
using System.Configuration;
using System.Data.SqlClient;

namespace ApplicationTresCapas.AcessoDatos
{
    public class ConexionBD
    {
        private SqlConnection _sqlConnection = null;
        private string _cadenaConexion;

        public ConexionBD()
        {
            _cadenaConexion = ConfigurationManager.ConnectionStrings["cnxLocal"].ConnectionString;
        }

        public void AbrirConexion()
        {
            _sqlConnection = new SqlConnection();
            _sqlConnection.ConnectionString = _cadenaConexion;
            _sqlConnection.Open();
        }

        public object EjecutarSQL(string consultaSQL)
        {
            object resultado = null;

            if (!String.IsNullOrEmpty(consultaSQL))
            {
                SqlCommand comandoSQL = new SqlCommand(consultaSQL, _sqlConnection);

                if (consultaSQL.ToUpper().StartsWith("SELECT"))
                    resultado = comandoSQL.ExecuteReader();
                else
                    resultado = comandoSQL.ExecuteNonQuery();
            }

            return resultado;
        }

        public void CerrarConexion()
        {
            if (_sqlConnection != null && _sqlConnection.State == System.Data.ConnectionState.Open)
                _sqlConnection.Close();
        }
    }
}
