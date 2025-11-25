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
            this.btnEntrarEm = new System.Windows.Forms.Button();
            this.btnSalirEm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLblContraseñaEmp = new System.Windows.Forms.LinkLabel();
            this.lblContraseñaEmp = new System.Windows.Forms.Label();
            this.txtUsuarioEmp = new System.Windows.Forms.TextBox();
            this.lblUsuarioEmp = new System.Windows.Forms.Label();
            this.txtContraseñaEmp = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.BackColor = System.Drawing.SystemColors.Control;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblBienvenido.Location = new System.Drawing.Point(324, 50);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(164, 36);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "Bienvenido";
            this.lblBienvenido.UseWaitCursor = true;
            // 
            // btnEntrarEm
            // 
            this.btnEntrarEm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrarEm.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnEntrarEm.Location = new System.Drawing.Point(611, 406);
            this.btnEntrarEm.Name = "btnEntrarEm";
            this.btnEntrarEm.Size = new System.Drawing.Size(89, 32);
            this.btnEntrarEm.TabIndex = 6;
            this.btnEntrarEm.Text = "Entrar";
            this.btnEntrarEm.UseVisualStyleBackColor = true;
            this.btnEntrarEm.UseWaitCursor = true;
            this.btnEntrarEm.Click += new System.EventHandler(this.btnEntrarEm_Click);
            // 
            // btnSalirEm
            // 
            this.btnSalirEm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirEm.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSalirEm.Location = new System.Drawing.Point(495, 411);
            this.btnSalirEm.Name = "btnSalirEm";
            this.btnSalirEm.Size = new System.Drawing.Size(89, 32);
            this.btnSalirEm.TabIndex = 5;
            this.btnSalirEm.Text = "Salir";
            this.btnSalirEm.UseVisualStyleBackColor = true;
            this.btnSalirEm.UseWaitCursor = true;
            this.btnSalirEm.Click += new System.EventHandler(this.btnSalirEm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLblContraseñaEmp);
            this.groupBox1.Controls.Add(this.lblContraseñaEmp);
            this.groupBox1.Controls.Add(this.txtUsuarioEmp);
            this.groupBox1.Controls.Add(this.lblUsuarioEmp);
            this.groupBox1.Controls.Add(this.txtContraseñaEmp);
            this.groupBox1.Location = new System.Drawing.Point(183, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 241);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // linkLblContraseñaEmp
            // 
            this.linkLblContraseñaEmp.AutoSize = true;
            this.linkLblContraseñaEmp.Location = new System.Drawing.Point(156, 165);
            this.linkLblContraseñaEmp.Name = "linkLblContraseñaEmp";
            this.linkLblContraseñaEmp.Size = new System.Drawing.Size(149, 13);
            this.linkLblContraseñaEmp.TabIndex = 9;
            this.linkLblContraseñaEmp.TabStop = true;
            this.linkLblContraseñaEmp.Text = "¿Haz olvidado tu contraseña?";
            this.linkLblContraseñaEmp.UseWaitCursor = true;
            // 
            // lblContraseñaEmp
            // 
            this.lblContraseñaEmp.AutoSize = true;
            this.lblContraseñaEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseñaEmp.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblContraseñaEmp.Location = new System.Drawing.Point(64, 107);
            this.lblContraseñaEmp.Name = "lblContraseñaEmp";
            this.lblContraseñaEmp.Size = new System.Drawing.Size(81, 17);
            this.lblContraseñaEmp.TabIndex = 6;
            this.lblContraseñaEmp.Text = "Contraseña";
            this.lblContraseñaEmp.UseWaitCursor = true;
            // 
            // txtUsuarioEmp
            // 
            this.txtUsuarioEmp.Location = new System.Drawing.Point(159, 62);
            this.txtUsuarioEmp.Name = "txtUsuarioEmp";
            this.txtUsuarioEmp.Size = new System.Drawing.Size(177, 20);
            this.txtUsuarioEmp.TabIndex = 7;
            this.txtUsuarioEmp.UseWaitCursor = true;
            // 
            // lblUsuarioEmp
            // 
            this.lblUsuarioEmp.AutoSize = true;
            this.lblUsuarioEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioEmp.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblUsuarioEmp.Location = new System.Drawing.Point(64, 63);
            this.lblUsuarioEmp.Name = "lblUsuarioEmp";
            this.lblUsuarioEmp.Size = new System.Drawing.Size(57, 17);
            this.lblUsuarioEmp.TabIndex = 5;
            this.lblUsuarioEmp.Text = "Usuario";
            this.lblUsuarioEmp.UseWaitCursor = true;
            // 
            // txtContraseñaEmp
            // 
            this.txtContraseñaEmp.Location = new System.Drawing.Point(159, 107);
            this.txtContraseñaEmp.Name = "txtContraseñaEmp";
            this.txtContraseñaEmp.PasswordChar = '*';
            this.txtContraseñaEmp.Size = new System.Drawing.Size(177, 20);
            this.txtContraseñaEmp.TabIndex = 8;
            this.txtContraseñaEmp.UseWaitCursor = true;
            // 
            // inicio_sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEntrarEm);
            this.Controls.Add(this.btnSalirEm);
            this.Controls.Add(this.lblBienvenido);
            this.Name = "inicio_sesion";
            this.Text = "Inicio Sesión";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.inicio_sesion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Button btnEntrarEm;
        private System.Windows.Forms.Button btnSalirEm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLblContraseñaEmp;
        private System.Windows.Forms.Label lblContraseñaEmp;
        private System.Windows.Forms.TextBox txtUsuarioEmp;
        private System.Windows.Forms.Label lblUsuarioEmp;
        private System.Windows.Forms.TextBox txtContraseñaEmp;
    }
}

