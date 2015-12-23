namespace Cartas
{
    partial class Carta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carta));
            this.name = new System.Windows.Forms.Label();
            this.cost = new System.Windows.Forms.Label();
            this.atk = new System.Windows.Forms.Label();
            this.hp = new System.Windows.Forms.Label();
            this.foto = new System.Windows.Forms.PictureBox();
            this.marco = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.desc = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).BeginInit();
            this.marco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(126, 299);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(235, 13);
            this.name.TabIndex = 0;
            this.name.Text = " nombre nombre nombre nombre nombre nombre";
            // 
            // cost
            // 
            this.cost.AutoSize = true;
            this.cost.Font = new System.Drawing.Font("Tw Cen MT", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cost.ForeColor = System.Drawing.SystemColors.Menu;
            this.cost.Location = new System.Drawing.Point(71, 32);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(41, 47);
            this.cost.TabIndex = 1;
            this.cost.Text = "0";
            // 
            // atk
            // 
            this.atk.AutoSize = true;
            this.atk.BackColor = System.Drawing.Color.Transparent;
            this.atk.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atk.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.atk.Location = new System.Drawing.Point(71, 493);
            this.atk.Name = "atk";
            this.atk.Size = new System.Drawing.Size(42, 46);
            this.atk.TabIndex = 2;
            this.atk.Text = "0";
            // 
            // hp
            // 
            this.hp.AutoSize = true;
            this.hp.BackColor = System.Drawing.Color.Transparent;
            this.hp.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hp.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.hp.Location = new System.Drawing.Point(374, 493);
            this.hp.Name = "hp";
            this.hp.Size = new System.Drawing.Size(42, 46);
            this.hp.TabIndex = 3;
            this.hp.Text = "0";
            // 
            // foto
            // 
            this.foto.BackColor = System.Drawing.Color.Transparent;
            this.foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.foto.Image = ((System.Drawing.Image)(resources.GetObject("foto.Image")));
            this.foto.InitialImage = null;
            this.foto.Location = new System.Drawing.Point(129, 16);
            this.foto.Name = "foto";
            this.foto.Size = new System.Drawing.Size(227, 271);
            this.foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.foto.TabIndex = 6;
            this.foto.TabStop = false;
            // 
            // marco
            // 
            this.marco.BackColor = System.Drawing.Color.Transparent;
            this.marco.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("marco.BackgroundImage")));
            this.marco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.marco.Controls.Add(this.pictureBox1);
            this.marco.Controls.Add(this.foto);
            this.marco.Controls.Add(this.desc);
            this.marco.Controls.Add(this.hp);
            this.marco.Controls.Add(this.name);
            this.marco.Controls.Add(this.cost);
            this.marco.Controls.Add(this.atk);
            this.marco.Location = new System.Drawing.Point(185, 80);
            this.marco.Name = "marco";
            this.marco.Size = new System.Drawing.Size(464, 575);
            this.marco.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cartas.Properties.Resources.gem;
            this.pictureBox1.Location = new System.Drawing.Point(228, 324);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 37);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // desc
            // 
            this.desc.AutoSize = true;
            this.desc.Location = new System.Drawing.Point(125, 381);
            this.desc.MaximumSize = new System.Drawing.Size(250, 100);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(247, 100);
            this.desc.TabIndex = 7;
            this.desc.Text = resources.GetString("desc.Text");
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.BackgroundImage = global::Cartas.Properties.Resources.X;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit.Location = new System.Drawing.Point(822, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(27, 24);
            this.exit.TabIndex = 9;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Carta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cartas.Properties.Resources.hearthstone_heroes_of_warcraft_box_sword_hd_wallpaper_92185;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(861, 838);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.marco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Carta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carta";
            ((System.ComponentModel.ISupportInitialize)(this.foto)).EndInit();
            this.marco.ResumeLayout(false);
            this.marco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label cost;
        private System.Windows.Forms.Label atk;
        private System.Windows.Forms.Label hp;
        private System.Windows.Forms.PictureBox foto;
        private System.Windows.Forms.Panel marco;
        private System.Windows.Forms.Label desc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox exit;
    }
}