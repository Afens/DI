using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace botonCorre
{
    class Persona
    {
        int velocidad=3;
        int tamanno=30;
        Image img;
        Point posicion;
        int lejos;
        int espacio = 10;
        int crecimiento;

        public Persona(Size marco)
        {
            Random r = new Random();
            posicion = new Point(r.Next(marco.Width-tamanno), r.Next(marco.Height-tamanno));
            lejos = r.Next(100, 251);
            crecimiento = r.Next(1, 4);
            
        }


        public void mirar(Size marco, Point e)
        {
            if(lejos > Math.Sqrt(Math.Pow(posicion.X - e.X, 2) + Math.Pow(posicion.Y - e.Y, 2)))
            {
                huir(marco, e);
            }
        }
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

        public Point mostrar()
        {
            return posicion;
        }
        public Size tam()
        {
            return new Size(tamanno,tamanno);
        }



    }
}
