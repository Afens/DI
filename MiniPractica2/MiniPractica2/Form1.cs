using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPractica2
{
    public partial class Form1 : Form
    {
        Point anterior = new Point(12, -8);
        int a = 20;
        public Form1()
        {
            InitializeComponent();
        }

        private void Crear_Tick(object sender, EventArgs e)
        {
            int x=anterior.X, y=anterior.Y;           
            CheckBox cb = new CheckBox();            
            if (y + 20 > this.Size.Height - 15)
            {
                cb.Location = new Point(x + 20, 12);
            }
            else
            {
                cb.Location = new Point(x , y + 20);     
            }
            Controls.Add(cb);
            anterior = cb.Location;
            

            if (x > this.Size.Width - 15 || y > this.Size.Height - 15)
            {
                Crear.Enabled = false;
            }


        }

        private void Desmarcar_Tick(object sender, EventArgs e)
        {
            foreach (Object x in Controls)
            {
                if (x is CheckBox)
                    ((CheckBox)x).Checked = false;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }
    }
}
