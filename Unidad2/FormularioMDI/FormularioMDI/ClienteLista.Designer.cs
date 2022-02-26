namespace FormularioMDI
{
    partial class ClienteLista
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
            this.BarraHerramientas = new System.Windows.Forms.ToolStrip();
            this.ToolButtonAbrir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolButtonAgregar = new System.Windows.Forms.ToolStripButton();
            this.ToolButtonEditar = new System.Windows.Forms.ToolStripButton();
            this.ToolButtonBorrar = new System.Windows.Forms.ToolStripButton();
            this.GrdListaClientes = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusStripBar = new System.Windows.Forms.StatusStrip();
            this.BarraHerramientas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdListaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraHerramientas
            // 
            this.BarraHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolButtonAbrir,
            this.toolStripSeparator1,
            this.ToolButtonAgregar,
            this.ToolButtonEditar,
            this.ToolButtonBorrar});
            this.BarraHerramientas.Location = new System.Drawing.Point(0, 0);
            this.BarraHerramientas.Name = "BarraHerramientas";
            this.BarraHerramientas.Size = new System.Drawing.Size(584, 25);
            this.BarraHerramientas.TabIndex = 0;
            this.BarraHerramientas.Text = "MenuHerramientas";
            // 
            // ToolButtonAbrir
            // 
            this.ToolButtonAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolButtonAbrir.Image = global::FormularioMDI.Properties.Resources.OpenFile_16x;
            this.ToolButtonAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolButtonAbrir.Name = "ToolButtonAbrir";
            this.ToolButtonAbrir.Size = new System.Drawing.Size(23, 22);
            this.ToolButtonAbrir.Text = "Abrir Archivo";
            this.ToolButtonAbrir.Click += new System.EventHandler(this.ToolButtonAbrir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolButtonAgregar
            // 
            this.ToolButtonAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolButtonAgregar.Image = global::FormularioMDI.Properties.Resources.AddRow_16x;
            this.ToolButtonAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolButtonAgregar.Name = "ToolButtonAgregar";
            this.ToolButtonAgregar.Size = new System.Drawing.Size(23, 22);
            this.ToolButtonAgregar.Text = "Agregar registro";
            this.ToolButtonAgregar.Click += new System.EventHandler(this.ToolButtonAgregar_Click);
            // 
            // ToolButtonEditar
            // 
            this.ToolButtonEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolButtonEditar.Image = global::FormularioMDI.Properties.Resources.EditRowLeft_16x;
            this.ToolButtonEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolButtonEditar.Name = "ToolButtonEditar";
            this.ToolButtonEditar.Size = new System.Drawing.Size(23, 22);
            this.ToolButtonEditar.Text = "Editar registro";
            this.ToolButtonEditar.Click += new System.EventHandler(this.ToolButtonEditar_Click);
            // 
            // ToolButtonBorrar
            // 
            this.ToolButtonBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolButtonBorrar.Image = global::FormularioMDI.Properties.Resources.RemoveRow_16x;
            this.ToolButtonBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolButtonBorrar.Name = "ToolButtonBorrar";
            this.ToolButtonBorrar.Size = new System.Drawing.Size(23, 22);
            this.ToolButtonBorrar.Text = "Borrar registro";
            this.ToolButtonBorrar.Click += new System.EventHandler(this.ToolButtonBorrar_Click);
            // 
            // GrdListaClientes
            // 
            this.GrdListaClientes.AllowUserToAddRows = false;
            this.GrdListaClientes.AllowUserToDeleteRows = false;
            this.GrdListaClientes.AllowUserToResizeRows = false;
            this.GrdListaClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdListaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.Email});
            this.GrdListaClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GrdListaClientes.Location = new System.Drawing.Point(0, 25);
            this.GrdListaClientes.MultiSelect = false;
            this.GrdListaClientes.Name = "GrdListaClientes";
            this.GrdListaClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.GrdListaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdListaClientes.Size = new System.Drawing.Size(584, 311);
            this.GrdListaClientes.TabIndex = 1;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // StatusStripBar
            // 
            this.StatusStripBar.Location = new System.Drawing.Point(0, 339);
            this.StatusStripBar.Name = "StatusStripBar";
            this.StatusStripBar.Size = new System.Drawing.Size(584, 22);
            this.StatusStripBar.TabIndex = 2;
            this.StatusStripBar.Text = "statusStrip1";
            // 
            // ClienteLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.StatusStripBar);
            this.Controls.Add(this.GrdListaClientes);
            this.Controls.Add(this.BarraHerramientas);
            this.Name = "ClienteLista";
            this.Text = "Lista de Clientes";
            this.BarraHerramientas.ResumeLayout(false);
            this.BarraHerramientas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdListaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip BarraHerramientas;
        private System.Windows.Forms.ToolStripButton ToolButtonAbrir;
        private System.Windows.Forms.DataGridView GrdListaClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.ToolStripButton ToolButtonAgregar;
        private System.Windows.Forms.ToolStripButton ToolButtonEditar;
        private System.Windows.Forms.ToolStripButton ToolButtonBorrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.StatusStrip StatusStripBar;
    }
}