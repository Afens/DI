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
            this.name = new System.Windows.Forms.Label();
            this.cost = new System.Windows.Forms.Label();
            this.atk = new System.Windows.Forms.Label();
            this.hp = new System.Windows.Forms.Label();
            this.desc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(114, 129);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(42, 13);
            this.name.TabIndex = 0;
            this.name.Text = "nombre";
            // 
            // cost
            // 
            this.cost.AutoSize = true;
            this.cost.Location = new System.Drawing.Point(28, 30);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(33, 13);
            this.cost.TabIndex = 1;
            this.cost.Text = "coste";
            // 
            // atk
            // 
            this.atk.AutoSize = true;
            this.atk.Location = new System.Drawing.Point(34, 237);
            this.atk.Name = "atk";
            this.atk.Size = new System.Drawing.Size(40, 13);
            this.atk.TabIndex = 2;
            this.atk.Text = "ataque";
            // 
            // hp
            // 
            this.hp.AutoSize = true;
            this.hp.Location = new System.Drawing.Point(237, 237);
            this.hp.Name = "hp";
            this.hp.Size = new System.Drawing.Size(27, 13);
            this.hp.TabIndex = 3;
            this.hp.Text = "vida";
            // 
            // desc
            // 
            this.desc.Location = new System.Drawing.Point(82, 169);
            this.desc.Multiline = true;
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(112, 55);
            this.desc.TabIndex = 5;
            // 
            // Carta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.hp);
            this.Controls.Add(this.atk);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.name);
            this.Name = "Carta";
            this.Text = "Carta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label cost;
        private System.Windows.Forms.Label atk;
        private System.Windows.Forms.Label hp;
        private System.Windows.Forms.TextBox desc;
    }
}