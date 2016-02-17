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
            this.tipos = new System.Windows.Forms.ComboBox();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listaCartas = new System.Windows.Forms.ListView();
            this.imageListC = new System.Windows.Forms.ImageList(this.components);
            this.listTengo = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.tipos.Location = new System.Drawing.Point(298, 124);
            this.tipos.Name = "tipos";
            this.tipos.Size = new System.Drawing.Size(121, 21);
            this.tipos.TabIndex = 1;
            this.tipos.SelectedIndexChanged += new System.EventHandler(this.tipos_SelectedIndexChanged);
            // 
            // txtBuscador
            // 
            this.txtBuscador.Location = new System.Drawing.Point(721, 125);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(120, 20);
            this.txtBuscador.TabIndex = 0;
            this.txtBuscador.TextChanged += new System.EventHandler(this.txtBuscador_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(718, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Buscador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(296, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Filtro";
            // 
            // listaCartas
            // 
            this.listaCartas.AllowDrop = true;
            this.listaCartas.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listaCartas.ForeColor = System.Drawing.SystemColors.MenuText;
            this.listaCartas.Location = new System.Drawing.Point(681, 216);
            this.listaCartas.MultiSelect = false;
            this.listaCartas.Name = "listaCartas";
            this.listaCartas.Size = new System.Drawing.Size(188, 274);
            this.listaCartas.SmallImageList = this.imageListC;
            this.listaCartas.TabIndex = 7;
            this.listaCartas.UseCompatibleStateImageBehavior = false;
            this.listaCartas.View = System.Windows.Forms.View.List;
            this.listaCartas.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.itemDrag);
            this.listaCartas.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDrop);
            this.listaCartas.DragEnter += new System.Windows.Forms.DragEventHandler(this.carta_DragEnter);
            this.listaCartas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.mostrarDetalles);
            // 
            // imageListC
            // 
            this.imageListC.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListC.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListC.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listTengo
            // 
            this.listTengo.AllowDrop = true;
            this.listTengo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listTengo.ForeColor = System.Drawing.SystemColors.MenuText;
            this.listTengo.Location = new System.Drawing.Point(252, 216);
            this.listTengo.MultiSelect = false;
            this.listTengo.Name = "listTengo";
            this.listTengo.Size = new System.Drawing.Size(192, 274);
            this.listTengo.SmallImageList = this.imageListC;
            this.listTengo.TabIndex = 8;
            this.listTengo.UseCompatibleStateImageBehavior = false;
            this.listTengo.View = System.Windows.Forms.View.List;
            this.listTengo.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.itemDrag);
            this.listTengo.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDrop);
            this.listTengo.DragEnter += new System.Windows.Forms.DragEventHandler(this.carta_DragEnter);
            this.listTengo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.mostrarDetalles);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Cartas.Properties.Resources.X;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1052, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 26);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(234, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cartas que Tengo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(656, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 31);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cartas que Faltan";
            // 
            // Selector
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cartas.Properties.Resources.hearthstone_deck;
            this.ClientSize = new System.Drawing.Size(1091, 596);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listTengo);
            this.Controls.Add(this.listaCartas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscador);
            this.Controls.Add(this.tipos);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Selector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selector";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.carta_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox tipos;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listaCartas;
        private System.Windows.Forms.ImageList imageListC;
        private System.Windows.Forms.ListView listTengo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}