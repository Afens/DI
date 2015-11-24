using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cartas
{
    public partial class Selector : Form
    {
        public Selector()
        {
            InitializeComponent();
        }

        private void tipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            listaCartas.Items.Clear();
            ArrayList cartas = BD.listaCartas(tipos.SelectedItem.ToString());
            listaCartas.Items.AddRange(cartas.ToArray());
        }

        private void listaCartas_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Visible = !label1.Visible;
        }

        private void listaCartas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                    Carta form3 = new Carta((String) listaCartas.SelectedItem);
                    this.Hide();
                    form3.FormClosed += (s, args) => { this.Show(); };
                    form3.Show();
 
            }
        }
    }
}
