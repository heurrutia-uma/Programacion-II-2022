using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FormularioMDI
{
    public partial class ClienteLista : Form
    {
        static string fileName;
        static readonly char delimitador = ',';

        public ClienteLista()
        {
            InitializeComponent();
        }

        private void ToolButtonAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = "c:\\",
                RestoreDirectory = true,
                Filter = "CSV files (*.csv)|*.csv",
                Title = "Abrir archivo"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;

                StatusStripBar.Items.Add(fileName);

                CargarDatos();
            }
        }

        private void ToolButtonAgregar_Click(object sender, EventArgs e)
        {
            if (fileName != null)
            {
                Cliente cliente = new Cliente(fileName);
                if (cliente.ShowDialog() == DialogResult.OK)
                    CargarDatos();
            }
        }

        private void ToolButtonEditar_Click(object sender, EventArgs e)
        {
            if (fileName != null)
            {
                int linea = GrdListaClientes.CurrentRow.Index;

                Cliente cliente = new Cliente(fileName, linea);
                if (cliente.ShowDialog() == DialogResult.OK)
                    CargarDatos();
            }
        }

        private void ToolButtonBorrar_Click(object sender, EventArgs e)
        {
            if (fileName != null)
            {
                int linea = GrdListaClientes.CurrentRow.Index;

                List<string> lineas = File.ReadAllLines(fileName).ToList();

                lineas.RemoveAt(linea + 1);

                File.WriteAllLines(fileName, lineas);

                CargarDatos();
            }
        }

        private void CargarDatos()
        {
            GrdListaClientes.Rows.Clear();

            int idx = 0;

            using (StreamReader reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    string[] valor = reader.ReadLine().Split(delimitador);

                    if (idx > 0)
                        GrdListaClientes.Rows.Add(valor);

                    idx++;
                }
            }
        }
    }
}
