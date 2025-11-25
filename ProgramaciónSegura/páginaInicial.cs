using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaciónSegura
{
    public partial class páginaInicial : Form
    {
        public páginaInicial()
        {
            InitializeComponent();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cerrarSesiónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            inicio_sesion inicio_Sesion = new inicio_sesion();
            this.Hide();
            inicio_Sesion.Show();
        }
    }
}
