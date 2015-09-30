using System;
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
        Persona person1;
        public F1()
        {
            InitializeComponent();
            person1 = new Persona(this.Size);
            btn.Location = person1.mostrar();
            btn.Size = person1.tam();
        }
        
        private void F1_MouseMove(object sender, MouseEventArgs e)
        {
            person1.mirar(this.Size, e.Location);
            btn.Location = person1.mostrar();
            btn.Size = person1.tam();

        }
        
    }
}
