using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos1;
using CapaDatos1.Modelos;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FCliente : Form
    {
        private DClienteAgrega DatosCliente = new DClienteAgrega();
        private CN_Cliente NegocioCliente = new CN_Cliente();
        private int IDClienteLogeado; // Variable para almacenar el ID del cliente logeado
        public FCliente(int IDCliente)
        {
            InitializeComponent();
            this.IDClienteLogeado = IDCliente; // Asignar el ID del cliente logeado a la variable
        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            DCliente clienteAeditar = DatosCliente.BuscarPorId(this.IDClienteLogeado); // Obtener los datos del cliente logeado usando su ID
            if (clienteAeditar != null)
            {
                clienteAeditar.Telefono = txtTelefono.Text; // Actualizar el teléfono con el nuevo valor del TextBox
                clienteAeditar.Correo = txtCorreo.Text; // Actualizar el correo con el nuevo valor del TextBox
                try
                {
                    DatosCliente.Actualizar(clienteAeditar);
                    MessageBox.Show("Datos de contacto actualizados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarDatosFormulario();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar los datos de contacto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void FCliente_Load(object sender, EventArgs e)
        {
            CargarDatosFormulario();
            ConfigurarComboBoxTerreno();
        }
        private void ConfigurarComboBoxTerreno()
        {
            // CORRECCIÓN: Quitamos la 's' para que llame exactamente a 'obtenerTerrenoPorCliente'
            List<DTerreno> misTerrenos = NegocioCliente.obtenerTerrenoPorCliente(IDClienteLogeado);

            if (misTerrenos != null && misTerrenos.Count > 0)
            {
                cmbLoteConsultar.DataSource = misTerrenos;
                cmbLoteConsultar.DisplayMember = "Direccion"; // Muestra la dirección en el ComboBox
                cmbLoteConsultar.ValueMember = "Id";

                cmbLoteConsultar.SelectedIndexChanged += cmbLoteConsultar_SelectedIndexChanged;
                MostrarDatosTerreno((DTerreno)cmbLoteConsultar.SelectedItem);
            }
            else
            {
                cmbLoteConsultar.DataSource = null;
                MessageBox.Show("No se encontraron terrenos asociados a tu cuenta.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void CargarDatosFormulario()
        {
            DCliente Cliente = DatosCliente.BuscarPorId(IDClienteLogeado); // Obtener los datos del cliente logeado usando su ID
            if (Cliente != null)
            {
                lbBienvenido.Text = $"Bienvenido, {Cliente.Nombre} {Cliente.Apellidos}"; // Mostrar el nombre del cliente en el label de bienvenida
                txtFolioCliente.Text = Cliente.Folio;
                txtNombreCompleto.Text = $"{Cliente.Nombre} {Cliente.Apellidos}";
                txtTelefono.Text = Cliente.Telefono;
                txtCorreo.Text = Cliente.Correo;
                txtContraActual.Text = Cliente.Contrasena;//se llama a la contraseña actual
            }
            else
            {
                MessageBox.Show("No se encontraron los datos del cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtContraNueva.Text))
            {
                MessageBox.Show("Por favor, ingresa la nueva contraseña.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DCliente ClientePassword = DatosCliente.BuscarPorId(this.IDClienteLogeado);
            if (ClientePassword != null)
            {
                ClientePassword.Contrasena = txtContraNueva.Text; // Actualizar la contraseña con el nuevo valor del TextBox
                try
                {
                    DatosCliente.Actualizar(ClientePassword);
                    MessageBox.Show("Contraseña actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtContraActual.Text = ClientePassword.Contrasena; // Actualizar el TextBox de contraseña actual con la nueva contraseña
                    txtContraNueva.Clear(); // Limpiar el TextBox de nueva contraseña
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar la contraseña: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnConfirmarPago_Click(object sender, EventArgs e)
        {
            // Validar que el usuario sí tenga seleccionado un lote en el ComboBox
            if (cmbLoteConsultar.SelectedValue == null)
            {
                MessageBox.Show("Por favor, selecciona un lote para abonar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtPagar.Text, out decimal cantidadAAbonar))
            {
                MessageBox.Show("Por favor, introduce un monto válido para realizar el abono.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int idTerrenoSeleccionado = (int)cmbLoteConsultar.SelectedValue;
            string mensajeError;

            bool pagoExitoso = NegocioCliente.RegristrarPagoTerreno(idTerrenoSeleccionado, cantidadAAbonar, out mensajeError);

            if (pagoExitoso)
            {
                MessageBox.Show($"¡Abono de {cantidadAAbonar:C} registrado con éxito!", "Terranova", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPagar.Clear(); 

                cmbLoteConsultar_SelectedIndexChanged(null, null);
            }
            else
            {
                MessageBox.Show(mensajeError, "Error en el pago", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbLoteConsultar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLoteConsultar.SelectedItem != null)
            {
                DTerreno terrenoSeleccionado = (DTerreno)cmbLoteConsultar.SelectedItem;

                using var db = new AppDbContext();
                var terrenoActualizado = db.Terrenos.Find(terrenoSeleccionado.Id);

                MostrarDatosTerreno(terrenoActualizado);
            }
        }
        private void MostrarDatosTerreno(DTerreno terreno)
        {
            if (terreno != null)
            {
                txtEstadoTerreno.Text = terreno.Estado ?? "Activo";
                txtMedidas.Text = terreno.Medidas;
                txtDireccion.Text = terreno.Direccion;

                txtPrecioVenta.Text = terreno.MontoTotal.ToString("C");
                txtTotalAbonado.Text = terreno.MontoPagado.ToString("C");
                txtFaltaAbonar.Text = terreno.Saldo.ToString("C");
            }
        }
     
    }
}
