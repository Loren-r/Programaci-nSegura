namespace ProgramaciónSs
{
    partial class frmMantenedorUsuario
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
            this.gboxDatos = new System.Windows.Forms.GroupBox();
            this.cboxNivel = new System.Windows.Forms.ComboBox();
            this.txtbConfContraseña = new System.Windows.Forms.TextBox();
            this.txtbContraseña = new System.Windows.Forms.TextBox();
            this.txtbCorreo = new System.Windows.Forms.TextBox();
            this.txtbUsuario = new System.Windows.Forms.TextBox();
            this.txtbNombreApellido = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblContraseñaConfirmar = new System.Windows.Forms.Label();
            this.lblContraseñaM = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.lblUsuarioM = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.gboxDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxDatos
            // 
            this.gboxDatos.Controls.Add(this.cboxNivel);
            this.gboxDatos.Controls.Add(this.txtbConfContraseña);
            this.gboxDatos.Controls.Add(this.txtbContraseña);
            this.gboxDatos.Controls.Add(this.txtbCorreo);
            this.gboxDatos.Controls.Add(this.txtbUsuario);
            this.gboxDatos.Controls.Add(this.txtbNombreApellido);
            this.gboxDatos.Controls.Add(this.lblCorreo);
            this.gboxDatos.Controls.Add(this.lblContraseñaConfirmar);
            this.gboxDatos.Controls.Add(this.lblContraseñaM);
            this.gboxDatos.Controls.Add(this.lblNivel);
            this.gboxDatos.Controls.Add(this.lblNombreCompleto);
            this.gboxDatos.Controls.Add(this.lblUsuarioM);
            this.gboxDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxDatos.ForeColor = System.Drawing.Color.MediumBlue;
            this.gboxDatos.Location = new System.Drawing.Point(12, 30);
            this.gboxDatos.Name = "gboxDatos";
            this.gboxDatos.Size = new System.Drawing.Size(571, 272);
            this.gboxDatos.TabIndex = 0;
            this.gboxDatos.TabStop = false;
            this.gboxDatos.Text = "Datos Usuario";
            // 
            // cboxNivel
            // 
            this.cboxNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxNivel.FormattingEnabled = true;
            this.cboxNivel.Items.AddRange(new object[] {
            "Persona",
            "Empresa",
            "Administrador"});
            this.cboxNivel.Location = new System.Drawing.Point(412, 76);
            this.cboxNivel.Name = "cboxNivel";
            this.cboxNivel.Size = new System.Drawing.Size(153, 24);
            this.cboxNivel.TabIndex = 11;
            // 
            // txtbConfContraseña
            // 
            this.txtbConfContraseña.Location = new System.Drawing.Point(156, 186);
            this.txtbConfContraseña.Name = "txtbConfContraseña";
            this.txtbConfContraseña.PasswordChar = '*';
            this.txtbConfContraseña.Size = new System.Drawing.Size(186, 23);
            this.txtbConfContraseña.TabIndex = 10;
            // 
            // txtbContraseña
            // 
            this.txtbContraseña.Location = new System.Drawing.Point(156, 147);
            this.txtbContraseña.Name = "txtbContraseña";
            this.txtbContraseña.PasswordChar = '*';
            this.txtbContraseña.Size = new System.Drawing.Size(186, 23);
            this.txtbContraseña.TabIndex = 9;
            // 
            // txtbCorreo
            // 
            this.txtbCorreo.Location = new System.Drawing.Point(156, 112);
            this.txtbCorreo.Name = "txtbCorreo";
            this.txtbCorreo.Size = new System.Drawing.Size(186, 23);
            this.txtbCorreo.TabIndex = 8;
            // 
            // txtbUsuario
            // 
            this.txtbUsuario.Location = new System.Drawing.Point(156, 76);
            this.txtbUsuario.Name = "txtbUsuario";
            this.txtbUsuario.Size = new System.Drawing.Size(186, 23);
            this.txtbUsuario.TabIndex = 7;
            // 
            // txtbNombreApellido
            // 
            this.txtbNombreApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNombreApellido.Location = new System.Drawing.Point(156, 38);
            this.txtbNombreApellido.Name = "txtbNombreApellido";
            this.txtbNombreApellido.Size = new System.Drawing.Size(316, 22);
            this.txtbNombreApellido.TabIndex = 6;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(99, 112);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(51, 17);
            this.lblCorreo.TabIndex = 5;
            this.lblCorreo.Text = "Correo";
            // 
            // lblContraseñaConfirmar
            // 
            this.lblContraseñaConfirmar.AutoSize = true;
            this.lblContraseñaConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseñaConfirmar.Location = new System.Drawing.Point(6, 186);
            this.lblContraseñaConfirmar.Name = "lblContraseñaConfirmar";
            this.lblContraseñaConfirmar.Size = new System.Drawing.Size(146, 17);
            this.lblContraseñaConfirmar.TabIndex = 4;
            this.lblContraseñaConfirmar.Text = "Confirmar Contraseña";
            this.lblContraseñaConfirmar.Click += new System.EventHandler(this.lblContraseñaConfirmar_Click);
            // 
            // lblContraseñaM
            // 
            this.lblContraseñaM.AutoSize = true;
            this.lblContraseñaM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseñaM.Location = new System.Drawing.Point(69, 147);
            this.lblContraseñaM.Name = "lblContraseñaM";
            this.lblContraseñaM.Size = new System.Drawing.Size(81, 17);
            this.lblContraseñaM.TabIndex = 3;
            this.lblContraseñaM.Text = "Contraseña";
            this.lblContraseñaM.Click += new System.EventHandler(this.lblContraseñaM_Click);
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.Location = new System.Drawing.Point(367, 79);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(39, 17);
            this.lblNivel.TabIndex = 2;
            this.lblNivel.Text = "Nivel";
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCompleto.Location = new System.Drawing.Point(27, 38);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(123, 17);
            this.lblNombreCompleto.TabIndex = 1;
            this.lblNombreCompleto.Text = "Nombre y Apellido";
            // 
            // lblUsuarioM
            // 
            this.lblUsuarioM.AutoSize = true;
            this.lblUsuarioM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioM.Location = new System.Drawing.Point(93, 76);
            this.lblUsuarioM.Name = "lblUsuarioM";
            this.lblUsuarioM.Size = new System.Drawing.Size(57, 17);
            this.lblUsuarioM.TabIndex = 0;
            this.lblUsuarioM.Text = "Usuario";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnAceptar.Location = new System.Drawing.Point(143, 342);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(81, 28);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnLimpiar.Location = new System.Drawing.Point(252, 342);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(81, 28);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnAtras.Location = new System.Drawing.Point(363, 342);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(81, 28);
            this.btnAtras.TabIndex = 3;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // frmMantenedorUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(595, 466);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gboxDatos);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmMantenedorUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenedor Usuario";
            this.gboxDatos.ResumeLayout(false);
            this.gboxDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxDatos;
        private System.Windows.Forms.Label lblContraseñaConfirmar;
        private System.Windows.Forms.Label lblContraseñaM;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.Label lblUsuarioM;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtbNombreApellido;
        private System.Windows.Forms.ComboBox cboxNivel;
        private System.Windows.Forms.TextBox txtbConfContraseña;
        private System.Windows.Forms.TextBox txtbContraseña;
        private System.Windows.Forms.TextBox txtbCorreo;
        private System.Windows.Forms.TextBox txtbUsuario;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAtras;
    }
}