namespace MP.Botonera
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Anterior = new System.Windows.Forms.Button();
            this.Siguiente = new System.Windows.Forms.Button();
            this.New = new System.Windows.Forms.Button();
            this.Borrar = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.Descartar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.p = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Anterior
            // 
            this.Anterior.Location = new System.Drawing.Point(2, 3);
            this.Anterior.Name = "Anterior";
            this.Anterior.Size = new System.Drawing.Size(21, 23);
            this.Anterior.TabIndex = 0;
            this.Anterior.Text = "<";
            this.Anterior.UseVisualStyleBackColor = true;
            this.Anterior.Click += new System.EventHandler(this.anterior);
            // 
            // Siguiente
            // 
            this.Siguiente.Location = new System.Drawing.Point(235, 3);
            this.Siguiente.Name = "Siguiente";
            this.Siguiente.Size = new System.Drawing.Size(21, 23);
            this.Siguiente.TabIndex = 1;
            this.Siguiente.Text = ">";
            this.Siguiente.UseVisualStyleBackColor = true;
            this.Siguiente.Click += new System.EventHandler(this.siguiente);
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(49, 3);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(37, 23);
            this.New.TabIndex = 2;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.newPersonaje);
            // 
            // Borrar
            // 
            this.Borrar.Location = new System.Drawing.Point(92, 3);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(50, 23);
            this.Borrar.TabIndex = 3;
            this.Borrar.Text = "Borrar";
            this.Borrar.UseVisualStyleBackColor = true;
            this.Borrar.Click += new System.EventHandler(this.borrar);
            // 
            // Modificar
            // 
            this.Modificar.Location = new System.Drawing.Point(148, 3);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(62, 23);
            this.Modificar.TabIndex = 4;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Click += new System.EventHandler(this.modificar);
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(3, 3);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(68, 23);
            this.Guardar.TabIndex = 5;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.guardar);
            // 
            // Descartar
            // 
            this.Descartar.Location = new System.Drawing.Point(92, 3);
            this.Descartar.Name = "Descartar";
            this.Descartar.Size = new System.Drawing.Size(68, 23);
            this.Descartar.TabIndex = 6;
            this.Descartar.Text = "Descartar";
            this.Descartar.UseVisualStyleBackColor = true;
            this.Descartar.Click += new System.EventHandler(this.descartar);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Guardar);
            this.panel1.Controls.Add(this.Descartar);
            this.panel1.Location = new System.Drawing.Point(61, 217);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 31);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.Anterior);
            this.panel2.Controls.Add(this.New);
            this.panel2.Controls.Add(this.Borrar);
            this.panel2.Controls.Add(this.Modificar);
            this.panel2.Controls.Add(this.Siguiente);
            this.panel2.Location = new System.Drawing.Point(12, 217);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 33);
            this.panel2.TabIndex = 10;
            // 
            // p
            // 
            this.p.AutoSize = true;
            this.p.Location = new System.Drawing.Point(3, 9);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(13, 13);
            this.p.TabIndex = 11;
            this.p.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "/";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(40, 9);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(13, 13);
            this.Total.TabIndex = 13;
            this.Total.Text = "0";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.p);
            this.panel3.Controls.Add(this.Total);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(114, 143);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(60, 31);
            this.panel3.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Anterior;
        private System.Windows.Forms.Button Siguiente;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Descartar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label p;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Panel panel3;
    }
}

