using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaciónSs
{
    public partial class frmPrincipal : Form
    {
        private Usuario usuarioActual;
        private Usuario NOMBRE_NIVEL;
        public frmPrincipal(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;

            lblUsuario.Text = usuarioActual.NOM_USUARIO;
            lblNivel.Text = usuarioActual.NOMBRE_NIVEL;

            agregarUsuarioToolStripMenu.Visible = false;
            string nivel = usuarioActual.NOMBRE_NIVEL.Trim().ToLower();

            if (usuarioActual.NOMBRE_NIVEL == "ADMINISTRADOR")
            {
                agregarUsuarioToolStripMenu.Visible = true;

            }
            
            
        }

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void linkCerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
            this.Close();
        }

        private void lblNivel_Click(object sender, EventArgs e)
        {

        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
            this.Close();
        }

        private void agregarUsuarioToolStripMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMantenedorUsuario MantenedorForm = new frmMantenedorUsuario();
            MantenedorForm.Show();
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
