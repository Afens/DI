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

namespace MiniPractica
{
    public partial class Form1 : Form
    {

        ArrayList orden = new ArrayList();
        ArrayList orden2 = new ArrayList();
        ArrayList progreso = new ArrayList();
        public Form1()
        {
            InitializeComponent();
            checkBox7.Checked = true;
            checkBox8.Checked = true;

            progreso.Add(checkBox10);
            progreso.Add(checkBox11);
            progreso.Add(checkBox12);
            progreso.Add(checkBox13);
            progreso.Add(checkBox14);
        }
        //Solo permiter marcar 2 checBox maximo, desmarca al resto
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (((CheckBox)sender).Checked) //Si el pulsado se queda a true desmarcar los demas
            {
                if (!sender.Equals(checkBox1)) checkBox1.Checked = false;
                if (!sender.Equals(checkBox2)) checkBox2.Checked = false;
                if (!sender.Equals(checkBox3)) checkBox3.Checked = false;
            }
        }

        //Solo permiter marcar 2 checBox maximo, desmarca al primero que se marcara
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked) // Si el pulsado queda true
            {
                orden.Add(sender);
                if (orden.Count > 2) // y hay 2 o mas pulsados
                {
                    ((CheckBox)orden[0]).Checked = false; //borra el primero del arrayList
                }
            }
            else //Si el pulsado queda false
            {
                orden.Remove(sender); //se borra del arrayList
            }

        }

        //combinacion de los 2 anteriores para que siempre esten 2 marcados
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                orden2.Add(sender);
                if (orden2.Count > 2)
                {
                    ((CheckBox)orden2[0]).Checked = false;
                }
            }
            else
            {
                orden2.Remove(sender);
                if (!sender.Equals(checkBox7)) checkBox7.Checked = true;
                if (!sender.Equals(checkBox8)) checkBox8.Checked = true;
                if (!sender.Equals(checkBox9)) checkBox9.Checked = true;
            }

        }



    
        private void checkBox_Click(object sender, EventArgs e)
        {
            ((CheckBox)sender).Checked = true;
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            int indice;
            if (((CheckBox)sender).Checked)
            {
                indice=progreso.IndexOf(sender)-1;
                if(indice>=0)
                    ((CheckBox)progreso[indice]).Checked = true;
            }
            else
            {
                indice = progreso.IndexOf(sender)+1;
                if (indice < progreso.Count)
                    ((CheckBox)progreso[indice]).Checked = false;
                
            }

        }

        


    }
}
