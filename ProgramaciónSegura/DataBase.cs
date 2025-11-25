using System;
using System.Collections.Generic;
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

}
