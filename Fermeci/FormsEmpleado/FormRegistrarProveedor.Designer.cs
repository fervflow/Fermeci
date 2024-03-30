namespace Fermeci
{
    partial class FormRegistrarProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistrarProveedor));
            pictureBox1 = new PictureBox();
            btX = new Button();
            lbNombre = new Label();
            tbNombre = new TextBox();
            lbDireccion = new Label();
            tbDireccion = new TextBox();
            lbTelefono = new Label();
            tbTelefono = new TextBox();
            lbUbicacion = new Label();
            tbUbicacion = new TextBox();
            btRegistrar = new Button();
            lbRegistroProveedor = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 355);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 143);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btX
            // 
            btX.BackColor = Color.FromArgb(68, 108, 84);
            btX.FlatAppearance.BorderSize = 0;
            btX.FlatStyle = FlatStyle.Flat;
            btX.ForeColor = SystemColors.ControlLightLight;
            btX.Location = new Point(12, 12);
            btX.Name = "btX";
            btX.Size = new Size(75, 23);
            btX.TabIndex = 2;
            btX.Text = "X";
            btX.UseVisualStyleBackColor = false;
            btX.Click += btX_Click;
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Font = new Font("Segoe UI", 12F);
            lbNombre.Location = new Point(160, 149);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(71, 21);
            lbNombre.TabIndex = 11;
            lbNombre.Text = "Nombre:";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(245, 147);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(239, 23);
            tbNombre.TabIndex = 10;
            // 
            // lbDireccion
            // 
            lbDireccion.AutoSize = true;
            lbDireccion.Font = new Font("Segoe UI", 12F);
            lbDireccion.Location = new Point(153, 188);
            lbDireccion.Name = "lbDireccion";
            lbDireccion.Size = new Size(78, 21);
            lbDireccion.TabIndex = 13;
            lbDireccion.Text = "Direccion:";
            // 
            // tbDireccion
            // 
            tbDireccion.Location = new Point(245, 186);
            tbDireccion.Name = "tbDireccion";
            tbDireccion.Size = new Size(239, 23);
            tbDireccion.TabIndex = 12;
            // 
            // lbTelefono
            // 
            lbTelefono.AutoSize = true;
            lbTelefono.Font = new Font("Segoe UI", 12F);
            lbTelefono.Location = new Point(77, 231);
            lbTelefono.Name = "lbTelefono";
            lbTelefono.Size = new Size(154, 21);
            lbTelefono.TabIndex = 15;
            lbTelefono.Text = "Número de Teléfono:";
            // 
            // tbTelefono
            // 
            tbTelefono.Location = new Point(245, 229);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(239, 23);
            tbTelefono.TabIndex = 14;
            // 
            // lbUbicacion
            // 
            lbUbicacion.AutoSize = true;
            lbUbicacion.Font = new Font("Segoe UI", 12F);
            lbUbicacion.Location = new Point(150, 275);
            lbUbicacion.Name = "lbUbicacion";
            lbUbicacion.Size = new Size(81, 21);
            lbUbicacion.TabIndex = 17;
            lbUbicacion.Text = "Ubicación:";
            // 
            // tbUbicacion
            // 
            tbUbicacion.Location = new Point(245, 273);
            tbUbicacion.Name = "tbUbicacion";
            tbUbicacion.Size = new Size(239, 23);
            tbUbicacion.TabIndex = 16;
            // 
            // btRegistrar
            // 
            btRegistrar.BackColor = Color.FromArgb(68, 108, 84);
            btRegistrar.FlatAppearance.BorderSize = 0;
            btRegistrar.FlatStyle = FlatStyle.Flat;
            btRegistrar.ForeColor = SystemColors.ControlLightLight;
            btRegistrar.Location = new Point(409, 326);
            btRegistrar.Name = "btRegistrar";
            btRegistrar.Size = new Size(75, 23);
            btRegistrar.TabIndex = 18;
            btRegistrar.Text = "Registrar";
            btRegistrar.UseVisualStyleBackColor = false;
            btRegistrar.Click += btRegistrar_Click;
            // 
            // lbRegistroProveedor
            // 
            lbRegistroProveedor.AutoSize = true;
            lbRegistroProveedor.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbRegistroProveedor.ForeColor = Color.FromArgb(68, 108, 84);
            lbRegistroProveedor.Location = new Point(205, 33);
            lbRegistroProveedor.Name = "lbRegistroProveedor";
            lbRegistroProveedor.Size = new Size(201, 30);
            lbRegistroProveedor.TabIndex = 19;
            lbRegistroProveedor.Text = "Registro Proveedor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(492, 9);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 20;
            label2.Text = "JEELM©2024";
            // 
            // FormRegistrarProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 510);
            Controls.Add(label2);
            Controls.Add(lbRegistroProveedor);
            Controls.Add(btRegistrar);
            Controls.Add(lbUbicacion);
            Controls.Add(tbUbicacion);
            Controls.Add(lbTelefono);
            Controls.Add(tbTelefono);
            Controls.Add(lbDireccion);
            Controls.Add(tbDireccion);
            Controls.Add(lbNombre);
            Controls.Add(tbNombre);
            Controls.Add(btX);
            Controls.Add(pictureBox1);
            MaximumSize = new Size(607, 549);
            MinimumSize = new Size(607, 549);
            Name = "FormRegistrarProveedor";
            Text = "Registro Proveedor";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btX;
        private Label lbNombre;
        private TextBox tbNombre;
        private Label lbDireccion;
        private TextBox tbDireccion;
        private Label lbTelefono;
        private TextBox tbTelefono;
        private Label lbUbicacion;
        private TextBox tbUbicacion;
        private Button btRegistrar;
        private Label lbRegistroProveedor;
        private Label label2;
    }
}