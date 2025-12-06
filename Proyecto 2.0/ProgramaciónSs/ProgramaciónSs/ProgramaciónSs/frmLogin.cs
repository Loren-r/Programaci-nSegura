using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgramaciónSs;

namespace ProgramaciónSs
{
    public partial class frmLogin : Form
    {
        private readonly LoginController controller;
        public frmLogin()
        {
            InitializeComponent();
            controller = new LoginController();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string usuario = txtbUsuario.Text;
            string contraseña = txtbContraseña.Text;
            Usuario user = controller.AutenticarUsuario(usuario, contraseña);

            if (user == null)
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"Bienvenido {user.NOM_USUARIO}!\nNivel de acceso: {user.NOMBRE_NIVEL}", "Autenticación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmPrincipal principalForm = new frmPrincipal(user);
                principalForm.Show();


            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();

        }


    }
}
