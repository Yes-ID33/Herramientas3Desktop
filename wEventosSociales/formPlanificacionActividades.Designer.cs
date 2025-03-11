namespace wEventosSociales
{
    partial class FormPlanificacionActividades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlanificacionActividades));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.volverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvActividades = new System.Windows.Forms.DataGridView();
            this.columActividades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columUbicaion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblActividades = new System.Windows.Forms.Label();
            this.lblAGENDA = new System.Windows.Forms.Label();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.dtpHoraActividades = new System.Windows.Forms.DateTimePicker();
            this.lblHora = new System.Windows.Forms.Label();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnCargarCampos = new System.Windows.Forms.Button();
            this.cboUbicacion = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnGuardarActividades = new System.Windows.Forms.Button();
            this.cboActividades = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).BeginInit();
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
            this.volverToolStripMenuItem.Name = "volverToolStripMenuItem";
            this.volverToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.volverToolStripMenuItem.Text = "&Volver";
            this.volverToolStripMenuItem.Click += new System.EventHandler(this.volverToolStripMenuItem_Click);
            // 
            // dgvActividades
            // 
            this.dgvActividades.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActividades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columActividades,
            this.columUbicaion,
            this.columHora});
            this.dgvActividades.Location = new System.Drawing.Point(81, 208);
            this.dgvActividades.Name = "dgvActividades";
            this.dgvActividades.Size = new System.Drawing.Size(622, 172);
            this.dgvActividades.TabIndex = 1;
            this.dgvActividades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActividades_CellContentClick);
            // 
            // columActividades
            // 
            this.columActividades.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columActividades.HeaderText = "Actividades";
            this.columActividades.Name = "columActividades";
            // 
            // columUbicaion
            // 
            this.columUbicaion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columUbicaion.HeaderText = "Ubicacion";
            this.columUbicaion.Name = "columUbicaion";
            // 
            // columHora
            // 
            this.columHora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columHora.HeaderText = "Hora";
            this.columHora.Name = "columHora";
            // 
            // lblActividades
            // 
            this.lblActividades.AutoSize = true;
            this.lblActividades.BackColor = System.Drawing.Color.Gray;
            this.lblActividades.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActividades.Location = new System.Drawing.Point(92, 84);
            this.lblActividades.Name = "lblActividades";
            this.lblActividades.Size = new System.Drawing.Size(126, 28);
            this.lblActividades.TabIndex = 3;
            this.lblActividades.Text = "Actividades:";
            // 
            // lblAGENDA
            // 
            this.lblAGENDA.AutoSize = true;
            this.lblAGENDA.BackColor = System.Drawing.Color.Gray;
            this.lblAGENDA.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAGENDA.Location = new System.Drawing.Point(225, 34);
            this.lblAGENDA.Name = "lblAGENDA";
            this.lblAGENDA.Size = new System.Drawing.Size(264, 28);
            this.lblAGENDA.TabIndex = 5;
            this.lblAGENDA.Text = "AGENDA DE ACTIVIDADES";
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.BackColor = System.Drawing.Color.Gray;
            this.lblUbicacion.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUbicacion.Location = new System.Drawing.Point(107, 144);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(109, 28);
            this.lblUbicacion.TabIndex = 6;
            this.lblUbicacion.Text = "Ubicacion:";
            // 
            // dtpHoraActividades
            // 
            this.dtpHoraActividades.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraActividades.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraActividades.Location = new System.Drawing.Point(495, 118);
            this.dtpHoraActividades.Name = "dtpHoraActividades";
            this.dtpHoraActividades.ShowUpDown = true;
            this.dtpHoraActividades.Size = new System.Drawing.Size(177, 30);
            this.dtpHoraActividades.TabIndex = 7;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Gray;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(420, 118);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(64, 28);
            this.lblHora.TabIndex = 8;
            this.lblHora.Text = "Hora:";
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackColor = System.Drawing.Color.Black;
            this.btnLimpiarCampos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLimpiarCampos.FlatAppearance.BorderSize = 2;
            this.btnLimpiarCampos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLimpiarCampos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLimpiarCampos.Location = new System.Drawing.Point(23, 386);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(179, 40);
            this.btnLimpiarCampos.TabIndex = 9;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnCargarCampos
            // 
            this.btnCargarCampos.BackColor = System.Drawing.Color.Black;
            this.btnCargarCampos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCargarCampos.FlatAppearance.BorderSize = 2;
            this.btnCargarCampos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Snow;
            this.btnCargarCampos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaShell;
            this.btnCargarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarCampos.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarCampos.ForeColor = System.Drawing.Color.White;
            this.btnCargarCampos.Location = new System.Drawing.Point(404, 386);
            this.btnCargarCampos.Name = "btnCargarCampos";
            this.btnCargarCampos.Size = new System.Drawing.Size(179, 40);
            this.btnCargarCampos.TabIndex = 11;
            this.btnCargarCampos.Text = "Cargar Campos";
            this.btnCargarCampos.UseVisualStyleBackColor = false;
            this.btnCargarCampos.Click += new System.EventHandler(this.btnCargarCampos_Click);
            // 
            // cboUbicacion
            // 
            this.cboUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUbicacion.FormattingEnabled = true;
            this.cboUbicacion.Location = new System.Drawing.Point(217, 141);
            this.cboUbicacion.Name = "cboUbicacion";
            this.cboUbicacion.Size = new System.Drawing.Size(197, 33);
            this.cboUbicacion.TabIndex = 13;
            this.cboUbicacion.SelectedIndexChanged += new System.EventHandler(this.cboUbicacion_SelectedIndexChanged);
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
            this.btnAgregar.ForeColor = System.Drawing.Color.Lime;
            this.btnAgregar.Location = new System.Drawing.Point(208, 386);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(179, 40);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnGuardarActividades
            // 
            this.btnGuardarActividades.BackColor = System.Drawing.Color.Black;
            this.btnGuardarActividades.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardarActividades.FlatAppearance.BorderSize = 2;
            this.btnGuardarActividades.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan;
            this.btnGuardarActividades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnGuardarActividades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarActividades.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarActividades.ForeColor = System.Drawing.Color.Tan;
            this.btnGuardarActividades.Location = new System.Drawing.Point(589, 386);
            this.btnGuardarActividades.Name = "btnGuardarActividades";
            this.btnGuardarActividades.Size = new System.Drawing.Size(179, 40);
            this.btnGuardarActividades.TabIndex = 15;
            this.btnGuardarActividades.Text = "Guardar";
            this.btnGuardarActividades.UseVisualStyleBackColor = false;
            this.btnGuardarActividades.Click += new System.EventHandler(this.btnGuardarActividades_Click);
            // 
            // cboActividades
            // 
            this.cboActividades.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboActividades.FormattingEnabled = true;
            this.cboActividades.Location = new System.Drawing.Point(217, 84);
            this.cboActividades.Name = "cboActividades";
            this.cboActividades.Size = new System.Drawing.Size(197, 33);
            this.cboActividades.TabIndex = 16;
            this.cboActividades.SelectedIndexChanged += new System.EventHandler(this.cboActividades_SelectedIndexChanged_1);
            // 
            // FormPlanificacionActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboActividades);
            this.Controls.Add(this.btnGuardarActividades);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cboUbicacion);
            this.Controls.Add(this.btnCargarCampos);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.dtpHoraActividades);
            this.Controls.Add(this.lblUbicacion);
            this.Controls.Add(this.lblAGENDA);
            this.Controls.Add(this.lblActividades);
            this.Controls.Add(this.dgvActividades);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPlanificacionActividades";
            this.Text = "formPlanificacionActividades";
            this.Load += new System.EventHandler(this.FormPlanificacionActividades_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem volverToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvActividades;
        private System.Windows.Forms.Label lblActividades;
        private System.Windows.Forms.Label lblAGENDA;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.DateTimePicker dtpHoraActividades;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnCargarCampos;
        private System.Windows.Forms.ComboBox cboUbicacion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn columActividades;
        private System.Windows.Forms.DataGridViewTextBoxColumn columUbicaion;
        private System.Windows.Forms.DataGridViewTextBoxColumn columHora;
        private System.Windows.Forms.Button btnGuardarActividades;
        private System.Windows.Forms.ComboBox cboActividades;
    }
}