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
        Point raton=new Point();
        public F1()
        {
            InitializeComponent();
        }

        private void F1_MouseMove(object sender, MouseEventArgs e)
        {
            Point boton = new Point(btn.Location.X, btn.Location.Y);
            int mov = 0;
            if (!e.Location.Equals(raton))
            {
                mov = velocidad(new Point(boton.X + btn.Width / 2, boton.Y + btn.Height / 2), new Point(e.Location.X, e.Location.Y));
                if (boton.X+btn.Width/2 > e.Location.X && boton.X+btn.Width<this.Width)
                {
                    boton.X += mov;
                }
                else if(boton.X > 0)
                {
                    boton.X -= mov;
                }
                if (boton.Y + btn.Height / 2 > e.Location.Y && boton.Y + btn.Height< this.Height)
                {
                    boton.Y += mov;
                }
                else if (boton.Y > 0)
                {
                    boton.Y -= mov;
                }
                btn.Location = boton;
            }
            raton.X = e.Location.X;
            raton.Y = e.Location.Y;

            //Thread.Sleep(100);
        }
        public int velocidad (Point a, Point b)
        {
            int vel;
            double dis = Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
            if (dis < 50) vel = 8;
            else if (dis < 100) vel = 6;
            else if (dis < 150) vel = 4;
            else if (dis < 200) vel = 2;
            else vel = 0;
            return vel;
        }
    }
}
