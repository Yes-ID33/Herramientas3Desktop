namespace wEventosSociales
{
    partial class FormListaTareas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaTareas));
            this.btnLimpiarLista = new System.Windows.Forms.Button();
            this.lblAGENDA = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.volverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtgListaIndicaciones = new System.Windows.Forms.DataGridView();
            this.btnCargarIndicaciones = new System.Windows.Forms.Button();
            this.ColumnIndicaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaIndicaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiarLista
            // 
            this.btnLimpiarLista.BackColor = System.Drawing.Color.Black;
            this.btnLimpiarLista.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLimpiarLista.FlatAppearance.BorderSize = 2;
            this.btnLimpiarLista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLimpiarLista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btnLimpiarLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarLista.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarLista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLimpiarLista.Location = new System.Drawing.Point(81, 382);
            this.btnLimpiarLista.Name = "btnLimpiarLista";
            this.btnLimpiarLista.Size = new System.Drawing.Size(144, 43);
            this.btnLimpiarLista.TabIndex = 20;
            this.btnLimpiarLista.Text = "Limpiar Lista";
            this.btnLimpiarLista.UseVisualStyleBackColor = false;
            this.btnLimpiarLista.Click += new System.EventHandler(this.btnLimpiarLista_Click);
            // 
            // lblAGENDA
            // 
            this.lblAGENDA.AutoSize = true;
            this.lblAGENDA.BackColor = System.Drawing.Color.Gray;
            this.lblAGENDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAGENDA.Location = new System.Drawing.Point(218, 43);
            this.lblAGENDA.Name = "lblAGENDA";
            this.lblAGENDA.Size = new System.Drawing.Size(362, 31);
            this.lblAGENDA.TabIndex = 16;
            this.lblAGENDA.Text = "LISTA DE INDICACIONES";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volverToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // volverToolStripMenuItem
            // 
            this.volverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.volverToolStripMenuItem.Name = "volverToolStripMenuItem";
            this.volverToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.volverToolStripMenuItem.Text = "&Menu";
            this.volverToolStripMenuItem.Click += new System.EventHandler(this.volverToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.cerrarToolStripMenuItem.Text = "&Volver";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.cerrarSesionToolStripMenuItem.Text = "&Cerrar sesion";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.BorderSize = 2;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Tan;
            this.btnGuardar.Location = new System.Drawing.Point(557, 382);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(143, 43);
            this.btnGuardar.TabIndex = 25;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dtgListaIndicaciones
            // 
            this.dtgListaIndicaciones.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgListaIndicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListaIndicaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIndicaciones});
            this.dtgListaIndicaciones.Location = new System.Drawing.Point(126, 95);
            this.dtgListaIndicaciones.Name = "dtgListaIndicaciones";
            this.dtgListaIndicaciones.RowHeadersWidth = 51;
            this.dtgListaIndicaciones.Size = new System.Drawing.Size(540, 257);
            this.dtgListaIndicaciones.TabIndex = 26;
            // 
            // btnCargarIndicaciones
            // 
            this.btnCargarIndicaciones.BackColor = System.Drawing.Color.Black;
            this.btnCargarIndicaciones.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCargarIndicaciones.FlatAppearance.BorderSize = 2;
            this.btnCargarIndicaciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Snow;
            this.btnCargarIndicaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaShell;
            this.btnCargarIndicaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarIndicaciones.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarIndicaciones.ForeColor = System.Drawing.Color.White;
            this.btnCargarIndicaciones.Location = new System.Drawing.Point(317, 382);
            this.btnCargarIndicaciones.Name = "btnCargarIndicaciones";
            this.btnCargarIndicaciones.Size = new System.Drawing.Size(163, 43);
            this.btnCargarIndicaciones.TabIndex = 27;
            this.btnCargarIndicaciones.Text = "Cargar Indicaciones";
            this.btnCargarIndicaciones.UseVisualStyleBackColor = false;
            this.btnCargarIndicaciones.Click += new System.EventHandler(this.btnCargarTareas_Click);
            // 
            // ColumnIndicaciones
            // 
            this.ColumnIndicaciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnIndicaciones.HeaderText = "Indicaciones a tener en cuenta";
            this.ColumnIndicaciones.MinimumWidth = 6;
            this.ColumnIndicaciones.Name = "ColumnIndicaciones";
            // 
            // FormListaTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCargarIndicaciones);
            this.Controls.Add(this.dtgListaIndicaciones);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiarLista);
            this.Controls.Add(this.lblAGENDA);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormListaTareas";
            this.Load += new System.EventHandler(this.FormListaTareas_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaIndicaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLimpiarLista;
        private System.Windows.Forms.Label lblAGENDA;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem volverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dtgListaIndicaciones;
        private System.Windows.Forms.Button btnCargarIndicaciones;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIndicaciones;
    }
}