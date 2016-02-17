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
            iconos();
        }

        private void iconos()
        {
            imageListC.Images.Add(Properties.Resources.Druid_icon);
            imageListC.Images.Add(Properties.Resources.Hunter_icon);
            imageListC.Images.Add(Properties.Resources.Mage_icon);
            imageListC.Images.Add(Properties.Resources.Paladin_icon);
            imageListC.Images.Add(Properties.Resources.Priest_icon);
            imageListC.Images.Add(Properties.Resources.Warlock_icon);
            imageListC.Images.Add(Properties.Resources.Warrior_icon);
            imageListC.Images.Add(Properties.Resources.Rogue_icon);
            imageListC.Images.Add(Properties.Resources.Shaman_icon);
            imageListC.Images.Add(Properties.Resources.Gema);
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
            ArrayList lista = BD.listaCartas(usuario, tipos.SelectedItem.ToString(), txtBuscador.Text.ToString());
            foreach (String carta in lista)
            {
                listaCartas.Items.Add(obtener(carta));
            }


            listTengo.Items.Clear();
            ArrayList cartasTengo = BD.listaTengo(usuario, tipos.SelectedItem.ToString(), txtBuscador.Text.ToString());
            foreach (String carta in cartasTengo)
            {
                listTengo.Items.Add(obtener(carta));
            }

        }

        private ListViewItem obtener(String carta)
        {
            ListViewItem lvi = new ListViewItem(carta);
            String clase = BD.clase(carta);
            clase = clase.ToLower();
            if (clase == "druida")
            {
                lvi.ImageIndex = 0;
            }
            else if (clase == "cazador")
            {
                lvi.ImageIndex = 1;
            }
            else if (clase == "mago")
            {
                lvi.ImageIndex = 2;
            }
            else if (clase == "paladin")
            {
                lvi.ImageIndex = 3;
            }
            else if (clase == "sacerdote")
            {
                lvi.ImageIndex = 4;
            }
            else if (clase == "brujo")
            {
                lvi.ImageIndex = 5;
            }
            else if (clase == "guerrero")
            {
                lvi.ImageIndex = 6;
            }
            else if (clase == "picaro")
            {
                lvi.ImageIndex = 7;
            }
            else if (clase == "chaman")
            {
                lvi.ImageIndex = 8;
            }
            else if (clase == "neutral")
            {
                lvi.ImageIndex = 9;
            }
            return lvi;
        }

        private void detalles(object sender)
        {
            Carta form3 = new Carta(usuario, ((ListView)sender).SelectedItems[0].Text);
            this.Hide();
            form3.FormClosed += (s, args) => { this.Show(); };
            form3.Show();
        }
        private void carta_ItemDrag(object sender, ItemDragEventArgs e)
        {
            ListView a = (ListView)sender;
            a.DoDragDrop(a.SelectedItems, DragDropEffects.All);
        }

        private void carta_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mostrarDetalles(object sender, MouseEventArgs e)
        {
            detalles(sender);
        }

        private void itemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(((ListView)sender).SelectedItems[0].Text, DragDropEffects.All);
        }

        private void dragDrop(object sender, DragEventArgs e)
        {
            String carta = e.Data.GetData(DataFormats.Text).ToString();
            if (sender == listTengo)
            {
                if (!BD.exist(usuario,carta)) {
                    BD.agregar(usuario, carta);
                    actu();
                }
            }
            else
            {
                BD.eliminar(usuario, carta);
                actu();
            }
        }
    }
}
