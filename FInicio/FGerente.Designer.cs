namespace CapaPresentacion
{
    partial class FGerente
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
            btnClientes = new Button();
            lbBienvenido = new Label();
            lbCerrarSesion = new Label();
            gbDatosPropietario = new GroupBox();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            txtFolioGerente = new TextBox();
            label3 = new Label();
            btnEmpleados = new Button();
            pbLogo = new PictureBox();
            gbQueBuscas = new GroupBox();
            btnTerrenos = new Button();
            dtgDatos = new DataGridView();
            gbAcciones = new GroupBox();
            btnRegistrarPago = new Button();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            gbContraseñas = new GroupBox();
            btnCambiarContraseña = new Button();
            txtContraNueva = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtContraActual = new TextBox();
            lblFiltroFolio = new Label();
            cmbBuscar = new ComboBox();
            lblCargo = new Label();
            txtNombre = new TextBox();
            txtApellidos = new TextBox();
            label5 = new Label();
            gbDatosPropietario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            gbQueBuscas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
            gbAcciones.SuspendLayout();
            gbContraseñas.SuspendLayout();
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(140, 74, 30);
            btnClientes.Cursor = Cursors.Hand;
            btnClientes.FlatStyle = FlatStyle.Popup;
            btnClientes.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClientes.ForeColor = SystemColors.ControlLightLight;
            btnClientes.Location = new Point(20, 44);
            btnClientes.Margin = new Padding(4);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(151, 36);
            btnClientes.TabIndex = 15;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // lbBienvenido
            // 
            lbBienvenido.BackColor = Color.FromArgb(140, 74, 30);
            lbBienvenido.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbBienvenido.ForeColor = SystemColors.ControlLightLight;
            lbBienvenido.Location = new Point(-1, 0);
            lbBienvenido.Margin = new Padding(4, 0, 4, 0);
            lbBienvenido.Name = "lbBienvenido";
            lbBienvenido.Size = new Size(1496, 85);
            lbBienvenido.TabIndex = 16;
            lbBienvenido.Text = "Bienvenid@ \"Fulanito de tal\"";
            lbBienvenido.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lbCerrarSesion
            // 
            lbCerrarSesion.AutoSize = true;
            lbCerrarSesion.BackColor = Color.FromArgb(140, 74, 30);
            lbCerrarSesion.Cursor = Cursors.Hand;
            lbCerrarSesion.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lbCerrarSesion.ForeColor = Color.FromArgb(82, 191, 243);
            lbCerrarSesion.Location = new Point(1339, 9);
            lbCerrarSesion.Margin = new Padding(4, 0, 4, 0);
            lbCerrarSesion.Name = "lbCerrarSesion";
            lbCerrarSesion.Size = new Size(113, 20);
            lbCerrarSesion.TabIndex = 20;
            lbCerrarSesion.Text = "Cerrar Sesión";
            lbCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // gbDatosPropietario
            // 
            gbDatosPropietario.BackColor = SystemColors.ControlLightLight;
            gbDatosPropietario.Controls.Add(label5);
            gbDatosPropietario.Controls.Add(txtApellidos);
            gbDatosPropietario.Controls.Add(txtNombre);
            gbDatosPropietario.Controls.Add(txtCorreo);
            gbDatosPropietario.Controls.Add(txtTelefono);
            gbDatosPropietario.Controls.Add(label4);
            gbDatosPropietario.Controls.Add(label1);
            gbDatosPropietario.Controls.Add(label2);
            gbDatosPropietario.Controls.Add(txtFolioGerente);
            gbDatosPropietario.Controls.Add(label3);
            gbDatosPropietario.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Italic, GraphicsUnit.Point, 0);
            gbDatosPropietario.Location = new Point(12, 96);
            gbDatosPropietario.Margin = new Padding(4);
            gbDatosPropietario.Name = "gbDatosPropietario";
            gbDatosPropietario.Padding = new Padding(4);
            gbDatosPropietario.Size = new Size(859, 192);
            gbDatosPropietario.TabIndex = 21;
            gbDatosPropietario.TabStop = false;
            gbDatosPropietario.Text = "Datos personales";
            // 
            // txtCorreo
            // 
            txtCorreo.Cursor = Cursors.Hand;
            txtCorreo.Font = new Font("Microsoft Sans Serif", 10.1999989F);
            txtCorreo.Location = new Point(265, 147);
            txtCorreo.Margin = new Padding(4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(586, 27);
            txtCorreo.TabIndex = 18;
            // 
            // txtTelefono
            // 
            txtTelefono.Cursor = Cursors.Hand;
            txtTelefono.Font = new Font("Microsoft Sans Serif", 10.1999989F);
            txtTelefono.Location = new Point(265, 107);
            txtTelefono.Margin = new Padding(4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(277, 27);
            txtTelefono.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.1999989F);
            label4.Location = new Point(631, 33);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 3;
            label4.Text = "Folio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.1999989F);
            label1.Location = new Point(41, 75);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.1999989F);
            label2.Location = new Point(41, 114);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 1;
            label2.Text = "No. Teléfono";
            // 
            // txtFolioGerente
            // 
            txtFolioGerente.Font = new Font("Microsoft Sans Serif", 10.1999989F);
            txtFolioGerente.Location = new Point(692, 26);
            txtFolioGerente.Margin = new Padding(4);
            txtFolioGerente.Name = "txtFolioGerente";
            txtFolioGerente.Size = new Size(159, 27);
            txtFolioGerente.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.1999989F);
            label3.Location = new Point(41, 151);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(147, 20);
            label3.TabIndex = 2;
            label3.Text = "Correo electrónico";
            // 
            // btnEmpleados
            // 
            btnEmpleados.BackColor = Color.FromArgb(140, 74, 30);
            btnEmpleados.Cursor = Cursors.Hand;
            btnEmpleados.FlatStyle = FlatStyle.Popup;
            btnEmpleados.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmpleados.ForeColor = SystemColors.ControlLightLight;
            btnEmpleados.Location = new Point(20, 88);
            btnEmpleados.Margin = new Padding(4);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(151, 36);
            btnEmpleados.TabIndex = 19;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.UseVisualStyleBackColor = false;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // pbLogo
            // 
            pbLogo.BackColor = Color.FromArgb(140, 74, 30);
            pbLogo.Image = Properties.Resources.logodesertico;
            pbLogo.Location = new Point(-1, 0);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(148, 85);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 22;
            pbLogo.TabStop = false;
            // 
            // gbQueBuscas
            // 
            gbQueBuscas.BackColor = SystemColors.ControlLightLight;
            gbQueBuscas.Controls.Add(btnTerrenos);
            gbQueBuscas.Controls.Add(btnEmpleados);
            gbQueBuscas.Controls.Add(btnClientes);
            gbQueBuscas.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Italic, GraphicsUnit.Point, 0);
            gbQueBuscas.Location = new Point(1286, 96);
            gbQueBuscas.Margin = new Padding(4);
            gbQueBuscas.Name = "gbQueBuscas";
            gbQueBuscas.Padding = new Padding(4);
            gbQueBuscas.Size = new Size(195, 192);
            gbQueBuscas.TabIndex = 22;
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
            btnTerrenos.Location = new Point(20, 132);
            btnTerrenos.Margin = new Padding(4);
            btnTerrenos.Name = "btnTerrenos";
            btnTerrenos.Size = new Size(151, 36);
            btnTerrenos.TabIndex = 20;
            btnTerrenos.Text = "Terrenos";
            btnTerrenos.UseVisualStyleBackColor = false;
            btnTerrenos.Click += btnTerrenos_Click;
            // 
            // dtgDatos
            // 
            dtgDatos.BackgroundColor = Color.FromArgb(210, 134, 77);
            dtgDatos.BorderStyle = BorderStyle.None;
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatos.Location = new Point(12, 349);
            dtgDatos.Name = "dtgDatos";
            dtgDatos.RowHeadersWidth = 51;
            dtgDatos.Size = new Size(1266, 272);
            dtgDatos.TabIndex = 24;
            // 
            // gbAcciones
            // 
            gbAcciones.BackColor = SystemColors.ControlLightLight;
            gbAcciones.Controls.Add(btnRegistrarPago);
            gbAcciones.Controls.Add(btnLimpiar);
            gbAcciones.Controls.Add(btnEliminar);
            gbAcciones.Controls.Add(btnModificar);
            gbAcciones.Controls.Add(btnAgregar);
            gbAcciones.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Italic, GraphicsUnit.Point, 0);
            gbAcciones.Location = new Point(1288, 349);
            gbAcciones.Margin = new Padding(4);
            gbAcciones.Name = "gbAcciones";
            gbAcciones.Padding = new Padding(4);
            gbAcciones.Size = new Size(195, 271);
            gbAcciones.TabIndex = 23;
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
            btnRegistrarPago.Location = new Point(18, 214);
            btnRegistrarPago.Margin = new Padding(4);
            btnRegistrarPago.Name = "btnRegistrarPago";
            btnRegistrarPago.Size = new Size(151, 36);
            btnRegistrarPago.TabIndex = 36;
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
            btnLimpiar.Location = new Point(18, 170);
            btnLimpiar.Margin = new Padding(4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(151, 36);
            btnLimpiar.TabIndex = 21;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(140, 74, 30);
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = SystemColors.ControlLightLight;
            btnEliminar.Location = new Point(18, 126);
            btnEliminar.Margin = new Padding(4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(151, 36);
            btnEliminar.TabIndex = 20;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(140, 74, 30);
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.FlatStyle = FlatStyle.Popup;
            btnModificar.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = SystemColors.ControlLightLight;
            btnModificar.Location = new Point(18, 82);
            btnModificar.Margin = new Padding(4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(151, 36);
            btnModificar.TabIndex = 19;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(140, 74, 30);
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = SystemColors.ControlLightLight;
            btnAgregar.Location = new Point(18, 38);
            btnAgregar.Margin = new Padding(4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(151, 36);
            btnAgregar.TabIndex = 15;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
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
            gbContraseñas.Location = new Point(879, 96);
            gbContraseñas.Margin = new Padding(4);
            gbContraseñas.Name = "gbContraseñas";
            gbContraseñas.Padding = new Padding(4);
            gbContraseñas.Size = new Size(399, 192);
            gbContraseñas.TabIndex = 22;
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
            label6.Location = new Point(8, 57);
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
            label7.Location = new Point(8, 95);
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
            // lblFiltroFolio
            // 
            lblFiltroFolio.AutoSize = true;
            lblFiltroFolio.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFiltroFolio.Location = new Point(13, 320);
            lblFiltroFolio.Margin = new Padding(4, 0, 4, 0);
            lblFiltroFolio.Name = "lblFiltroFolio";
            lblFiltroFolio.Size = new Size(134, 20);
            lblFiltroFolio.TabIndex = 35;
            lblFiltroFolio.Text = "Filtro por folio ";
            // 
            // cmbBuscar
            // 
            cmbBuscar.BackColor = Color.FromArgb(210, 134, 77);
            cmbBuscar.Cursor = Cursors.Hand;
            cmbBuscar.FlatStyle = FlatStyle.Flat;
            cmbBuscar.FormattingEnabled = true;
            cmbBuscar.Location = new Point(156, 315);
            cmbBuscar.Name = "cmbBuscar";
            cmbBuscar.Size = new Size(204, 28);
            cmbBuscar.TabIndex = 34;
            cmbBuscar.SelectedIndexChanged += cmbBuscar_SelectedIndexChanged;
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.BackColor = Color.FromArgb(140, 74, 30);
            lblCargo.Font = new Font("Microsoft Sans Serif", 10.1999989F);
            lblCargo.ForeColor = Color.Snow;
            lblCargo.Location = new Point(154, 57);
            lblCargo.Margin = new Padding(4, 0, 4, 0);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(141, 20);
            lblCargo.TabIndex = 19;
            lblCargo.Text = "Nombre completo";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Microsoft Sans Serif", 10.8F);
            txtNombre.Location = new Point(130, 67);
            txtNombre.Margin = new Padding(4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(291, 28);
            txtNombre.TabIndex = 26;
            // 
            // txtApellidos
            // 
            txtApellidos.Font = new Font("Microsoft Sans Serif", 10.8F);
            txtApellidos.Location = new Point(543, 67);
            txtApellidos.Margin = new Padding(4);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(291, 28);
            txtApellidos.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.1999989F);
            label5.Location = new Point(445, 75);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 36;
            label5.Text = "Apellidos";
            // 
            // FGerente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1496, 634);
            Controls.Add(lblCargo);
            Controls.Add(lblFiltroFolio);
            Controls.Add(cmbBuscar);
            Controls.Add(gbContraseñas);
            Controls.Add(gbAcciones);
            Controls.Add(dtgDatos);
            Controls.Add(gbQueBuscas);
            Controls.Add(pbLogo);
            Controls.Add(gbDatosPropietario);
            Controls.Add(lbCerrarSesion);
            Controls.Add(lbBienvenido);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FGerente";
            Text = "Inicio de sesión como gerente";
            Load += FGerente_Load;
            gbDatosPropietario.ResumeLayout(false);
            gbDatosPropietario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            gbQueBuscas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgDatos).EndInit();
            gbAcciones.ResumeLayout(false);
            gbContraseñas.ResumeLayout(false);
            gbContraseñas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClientes;
        private Label lbBienvenido;
        private Label lbCerrarSesion;
        private GroupBox gbDatosPropietario;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private Label label4;
        private Label label1;
        private Label label2;
        private TextBox txtFolioGerente;
        private Label label3;
        private Button btnEmpleados;
        private PictureBox pbLogo;
        private GroupBox gbQueBuscas;
        private Button btnTerrenos;
        private DataGridView dtgDatos;
        private GroupBox gbAcciones;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private Button btnLimpiar;
        private GroupBox gbContraseñas;
        private Button btnCambiarContraseña;
        private TextBox txtContraNueva;
        private Label label6;
        private Label label7;
        private TextBox txtContraActual;
        private Label lblFiltroFolio;
        private ComboBox cmbBuscar;
        private Label lblCargo;
        private Button btnRegistrarPago;
        private Label label5;
        private TextBox txtApellidos;
        private TextBox txtNombre;
    }
}