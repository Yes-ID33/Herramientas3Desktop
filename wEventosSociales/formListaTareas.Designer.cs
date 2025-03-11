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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtgListaTareas = new System.Windows.Forms.DataGridView();
            this.ColumnTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInvitado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCargarTareas = new System.Windows.Forms.Button();
            this.cboOpciones = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaTareas)).BeginInit();
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
            this.lblAGENDA.Location = new System.Drawing.Point(302, 44);
            this.lblAGENDA.Name = "lblAGENDA";
            this.lblAGENDA.Size = new System.Drawing.Size(266, 31);
            this.lblAGENDA.TabIndex = 16;
            this.lblAGENDA.Text = "LISTA DE TAREAS";
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
            // dtgListaTareas
            // 
            this.dtgListaTareas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgListaTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListaTareas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTarea,
            this.ColumnInvitado});
            this.dtgListaTareas.Location = new System.Drawing.Point(126, 95);
            this.dtgListaTareas.Name = "dtgListaTareas";
            this.dtgListaTareas.RowHeadersWidth = 51;
            this.dtgListaTareas.Size = new System.Drawing.Size(540, 257);
            this.dtgListaTareas.TabIndex = 26;
            // 
            // ColumnTarea
            // 
            this.ColumnTarea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnTarea.HeaderText = "Tarea a realizar";
            this.ColumnTarea.MinimumWidth = 6;
            this.ColumnTarea.Name = "ColumnTarea";
            // 
            // ColumnInvitado
            // 
            this.ColumnInvitado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnInvitado.HeaderText = "Invitado Que La Realiza";
            this.ColumnInvitado.MinimumWidth = 6;
            this.ColumnInvitado.Name = "ColumnInvitado";
            this.ColumnInvitado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btnCargarTareas
            // 
            this.btnCargarTareas.BackColor = System.Drawing.Color.Black;
            this.btnCargarTareas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCargarTareas.FlatAppearance.BorderSize = 2;
            this.btnCargarTareas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Snow;
            this.btnCargarTareas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaShell;
            this.btnCargarTareas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarTareas.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarTareas.ForeColor = System.Drawing.Color.White;
            this.btnCargarTareas.Location = new System.Drawing.Point(317, 382);
            this.btnCargarTareas.Name = "btnCargarTareas";
            this.btnCargarTareas.Size = new System.Drawing.Size(163, 43);
            this.btnCargarTareas.TabIndex = 27;
            this.btnCargarTareas.Text = "Cargar Tareas";
            this.btnCargarTareas.UseVisualStyleBackColor = false;
            this.btnCargarTareas.Click += new System.EventHandler(this.btnCargarTareas_Click);
            // 
            // cboOpciones
            // 
            this.cboOpciones.FormattingEnabled = true;
            this.cboOpciones.Location = new System.Drawing.Point(126, 70);
            this.cboOpciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboOpciones.Name = "cboOpciones";
            this.cboOpciones.Size = new System.Drawing.Size(145, 21);
            this.cboOpciones.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Tareas recomendadas";
            // 
            // FormListaTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboOpciones);
            this.Controls.Add(this.btnCargarTareas);
            this.Controls.Add(this.dtgListaTareas);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiarLista);
            this.Controls.Add(this.lblAGENDA);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormListaTareas";
            this.Load += new System.EventHandler(this.FormListaTareas_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaTareas)).EndInit();
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
        private System.Windows.Forms.DataGridView dtgListaTareas;
        private System.Windows.Forms.Button btnCargarTareas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInvitado;
        private System.Windows.Forms.ComboBox cboOpciones;
        private System.Windows.Forms.Label label1;
    }
}