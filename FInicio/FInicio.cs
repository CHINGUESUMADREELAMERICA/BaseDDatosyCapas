using CapaDatos1.Modelos;
using CapaNegocio;
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
        private Image[] imagenes = Array.Empty<Image>();
        private int indiceActual = 0;

        private NCliente nCliente = new NCliente();
        private NEmpleado nEmpleado = new NEmpleado();

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

        private void Timer1_Tick(object? sender, EventArgs e)
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



        private void acercaDeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // FormAcercaDe acercaDeForm = new FormAcercaDe();
            // acercaDeForm.Show();
        }

        private void teléfonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Lógica para el teléfono
            MessageBox.Show("Número de teléfono: +52 633-129-9913");
        }

        private void whatsAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Lógica para WhatsApp
            MessageBox.Show("Mensajes al WhatsApp: +52 633-129-5818");

        }

        private void instagramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Lógica para Instagram
            MessageBox.Show("Síguenos en Instagram como: @Terranova");
        }

 

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                string identificacion = txtNombre.Text.Trim();
                string contrasena = txtContraseña.Text.Trim();
                string puesto = cmbPuesto.Text; // "Cliente", "Empleado", "Gerente"

                if (string.IsNullOrWhiteSpace(identificacion) || string.IsNullOrWhiteSpace(contrasena))
                {
                    MessageBox.Show("Ingresa identificación y contraseña.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (puesto == "Cliente")
                {
                    var cliente = nCliente.ValidarAcceso(identificacion, contrasena);
                    if (cliente == null)
                    {
                        MessageBox.Show("Identificación o contraseña incorrectos.", "Acceso denegado",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    LimpiarYOcultar();
                    new FCliente(cliente).ShowDialog();
                }
                else
                {
                    var empleado = nEmpleado.ValidarAcceso(identificacion, contrasena);
                    if (empleado == null)
                    {
                        MessageBox.Show("Identificación o contraseña incorrectos.", "Acceso denegado",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Verificar que el cargo coincida con el puesto seleccionado
                    bool esGerente = empleado.Cargo == "Gerente";
                    if (puesto == "Gerente" && !esGerente)
                    {
                        MessageBox.Show("No tienes permisos de gerente.", "Acceso denegado",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (puesto == "Empleado" && esGerente)
                    {
                        MessageBox.Show("Selecciona el puesto correcto.", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    LimpiarYOcultar();
                    if (esGerente)
                        new FGerente(empleado).ShowDialog();
                    else
                        new FEmpleado(empleado).ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LimpiarYOcultar()
        {
            txtNombre.Text = "";
            txtContraseña.Text = "";
            cmbPuesto.SelectedIndex = -1;
            panel1.Visible = false;
        }

        private void iniciarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            pictureBox2.Visible = false;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas salir?", "Confirmar",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
