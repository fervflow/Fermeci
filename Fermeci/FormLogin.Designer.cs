namespace Fermeci
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lbUsuario = new Label();
            lbContraseña = new Label();
            tbNombreUsuario = new TextBox();
            tbContraseña = new TextBox();
            cbCargo = new ComboBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(68, 108, 84);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(163, 283);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-13, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 199);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(271, 27);
            label1.Name = "label1";
            label1.Size = new Size(168, 30);
            label1.TabIndex = 1;
            label1.Text = "Inicio de Sesión";
            // 
            // lbUsuario
            // 
            lbUsuario.AutoSize = true;
            lbUsuario.Location = new Point(236, 95);
            lbUsuario.Name = "lbUsuario";
            lbUsuario.Size = new Size(59, 19);
            lbUsuario.TabIndex = 2;
            lbUsuario.Text = "Usuario:";
            // 
            // lbContraseña
            // 
            lbContraseña.AutoSize = true;
            lbContraseña.Location = new Point(213, 137);
            lbContraseña.Name = "lbContraseña";
            lbContraseña.Size = new Size(82, 19);
            lbContraseña.TabIndex = 3;
            lbContraseña.Text = "Contraseña:";
            // 
            // tbNombreUsuario
            // 
            tbNombreUsuario.Location = new Point(298, 89);
            tbNombreUsuario.Name = "tbNombreUsuario";
            tbNombreUsuario.Size = new Size(198, 25);
            tbNombreUsuario.TabIndex = 4;
            tbNombreUsuario.TextChanged += tbNombreUsuario_TextChanged;
            // 
            // tbContraseña
            // 
            tbContraseña.Location = new Point(298, 131);
            tbContraseña.Name = "tbContraseña";
            tbContraseña.Size = new Size(198, 25);
            tbContraseña.TabIndex = 5;
            tbContraseña.UseSystemPasswordChar = true;
            tbContraseña.TextChanged += tbContraseña_TextChanged;
            // 
            // cbCargo
            // 
            cbCargo.FormattingEnabled = true;
            cbCargo.Items.AddRange(new object[] { "Empleado", "Propietario" });
            cbCargo.Location = new Point(298, 171);
            cbCargo.Name = "cbCargo";
            cbCargo.Size = new Size(198, 25);
            cbCargo.TabIndex = 6;
            cbCargo.SelectedIndexChanged += cbCargo_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(68, 108, 84);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(298, 213);
            button1.Name = "button1";
            button1.Size = new Size(141, 30);
            button1.TabIndex = 7;
            button1.Text = "Acceder";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(466, 255);
            label2.Name = "label2";
            label2.Size = new Size(92, 19);
            label2.TabIndex = 8;
            label2.Text = "JEELM©2024";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(243, 177);
            label3.Name = "label3";
            label3.Size = new Size(49, 19);
            label3.TabIndex = 9;
            label3.Text = "Cargo:";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 283);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(cbCargo);
            Controls.Add(tbContraseña);
            Controls.Add(tbNombreUsuario);
            Controls.Add(lbContraseña);
            Controls.Add(lbUsuario);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormLogin";
            Text = "Ferreteria Fermecí";
            Load += FormLogin_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label lbUsuario;
        private Label lbContraseña;
        private TextBox tbNombreUsuario;
        private TextBox tbContraseña;
        private ComboBox cbCargo;
        private Button button1;
        private Label label2;
        private Label label3;
    }
}