namespace Cartas
{
    partial class Selector
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listaCartas = new System.Windows.Forms.ListBox();
            this.tipos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listaCartas
            // 
            this.listaCartas.FormattingEnabled = true;
            this.listaCartas.Location = new System.Drawing.Point(77, 64);
            this.listaCartas.Name = "listaCartas";
            this.listaCartas.Size = new System.Drawing.Size(120, 147);
            this.listaCartas.TabIndex = 0;
            this.listaCartas.SelectedIndexChanged += new System.EventHandler(this.listaCartas_SelectedIndexChanged);
            this.listaCartas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listaCartas_KeyPress);
            // 
            // tipos
            // 
            this.tipos.FormattingEnabled = true;
            this.tipos.Items.AddRange(new object[] {
            "Neutral",
            "Mago",
            "Cazador",
            "Druida",
            "Guerrero",
            "Paladin",
            "Sacerdote",
            "Picaro",
            "Chaman",
            "Brujo"});
            this.tipos.Location = new System.Drawing.Point(77, 37);
            this.tipos.Name = "tipos";
            this.tipos.Size = new System.Drawing.Size(121, 21);
            this.tipos.TabIndex = 1;
            this.tipos.SelectedIndexChanged += new System.EventHandler(this.tipos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Selector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tipos);
            this.Controls.Add(this.listaCartas);
            this.Name = "Selector";
            this.Text = "Selector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listaCartas;
        private System.Windows.Forms.ComboBox tipos;
        private System.Windows.Forms.Label label1;
    }
}