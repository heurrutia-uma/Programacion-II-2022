using ApplicationTresCapas.AcessoDatos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ApplicationTresCapas.LogicaNegocios.Modelos;

namespace ApplicationTresCapas.LogicaNegocios
{
    public class PersonaAD
    {
        private ConexionBD cnxBD;

        public PersonaAD()
        {
            cnxBD = new ConexionBD();
        }

        public List<Persona> ListaPersona()
        {
            List<Persona> lista = new List<Persona>();

            cnxBD.AbrirConexion();

            string comandoSQL = $"SELECT P.Id, P.PrimerNombre, P.SegundoNombre, " +
                $"P.PrimerApellido, P.SegundoApellido, P.Genero " +
                $"FROM Persona P;";

            SqlDataReader dataReader = (SqlDataReader)cnxBD.EjecutarSQL(comandoSQL);

            while (dataReader.Read())
            {
                Object[] registro = new Object[dataReader.FieldCount];
                dataReader.GetValues(registro);

                Persona persona = new Persona()
                {
                    ID = Convert.ToInt64(registro[0]),
                    PrimerNombre = registro[1].ToString(),
                    SegundoNombre = registro[2].ToString(),
                    PrimerApellido = registro[3].ToString(),
                    SegundoApellido = registro[4].ToString(),
                    Genero = registro[5].ToString()
                };

                lista.Add(persona);
            }

            dataReader.Close();

            cnxBD.CerrarConexion();

            return lista;
        }

        public Persona ObtenerPersona(Int64 id)
        {
            Persona persona = null;

            cnxBD.AbrirConexion();

            string comandoSQL = $"SELECT P.Id, P.PrimerNombre, P.SegundoNombre, " +
                $"P.PrimerApellido, P.SegundoApellido, P.Genero " +
                $"FROM Persona P WHERE P.Id = {id};";

            SqlDataReader dataReader = (SqlDataReader)cnxBD.EjecutarSQL(comandoSQL);

            if (dataReader != null)
            {
                dataReader.Read();

                Object[] registro = new Object[dataReader.FieldCount];
                dataReader.GetValues(registro);

                persona = new Persona()
                {
                    ID = Convert.ToInt64(registro[0]),
                    PrimerNombre = registro[1].ToString(),
                    SegundoNombre = registro[2].ToString(),
                    PrimerApellido = registro[3].ToString(),
                    SegundoApellido = registro[4].ToString(),
                    Genero = registro[5].ToString()
                };

                dataReader.Close();
            }

            cnxBD.CerrarConexion();

            return persona;
        }
    }
}
