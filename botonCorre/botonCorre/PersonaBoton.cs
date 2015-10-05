using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace botonCorre
{
    class PersonaBoton
    {
        public Persona pers;
        public Button btn;

        public PersonaBoton(Size tam, Button boton)
        {
            pers = new Persona(tam);
            btn = boton;
            btn.BackgroundImage = Properties.Resources.Diana;
            btn.BackgroundImageLayout = ImageLayout.Zoom;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Location = pers.lugar();
            btn.Size = pers.tam();
            //btn.Click += new EventHandler();       
        }

        public void actuRaton(Size campo, Point e)
        {
            pers.mirar(campo, e);
            actualizar();
            
        }
        public void actualizar()
        {
            btn.Location = pers.lugar();
            btn.Size = pers.tam();
        }
    }
}
