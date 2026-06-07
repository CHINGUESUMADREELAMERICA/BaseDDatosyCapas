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
            lbCerrarSesion = new Label();
            lbBienvenido = new Label();
            SuspendLayout();
            // 
            // lbCerrarSesion
            // 
            lbCerrarSesion.AutoSize = true;
            lbCerrarSesion.BackColor = Color.FromArgb(140, 74, 30);
            lbCerrarSesion.Cursor = Cursors.Hand;
            lbCerrarSesion.Font = new Font("Noto Sans Georgian", 10.1999989F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lbCerrarSesion.ForeColor = Color.FromArgb(82, 191, 243);
            lbCerrarSesion.Location = new Point(1035, 12);
            lbCerrarSesion.Margin = new Padding(4, 0, 4, 0);
            lbCerrarSesion.Name = "lbCerrarSesion";
            lbCerrarSesion.Size = new Size(118, 23);
            lbCerrarSesion.TabIndex = 21;
            lbCerrarSesion.Text = "Cerrar Sesión";
            // 
            // lbBienvenido
            // 
            lbBienvenido.BackColor = Color.FromArgb(140, 74, 30);
            lbBienvenido.Font = new Font("Noto Serif Armenian", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbBienvenido.ForeColor = SystemColors.ControlLightLight;
            lbBienvenido.Location = new Point(-2, -1);
            lbBienvenido.Margin = new Padding(4, 0, 4, 0);
            lbBienvenido.Name = "lbBienvenido";
            lbBienvenido.Size = new Size(1192, 73);
            lbBienvenido.TabIndex = 20;
            lbBienvenido.Text = "Bienvenid@ \"Fulanito de tal\"";
            lbBienvenido.TextAlign = ContentAlignment.BottomCenter;
            // 
            // FEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1190, 600);
            Controls.Add(lbCerrarSesion);
            Controls.Add(lbBienvenido);
            Name = "FEmpleado";
            Text = "FEmpleado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCerrarSesion;
        private Label lbBienvenido;
    }
}