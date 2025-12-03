namespace ProgramaciónSs
{
    partial class frmPrincipal
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
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblNombreNivel = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.smenuOpciones = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarUsuarioToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblBienvenido.Location = new System.Drawing.Point(299, 108);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(173, 37);
            this.lblBienvenido.TabIndex = 1;
            this.lblBienvenido.Text = "Bienvenido";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblNombreUsuario.Location = new System.Drawing.Point(535, 28);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(68, 20);
            this.lblNombreUsuario.TabIndex = 2;
            this.lblNombreUsuario.Text = "Usuario:";
            // 
            // lblNombreNivel
            // 
            this.lblNombreNivel.AutoSize = true;
            this.lblNombreNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreNivel.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblNombreNivel.Location = new System.Drawing.Point(557, 48);
            this.lblNombreNivel.Name = "lblNombreNivel";
            this.lblNombreNivel.Size = new System.Drawing.Size(46, 20);
            this.lblNombreNivel.TabIndex = 3;
            this.lblNombreNivel.Text = "Nivel:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblUsuario.Location = new System.Drawing.Point(609, 28);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(64, 20);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblNivel.Location = new System.Drawing.Point(609, 48);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(42, 20);
            this.lblNivel.TabIndex = 5;
            this.lblNivel.Text = "Nivel";
            this.lblNivel.Click += new System.EventHandler(this.lblNivel_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smenuOpciones});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // smenuOpciones
            // 
            this.smenuOpciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarUsuarioToolStripMenu,
            this.cerrarSesiónToolStripMenuItem});
            this.smenuOpciones.Name = "smenuOpciones";
            this.smenuOpciones.Size = new System.Drawing.Size(69, 20);
            this.smenuOpciones.Text = "Opciones";
            // 
            // agregarUsuarioToolStripMenu
            // 
            this.agregarUsuarioToolStripMenu.Name = "agregarUsuarioToolStripMenu";
            this.agregarUsuarioToolStripMenu.Size = new System.Drawing.Size(180, 22);
            this.agregarUsuarioToolStripMenu.Text = "Agregar Usuario";
            this.agregarUsuarioToolStripMenu.Click += new System.EventHandler(this.agregarUsuarioToolStripMenu_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblNombreNivel);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Página Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblNombreNivel;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem smenuOpciones;
        private System.Windows.Forms.ToolStripMenuItem agregarUsuarioToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
    }
}