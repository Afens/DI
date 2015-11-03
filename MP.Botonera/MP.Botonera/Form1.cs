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

namespace MP.Botonera
{
    public partial class Form1 : Form
    {
        ArrayList datos=new ArrayList();
        Persona actual;
        public Form1()
        {
            InitializeComponent();            
            inicio();
        }

        private void inicio()
        {
            actual= new Persona();
            modoEditar(true);
        }

        private void newPersonaje(object sender, EventArgs e)
        {
            actual=new Persona();
            modoEditar(true);
        }
        private void modoEditar(Boolean a)
        {
            panel2.Visible = !a;
            panel1.Visible = a;
            textBox1.ReadOnly = !a;

            actualizarDatos();
                     
        }

        private void actualizarDatos()
        {
            int pos = datos.IndexOf(actual)+1;
            int cont = datos.Count;
            if (!datos.Contains(actual))
            {
                pos=pos+1;
                cont=cont+1;
            }
            p.Text = pos.ToString();
            Total.Text = cont.ToString();

            textBox1.Text = actual.valor;
            if (pos == 1)
                Anterior.Enabled = false;
            else
                Anterior.Enabled = true;
            
            if (pos == cont)            
                Siguiente.Enabled = false;
            else
                Siguiente.Enabled = true;
        }

        private void guardar(object sender, EventArgs e)
        {
            actual.valor = textBox1.Text;
            if (!datos.Contains(actual))
            {
                datos.Add(actual);
            }
            modoEditar(false);
            
        }

        private void descartar(object sender, EventArgs e)
        {
            if (datos.Contains(actual))
            {
                modoEditar(false);           
            }
            else
            {
                if (datos.Count<1)
                {
                    actualizarDatos();
                    MessageBox.Show("Tienes que crear un personaje");
                }
                else
                {
                    actual =(Persona)datos[datos.Count - 1];
                    modoEditar(false);                   
                }
            }
            
        }

        private void borrar(object sender, EventArgs e)
        {
            datos.Remove(actual);
            if (datos.Count < 1)
            {
                MessageBox.Show("No hay mas personajes, crea uno nuevo");
                inicio();
            }
            else
            {
                actual = (Persona)datos[0];
                actualizarDatos();
            }
        }

        private void modificar(object sender, EventArgs e)
        {
            modoEditar(true);
        }

        private void anterior(object sender, EventArgs e)
        {
            actual =(Persona)datos[datos.IndexOf(actual) - 1];
            actualizarDatos();
        }

        private void siguiente(object sender, EventArgs e)
        {
            actual = (Persona)datos[datos.IndexOf(actual) + 1];
            actualizarDatos();
        }
    }
}
