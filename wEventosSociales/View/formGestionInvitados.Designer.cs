namespace wEventosSociales
{
    partial class FormGestionInvitados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionInvitados));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.volverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtgInvitados = new System.Windows.Forms.DataGridView();
            this.intCodigoInvitado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpiarDatos = new System.Windows.Forms.Button();
            this.btnCargarCorreos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSubirLista = new System.Windows.Forms.Button();
            this.inciarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInvitados)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volverToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // volverToolStripMenuItem
            // 
            this.volverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inciarSesionToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.volverToolStripMenuItem.Name = "volverToolStripMenuItem";
            this.volverToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.volverToolStripMenuItem.Text = "&Menu";
            this.volverToolStripMenuItem.Click += new System.EventHandler(this.volverToolStripMenuItem_Click);
            // 
            // dtgInvitados
            // 
            this.dtgInvitados.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dtgInvitados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgInvitados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intCodigoInvitado,
            this.columNombre,
            this.columCorreo,
            this.columTelefono});
            this.dtgInvitados.Location = new System.Drawing.Point(139, 109);
            this.dtgInvitados.Name = "dtgInvitados";
            this.dtgInvitados.Size = new System.Drawing.Size(528, 244);
            this.dtgInvitados.TabIndex = 1;
            this.dtgInvitados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgInvitados_CellContentClick);
            // 
            // intCodigoInvitado
            // 
            this.intCodigoInvitado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.intCodigoInvitado.HeaderText = "ID";
            this.intCodigoInvitado.Name = "intCodigoInvitado";
            // 
            // columNombre
            // 
            this.columNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columNombre.HeaderText = "Nombre";
            this.columNombre.Name = "columNombre";
            // 
            // columCorreo
            // 
            this.columCorreo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columCorreo.HeaderText = "Correo Electronico";
            this.columCorreo.Name = "columCorreo";
            // 
            // columTelefono
            // 
            this.columTelefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columTelefono.HeaderText = "Telefono";
            this.columTelefono.Name = "columTelefono";
            // 
            // btnLimpiarDatos
            // 
            this.btnLimpiarDatos.BackColor = System.Drawing.Color.Black;
            this.btnLimpiarDatos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLimpiarDatos.FlatAppearance.BorderSize = 2;
            this.btnLimpiarDatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLimpiarDatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btnLimpiarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarDatos.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLimpiarDatos.Location = new System.Drawing.Point(12, 382);
            this.btnLimpiarDatos.Name = "btnLimpiarDatos";
            this.btnLimpiarDatos.Size = new System.Drawing.Size(170, 40);
            this.btnLimpiarDatos.TabIndex = 2;
            this.btnLimpiarDatos.Text = "Limpiar  Datos";
            this.btnLimpiarDatos.UseVisualStyleBackColor = false;
            this.btnLimpiarDatos.Click += new System.EventHandler(this.btnLimpiarDatos_Click_1);
            // 
            // btnCargarCorreos
            // 
            this.btnCargarCorreos.BackColor = System.Drawing.Color.Black;
            this.btnCargarCorreos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCargarCorreos.FlatAppearance.BorderSize = 2;
            this.btnCargarCorreos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Snow;
            this.btnCargarCorreos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaShell;
            this.btnCargarCorreos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarCorreos.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarCorreos.ForeColor = System.Drawing.Color.White;
            this.btnCargarCorreos.Location = new System.Drawing.Point(414, 382);
            this.btnCargarCorreos.Name = "btnCargarCorreos";
            this.btnCargarCorreos.Size = new System.Drawing.Size(172, 40);
            this.btnCargarCorreos.TabIndex = 4;
            this.btnCargarCorreos.Text = "Cargar Correos";
            this.btnCargarCorreos.UseVisualStyleBackColor = false;
            this.btnCargarCorreos.Click += new System.EventHandler(this.btnCargarCorreos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "GESTION DE INVITADOS";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Black;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAgregar.FlatAppearance.BorderSize = 2;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Ivory;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnAgregar.Location = new System.Drawing.Point(204, 382);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(172, 40);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSubirLista
            // 
            this.btnSubirLista.BackColor = System.Drawing.Color.Black;
            this.btnSubirLista.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSubirLista.FlatAppearance.BorderSize = 2;
            this.btnSubirLista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan;
            this.btnSubirLista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnSubirLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubirLista.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubirLista.ForeColor = System.Drawing.Color.Tan;
            this.btnSubirLista.Location = new System.Drawing.Point(615, 382);
            this.btnSubirLista.Name = "btnSubirLista";
            this.btnSubirLista.Size = new System.Drawing.Size(172, 40);
            this.btnSubirLista.TabIndex = 7;
            this.btnSubirLista.Text = "Subir Lista";
            this.btnSubirLista.UseVisualStyleBackColor = false;
            this.btnSubirLista.Click += new System.EventHandler(this.btnSubirLista_Click);
            // 
            // inciarSesionToolStripMenuItem
            // 
            this.inciarSesionToolStripMenuItem.Name = "inciarSesionToolStripMenuItem";
            this.inciarSesionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inciarSesionToolStripMenuItem.Text = "&Volver";
            this.inciarSesionToolStripMenuItem.Click += new System.EventHandler(this.inciarSesionToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarSesionToolStripMenuItem.Text = "&Cerrar sesion";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // FormGestionInvitados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubirLista);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCargarCorreos);
            this.Controls.Add(this.btnLimpiarDatos);
            this.Controls.Add(this.dtgInvitados);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormGestionInvitados";
            this.Text = "formGestionInvitados";
            this.Load += new System.EventHandler(this.FormGestionInvitados_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInvitados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem volverToolStripMenuItem;
        private System.Windows.Forms.DataGridView dtgInvitados;
        private System.Windows.Forms.Button btnLimpiarDatos;
        private System.Windows.Forms.Button btnCargarCorreos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSubirLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn intCodigoInvitado;
        private System.Windows.Forms.DataGridViewTextBoxColumn columNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn columCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columTelefono;
        private System.Windows.Forms.ToolStripMenuItem inciarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}