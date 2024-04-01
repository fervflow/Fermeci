namespace Fermeci
{
    partial class FormRegistrarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistrarProducto));
            label7 = new Label();
            lbPrecioVenta = new Label();
            tbPrecioVenta = new TextBox();
            lbPrecioCompra = new Label();
            tbPrecioCompra = new TextBox();
            lbMarca = new Label();
            tbMarca = new TextBox();
            lbTipo = new Label();
            lbNombreProducto = new Label();
            label1 = new Label();
            tbNombre = new TextBox();
            button2 = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btX = new Button();
            lbRegistrarProducto = new Label();
            lbCantidad = new Label();
            lbDescripcion = new Label();
            tbDescripcion = new TextBox();
            cbTipo = new ComboBox();
            lbBs1 = new Label();
            lbBs2 = new Label();
            nCantidad = new NumericUpDown();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nCantidad).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(489, 11);
            label7.Name = "label7";
            label7.Size = new Size(75, 15);
            label7.TabIndex = 33;
            label7.Text = "JEELM©2024";
            // 
            // lbPrecioVenta
            // 
            lbPrecioVenta.AutoSize = true;
            lbPrecioVenta.Font = new Font("Segoe UI", 12F);
            lbPrecioVenta.Location = new Point(142, 283);
            lbPrecioVenta.Name = "lbPrecioVenta";
            lbPrecioVenta.Size = new Size(99, 21);
            lbPrecioVenta.TabIndex = 32;
            lbPrecioVenta.Text = "Precio Venta:";
            // 
            // tbPrecioVenta
            // 
            tbPrecioVenta.Location = new Point(258, 281);
            tbPrecioVenta.Name = "tbPrecioVenta";
            tbPrecioVenta.Size = new Size(142, 23);
            tbPrecioVenta.TabIndex = 31;
            // 
            // lbPrecioCompra
            // 
            lbPrecioCompra.AutoSize = true;
            lbPrecioCompra.Font = new Font("Segoe UI", 12F);
            lbPrecioCompra.Location = new Point(125, 238);
            lbPrecioCompra.Name = "lbPrecioCompra";
            lbPrecioCompra.Size = new Size(116, 21);
            lbPrecioCompra.TabIndex = 30;
            lbPrecioCompra.Text = "Precio Compra:";
            // 
            // tbPrecioCompra
            // 
            tbPrecioCompra.Location = new Point(258, 236);
            tbPrecioCompra.Name = "tbPrecioCompra";
            tbPrecioCompra.Size = new Size(142, 23);
            tbPrecioCompra.TabIndex = 29;
            tbPrecioCompra.TextChanged += tbPrecioCompra_TextChanged;
            // 
            // lbMarca
            // 
            lbMarca.AutoSize = true;
            lbMarca.Font = new Font("Segoe UI", 12F);
            lbMarca.Location = new Point(185, 194);
            lbMarca.Name = "lbMarca";
            lbMarca.Size = new Size(56, 21);
            lbMarca.TabIndex = 28;
            lbMarca.Text = "Marca:";
            // 
            // tbMarca
            // 
            tbMarca.Location = new Point(258, 192);
            tbMarca.Name = "tbMarca";
            tbMarca.Size = new Size(178, 23);
            tbMarca.TabIndex = 27;
            // 
            // lbTipo
            // 
            lbTipo.AutoSize = true;
            lbTipo.Font = new Font("Segoe UI", 12F);
            lbTipo.Location = new Point(198, 151);
            lbTipo.Name = "lbTipo";
            lbTipo.Size = new Size(43, 21);
            lbTipo.TabIndex = 26;
            lbTipo.Text = "Tipo:";
            // 
            // lbNombreProducto
            // 
            lbNombreProducto.AutoSize = true;
            lbNombreProducto.Font = new Font("Segoe UI", 12F);
            lbNombreProducto.Location = new Point(78, 103);
            lbNombreProducto.Name = "lbNombreProducto";
            lbNombreProducto.Size = new Size(163, 21);
            lbNombreProducto.TabIndex = 24;
            lbNombreProducto.Text = "Nombre del Producto:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(183, 111);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 23;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(258, 101);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(178, 23);
            tbNombre.TabIndex = 22;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(68, 108, 84);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(476, 460);
            button2.Name = "button2";
            button2.Size = new Size(103, 37);
            button2.TabIndex = 21;
            button2.Text = "Enviar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 400);
            panel1.Name = "panel1";
            panel1.Size = new Size(114, 100);
            panel1.TabIndex = 20;
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
            // btX
            // 
            btX.BackColor = Color.FromArgb(68, 108, 84);
            btX.FlatAppearance.BorderSize = 0;
            btX.FlatStyle = FlatStyle.Flat;
            btX.ForeColor = SystemColors.ControlLightLight;
            btX.Location = new Point(12, 11);
            btX.Name = "btX";
            btX.Size = new Size(75, 23);
            btX.TabIndex = 19;
            btX.Text = "X";
            btX.UseVisualStyleBackColor = false;
            btX.Click += btX_Click;
            // 
            // lbRegistrarProducto
            // 
            lbRegistrarProducto.AutoSize = true;
            lbRegistrarProducto.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbRegistrarProducto.ForeColor = Color.FromArgb(68, 108, 84);
            lbRegistrarProducto.Location = new Point(198, 29);
            lbRegistrarProducto.Name = "lbRegistrarProducto";
            lbRegistrarProducto.Size = new Size(175, 25);
            lbRegistrarProducto.TabIndex = 18;
            lbRegistrarProducto.Text = "Registro Producto";
            // 
            // lbCantidad
            // 
            lbCantidad.AutoSize = true;
            lbCantidad.Font = new Font("Segoe UI", 12F);
            lbCantidad.Location = new Point(166, 324);
            lbCantidad.Name = "lbCantidad";
            lbCantidad.Size = new Size(75, 21);
            lbCantidad.TabIndex = 35;
            lbCantidad.Text = "Cantidad:";
            // 
            // lbDescripcion
            // 
            lbDescripcion.AutoSize = true;
            lbDescripcion.Font = new Font("Segoe UI", 12F);
            lbDescripcion.Location = new Point(152, 364);
            lbDescripcion.Name = "lbDescripcion";
            lbDescripcion.Size = new Size(94, 21);
            lbDescripcion.TabIndex = 37;
            lbDescripcion.Text = "Descripción:";
            // 
            // tbDescripcion
            // 
            tbDescripcion.Location = new Point(258, 362);
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.Size = new Size(178, 23);
            tbDescripcion.TabIndex = 36;
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Items.AddRange(new object[] { "Herramientas", "Pinturas", "Accesorios Pintura", "Accesorios Baño", "Accesorios Electricos" });
            cbTipo.Location = new Point(258, 149);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(178, 23);
            cbTipo.TabIndex = 38;
            // 
            // lbBs1
            // 
            lbBs1.AutoSize = true;
            lbBs1.Font = new Font("Segoe UI", 12F);
            lbBs1.Location = new Point(397, 238);
            lbBs1.Name = "lbBs1";
            lbBs1.Size = new Size(29, 21);
            lbBs1.TabIndex = 39;
            lbBs1.Text = "Bs.";
            // 
            // lbBs2
            // 
            lbBs2.AutoSize = true;
            lbBs2.Font = new Font("Segoe UI", 12F);
            lbBs2.Location = new Point(397, 283);
            lbBs2.Name = "lbBs2";
            lbBs2.Size = new Size(29, 21);
            lbBs2.TabIndex = 40;
            lbBs2.Text = "Bs.";
            // 
            // nCantidad
            // 
            nCantidad.Location = new Point(258, 322);
            nCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nCantidad.Name = "nCantidad";
            nCantidad.Size = new Size(168, 23);
            nCantidad.TabIndex = 41;
            nCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nCantidad.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // FormRegistrarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 510);
            Controls.Add(nCantidad);
            Controls.Add(lbBs2);
            Controls.Add(lbBs1);
            Controls.Add(cbTipo);
            Controls.Add(lbDescripcion);
            Controls.Add(tbDescripcion);
            Controls.Add(lbCantidad);
            Controls.Add(label7);
            Controls.Add(lbPrecioVenta);
            Controls.Add(tbPrecioVenta);
            Controls.Add(lbPrecioCompra);
            Controls.Add(tbPrecioCompra);
            Controls.Add(lbMarca);
            Controls.Add(tbMarca);
            Controls.Add(lbTipo);
            Controls.Add(lbNombreProducto);
            Controls.Add(label1);
            Controls.Add(tbNombre);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(btX);
            Controls.Add(lbRegistrarProducto);
            MaximumSize = new Size(607, 549);
            MinimumSize = new Size(607, 549);
            Name = "FormRegistrarProducto";
            Text = "Registro Producto";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label lbPrecioVenta;
        private TextBox tbPrecioVenta;
        private Label lbPrecioCompra;
        private TextBox tbPrecioCompra;
        private Label lbMarca;
        private TextBox tbMarca;
        private Label lbTipo;
        private Label lbNombreProducto;
        private Label label1;
        private TextBox tbNombre;
        private Button button2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btX;
        private Label lbRegistrarProducto;
        private Label lbCantidad;
        private Label lbDescripcion;
        private TextBox tbDescripcion;
        private ComboBox cbTipo;
        private Label lbBs1;
        private Label lbBs2;
        private NumericUpDown nCantidad;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}