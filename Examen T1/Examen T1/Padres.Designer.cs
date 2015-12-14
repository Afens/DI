namespace Examen_T1
{
    partial class Padres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Padres));
            this.enBoca = new System.Windows.Forms.ListView();
            this.caidos = new System.Windows.Forms.ListView();
            this.tickets = new System.Windows.Forms.ListView();
            this.hijos = new System.Windows.Forms.ComboBox();
            this.diente = new System.Windows.Forms.ImageList(this.components);
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NDiente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // enBoca
            // 
            this.enBoca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.enBoca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.enBoca.LargeImageList = this.diente;
            this.enBoca.Location = new System.Drawing.Point(267, 106);
            this.enBoca.MultiSelect = false;
            this.enBoca.Name = "enBoca";
            this.enBoca.Size = new System.Drawing.Size(630, 98);
            this.enBoca.SmallImageList = this.diente;
            this.enBoca.TabIndex = 0;
            this.enBoca.TileSize = new System.Drawing.Size(50, 30);
            this.enBoca.UseCompatibleStateImageBehavior = false;
            this.enBoca.View = System.Windows.Forms.View.Tile;
            this.enBoca.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.itemDrag);
            // 
            // caidos
            // 
            this.caidos.AllowDrop = true;
            this.caidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.caidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.caidos.LargeImageList = this.diente;
            this.caidos.Location = new System.Drawing.Point(267, 237);
            this.caidos.Name = "caidos";
            this.caidos.Size = new System.Drawing.Size(630, 99);
            this.caidos.SmallImageList = this.diente;
            this.caidos.TabIndex = 0;
            this.caidos.TileSize = new System.Drawing.Size(50, 30);
            this.caidos.UseCompatibleStateImageBehavior = false;
            this.caidos.View = System.Windows.Forms.View.Tile;
            this.caidos.DragDrop += new System.Windows.Forms.DragEventHandler(this.caidosDrop);
            this.caidos.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragEnter);
            // 
            // tickets
            // 
            this.tickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.tickets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tickets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.NDiente,
            this.Fecha});
            this.tickets.LargeImageList = this.diente;
            this.tickets.Location = new System.Drawing.Point(68, 378);
            this.tickets.Name = "tickets";
            this.tickets.Size = new System.Drawing.Size(829, 98);
            this.tickets.SmallImageList = this.diente;
            this.tickets.TabIndex = 0;
            this.tickets.UseCompatibleStateImageBehavior = false;
            this.tickets.View = System.Windows.Forms.View.Details;
            // 
            // hijos
            // 
            this.hijos.BackColor = System.Drawing.Color.White;
            this.hijos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hijos.FormattingEnabled = true;
            this.hijos.Location = new System.Drawing.Point(533, 30);
            this.hijos.Name = "hijos";
            this.hijos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.hijos.Size = new System.Drawing.Size(361, 21);
            this.hijos.TabIndex = 1;
            this.hijos.SelectedIndexChanged += new System.EventHandler(this.actu);
            // 
            // diente
            // 
            this.diente.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("diente.ImageStream")));
            this.diente.TransparentColor = System.Drawing.Color.Transparent;
            this.diente.Images.SetKeyName(0, "diente.png");
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImage = global::Examen_T1.Properties.Resources.X;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Location = new System.Drawing.Point(902, -1);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(25, 25);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.cerrar);
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 321;
            // 
            // NDiente
            // 
            this.NDiente.Text = "Diente";
            this.NDiente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NDiente.Width = 118;
            // 
            // Fecha
            // 
            this.Fecha.Text = "Fecha Prevista";
            this.Fecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Fecha.Width = 389;
            // 
            // Padres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Examen_T1.Properties.Resources.fondo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(925, 500);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.hijos);
            this.Controls.Add(this.tickets);
            this.Controls.Add(this.caidos);
            this.Controls.Add(this.enBoca);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Padres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Padres";
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView enBoca;
        private System.Windows.Forms.ListView caidos;
        private System.Windows.Forms.ListView tickets;
        private System.Windows.Forms.ComboBox hijos;
        private System.Windows.Forms.ImageList diente;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader NDiente;
        private System.Windows.Forms.ColumnHeader Fecha;
    }
}