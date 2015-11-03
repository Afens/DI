using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP.ProgressBarr
{
    class Class1 : ProgressBar
    {
        public override void Refresh()
        {
            base.Refresh();
            int percent = (int)(((double)(this.Value - this.Minimum) /
                       (double)(this.Maximum - this.Minimum)) * 100);
            using (Graphics gr = this.CreateGraphics())
            {
                gr.DrawString(percent.ToString() + "%", SystemFonts.DefaultFont, Brushes.Black,
                    new PointF(
                        this.Width / 2 - (
                            gr.MeasureString(percent.ToString() + "%", SystemFonts.DefaultFont)
                        .Width / 2.0F),
                        this.Height / 2 - (
                            gr.MeasureString(percent.ToString() + "%", SystemFonts.DefaultFont)
                        .Height / 2.0F)
                        )
                    );

            }
        }
    }
}
