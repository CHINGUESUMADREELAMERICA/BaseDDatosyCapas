using CapaDatos1.Modelos;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FEmpleado : Form
    {
        private DEmpleado empleadoActual;
        private NCliente nCliente = new NCliente();
        private NTerreno nTerreno = new NTerreno();
        private NEmpleado nEmpleado = new NEmpleado();

        private string vistaActual = "";

        public FEmpleado(DEmpleado empleado)
        {
            InitializeComponent();
            empleadoActual = empleado;
        }

        private void FEmpleado_Load(object sender, EventArgs e)
        {
            try
            {
                lbBienvenido.Text = $"Bienvenid@ {empleadoActual.Nombre} {empleadoActual.Apellidos}";
                txtNombreCompleto.Text = $"{empleadoActual.Nombre} {empleadoActual.Apellidos}";
                txtFolioEmpleado.Text = empleadoActual.Id.ToString();
                lblCargo.Text = empleadoActual.Cargo;

                // Empleado no puede agregar ni eliminar

                MostrarClientes();
            }
            catch (Exception ex) { MessageBox.Show("Error al cargar: " + ex.Message); }
        }

        // ─── BOTONES ¿QUÉ BUSCAS? ────────────────────────────────────────────
        private void btnClientes_Click(object sender, EventArgs e) => MostrarClientes();
        private void btnTerrenos_Click(object sender, EventArgs e) => MostrarTerrenos();

        // ─── CARGAR DATOS ─────────────────────────────────────────────────────
        private void MostrarClientes(string filtroFolio = "")
        {
            try
            {
                vistaActual = "Clientes";
                dtgDatos.ReadOnly = true; // Empleado solo ve clientes
                CargarComboFolios();

                var lista = string.IsNullOrWhiteSpace(filtroFolio) || filtroFolio == "-- Todos --"
                    ? nCliente.ObtenerTodos()
                    : new List<DCliente> { nCliente.ObtenerPorFolio(filtroFolio) };

                dtgDatos.DataSource = null;
                dtgDatos.DataSource = lista;
                OcultarColumna("Terrenos");
            }
            catch (Exception ex) { MessageBox.Show("Error al cargar clientes: " + ex.Message); }
        }

        private void MostrarTerrenos(string filtroFolio = "")
        {
            try
            {
                vistaActual = "Terrenos";
                dtgDatos.ReadOnly = false; // Empleado puede modificar campos permitidos
                CargarComboFolios();

                var lista = string.IsNullOrWhiteSpace(filtroFolio) || filtroFolio == "-- Todos --"
                    ? nTerreno.ObtenerTodos()
                    : nTerreno.ObtenerPorFolioCliente(filtroFolio);

                dtgDatos.DataSource = null;
                dtgDatos.DataSource = lista;
                OcultarColumna("Cliente");
                BloquearColumnasEmpleado();
            }
            catch (Exception ex) { MessageBox.Show("Error al cargar terrenos: " + ex.Message); }
        }

        // Empleado solo puede editar DiasDePago, ClienteId y FechaCompra
        private void BloquearColumnasEmpleado()
        {
            dtgDatos.DataBindingComplete += (s, e) =>
            {
                foreach (DataGridViewColumn col in dtgDatos.Columns)
                {
                    bool editable = col.Name == "DiasDePago"
                                 || col.Name == "ClienteId"
                                 || col.Name == "FechaCompra";
                    col.ReadOnly = !editable;
                }
            };
        }

        private void CargarComboFolios()
        {
            try
            {
                cmbBuscar.Items.Clear();
                cmbBuscar.Items.Add("-- Todos --");
                foreach (var c in nCliente.ObtenerTodos())
                    if (!string.IsNullOrWhiteSpace(c.Folio))
                        cmbBuscar.Items.Add(c.Folio);
                cmbBuscar.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show("Error al cargar folios: " + ex.Message); }
        }

        private void OcultarColumna(string nombre)
        {
            if (dtgDatos.Columns[nombre] != null)
                dtgDatos.Columns[nombre].Visible = false;
        }

        // ─── FILTRO ───────────────────────────────────────────────────────────
        private void cmbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string folio = cmbBuscar.SelectedItem?.ToString();
                if (vistaActual == "Clientes") MostrarClientes(folio);
                else if (vistaActual == "Terrenos") MostrarTerrenos(folio);
            }
            catch (Exception ex) { MessageBox.Show("Error al filtrar: " + ex.Message); }
        }

        // ─── MODIFICAR (solo terrenos, campos permitidos) ─────────────────────
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (vistaActual != "Terrenos")
                {
                    MessageBox.Show("Solo puedes modificar terrenos.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dtgDatos.EndEdit();

                if (MessageBox.Show("¿Confirmas guardar los cambios?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

                var lista = (List<DTerreno>)dtgDatos.DataSource;
                foreach (var t in lista)
                    if (t.Id > 0)
                        nTerreno.ModificarEmpleado(t.Id, t.DiasDePago, t.ClienteId, t.FechaCompra);

                MessageBox.Show("Cambios guardados.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarTerrenos(cmbBuscar.SelectedItem?.ToString());
            }
            catch (Exception ex) { MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbBuscar.SelectedIndex = 0;
            if (vistaActual == "Clientes") MostrarClientes();
            else if (vistaActual == "Terrenos") MostrarTerrenos();
        }

        // ─── CAMBIO DE CONTRASEÑA ─────────────────────────────────────────────
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
                if (actual != empleadoActual.Contraseña)
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

                empleadoActual.Contraseña = nueva;
                nEmpleado.Modificar(empleadoActual);

                txtContraActual.Text = "";
                txtContraNueva.Text = "";
                MessageBox.Show("Contraseña cambiada.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        // ─── CERRAR SESIÓN ────────────────────────────────────────────────────
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas cerrar sesión?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }


        //registro pago
        private void btnRegistrarPago_Click(object sender, EventArgs e)
        {
            try
            {
                if (vistaActual != "Terrenos")
                {
                    MessageBox.Show("Selecciona la vista de Terrenos primero.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dtgDatos.CurrentRow == null)
                {
                    MessageBox.Show("Selecciona un terreno de la lista.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var terreno = ((List<DTerreno>)dtgDatos.DataSource)[dtgDatos.CurrentRow.Index];

                if (terreno.EnVenta)
                {
                    MessageBox.Show("Este terreno está en venta, no tiene pagos pendientes.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (terreno.Saldo <= 0)
                {
                    MessageBox.Show("Este terreno ya está liquidado.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var fPago = new FPago(terreno);
                if (fPago.ShowDialog() == DialogResult.OK)
                    MostrarTerrenos(cmbBuscar.SelectedItem?.ToString()); // refresca el grid
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}