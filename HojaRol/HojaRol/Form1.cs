using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HojaRol
{
    public partial class Form1 : Form
    {
        int[] statsBase = new int[5];
        Album album;
        bool nuevo=true;

        public Form1()
        {
            InitializeComponent();
        }


        // Termina la Aplicacion
        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // No permite elegir mas del maximo de habilidades y muestra cuantas hay selecionadas
        private void skill_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            bool checkeado = false;
            int total=0;
            //Comprobamos si estaba marcado
            foreach (var i in skill.CheckedItems)
                if (skill.Items[e.Index] == i)
                {
                    checkeado = true;
                    break;
                }

            //Si estaba marcado se desmarcara
            if (checkeado)
                total = skill.CheckedItems.Count - 1;
            //Si no estaba marcado y no puede marcarse se quedara igual
            else if (skill.CheckedItems.Count > int.Parse(habilTotal.Text) - 1)
            {
                e.NewValue = e.CurrentValue;
                total = skill.CheckedItems.Count;
            }
            //Si no estaba marcado y puede marcarse se marcara
            else
                total = skill.CheckedItems.Count + 1;

            //Mostramos cuantos selecionados habra
            habilSelect.Text = total.ToString();
        }

        //Cada 5 niveles consigue un punto de habilidad y 2 puntos de stats
        private void nivel_Changed(object sender, EventArgs e)
        {
            habilTotal.Text= Math.Ceiling(nivel.Value/5).ToString();
            validar(null,null);
            calculoVida(sender, e);
            calcularPuntosRestantes();
        }
        //Calcula los puntos Restantes
        private void calcularPuntosRestantes()
        {
            int aRepartir = (int)nivel.Value * 2 + 100;
            int total=0;
            total += int.Parse(fue.Text);
            total += int.Parse(des.Text);
            total += int.Parse(inte.Text);
            total += int.Parse(con.Text);
            total += int.Parse(def.Text);
            puntos.Text = (aRepartir - total).ToString();
        }

        //Al hacer clic para aumentar alguna estadistica, no puede superar 100, a quien se refiere depende del tag
        private void up_Click(object sender, EventArgs e)
        {
            if (int.Parse(puntos.Text) > 0)
            {
                int referencia = int.Parse(((PictureBox)sender).Tag.ToString());
                int nuevoValor;
                switch (referencia)
                {
                    case 1:
                        nuevoValor = (int.Parse(fue.Text) + 1);
                        if (nuevoValor <= 100)
                            fue.Text = nuevoValor.ToString();
                        break;
                    case 2:
                        nuevoValor = (int.Parse(des.Text) + 1);
                        if (nuevoValor <= 100)
                            des.Text = nuevoValor.ToString();
                        break;
                    case 3:
                        nuevoValor = (int.Parse(inte.Text) + 1);
                        if (nuevoValor <= 100)
                            inte.Text = nuevoValor.ToString();
                        break;
                    case 4:
                        nuevoValor = (int.Parse(con.Text) + 1);
                        if (nuevoValor <= 100)
                            con.Text = nuevoValor.ToString();
                        break;
                    case 5:
                        nuevoValor = (int.Parse(def.Text) + 1);
                        if (nuevoValor <= 100)
                            def.Text = nuevoValor.ToString();
                        break;
                }
                calcularPuntosRestantes();
            }
            
        }
        //Genera las stadisticas basicas del personaje
        private void dado_Click(object sender, EventArgs e)
        {
            int restante = 100;
            int valor;
            Random rnd = new Random();

            valor = rnd.Next(restante+1);
            fue.Text = valor.ToString();
            statsBase[0] = valor;
            restante -= valor;

            valor = rnd.Next(restante + 1);
            inte.Text = valor.ToString();
            statsBase[2] = valor;
            restante -= valor;

            valor = rnd.Next(restante + 1);
            des.Text = valor.ToString();
            statsBase[1] = valor;
            restante -= valor;

            valor = rnd.Next(restante + 1);
            con.Text = valor.ToString();
            statsBase[3] = valor;
            restante -= valor;

            def.Text = restante.ToString();
            statsBase[4] = restante;
            calcularPuntosRestantes();
        }
        // Cuando carga el formulario
        private void Form1_Load(object sender, EventArgs e)
        {
            album = new Album();
            album.importarPjs("..\\..\\datos.txt");
        }
        //Abre un dialogo para indicar desde donde queremos importar nuevos personajes
        private void btnImportar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            dialogo.DefaultExt = "txt";
            dialogo.Filter = "Archivo de texto (.txt)|*.txt|All files (.*)|*.*";
            DialogResult resultado = dialogo.ShowDialog();
            if (resultado == DialogResult.OK)
                album.importarPjs(dialogo.FileName);
            modo(false);
            cargarPersonaje();
        }
        //Abre un dialogo para indicar donde queremos exportar nuestros personajes
        private void btnExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialogo = new SaveFileDialog();
            dialogo.DefaultExt = "txt";
            dialogo.Filter = "Archivo de texto (.txt)|*.txt|All files (.*)|*.*";
            DialogResult resultado = dialogo.ShowDialog();
            if (resultado == DialogResult.OK)
                album.exportarPjs(dialogo.FileName);
        }
        // Carga los datos del personaje, si no hay ninguno creara uno nuevo
        private void cargarPersonaje()
        {
            Personaje p = album.obtenerPersonaje();
            if (p == null)
                btnNuevo_Click(null, null);
            else
            {
                nombre.Text=p.nombre;
                nivel.Value = p.nivel;
                if (p.genero)
                    masc.Checked = true;
                else
                    feme.Checked = true;
                raza.SelectedIndex = p.raza;
                prof.SelectedIndex = p.profesion;
                descrip.Text = p.descripcion;
                statsBase = p.statsBase;

                fue.Text = p.stats[0].ToString();
                des.Text = p.stats[1].ToString();
                inte.Text = p.stats[2].ToString();
                con.Text = p.stats[3].ToString();
                def.Text = p.stats[4].ToString();

                vidaTotal.Text = p.vidaTotal.ToString();
                vidaRestante.Value = p.vidaActual;

                foreach (int item in p.skills)
                {
                    skill.SetItemChecked(item, true);
                }

            }
        }
        //Borra los datos del personaje actual y carga el siguiente
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(!nuevo)
                album.eliminar();
            cargarPersonaje();
        }
        // Activa la creacion de un nuevo personaje
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            modo(true);
            limpiar();
        }
        //Limpia el texto de todos los campos
        private void limpiar()
        {
            nombre.Text = "";
            nivel.Value = 0;
                masc.Checked = false;
                feme.Checked = false;
            raza.SelectedItem = null;
            prof.SelectedItem = null;
            descrip.Text = "";

            for (int i = 0; i < statsBase.Length; i++)
            {
                statsBase[i] = 0;
            }
          
            fue.Text = 0.ToString();
            des.Text = 0.ToString();
            inte.Text = 0.ToString();
            con.Text = 0.ToString();
            def.Text = 0.ToString();
            vidaTotal.Text = 0.ToString();
            vidaRestante.Value = 0;

            for (int i = 0; i < skill.Items.Count; i++)
            {
                skill.SetItemChecked(i, false);
            }

        }
        //Cambiar de modo normal a modo crear
        private void modo(bool v)
        {
            nuevo = v;
            dado.Visible = v;
            nombre.Enabled = v;
            raza.Enabled = v;
            prof.Enabled = v;
            btnNuevo.Visible = !v;
            btnGuardar.Visible = false;
        }
        // Guardamos el personaje
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (nuevo)
                album.agregar(new Personaje());
            Personaje p=album.obtenerPersonaje();
            p.nombre = nombre.Text;
            p.nivel = (int)nivel.Value;
            if (masc.Checked)
                p.genero = true;
            else
                p.genero = false;
            p.raza = raza.SelectedIndex;
            p.profesion = prof.SelectedIndex;
            p.descripcion = descrip.Text;
            p.statsBase = statsBase;

            p.stats[0] = int.Parse(fue.Text);
            p.stats[1] = int.Parse(des.Text);
            p.stats[2] = int.Parse(inte.Text);
            p.stats[3] = int.Parse(con.Text);
            p.stats[4] = int.Parse(def.Text);

            p.vidaTotal= int.Parse(vidaTotal.Text);
            p.vidaTotal= (int)vidaRestante.Value;

            foreach (var i in skill.CheckedItems)
            {
                p.skills.Add(skill.Items.IndexOf(i));
            }
            modo(false);
            cargarPersonaje();
        }
        // Pone las skill con los stats basicos
        private void btnReset_Click(object sender, EventArgs e)
        {
            fue.Text = statsBase[0].ToString();
            des.Text = statsBase[1].ToString();
            inte.Text = statsBase[2].ToString();
            con.Text = statsBase[3].ToString();
            def.Text = statsBase[4].ToString();
            calcularPuntosRestantes();
        }

        //Activa el boton de guardar cuando se realiza algun cambio y todos los datos estan rellenos
        private void validar(object sender, EventArgs e)
        {
            btnGuardar.Visible = true;
        }
        private void cambiarImagen(object sender, EventArgs e)
        {
            string foto="";
            validar(null, null);
            int indice = raza.SelectedIndex;
            if (indice > -1)
            {
                foto += indice;
                if (feme.Checked)
                    foto += 0;
                else
                    foto += 1;
                foto += ".png";
                imagen.BackgroundImage = Image.FromFile(System.IO.Path.GetFullPath(@"..//..//imgs//" + foto));
            }
            else
                imagen.BackgroundImage = null;
        }
        //Pasa al siguiente Personaje
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            album.siguiente();
            cargarPersonaje();
        }
        //Pasa al anterior Personaje
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            album.anterior();
            cargarPersonaje();
        }
        // Accion cuando se cierra el formulario
        private void Form1_Closed(object sender, FormClosedEventArgs e)
        {
            album.exportarPjs("..\\..\\datos.txt");
        }

        //Calcula la vida maxima
        private void calculoVida(object sender, EventArgs e)
        {
            int vidaMax=(int.Parse(con.Text) + (int)nivel.Value)*500;
            vidaTotal.Text = vidaMax.ToString();
            vidaRestante.Maximum = vidaMax;
        }

        //Actualiza la barra de vida
        private void vidaRestante_ValueChanged(object sender, EventArgs e)
        {
            pgVida.Maximum = (int)vidaRestante.Maximum;
            pgVida.Value = (int)vidaRestante.Value;
            validar(null,null);
        }

    }
}
