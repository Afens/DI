namespace Cartas
{
    partial class Login
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
            this.user = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.error = new System.Windows.Forms.Label();
            this.imgClose = new System.Windows.Forms.PictureBox();
            this.imgNewUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNewUser)).BeginInit();
            this.SuspendLayout();
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(80, 44);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(43, 13);
            this.user.TabIndex = 0;
            this.user.Text = "Usuario";
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Location = new System.Drawing.Point(80, 111);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(61, 13);
            this.pass.TabIndex = 1;
            this.pass.Text = "Contraseña";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(83, 60);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 2;
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ok_KeyPress);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(83, 127);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 3;
            this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ok_KeyPress);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(61, 163);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(148, 13);
            this.error.TabIndex = 4;
            this.error.Text = "Usuario/Contraseña no valido";
            this.error.Visible = false;
            // 
            // imgClose
            // 
            this.imgClose.Location = new System.Drawing.Point(254, 1);
            this.imgClose.Name = "imgClose";
            this.imgClose.Size = new System.Drawing.Size(28, 28);
            this.imgClose.TabIndex = 6;
            this.imgClose.TabStop = false;
            // 
            // imgNewUser
            // 
            this.imgNewUser.Location = new System.Drawing.Point(83, 193);
            this.imgNewUser.Name = "imgNewUser";
            this.imgNewUser.Size = new System.Drawing.Size(100, 32);
            this.imgNewUser.TabIndex = 7;
            this.imgNewUser.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.imgNewUser);
            this.Controls.Add(this.imgClose);
            this.Controls.Add(this.error);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.imgClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNewUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.PictureBox imgClose;
        private System.Windows.Forms.PictureBox imgNewUser;
    }
}

