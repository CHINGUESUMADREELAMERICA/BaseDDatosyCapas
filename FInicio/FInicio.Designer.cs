namespace CapaPresentacion
{
    partial class FInicio
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FInicio));
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnAcceder = new Button();
            pbLogo = new PictureBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            salirToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            contactanosToolStripMenuItem = new ToolStripMenuItem();
            teléfonoToolStripMenuItem = new ToolStripMenuItem();
            whatsAppToolStripMenuItem = new ToolStripMenuItem();
            instagramToolStripMenuItem = new ToolStripMenuItem();
            inicioDeSesiónToolStripMenuItem = new ToolStripMenuItem();
            label4 = new Label();
            menuStrip2 = new MenuStrip();
            salirToolStripMenuItem1 = new ToolStripMenuItem();
            acercaDeToolStripMenuItem1 = new ToolStripMenuItem();
            contáctanosToolStripMenuItem = new ToolStripMenuItem();
            inicioDeSesiónToolStripMenuItem1 = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Cliente", "Empleado", "Gerente" });
            comboBox1.Location = new Point(250, 49);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(364, 33);
            comboBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(250, 136);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(446, 32);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(250, 187);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(446, 32);
            textBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Noto Sans Georgian Bold", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 54);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(208, 28);
            label1.TabIndex = 4;
            label1.Text = "Identifica tu puesto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 143);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(171, 25);
            label2.TabIndex = 5;
            label2.Text = "Ingresa tu nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 194);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(199, 25);
            label3.TabIndex = 6;
            label3.Text = "Ingresa tu contraseña";
            // 
            // btnAcceder
            // 
            btnAcceder.BackColor = Color.FromArgb(140, 74, 30);
            btnAcceder.FlatStyle = FlatStyle.Popup;
            btnAcceder.Font = new Font("Noto Sans Georgian Bold", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAcceder.ForeColor = SystemColors.ControlLightLight;
            btnAcceder.Location = new Point(535, 280);
            btnAcceder.Margin = new Padding(4);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(161, 54);
            btnAcceder.TabIndex = 7;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = false;
            // 
            // pbLogo
            // 
            pbLogo.BackColor = Color.FromArgb(140, 74, 30);
            pbLogo.Image = Properties.Resources.logodesertico;
            pbLogo.Location = new Point(10, 6);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(120, 85);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 35;
            pbLogo.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Linen;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(btnAcceder);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(35, 182);
            panel1.Name = "panel1";
            panel1.Size = new Size(722, 358);
            panel1.TabIndex = 36;
            panel1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.personaytexto;
            pictureBox2.Location = new Point(-2, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(722, 358);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 41;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(775, 182);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(465, 358);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(63, 95);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(124, 95);
            acercaDeToolStripMenuItem.Text = "Acerca de...";
            acercaDeToolStripMenuItem.Click += acercaDeToolStripMenuItem1_Click;
            // 
            // contactanosToolStripMenuItem
            // 
            contactanosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { teléfonoToolStripMenuItem, whatsAppToolStripMenuItem, instagramToolStripMenuItem });
            contactanosToolStripMenuItem.ForeColor = Color.White;
            contactanosToolStripMenuItem.Name = "contactanosToolStripMenuItem";
            contactanosToolStripMenuItem.Size = new Size(133, 95);
            contactanosToolStripMenuItem.Text = "Contáctanos";
            // 
            // teléfonoToolStripMenuItem
            // 
            teléfonoToolStripMenuItem.Name = "teléfonoToolStripMenuItem";
            teléfonoToolStripMenuItem.Size = new Size(161, 26);
            teléfonoToolStripMenuItem.Text = "Teléfono";
            // 
            // whatsAppToolStripMenuItem
            // 
            whatsAppToolStripMenuItem.Name = "whatsAppToolStripMenuItem";
            whatsAppToolStripMenuItem.Size = new Size(161, 26);
            whatsAppToolStripMenuItem.Text = "WhatsApp";
            // 
            // instagramToolStripMenuItem
            // 
            instagramToolStripMenuItem.Name = "instagramToolStripMenuItem";
            instagramToolStripMenuItem.Size = new Size(161, 26);
            instagramToolStripMenuItem.Text = "Instagram";
            // 
            // inicioDeSesiónToolStripMenuItem
            // 
            inicioDeSesiónToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            inicioDeSesiónToolStripMenuItem.Name = "inicioDeSesiónToolStripMenuItem";
            inicioDeSesiónToolStripMenuItem.Size = new Size(159, 95);
            inicioDeSesiónToolStripMenuItem.Text = "Inicio de sesión";
            inicioDeSesiónToolStripMenuItem.Click += inicioDeSesiónToolStripMenuItem1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(140, 74, 30);
            label4.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(114, 25);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(299, 51);
            label4.TabIndex = 8;
            label4.Text = "TERRANOVA";
            // 
            // menuStrip2
            // 
            menuStrip2.AutoSize = false;
            menuStrip2.BackColor = Color.FromArgb(140, 74, 30);
            menuStrip2.Font = new Font("Noto Sans Georgian", 10.1999989F);
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { salirToolStripMenuItem1, acercaDeToolStripMenuItem1, contáctanosToolStripMenuItem, inicioDeSesiónToolStripMenuItem1 });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.RightToLeft = RightToLeft.Yes;
            menuStrip2.Size = new Size(1267, 99);
            menuStrip2.TabIndex = 40;
            menuStrip2.Text = "menuStrip2";
            // 
            // salirToolStripMenuItem1
            // 
            salirToolStripMenuItem1.ForeColor = Color.White;
            salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            salirToolStripMenuItem1.Size = new Size(58, 95);
            salirToolStripMenuItem1.Text = "Salir";
            // 
            // acercaDeToolStripMenuItem1
            // 
            acercaDeToolStripMenuItem1.ForeColor = Color.White;
            acercaDeToolStripMenuItem1.Name = "acercaDeToolStripMenuItem1";
            acercaDeToolStripMenuItem1.Size = new Size(117, 95);
            acercaDeToolStripMenuItem1.Text = "Acerca de...";
            // 
            // contáctanosToolStripMenuItem
            // 
            contáctanosToolStripMenuItem.ForeColor = Color.White;
            contáctanosToolStripMenuItem.Name = "contáctanosToolStripMenuItem";
            contáctanosToolStripMenuItem.Size = new Size(125, 95);
            contáctanosToolStripMenuItem.Text = "Contáctanos";
            // 
            // inicioDeSesiónToolStripMenuItem1
            // 
            inicioDeSesiónToolStripMenuItem1.ForeColor = SystemColors.ControlLightLight;
            inicioDeSesiónToolStripMenuItem1.Name = "inicioDeSesiónToolStripMenuItem1";
            inicioDeSesiónToolStripMenuItem1.Size = new Size(146, 95);
            inicioDeSesiónToolStripMenuItem1.Text = "Inicio de sesión";
            inicioDeSesiónToolStripMenuItem1.Click += inicioDeSesiónToolStripMenuItem1_Click;
            // 
            // FInicio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1267, 596);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(pbLogo);
            Controls.Add(panel1);
            Controls.Add(menuStrip2);
            DoubleBuffered = true;
            Font = new Font("Noto Sans Georgian", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = menuStrip2;
            Margin = new Padding(4);
            Name = "FInicio";
            Text = "Bienvenido a Terranova";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAcceder;
        private PictureBox pbLogo;
        private Panel panel1;
        private MenuStrip menuStrip1;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
     
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripMenuItem contactanosToolStripMenuItem;
        private ToolStripMenuItem inicioDeSesiónToolStripMenuItem;
        private ToolStripMenuItem teléfonoToolStripMenuItem;
        private ToolStripMenuItem whatsAppToolStripMenuItem;
        private ToolStripMenuItem instagramToolStripMenuItem;
        private Label label4;
        private PictureBox pictureBox2;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem salirToolStripMenuItem1;
        private ToolStripMenuItem acercaDeToolStripMenuItem1;
        private ToolStripMenuItem contáctanosToolStripMenuItem;
        private ToolStripMenuItem inicioDeSesiónToolStripMenuItem1;
    }
}