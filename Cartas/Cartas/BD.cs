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
        //Realiza la conecion con la BBDD
        private static SqlConnection conection()
        {
            SqlConnection con= new SqlConnection();
            //con.ConnectionString = "Data Source=USUARIO-PC\\SQLEXPRESS;Initial Catalog=Cartas;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            con.ConnectionString= "Data Source = WIN10-AFENS; Initial Catalog = Cartas; Integrated Security = True; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            con.Open();
            return con;
        }

        //Comprobar si el usuario con esa contraseña es valido
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

        public static void crearUsuario(String usuario, String pass)
        {
            SqlConnection con = conection();
            SqlCommand orden = new SqlCommand();

            orden.CommandText = String.Format("INSERT INTO Usuario VALUES('{0}','{1}')", usuario, pass);
            orden.CommandType = System.Data.CommandType.Text;
            orden.Connection = con;
            orden.ExecuteNonQuery();

            con.Close();
        }
        //Devuelve un array de cartas que no tiene el usuario
        public static ArrayList listaCartas(String usuario, String tipo,String filtro)
        {
            SqlConnection con = conection();
            SqlCommand orden = new SqlCommand();
            if (tipo == "Todas")
                orden.CommandText = String.Format("SELECT Nombre FROM Carta WHERE nombre like '%{0}%' AND nombre NOT IN (SELECT nombreCarta FROM tiene where nombreUsuario='{1}')", filtro, usuario);
            else
                orden.CommandText = String.Format("SELECT Nombre FROM Carta WHERE clase='{0}' AND nombre like '%{1}%' AND nombre NOT IN (SELECT nombreCarta FROM tiene where nombreUsuario='{2}')", tipo, filtro, usuario);
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
        //Devuelve un array de las cartas que tiene el usuario
        public static ArrayList listaTengo(String usuario, String tipo, String filtro)
        {
            SqlConnection con = conection();
            SqlCommand orden = new SqlCommand();
            if (tipo == "Todas") 
                orden.CommandText = String.Format("SELECT Nombre FROM Carta WHERE nombre like '%{0}%' AND nombre IN (SELECT nombreCarta FROM tiene where nombreUsuario='{1}')", filtro, usuario);
            else
                orden.CommandText = String.Format("SELECT Nombre FROM Carta WHERE clase='{0}' AND nombre like '%{1}%' AND nombre IN (SELECT nombreCarta FROM tiene where nombreUsuario='{2}')", tipo, filtro, usuario);
            orden.CommandType = CommandType.Text;
            orden.Connection = con;

            SqlDataReader result = orden.ExecuteReader();
            ArrayList listaCartas = new ArrayList();
            while (result.Read())
            {
                listaCartas.Add(result.GetString(0));
            }
            con.Close();
            return listaCartas;
        }
        //Devuelve de que clase es la carta
        public static String clase(String carta)
        {
            SqlConnection con = conection();
            SqlCommand orden = new SqlCommand();
            orden.CommandText = String.Format("SELECT clase FROM Carta WHERE nombre='{0}' ", carta);
            orden.CommandType = CommandType.Text;
            orden.Connection = con;
            String tipo = (String)orden.ExecuteScalar();
            con.Close();
            return tipo;
        }
        //Devuelve los datos de la carta en un array
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
        //Agrega una carta al usuario
        public static void agregar(String user, String carta)
        {
            SqlConnection con = conection();
            SqlCommand orden = new SqlCommand();

            orden.CommandText = String.Format("INSERT INTO Tiene VALUES ('{0}','{1}')", user, carta);
            orden.CommandType = CommandType.Text;
            orden.Connection = con;
            orden.ExecuteScalar();
            con.Close();
        }
        //Elimina una carta del usuario
        public static void eliminar(String user, String carta)
        {
            SqlConnection con = conection();
            SqlCommand orden = new SqlCommand();

            orden.CommandText = String.Format("DELETE FROM Tiene WHERE nombreUsuario='{0}' and nombreCarta='{1}'", user, carta);
            orden.CommandType = CommandType.Text;
            orden.Connection = con;
            orden.ExecuteScalar();
            con.Close();
        }
        public static Boolean exist(String usuario, String carta)
        {

            SqlConnection con = conection();
            SqlCommand orden = new SqlCommand();

            orden.CommandText = String.Format("SELECT COUNT(*) FROM Tiene WHERE nombreUsuario='{0}' AND nombreCarta='{1}'", usuario, carta);
            orden.CommandType = System.Data.CommandType.Text;
            orden.Connection = con;
            int resultado = (int)orden.ExecuteScalar();
            con.Close();

            if (resultado == 1)
            {
                return true;
            }

            return false;
        }
    }
}
