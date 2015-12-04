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
            this.components = new System.ComponentModel.Container();
            this.listaCartas = new System.Windows.Forms.ListBox();
            this.tipos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listTengo = new System.Windows.Forms.ListBox();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageListC = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // listaCartas
            // 
            this.listaCartas.FormattingEnabled = true;
            this.listaCartas.Location = new System.Drawing.Point(296, 108);
            this.listaCartas.Name = "listaCartas";
            this.listaCartas.Size = new System.Drawing.Size(120, 147);
            this.listaCartas.TabIndex = 3;
            this.listaCartas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listaCartas_KeyPress);
            // 
            // tipos
            // 
            this.tipos.FormattingEnabled = true;
            this.tipos.Items.AddRange(new object[] {
            "Todas",
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
            this.tipos.Location = new System.Drawing.Point(295, 50);
            this.tipos.Name = "tipos";
            this.tipos.Size = new System.Drawing.Size(121, 21);
            this.tipos.TabIndex = 1;
            this.tipos.SelectedIndexChanged += new System.EventHandler(this.tipos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(442, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // listTengo
            // 
            this.listTengo.FormattingEnabled = true;
            this.listTengo.Location = new System.Drawing.Point(69, 108);
            this.listTengo.Name = "listTengo";
            this.listTengo.Size = new System.Drawing.Size(120, 147);
            this.listTengo.TabIndex = 2;
            // 
            // txtBuscador
            // 
            this.txtBuscador.Location = new System.Drawing.Point(69, 50);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(120, 20);
            this.txtBuscador.TabIndex = 0;
            this.txtBuscador.TextChanged += new System.EventHandler(this.txtBuscador_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Buscador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Filtro";
            // 
            // listView1
            // 
            this.listView1.LargeImageList = this.imageListC;
            this.listView1.Location = new System.Drawing.Point(164, 108);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(126, 168);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // imageListC
            // 
            this.imageListC.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListC.ImageSize = new System.Drawing.Size(100, 100);
            this.imageListC.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Selector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 350);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscador);
            this.Controls.Add(this.listTengo);
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
        private System.Windows.Forms.ListBox listTengo;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageListC;
    }
}