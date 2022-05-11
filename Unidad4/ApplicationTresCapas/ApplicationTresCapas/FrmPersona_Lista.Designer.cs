namespace ApplicationTresCapas
{
    partial class FrmPersona_Lista
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
            this.MenuPersonaLista = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.GrdLista = new System.Windows.Forms.DataGridView();
            this.BtnCrear = new System.Windows.Forms.ToolStripButton();
            this.BtnEditar = new System.Windows.Forms.ToolStripButton();
            this.BtnBorrar = new System.Windows.Forms.ToolStripButton();
            this.MenuPersonaLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdLista)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPersonaLista
            // 
            this.MenuPersonaLista.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnCrear,
            this.BtnEditar,
            this.BtnBorrar,
            this.toolStripSeparator1});
            this.MenuPersonaLista.Location = new System.Drawing.Point(0, 0);
            this.MenuPersonaLista.Name = "MenuPersonaLista";
            this.MenuPersonaLista.Size = new System.Drawing.Size(784, 25);
            this.MenuPersonaLista.TabIndex = 0;
            this.MenuPersonaLista.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // GrdLista
            // 
            this.GrdLista.AllowUserToAddRows = false;
            this.GrdLista.AllowUserToDeleteRows = false;
            this.GrdLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdLista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GrdLista.Location = new System.Drawing.Point(0, 25);
            this.GrdLista.Name = "GrdLista";
            this.GrdLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdLista.Size = new System.Drawing.Size(784, 536);
            this.GrdLista.TabIndex = 1;
            // 
            // BtnCrear
            // 
            this.BtnCrear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnCrear.Image = global::ApplicationTresCapas.Properties.Resources.NewFile_16x;
            this.BtnCrear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(23, 22);
            this.BtnCrear.Text = "Crear";
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnEditar.Image = global::ApplicationTresCapas.Properties.Resources.EditDocument_16x;
            this.BtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(23, 22);
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnBorrar.Image = global::ApplicationTresCapas.Properties.Resources.Trash_16x;
            this.BtnBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(23, 22);
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // FrmPersona_Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.GrdLista);
            this.Controls.Add(this.MenuPersonaLista);
            this.Name = "FrmPersona_Lista";
            this.Text = "Personas";
            this.Load += new System.EventHandler(this.FrmPersona_Lista_Load);
            this.MenuPersonaLista.ResumeLayout(false);
            this.MenuPersonaLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip MenuPersonaLista;
        private System.Windows.Forms.ToolStripButton BtnCrear;
        private System.Windows.Forms.ToolStripButton BtnEditar;
        private System.Windows.Forms.ToolStripButton BtnBorrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridView GrdLista;
    }
}