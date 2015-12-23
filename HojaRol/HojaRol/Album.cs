using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HojaRol
{
    class Album
    {
        int index=-1;
        private ArrayList personajes=new ArrayList();

        //Devuelve el numero de personajes en la lista
        public int count()
        {
            return personajes.Count;
        }
        public void anterior()
        {
            index--;
            if (index < 0 && index < personajes.Count - 1)
                index = 0;
        }
        public void siguiente()
        {
            index++;
            if (index > personajes.Count - 1)
                index = personajes.Count - 1;
        }
        //Agrega un personaje a la lista y se seleciona
        public void agregar(Personaje p)
        {
            personajes.Add(p);
            index = personajes.IndexOf(p);
        }

        //Devuelve el personaje actual
        public Personaje obtenerPersonaje()
        {
            if (index > -1 && index < personajes.Count)
                return (Personaje)personajes[index];
            else
                return null;
        }

        //Elimina un personaje de la lista y seleciona el anterior o siguiente disponible
        public void eliminar()
        {
            personajes.Remove(personajes[index]);
            index--;
            if (index <0 && index < personajes.Count - 1)
                index = 0;
        }

        //Importa los personajes desde el fichero de la ruta introducida
        public void importarPjs(String ruta)
        {
            StreamReader lector;
            string linea;
            Personaje p;
            if (File.Exists(ruta))
            {
                lector = new StreamReader(ruta);
                // leo el fichero linea a linea
                while ((linea = lector.ReadLine()) != null)
                    if ((p = Personaje.importar(linea)) != null)
                        personajes.Add(p);
                lector.Close();
            }
            index = 0;
        }

        //Exporta los personajes al fichero de la ruta introducida
        public void exportarPjs(String ruta)
        {
            StreamWriter escritor = new StreamWriter(ruta);
            foreach (Personaje p in personajes)
                escritor.WriteLine(p.exportar());
            escritor.Close();
        }

    }
}
