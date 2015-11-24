using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace Cartas
{
    public static class BD
    {
        private static SqlConnection conection()
        {
            SqlConnection con= new SqlConnection();
            con.ConnectionString = "Data Source=USUARIO-PC\\SQLEXPRESS;Initial Catalog=Cartas;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
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
        public static ArrayList listaCartas(String tipo)
        {
            SqlConnection con = conection();
            SqlCommand orden = new SqlCommand();
            orden.CommandText = String.Format("SELECT Nombre FROM Carta WHERE clase='{0}'",tipo);
            orden.CommandType = CommandType.Text;
            orden.Connection = con;

            SqlDataReader result = orden.ExecuteReader();
            ArrayList listaCartas=new ArrayList();
            while (result.Read())
            {
                listaCartas.Add(result.GetString(0));
            }
            con.Close();
            return listaCartas;
        }
        public static ArrayList carta(String nombre)
        {
            SqlConnection con = conection();
            SqlCommand orden = new SqlCommand();
            orden.CommandText = String.Format("SELECT * FROM Carta WHERE nombre='{0}'", nombre);
            orden.CommandType = CommandType.Text;
            orden.Connection = con;

            SqlDataReader result = orden.ExecuteReader();
            ArrayList listaCartas = new ArrayList();

            if (result.Read())
                for (int i = 0; i < result.FieldCount; i++)
                {
                    listaCartas.Add(result.GetValue(i));
                }
                          
            con.Close();
            return listaCartas;
        }
    }
}
