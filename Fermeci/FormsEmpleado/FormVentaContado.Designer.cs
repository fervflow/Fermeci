namespace Fermeci
{
    partial class FormVentaContado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVentaContado));
            btX = new Button();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
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
            lbBs1 = new Label();
            lbBs2 = new Label();
            lbBsTotal = new Label();
            label2 = new Label();
            lbIdCliente = new Label();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            btX.TabIndex = 1;
            btX.Text = "X";
            btX.UseVisualStyleBackColor = false;
            btX.Click += btX_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(68, 108, 84);
            label1.Location = new Point(229, 12);
            label1.Name = "label1";
            label1.Size = new Size(165, 25);
            label1.TabIndex = 2;
            label1.Text = "Venta al Contado";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 368);
            panel1.Name = "panel1";
            panel1.Size = new Size(153, 130);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbFechaHora
            // 
            lbFechaHora.AutoSize = true;
            lbFechaHora.Font = new Font("Segoe UI", 12F);
            lbFechaHora.Location = new Point(87, 105);
            lbFechaHora.Name = "lbFechaHora";
            lbFechaHora.Size = new Size(50, 21);
            lbFechaHora.TabIndex = 5;
            lbFechaHora.Text = "Fecha";
            // 
            // lbNombreProducto
            // 
            lbNombreProducto.AutoSize = true;
            lbNombreProducto.Font = new Font("Segoe UI", 12F);
            lbNombreProducto.Location = new Point(56, 194);
            lbNombreProducto.Name = "lbNombreProducto";
            lbNombreProducto.Size = new Size(163, 21);
            lbNombreProducto.TabIndex = 9;
            lbNombreProducto.Text = "Nombre del Producto:";
            // 
            // tbNombreProducto
            // 
            tbNombreProducto.Location = new Point(247, 194);
            tbNombreProducto.Name = "tbNombreProducto";
            tbNombreProducto.Size = new Size(239, 23);
            tbNombreProducto.TabIndex = 8;
            // 
            // lbCantidad
            // 
            lbCantidad.AutoSize = true;
            lbCantidad.Font = new Font("Segoe UI", 12F);
            lbCantidad.Location = new Point(141, 242);
            lbCantidad.Name = "lbCantidad";
            lbCantidad.Size = new Size(75, 21);
            lbCantidad.TabIndex = 11;
            lbCantidad.Text = "Cantidad:";
            // 
            // tbCantidad
            // 
            tbCantidad.Location = new Point(247, 240);
            tbCantidad.Name = "tbCantidad";
            tbCantidad.Size = new Size(199, 23);
            tbCantidad.TabIndex = 10;
            tbCantidad.TextChanged += tbCantidad_TextChanged;
            // 
            // lbPrecioUnitario
            // 
            lbPrecioUnitario.AutoSize = true;
            lbPrecioUnitario.Font = new Font("Segoe UI", 12F);
            lbPrecioUnitario.Location = new Point(103, 290);
            lbPrecioUnitario.Name = "lbPrecioUnitario";
            lbPrecioUnitario.Size = new Size(116, 21);
            lbPrecioUnitario.TabIndex = 13;
            lbPrecioUnitario.Text = "Precio Unitario:";
            // 
            // tbPrecioUnitario
            // 
            tbPrecioUnitario.Location = new Point(247, 288);
            tbPrecioUnitario.Name = "tbPrecioUnitario";
            tbPrecioUnitario.Size = new Size(199, 23);
            tbPrecioUnitario.TabIndex = 12;
            tbPrecioUnitario.TextChanged += tbPrecioUnitario_TextChanged;
            // 
            // lbTotalPagar
            // 
            lbTotalPagar.AutoSize = true;
            lbTotalPagar.Font = new Font("Segoe UI", 12F);
            lbTotalPagar.Location = new Point(209, 429);
            lbTotalPagar.Name = "lbTotalPagar";
            lbTotalPagar.Size = new Size(100, 21);
            lbTotalPagar.TabIndex = 15;
            lbTotalPagar.Text = "Total a Pagar:";
            // 
            // tbTotalPagar
            // 
            tbTotalPagar.Location = new Point(324, 427);
            tbTotalPagar.Name = "tbTotalPagar";
            tbTotalPagar.Size = new Size(200, 23);
            tbTotalPagar.TabIndex = 14;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(68, 108, 84);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(499, 472);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 16;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = false;
            // 
            // lbBs1
            // 
            lbBs1.AutoSize = true;
            lbBs1.Font = new Font("Segoe UI", 12F);
            lbBs1.Location = new Point(452, 242);
            lbBs1.Name = "lbBs1";
            lbBs1.Size = new Size(29, 21);
            lbBs1.TabIndex = 17;
            lbBs1.Text = "Bs.";
            // 
            // lbBs2
            // 
            lbBs2.AutoSize = true;
            lbBs2.Font = new Font("Segoe UI", 12F);
            lbBs2.Location = new Point(452, 290);
            lbBs2.Name = "lbBs2";
            lbBs2.Size = new Size(29, 21);
            lbBs2.TabIndex = 18;
            lbBs2.Text = "Bs.";
            // 
            // lbBsTotal
            // 
            lbBsTotal.AutoSize = true;
            lbBsTotal.Font = new Font("Segoe UI", 12F);
            lbBsTotal.Location = new Point(530, 429);
            lbBsTotal.Name = "lbBsTotal";
            lbBsTotal.Size = new Size(29, 21);
            lbBsTotal.TabIndex = 19;
            lbBsTotal.Text = "Bs.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(484, 9);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 20;
            label2.Text = "JEELM©2024";
            // 
            // lbIdCliente
            // 
            lbIdCliente.AutoSize = true;
            lbIdCliente.Font = new Font("Segoe UI", 12F);
            lbIdCliente.Location = new Point(141, 148);
            lbIdCliente.Name = "lbIdCliente";
            lbIdCliente.Size = new Size(78, 21);
            lbIdCliente.TabIndex = 35;
            lbIdCliente.Text = "Id Cliente:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(247, 146);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(239, 23);
            textBox1.TabIndex = 34;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 510);
            Controls.Add(lbIdCliente);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(lbBsTotal);
            Controls.Add(lbBs2);
            Controls.Add(lbBs1);
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
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(btX);
            Name = "Form2";
            Text = "Venta Contado";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btX;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
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
        private Label lbBs1;
        private Label lbBs2;
        private Label lbBsTotal;
        private Label label2;
        private Label lbIdCliente;
        private TextBox textBox1;
    }
}