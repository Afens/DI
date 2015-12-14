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

namespace Examen_T1
{
    public partial class Padres : Form
    {
        String padre;
        public Padres(String padre)
        {
            InitializeComponent();
            this.padre = padre;
            cargarHijos(padre);
        }

        private void cargarHijos(String padre)
        {
            ArrayList ninos = BD.hijos(padre);
            foreach (String item in ninos)
            {
                hijos.Items.Add(item);
            }
            hijos.SelectedIndex = 0;
        }

        private void cerrar(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dientesCaidos(ArrayList dCaidos)
        {
            caidos.Clear();
            for (int i = 0; i < dCaidos.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = 0;
                item.Text = dCaidos[i].ToString();
                caidos.Items.Add(item);
            }
        }
        private void dientesTiene(ArrayList dCaidos)
        {
            enBoca.Clear();
            for (int i = 1; i <= 32; i++)
            {
                if (!dCaidos.Contains(i))
                {
                    ListViewItem item = new ListViewItem();
                    item.ImageIndex = 0;
                    item.Text = i.ToString();
                    enBoca.Items.Add(item);
                }
            }
        }

        private void actu(object sender, EventArgs e)
        {
            ArrayList d = BD.dientesCaidos(hijos.Text);
            dientesCaidos(d);
            dientesTiene(d);
            actuTikects();
        }

        private void actuTikects()
        {
            tickets.Items.Clear();
            ArrayList datos = BD.tickets(padre);
            ListViewItem item;
            for (int i = 0; i < datos.Count; i+=3)
            {
                item = new ListViewItem();
                item.Text = datos[i].ToString();
                item.SubItems.Add(datos[i + 1].ToString());
                item.SubItems.Add(datos[i + 2].ToString());
                tickets.Items.Add(item);
            }
        }

        private void itemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(((ListView)sender).FocusedItem, DragDropEffects.All);
        }

        private void dragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void caidosDrop(object sender, DragEventArgs e)
        {          
            int codfecha = BD.fechaValida();
            int nDiente = int.Parse(((ListViewItem)e.Data.GetData(typeof(ListViewItem))).Text);
            int idHijo = BD.idHijo(hijos.Text);
            BD.agregarCae(idHijo, nDiente, codfecha);
            actu(null, null);
        }
    }
}
