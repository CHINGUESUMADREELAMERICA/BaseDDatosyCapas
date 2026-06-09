namespace CapaPresentacion
{
    partial class FTerreno
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
            gbAcciones = new GroupBox();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            dtgDatos = new DataGridView();
            lbAtras = new Label();
            label6 = new Label();
            label5 = new Label();
            cmbBuscar = new ComboBox();
            gbAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
            SuspendLayout();
            // 
            // gbAcciones
            // 
            gbAcciones.BackColor = SystemColors.ControlLightLight;
            gbAcciones.Controls.Add(btnGuardar);
            gbAcciones.Controls.Add(btnLimpiar);
            gbAcciones.Controls.Add(btnEliminar);
            gbAcciones.Controls.Add(btnModificar);
            gbAcciones.Controls.Add(btnAgregar);
            gbAcciones.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Italic, GraphicsUnit.Point, 0);
            gbAcciones.Location = new Point(13, 84);
            gbAcciones.Margin = new Padding(4);
            gbAcciones.Name = "gbAcciones";
            gbAcciones.Padding = new Padding(4);
            gbAcciones.Size = new Size(195, 288);
            gbAcciones.TabIndex = 24;
            gbAcciones.TabStop = false;
            gbAcciones.Text = "Acciones";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(140, 74, 30);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.ControlLightLight;
            btnGuardar.Location = new Point(22, 48);
            btnGuardar.Margin = new Padding(4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(151, 36);
            btnGuardar.TabIndex = 22;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(140, 74, 30);
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatStyle = FlatStyle.Popup;
            btnLimpiar.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = SystemColors.ControlLightLight;
            btnLimpiar.Location = new Point(22, 224);
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
            btnEliminar.Location = new Point(22, 180);
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
            btnModificar.Location = new Point(22, 136);
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
            btnAgregar.Location = new Point(22, 92);
            btnAgregar.Margin = new Padding(4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(151, 36);
            btnAgregar.TabIndex = 15;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dtgDatos
            // 
            dtgDatos.BackgroundColor = Color.FromArgb(210, 134, 77);
            dtgDatos.BorderStyle = BorderStyle.None;
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatos.Location = new Point(208, 84);
            dtgDatos.Name = "dtgDatos";
            dtgDatos.RowHeadersWidth = 51;
            dtgDatos.Size = new Size(1070, 288);
            dtgDatos.TabIndex = 25;
            // 
            // lbAtras
            // 
            lbAtras.AutoSize = true;
            lbAtras.BackColor = Color.FromArgb(140, 74, 30);
            lbAtras.Cursor = Cursors.Hand;
            lbAtras.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lbAtras.ForeColor = Color.FromArgb(82, 191, 243);
            lbAtras.Location = new Point(1226, 421);
            lbAtras.Margin = new Padding(4, 0, 4, 0);
            lbAtras.Name = "lbAtras";
            lbAtras.Size = new Size(49, 20);
            lbAtras.TabIndex = 26;
            lbAtras.Text = "Atrás";
            lbAtras.Click += btnRetroceder_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(13, 25);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(367, 22);
            label6.TabIndex = 27;
            label6.Text = "Información completa sobre los terrenos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(931, 55);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(134, 20);
            label5.TabIndex = 35;
            label5.Text = "Filtro por folio ";
            // 
            // cmbBuscar
            // 
            cmbBuscar.BackColor = Color.White;
            cmbBuscar.Cursor = Cursors.Hand;
            cmbBuscar.FlatStyle = FlatStyle.Flat;
            cmbBuscar.FormattingEnabled = true;
            cmbBuscar.Location = new Point(1074, 50);
            cmbBuscar.Name = "cmbBuscar";
            cmbBuscar.Size = new Size(204, 28);
            cmbBuscar.TabIndex = 34;
            cmbBuscar.SelectedIndexChanged += cbFolio_SelectedIndexChanged;
            // 
            // FTerreno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(140, 74, 30);
            ClientSize = new Size(1291, 451);
            Controls.Add(label5);
            Controls.Add(cmbBuscar);
            Controls.Add(label6);
            Controls.Add(lbAtras);
            Controls.Add(dtgDatos);
            Controls.Add(gbAcciones);
            Name = "FTerreno";
            Text = "Vista general del terreno";
            Load += FTerreno_Load;
            gbAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbAcciones;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private DataGridView dtgDatos;
        private Label lbAtras;
        private Label label6;
        private Label label5;
        private ComboBox cmbBuscar;
        private Button btnGuardar;
    }
}