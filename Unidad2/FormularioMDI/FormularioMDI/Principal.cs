using System;
using System.Windows.Forms;

namespace FormularioMDI
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void MenuItemHorizontal_Click(object sender, EventArgs e)
        {
            // Distribucion Horizontal
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void MenuItemVertical_Click(object sender, EventArgs e)
        {
            // Distribucion en Vertical
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void MenuItemCascada_Click(object sender, EventArgs e)
        {
            // Ordenamiento en Cascada
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void MenuItemSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuItemClientes_Click(object sender, EventArgs e)
        {
            Form clienteLista = new ClienteLista
            {
                MdiParent = this
            };
            clienteLista.Show();
        }
    }
}
