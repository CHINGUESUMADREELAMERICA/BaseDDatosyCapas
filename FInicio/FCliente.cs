using CapaDatos1.Modelos;
using CapaNegocio;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FCliente : Form
    {
        private DCliente clienteActual;
        private NTerreno nTerreno = new NTerreno();
        private NCliente nCliente = new NCliente();

        public FCliente(DCliente cliente)
        {
            InitializeComponent();
            clienteActual = cliente;
        }

        private void FCliente_Load(object sender, EventArgs e)
        {
            try
            {
                lbBienvenido.Text = "Bienvenid@, " + $"{clienteActual.Nombre} {clienteActual.Apellidos}";
                txtFolioCliente.Text = clienteActual.Folio;
                txtNombreCompleto.Text = $"{clienteActual.Nombre} {clienteActual.Apellidos}";
                txtTelefono.Text = clienteActual.Telefono;
                txtCorreo.Text = clienteActual.Correo;
                CargarComboLotes();
            }
            catch (Exception ex) { MessageBox.Show("Error al cargar datos: " + ex.Message); }
        }

        // ─── COMBO LOTES ──────────────────────────────────────────────────────
        private void CargarComboLotes()
        {
            try
            {
                var terrenos = nTerreno.ObtenerPorCliente(clienteActual.Id);
                cmbLoteConsultar.Items.Clear();
                foreach (var t in terrenos)
                    cmbLoteConsultar.Items.Add(t.NoTerreno);

                if (cmbLoteConsultar.Items.Count > 0)
                    cmbLoteConsultar.SelectedIndex = 0;
                else
                    LimpiarDatosTerreno();
            }
            catch (Exception ex) { MessageBox.Show("Error al cargar lotes: " + ex.Message); }
        }

        private void cmbLoteConsultar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string noTerreno = cmbLoteConsultar.SelectedItem?.ToString();
                if (string.IsNullOrWhiteSpace(noTerreno)) return;

                var terrenos = nTerreno.ObtenerPorCliente(clienteActual.Id);
                var terreno = terrenos.FirstOrDefault(t => t.NoTerreno == noTerreno);
                if (terreno == null) return;

                txtEstadoTerreno.Text = terreno.Estado;
                txtMedidas.Text = terreno.Medidas;
                txtDireccion.Text = terreno.Direccion;
                txtFechaCompra.Value = terreno.FechaCompra ?? DateTime.Now;
                txtPrecioVenta.Text = terreno.MontoTotal.ToString("C");
                txtTotalAbonado.Text = terreno.MontoPagado.ToString("C");
                txtFaltaAbonar.Text = terreno.Saldo.ToString("C");
            }
            catch (Exception ex) { MessageBox.Show("Error al cargar terreno: " + ex.Message); }
        }

        private void LimpiarDatosTerreno()
        {
            txtEstadoTerreno.Text = "";
            txtMedidas.Text = "";
            txtDireccion.Text = "";
            txtPrecioVenta.Text = "";
            txtTotalAbonado.Text = "";
            txtFaltaAbonar.Text = "";
            txtFechaCompra.Value = DateTime.Now;
        }

        // ─── BOTÓN VISTA GENERAL ──────────────────────────────────────────────
        private void btnVistaGeneral_Click(object sender, EventArgs e)
        {
            try { new FTerreno(clienteActual, null, null).ShowDialog(); }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }


        // ─── BOTÓN MODIFICAR (datos del propietario) ──────────────────────────
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Confirmas modificar tus datos?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

                var partes = txtNombreCompleto.Text.Trim().Split(' ');
                clienteActual.Nombre = partes.Length > 0 ? partes[0] : clienteActual.Nombre;
                clienteActual.Apellidos = partes.Length > 1
                    ? string.Join(" ", partes, 1, partes.Length - 1)
                    : clienteActual.Apellidos;
                clienteActual.Telefono = txtTelefono.Text.Trim();
                clienteActual.Correo = txtCorreo.Text.Trim();

                nCliente.Modificar(clienteActual);
                MessageBox.Show("Datos actualizados correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── BOTÓN ACEPTAR (cambio de contraseña) ─────────────────────────────
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string actual = txtContraActual.Text.Trim();
                string nueva = txtContraNueva.Text.Trim();

                if (string.IsNullOrWhiteSpace(actual) || string.IsNullOrWhiteSpace(nueva))
                {
                    MessageBox.Show("Ingresa la contraseña actual y la nueva.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (actual != clienteActual.Contrasena)
                {
                    MessageBox.Show("La contraseña actual es incorrecta.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (nueva.Length < 4)
                {
                    MessageBox.Show("La nueva contraseña debe tener al menos 4 caracteres.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("¿Confirmas cambiar tu contraseña?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

                clienteActual.Contrasena = nueva;
                nCliente.Modificar(clienteActual);

                txtContraActual.Text = "";
                txtContraNueva.Text = "";

                MessageBox.Show("Contraseña cambiada correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cambiar contraseña: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── CERRAR SESIÓN ────────────────────────────────────────────────────
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas cerrar sesión?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
