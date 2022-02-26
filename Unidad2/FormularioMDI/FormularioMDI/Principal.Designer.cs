namespace FormularioMDI
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.MenuItemArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemListas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemVentanas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCascada = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemArchivo,
            this.MenuItemListas,
            this.MenuItemVentanas});
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Size = new System.Drawing.Size(800, 24);
            this.MenuPrincipal.TabIndex = 1;
            this.MenuPrincipal.Text = "Menu principal";
            // 
            // MenuItemArchivo
            // 
            this.MenuItemArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemSalir});
            this.MenuItemArchivo.Name = "MenuItemArchivo";
            this.MenuItemArchivo.Size = new System.Drawing.Size(60, 20);
            this.MenuItemArchivo.Text = "Archivo";
            // 
            // MenuItemSalir
            // 
            this.MenuItemSalir.Name = "MenuItemSalir";
            this.MenuItemSalir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.MenuItemSalir.Size = new System.Drawing.Size(138, 22);
            this.MenuItemSalir.Text = "Salir";
            this.MenuItemSalir.Click += new System.EventHandler(this.MenuItemSalir_Click);
            // 
            // MenuItemListas
            // 
            this.MenuItemListas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemClientes});
            this.MenuItemListas.Name = "MenuItemListas";
            this.MenuItemListas.Size = new System.Drawing.Size(48, 20);
            this.MenuItemListas.Text = "Listas";
            // 
            // MenuItemVentanas
            // 
            this.MenuItemVentanas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemHorizontal,
            this.MenuItemVertical,
            this.MenuItemCascada});
            this.MenuItemVentanas.Name = "MenuItemVentanas";
            this.MenuItemVentanas.Size = new System.Drawing.Size(66, 20);
            this.MenuItemVentanas.Text = "Ventanas";
            // 
            // MenuItemHorizontal
            // 
            this.MenuItemHorizontal.Name = "MenuItemHorizontal";
            this.MenuItemHorizontal.Size = new System.Drawing.Size(129, 22);
            this.MenuItemHorizontal.Text = "Horizontal";
            this.MenuItemHorizontal.Click += new System.EventHandler(this.MenuItemHorizontal_Click);
            // 
            // MenuItemVertical
            // 
            this.MenuItemVertical.Name = "MenuItemVertical";
            this.MenuItemVertical.Size = new System.Drawing.Size(129, 22);
            this.MenuItemVertical.Text = "Vertical";
            this.MenuItemVertical.Click += new System.EventHandler(this.MenuItemVertical_Click);
            // 
            // MenuItemCascada
            // 
            this.MenuItemCascada.Name = "MenuItemCascada";
            this.MenuItemCascada.Size = new System.Drawing.Size(129, 22);
            this.MenuItemCascada.Text = "Cascada";
            this.MenuItemCascada.Click += new System.EventHandler(this.MenuItemCascada_Click);
            // 
            // MenuItemClientes
            // 
            this.MenuItemClientes.Name = "MenuItemClientes";
            this.MenuItemClientes.Size = new System.Drawing.Size(180, 22);
            this.MenuItemClientes.Text = "Clientes";
            this.MenuItemClientes.Click += new System.EventHandler(this.MenuItemClientes_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MenuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuPrincipal;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multiples Formularios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem MenuItemArchivo;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSalir;
        private System.Windows.Forms.ToolStripMenuItem MenuItemListas;
        private System.Windows.Forms.ToolStripMenuItem MenuItemVentanas;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHorizontal;
        private System.Windows.Forms.ToolStripMenuItem MenuItemVertical;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCascada;
        private System.Windows.Forms.ToolStripMenuItem MenuItemClientes;
    }
}

