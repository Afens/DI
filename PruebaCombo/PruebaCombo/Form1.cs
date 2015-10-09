using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaCombo
{
    public partial class Form1 : Form
    {
        String[] lista = {"A", "B", "C"};
        String[] rangos = { "1-5", "6-10", "11-15" };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Ping");
            comboBox1.Items.AddRange(lista);
            //comboBox1.SelectedIndex=4;
            comboBox1.SelectedItem = "A";  
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(rangos);
            comboBox1.SelectedIndex = 0;



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            int a = comboBox1.SelectedIndex;
            for(int i =  1; i <= 5; i++)
            {
                comboBox2.Items.Add(a*5+i);
            }
            comboBox2.SelectedIndex = 0;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = comboBox2.SelectedItem.ToString();
        }
    }
}
