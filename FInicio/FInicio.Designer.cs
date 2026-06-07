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
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 

            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Cliente", "Empleado", "Gerente" });

            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.FromArgb(140, 74, 30);
            menuStrip1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 2, 0, 2);
            menuStrip1.Size = new Size(840, 115);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
    
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(280, 184);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(364, 30);
            comboBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(250, 136);
            textBox1.Location = new Point(284, 284);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(446, 28);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(250, 187);
            textBox2.Location = new Point(284, 335);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(446, 28);
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
            label1.Size = new Size(160, 22);
            label1.TabIndex = 4;
            label1.Text = "Identifica tu puesto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 143);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(154, 22);
            label2.TabIndex = 5;
            label2.Text = "Ingresa tu nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 194);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(183, 22);
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

            btnAcceder.FlatStyle = FlatStyle.Flat;
            btnAcceder.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAcceder.ForeColor = SystemColors.ControlLightLight;
            btnAcceder.Location = new Point(571, 412);
            btnAcceder.Margin = new Padding(4);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(161, 54);
            btnAcceder.TabIndex = 7;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = false;
            btnAcceder.Click += btnAcceder_Click;
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
            // FInicio
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1267, 596);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(pbLogo);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Font = new Font("Noto Sans Georgian", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            ClientSize = new Size(840, 562);
            Controls.Add(btnAcceder);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(menuStrip1);
            Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "FInicio";
            Text = "Bienvenido a Terranova";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        
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
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
     
        private Label label4;
        private PictureBox pictureBox2;
        private MenuStrip menuStrip1;
     
    }
}