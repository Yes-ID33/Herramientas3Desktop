namespace wEventosSociales
{
    partial class FormHistorialEventos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistorialEventos));
            this.lblAGENDA = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.volverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcionHistorial = new System.Windows.Forms.TextBox();
            this.btnMostrarEvento = new System.Windows.Forms.Button();
            this.ptbEvento = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgInvitadosHistorial = new System.Windows.Forms.DataGridView();
            this.intCodigoInvitado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intCodigoEvento1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCodigoHistorial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgHistorial = new System.Windows.Forms.DataGridView();
            this.intCodigoHistorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intCodigoEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strUbicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intInvitadosAprox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEvento = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEvento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInvitadosHistorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAGENDA
            // 
            this.lblAGENDA.AutoSize = true;
            this.lblAGENDA.BackColor = System.Drawing.Color.Gray;
            this.lblAGENDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAGENDA.Location = new System.Drawing.Point(195, 47);
            this.lblAGENDA.Name = "lblAGENDA";
            this.lblAGENDA.Size = new System.Drawing.Size(568, 31);
            this.lblAGENDA.TabIndex = 17;
            this.lblAGENDA.Text = "REGISTRO DE HISTORIAL DE EVENTOS";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volverToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1271, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // volverToolStripMenuItem
            // 
            this.volverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarToolStripMenuItem});
            this.volverToolStripMenuItem.Name = "volverToolStripMenuItem";
            this.volverToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.volverToolStripMenuItem.Text = "&Volver";
            this.volverToolStripMenuItem.Click += new System.EventHandler(this.volverToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.cerrarToolStripMenuItem.Text = "&Cerrar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(778, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 28);
            this.label1.TabIndex = 20;
            this.label1.Text = "Invitados:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "Comentarios:";
            // 
            // txtDescripcionHistorial
            // 
            this.txtDescripcionHistorial.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtDescripcionHistorial.Location = new System.Drawing.Point(35, 130);
            this.txtDescripcionHistorial.Multiline = true;
            this.txtDescripcionHistorial.Name = "txtDescripcionHistorial";
            this.txtDescripcionHistorial.Size = new System.Drawing.Size(363, 155);
            this.txtDescripcionHistorial.TabIndex = 22;
            // 
            // btnMostrarEvento
            // 
            this.btnMostrarEvento.BackColor = System.Drawing.Color.Black;
            this.btnMostrarEvento.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMostrarEvento.FlatAppearance.BorderSize = 2;
            this.btnMostrarEvento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan;
            this.btnMostrarEvento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnMostrarEvento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarEvento.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarEvento.ForeColor = System.Drawing.Color.Transparent;
            this.btnMostrarEvento.Location = new System.Drawing.Point(787, 209);
            this.btnMostrarEvento.Name = "btnMostrarEvento";
            this.btnMostrarEvento.Size = new System.Drawing.Size(181, 49);
            this.btnMostrarEvento.TabIndex = 24;
            this.btnMostrarEvento.Text = "Mostrar Evento";
            this.btnMostrarEvento.UseVisualStyleBackColor = false;
            this.btnMostrarEvento.Click += new System.EventHandler(this.btnMostrarEvento_Click);
            // 
            // ptbEvento
            // 
            this.ptbEvento.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ptbEvento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbEvento.Location = new System.Drawing.Point(473, 110);
            this.ptbEvento.Name = "ptbEvento";
            this.ptbEvento.Size = new System.Drawing.Size(265, 195);
            this.ptbEvento.TabIndex = 19;
            this.ptbEvento.TabStop = false;
            this.ptbEvento.Click += new System.EventHandler(this.ptbEvento_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Black;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.BorderSize = 2;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminar.Location = new System.Drawing.Point(1034, 209);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(122, 69);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "ELiminar Historial";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.Black;
            this.txtCodigo.Location = new System.Drawing.Point(1034, 173);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(122, 30);
            this.txtCodigo.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1014, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 39);
            this.label3.TabIndex = 27;
            this.label3.Text = "Ingresa el codigo del historial para eliminarlo:";
            // 
            // dtgInvitadosHistorial
            // 
            this.dtgInvitadosHistorial.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgInvitadosHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgInvitadosHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intCodigoInvitado,
            this.intCodigoEvento1,
            this.strNombre,
            this.strCorreo,
            this.intTelefono});
            this.dtgInvitadosHistorial.Location = new System.Drawing.Point(778, 356);
            this.dtgInvitadosHistorial.Name = "dtgInvitadosHistorial";
            this.dtgInvitadosHistorial.RowHeadersWidth = 51;
            this.dtgInvitadosHistorial.Size = new System.Drawing.Size(481, 172);
            this.dtgInvitadosHistorial.TabIndex = 28;
            // 
            // intCodigoInvitado
            // 
            this.intCodigoInvitado.FillWeight = 85F;
            this.intCodigoInvitado.HeaderText = "ID INVITADO";
            this.intCodigoInvitado.MinimumWidth = 6;
            this.intCodigoInvitado.Name = "intCodigoInvitado";
            // 
            // intCodigoEvento1
            // 
            this.intCodigoEvento1.HeaderText = "ID EVENTO";
            this.intCodigoEvento1.MinimumWidth = 6;
            this.intCodigoEvento1.Name = "intCodigoEvento1";
            this.intCodigoEvento1.Width = 85;
            // 
            // strNombre
            // 
            this.strNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.strNombre.HeaderText = "Nombre";
            this.strNombre.MinimumWidth = 6;
            this.strNombre.Name = "strNombre";
            // 
            // strCorreo
            // 
            this.strCorreo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.strCorreo.HeaderText = "Correo Electronico";
            this.strCorreo.MinimumWidth = 6;
            this.strCorreo.Name = "strCorreo";
            // 
            // intTelefono
            // 
            this.intTelefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.intTelefono.HeaderText = "Telefono";
            this.intTelefono.MinimumWidth = 6;
            this.intTelefono.Name = "intTelefono";
            // 
            // txtCodigoHistorial
            // 
            this.txtCodigoHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoHistorial.ForeColor = System.Drawing.Color.Black;
            this.txtCodigoHistorial.Location = new System.Drawing.Point(819, 173);
            this.txtCodigoHistorial.Name = "txtCodigoHistorial";
            this.txtCodigoHistorial.Size = new System.Drawing.Size(122, 30);
            this.txtCodigoHistorial.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(783, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 43);
            this.label4.TabIndex = 30;
            this.label4.Text = "Ingresa el codigo del historial que quieres mirar:";
            // 
            // dtgHistorial
            // 
            this.dtgHistorial.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intCodigoHistorial,
            this.intCodigoEvento,
            this.datFecha,
            this.datHora,
            this.strUbicacion,
            this.intInvitadosAprox,
            this.strDescripcion});
            this.dtgHistorial.Location = new System.Drawing.Point(12, 356);
            this.dtgHistorial.Name = "dtgHistorial";
            this.dtgHistorial.RowHeadersWidth = 51;
            this.dtgHistorial.Size = new System.Drawing.Size(760, 172);
            this.dtgHistorial.TabIndex = 32;
            this.dtgHistorial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgHistorial_CellContentClick);
            // 
            // intCodigoHistorial
            // 
            this.intCodigoHistorial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.intCodigoHistorial.HeaderText = "ID HISTORIAL";
            this.intCodigoHistorial.MinimumWidth = 6;
            this.intCodigoHistorial.Name = "intCodigoHistorial";
            this.intCodigoHistorial.Width = 95;
            // 
            // intCodigoEvento
            // 
            this.intCodigoEvento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.intCodigoEvento.HeaderText = "ID EVENTO";
            this.intCodigoEvento.MinimumWidth = 6;
            this.intCodigoEvento.Name = "intCodigoEvento";
            this.intCodigoEvento.Width = 83;
            // 
            // datFecha
            // 
            this.datFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datFecha.HeaderText = "Fecha";
            this.datFecha.MinimumWidth = 6;
            this.datFecha.Name = "datFecha";
            // 
            // datHora
            // 
            this.datHora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datHora.HeaderText = "Hora";
            this.datHora.MinimumWidth = 6;
            this.datHora.Name = "datHora";
            // 
            // strUbicacion
            // 
            this.strUbicacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.strUbicacion.HeaderText = "Ubicacion";
            this.strUbicacion.MinimumWidth = 6;
            this.strUbicacion.Name = "strUbicacion";
            // 
            // intInvitadosAprox
            // 
            this.intInvitadosAprox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.intInvitadosAprox.HeaderText = "Invitados Aprox";
            this.intInvitadosAprox.MinimumWidth = 6;
            this.intInvitadosAprox.Name = "intInvitadosAprox";
            this.intInvitadosAprox.Width = 97;
            // 
            // strDescripcion
            // 
            this.strDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.strDescripcion.HeaderText = "Descripcion";
            this.strDescripcion.MinimumWidth = 6;
            this.strDescripcion.Name = "strDescripcion";
            this.strDescripcion.Width = 88;
            // 
            // lblEvento
            // 
            this.lblEvento.AutoSize = true;
            this.lblEvento.BackColor = System.Drawing.Color.Gray;
            this.lblEvento.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvento.Location = new System.Drawing.Point(30, 325);
            this.lblEvento.Name = "lblEvento";
            this.lblEvento.Size = new System.Drawing.Size(90, 28);
            this.lblEvento.TabIndex = 31;
            this.lblEvento.Text = "Eventos:";
            // 
            // FormHistorialEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1271, 582);
            this.Controls.Add(this.dtgHistorial);
            this.Controls.Add(this.lblEvento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCodigoHistorial);
            this.Controls.Add(this.dtgInvitadosHistorial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnMostrarEvento);
            this.Controls.Add(this.txtDescripcionHistorial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptbEvento);
            this.Controls.Add(this.lblAGENDA);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormHistorialEventos";
            this.Text = "FormHistorialEventos";
            this.Load += new System.EventHandler(this.FormHistorialEventos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEvento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInvitadosHistorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAGENDA;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem volverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.PictureBox ptbEvento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcionHistorial;
        private System.Windows.Forms.Button btnMostrarEvento;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgInvitadosHistorial;
        private System.Windows.Forms.TextBox txtCodigoHistorial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgHistorial;
        private System.Windows.Forms.Label lblEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn intCodigoHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn intCodigoEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn datFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn datHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn strUbicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn intInvitadosAprox;
        private System.Windows.Forms.DataGridViewTextBoxColumn strDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn intCodigoInvitado;
        private System.Windows.Forms.DataGridViewTextBoxColumn intCodigoEvento1;
        private System.Windows.Forms.DataGridViewTextBoxColumn strNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn strCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn intTelefono;
    }
}