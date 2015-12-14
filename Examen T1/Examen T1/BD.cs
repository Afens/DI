using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_T1
{
    class BD
    {
        private static SqlConnection conection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=USUARIO-PC\\SQLEXPRESS;Initial Catalog=BDDientes;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            con.Open();
            return con;
        }
        public static Boolean validar(String nombre)
        {
            SqlConnection con = conection();
            SqlCommand orden = new SqlCommand();

            orden.CommandText = String.Format("SELECT COUNT(*) FROM Progenitor WHERE nombre='{0}'", nombre);
            orden.CommandType = CommandType.Text;
            orden.Connection = con;
            int a = (int)orden.ExecuteScalar();
            con.Close();

            if (a == 1)
                return true;
            else
                return false;
        }
        public static Boolean vacia()
        {
            SqlConnection con = conection();
            SqlCommand orden = new SqlCommand();

            orden.CommandText = String.Format("SELECT COUNT(*) FROM Progenitor");
            orden.CommandType = CommandType.Text;
            orden.Connection = con;
            int a = (int)orden.ExecuteScalar();
            con.Close();

            if (a >0)
                return false;
            else
                return true;
        }
        public static void agregarPadre(int id, String nombre)
        {
            SqlConnection con = conection();
            SqlCommand orden = new SqlCommand();

            orden.CommandText = String.Format("INSERT INTO Progenitor VALUES ('{0}','{1}')", id, nombre);
            orden.CommandType = CommandType.Text;
            orden.Connection = con;
            orden.ExecuteNonQuery();
        }
        public static void agregarHijos(int id, String nombre, String ciudad)
        {
            SqlConnection con = conection();
            SqlCommand orden = new SqlCommand();
            orden.CommandText = String.Format("INSERT INTO Nino VALUES ('{0}','{1}','{2}')", id, nombre, ciudad);
            orden.CommandType = CommandType.Text;
            orden.Connection = con;
            orden.ExecuteNonQuery();
        }
        public static void agregarRelaciones(int idP, int idN)
        {
            SqlConnection con = conection();
            SqlCommand orden = new SqlCommand();
            orden.CommandText = String.Format("INSERT INTO EsPadre VALUES ('{0}','{1}')", idP,idN);
            orden.CommandType = CommandType.Text;
            orden.Connection = con;
            orden.ExecuteNonQuery();
        }
        public static void agregarCae(int idN, int diente, int dia)
        {
            SqlConnection con = conection();
            SqlCommand orden = new SqlCommand();
            orden.CommandText = String.Format("INSERT INTO Cae VALUES ('{0}','{1}','{2}')", idN, diente, dia);
            orden.CommandType = CommandType.Text;
            orden.Connection = con;
            orden.ExecuteNonQuery();
        }

        public static ArrayList hijos(String nombre)
        {
            SqlConnection con = conection();
            SqlCommand orden = new SqlCommand();
            orden.CommandText = String.Format("SELECT n.nombre FROM Nino n, EsPadre e, Progenitor p WHERE p.nombre='{0}' and n.Id=e.idNino and p.Id=e.idPadre and n.Id=e.idNino", nombre);
            orden.CommandType = CommandType.Text;
            orden.Connection = con;

            SqlDataReader result = orden.ExecuteReader();
            ArrayList ninos = new ArrayList();

            while(result.Read())
                ninos.Add(result.GetValue(0));


            con.Close();
            return ninos;
        }

        public static ArrayList dientesCaidos(String nombre)
        {
            SqlConnection con = conection();
            SqlCommand orden = new SqlCommand();
            orden.CommandText = String.Format("SELECT c.NDiente FROM Nino n, Cae c WHERE n.nombre='{0}' and n.Id=c.idNino", nombre);
            orden.CommandType = CommandType.Text;
            orden.Connection = con;

            SqlDataReader result = orden.ExecuteReader();
            ArrayList dientes = new ArrayList();

            while (result.Read())
                dientes.Add(result.GetValue(0));

            con.Close();
            return dientes;
        }

        public static int idHijo(String hijo)
        {
            SqlConnection con = conection();
            SqlCommand orden = new SqlCommand();

            orden.CommandText = String.Format("SELECT Id FROM Nino where nombre='{0}'",hijo);
            orden.CommandType = CommandType.Text;
            orden.Connection = con;
            int a = (int)orden.ExecuteScalar();
            con.Close();

            return a;

        }

        public static int fechaValida()
        {
            SqlConnection con = conection();
            SqlCommand orden = new SqlCommand();
            orden.CommandType = CommandType.Text;
            orden.Connection = con;

            DateTime fecha = DateTime.Now;
            int codfecha;
            codfecha = int.Parse(fecha.ToString("yyyyMMdd"));
            bool rep = true;
            int a;

            while (rep)
            {
                codfecha = int.Parse(fecha.ToString("yyyyMMdd"));
                orden.CommandText = String.Format("SELECT count(*) FROM Cae where fecha='{0}'", codfecha);
                a = (int)orden.ExecuteScalar();
                if (a > 5)
                    fecha=fecha.AddDays(1);
                else
                    rep = false;

            }
            con.Close();

            return codfecha;
        }

        
        public static ArrayList tickets(String nombre)
        {
            SqlConnection con = conection();
            SqlCommand orden = new SqlCommand();
            DateTime fecha = DateTime.Now;
            int dia= int.Parse(fecha.ToString("yyyyMMdd"));
            orden.CommandText = String.Format("SELECT n.nombre, c.NDiente, c.fecha FROM Nino n, Progenitor p, esPadre e, Cae c "
                +" WHERE p.nombre='{0}' and p.Id=e.IdPadre and n.Id=e.IdNino and n.Id=c.IdNino and c.fecha>='{1}'", nombre, dia);
            orden.CommandType = CommandType.Text;
            orden.Connection = con;

            SqlDataReader result = orden.ExecuteReader();
            ArrayList dientes = new ArrayList();

            while (result.Read())
            {
                dientes.Add(result.GetValue(0));
                dientes.Add(result.GetValue(1));
                dientes.Add(result.GetValue(2));
            }
            con.Close();
            return dientes;
        }

        public static ArrayList tickets(int dia)
        {
            SqlConnection con = conection();
            SqlCommand orden = new SqlCommand();
            orden.CommandText = String.Format("SELECT n.nombre, n.ciudad FROM Nino n, Cae c "
                + " WHERE n.Id=c.IdNino and c.fecha='{0}'", dia);
            orden.CommandType = CommandType.Text;
            orden.Connection = con;

            SqlDataReader result = orden.ExecuteReader();
            ArrayList dientes = new ArrayList();

            while (result.Read())
            {
                dientes.Add(result.GetValue(0));
                dientes.Add(result.GetValue(1));
            }
            con.Close();
            return dientes;
        }
    }
}
