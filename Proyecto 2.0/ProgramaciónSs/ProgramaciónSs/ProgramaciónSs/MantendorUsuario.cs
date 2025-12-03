using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaciónSs
{


    public class MantendorUsuario
    {
        private string cadenaConexion = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|bdPrograciónSs.mdf;Integrated Security=True;Connect Timeout=30";
        private void CargarUsuario
            (string usuario, string nombre, string contraseña, string correo, string nivel)
        {

          SqlConnection con = new SqlConnection(cadenaConexion);
          SqlCommand cmd = new SqlCommand("AGREGAR_USUARIO", con);
          cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@NOM_USUARIO", SqlDbType.NVarChar);
            cmd.Parameters.Add("@NOMBRE_COMPLETO", SqlDbType.NVarChar);
            cmd.Parameters.Add("@CONTRASEÑA", SqlDbType.NVarChar);
            cmd.Parameters.Add("@CORREO", SqlDbType.NVarChar);
            cmd.Parameters.Add("@ID_NIVEL", SqlDbType.NVarChar);
            cmd.Parameters.Add("@OP", SqlDbType.NVarChar);

            cmd.Parameters["@NOM_USUARIO"].Value = Convert.ToString(usuario);
            

            SqlParameter registros = new SqlParameter("@NRO_REGISTRO", SqlDbType.Int);
            registros.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(registros);

            con.Open();
            cmd.EndExecuteNonQuery();

            int Registro = Convert.ToInt32(cmd.Parameters["@NRO_REGISTRO"].Value.ToString());

            if (Registro == 1)
            {
                MessageBox.Show("Se Ingreso Nuevo Usuario");
         
            }
            else
            {
                MessageBox.Show("Error al ingresar Nuevo Usuario");
            }
            con.Close();

        }

    }
}
