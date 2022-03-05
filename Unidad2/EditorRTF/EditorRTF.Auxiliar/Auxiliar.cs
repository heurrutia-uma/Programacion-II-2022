using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EditorRTF.Auxiliar
{
    public struct Fuente
    {
        public List<string> Nombres;
        public List<string> Tamanios;
    }

    public class Dialogos
    {
        static readonly string filtro = "Archivo RTF (*.rtf)|*.rtf";

        public static string AbrirArchivo()
        {
            string nombreArchivo = string.Empty;

            OpenFileDialog abrirDialogo = new OpenFileDialog();
            abrirDialogo.Filter = filtro;

            if (abrirDialogo.ShowDialog() == DialogResult.OK)
                nombreArchivo = abrirDialogo.FileName;

            return nombreArchivo;
        }

        public static string GuardarArchivoComo()
        {
            string nombreArchivo = string.Empty;

            SaveFileDialog guardarDialogo = new SaveFileDialog();
            guardarDialogo.Filter = filtro;

            if (guardarDialogo.ShowDialog() == DialogResult.OK)
                nombreArchivo = guardarDialogo.FileName;

            return nombreArchivo;
        }

        public static Color SeleccionarColorFuente()
        {
            Color color = Color.Empty;

            ColorDialog colorFuente = new ColorDialog();

            if (colorFuente.ShowDialog() == DialogResult.OK)
                color = colorFuente.Color;

            return color;
        }
    }

    public class Funciones
    {
        public static readonly int FUENTE_TAMANIO_INICIAL = 8;
        public static readonly int FUENTE_TAMANIO_FINAL = 72;
        public static Fuente CargarFamiliaFuente()
        {
            Fuente obj = new Fuente();

            FontFamily[] familias = FontFamily.Families;
            List<string> fuentes = new List<string>();
            List<string> tamanios = new List<string>();

            for (int i = 0; i < familias.Length; i++)
            {
                if (familias[i].IsStyleAvailable(FontStyle.Regular))
                    fuentes.Add(familias[i].Name);
            }

            int j = FUENTE_TAMANIO_INICIAL;
            while (j <= FUENTE_TAMANIO_FINAL)
            {
                tamanios.Add(j.ToString());

                if (j < 12)
                    j++;
                else if (j >= 12 && j < 48)
                    j += 2;
                else if (j >= 48)
                    j += 24;
            }

            obj.Nombres = fuentes;
            obj.Tamanios = tamanios;

            return obj;
        }
    }
}
