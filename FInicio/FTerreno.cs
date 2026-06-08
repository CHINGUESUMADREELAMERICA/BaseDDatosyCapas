using CapaDatos1.Modelos;
using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FTerreno : Form
    {
        private DCliente clienteActual;
        private DEmpleado empleadoActual;
        private DEmpleado gerenteActual;
        private string rol;

        private NTerreno nTerreno = new NTerreno();
        private NCliente nCliente = new NCliente();

        private List<DTerreno> terrenosActuales = new List<DTerreno>();

        public FTerreno(DCliente cliente, DEmpleado empleado, DEmpleado gerente)
        {
            InitializeComponent();
            clienteActual = cliente;
            empleadoActual = empleado;
            gerenteActual = gerente;

            if (cliente != null) rol = "Cliente";
            else if (empleado != null) rol = "Empleado";
            else rol = "Gerente";
        }

        private void FTerreno_Load(object sender, EventArgs e)
        {
            try
            {
                CargarComboFolios();
                CargarTerrenos();
                ConfigurarPermisos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── CARGAR COMBO DE FOLIOS ───────────────────────────────────────────
        private void CargarComboFolios()
        {
            try
            {
                cmbBuscar.Items.Clear();
                cmbBuscar.Items.Add("-- Todos --");

                var clientes = nCliente.ObtenerTodos();
                foreach (var c in clientes)
                    if (!string.IsNullOrWhiteSpace(c.Folio))
                        cmbBuscar.Items.Add(c.Folio);

                cmbBuscar.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar folios: " + ex.Message);
            }
        }
        // ─── CARGAR DATAGRIDVIEW ──────────────────────────────────────────────
        private void CargarTerrenos(string filtroFolio = "")
        {
            try
            {
                if (rol == "Cliente")
                {
                    terrenosActuales = nTerreno.ObtenerPorFolioCliente(clienteActual.Folio);
                }
                else if (string.IsNullOrWhiteSpace(filtroFolio) || filtroFolio == "-- Todos --")
                {
                    terrenosActuales = nTerreno.ObtenerTodos();
                }
                else
                {
                    terrenosActuales = nTerreno.ObtenerPorFolioCliente(filtroFolio);
                }

                RefrescarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar terrenos: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefrescarGrid()
        {
            dtgDatos.DataSource = null;
            dtgDatos.DataSource = terrenosActuales;

            // Ocultar columna de navegación de EF
            if (dtgDatos.Columns["Cliente"] != null)
                dtgDatos.Columns["Cliente"].Visible = false;
        }

        // ─── FILTRAR AL CAMBIAR COMBOBOX ──────────────────────────────────────
        private void cbFolio_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CargarTerrenos(cmbBuscar.SelectedItem?.ToString());
            }
            catch (Exception ex) { MessageBox.Show("Error al filtrar: " + ex.Message); }
        }

        // ─── CONFIGURAR PERMISOS ──────────────────────────────────────────────
        // ─── PERMISOS POR ROL ─────────────────────────────────────────────────
        private void ConfigurarPermisos()
        {
            switch (rol)
            {
                case "Cliente":
                    dtgDatos.ReadOnly = true;
                    cmbBuscar.Visible = false;
                    label5.Visible = false;
                    btnAgregar.Visible = false;
                   btnGuardar.Visible = false;
                    btnEliminar.Visible = false;
                    btnLimpiar.Visible = false;
                    break;

                case "Empleado":
                    dtgDatos.ReadOnly = false;
                    btnAgregar.Visible = false;
                    btnEliminar.Visible = false;
                    BloquearColumnasEmpleado();
                    break;

                case "Gerente":
                    dtgDatos.ReadOnly = false;
                    break;
            }
        }

        private void BloquearColumnasEmpleado()
        {
            // Se ejecuta después de cargar datos para que las columnas existan
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

        // ─── GUARDAR ──────────────────────────────────────────────────────────
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                dtgDatos.EndEdit();

                if (MessageBox.Show("¿Confirmas guardar los cambios?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

                foreach (var t in terrenosActuales)
                {
                    if (rol == "Empleado")
                        nTerreno.ModificarEmpleado(t.Id, t.DiasDePago, t.ClienteId, t.FechaCompra);
                    else
                        nTerreno.Modificar(t);
                }

                MessageBox.Show("Cambios guardados.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarTerrenos(cmbBuscar.SelectedItem?.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── AGREGAR (solo Gerente) ───────────────────────────────────────────
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                var nuevo = new DTerreno { EnVenta = true };
                terrenosActuales.Add(nuevo);
                RefrescarGrid();

                // Posicionar en la nueva fila
                dtgDatos.CurrentCell =
                    dtgDatos.Rows[dtgDatos.RowCount - 1].Cells["NoTerreno"];
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        // ─── ELIMINAR (solo Gerente) ──────────────────────────────────────────
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgDatos.CurrentRow == null) return;

                if (MessageBox.Show("¿Eliminar este terreno? Esta acción no se puede deshacer.",
                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

                int idx = dtgDatos.CurrentRow.Index;
                var terreno = terrenosActuales[idx];

                if (terreno.Id > 0)
                    nTerreno.Eliminar(terreno.Id);

                MessageBox.Show("Terreno eliminado.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarTerrenos(cmbBuscar.SelectedItem?.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── LIMPIAR FILTRO ───────────────────────────────────────────────────
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                cmbBuscar.SelectedIndex = 0;
                CargarTerrenos();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        // ─── RETROCEDER ───────────────────────────────────────────────────────
        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas salir?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}