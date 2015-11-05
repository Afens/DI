using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP.ProgressBarr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void up_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value<progressBar1.Maximum)
            {
                progressBar1.Value += 1;
            }
        }

        private void down_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value > progressBar1.Minimum)
            {
                progressBar1.Value -= 1;
            }
        }

        private void progressBar2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.X > 50)
            {
                if (progressBar2.Value < progressBar1.Maximum)
                    progressBar2.Value += 10;
            } else
                if (progressBar2.Value > progressBar1.Minimum)
                    progressBar2.Value -= 10;
        }
        private void progressBar3_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.X > progressBar3.Value)
            {
                progressBar3.Value += 10;
            }
            else
                progressBar3.Value -= 10;
        }
        private void progressBar4_MouseClick(object sender, MouseEventArgs e)
        {           
                progressBar4.Value = e.X;          
        }
        
        private void progressBar5_MouseClick(object sender, MouseEventArgs e)
        {
            progressBar5.Value =(int)Math.Round((double)e.X * progressBar5.Maximum / progressBar5.Width);
            
            int percent = (int)(((double)(progressBar5.Value - progressBar5.Minimum) /
                        (double)(progressBar5.Maximum - progressBar5.Minimum)) * 100);
            using (Graphics gr = progressBar5.CreateGraphics())
            {
                gr.DrawString(percent.ToString() + "%", SystemFonts.DefaultFont, Brushes.Black,
                    new PointF(
                        progressBar5.Width / 2 - (
                            gr.MeasureString(percent.ToString() + "%", SystemFonts.DefaultFont)
                        .Width / 2.0F),
                        progressBar5.Height / 2 - (
                            gr.MeasureString(percent.ToString() + "%", SystemFonts.DefaultFont)
                        .Height / 2.0F)
                        )
                    );

            }

            Refresh();//


        }
        


    }
}
