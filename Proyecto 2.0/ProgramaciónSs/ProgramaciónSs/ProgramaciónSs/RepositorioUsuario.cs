using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaciónSs
{
    public class RepositorioUsuario
    {
        private string cadenaConexion = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|bdPrograciónSs.mdf;Integrated Security=True;Connect Timeout=30";
        public Usuario ValidarCredenciales(string usuario, string contraseña)
        {
            SqlConnection con = new SqlConnection(cadenaConexion);
            con.Open();

            SqlCommand cmd = new SqlCommand("VALIDAR_CREDENCIALES", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NOM_USUARIO", usuario);
            cmd.Parameters.AddWithValue("@CONTRASEÑA", contraseña);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (!reader.Read())
                {
                    return null;
                }
                else
                {
                    Usuario u = new Usuario
                    {
                        NOM_USUARIO = reader["NOM_USUARIO"].ToString(),
                        ID_NIVEL = Convert.ToInt32(reader["ID_NIVEL"]),
                        NOMBRE_NIVEL = reader["NOMBRE_NIVEL"].ToString()
                    };

                    return u;
                }
            }



        }
    }
}
