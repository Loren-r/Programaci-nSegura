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
        private Usuario NOM_NIVEL;
        public frmPrincipal(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;

            lblUsuario.Text = usuarioActual.NOM_USUARIO;
            lblNivel.Text = usuarioActual.NOMBRE_NIVEL;
            if (NOM_NIVEL = "ADMINISTRADOR")
            {
                agregarUsuarioToolStripMenu.Visible = true;
            }
            else
            {
                agregarUsuarioToolStripMenu.Visible = false;
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
    }
}
