using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RegistroCorreos
{
    class Program
    {
        static string rutaArchivo;
        static string nombreArchivo;
        static readonly char delimitador = ',';
        static readonly string[] respuestaAfirmativa = { "SI", "Si", "si", "S", "s" };

        static void Main(string[] args)
        {
            Console.Write("Ingrese ruta y nombre del archivo: ");
            string archivo = Console.ReadLine();

            if (ValidaArchivo(archivo))
                Menu();
        }

        static void Menu()
        {
            int op = 0, resultado = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("+----------------------+");
                Console.WriteLine("| Registro de Clientes |");
                Console.WriteLine("+----------------------+");
                Console.WriteLine("| 1 - Ver registros    |");
                Console.WriteLine("| 2 - Agregar registro |");
                Console.WriteLine("| 3 - Borrar registro  |");
                Console.WriteLine("| 4 - Salir            |");
                Console.WriteLine("+----------------------+");
                Console.Write("Opcion: ");
                if (Int32.TryParse(Console.ReadLine(), out resultado))
                    op = resultado;

                switch (op)
                {
                    case 1:
                        MostrarRegistros();
                        break;
                    case 2:
                        AgragarRegistro();
                        break;
                    case 3:
                        BorrarRegistro();
                        break;
                    default:
                        break;
                }

            } while (op >= 1 && op <= 3);
        }

        static void MostrarRegistros()
        {
            Console.Clear();

            string archivo = Path.Combine(rutaArchivo, nombreArchivo);

            string encabezado = String.Empty;
            string separador = new string('-', 80);

            int idx = 0;

            using (StreamReader reader = new StreamReader(archivo))
            {
                while (!reader.EndOfStream)
                {
                    string[] valor = reader.ReadLine().Split(delimitador);
                    if (idx == 0)
                    {
                        encabezado = $"{new string(' ', 6)}{valor[0].ToUpper().PadRight(25)}{valor[1].ToUpper().PadRight(25)}{valor[2].ToUpper().PadRight(30)}";
                        Console.WriteLine("{0}", encabezado);
                        Console.WriteLine(separador);
                    }
                    else
                    {
                        if ((idx % 24) != 0)
                            Console.WriteLine("{0}{1}{2}{3}", idx.ToString().PadRight(6), valor[0].PadRight(25), valor[1].PadRight(25), valor[2].PadRight(30));
                        else
                        {
                            Console.WriteLine(separador);
                            Console.Write("Presione [Enter] para continuar... ");
                            Console.ReadLine();

                            Console.Clear();
                            Console.WriteLine("{0}", encabezado);
                            Console.WriteLine(separador);
                            Console.WriteLine("{0}{1}{2}{3}", idx.ToString().PadRight(6), valor[0].PadRight(25), valor[1].PadRight(25), valor[2].PadRight(30));
                        }
                    }
                    idx++;
                }
            }

            Console.WriteLine(separador);
            Console.Write("Presione [A]gregar | [B]orrar | [Enter] para salir. ");
            string resp = Console.ReadLine();

            if (resp == "A" || resp == "a")
                AgragarRegistro();
            else if (resp == "B" || resp == "b")
                BorrarRegistro();
        }

        static void AgragarRegistro()
        {
            Console.Clear();
            Console.WriteLine("- Agregar Registro -");
            Console.WriteLine(" Dejar campos en blanco para salir.\n\n");

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Apellido: ");
            string apellido = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            if (!String.IsNullOrEmpty(nombre) && !String.IsNullOrEmpty(apellido) && !String.IsNullOrEmpty(email))
            {
                try
                {
                    string archivo = Path.Combine(rutaArchivo, nombreArchivo);

                    File.AppendAllText(archivo, $"{nombre}{delimitador}{apellido}{delimitador}{email}{Environment.NewLine}");

                    Console.WriteLine("\n ** Registro agregado **");
                    Console.ReadKey();
                }
                catch (Exception err)
                {
                    Console.WriteLine("\nError al agregar registro.\n{0}", err.Message);
                }
            }
        }

        static void BorrarRegistro()
        {
            Console.Clear();

            Console.WriteLine("- Borrar Registro -");
            Console.WriteLine(" Dejar campos en blanco para salir.\n\n");

            Console.Write("Igrese el número de línea a eliminar: ");
            string linea = Console.ReadLine();

            int num;
            int indice = int.TryParse(linea, out num) ? num : -1;

            if (indice >= 0)
            {
                string archivo = Path.Combine(rutaArchivo, nombreArchivo);

                List<string> lineas = File.ReadAllLines(archivo).ToList();
                lineas.RemoveAt(indice);
                File.WriteAllLines(archivo, lineas);
            }
        }

        static bool ValidaArchivo(string _archivo)
        {
            bool valido = false;

            if (!String.IsNullOrEmpty(_archivo))
            {
                rutaArchivo = Path.GetDirectoryName(_archivo);
                nombreArchivo = Path.GetFileName(_archivo);

                // Validar directorio exista
                if (!String.IsNullOrEmpty(rutaArchivo))
                {
                    if (!Directory.Exists(rutaArchivo))
                        Directory.CreateDirectory(rutaArchivo);
                }
                else
                    rutaArchivo = Directory.GetCurrentDirectory();

                // Validar archivo exista
                string nuevoArchivo = Path.Combine(rutaArchivo, nombreArchivo);

                if (!File.Exists(nuevoArchivo))
                {
                    try
                    {
                        File.Create(nuevoArchivo).Close();
                        File.AppendAllText(nuevoArchivo, $"Nombre{delimitador}Apellido{delimitador}Email{Environment.NewLine}");
                        valido = true;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error al crear archivo.\n{0}", e.Message);
                    }
                }
                else
                    valido = true;
            }
            else
                Console.WriteLine("Ruta o nombre de archivo vacio.");

            return valido;
        }
    }
}
