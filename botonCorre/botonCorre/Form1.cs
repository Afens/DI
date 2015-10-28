using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace botonCorre
{
    public partial class F1 : Form
    {
        int cont=0;
        ArrayList personas = new ArrayList();
        public F1()
        {
            InitializeComponent();
            //Creamos el primer Boton
            nacer();
        }
        /* Metodo que se usa para hacer nacer un Boton y la Persona correspondiente */
        private void nacer()
        {
            Button btn = new Button();
            Controls.Add(btn);
            btn.Click += new EventHandler(matar);     
            personas.Add(new PersonaBoton(this.Size,btn));
        }
        /* Metodo que se ejecuta cada vez que se mueve el raton */
        private void F1_MouseMove(object sender, MouseEventArgs e)
        {
            //Hacemos que todas las personas comprueben si estan cerca del raton
            foreach (PersonaBoton person in personas)
            {
                person.actuRaton(this.Size, e.Location);
            }

        }
        /* Metodo que se ejecuta cada vez que el timer hace un Tick  */
        private void timer1_Tick(object sender, EventArgs e)
        {           
            // Hace crecer a todas las personas que tenemos
            foreach (PersonaBoton persona in personas)
            {
                persona.pers.crecer();
                persona.actualizar();
            }
            // Cada 3 Tick creamos una nueva persona
            if (cont % 3 == 0)
                nacer();
            cont++;
        }

        /* Metodo usado al hacer clic en un boton */ 
        public void matar(object Sender, EventArgs e)
        {
            int i = 0;
            /* Buscamos en boton en el ArrayList de personas,
            lo eliminamos de Contols y del ArrayList */
            foreach (PersonaBoton completa in personas)
            {
                if (completa.btn==Sender)
                {
                    Controls.Remove((Button)Sender);
                    
                    break;
                }
                i++;
            }
            personas.RemoveAt(i);

            //Si no quedan mas personas muestra un mensaje de que has ganado
            if (personas.Count==0)
            {
                timer1.Stop();
                MessageBox.Show("Has Ganado");
            }
        }
    }
}
