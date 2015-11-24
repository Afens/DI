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
        public Carta(String nombre)
        {
            InitializeComponent();
            ArrayList datosCarta = BD.carta(nombre);
            name.Text = datosCarta[0].ToString();
            desc.Text = datosCarta[1].ToString();
            cost.Text = datosCarta[4].ToString();
            atk.Text = datosCarta[5].ToString();
            hp.Text = datosCarta[6].ToString();
        }
    }
}
