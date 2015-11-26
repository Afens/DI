using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cartas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ok_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==Convert.ToChar(Keys.Enter))
            {

                if (BD.validar(txtUser.Text, txtPass.Text))
                {

                    error.Visible = false;
                    Selector form2 = new Selector();
                    this.Hide();
                    form2.FormClosed += (s, args) => { this.Show(); };
                    form2.Show();
                }
                else
                    error.Visible = true;
            }
            
        }


    }
}
