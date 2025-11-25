namespace ProgramaciónSegura
{
    partial class inicio_sesion
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
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.tabCInicioSesion = new System.Windows.Forms.TabControl();
            this.tbPagePersonas = new System.Windows.Forms.TabPage();
            this.btnOjo = new System.Windows.Forms.Button();
            this.linkLblContraseñaPe = new System.Windows.Forms.LinkLabel();
            this.txtContraseñaPe = new System.Windows.Forms.TextBox();
            this.txtUsuarioPe = new System.Windows.Forms.TextBox();
            this.lblContraseñaPe = new System.Windows.Forms.Label();
            this.lblUsuarioPe = new System.Windows.Forms.Label();
            this.tbPageEmpresas = new System.Windows.Forms.TabPage();
            this.linkLblContraseñaEmp = new System.Windows.Forms.LinkLabel();
            this.txtContraseñaEmp = new System.Windows.Forms.TextBox();
            this.txtUsuarioEmp = new System.Windows.Forms.TextBox();
            this.lblContraseñaEmp = new System.Windows.Forms.Label();
            this.lblUsuarioEmp = new System.Windows.Forms.Label();
            this.tbPageAdministrador = new System.Windows.Forms.TabPage();
            this.linkLblContraseñaAdmin = new System.Windows.Forms.LinkLabel();
            this.txtConstraseñaAdmin = new System.Windows.Forms.TextBox();
            this.txtUsuarioAdmin = new System.Windows.Forms.TextBox();
            this.lblContraseñaAdmin = new System.Windows.Forms.Label();
            this.lblUsuarioAdmin = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.tabCInicioSesion.SuspendLayout();
            this.tbPagePersonas.SuspendLayout();
            this.tbPageEmpresas.SuspendLayout();
            this.tbPageAdministrador.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.BackColor = System.Drawing.SystemColors.Control;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblBienvenido.Location = new System.Drawing.Point(301, 76);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(164, 36);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "Bienvenido";
            this.lblBienvenido.UseWaitCursor = true;
            // 
            // tabCInicioSesion
            // 
            this.tabCInicioSesion.Controls.Add(this.tbPagePersonas);
            this.tabCInicioSesion.Controls.Add(this.tbPageEmpresas);
            this.tabCInicioSesion.Controls.Add(this.tbPageAdministrador);
            this.tabCInicioSesion.Location = new System.Drawing.Point(198, 125);
            this.tabCInicioSesion.Name = "tabCInicioSesion";
            this.tabCInicioSesion.SelectedIndex = 0;
            this.tabCInicioSesion.Size = new System.Drawing.Size(382, 199);
            this.tabCInicioSesion.TabIndex = 1;
            this.tabCInicioSesion.UseWaitCursor = true;
            // 
            // tbPagePersonas
            // 
            this.tbPagePersonas.Controls.Add(this.btnOjo);
            this.tbPagePersonas.Controls.Add(this.linkLblContraseñaPe);
            this.tbPagePersonas.Controls.Add(this.txtContraseñaPe);
            this.tbPagePersonas.Controls.Add(this.txtUsuarioPe);
            this.tbPagePersonas.Controls.Add(this.lblContraseñaPe);
            this.tbPagePersonas.Controls.Add(this.lblUsuarioPe);
            this.tbPagePersonas.Location = new System.Drawing.Point(4, 22);
            this.tbPagePersonas.Name = "tbPagePersonas";
            this.tbPagePersonas.Padding = new System.Windows.Forms.Padding(3);
            this.tbPagePersonas.Size = new System.Drawing.Size(374, 173);
            this.tbPagePersonas.TabIndex = 0;
            this.tbPagePersonas.Text = "Personas";
            this.tbPagePersonas.UseVisualStyleBackColor = true;
            this.tbPagePersonas.UseWaitCursor = true;
            // 
            // btnOjo
            // 
            this.btnOjo.BackColor = System.Drawing.SystemColors.Control;
            this.btnOjo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOjo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnOjo.Location = new System.Drawing.Point(316, 65);
            this.btnOjo.Name = "btnOjo";
            this.btnOjo.Size = new System.Drawing.Size(23, 30);
            this.btnOjo.TabIndex = 10;
            this.btnOjo.Text = "👁️‍🗨️";
            this.btnOjo.UseVisualStyleBackColor = false;
            this.btnOjo.UseWaitCursor = true;
            this.btnOjo.Click += new System.EventHandler(this.btnOjo_Click);
            // 
            // linkLblContraseñaPe
            // 
            this.linkLblContraseñaPe.AutoSize = true;
            this.linkLblContraseñaPe.Location = new System.Drawing.Point(130, 115);
            this.linkLblContraseñaPe.Name = "linkLblContraseñaPe";
            this.linkLblContraseñaPe.Size = new System.Drawing.Size(149, 13);
            this.linkLblContraseñaPe.TabIndex = 9;
            this.linkLblContraseñaPe.TabStop = true;
            this.linkLblContraseñaPe.Text = "¿Haz olvidado tu contraseña?";
            this.linkLblContraseñaPe.UseWaitCursor = true;
            // 
            // txtContraseñaPe
            // 
            this.txtContraseñaPe.Location = new System.Drawing.Point(133, 72);
            this.txtContraseñaPe.Name = "txtContraseñaPe";
            this.txtContraseñaPe.PasswordChar = '*';
            this.txtContraseñaPe.Size = new System.Drawing.Size(177, 20);
            this.txtContraseñaPe.TabIndex = 8;
            this.txtContraseñaPe.UseWaitCursor = true;
            // 
            // txtUsuarioPe
            // 
            this.txtUsuarioPe.Location = new System.Drawing.Point(133, 36);
            this.txtUsuarioPe.Name = "txtUsuarioPe";
            this.txtUsuarioPe.Size = new System.Drawing.Size(177, 20);
            this.txtUsuarioPe.TabIndex = 7;
            this.txtUsuarioPe.UseWaitCursor = true;
            // 
            // lblContraseñaPe
            // 
            this.lblContraseñaPe.AutoSize = true;
            this.lblContraseñaPe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseñaPe.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblContraseñaPe.Location = new System.Drawing.Point(36, 72);
            this.lblContraseñaPe.Name = "lblContraseñaPe";
            this.lblContraseñaPe.Size = new System.Drawing.Size(81, 17);
            this.lblContraseñaPe.TabIndex = 6;
            this.lblContraseñaPe.Text = "Contraseña";
            this.lblContraseñaPe.UseWaitCursor = true;
            // 
            // lblUsuarioPe
            // 
            this.lblUsuarioPe.AutoSize = true;
            this.lblUsuarioPe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioPe.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblUsuarioPe.Location = new System.Drawing.Point(60, 37);
            this.lblUsuarioPe.Name = "lblUsuarioPe";
            this.lblUsuarioPe.Size = new System.Drawing.Size(57, 17);
            this.lblUsuarioPe.TabIndex = 5;
            this.lblUsuarioPe.Text = "Usuario";
            this.lblUsuarioPe.UseWaitCursor = true;
            // 
            // tbPageEmpresas
            // 
            this.tbPageEmpresas.Controls.Add(this.linkLblContraseñaEmp);
            this.tbPageEmpresas.Controls.Add(this.txtContraseñaEmp);
            this.tbPageEmpresas.Controls.Add(this.txtUsuarioEmp);
            this.tbPageEmpresas.Controls.Add(this.lblContraseñaEmp);
            this.tbPageEmpresas.Controls.Add(this.lblUsuarioEmp);
            this.tbPageEmpresas.Location = new System.Drawing.Point(4, 22);
            this.tbPageEmpresas.Name = "tbPageEmpresas";
            this.tbPageEmpresas.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageEmpresas.Size = new System.Drawing.Size(374, 173);
            this.tbPageEmpresas.TabIndex = 1;
            this.tbPageEmpresas.Text = "Empresas";
            this.tbPageEmpresas.UseVisualStyleBackColor = true;
            this.tbPageEmpresas.UseWaitCursor = true;
            // 
            // linkLblContraseñaEmp
            // 
            this.linkLblContraseñaEmp.AutoSize = true;
            this.linkLblContraseñaEmp.Location = new System.Drawing.Point(130, 117);
            this.linkLblContraseñaEmp.Name = "linkLblContraseñaEmp";
            this.linkLblContraseñaEmp.Size = new System.Drawing.Size(149, 13);
            this.linkLblContraseñaEmp.TabIndex = 4;
            this.linkLblContraseñaEmp.TabStop = true;
            this.linkLblContraseñaEmp.Text = "¿Haz olvidado tu contraseña?";
            this.linkLblContraseñaEmp.UseWaitCursor = true;
            this.linkLblContraseñaEmp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkL);
            // 
            // txtContraseñaEmp
            // 
            this.txtContraseñaEmp.Location = new System.Drawing.Point(133, 74);
            this.txtContraseñaEmp.Name = "txtContraseñaEmp";
            this.txtContraseñaEmp.PasswordChar = '*';
            this.txtContraseñaEmp.Size = new System.Drawing.Size(177, 20);
            this.txtContraseñaEmp.TabIndex = 3;
            this.txtContraseñaEmp.UseWaitCursor = true;
            // 
            // txtUsuarioEmp
            // 
            this.txtUsuarioEmp.Location = new System.Drawing.Point(133, 38);
            this.txtUsuarioEmp.Name = "txtUsuarioEmp";
            this.txtUsuarioEmp.Size = new System.Drawing.Size(177, 20);
            this.txtUsuarioEmp.TabIndex = 2;
            this.txtUsuarioEmp.UseWaitCursor = true;
            // 
            // lblContraseñaEmp
            // 
            this.lblContraseñaEmp.AutoSize = true;
            this.lblContraseñaEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseñaEmp.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblContraseñaEmp.Location = new System.Drawing.Point(36, 74);
            this.lblContraseñaEmp.Name = "lblContraseñaEmp";
            this.lblContraseñaEmp.Size = new System.Drawing.Size(81, 17);
            this.lblContraseñaEmp.TabIndex = 1;
            this.lblContraseñaEmp.Text = "Contraseña";
            this.lblContraseñaEmp.UseWaitCursor = true;
            // 
            // lblUsuarioEmp
            // 
            this.lblUsuarioEmp.AutoSize = true;
            this.lblUsuarioEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioEmp.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblUsuarioEmp.Location = new System.Drawing.Point(60, 39);
            this.lblUsuarioEmp.Name = "lblUsuarioEmp";
            this.lblUsuarioEmp.Size = new System.Drawing.Size(57, 17);
            this.lblUsuarioEmp.TabIndex = 0;
            this.lblUsuarioEmp.Text = "Usuario";
            this.lblUsuarioEmp.UseWaitCursor = true;
            // 
            // tbPageAdministrador
            // 
            this.tbPageAdministrador.Controls.Add(this.linkLblContraseñaAdmin);
            this.tbPageAdministrador.Controls.Add(this.txtConstraseñaAdmin);
            this.tbPageAdministrador.Controls.Add(this.txtUsuarioAdmin);
            this.tbPageAdministrador.Controls.Add(this.lblContraseñaAdmin);
            this.tbPageAdministrador.Controls.Add(this.lblUsuarioAdmin);
            this.tbPageAdministrador.Location = new System.Drawing.Point(4, 22);
            this.tbPageAdministrador.Name = "tbPageAdministrador";
            this.tbPageAdministrador.Size = new System.Drawing.Size(374, 173);
            this.tbPageAdministrador.TabIndex = 2;
            this.tbPageAdministrador.Text = "Administrador";
            this.tbPageAdministrador.UseVisualStyleBackColor = true;
            this.tbPageAdministrador.UseWaitCursor = true;
            // 
            // linkLblContraseñaAdmin
            // 
            this.linkLblContraseñaAdmin.AutoSize = true;
            this.linkLblContraseñaAdmin.Location = new System.Drawing.Point(131, 119);
            this.linkLblContraseñaAdmin.Name = "linkLblContraseñaAdmin";
            this.linkLblContraseñaAdmin.Size = new System.Drawing.Size(149, 13);
            this.linkLblContraseñaAdmin.TabIndex = 14;
            this.linkLblContraseñaAdmin.TabStop = true;
            this.linkLblContraseñaAdmin.Text = "¿Haz olvidado tu contraseña?";
            this.linkLblContraseñaAdmin.UseWaitCursor = true;
            // 
            // txtConstraseñaAdmin
            // 
            this.txtConstraseñaAdmin.Location = new System.Drawing.Point(134, 76);
            this.txtConstraseñaAdmin.Name = "txtConstraseñaAdmin";
            this.txtConstraseñaAdmin.PasswordChar = '*';
            this.txtConstraseñaAdmin.Size = new System.Drawing.Size(177, 20);
            this.txtConstraseñaAdmin.TabIndex = 13;
            this.txtConstraseñaAdmin.UseWaitCursor = true;
            // 
            // txtUsuarioAdmin
            // 
            this.txtUsuarioAdmin.Location = new System.Drawing.Point(134, 40);
            this.txtUsuarioAdmin.Name = "txtUsuarioAdmin";
            this.txtUsuarioAdmin.Size = new System.Drawing.Size(177, 20);
            this.txtUsuarioAdmin.TabIndex = 12;
            this.txtUsuarioAdmin.UseWaitCursor = true;
            // 
            // lblContraseñaAdmin
            // 
            this.lblContraseñaAdmin.AutoSize = true;
            this.lblContraseñaAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseñaAdmin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblContraseñaAdmin.Location = new System.Drawing.Point(37, 76);
            this.lblContraseñaAdmin.Name = "lblContraseñaAdmin";
            this.lblContraseñaAdmin.Size = new System.Drawing.Size(81, 17);
            this.lblContraseñaAdmin.TabIndex = 11;
            this.lblContraseñaAdmin.Text = "Contraseña";
            this.lblContraseñaAdmin.UseWaitCursor = true;
            // 
            // lblUsuarioAdmin
            // 
            this.lblUsuarioAdmin.AutoSize = true;
            this.lblUsuarioAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioAdmin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblUsuarioAdmin.Location = new System.Drawing.Point(61, 41);
            this.lblUsuarioAdmin.Name = "lblUsuarioAdmin";
            this.lblUsuarioAdmin.Size = new System.Drawing.Size(57, 17);
            this.lblUsuarioAdmin.TabIndex = 10;
            this.lblUsuarioAdmin.Text = "Usuario";
            this.lblUsuarioAdmin.UseWaitCursor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSalir.Location = new System.Drawing.Point(487, 362);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(89, 32);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.UseWaitCursor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnEntrar.Location = new System.Drawing.Point(596, 362);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(89, 32);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.UseWaitCursor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // inicio_sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.tabCInicioSesion);
            this.Controls.Add(this.lblBienvenido);
            this.Name = "inicio_sesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio Sesión";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.inicio_sesion_Load);
            this.tabCInicioSesion.ResumeLayout(false);
            this.tbPagePersonas.ResumeLayout(false);
            this.tbPagePersonas.PerformLayout();
            this.tbPageEmpresas.ResumeLayout(false);
            this.tbPageEmpresas.PerformLayout();
            this.tbPageAdministrador.ResumeLayout(false);
            this.tbPageAdministrador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.TabControl tabCInicioSesion;
        private System.Windows.Forms.TabPage tbPagePersonas;
        private System.Windows.Forms.TabPage tbPageEmpresas;
        private System.Windows.Forms.LinkLabel linkLblContraseñaEmp;
        private System.Windows.Forms.TextBox txtContraseñaEmp;
        private System.Windows.Forms.TextBox txtUsuarioEmp;
        private System.Windows.Forms.Label lblContraseñaEmp;
        private System.Windows.Forms.Label lblUsuarioEmp;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.LinkLabel linkLblContraseñaPe;
        private System.Windows.Forms.TextBox txtContraseñaPe;
        private System.Windows.Forms.TextBox txtUsuarioPe;
        private System.Windows.Forms.Label lblContraseñaPe;
        private System.Windows.Forms.Label lblUsuarioPe;
        private System.Windows.Forms.TabPage tbPageAdministrador;
        private System.Windows.Forms.LinkLabel linkLblContraseñaAdmin;
        private System.Windows.Forms.TextBox txtConstraseñaAdmin;
        private System.Windows.Forms.TextBox txtUsuarioAdmin;
        private System.Windows.Forms.Label lblContraseñaAdmin;
        private System.Windows.Forms.Label lblUsuarioAdmin;
        private System.Windows.Forms.Button btnOjo;
    }
}

