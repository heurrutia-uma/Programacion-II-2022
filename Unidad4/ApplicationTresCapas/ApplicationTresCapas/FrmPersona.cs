using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationTresCapas.LogicaNegocios;
using static ApplicationTresCapas.LogicaNegocios.Modelos;

namespace ApplicationTresCapas
{
    public partial class FrmPersona : Form
    {
        private PersonaAD persona;
        private Persona p;
        private Int64 ID;

        public FrmPersona(Int64 id = -1)
        {
            InitializeComponent();

            persona = new PersonaAD();
            ID = id;
        }

        private void FrmPersona_Load(object sender, EventArgs e)
        {
            if (ID != -1)
            {
                p = persona.ObtenerPersona(ID);

                TxtPrimerNombre.Text = p.PrimerNombre;
                TxtSegundoNombre.Text = p.SegundoNombre;
                TxtPrimerApellido.Text = p.PrimerApellido;
                TxtSegundoApellido.Text = p.SegundoApellido;
                CmbGenero.Text = p.Genero;
            }
            else
                p = new Persona();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (ID != -1)
                p.ID = ID;

            p.PrimerNombre = TxtPrimerNombre.Text;
            p.SegundoNombre = TxtSegundoNombre.Text;
            p.PrimerApellido = TxtPrimerApellido.Text;
            p.SegundoApellido = TxtSegundoApellido.Text;
            p.Genero = CmbGenero.Text;

            p.GuardarRegistro();
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtPrimerNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
