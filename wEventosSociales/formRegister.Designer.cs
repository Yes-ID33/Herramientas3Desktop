namespace wEventosSociales
{
    partial class formRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRegister));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblCorreoUsuario = new System.Windows.Forms.Label();
            this.lblContraseniaUno = new System.Windows.Forms.Label();
            this.lblContraseniaDos = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtCorreoUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseniaDos = new System.Windows.Forms.TextBox();
            this.txtContraseniaUno = new System.Windows.Forms.TextBox();
            this.btnCrearCuenta = new System.Windows.Forms.Button();
            this.btnIrIniciarSesion = new System.Windows.Forms.Button();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.inicioToolStripMenuItem.Text = "&Inicio";
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.cerrarToolStripMenuItem.Text = "&Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.BackColor = System.Drawing.Color.Gray;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Segoe UI Black", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(149, 105);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(170, 23);
            this.lblNombreUsuario.TabIndex = 1;
            this.lblNombreUsuario.Text = "Nombre de usuario";
            // 
            // lblCorreoUsuario
            // 
            this.lblCorreoUsuario.AutoSize = true;
            this.lblCorreoUsuario.BackColor = System.Drawing.Color.Gray;
            this.lblCorreoUsuario.Font = new System.Drawing.Font("Segoe UI Black", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoUsuario.Location = new System.Drawing.Point(149, 147);
            this.lblCorreoUsuario.Name = "lblCorreoUsuario";
            this.lblCorreoUsuario.Size = new System.Drawing.Size(151, 23);
            this.lblCorreoUsuario.TabIndex = 2;
            this.lblCorreoUsuario.Text = "Ingrese su correo";
            // 
            // lblContraseniaUno
            // 
            this.lblContraseniaUno.AutoSize = true;
            this.lblContraseniaUno.BackColor = System.Drawing.Color.Gray;
            this.lblContraseniaUno.Font = new System.Drawing.Font("Segoe UI Black", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseniaUno.Location = new System.Drawing.Point(149, 191);
            this.lblContraseniaUno.Name = "lblContraseniaUno";
            this.lblContraseniaUno.Size = new System.Drawing.Size(168, 23);
            this.lblContraseniaUno.TabIndex = 3;
            this.lblContraseniaUno.Text = "Cree su contraseña";
            // 
            // lblContraseniaDos
            // 
            this.lblContraseniaDos.AutoSize = true;
            this.lblContraseniaDos.BackColor = System.Drawing.Color.Gray;
            this.lblContraseniaDos.Font = new System.Drawing.Font("Segoe UI Black", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseniaDos.Location = new System.Drawing.Point(149, 233);
            this.lblContraseniaDos.Name = "lblContraseniaDos";
            this.lblContraseniaDos.Size = new System.Drawing.Size(208, 23);
            this.lblContraseniaDos.TabIndex = 4;
            this.lblContraseniaDos.Text = "Confirme su contraseña";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUsuario.Location = new System.Drawing.Point(406, 101);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(196, 27);
            this.txtNombreUsuario.TabIndex = 5;
            // 
            // txtCorreoUsuario
            // 
            this.txtCorreoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoUsuario.Location = new System.Drawing.Point(406, 143);
            this.txtCorreoUsuario.Name = "txtCorreoUsuario";
            this.txtCorreoUsuario.Size = new System.Drawing.Size(196, 27);
            this.txtCorreoUsuario.TabIndex = 6;
            // 
            // txtContraseniaDos
            // 
            this.txtContraseniaDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseniaDos.Location = new System.Drawing.Point(406, 229);
            this.txtContraseniaDos.Name = "txtContraseniaDos";
            this.txtContraseniaDos.Size = new System.Drawing.Size(140, 27);
            this.txtContraseniaDos.TabIndex = 8;
            this.txtContraseniaDos.TextChanged += new System.EventHandler(this.txtContraseniaDos_TextChanged);
            // 
            // txtContraseniaUno
            // 
            this.txtContraseniaUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseniaUno.Location = new System.Drawing.Point(406, 187);
            this.txtContraseniaUno.Name = "txtContraseniaUno";
            this.txtContraseniaUno.Size = new System.Drawing.Size(140, 27);
            this.txtContraseniaUno.TabIndex = 7;
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCrearCuenta.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCuenta.ForeColor = System.Drawing.Color.Transparent;
            this.btnCrearCuenta.Location = new System.Drawing.Point(165, 305);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Size = new System.Drawing.Size(154, 72);
            this.btnCrearCuenta.TabIndex = 9;
            this.btnCrearCuenta.Text = "Crear cuenta";
            this.btnCrearCuenta.UseVisualStyleBackColor = false;
            this.btnCrearCuenta.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            // 
            // btnIrIniciarSesion
            // 
            this.btnIrIniciarSesion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIrIniciarSesion.Font = new System.Drawing.Font("Segoe UI Black", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrIniciarSesion.ForeColor = System.Drawing.Color.Transparent;
            this.btnIrIniciarSesion.Location = new System.Drawing.Point(394, 305);
            this.btnIrIniciarSesion.Name = "btnIrIniciarSesion";
            this.btnIrIniciarSesion.Size = new System.Drawing.Size(171, 72);
            this.btnIrIniciarSesion.TabIndex = 10;
            this.btnIrIniciarSesion.Text = "¿Ya tiene cuenta?";
            this.btnIrIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIrIniciarSesion.Click += new System.EventHandler(this.btnIrIniciarSesion_Click);
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.BackColor = System.Drawing.Color.Gray;
            this.lblRegistro.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.Location = new System.Drawing.Point(279, 38);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(127, 37);
            this.lblRegistro.TabIndex = 11;
            this.lblRegistro.Text = "Registro";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(628, 278);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(160, 160);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // formRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.btnIrIniciarSesion);
            this.Controls.Add(this.btnCrearCuenta);
            this.Controls.Add(this.txtContraseniaDos);
            this.Controls.Add(this.txtContraseniaUno);
            this.Controls.Add(this.txtCorreoUsuario);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.lblContraseniaDos);
            this.Controls.Add(this.lblContraseniaUno);
            this.Controls.Add(this.lblCorreoUsuario);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formRegister";
            this.Text = "formRegister";
            this.Load += new System.EventHandler(this.formRegister_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblCorreoUsuario;
        private System.Windows.Forms.Label lblContraseniaUno;
        private System.Windows.Forms.Label lblContraseniaDos;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtCorreoUsuario;
        private System.Windows.Forms.TextBox txtContraseniaDos;
        private System.Windows.Forms.TextBox txtContraseniaUno;
        private System.Windows.Forms.Button btnCrearCuenta;
        private System.Windows.Forms.Button btnIrIniciarSesion;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}