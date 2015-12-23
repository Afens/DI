namespace HojaRol
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
            this.imagen = new System.Windows.Forms.PictureBox();
            this.Datos = new System.Windows.Forms.Panel();
            this.nivel = new System.Windows.Forms.NumericUpDown();
            this.descrip = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.feme = new System.Windows.Forms.RadioButton();
            this.masc = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.prof = new System.Windows.Forms.ComboBox();
            this.raza = new System.Windows.Forms.ComboBox();
            this.Stadisticas = new System.Windows.Forms.Panel();
            this.vidaRestante = new System.Windows.Forms.NumericUpDown();
            this.btnReset = new System.Windows.Forms.PictureBox();
            this.pgVida = new System.Windows.Forms.ProgressBar();
            this.upDEF = new System.Windows.Forms.PictureBox();
            this.upPOD = new System.Windows.Forms.PictureBox();
            this.upINT = new System.Windows.Forms.PictureBox();
            this.upDes = new System.Windows.Forms.PictureBox();
            this.upFue = new System.Windows.Forms.PictureBox();
            this.puntos = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.dado = new System.Windows.Forms.PictureBox();
            this.vidaTotal = new System.Windows.Forms.Label();
            this.def = new System.Windows.Forms.Label();
            this.con = new System.Windows.Forms.Label();
            this.inte = new System.Windows.Forms.Label();
            this.des = new System.Windows.Forms.Label();
            this.fue = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Habilidades = new System.Windows.Forms.Panel();
            this.habilSelect = new System.Windows.Forms.Label();
            this.habilTotal = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.skill = new System.Windows.Forms.CheckedListBox();
            this.salir = new System.Windows.Forms.PictureBox();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).BeginInit();
            this.Datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nivel)).BeginInit();
            this.panel2.SuspendLayout();
            this.Stadisticas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vidaRestante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDEF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upPOD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upINT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upFue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dado)).BeginInit();
            this.Habilidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salir)).BeginInit();
            this.SuspendLayout();
            // 
            // imagen
            // 
            this.imagen.BackColor = System.Drawing.Color.Transparent;
            this.imagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imagen.Location = new System.Drawing.Point(459, 41);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(322, 323);
            this.imagen.TabIndex = 0;
            this.imagen.TabStop = false;
            // 
            // Datos
            // 
            this.Datos.BackColor = System.Drawing.Color.Transparent;
            this.Datos.BackgroundImage = global::HojaRol.Properties.Resources.boxh226;
            this.Datos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Datos.Controls.Add(this.nivel);
            this.Datos.Controls.Add(this.descrip);
            this.Datos.Controls.Add(this.panel2);
            this.Datos.Controls.Add(this.label6);
            this.Datos.Controls.Add(this.nombre);
            this.Datos.Controls.Add(this.label5);
            this.Datos.Controls.Add(this.label4);
            this.Datos.Controls.Add(this.label3);
            this.Datos.Controls.Add(this.label2);
            this.Datos.Controls.Add(this.label1);
            this.Datos.Controls.Add(this.prof);
            this.Datos.Controls.Add(this.raza);
            this.Datos.Location = new System.Drawing.Point(66, 41);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(302, 291);
            this.Datos.TabIndex = 1;
            // 
            // nivel
            // 
            this.nivel.Location = new System.Drawing.Point(20, 85);
            this.nivel.Name = "nivel";
            this.nivel.Size = new System.Drawing.Size(52, 20);
            this.nivel.TabIndex = 13;
            this.nivel.ValueChanged += new System.EventHandler(this.nivel_Changed);
            // 
            // descrip
            // 
            this.descrip.Location = new System.Drawing.Point(22, 192);
            this.descrip.Name = "descrip";
            this.descrip.Size = new System.Drawing.Size(254, 76);
            this.descrip.TabIndex = 12;
            this.descrip.Text = "";
            this.descrip.TextChanged += new System.EventHandler(this.validar);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.feme);
            this.panel2.Controls.Add(this.masc);
            this.panel2.Location = new System.Drawing.Point(93, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 20);
            this.panel2.TabIndex = 11;
            // 
            // feme
            // 
            this.feme.AutoSize = true;
            this.feme.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.feme.Location = new System.Drawing.Point(98, 3);
            this.feme.Name = "feme";
            this.feme.Size = new System.Drawing.Size(71, 17);
            this.feme.TabIndex = 1;
            this.feme.Text = "Femenino";
            this.feme.UseVisualStyleBackColor = true;
            // 
            // masc
            // 
            this.masc.AutoSize = true;
            this.masc.Checked = true;
            this.masc.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.masc.Location = new System.Drawing.Point(7, 3);
            this.masc.Name = "masc";
            this.masc.Size = new System.Drawing.Size(73, 17);
            this.masc.TabIndex = 0;
            this.masc.TabStop = true;
            this.masc.Text = "Masculino";
            this.masc.UseVisualStyleBackColor = true;
            this.masc.CheckedChanged += new System.EventHandler(this.cambiarImagen);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(155, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Genero";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(20, 36);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(259, 20);
            this.nombre.TabIndex = 8;
            this.nombre.TextChanged += new System.EventHandler(this.validar);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(17, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Descricion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(17, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nivel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(17, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(155, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Profesión";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(17, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Raza";
            // 
            // prof
            // 
            this.prof.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prof.FormattingEnabled = true;
            this.prof.Items.AddRange(new object[] {
            "Ladron",
            "Guardian",
            "Guerrero",
            "Ingeniero",
            "Elementalista",
            "Nigromante",
            "Guardabosques",
            "Hipnotizador",
            "Retornado"});
            this.prof.Location = new System.Drawing.Point(158, 136);
            this.prof.Name = "prof";
            this.prof.Size = new System.Drawing.Size(121, 21);
            this.prof.TabIndex = 2;
            this.prof.SelectedIndexChanged += new System.EventHandler(this.validar);
            // 
            // raza
            // 
            this.raza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.raza.FormattingEnabled = true;
            this.raza.Items.AddRange(new object[] {
            "Asura",
            "Charr",
            "Norm",
            "Humano"});
            this.raza.Location = new System.Drawing.Point(20, 136);
            this.raza.Name = "raza";
            this.raza.Size = new System.Drawing.Size(121, 21);
            this.raza.TabIndex = 1;
            this.raza.SelectedIndexChanged += new System.EventHandler(this.cambiarImagen);
            // 
            // Stadisticas
            // 
            this.Stadisticas.BackColor = System.Drawing.Color.Transparent;
            this.Stadisticas.BackgroundImage = global::HojaRol.Properties.Resources.boxh226;
            this.Stadisticas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Stadisticas.Controls.Add(this.vidaRestante);
            this.Stadisticas.Controls.Add(this.btnReset);
            this.Stadisticas.Controls.Add(this.pgVida);
            this.Stadisticas.Controls.Add(this.upDEF);
            this.Stadisticas.Controls.Add(this.upPOD);
            this.Stadisticas.Controls.Add(this.upINT);
            this.Stadisticas.Controls.Add(this.upDes);
            this.Stadisticas.Controls.Add(this.upFue);
            this.Stadisticas.Controls.Add(this.puntos);
            this.Stadisticas.Controls.Add(this.label19);
            this.Stadisticas.Controls.Add(this.dado);
            this.Stadisticas.Controls.Add(this.vidaTotal);
            this.Stadisticas.Controls.Add(this.def);
            this.Stadisticas.Controls.Add(this.con);
            this.Stadisticas.Controls.Add(this.inte);
            this.Stadisticas.Controls.Add(this.des);
            this.Stadisticas.Controls.Add(this.fue);
            this.Stadisticas.Controls.Add(this.label15);
            this.Stadisticas.Controls.Add(this.label14);
            this.Stadisticas.Controls.Add(this.label13);
            this.Stadisticas.Controls.Add(this.label12);
            this.Stadisticas.Controls.Add(this.label11);
            this.Stadisticas.Controls.Add(this.label10);
            this.Stadisticas.Controls.Add(this.label9);
            this.Stadisticas.Controls.Add(this.label8);
            this.Stadisticas.Controls.Add(this.label7);
            this.Stadisticas.Location = new System.Drawing.Point(66, 360);
            this.Stadisticas.Name = "Stadisticas";
            this.Stadisticas.Size = new System.Drawing.Size(302, 243);
            this.Stadisticas.TabIndex = 3;
            // 
            // vidaRestante
            // 
            this.vidaRestante.Location = new System.Drawing.Point(215, 75);
            this.vidaRestante.Name = "vidaRestante";
            this.vidaRestante.Size = new System.Drawing.Size(68, 20);
            this.vidaRestante.TabIndex = 14;
            this.vidaRestante.ValueChanged += new System.EventHandler(this.vidaRestante_ValueChanged);
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::HojaRol.Properties.Resources.descarga;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.Location = new System.Drawing.Point(231, 140);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(52, 45);
            this.btnReset.TabIndex = 35;
            this.btnReset.TabStop = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pgVida
            // 
            this.pgVida.BackColor = System.Drawing.Color.DarkRed;
            this.pgVida.Location = new System.Drawing.Point(173, 103);
            this.pgVida.Name = "pgVida";
            this.pgVida.Size = new System.Drawing.Size(108, 10);
            this.pgVida.TabIndex = 16;
            // 
            // upDEF
            // 
            this.upDEF.BackgroundImage = global::HojaRol.Properties.Resources.Gema;
            this.upDEF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.upDEF.Location = new System.Drawing.Point(120, 165);
            this.upDEF.Name = "upDEF";
            this.upDEF.Size = new System.Drawing.Size(20, 20);
            this.upDEF.TabIndex = 34;
            this.upDEF.TabStop = false;
            this.upDEF.Tag = "5";
            this.upDEF.Click += new System.EventHandler(this.up_Click);
            // 
            // upPOD
            // 
            this.upPOD.BackgroundImage = global::HojaRol.Properties.Resources.Gema;
            this.upPOD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.upPOD.Location = new System.Drawing.Point(120, 135);
            this.upPOD.Name = "upPOD";
            this.upPOD.Size = new System.Drawing.Size(20, 20);
            this.upPOD.TabIndex = 33;
            this.upPOD.TabStop = false;
            this.upPOD.Tag = "4";
            this.upPOD.Click += new System.EventHandler(this.up_Click);
            // 
            // upINT
            // 
            this.upINT.BackgroundImage = global::HojaRol.Properties.Resources.Gema;
            this.upINT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.upINT.Location = new System.Drawing.Point(120, 105);
            this.upINT.Name = "upINT";
            this.upINT.Size = new System.Drawing.Size(20, 20);
            this.upINT.TabIndex = 32;
            this.upINT.TabStop = false;
            this.upINT.Tag = "3";
            this.upINT.Click += new System.EventHandler(this.up_Click);
            // 
            // upDes
            // 
            this.upDes.BackgroundImage = global::HojaRol.Properties.Resources.Gema;
            this.upDes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.upDes.Location = new System.Drawing.Point(120, 75);
            this.upDes.Name = "upDes";
            this.upDes.Size = new System.Drawing.Size(20, 20);
            this.upDes.TabIndex = 31;
            this.upDes.TabStop = false;
            this.upDes.Tag = "2";
            this.upDes.Click += new System.EventHandler(this.up_Click);
            // 
            // upFue
            // 
            this.upFue.BackgroundImage = global::HojaRol.Properties.Resources.Gema;
            this.upFue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.upFue.Location = new System.Drawing.Point(120, 45);
            this.upFue.Name = "upFue";
            this.upFue.Size = new System.Drawing.Size(20, 20);
            this.upFue.TabIndex = 16;
            this.upFue.TabStop = false;
            this.upFue.Tag = "1";
            this.upFue.Click += new System.EventHandler(this.up_Click);
            // 
            // puntos
            // 
            this.puntos.AutoSize = true;
            this.puntos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.puntos.Location = new System.Drawing.Point(170, 217);
            this.puntos.Name = "puntos";
            this.puntos.Size = new System.Drawing.Size(13, 13);
            this.puntos.TabIndex = 30;
            this.puntos.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label19.Location = new System.Drawing.Point(52, 217);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(97, 13);
            this.label19.TabIndex = 29;
            this.label19.Text = "Puntos Disponibles";
            // 
            // dado
            // 
            this.dado.BackgroundImage = global::HojaRol.Properties.Resources.dado;
            this.dado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dado.Location = new System.Drawing.Point(173, 140);
            this.dado.Name = "dado";
            this.dado.Size = new System.Drawing.Size(52, 45);
            this.dado.TabIndex = 28;
            this.dado.TabStop = false;
            this.dado.Click += new System.EventHandler(this.dado_Click);
            // 
            // vidaTotal
            // 
            this.vidaTotal.AutoSize = true;
            this.vidaTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.vidaTotal.Location = new System.Drawing.Point(212, 47);
            this.vidaTotal.Name = "vidaTotal";
            this.vidaTotal.Size = new System.Drawing.Size(13, 13);
            this.vidaTotal.TabIndex = 27;
            this.vidaTotal.Text = "0";
            // 
            // def
            // 
            this.def.AutoSize = true;
            this.def.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.def.Location = new System.Drawing.Point(83, 171);
            this.def.Name = "def";
            this.def.Size = new System.Drawing.Size(13, 13);
            this.def.TabIndex = 26;
            this.def.Text = "0";
            this.def.TextChanged += new System.EventHandler(this.validar);
            // 
            // con
            // 
            this.con.AutoSize = true;
            this.con.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.con.Location = new System.Drawing.Point(83, 140);
            this.con.Name = "con";
            this.con.Size = new System.Drawing.Size(13, 13);
            this.con.TabIndex = 25;
            this.con.Text = "0";
            this.con.TextChanged += new System.EventHandler(this.calculoVida);
            // 
            // inte
            // 
            this.inte.AutoSize = true;
            this.inte.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.inte.Location = new System.Drawing.Point(83, 109);
            this.inte.Name = "inte";
            this.inte.Size = new System.Drawing.Size(13, 13);
            this.inte.TabIndex = 24;
            this.inte.Text = "0";
            this.inte.TextChanged += new System.EventHandler(this.validar);
            // 
            // des
            // 
            this.des.AutoSize = true;
            this.des.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.des.Location = new System.Drawing.Point(83, 78);
            this.des.Name = "des";
            this.des.Size = new System.Drawing.Size(13, 13);
            this.des.TabIndex = 23;
            this.des.Text = "0";
            this.des.TextChanged += new System.EventHandler(this.validar);
            // 
            // fue
            // 
            this.fue.AutoSize = true;
            this.fue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fue.Location = new System.Drawing.Point(83, 50);
            this.fue.Name = "fue";
            this.fue.Size = new System.Drawing.Size(13, 13);
            this.fue.TabIndex = 22;
            this.fue.Text = "0";
            this.fue.TextChanged += new System.EventHandler(this.validar);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(83, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "Stats";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(172, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Actual";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(172, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Total";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(212, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Vida";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(23, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "DEF";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(23, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "CON";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(23, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "INT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(23, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "DES";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(23, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "FUE";
            // 
            // Habilidades
            // 
            this.Habilidades.BackColor = System.Drawing.Color.Transparent;
            this.Habilidades.BackgroundImage = global::HojaRol.Properties.Resources.boxh226;
            this.Habilidades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Habilidades.Controls.Add(this.habilSelect);
            this.Habilidades.Controls.Add(this.habilTotal);
            this.Habilidades.Controls.Add(this.label18);
            this.Habilidades.Controls.Add(this.label17);
            this.Habilidades.Controls.Add(this.label16);
            this.Habilidades.Controls.Add(this.skill);
            this.Habilidades.Location = new System.Drawing.Point(459, 390);
            this.Habilidades.Name = "Habilidades";
            this.Habilidades.Size = new System.Drawing.Size(322, 213);
            this.Habilidades.TabIndex = 14;
            // 
            // habilSelect
            // 
            this.habilSelect.AutoSize = true;
            this.habilSelect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.habilSelect.Location = new System.Drawing.Point(229, 15);
            this.habilSelect.Name = "habilSelect";
            this.habilSelect.Size = new System.Drawing.Size(13, 13);
            this.habilSelect.TabIndex = 26;
            this.habilSelect.Text = "0";
            // 
            // habilTotal
            // 
            this.habilTotal.AutoSize = true;
            this.habilTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.habilTotal.Location = new System.Drawing.Point(271, 15);
            this.habilTotal.Name = "habilTotal";
            this.habilTotal.Size = new System.Drawing.Size(13, 13);
            this.habilTotal.TabIndex = 25;
            this.habilTotal.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label18.Location = new System.Drawing.Point(250, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(19, 13);
            this.label18.TabIndex = 24;
            this.label18.Text = "de";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label17.Location = new System.Drawing.Point(156, 15);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 13);
            this.label17.TabIndex = 23;
            this.label17.Text = "Selecionados";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Location = new System.Drawing.Point(28, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = "Habilidades";
            // 
            // skill
            // 
            this.skill.CheckOnClick = true;
            this.skill.FormattingEnabled = true;
            this.skill.Items.AddRange(new object[] {
            "Aumentar Velocidad",
            "Aumentar Fuerza",
            "Aumentar Destreza",
            "Aumentar Defensa",
            "Aumentar Inteligencia",
            "Cono de Hielo",
            "Bola de Fuego",
            "Charco Acido",
            "Magia del Caos",
            "Concentracion",
            "Disparo Certero",
            "Disparo Critico",
            "Golpe Preciso",
            "Aguantar Respiracion",
            "Bendicion del Fuego",
            "Bendicion del Agua",
            "Bendicion del Caos",
            "Bendicion de la Tierra",
            "Bendicion del Aire"});
            this.skill.Location = new System.Drawing.Point(31, 31);
            this.skill.Name = "skill";
            this.skill.Size = new System.Drawing.Size(262, 169);
            this.skill.TabIndex = 0;
            this.skill.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.skill_ItemCheck);
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.Transparent;
            this.salir.BackgroundImage = global::HojaRol.Properties.Resources.original;
            this.salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.salir.Location = new System.Drawing.Point(811, 12);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(29, 27);
            this.salir.TabIndex = 15;
            this.salir.TabStop = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(546, 647);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 23);
            this.btnExportar.TabIndex = 22;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(639, 647);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(75, 23);
            this.btnImportar.TabIndex = 23;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(310, 647);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 22;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(212, 647);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(114, 647);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 22;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(408, 647);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(25, 23);
            this.btnSiguiente.TabIndex = 22;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(66, 647);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(25, 23);
            this.btnAnterior.TabIndex = 22;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HojaRol.Properties.Resources.recycled_texture_background_by_sandeep_m_d6aeau9_PZ9chud;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(852, 746);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.Habilidades);
            this.Controls.Add(this.Stadisticas);
            this.Controls.Add(this.imagen);
            this.Controls.Add(this.Datos);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_Closed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
            this.Datos.ResumeLayout(false);
            this.Datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nivel)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Stadisticas.ResumeLayout(false);
            this.Stadisticas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vidaRestante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDEF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upPOD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upINT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upFue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dado)).EndInit();
            this.Habilidades.ResumeLayout(false);
            this.Habilidades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imagen;
        private System.Windows.Forms.Panel Datos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox prof;
        private System.Windows.Forms.ComboBox raza;
        private System.Windows.Forms.RichTextBox descrip;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton feme;
        private System.Windows.Forms.RadioButton masc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel Stadisticas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel Habilidades;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox salir;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nivel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckedListBox skill;
        private System.Windows.Forms.Label habilSelect;
        private System.Windows.Forms.Label habilTotal;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label vidaTotal;
        private System.Windows.Forms.Label def;
        private System.Windows.Forms.Label con;
        private System.Windows.Forms.Label inte;
        private System.Windows.Forms.Label des;
        private System.Windows.Forms.Label fue;
        private System.Windows.Forms.PictureBox dado;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label puntos;
        private System.Windows.Forms.PictureBox upFue;
        private System.Windows.Forms.ProgressBar pgVida;
        private System.Windows.Forms.PictureBox upDEF;
        private System.Windows.Forms.PictureBox upPOD;
        private System.Windows.Forms.PictureBox upINT;
        private System.Windows.Forms.PictureBox upDes;
        private System.Windows.Forms.PictureBox btnReset;
        private System.Windows.Forms.NumericUpDown vidaRestante;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
    }
}

