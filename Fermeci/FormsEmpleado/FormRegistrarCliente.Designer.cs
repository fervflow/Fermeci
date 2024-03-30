namespace Fermeci
{
    partial class FormRegistrarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistrarCliente));
            lbRegistrarCliente = new Label();
            btX = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btEnviar = new Button();
            tbNombres = new TextBox();
            label1 = new Label();
            lbNombre = new Label();
            lbCi = new Label();
            tbCi = new TextBox();
            lbDireccion = new Label();
            tbDireccion = new TextBox();
            lbTelefono = new Label();
            tbTelefono = new TextBox();
            label7 = new Label();
            tbApellidos = new TextBox();
            lbApellidos = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbRegistrarCliente
            // 
            lbRegistrarCliente.AutoSize = true;
            lbRegistrarCliente.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbRegistrarCliente.ForeColor = Color.FromArgb(68, 108, 84);
            lbRegistrarCliente.Location = new Point(211, 30);
            lbRegistrarCliente.Name = "lbRegistrarCliente";
            lbRegistrarCliente.Size = new Size(152, 25);
            lbRegistrarCliente.TabIndex = 0;
            lbRegistrarCliente.Text = "Registro Cliente";
            // 
            // btX
            // 
            btX.BackColor = Color.FromArgb(68, 108, 84);
            btX.FlatAppearance.BorderSize = 0;
            btX.FlatStyle = FlatStyle.Flat;
            btX.ForeColor = SystemColors.ControlLightLight;
            btX.Location = new Point(12, 9);
            btX.Name = "btX";
            btX.Size = new Size(75, 23);
            btX.TabIndex = 1;
            btX.Text = "X";
            btX.UseVisualStyleBackColor = false;
//            btX.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 398);
            panel1.Name = "panel1";
            panel1.Size = new Size(114, 100);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btEnviar
            // 
            btEnviar.BackColor = Color.FromArgb(68, 108, 84);
            btEnviar.FlatAppearance.BorderSize = 0;
            btEnviar.FlatStyle = FlatStyle.Flat;
            btEnviar.ForeColor = SystemColors.ControlLightLight;
            btEnviar.Location = new Point(476, 458);
            btEnviar.Name = "btEnviar";
            btEnviar.Size = new Size(103, 37);
            btEnviar.TabIndex = 3;
            btEnviar.Text = "Enviar";
            btEnviar.UseVisualStyleBackColor = false;
            btEnviar.Click += button2_Click;
            // 
            // tbNombres
            // 
            tbNombres.Location = new Point(258, 99);
            tbNombres.Name = "tbNombres";
            tbNombres.Size = new Size(178, 23);
            tbNombres.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(183, 109);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 5;
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Font = new Font("Segoe UI", 12F);
            lbNombre.Location = new Point(168, 101);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(78, 21);
            lbNombre.TabIndex = 8;
            lbNombre.Text = "Nombres:";
            // 
            // lbCi
            // 
            lbCi.AutoSize = true;
            lbCi.Font = new Font("Segoe UI", 12F);
            lbCi.Location = new Point(95, 192);
            lbCi.Name = "lbCi";
            lbCi.Size = new Size(151, 21);
            lbCi.TabIndex = 12;
            lbCi.Text = "Cédula de Identidad:";
            // 
            // tbCi
            // 
            tbCi.Location = new Point(258, 190);
            tbCi.Name = "tbCi";
            tbCi.Size = new Size(178, 23);
            tbCi.TabIndex = 11;
            // 
            // lbDireccion
            // 
            lbDireccion.AutoSize = true;
            lbDireccion.Font = new Font("Segoe UI", 12F);
            lbDireccion.Location = new Point(168, 236);
            lbDireccion.Name = "lbDireccion";
            lbDireccion.Size = new Size(78, 21);
            lbDireccion.TabIndex = 14;
            lbDireccion.Text = "Dirección:";
            // 
            // tbDireccion
            // 
            tbDireccion.Location = new Point(258, 234);
            tbDireccion.Name = "tbDireccion";
            tbDireccion.Size = new Size(178, 23);
            tbDireccion.TabIndex = 13;
            // 
            // lbTelefono
            // 
            lbTelefono.AutoSize = true;
            lbTelefono.Font = new Font("Segoe UI", 12F);
            lbTelefono.Location = new Point(91, 281);
            lbTelefono.Name = "lbTelefono";
            lbTelefono.Size = new Size(154, 21);
            lbTelefono.TabIndex = 16;
            lbTelefono.Text = "Número de Teléfono:";
            // 
            // tbTelefono
            // 
            tbTelefono.Location = new Point(258, 279);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(178, 23);
            tbTelefono.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(494, 13);
            label7.Name = "label7";
            label7.Size = new Size(75, 15);
            label7.TabIndex = 17;
            label7.Text = "JEELM©2024";
            // 
            // tbApellidos
            // 
            tbApellidos.Location = new Point(258, 147);
            tbApellidos.Name = "tbApellidos";
            tbApellidos.Size = new Size(178, 23);
            tbApellidos.TabIndex = 9;
            // 
            // lbApellidos
            // 
            lbApellidos.AutoSize = true;
            lbApellidos.Font = new Font("Segoe UI", 12F);
            lbApellidos.Location = new Point(168, 149);
            lbApellidos.Name = "lbApellidos";
            lbApellidos.Size = new Size(77, 21);
            lbApellidos.TabIndex = 10;
            lbApellidos.Text = "Apellidos:";
            // 
            // FormRegistrarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 510);
            Controls.Add(label7);
            Controls.Add(lbTelefono);
            Controls.Add(tbTelefono);
            Controls.Add(lbDireccion);
            Controls.Add(tbDireccion);
            Controls.Add(lbCi);
            Controls.Add(tbCi);
            Controls.Add(lbApellidos);
            Controls.Add(tbApellidos);
            Controls.Add(lbNombre);
            Controls.Add(label1);
            Controls.Add(tbNombres);
            Controls.Add(btEnviar);
            Controls.Add(panel1);
            Controls.Add(btX);
            Controls.Add(lbRegistrarCliente);
            MaximumSize = new Size(607, 549);
            MinimumSize = new Size(607, 549);
            Name = "FormRegistrarCliente";
            Text = "Registro Cliente";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbRegistrarCliente;
        private Button btX;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btEnviar;
        private TextBox tbNombres;
        private Label label1;
        private Label lbNombre;
        private Label lbCi;
        private TextBox tbCi;
        private Label lbDireccion;
        private TextBox tbDireccion;
        private Label lbTelefono;
        private TextBox tbTelefono;
        private Label label7;
        private TextBox tbApellidos;
        private Label lbApellidos;
    }
}