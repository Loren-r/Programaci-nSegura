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
        public frmPrincipal(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;

            lblUsuario.Text = usuarioActual.NOM_USUARIO;
            lblNivel.Text = usuarioActual.NOMBRE_NIVEL;
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
    }
}
