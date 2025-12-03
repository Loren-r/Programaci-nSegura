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
    public partial class frmMantenedorUsuario : Form
    {
        public frmMantenedorUsuario()
        {
            InitializeComponent();
        }

       

        private void lblContraseñaConfirmar_Click(object sender, EventArgs e)
        {

        }

        private void lblContraseñaM_Click(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal principalForm = new frmPrincipal();
            principalForm.Show();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string NOMBRE_COMPLETO = txtbNombreApellido.Text;
            string NOM_USUARIO = txtbUsuario.Text;
            string CORREO = txtbCorreo.Text;
            string CONTRASEÑA = txtbContraseña.Text;
            int ID_NIVEL;

           switch (cboxNivel.Text)
            {
                case "Persona":
                    ID_NIVEL = 1;
                    break;

                case "Empresa":
                    ID_NIVEL = 2;
                    break;

                case "Administrador":
                    ID_NIVEL = 3;
                    break;

                default:
                    MessageBox.Show("Seleccione un nivel válido");
                    return;

            }






        }
    }
}
