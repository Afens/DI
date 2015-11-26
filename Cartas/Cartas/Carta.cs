using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cartas
{
    public partial class Carta : Form
    {
        String usuario, carta;

        public Carta(String nombre)
        {
            InitializeComponent();
            usuario = nombre;         
            ArrayList datosCarta = BD.carta(usuario);
            carta = datosCarta[0].ToString();
            name.Text = carta;
            name.CreateGraphics().RotateTransform(45f);
            
            foto.Image = new Bitmap("..//..//../img/"+ datosCarta[2].ToString()+".png");
            marco.BackgroundImage = new Bitmap("..//..//../fondo/" + datosCarta[3].ToString() + ".png");
            desc.Text = datosCarta[1].ToString();
            cost.Text = datosCarta[4].ToString();
            atk.Text = datosCarta[5].ToString();
            hp.Text = datosCarta[6].ToString();
        }
    }
}
