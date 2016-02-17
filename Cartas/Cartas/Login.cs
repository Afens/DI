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
                    logear();                  
                }
                else if (registro.Checked) {
                    BD.crearUsuario(txtUser.Text, txtPass.Text);
                    logear();
                }
                else
                    error.Visible = true;
            }
            
        }

        private void logear()
        {
            error.Visible = false;
            Selector form2 = new Selector(txtUser.Text);
            this.Hide();
            form2.FormClosed += (s, args) => { this.Show(); };
            form2.Show();
        }

        private void imgClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void acercaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Creado Por Manuel Espinosa de los Monteros Delgado");
        }
    }
}
