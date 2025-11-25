using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaciónSegura
{
    public static class DataBase
    {
        private static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\ProgramaciónS.mdf;Integrated Security = True; Connect Timeout=30";

        public static SqlConnection Open()
        {
            SqlConnection cn = new SqlConnection(connectionString);
            cn.Open();
            return cn;
        }
    }

    public static DataTable validarUsuario(string usuario, string contraseña)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = DataBase.Open())
            {
                SqlCommand cmd = new SqlCommand("VALIDAR_CREDENCIALES", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NOM_USUARIO", usuario);
                cmd.Parameters.AddWithValue("@CONTRASEÑA", contraseña);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                try
                {
                    da.Fill(dt);
                }
                catch (Exception)
                {
                    // Manejo de errores
                    throw;
                    
                }
                return dt;
            }
        }

    }
