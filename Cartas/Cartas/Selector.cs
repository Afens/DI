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
        String usuario;
        public Selector(String user)
        {
            InitializeComponent();
            usuario = user;
            tipos.SelectedIndex = 0;
        }

        private void tipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            actu();
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            actu();
        }

        private void actu()
        {
            listaCartas.Items.Clear();
            listView1.Items.Clear();
            imageListC.Images.Clear();
            ArrayList cartasNoTengo = BD.listaCartas(usuario, tipos.SelectedItem.ToString(),txtBuscador.Text.ToString());
            listaCartas.Items.AddRange(cartasNoTengo.ToArray());
            String carta;
            ListViewItem item;
            for (int i = 0; i < cartasNoTengo.Count; i++)
            {
                carta = (String) cartasNoTengo[i];
                imageListC.Images.Add(Image.FromFile(System.IO.Path.GetFullPath(@"..//..//img//fondo//" + BD.clase(carta) + ".png")));
                item = new ListViewItem();
                item.ImageIndex = i;
                item.Text = carta;
                listView1.Items.Add(item);

            }
            

            


            listTengo.Items.Clear();
            ArrayList cartasTengo = BD.listaTengo(usuario, tipos.SelectedItem.ToString(), txtBuscador.Text.ToString());
            listTengo.Items.AddRange(cartasTengo.ToArray());
        }

        private void listaCartas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                    Carta form3 = new Carta(usuario, (String) listaCartas.SelectedItem);
                    this.Hide();
                    form3.FormClosed += (s, args) => { this.Show(); };
                    form3.Show();
 
            }
        }

        
    }
}
