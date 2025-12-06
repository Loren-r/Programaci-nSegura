using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            
            if (txtbContraseña.Text != txtbConfContraseña.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, inténtelo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiarContraseña();
                return;
            }


           
           

            MessageBox.Show("Usuario registrado correctamente");
        }


        private void limpiar()
        {
            txtbUsuario.Clear();
            txtbNombreApellido.Clear();
            txtbContraseña.Clear();
            txtbConfContraseña.Clear();
            txtbCorreo.Clear();
            cboxNivel.SelectedIndex = -1;
            txtbUsuario.Focus();
      
        }
        private void limpiarContraseña()
        {
            txtbContraseña.Clear();
            txtbConfContraseña.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}

