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
    public partial class Raton : Form
    {
        public Raton()
        {
            InitializeComponent();
            actu();
            saveFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
        }

        private void actu()
        {
            DateTime hoy = DateTime.Now;
            actuHoy(hoy);
            actuMañana(hoy.AddDays(1));
            actuPasado(hoy.AddDays(2));
        }

        private void actuPasado(DateTime fecha)
        {
            pasado.Items.Clear();
            int dia = int.Parse(fecha.ToString("yyyyMMdd"));
            ArrayList datos = BD.tickets(dia);
            ListViewItem item;
            for (int i = 0; i < datos.Count; i += 2)
            {
                item = new ListViewItem();
                item.Text = datos[i].ToString();
                item.SubItems.Add(datos[i + 1].ToString());
                pasado.Items.Add(item);
            }
        }

        private void actuMañana(DateTime fecha)
        {
            mañana.Items.Clear();
            int dia = int.Parse(fecha.ToString("yyyyMMdd"));
            ArrayList datos = BD.tickets(dia);
            ListViewItem item;
            for (int i = 0; i < datos.Count; i += 2)
            {
                item = new ListViewItem();
                item.Text = datos[i].ToString();
                item.SubItems.Add(datos[i + 1].ToString());
                mañana.Items.Add(item);
            }
        }

        private void actuHoy(DateTime fecha)
        {
            hoy.Items.Clear();
            int dia = int.Parse(fecha.ToString("yyyyMMdd"));
            ArrayList datos = BD.tickets(dia);
            ListViewItem item;
            for (int i = 0; i < datos.Count; i += 2)
            {
                item = new ListViewItem();
                item.Text = datos[i].ToString();
                item.SubItems.Add(datos[i + 1].ToString());
                hoy.Items.Add(item);
            }
        }

        private void cerrar(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
