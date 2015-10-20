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

namespace MiniPracticaRadioButton
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }



        private void radioButton_Click(object sender, EventArgs e)
        {
            int a = ((RadioButton)sender).TabIndex;
            
            foreach (Object p in ((RadioButton)sender).Parent.Parent.Controls)
            {
                if (p is Panel)
                {
                    foreach (RadioButton item in ((Panel)p).Controls)
                    {
                        if (item.TabIndex <= a)
                            item.Checked = true;
                        else
                            item.Checked = false;                        
                    }
                }
            }
            
            
        }
        /*
        private void grupo2_Click(object sender, EventArgs e)
        {
            Boolean a = true;
            foreach (RadioButton item in orden2)
            {
                item.Checked = a;
                if (item.Equals(sender))
                {
                    a = false;
                }
            }
        }*/
    }
}
