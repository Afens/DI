using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace botonCorre
{
    /* Clase que identifica cada Boton con la persona que le corresponde*/
    class PersonaBoton
    {
        public Persona pers;
        public Button btn;

        /* Constructor de la clase al que hay que pasarle el tamaño del contenedor
        y el boton al que asignaremos una persona que vamos a generar */
        public PersonaBoton(Size tam, Button boton)
        {
            pers = new Persona(tam);
            btn = boton;
            btn.BackgroundImage = Properties.Resources.g3;
            btn.BackgroundImageLayout = ImageLayout.Zoom;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Location = pers.lugar();
            btn.Size = pers.tam();    
        }
        /* Metodo al que se llama al mover el raton para que la persona compruebe
        si esta en peligro */
        public void actuRaton(Size campo, Point e)
        {
            pers.mirar(campo, e);
            actualizar();
            
        }
        /* Actualiza los datos del Boton con la nueva posicion de la persona
        a la que corresponde */
        public void actualizar()
        {
            btn.Location = pers.lugar();
            btn.Size = pers.tam();
        }
    }
}
