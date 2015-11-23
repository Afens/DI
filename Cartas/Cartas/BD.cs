using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Cartas
{
    public static class BD
    {
        private static SqlConnection conection()
        {
            SqlConnection con= new SqlConnection();
            con.ConnectionString = "Data Source=USUARIO-PC\\SQLEXPRESS;Initial Catalog=Magic;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            con.Open();
            return con;
        }
        public static Boolean validar(String user, String pass)
        {
            SqlConnection con = conection();
            SqlCommand orden = new SqlCommand();
            

            orden.CommandText = String.Format("SELECT COUNT(*) FROM Usuario WHERE nick='{0}' AND pass='{1}'",user,pass);
            orden.CommandType = CommandType.Text;
            orden.Connection = con;
            int a=(int) orden.ExecuteScalar();
            con.Close();

            if (a == 1)
                return true;
            else
                return false;
        }
    }
}
