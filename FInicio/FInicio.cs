using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FInicio : Form
    {
        private Image[] imagenes;
        private int indiceActual = 0;

        public FInicio()
        {
            InitializeComponent();
            IniciarSlideshow();
        }

        private void IniciarSlideshow()
        {
            // Carga las imágenes directamente desde Resources
            imagenes = new Image[]
            {
            Properties.Resources._1foto,
            Properties.Resources._2foto,
            Properties.Resources._3foto,
            Properties.Resources._4foto,
            Properties.Resources.logodesertico,
            Properties.Resources.personaytexto,
            };

            MostrarImagen(indiceActual);

            timer1.Interval = 3000;
            timer1.Tick += Timer1_Tick;
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            indiceActual = (indiceActual + 1) % imagenes.Length;
            MostrarImagen(indiceActual);
        }

        private void MostrarImagen(int indice)
        {
            pictureBox1.Image = imagenes[indice];
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            timer1.Stop();
            base.OnFormClosing(e);
        }

        private void inicioDeSesiónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            pictureBox2.Visible = false;
        }

        private void acercaDeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // FormAcercaDe acercaDeForm = new FormAcercaDe();
            // acercaDeForm.Show();
        }

        private void teléfonoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Lógica para el teléfono
            MessageBox.Show("Número de teléfono: +52 633-129-9913");
        }

        private void whatsAppToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Lógica para WhatsApp
            MessageBox.Show("Mensajes al WhatsApp: +52 633-129-5818");

        }

        private void instagramToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Lógica para Instagram
            MessageBox.Show("Síguenos en Instagram como: @Terranova");
        }
    }
}
