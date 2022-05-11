using ApplicationTresCapas.LogicaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ApplicationTresCapas.LogicaNegocios.Modelos;

namespace ApplicationTresCapas
{
    public partial class FrmPersona_Lista : Form
    {
        PersonaAD personaAD; 

        public FrmPersona_Lista()
        {
            InitializeComponent();

            personaAD = new PersonaAD();
        }

        private void FrmPersona_Lista_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            GrdLista.DataSource = personaAD.ListaPersona();
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            FrmPersona frmPersona = new FrmPersona();
            frmPersona.ShowDialog();
            CargarDatos();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Int64 id = ObtenerID();

            FrmPersona frmPersona = new FrmPersona(id);
            frmPersona.ShowDialog();
            CargarDatos();
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            Int64 id = ObtenerID();
     
            Persona p = personaAD.ObtenerPersona(id);
            p.BorrarRegistro();
            CargarDatos();
        }

        private DataGridViewRow ObtenerRegistroSeleccionado()
        {
            return GrdLista.CurrentRow;
        }

        private Int64 ObtenerID()
        {
            return Convert.ToInt64(ObtenerRegistroSeleccionado().Cells["ID"].Value);
        }
    }
}
