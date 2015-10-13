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
        ArrayList cbs = new ArrayList();
        ArrayList orden = new ArrayList();
        ArrayList cbs2 = new ArrayList();
        ArrayList orden2 = new ArrayList();
        public Form1()
        {
            InitializeComponent();
            cbs.Add(checkBox1);
            cbs.Add(checkBox2);
            cbs.Add(checkBox3);
            cbs2.Add(checkBox7);
            cbs2.Add(checkBox8);
            cbs2.Add(checkBox9);
            checkBox7.Checked = true;
            checkBox8.Checked = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                foreach (CheckBox c in cbs)
                {
                    if (!c.Equals(sender))
                        c.Checked = false;
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                orden.Add(sender);
                if (orden.Count > 2)
                {
                    ((CheckBox)orden[0]).Checked = false;
                }
            }
            else
            {
                orden.Remove(sender);
            }

        }
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
                foreach (CheckBox c in cbs2)
                {
                    if (!c.Equals(sender))
                        c.Checked = true;
                }
            }

        }
    }
}
