using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FormularioMDI
{
    public partial class Cliente : Form
    {
        static readonly char delimitador = ',';
        static string fileName;
        static int row;

        public Cliente(string _fileName, int _row = -1)
        {
            InitializeComponent();

            fileName = _fileName;
            row = _row;

            if (row != -1)
            {
                row++;
                MotrarRegistro();
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtNombre.Text) && !String.IsNullOrEmpty(TxtApellido.Text) && !String.IsNullOrEmpty(TxtEmail.Text))
            {
                if (row == -1)
                {
                    File.AppendAllText(fileName, $"{TxtNombre.Text}{delimitador}{TxtApellido.Text}{delimitador}{TxtEmail.Text}{Environment.NewLine}");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    List<string> lineas = File.ReadAllLines(fileName).ToList();

                    lineas[row] = $"{TxtNombre.Text}{delimitador}{TxtApellido.Text}{delimitador}{TxtEmail.Text}";

                    File.WriteAllLines(fileName, lineas);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void MotrarRegistro()
        {
            List<string> lineas = File.ReadAllLines(fileName).ToList();
            string[] valor = lineas[row].Split(delimitador);

            if (valor.Length == 3)
            {
                TxtNombre.Text = valor[0];
                TxtApellido.Text = valor[1];
                TxtEmail.Text = valor[2];
            }
        }
    }
}
