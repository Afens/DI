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
            label1.Text = x.ToString();
            label2.Text = y.ToString();
            Point posicion;
            if(x>this.Size.Width-15 && y > this.Size.Height - 15)
            {
                Crear.Enabled = false;
            }
            else
            {
                if (y + 20 > this.Size.Height - 15)
                {
                    posicion = new Point(x + 20, y);
                }
                else
                {
                    posicion = new Point(x , y + 20);
                }
                CheckBox cb = new CheckBox();
                Controls.Add(cb);
                cb.Location = posicion;
                anterior = posicion;
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
    }
}
