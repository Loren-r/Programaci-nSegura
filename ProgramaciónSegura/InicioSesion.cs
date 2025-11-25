using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProgramaciónSegura
{
    public partial class inicio_sesion : Form
    {
        public inicio_sesion()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                    }

        private void linkL(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblojo_Click(object sender, EventArgs e)
        {

        }

        private void btnOjo_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuarioPe.Text == "" || txtContraseñaPe.Text =="")
            {
                MessageBox.Show("Porfavor escriba su usuario y/o contraseña.");
                    return;
            }
            try
            { 
                using (SqlConnection cn = DataBase.Open()) 
              {

                    SqlCommand cmd = new SqlCommand("VALIDAR_CREDENCIALES", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    
                    { 
                        cmd.Parameters.AddWithValue("@NOM_USUARIO", txtUsuarioPe.Text);
                cmd.Parameters.AddWithValue("@CONTRASEÑA", txtContraseñaPe.Text);
                
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                cn.Close();
                int contar = ds.Tables[0].Rows.Count;
                if (contar == 1)
                {
                    MessageBox.Show("Ingreso Satisfactorio");
                    this.Hide();
                    páginaInicial pagInicial = new páginaInicial();
                    pagInicial.Show();
                }
                else
                {
                    MessageBox.Show("Ingreso Fallido");
                }
               }
              }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inicio_sesion_Load(object sender, EventArgs e)
        {

        }
    }
}
