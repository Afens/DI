using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            bT1.Location = new Point(rnd.Next(this.Width - bT1.Width), rnd.Next(this.Height - bT1.Height));

        }

        private void bT1_Click(object sender, EventArgs e)
        {
            //timer1.Enabled = false;
            MessageBox.Show("Has Ganado");
            timer1.Interval = timer1.Interval - 100;
            //this.Close();
        }
    }
}
