using ApplicationTresCapas.AcessoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTresCapas.LogicaNegocios
{
    public class Modelos
    {
        public class Estudiante
        {
            public Int64 ID { get; set; }
            public Int64 IDPersona { get; set; }
            public string Codigo { get; set; }
            public string FechaIngreso { get; set; }
            public string FechaEgreso { get; set; }
            public string Estatus { get; set; }
        }

        public class Persona
        {
            public Int64 ID { get; set; }
            public string PrimerNombre { get; set; }
            public string SegundoNombre { get; set; }
            public string PrimerApellido { get; set; }
            public string SegundoApellido { get; set; }
            public string Genero { get; set; }
            public void GuardarRegistro()
            {
                Int64 val;
                if (Int64.TryParse(ID.ToString(), out val))
                {
                    ConexionBD cnxBD = new ConexionBD();

                    cnxBD.AbrirConexion();

                    string comandoSQL = String.Empty;

                    if (val > 0)
                        comandoSQL = $"UPDATE Persona SET PrimerNombre='{PrimerNombre}', SegundoNombre='{SegundoNombre}', PrimerApellido='{PrimerApellido}', SegundoApellido='{SegundoApellido}', Genero='{Genero}' WHERE ID={ID}";
                    else
                        comandoSQL = $"INSERT INTO Persona (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, Genero) VALUES ('{PrimerNombre}','{SegundoNombre}','{PrimerApellido}','{SegundoApellido}','{Genero}')";

                    var result = (int)cnxBD.EjecutarSQL(comandoSQL);

                    cnxBD.CerrarConexion();
                }
            }
            public void BorrarRegistro()
            {
                Int64 val;
                if (Int64.TryParse(ID.ToString(), out val))
                {
                    ConexionBD cnxBD = new ConexionBD();

                    cnxBD.AbrirConexion();

                    string comandoSQL = String.Empty;

                    if (val > 0)
                    {
                        comandoSQL = $"DELETE FROM Persona WHERE ID={ID}";
                        var result = (int)cnxBD.EjecutarSQL(comandoSQL);
                    }

                    cnxBD.CerrarConexion();
                }
            }
        }
    }
}
