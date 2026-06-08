using CapaDatos1.Modelos;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FGerente : Form
    {
        private DEmpleado gerenteActual;
        private NCliente nCliente = new NCliente();
        private NEmpleado nEmpleado = new NEmpleado();
        private NTerreno nTerreno = new NTerreno();

        // Controla qué está mostrando el DataGridView ahora mismo
        private string vistaActual = ""; // "Clientes", "Empleados", "Terrenos"

        public FGerente(DEmpleado gerente)
        {
            InitializeComponent();
            gerenteActual = gerente;
        }

        private void FGerente_Load(object sender, EventArgs e)
        {
            try
            {
                // Datos del gerente logueado
                lbBienvenido.Text = "Bienvenid@" + $"{gerenteActual.Nombre} {gerenteActual.Apellidos}";
                txtNombreCompleto.Text = $"{gerenteActual.Nombre} {gerenteActual.Apellidos}";
                txtFolioGerente.Text = gerenteActual.Id.ToString();

                // Mostrar clientes por defecto
                MostrarClientes();
            }
            catch (Exception ex) { MessageBox.Show("Error al cargar: " + ex.Message); }
        }

        // ─── BOTONES ¿QUÉ BUSCAS? ────────────────────────────────────────────
        private void btnClientes_Click(object sender, EventArgs e) => MostrarClientes();
        private void btnEmpleados_Click(object sender, EventArgs e) => MostrarEmpleados();
        private void btnTerrenos_Click(object sender, EventArgs e) => MostrarTerrenos();

        // ─── CARGAR DATOS EN DATAGRIDVIEW ─────────────────────────────────────
        private void MostrarClientes(string filtroFolio = "")
        {
            try
            {
                vistaActual = "Clientes";
                CargarComboFoliosClientes();

                var lista = string.IsNullOrWhiteSpace(filtroFolio) || filtroFolio == "-- Todos --"
                    ? nCliente.ObtenerTodos()
                    : new List<DCliente> { nCliente.ObtenerPorFolio(filtroFolio) };

                dtgDatos.DataSource = null;
                dtgDatos.DataSource = lista;
                OcultarColumnaNavegacion("Terrenos");
            }
            catch (Exception ex) { MessageBox.Show("Error al cargar clientes: " + ex.Message); }
        }

        private void MostrarEmpleados()
        {
            try
            {
                vistaActual = "Empleados";
                cmbBuscar.Items.Clear(); // El filtro por folio no aplica a empleados
                cmbBuscar.Items.Add("-- Todos --");
                cmbBuscar.SelectedIndex = 0;

                dtgDatos.DataSource = null;
                dtgDatos.DataSource = nEmpleado.ObtenerTodos();
            }
            catch (Exception ex) { MessageBox.Show("Error al cargar empleados: " + ex.Message); }
        }

        private void MostrarTerrenos(string filtroFolio = "")
        {
            try
            {
                vistaActual = "Terrenos";
                CargarComboFoliosClientes();

                var lista = string.IsNullOrWhiteSpace(filtroFolio) || filtroFolio == "-- Todos --"
                    ? nTerreno.ObtenerTodos()
                    : nTerreno.ObtenerPorFolioCliente(filtroFolio);

                dtgDatos.DataSource = null;
                dtgDatos.DataSource = lista;
                OcultarColumnaNavegacion("Cliente");
            }
            catch (Exception ex) { MessageBox.Show("Error al cargar terrenos: " + ex.Message); }
        }

        private void CargarComboFoliosClientes()
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

        private void OcultarColumnaNavegacion(string nombreColumna)
        {
            if (dtgDatos.Columns[nombreColumna] != null)
                dtgDatos.Columns[nombreColumna].Visible = false;
        }

        // ─── FILTRO POR FOLIO ─────────────────────────────────────────────────
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

        // ─── SELECCIONAR FILA ─────────────────────────────────────────────────
        private void dtgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Solo para info — la edición es directa en el grid
        }

        // ─── ACCIONES ─────────────────────────────────────────────────────────
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (vistaActual == "Clientes")
                {
                    var nuevo = new DCliente();
                    var lista = (List<DCliente>)dtgDatos.DataSource;
                    lista.Add(nuevo);
                    dtgDatos.DataSource = null;
                    dtgDatos.DataSource = lista;
                }
                else if (vistaActual == "Empleados")
                {
                    var nuevo = new DEmpleado { FechaNacimiento = DateTime.Now, FechaIngreso = DateTime.Now };
                    var lista = (List<DEmpleado>)dtgDatos.DataSource;
                    lista.Add(nuevo);
                    dtgDatos.DataSource = null;
                    dtgDatos.DataSource = lista;
                }
                else if (vistaActual == "Terrenos")
                {
                    var nuevo = new DTerreno { EnVenta = true };
                    var lista = (List<DTerreno>)dtgDatos.DataSource;
                    lista.Add(nuevo);
                    dtgDatos.DataSource = null;
                    dtgDatos.DataSource = lista;
                }

                // Ir a la última fila
                if (dtgDatos.Rows.Count > 0)
                    dtgDatos.FirstDisplayedScrollingRowIndex = dtgDatos.Rows.Count - 1;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                dtgDatos.EndEdit();

                if (MessageBox.Show("¿Confirmas guardar los cambios?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

                if (vistaActual == "Clientes")
                {
                    var lista = (List<DCliente>)dtgDatos.DataSource;
                    foreach (var c in lista)
                        if (c.Id > 0) nCliente.Modificar(c);
                        else nCliente.Agregar(c);
                }
                else if (vistaActual == "Empleados")
                {
                    var lista = (List<DEmpleado>)dtgDatos.DataSource;
                    foreach (var emp in lista)
                        if (emp.Id > 0) nEmpleado.Modificar(emp);
                        else nEmpleado.Agregar(emp);
                }
                else if (vistaActual == "Terrenos")
                {
                    var lista = (List<DTerreno>)dtgDatos.DataSource;
                    foreach (var t in lista)
                        if (t.Id > 0) nTerreno.Modificar(t);
                        else nTerreno.Agregar(t);
                }

                MessageBox.Show("Cambios guardados.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefrescarVista();
            }
            catch (Exception ex) { MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgDatos.CurrentRow == null) return;
                int idx = dtgDatos.CurrentRow.Index;

                if (MessageBox.Show("¿Eliminar este registro?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

                if (vistaActual == "Clientes")
                {
                    var item = ((List<DCliente>)dtgDatos.DataSource)[idx];
                    if (item.Id > 0) nCliente.Eliminar(item.Id);
                }
                else if (vistaActual == "Empleados")
                {
                    var item = ((List<DEmpleado>)dtgDatos.DataSource)[idx];
                    if (item.Id > 0) nEmpleado.Eliminar(item.Id);
                }
                else if (vistaActual == "Terrenos")
                {
                    var item = ((List<DTerreno>)dtgDatos.DataSource)[idx];
                    if (item.Id > 0) nTerreno.Eliminar(item.Id);
                }

                MessageBox.Show("Registro eliminado.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefrescarVista();
            }
            catch (Exception ex) { MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnLimpiar_Click(object sender, EventArgs e) => RefrescarVista();

        private void RefrescarVista()
        {
            if (vistaActual == "Clientes") MostrarClientes();
            else if (vistaActual == "Empleados") MostrarEmpleados();
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
                if (actual != gerenteActual.Contraseña)
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

                gerenteActual.Contraseña = nueva;
                nEmpleado.Modificar(gerenteActual);

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

        //botones a programar

        //contrasenia
        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {

        }

        //Registro pago
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