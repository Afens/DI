﻿using System;
using System.Collections;
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
    public partial class Carta : Form
    {
        String usuario;

        public Carta(String user, String carta)
        {
            InitializeComponent();
            usuario = user;         
            ArrayList datosCarta = BD.carta(carta);
            name.Text = carta;
            name.CreateGraphics().RotateTransform(45f);

            foto.Image=Image.FromFile(System.IO.Path.GetFullPath(@"..//..//img//picture//" + datosCarta[2].ToString() + ".png"));

            marco.BackgroundImage = Image.FromFile(System.IO.Path.GetFullPath(@"..//..//img//background//" + datosCarta[3].ToString() + ".png"));         
            desc.Text = datosCarta[1].ToString();
            cost.Text = datosCarta[4].ToString();
            atk.Text = datosCarta[5].ToString();
            hp.Text = datosCarta[6].ToString();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
