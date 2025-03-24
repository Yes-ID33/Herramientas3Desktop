namespace wEventosSociales
{
    partial class FormCrearEvento
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCrearEvento));
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.cboTipoEvento = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnPlanificacion = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.lblDescripcionEvento = new System.Windows.Forms.Label();
            this.lblAproxInv = new System.Windows.Forms.Label();
            this.txtInvitadosAprox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboNivelEvento = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUbicacion.ForeColor = System.Drawing.Color.Black;
            this.txtUbicacion.Location = new System.Drawing.Point(219, 206);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(211, 30);
            this.txtUbicacion.TabIndex = 0;
            // 
            // cboTipoEvento
            // 
            this.cboTipoEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoEvento.ForeColor = System.Drawing.Color.Black;
            this.cboTipoEvento.FormattingEnabled = true;
            this.cboTipoEvento.Location = new System.Drawing.Point(219, 114);
            this.cboTipoEvento.Name = "cboTipoEvento";
            this.cboTipoEvento.Size = new System.Drawing.Size(211, 33);
            this.cboTipoEvento.TabIndex = 1;
            this.cboTipoEvento.SelectedIndexChanged += new System.EventHandler(this.cboTipoEvento_SelectedIndexChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Gray;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(393, 54);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(262, 31);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "EVENTOS OCASO";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(219, 255);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(343, 30);
            this.dtpFecha.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo de Evento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ubicacion:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Gray;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(129, 257);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(70, 28);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(976, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarToolStripMenuItem1,
            this.salirToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.cerrarToolStripMenuItem.Text = "&Menu";
            // 
            // cerrarToolStripMenuItem1
            // 
            this.cerrarToolStripMenuItem1.Name = "cerrarToolStripMenuItem1";
            this.cerrarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.cerrarToolStripMenuItem1.Text = "&Volver";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "&Cerrar sesion";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem1.Text = "&Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtDescripcion.Location = new System.Drawing.Point(583, 168);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(328, 261);
            this.txtDescripcion.TabIndex = 10;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Black;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatAppearance.BorderSize = 2;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLimpiar.Location = new System.Drawing.Point(265, 486);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(165, 43);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnPlanificacion
            // 
            this.btnPlanificacion.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnPlanificacion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPlanificacion.FlatAppearance.BorderSize = 2;
            this.btnPlanificacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan;
            this.btnPlanificacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnPlanificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanificacion.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanificacion.ForeColor = System.Drawing.Color.Transparent;
            this.btnPlanificacion.Location = new System.Drawing.Point(583, 483);
            this.btnPlanificacion.Name = "btnPlanificacion";
            this.btnPlanificacion.Size = new System.Drawing.Size(169, 46);
            this.btnPlanificacion.TabIndex = 14;
            this.btnPlanificacion.Text = "Planificacion";
            this.btnPlanificacion.UseVisualStyleBackColor = false;
            this.btnPlanificacion.Click += new System.EventHandler(this.btnPlanificacion_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(18, 394);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(154, 153);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Gray;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(135, 306);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(64, 28);
            this.lblHora.TabIndex = 17;
            this.lblHora.Text = "Hora:";
            // 
            // dtpHora
            // 
            this.dtpHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(219, 304);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.ShowUpDown = true;
            this.dtpHora.Size = new System.Drawing.Size(211, 30);
            this.dtpHora.TabIndex = 18;
            // 
            // lblDescripcionEvento
            // 
            this.lblDescripcionEvento.AutoSize = true;
            this.lblDescripcionEvento.BackColor = System.Drawing.Color.Gray;
            this.lblDescripcionEvento.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionEvento.Location = new System.Drawing.Point(588, 119);
            this.lblDescripcionEvento.Name = "lblDescripcionEvento";
            this.lblDescripcionEvento.Size = new System.Drawing.Size(191, 28);
            this.lblDescripcionEvento.TabIndex = 19;
            this.lblDescripcionEvento.Text = "Describe tu evento:";
            this.lblDescripcionEvento.Visible = false;
            // 
            // lblAproxInv
            // 
            this.lblAproxInv.AutoSize = true;
            this.lblAproxInv.BackColor = System.Drawing.Color.Gray;
            this.lblAproxInv.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAproxInv.Location = new System.Drawing.Point(31, 351);
            this.lblAproxInv.Name = "lblAproxInv";
            this.lblAproxInv.Size = new System.Drawing.Size(168, 28);
            this.lblAproxInv.TabIndex = 21;
            this.lblAproxInv.Text = "Invitados Aprox:";
            // 
            // txtInvitadosAprox
            // 
            this.txtInvitadosAprox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvitadosAprox.ForeColor = System.Drawing.Color.Black;
            this.txtInvitadosAprox.Location = new System.Drawing.Point(219, 351);
            this.txtInvitadosAprox.Name = "txtInvitadosAprox";
            this.txtInvitadosAprox.Size = new System.Drawing.Size(211, 30);
            this.txtInvitadosAprox.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 28);
            this.label4.TabIndex = 25;
            this.label4.Text = "Nivel del Evento:";
            // 
            // cboNivelEvento
            // 
            this.cboNivelEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNivelEvento.ForeColor = System.Drawing.Color.Black;
            this.cboNivelEvento.FormattingEnabled = true;
            this.cboNivelEvento.Location = new System.Drawing.Point(219, 159);
            this.cboNivelEvento.Name = "cboNivelEvento";
            this.cboNivelEvento.Size = new System.Drawing.Size(211, 33);
            this.cboNivelEvento.TabIndex = 24;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUsuario.Location = new System.Drawing.Point(898, 4);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 20);
            this.lblUsuario.TabIndex = 26;
            // 
            // FormCrearEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(976, 566);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboNivelEvento);
            this.Controls.Add(this.lblAproxInv);
            this.Controls.Add(this.txtInvitadosAprox);
            this.Controls.Add(this.lblDescripcionEvento);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnPlanificacion);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cboTipoEvento);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormCrearEvento";
            this.Text = "Crear Evento";
            this.Load += new System.EventHandler(this.formCrearEvento_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.ComboBox cboTipoEvento;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem1;
        private System.Windows.Forms.Button btnPlanificacion;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.Label lblDescripcionEvento;
        private System.Windows.Forms.Label lblAproxInv;
        private System.Windows.Forms.TextBox txtInvitadosAprox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboNivelEvento;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.Label lblUsuario;
    }
}

