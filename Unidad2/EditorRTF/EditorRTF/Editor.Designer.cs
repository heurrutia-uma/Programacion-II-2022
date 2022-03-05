namespace EditorRTF
{
    partial class Editor
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
            this.components = new System.ComponentModel.Container();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSalir = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolEdicion = new System.Windows.Forms.ToolStrip();
            this.ToolStripCmbFuente = new System.Windows.Forms.ToolStripComboBox();
            this.ToolStripCmbTamanio = new System.Windows.Forms.ToolStripComboBox();
            this.ToolStripBtnNegrita = new System.Windows.Forms.ToolStripButton();
            this.ToolStripBtnItalica = new System.Windows.Forms.ToolStripButton();
            this.ToolStripBtnSubrayado = new System.Windows.Forms.ToolStripButton();
            this.ToolStripBtnColor = new System.Windows.Forms.ToolStripButton();
            this.ToolStripBntIzquierda = new System.Windows.Forms.ToolStripButton();
            this.ToolStripBtnCentro = new System.Windows.Forms.ToolStripButton();
            this.ToolStripBtnDerecha = new System.Windows.Forms.ToolStripButton();
            this.ToolArchivo = new System.Windows.Forms.ToolStrip();
            this.ToolStripNuevo = new System.Windows.Forms.ToolStripButton();
            this.ToolStripAbrir = new System.Windows.Forms.ToolStripButton();
            this.ToolStripGuardarComo = new System.Windows.Forms.ToolStripButton();
            this.RichTxtBox = new System.Windows.Forms.RichTextBox();
            this.ContextMenuEdicion = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CopiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.DeshacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RehacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolEdicion.SuspendLayout();
            this.ToolArchivo.SuspendLayout();
            this.ContextMenuEdicion.SuspendLayout();
            this.MenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSalir
            // 
            this.toolStripSalir.Name = "toolStripSalir";
            this.toolStripSalir.Size = new System.Drawing.Size(29, 22);
            this.toolStripSalir.Text = "Salir";
            this.toolStripSalir.Click += new System.EventHandler(this.ToolStripSalir_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolEdicion
            // 
            this.ToolEdicion.Dock = System.Windows.Forms.DockStyle.None;
            this.ToolEdicion.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolEdicion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripCmbFuente,
            this.ToolStripCmbTamanio,
            this.ToolStripBtnNegrita,
            this.ToolStripBtnItalica,
            this.ToolStripBtnSubrayado,
            this.ToolStripBtnColor,
            this.ToolStripBntIzquierda,
            this.ToolStripBtnCentro,
            this.ToolStripBtnDerecha});
            this.ToolEdicion.Location = new System.Drawing.Point(122, 24);
            this.ToolEdicion.Name = "ToolEdicion";
            this.ToolEdicion.Size = new System.Drawing.Size(409, 27);
            this.ToolEdicion.TabIndex = 7;
            this.ToolEdicion.Text = "toolStrip1";
            // 
            // ToolStripCmbFuente
            // 
            this.ToolStripCmbFuente.Name = "ToolStripCmbFuente";
            this.ToolStripCmbFuente.Size = new System.Drawing.Size(150, 27);
            this.ToolStripCmbFuente.Text = "Fuente";
            this.ToolStripCmbFuente.ToolTipText = "Fuente";
            this.ToolStripCmbFuente.SelectedIndexChanged += new System.EventHandler(this.ToolStripCmbFuente_SelectedIndexChanged);
            // 
            // ToolStripCmbTamanio
            // 
            this.ToolStripCmbTamanio.Name = "ToolStripCmbTamanio";
            this.ToolStripCmbTamanio.Size = new System.Drawing.Size(75, 27);
            this.ToolStripCmbTamanio.Text = "Tamaño";
            this.ToolStripCmbTamanio.ToolTipText = "Tamaño";
            this.ToolStripCmbTamanio.SelectedIndexChanged += new System.EventHandler(this.ToolStripCmbTamanio_SelectedIndexChanged);
            // 
            // ToolStripBtnNegrita
            // 
            this.ToolStripBtnNegrita.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripBtnNegrita.Image = global::EditorRTF.Properties.Resources.Bold_16x;
            this.ToolStripBtnNegrita.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripBtnNegrita.Name = "ToolStripBtnNegrita";
            this.ToolStripBtnNegrita.Size = new System.Drawing.Size(24, 24);
            this.ToolStripBtnNegrita.Text = "Negrita";
            this.ToolStripBtnNegrita.Click += new System.EventHandler(this.ToolStripBtnNegrita_Click);
            // 
            // ToolStripBtnItalica
            // 
            this.ToolStripBtnItalica.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripBtnItalica.Image = global::EditorRTF.Properties.Resources.Italic_16x;
            this.ToolStripBtnItalica.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripBtnItalica.Name = "ToolStripBtnItalica";
            this.ToolStripBtnItalica.Size = new System.Drawing.Size(24, 24);
            this.ToolStripBtnItalica.Text = "Italica";
            this.ToolStripBtnItalica.Click += new System.EventHandler(this.ToolStripBtnItalica_Click);
            // 
            // ToolStripBtnSubrayado
            // 
            this.ToolStripBtnSubrayado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripBtnSubrayado.Image = global::EditorRTF.Properties.Resources.Underline_16x;
            this.ToolStripBtnSubrayado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripBtnSubrayado.Name = "ToolStripBtnSubrayado";
            this.ToolStripBtnSubrayado.Size = new System.Drawing.Size(24, 24);
            this.ToolStripBtnSubrayado.Text = "Subrayado";
            this.ToolStripBtnSubrayado.Click += new System.EventHandler(this.ToolStripBtnSubrayado_Click);
            // 
            // ToolStripBtnColor
            // 
            this.ToolStripBtnColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripBtnColor.Image = global::EditorRTF.Properties.Resources.FontColor_16x;
            this.ToolStripBtnColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripBtnColor.Name = "ToolStripBtnColor";
            this.ToolStripBtnColor.Size = new System.Drawing.Size(24, 24);
            this.ToolStripBtnColor.Text = "Color";
            this.ToolStripBtnColor.Click += new System.EventHandler(this.ToolStripBtnColor_Click);
            // 
            // ToolStripBntIzquierda
            // 
            this.ToolStripBntIzquierda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripBntIzquierda.Image = global::EditorRTF.Properties.Resources.TextLeftJustify_16x;
            this.ToolStripBntIzquierda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripBntIzquierda.Name = "ToolStripBntIzquierda";
            this.ToolStripBntIzquierda.Size = new System.Drawing.Size(24, 24);
            this.ToolStripBntIzquierda.Text = "Justificado Izquierda";
            this.ToolStripBntIzquierda.Click += new System.EventHandler(this.ToolStripBntIzquierda_Click);
            // 
            // ToolStripBtnCentro
            // 
            this.ToolStripBtnCentro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripBtnCentro.Image = global::EditorRTF.Properties.Resources.TextCenter_16x;
            this.ToolStripBtnCentro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripBtnCentro.Name = "ToolStripBtnCentro";
            this.ToolStripBtnCentro.Size = new System.Drawing.Size(24, 24);
            this.ToolStripBtnCentro.Text = "Justificación Centro";
            this.ToolStripBtnCentro.Click += new System.EventHandler(this.ToolStripBtnCentro_Click);
            // 
            // ToolStripBtnDerecha
            // 
            this.ToolStripBtnDerecha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripBtnDerecha.Image = global::EditorRTF.Properties.Resources.TextRightJustify_16x;
            this.ToolStripBtnDerecha.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripBtnDerecha.Name = "ToolStripBtnDerecha";
            this.ToolStripBtnDerecha.Size = new System.Drawing.Size(24, 24);
            this.ToolStripBtnDerecha.Text = "Justificado Derecha";
            this.ToolStripBtnDerecha.Click += new System.EventHandler(this.ToolStripBtnDerecha_Click);
            // 
            // ToolArchivo
            // 
            this.ToolArchivo.Dock = System.Windows.Forms.DockStyle.None;
            this.ToolArchivo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripNuevo,
            this.ToolStripAbrir,
            this.ToolStripGuardarComo,
            this.toolStripSeparator1,
            this.toolStripSalir,
            this.toolStripSeparator2});
            this.ToolArchivo.Location = new System.Drawing.Point(0, 24);
            this.ToolArchivo.Name = "ToolArchivo";
            this.ToolArchivo.Size = new System.Drawing.Size(122, 25);
            this.ToolArchivo.TabIndex = 6;
            this.ToolArchivo.Text = "toolStrip1";
            // 
            // ToolStripNuevo
            // 
            this.ToolStripNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripNuevo.Image = global::EditorRTF.Properties.Resources.NewFile_16x;
            this.ToolStripNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripNuevo.Name = "ToolStripNuevo";
            this.ToolStripNuevo.Size = new System.Drawing.Size(23, 22);
            this.ToolStripNuevo.Text = "Nuevo";
            this.ToolStripNuevo.ToolTipText = "Nuevo";
            this.ToolStripNuevo.Click += new System.EventHandler(this.ToolStripNuevo_Click);
            // 
            // ToolStripAbrir
            // 
            this.ToolStripAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripAbrir.Image = global::EditorRTF.Properties.Resources.OpenFile_16x;
            this.ToolStripAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripAbrir.Name = "ToolStripAbrir";
            this.ToolStripAbrir.Size = new System.Drawing.Size(23, 22);
            this.ToolStripAbrir.Text = "Abrir";
            this.ToolStripAbrir.ToolTipText = "Abrir";
            this.ToolStripAbrir.Click += new System.EventHandler(this.ToolStripAbrir_Click);
            // 
            // ToolStripGuardarComo
            // 
            this.ToolStripGuardarComo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripGuardarComo.Image = global::EditorRTF.Properties.Resources.SaveAs_16x;
            this.ToolStripGuardarComo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripGuardarComo.Name = "ToolStripGuardarComo";
            this.ToolStripGuardarComo.Size = new System.Drawing.Size(23, 22);
            this.ToolStripGuardarComo.Text = "Guardar Como";
            this.ToolStripGuardarComo.ToolTipText = "Guardar Como...";
            this.ToolStripGuardarComo.Click += new System.EventHandler(this.ToolStripGuardarComo_Click);
            // 
            // RichTxtBox
            // 
            this.RichTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RichTxtBox.ContextMenuStrip = this.ContextMenuEdicion;
            this.RichTxtBox.Location = new System.Drawing.Point(0, 52);
            this.RichTxtBox.Name = "RichTxtBox";
            this.RichTxtBox.Size = new System.Drawing.Size(784, 509);
            this.RichTxtBox.TabIndex = 5;
            this.RichTxtBox.Text = "";
            this.RichTxtBox.SelectionChanged += new System.EventHandler(this.RichTxtBox_SelectionChanged);
            // 
            // ContextMenuEdicion
            // 
            this.ContextMenuEdicion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopiarToolStripMenuItem,
            this.CortarToolStripMenuItem,
            this.PegarToolStripMenuItem,
            this.toolStripMenuItem2,
            this.DeshacerToolStripMenuItem,
            this.RehacerToolStripMenuItem});
            this.ContextMenuEdicion.Name = "ContextMenuEdicion";
            this.ContextMenuEdicion.Size = new System.Drawing.Size(123, 120);
            // 
            // CopiarToolStripMenuItem
            // 
            this.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem";
            this.CopiarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CopiarToolStripMenuItem.Text = "Copiar";
            this.CopiarToolStripMenuItem.Click += new System.EventHandler(this.CopiarToolStripMenuItem_Click);
            // 
            // CortarToolStripMenuItem
            // 
            this.CortarToolStripMenuItem.Name = "CortarToolStripMenuItem";
            this.CortarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CortarToolStripMenuItem.Text = "Cortar";
            this.CortarToolStripMenuItem.Click += new System.EventHandler(this.CortarToolStripMenuItem_Click);
            // 
            // PegarToolStripMenuItem
            // 
            this.PegarToolStripMenuItem.Name = "PegarToolStripMenuItem";
            this.PegarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.PegarToolStripMenuItem.Text = "Pegar";
            this.PegarToolStripMenuItem.Click += new System.EventHandler(this.PegarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(119, 6);
            // 
            // DeshacerToolStripMenuItem
            // 
            this.DeshacerToolStripMenuItem.Name = "DeshacerToolStripMenuItem";
            this.DeshacerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DeshacerToolStripMenuItem.Text = "Deshacer";
            this.DeshacerToolStripMenuItem.Click += new System.EventHandler(this.DeshacerToolStripMenuItem_Click);
            // 
            // RehacerToolStripMenuItem
            // 
            this.RehacerToolStripMenuItem.Name = "RehacerToolStripMenuItem";
            this.RehacerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.RehacerToolStripMenuItem.Text = "Rehacer";
            this.RehacerToolStripMenuItem.Click += new System.EventHandler(this.RehacerToolStripMenuItem_Click);
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Size = new System.Drawing.Size(784, 24);
            this.MenuPrincipal.TabIndex = 4;
            this.MenuPrincipal.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.guardarComoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Image = global::EditorRTF.Properties.Resources.NewFile_16x;
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.nuevoToolStripMenuItem.Text = "&Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.NuevoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Image = global::EditorRTF.Properties.Resources.OpenFile_16x;
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.abrirToolStripMenuItem.Text = "A&brir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.AbrirToolStripMenuItem_Click);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Image = global::EditorRTF.Properties.Resources.SaveAs_16x;
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.guardarComoToolStripMenuItem.Text = "&Guardar Como...";
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.guardarComoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(198, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::EditorRTF.Properties.Resources.Close_16x;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ToolEdicion);
            this.Controls.Add(this.ToolArchivo);
            this.Controls.Add(this.RichTxtBox);
            this.Controls.Add(this.MenuPrincipal);
            this.Name = "Editor";
            this.Text = "Editor RTF";
            this.Load += new System.EventHandler(this.Editor_Load);
            this.ToolEdicion.ResumeLayout(false);
            this.ToolEdicion.PerformLayout();
            this.ToolArchivo.ResumeLayout(false);
            this.ToolArchivo.PerformLayout();
            this.ContextMenuEdicion.ResumeLayout(false);
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton ToolStripBtnCentro;
        private System.Windows.Forms.ToolStripButton ToolStripNuevo;
        private System.Windows.Forms.ToolStripButton ToolStripAbrir;
        private System.Windows.Forms.ToolStripButton ToolStripGuardarComo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripSalir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStrip ToolEdicion;
        private System.Windows.Forms.ToolStripComboBox ToolStripCmbFuente;
        private System.Windows.Forms.ToolStripComboBox ToolStripCmbTamanio;
        private System.Windows.Forms.ToolStripButton ToolStripBtnNegrita;
        private System.Windows.Forms.ToolStripButton ToolStripBtnItalica;
        private System.Windows.Forms.ToolStripButton ToolStripBtnSubrayado;
        private System.Windows.Forms.ToolStripButton ToolStripBtnColor;
        private System.Windows.Forms.ToolStripButton ToolStripBntIzquierda;
        private System.Windows.Forms.ToolStripButton ToolStripBtnDerecha;
        private System.Windows.Forms.ToolStrip ToolArchivo;
        private System.Windows.Forms.RichTextBox RichTxtBox;
        private System.Windows.Forms.ContextMenuStrip ContextMenuEdicion;
        private System.Windows.Forms.ToolStripMenuItem CopiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem DeshacerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RehacerToolStripMenuItem;
        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}

