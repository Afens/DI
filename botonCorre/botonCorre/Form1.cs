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
            nacer();
        }
        
        private void nacer()
        {
            Button btn = new Button();
            Controls.Add(btn);
            btn.Click += new EventHandler(matar);     
            personas.Add(new PersonaBoton(this.Size,btn));
        }
        private void F1_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (PersonaBoton person in personas)
            {
                person.actuRaton(this.Size, e.Location);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {           
            
            foreach (PersonaBoton persona in personas)
            {
                persona.pers.crecer();
                persona.actualizar();
            }
            if (cont % 3 == 0)
                nacer();
            cont++;
        }

        public void matar(object Sender, EventArgs e)
        {
            int i = 0;
            foreach (PersonaBoton completa in personas)
            {
                if (completa.btn==Sender)
                {
                    Controls.Remove((Button)Sender);
                    //completa.btn.Dispose();
                    break;
                }
                i++;
            }
            personas.RemoveAt(i);

            if (personas.Count==0)
            {
                timer1.Stop();
                MessageBox.Show("Has Ganado");
            }
        }
    }
}
