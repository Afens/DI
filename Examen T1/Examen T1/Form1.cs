using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_T1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cargarDatos();
        }

        private void cargarDatos()
        {

            if (BD.vacia())
            {
                String cadena;
                String[] valores;
                StreamReader a = new StreamReader("..\\..\\Ficheros\\progenitor.txt");
                while ((cadena = a.ReadLine()) != null) { 
                    valores =cadena.Split('|');
                    BD.agregarPadre(int.Parse(valores[0]), valores[1]);
                }

                a = new StreamReader("..\\..\\Ficheros\\niño.txt");
                while ((cadena = a.ReadLine()) != null)
                {
                    valores = cadena.Split('|');
                    BD.agregarHijos(int.Parse(valores[0]), valores[1], valores[2]);
                }

                a = new StreamReader("..\\..\\Ficheros\\espadre.txt");
                while ((cadena = a.ReadLine()) != null)
                {
                    valores = cadena.Split('|');
                    BD.agregarRelaciones(int.Parse(valores[0]), int.Parse(valores[1]));
                }

                a = new StreamReader("..\\..\\Ficheros\\cae.txt");
                while ((cadena = a.ReadLine()) != null)
                {
                    valores = cadena.Split('|');
                    BD.agregarCae(int.Parse(valores[0]), int.Parse(valores[1]), int.Parse(valores[2]));
                }
            }
        }

        private void login(object sender, EventArgs e)
        {
            if(tbNombre.Text=="Ratoncito")
            {
                error.Visible = false;
                Raton form2 = new Raton();
                this.Hide();
                form2.FormClosed += (s, args) => { this.Show(); };
                form2.Show();
            }
            else if (BD.validar(tbNombre.Text))
            {
                error.Visible = false;
                Padres form2 = new Padres(tbNombre.Text);
                this.Hide();
                form2.FormClosed += (s, args) => { this.Show(); };
                form2.Show();
            }
            else
                error.Visible = true;
        }

        private void cerrar(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
