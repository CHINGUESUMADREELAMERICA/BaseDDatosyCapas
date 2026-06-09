namespace CapaPresentacion
{
    partial class FEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbContraseñas = new GroupBox();
            btnCambiarContraseña = new Button();
            txtContraNueva = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtContraActual = new TextBox();
            gbAcciones = new GroupBox();
            btnRegistrarPago = new Button();
            btnLimpiar = new Button();
            btnModificar = new Button();
            dtgDatos = new DataGridView();
            cmbBuscar = new ComboBox();
            gbQueBuscas = new GroupBox();
            btnTerrenos = new Button();
            btnClientes = new Button();
            gbDatosEmpleado = new GroupBox();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            label4 = new Label();
            label2 = new Label();
            txtFolioEmpleado = new TextBox();
            label3 = new Label();
            lbCerrarSesion = new Label();
            lbBienvenido = new Label();
            label5 = new Label();
            pbLogo = new PictureBox();
            lblCargo = new Label();
            label1 = new Label();
            txtApellidos = new TextBox();
            txtNombre = new TextBox();
            label8 = new Label();
            gbContraseñas.SuspendLayout();
            gbAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
            gbQueBuscas.SuspendLayout();
            gbDatosEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // gbContraseñas
            // 
            gbContraseñas.BackColor = SystemColors.ControlLightLight;
            gbContraseñas.Controls.Add(btnCambiarContraseña);
            gbContraseñas.Controls.Add(txtContraNueva);
            gbContraseñas.Controls.Add(label6);
            gbContraseñas.Controls.Add(label7);
            gbContraseñas.Controls.Add(txtContraActual);
            gbContraseñas.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Italic, GraphicsUnit.Point, 0);
            gbContraseñas.Location = new Point(880, 94);
            gbContraseñas.Margin = new Padding(4);
            gbContraseñas.Name = "gbContraseñas";
            gbContraseñas.Padding = new Padding(4);
            gbContraseñas.Size = new Size(399, 192);
            gbContraseñas.TabIndex = 28;
            gbContraseñas.TabStop = false;
            gbContraseñas.Text = "Contraseña";
            // 
            // btnCambiarContraseña
            // 
            btnCambiarContraseña.BackColor = Color.FromArgb(140, 74, 30);
            btnCambiarContraseña.Cursor = Cursors.Hand;
            btnCambiarContraseña.FlatStyle = FlatStyle.Popup;
            btnCambiarContraseña.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCambiarContraseña.ForeColor = SystemColors.ControlLightLight;
            btnCambiarContraseña.Location = new Point(236, 132);
            btnCambiarContraseña.Margin = new Padding(4);
            btnCambiarContraseña.Name = "btnCambiarContraseña";
            btnCambiarContraseña.Size = new Size(151, 36);
            btnCambiarContraseña.TabIndex = 21;
            btnCambiarContraseña.Text = "Aceptar";
            btnCambiarContraseña.UseVisualStyleBackColor = false;
            btnCambiarContraseña.Click += btnAceptar_Click;
            // 
            // txtContraNueva
            // 
            txtContraNueva.Font = new Font("Microsoft Sans Serif", 10.1999989F);
            txtContraNueva.Location = new Point(194, 86);
            txtContraNueva.Margin = new Padding(4);
            txtContraNueva.Name = "txtContraNueva";
            txtContraNueva.Size = new Size(191, 27);
            txtContraNueva.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.1999989F);
            label6.Location = new Point(9, 58);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(147, 20);
            label6.TabIndex = 3;
            label6.Text = "Contraseña Actual";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.1999989F);
            label7.Location = new Point(9, 96);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(160, 20);
            label7.TabIndex = 0;
            label7.Text = "Cambiar contraseña";
            // 
            // txtContraActual
            // 
            txtContraActual.Font = new Font("Microsoft Sans Serif", 10.1999989F);
            txtContraActual.Location = new Point(194, 47);
            txtContraActual.Margin = new Padding(4);
            txtContraActual.Name = "txtContraActual";
            txtContraActual.Size = new Size(191, 27);
            txtContraActual.TabIndex = 15;
            // 
            // gbAcciones
            // 
            gbAcciones.BackColor = SystemColors.ControlLightLight;
            gbAcciones.Controls.Add(btnRegistrarPago);
            gbAcciones.Controls.Add(btnLimpiar);
            gbAcciones.Controls.Add(btnModificar);
            gbAcciones.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Italic, GraphicsUnit.Point, 0);
            gbAcciones.Location = new Point(1289, 347);
            gbAcciones.Margin = new Padding(4);
            gbAcciones.Name = "gbAcciones";
            gbAcciones.Padding = new Padding(4);
            gbAcciones.Size = new Size(195, 271);
            gbAcciones.TabIndex = 30;
            gbAcciones.TabStop = false;
            gbAcciones.Text = "Acciones";
            // 
            // btnRegistrarPago
            // 
            btnRegistrarPago.BackColor = Color.FromArgb(140, 74, 30);
            btnRegistrarPago.Cursor = Cursors.Hand;
            btnRegistrarPago.FlatStyle = FlatStyle.Popup;
            btnRegistrarPago.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarPago.ForeColor = SystemColors.ControlLightLight;
            btnRegistrarPago.Location = new Point(20, 172);
            btnRegistrarPago.Margin = new Padding(4);
            btnRegistrarPago.Name = "btnRegistrarPago";
            btnRegistrarPago.Size = new Size(151, 36);
            btnRegistrarPago.TabIndex = 35;
            btnRegistrarPago.Text = "Registrar pago";
            btnRegistrarPago.UseVisualStyleBackColor = false;
            btnRegistrarPago.Click += btnRegistrarPago_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(140, 74, 30);
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatStyle = FlatStyle.Popup;
            btnLimpiar.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = SystemColors.ControlLightLight;
            btnLimpiar.Location = new Point(20, 115);
            btnLimpiar.Margin = new Padding(4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(151, 36);
            btnLimpiar.TabIndex = 21;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(140, 74, 30);
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.FlatStyle = FlatStyle.Popup;
            btnModificar.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = SystemColors.ControlLightLight;
            btnModificar.Location = new Point(20, 57);
            btnModificar.Margin = new Padding(4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(151, 36);
            btnModificar.TabIndex = 19;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // dtgDatos
            // 
            dtgDatos.BackgroundColor = Color.FromArgb(210, 134, 77);
            dtgDatos.BorderStyle = BorderStyle.None;
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatos.Location = new Point(13, 347);
            dtgDatos.Name = "dtgDatos";
            dtgDatos.RowHeadersWidth = 51;
            dtgDatos.Size = new Size(1266, 272);
            dtgDatos.TabIndex = 32;
            // 
            // cmbBuscar
            // 
            cmbBuscar.BackColor = Color.FromArgb(210, 134, 77);
            cmbBuscar.Cursor = Cursors.Hand;
            cmbBuscar.FlatStyle = FlatStyle.Flat;
            cmbBuscar.FormattingEnabled = true;
            cmbBuscar.Location = new Point(156, 313);
            cmbBuscar.Name = "cmbBuscar";
            cmbBuscar.Size = new Size(204, 28);
            cmbBuscar.TabIndex = 31;
            cmbBuscar.SelectedIndexChanged += cmbBuscar_SelectedIndexChanged;
            // 
            // gbQueBuscas
            // 
            gbQueBuscas.BackColor = SystemColors.ControlLightLight;
            gbQueBuscas.Controls.Add(btnTerrenos);
            gbQueBuscas.Controls.Add(btnClientes);
            gbQueBuscas.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Italic, GraphicsUnit.Point, 0);
            gbQueBuscas.Location = new Point(1287, 94);
            gbQueBuscas.Margin = new Padding(4);
            gbQueBuscas.Name = "gbQueBuscas";
            gbQueBuscas.Padding = new Padding(4);
            gbQueBuscas.Size = new Size(195, 192);
            gbQueBuscas.TabIndex = 29;
            gbQueBuscas.TabStop = false;
            gbQueBuscas.Text = "¿Qué buscas?";
            // 
            // btnTerrenos
            // 
            btnTerrenos.BackColor = Color.FromArgb(140, 74, 30);
            btnTerrenos.Cursor = Cursors.Hand;
            btnTerrenos.FlatStyle = FlatStyle.Popup;
            btnTerrenos.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTerrenos.ForeColor = SystemColors.ControlLightLight;
            btnTerrenos.Location = new Point(22, 109);
            btnTerrenos.Margin = new Padding(4);
            btnTerrenos.Name = "btnTerrenos";
            btnTerrenos.Size = new Size(151, 36);
            btnTerrenos.TabIndex = 20;
            btnTerrenos.Text = "Terrenos";
            btnTerrenos.UseVisualStyleBackColor = false;
            btnTerrenos.Click += btnTerrenos_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(140, 74, 30);
            btnClientes.Cursor = Cursors.Hand;
            btnClientes.FlatStyle = FlatStyle.Popup;
            btnClientes.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClientes.ForeColor = SystemColors.ControlLightLight;
            btnClientes.Location = new Point(22, 58);
            btnClientes.Margin = new Padding(4);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(151, 36);
            btnClientes.TabIndex = 15;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // gbDatosEmpleado
            // 
            gbDatosEmpleado.BackColor = SystemColors.ControlLightLight;
            gbDatosEmpleado.Controls.Add(label1);
            gbDatosEmpleado.Controls.Add(txtApellidos);
            gbDatosEmpleado.Controls.Add(txtNombre);
            gbDatosEmpleado.Controls.Add(label8);
            gbDatosEmpleado.Controls.Add(txtCorreo);
            gbDatosEmpleado.Controls.Add(txtTelefono);
            gbDatosEmpleado.Controls.Add(label4);
            gbDatosEmpleado.Controls.Add(label2);
            gbDatosEmpleado.Controls.Add(txtFolioEmpleado);
            gbDatosEmpleado.Controls.Add(label3);
            gbDatosEmpleado.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Italic, GraphicsUnit.Point, 0);
            gbDatosEmpleado.Location = new Point(13, 94);
            gbDatosEmpleado.Margin = new Padding(4);
            gbDatosEmpleado.Name = "gbDatosEmpleado";
            gbDatosEmpleado.Padding = new Padding(4);
            gbDatosEmpleado.Size = new Size(859, 192);
            gbDatosEmpleado.TabIndex = 27;
            gbDatosEmpleado.TabStop = false;
            gbDatosEmpleado.Text = "Datos personales";
            // 
            // txtCorreo
            // 
            txtCorreo.Cursor = Cursors.Hand;
            txtCorreo.Font = new Font("Microsoft Sans Serif", 10.1999989F);
            txtCorreo.Location = new Point(248, 153);
            txtCorreo.Margin = new Padding(4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(586, 27);
            txtCorreo.TabIndex = 18;
            // 
            // txtTelefono
            // 
            txtTelefono.Cursor = Cursors.Hand;
            txtTelefono.Font = new Font("Microsoft Sans Serif", 10.1999989F);
            txtTelefono.Location = new Point(248, 113);
            txtTelefono.Margin = new Padding(4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(277, 27);
            txtTelefono.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.1999989F);
            label4.Location = new Point(615, 40);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 3;
            label4.Text = "Folio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.1999989F);
            label2.Location = new Point(25, 121);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 1;
            label2.Text = "No. Teléfono";
            // 
            // txtFolioEmpleado
            // 
            txtFolioEmpleado.Font = new Font("Microsoft Sans Serif", 10.1999989F);
            txtFolioEmpleado.Location = new Point(675, 32);
            txtFolioEmpleado.Margin = new Padding(4);
            txtFolioEmpleado.Name = "txtFolioEmpleado";
            txtFolioEmpleado.Size = new Size(159, 27);
            txtFolioEmpleado.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.1999989F);
            label3.Location = new Point(25, 158);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(147, 20);
            label3.TabIndex = 2;
            label3.Text = "Correo electrónico";
            // 
            // lbCerrarSesion
            // 
            lbCerrarSesion.AutoSize = true;
            lbCerrarSesion.BackColor = Color.FromArgb(140, 74, 30);
            lbCerrarSesion.Cursor = Cursors.Hand;
            lbCerrarSesion.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lbCerrarSesion.ForeColor = Color.FromArgb(82, 191, 243);
            lbCerrarSesion.Location = new Point(1342, 9);
            lbCerrarSesion.Margin = new Padding(4, 0, 4, 0);
            lbCerrarSesion.Name = "lbCerrarSesion";
            lbCerrarSesion.Size = new Size(113, 20);
            lbCerrarSesion.TabIndex = 26;
            lbCerrarSesion.Text = "Cerrar Sesión";
            lbCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // lbBienvenido
            // 
            lbBienvenido.BackColor = Color.FromArgb(140, 74, 30);
            lbBienvenido.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbBienvenido.ForeColor = SystemColors.ControlLightLight;
            lbBienvenido.Location = new Point(0, -2);
            lbBienvenido.Margin = new Padding(4, 0, 4, 0);
            lbBienvenido.Name = "lbBienvenido";
            lbBienvenido.Size = new Size(1496, 85);
            lbBienvenido.TabIndex = 25;
            lbBienvenido.Text = "Bienvenid@ \"Fulanito de tal\"";
            lbBienvenido.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(13, 318);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(134, 20);
            label5.TabIndex = 33;
            label5.Text = "Filtro por folio ";
            // 
            // pbLogo
            // 
            pbLogo.BackColor = Color.FromArgb(140, 74, 30);
            pbLogo.Image = Properties.Resources.logodesertico;
            pbLogo.Location = new Point(0, -2);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(148, 85);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 34;
            pbLogo.TabStop = false;
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.BackColor = Color.FromArgb(140, 74, 30);
            lblCargo.Font = new Font("Microsoft Sans Serif", 10.1999989F);
            lblCargo.ForeColor = SystemColors.ButtonHighlight;
            lblCargo.Location = new Point(156, 55);
            lblCargo.Margin = new Padding(4, 0, 4, 0);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(61, 20);
            lblCargo.TabIndex = 19;
            lblCargo.Text = "Puesto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.1999989F);
            label1.Location = new Point(437, 90);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 39;
            label1.Text = "Apellidos";
            // 
            // txtApellidos
            // 
            txtApellidos.Font = new Font("Microsoft Sans Serif", 10.8F);
            txtApellidos.Location = new Point(535, 82);
            txtApellidos.Margin = new Padding(4);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(291, 28);
            txtApellidos.TabIndex = 40;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Microsoft Sans Serif", 10.8F);
            txtNombre.Location = new Point(122, 82);
            txtNombre.Margin = new Padding(4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(291, 28);
            txtNombre.TabIndex = 38;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10.1999989F);
            label8.Location = new Point(33, 90);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(68, 20);
            label8.TabIndex = 37;
            label8.Text = "Nombre";
            // 
            // FEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1495, 628);
            Controls.Add(lblCargo);
            Controls.Add(pbLogo);
            Controls.Add(label5);
            Controls.Add(gbContraseñas);
            Controls.Add(gbAcciones);
            Controls.Add(dtgDatos);
            Controls.Add(cmbBuscar);
            Controls.Add(gbQueBuscas);
            Controls.Add(gbDatosEmpleado);
            Controls.Add(lbCerrarSesion);
            Controls.Add(lbBienvenido);
            Name = "FEmpleado";
            Text = "Inicio de sesión como empleado";
            Load += FEmpleado_Load;
            gbContraseñas.ResumeLayout(false);
            gbContraseñas.PerformLayout();
            gbAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgDatos).EndInit();
            gbQueBuscas.ResumeLayout(false);
            gbDatosEmpleado.ResumeLayout(false);
            gbDatosEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbContraseñas;
        private Button btnCambiarContraseña;
        private TextBox txtContraNueva;
        private Label label6;
        private Label label7;
        private TextBox txtContraActual;
        private GroupBox gbAcciones;
        private Button btnLimpiar;
        private Button btnModificar;
        private DataGridView dtgDatos;
        private ComboBox cmbBuscar;
        private GroupBox gbQueBuscas;
        private Button btnTerrenos;
        private Button btnClientes;
        private GroupBox gbDatosEmpleado;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private Label label4;
        private Label label2;
        private TextBox txtFolioEmpleado;
        private Label label3;
        private Label lbCerrarSesion;
        private Label lbBienvenido;
        private Label label5;
        private PictureBox pbLogo;
        private Label lblCargo;
        private Button btnRegistrarPago;
        private Label label1;
        private TextBox txtApellidos;
        private TextBox txtNombre;
        private Label label8;
    }
}