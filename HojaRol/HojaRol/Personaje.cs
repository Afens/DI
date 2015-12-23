using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HojaRol
{
    class Personaje
    {
        public string nombre;
        public int nivel;
        public bool genero;
        public int raza;
        public int profesion;
        public string descripcion;
        public int[] statsBase;
        public int[] stats;
        public int vidaTotal;
        public int vidaActual;
        public ArrayList skills;

        public Personaje()
        {
            statsBase = new int[5];
            stats = new int[5];
            skills = new ArrayList();
        }
        public string exportar()
        {
            string cadena = "";
            cadena += nombre + ";";
            cadena += nivel + ";";
            if (genero)
                cadena += 1 + ";";
            else
                cadena += 0 + ";";

            cadena += raza + ";";
            cadena += profesion + ";";
            cadena += descripcion + ";";

            for (int i = 0; i < statsBase.Length; i++)
            {
                cadena += statsBase[i] + ".";
            }
            cadena += ";";

            for (int i = 0; i < stats.Length; i++)
            {
                cadena += stats[i] + ".";
            }
            cadena += ";";
            cadena += vidaTotal + ";";
            cadena += vidaActual + ";";

            for (int i = 0; i < skills.Count; i++)
            {
                cadena += skills[i] + ".";
            }
            cadena += "ç"+cadena.GetHashCode();

            return cadena;
        }
        public static Personaje importar(String linea)
        {
            String[] comprobaciones = linea.Split('ç');
            String[] datos;
            String[] aux;
            Personaje p=null;
            if (comprobaciones[0].GetHashCode() == int.Parse(comprobaciones[1]))
            {
                p = new Personaje();
                datos = comprobaciones[0].Split(';');
                p.nombre = datos[0];
                p.nivel = int.Parse(datos[1]);
                if (int.Parse(datos[2]) == 1)
                    p.genero = true;
                else
                    p.genero = false;
                p.raza = int.Parse(datos[3]);
                p.profesion = int.Parse(datos[4]);
                p.descripcion = datos[5];

                aux = datos[6].Split('.');
                for (int i = 0; i < p.statsBase.Length; i++)
                {
                    p.statsBase[i] = int.Parse(aux[i]);
                }
                aux = datos[7].Split('.');
                for (int i = 0; i < p.stats.Length; i++)
                {
                    p.stats[i] = int.Parse(aux[i]);
                }

                p.vidaTotal = int.Parse(datos[8]);
                p.vidaActual = int.Parse(datos[9]);
                aux = datos[10].Split();
                for (int i = 0; i < aux.Length; i++)
                {
                    p.skills.Add(int.Parse(aux[i]));
                }
                
            }
            return p;
        }

    }
}
