using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace botonCorre
{
    /*  */
    class Persona
    {
        int velocidad=3;
        int tamanno;
        Point posicion;
        int lejos;
        int espacio = 10;
        int crecimiento;

        /* Constructor de la persona,
        hay que pasarle el campo donde queremos que se situe */
        public Persona(Size marco)
        {
            Random r = new Random();
            posicion = new Point(r.Next(espacio,marco.Width-tamanno-espacio), 
                r.Next(espacio, marco.Height-tamanno-espacio));
            lejos = r.Next(100, 251);
            tamanno = r.Next(30, 50);
            crecimiento = r.Next(1, 4);           
        }

        /* Comprueba si el raton esta cerca de la posicion de la persona,
        en caso de que este llama a huir */
        public void mirar(Size marco, Point e)
        {
            if(lejos > Math.Sqrt(Math.Pow(posicion.X - e.X, 2) + Math.Pow(posicion.Y - e.Y, 2)))
            {
                huir(marco, e);
            }
        }
        /* Huye de la posicion del raton, respecto de la persona. */ 
        public void huir(Size marco, Point e)
        {
            if (posicion.X + tamanno / 2 > e.X && posicion.X + tamanno < marco.Width-espacio)
            {
                posicion.X += velocidad;
            }
            else if (posicion.X > 0+espacio)
            {
                posicion.X -= velocidad;
            }
            if (posicion.Y + tamanno / 2 > e.Y && posicion.Y + tamanno < marco.Height-espacio)
            {
                posicion.Y += velocidad;
            }
            else if (posicion.Y > 0+espacio)
            {
                posicion.Y -= velocidad;
            }
        }
        /* Devuelve la posicion de la Persona */
        public Point lugar()
        {
            return posicion;
        }
        /* Devuelve un nuevo Size de la persoan */
        public Size tam()
        {
            return new Size(tamanno,tamanno);
        }

        /* Hace crecer a la persona */
        public void crecer()
        {
            tamanno += crecimiento;
            lejos += crecimiento;
        }


    }
}
