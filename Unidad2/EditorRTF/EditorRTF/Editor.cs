using EditorRTF.Auxiliar;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EditorRTF
{
    public partial class Editor : Form
    {
        public Editor()
        {
            InitializeComponent();
        }

        private void NuevoArchivo()
        {
            RichTxtBox.ResetText();
        }

        private void AbrirArchivo()
        {
            string archivo = Auxiliar.Dialogos.AbrirArchivo();

            if (!string.IsNullOrEmpty(archivo))
                RichTxtBox.LoadFile(archivo);
        }

        private void GuardarComo()
        {
            string archivo = Auxiliar.Dialogos.GuardarArchivoComo();

            if (!string.IsNullOrEmpty(archivo))
                RichTxtBox.SaveFile(archivo);
        }

        private void AplicarEstilo(FontStyle estilo)
        {
            string fuenteCombo = ToolStripCmbFuente.SelectedItem.ToString();
            float tamnioCombo = ToolStripCmbTamanio.SelectedItem == null ? (float)Convert.ToDecimal(Auxiliar.Funciones.FUENTE_TAMANIO_INICIAL) : (float)Convert.ToDecimal(ToolStripCmbTamanio.SelectedItem);

            string nombreFuente;
            float tamanio;

            if (RichTxtBox.SelectionFont != null)
            {
                string fuenteSeleccion = RichTxtBox.SelectionFont.Name;
                float tamanioSeleccion = RichTxtBox.SelectionFont.Size;

                if (fuenteCombo != fuenteSeleccion)
                    nombreFuente = fuenteCombo;
                else
                    nombreFuente = fuenteSeleccion;

                if (tamnioCombo != tamanioSeleccion)
                    tamanio = tamnioCombo;
                else
                    tamanio = tamanioSeleccion;
            }
            else
            {
                nombreFuente = fuenteCombo;
                tamanio = tamnioCombo;
            }

            Font fuente = new Font(nombreFuente, tamanio, estilo);

            if (fuente != null)
                RichTxtBox.SelectionFont = fuente;
        }

        private void CerrarApplicacion()
        {
            this.Close();
        }

        private void ToolStripSalir_Click(object sender, EventArgs e)
        {
            CerrarApplicacion();
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarApplicacion();
        }

        private void NuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoArchivo();
        }

        private void ToolStripNuevo_Click(object sender, EventArgs e)
        {
            NuevoArchivo();
        }

        private void ToolStripAbrir_Click(object sender, EventArgs e)
        {
            AbrirArchivo();
        }

        private void AbrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirArchivo();
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarComo();
        }

        private void ToolStripGuardarComo_Click(object sender, EventArgs e)
        {
            GuardarComo();
        }

        private void Editor_Load(object sender, EventArgs e)
        {
            Fuente fuentes = Auxiliar.Funciones.CargarFamiliaFuente();

            foreach(string fuente in fuentes.Nombres)
            {
                ToolStripCmbFuente.Items.Add(fuente);
            }

            foreach (string tamanio in fuentes.Tamanios)
            {
                ToolStripCmbTamanio.Items.Add(tamanio);
            }

            ToolStripCmbFuente.SelectedItem = RichTxtBox.Font.Name;
            ToolStripCmbTamanio.SelectedItem = Math.Truncate(RichTxtBox.Font.Size).ToString();
        }

        private void ToolStripCmbFuente_SelectedIndexChanged(object sender, EventArgs e)
        {
            FontStyle estilo = RichTxtBox.SelectionFont == null ? FontStyle.Regular : RichTxtBox.SelectionFont.Style;
            AplicarEstilo(estilo);
        }

        private void ToolStripCmbTamanio_SelectedIndexChanged(object sender, EventArgs e)
        {
            FontStyle estilo = RichTxtBox.SelectionFont == null ? FontStyle.Regular : RichTxtBox.SelectionFont.Style;
            AplicarEstilo(estilo);
        }

        private void ToolStripBtnNegrita_Click(object sender, EventArgs e)
        {
            FontStyle estilo = FontStyle.Bold;

            if (RichTxtBox.SelectionFont != null)
            {
                estilo = RichTxtBox.SelectionFont.Style;

                if (RichTxtBox.SelectionFont.Bold)
                    estilo = estilo & ~FontStyle.Bold;
                else
                    estilo = estilo | FontStyle.Bold;
            }

            AplicarEstilo(estilo);
        }

        private void ToolStripBtnItalica_Click(object sender, EventArgs e)
        {
            FontStyle estilo = FontStyle.Italic;

            if (RichTxtBox.SelectionFont != null)
            {
                estilo = RichTxtBox.SelectionFont.Style;

                if (RichTxtBox.SelectionFont.Italic)
                    estilo = estilo & ~FontStyle.Italic;
                else
                    estilo = estilo | FontStyle.Italic;
            }

            AplicarEstilo(estilo);
        }

        private void ToolStripBtnSubrayado_Click(object sender, EventArgs e)
        {
            FontStyle estilo = FontStyle.Underline;

            if (RichTxtBox.SelectionFont != null)
            {
                estilo = RichTxtBox.SelectionFont.Style;

                if (RichTxtBox.SelectionFont.Underline)
                    estilo = estilo & ~FontStyle.Underline;
                else
                    estilo = estilo | FontStyle.Underline;
            }

            AplicarEstilo(estilo);
        }

        private void ToolStripBtnColor_Click(object sender, EventArgs e)
        {
            var colorFuente = Auxiliar.Dialogos.SeleccionarColorFuente();

            if (!colorFuente.IsEmpty && RichTxtBox.SelectionFont != null)
                RichTxtBox.SelectionColor = Color.FromName(colorFuente.Name);
        }

        private void ToolStripBntIzquierda_Click(object sender, EventArgs e)
        {
            RichTxtBox.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void ToolStripBtnCentro_Click(object sender, EventArgs e)
        {
            RichTxtBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void ToolStripBtnDerecha_Click(object sender, EventArgs e)
        {
            RichTxtBox.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void CopiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTxtBox.Copy();
        }

        private void CortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTxtBox.Cut();
        }

        private void PegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTxtBox.Paste();
        }

        private void DeshacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTxtBox.Undo();
        }

        private void RehacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTxtBox.Redo();
        }

        private void RichTxtBox_SelectionChanged(object sender, EventArgs e)
        {
            Font fuente = RichTxtBox.SelectionFont;

            if (fuente != null)
            {
                ToolStripCmbFuente.SelectedItem = fuente.Name;
                ToolStripCmbTamanio.SelectedItem = Math.Truncate(fuente.Size).ToString();
            }
        }
    }
}
