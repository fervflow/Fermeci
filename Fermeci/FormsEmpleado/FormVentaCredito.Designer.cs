namespace Fermeci
{
    partial class FormVentaCredito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVentaCredito));
            btX2 = new Button();
            lbFechaHora = new Label();
            lbNombreProducto = new Label();
            tbNombreProducto = new TextBox();
            lbCantidad = new Label();
            tbCantidad = new TextBox();
            lbPrecioUnitario = new Label();
            tbPrecioUnitario = new TextBox();
            lbTotalPagar = new Label();
            tbTotalPagar = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            lbPlazoPago = new Label();
            label8 = new Label();
            cbPlazoPago = new ComboBox();
            lbVentaCredito = new Label();
            lbBs1 = new Label();
            lbBs2 = new Label();
            lbBsTotal = new Label();
            label1 = new Label();
            lbMeses = new Label();
            label2 = new Label();
            label3 = new Label();
            lbIdCliente = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btX2
            // 
            btX2.BackColor = Color.FromArgb(68, 108, 84);
            btX2.FlatAppearance.BorderSize = 0;
            btX2.FlatStyle = FlatStyle.Flat;
            btX2.ForeColor = SystemColors.ControlLightLight;
            btX2.Location = new Point(12, 12);
            btX2.Name = "btX2";
            btX2.Size = new Size(75, 23);
            btX2.TabIndex = 0;
            btX2.Text = "X";
            btX2.UseVisualStyleBackColor = false;
            btX2.Click += btX2_Click;
            // 
            // lbFechaHora
            // 
            lbFechaHora.AutoSize = true;
            lbFechaHora.Font = new Font("Segoe UI", 12F);
            lbFechaHora.Location = new Point(73, 92);
            lbFechaHora.Name = "lbFechaHora";
            lbFechaHora.Size = new Size(50, 21);
            lbFechaHora.TabIndex = 7;
            lbFechaHora.Text = "Fecha";
            // 
            // lbNombreProducto
            // 
            lbNombreProducto.AutoSize = true;
            lbNombreProducto.Font = new Font("Segoe UI", 12F);
            lbNombreProducto.Location = new Point(51, 171);
            lbNombreProducto.Name = "lbNombreProducto";
            lbNombreProducto.Size = new Size(163, 21);
            lbNombreProducto.TabIndex = 11;
            lbNombreProducto.Text = "Nombre del Producto:";
            // 
            // tbNombreProducto
            // 
            tbNombreProducto.Location = new Point(242, 169);
            tbNombreProducto.Name = "tbNombreProducto";
            tbNombreProducto.Size = new Size(239, 23);
            tbNombreProducto.TabIndex = 10;
            // 
            // lbCantidad
            // 
            lbCantidad.AutoSize = true;
            lbCantidad.Font = new Font("Segoe UI", 12F);
            lbCantidad.Location = new Point(139, 217);
            lbCantidad.Name = "lbCantidad";
            lbCantidad.Size = new Size(75, 21);
            lbCantidad.TabIndex = 13;
            lbCantidad.Text = "Cantidad:";
            // 
            // tbCantidad
            // 
            tbCantidad.Location = new Point(242, 215);
            tbCantidad.Name = "tbCantidad";
            tbCantidad.Size = new Size(204, 23);
            tbCantidad.TabIndex = 12;
            tbCantidad.TextChanged += tbCantidad_TextChanged;
            // 
            // lbPrecioUnitario
            // 
            lbPrecioUnitario.AutoSize = true;
            lbPrecioUnitario.Font = new Font("Segoe UI", 12F);
            lbPrecioUnitario.Location = new Point(98, 262);
            lbPrecioUnitario.Name = "lbPrecioUnitario";
            lbPrecioUnitario.Size = new Size(116, 21);
            lbPrecioUnitario.TabIndex = 15;
            lbPrecioUnitario.Text = "Precio Unitario:";
            // 
            // tbPrecioUnitario
            // 
            tbPrecioUnitario.Location = new Point(242, 260);
            tbPrecioUnitario.Name = "tbPrecioUnitario";
            tbPrecioUnitario.Size = new Size(204, 23);
            tbPrecioUnitario.TabIndex = 14;
            tbPrecioUnitario.TextChanged += tbPrecioUnitario_TextChanged;
            // 
            // lbTotalPagar
            // 
            lbTotalPagar.AutoSize = true;
            lbTotalPagar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotalPagar.Location = new Point(210, 418);
            lbTotalPagar.Name = "lbTotalPagar";
            lbTotalPagar.Size = new Size(114, 21);
            lbTotalPagar.TabIndex = 17;
            lbTotalPagar.Text = "Total a Pagar:";
            // 
            // tbTotalPagar
            // 
            tbTotalPagar.Location = new Point(327, 416);
            tbTotalPagar.Name = "tbTotalPagar";
            tbTotalPagar.Size = new Size(192, 23);
            tbTotalPagar.TabIndex = 16;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(68, 108, 84);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(483, 464);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 18;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 374);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // lbPlazoPago
            // 
            lbPlazoPago.AutoSize = true;
            lbPlazoPago.Font = new Font("Segoe UI", 12F);
            lbPlazoPago.Location = new Point(105, 304);
            lbPlazoPago.Name = "lbPlazoPago";
            lbPlazoPago.Size = new Size(109, 21);
            lbPlazoPago.TabIndex = 21;
            lbPlazoPago.Text = "Plazo de Pago:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(266, 328);
            label8.Name = "label8";
            label8.Size = new Size(215, 15);
            label8.TabIndex = 22;
            label8.Text = "*Se cobrará un interés del 0,5% por mes";
            // 
            // cbPlazoPago
            // 
            cbPlazoPago.FormattingEnabled = true;
            cbPlazoPago.Items.AddRange(new object[] { "2", "4", "6" });
            cbPlazoPago.Location = new Point(266, 302);
            cbPlazoPago.Name = "cbPlazoPago";
            cbPlazoPago.Size = new Size(78, 23);
            cbPlazoPago.TabIndex = 23;
            cbPlazoPago.SelectedIndexChanged += cbPlazoPago_SelectedIndexChanged;
            // 
            // lbVentaCredito
            // 
            lbVentaCredito.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbVentaCredito.AutoSize = true;
            lbVentaCredito.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbVentaCredito.ForeColor = Color.FromArgb(68, 108, 84);
            lbVentaCredito.Location = new Point(229, 12);
            lbVentaCredito.Name = "lbVentaCredito";
            lbVentaCredito.Size = new Size(149, 25);
            lbVentaCredito.TabIndex = 24;
            lbVentaCredito.Text = "Venta a Crédito";
            // 
            // lbBs1
            // 
            lbBs1.AutoSize = true;
            lbBs1.Font = new Font("Segoe UI", 12F);
            lbBs1.Location = new Point(452, 217);
            lbBs1.Name = "lbBs1";
            lbBs1.Size = new Size(29, 21);
            lbBs1.TabIndex = 25;
            lbBs1.Text = "Bs.";
            // 
            // lbBs2
            // 
            lbBs2.AutoSize = true;
            lbBs2.Font = new Font("Segoe UI", 12F);
            lbBs2.Location = new Point(452, 262);
            lbBs2.Name = "lbBs2";
            lbBs2.Size = new Size(29, 21);
            lbBs2.TabIndex = 26;
            lbBs2.Text = "Bs.";
            // 
            // lbBsTotal
            // 
            lbBsTotal.AutoSize = true;
            lbBsTotal.Font = new Font("Segoe UI", 12F);
            lbBsTotal.Location = new Point(525, 418);
            lbBsTotal.Name = "lbBsTotal";
            lbBsTotal.Size = new Size(29, 21);
            lbBsTotal.TabIndex = 27;
            lbBsTotal.Text = "Bs.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(360, 309);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 28;
            // 
            // lbMeses
            // 
            lbMeses.AutoSize = true;
            lbMeses.Font = new Font("Segoe UI", 12F);
            lbMeses.Location = new Point(347, 302);
            lbMeses.Name = "lbMeses";
            lbMeses.Size = new Size(54, 21);
            lbMeses.TabIndex = 29;
            lbMeses.Text = "Meses";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(496, 9);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 30;
            label2.Text = "JEELM©2024";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(148, 446);
            label3.Name = "label3";
            label3.Size = new Size(348, 15);
            label3.TabIndex = 31;
            label3.Text = "*Se agregó el 0.5% de interes al total de acuerdo al plazo de pago\r\n";
            // 
            // lbIdCliente
            // 
            lbIdCliente.AutoSize = true;
            lbIdCliente.Font = new Font("Segoe UI", 12F);
            lbIdCliente.Location = new Point(136, 130);
            lbIdCliente.Name = "lbIdCliente";
            lbIdCliente.Size = new Size(78, 21);
            lbIdCliente.TabIndex = 33;
            lbIdCliente.Text = "Id Cliente:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(242, 128);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(239, 23);
            textBox1.TabIndex = 32;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 510);
            Controls.Add(lbIdCliente);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbMeses);
            Controls.Add(label1);
            Controls.Add(lbBsTotal);
            Controls.Add(lbBs2);
            Controls.Add(lbBs1);
            Controls.Add(lbVentaCredito);
            Controls.Add(cbPlazoPago);
            Controls.Add(label8);
            Controls.Add(lbPlazoPago);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(lbTotalPagar);
            Controls.Add(tbTotalPagar);
            Controls.Add(lbPrecioUnitario);
            Controls.Add(tbPrecioUnitario);
            Controls.Add(lbCantidad);
            Controls.Add(tbCantidad);
            Controls.Add(lbNombreProducto);
            Controls.Add(tbNombreProducto);
            Controls.Add(lbFechaHora);
            Controls.Add(btX2);
            MaximumSize = new Size(607, 549);
            MinimumSize = new Size(607, 549);
            Name = "Form3";
            Text = "Venta Crédito";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btX2;
        private Label lbFechaHora;
        private Label lbNombreProducto;
        private TextBox tbNombreProducto;
        private Label lbCantidad;
        private TextBox tbCantidad;
        private Label lbPrecioUnitario;
        private TextBox tbPrecioUnitario;
        private Label lbTotalPagar;
        private TextBox tbTotalPagar;
        private Button button1;
        private PictureBox pictureBox1;
        private Label lbPlazoPago;
        private Label label8;
        private ComboBox cbPlazoPago;
        private Label lbVentaCredito;
        private Label lbBs1;
        private Label lbBs2;
        private Label lbBsTotal;
        private Label label1;
        private Label lbMeses;
        private Label label2;
        private Label label3;
        private Label lbIdCliente;
        private TextBox textBox1;
    }
}