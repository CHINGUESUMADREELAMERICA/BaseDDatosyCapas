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
    public partial class FPago : Form
    {
        private DTerreno terrenoSeleccionado;
        private NTerreno nTerreno = new NTerreno();

        public FPago(DTerreno terreno)
        {
            InitializeComponent();
            terrenoSeleccionado = terreno;
        }

        private void FPago_Load(object sender, EventArgs e)
        {
            lblTerreno.Text = $"Terreno: {terrenoSeleccionado.NoTerreno} - {terrenoSeleccionado.Direccion}";
            lblSaldo.Text = $"Saldo pendiente: {terrenoSeleccionado.Saldo:C}";
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMonto.Text))
            {
                MessageBox.Show("Ingresa el monto a abonar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtMonto.Text, out decimal monto) || monto <= 0)
            {
                MessageBox.Show("Ingresa un monto válido.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (monto > terrenoSeleccionado.Saldo)
            {
                MessageBox.Show($"El monto excede el saldo pendiente ({terrenoSeleccionado.Saldo:C}).", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"¿Confirmas el abono de {monto:C}?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            terrenoSeleccionado.MontoPagado += monto;
            if (terrenoSeleccionado.Saldo == 0)
                terrenoSeleccionado.Estado = "Liquidado";

            nTerreno.Modificar(terrenoSeleccionado);

            MessageBox.Show("Pago registrado correctamente.", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
