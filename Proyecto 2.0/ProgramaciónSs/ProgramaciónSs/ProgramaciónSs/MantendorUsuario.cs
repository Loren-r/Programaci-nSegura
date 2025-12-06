using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaciónSs
{


    public class MantendorUsuario
    {
        private string cadenaConexion = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|bdPrograciónSs.mdf;Integrated Security=True;Connect Timeout=30";
        public void CargarUsuario
            (string usuario, string nombre, string contraseña, string correo, string nivel)
        {
            try
            {
               using(SqlConnection con = new SqlConnection(cadenaConexion))
                {
                    using(SqlCommand cmd = new SqlCommand("SP_AGREGAR_USUARIO", con))
                    {


                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@NOM_USUARIO", SqlDbType.NVarChar);
                        cmd.Parameters.Add("@NOMBRE_COMPLETO", SqlDbType.NVarChar);
                        cmd.Parameters.Add("@CONTRASEÑA", SqlDbType.NVarChar);
                        cmd.Parameters.Add("@CORREO", SqlDbType.NVarChar);



                        int ID_NIVEL = 0;
                        switch (nivel)
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
                        cmd.Parameters.Add("@ID_NIVEL", SqlDbType.Int).Value = ID_NIVEL;

                        cmd.Parameters["@NOM_USUARIO"].Value = Convert.ToString(usuario);
                        cmd.Parameters["@NOMBRE_COMPLETO"].Value = Convert.ToString(nombre);
                        cmd.Parameters["@CONTRASEÑA"].Value = Convert.ToString(contraseña);
                        cmd.Parameters["@CORREO"].Value = Convert.ToString(correo);


                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Usuario insertado correctamente");

                    }

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }



        }

    }
}
