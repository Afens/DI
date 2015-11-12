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

namespace MP.ficheros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFile.InitialDirectory = openFile.InitialDirectory;
            openFile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            comboBox2.Items.Clear();
            StreamReader a= new StreamReader("..\\..\\Ficheros\\"+ comboBox1.Text+".pro");
            
            string[] cadena = a.ReadLine().Split(',');
            comboBox2.Items.AddRange(cadena);
            a.Close();
            //System.IO.StreamReader

            //comboBox2.Items.AddRange(lista);
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            comboBox2.Items.Clear();
            StreamReader a = new StreamReader("..\\..\\Ficheros\\datos.pro");
            string cad;
            string[] cadena;
            while ((cad = a.ReadLine()) != null)
            {
                cadena = cad.Split(',');
                if (comboBox1.Text==cadena[0].ToString()){
                    comboBox2.Items.AddRange(cadena);
                    comboBox2.Items.Remove(cadena[0]);               
                }
            }
            a.Close();
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            comboBox2.Items.Clear();
            StreamReader a = new StreamReader("..\\..\\Ficheros\\completo.pro");
            string cad;
            string[] cadena;
            string[] divisor= { "|*|" };
            while ((cad = a.ReadLine()) != null)
            {
                cadena = cad.Split(divisor,StringSplitOptions.RemoveEmptyEntries);
                if (comboBox1.Text == cadena[0].ToString())
                {
                    comboBox2.Items.AddRange(cadena[1].Split(','));
                    
                }
            }
            a.Close();
        }

        private void import_Click(object sender, EventArgs e)
        {                     
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                StreamReader a = new StreamReader(openFile.FileName);
                text.Text = a.ReadToEnd();
                a.Close();
            }
        }
        private void export_Click(object sender, EventArgs e)
        {
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter a = new StreamWriter(saveFile.FileName);
                a.WriteLine(text.Text);
                a.Close();
            }
        }
    }
}
