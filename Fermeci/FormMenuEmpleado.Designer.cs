namespace Fermeci
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pSubMenu = new Panel();
            btHistorialVentas = new Button();
            btRegistrarProveedor = new Button();
            btBuscarProducto = new Button();
            btRegistrarProducto = new Button();
            pSubMenuRealizarVenta = new Panel();
            btCredito = new Button();
            btContado = new Button();
            btRealizarVenta = new Button();
            panel2 = new Panel();
            btRegistrarCliente = new Button();
            pictureBox1 = new PictureBox();
            copy = new Label();
            pContenedor = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            labelCopy = new Label();
            pSubMenu.SuspendLayout();
            pSubMenuRealizarVenta.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pSubMenu
            // 
            pSubMenu.AutoScroll = true;
            pSubMenu.BackColor = Color.FromArgb(68, 108, 84);
            pSubMenu.Controls.Add(btHistorialVentas);
            pSubMenu.Controls.Add(btRegistrarProveedor);
            pSubMenu.Controls.Add(btBuscarProducto);
            pSubMenu.Controls.Add(btRegistrarProducto);
            pSubMenu.Controls.Add(pSubMenuRealizarVenta);
            pSubMenu.Controls.Add(btRealizarVenta);
            pSubMenu.Controls.Add(panel2);
            pSubMenu.Dock = DockStyle.Left;
            pSubMenu.Location = new Point(0, 0);
            pSubMenu.Name = "pSubMenu";
            pSubMenu.Size = new Size(209, 510);
            pSubMenu.TabIndex = 0;
            // 
            // btHistorialVentas
            // 
            btHistorialVentas.Dock = DockStyle.Top;
            btHistorialVentas.FlatAppearance.BorderSize = 0;
            btHistorialVentas.FlatStyle = FlatStyle.Flat;
            btHistorialVentas.ForeColor = SystemColors.ControlLightLight;
            btHistorialVentas.Location = new Point(0, 474);
            btHistorialVentas.Name = "btHistorialVentas";
            btHistorialVentas.Padding = new Padding(10, 0, 0, 0);
            btHistorialVentas.Size = new Size(192, 51);
            btHistorialVentas.TabIndex = 6;
            btHistorialVentas.Text = "Historial de Ventas";
            btHistorialVentas.TextAlign = ContentAlignment.MiddleLeft;
            btHistorialVentas.UseVisualStyleBackColor = true;
            btHistorialVentas.Click += btHistorialVentas_Click;
            // 
            // btRegistrarProveedor
            // 
            btRegistrarProveedor.Dock = DockStyle.Top;
            btRegistrarProveedor.FlatAppearance.BorderSize = 0;
            btRegistrarProveedor.FlatStyle = FlatStyle.Flat;
            btRegistrarProveedor.ForeColor = SystemColors.ControlLightLight;
            btRegistrarProveedor.Location = new Point(0, 423);
            btRegistrarProveedor.Name = "btRegistrarProveedor";
            btRegistrarProveedor.Padding = new Padding(10, 0, 0, 0);
            btRegistrarProveedor.Size = new Size(192, 51);
            btRegistrarProveedor.TabIndex = 5;
            btRegistrarProveedor.Text = "Registrar Proveedor";
            btRegistrarProveedor.TextAlign = ContentAlignment.MiddleLeft;
            btRegistrarProveedor.UseVisualStyleBackColor = true;
            btRegistrarProveedor.Click += btRegistrarProveedor_Click;
            // 
            // btBuscarProducto
            // 
            btBuscarProducto.Dock = DockStyle.Top;
            btBuscarProducto.FlatAppearance.BorderSize = 0;
            btBuscarProducto.FlatStyle = FlatStyle.Flat;
            btBuscarProducto.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btBuscarProducto.ForeColor = SystemColors.ControlLightLight;
            btBuscarProducto.ImageAlign = ContentAlignment.MiddleRight;
            btBuscarProducto.Location = new Point(0, 372);
            btBuscarProducto.Name = "btBuscarProducto";
            btBuscarProducto.Padding = new Padding(10, 0, 0, 0);
            btBuscarProducto.Size = new Size(192, 51);
            btBuscarProducto.TabIndex = 4;
            btBuscarProducto.Text = "Buscar Producto";
            btBuscarProducto.TextAlign = ContentAlignment.MiddleLeft;
            btBuscarProducto.UseVisualStyleBackColor = true;
            btBuscarProducto.Click += btBuscarProducto_Click;
            // 
            // btRegistrarProducto
            // 
            btRegistrarProducto.Dock = DockStyle.Top;
            btRegistrarProducto.FlatAppearance.BorderSize = 0;
            btRegistrarProducto.FlatStyle = FlatStyle.Flat;
            btRegistrarProducto.ForeColor = SystemColors.ControlLightLight;
            btRegistrarProducto.Location = new Point(0, 321);
            btRegistrarProducto.Name = "btRegistrarProducto";
            btRegistrarProducto.Padding = new Padding(10, 0, 0, 0);
            btRegistrarProducto.Size = new Size(192, 51);
            btRegistrarProducto.TabIndex = 2;
            btRegistrarProducto.Text = "Registrar Producto";
            btRegistrarProducto.TextAlign = ContentAlignment.MiddleLeft;
            btRegistrarProducto.UseVisualStyleBackColor = true;
            btRegistrarProducto.Click += btRegistrarProducto_Click;
            // 
            // pSubMenuRealizarVenta
            // 
            pSubMenuRealizarVenta.BackColor = Color.FromArgb(78, 118, 94);
            pSubMenuRealizarVenta.Controls.Add(btCredito);
            pSubMenuRealizarVenta.Controls.Add(btContado);
            pSubMenuRealizarVenta.Dock = DockStyle.Top;
            pSubMenuRealizarVenta.Location = new Point(0, 196);
            pSubMenuRealizarVenta.Name = "pSubMenuRealizarVenta";
            pSubMenuRealizarVenta.Size = new Size(192, 125);
            pSubMenuRealizarVenta.TabIndex = 1;
            // 
            // btCredito
            // 
            btCredito.Dock = DockStyle.Top;
            btCredito.FlatAppearance.BorderSize = 0;
            btCredito.FlatStyle = FlatStyle.Flat;
            btCredito.ForeColor = SystemColors.ControlLightLight;
            btCredito.Location = new Point(0, 51);
            btCredito.Name = "btCredito";
            btCredito.Padding = new Padding(35, 0, 0, 0);
            btCredito.Size = new Size(192, 51);
            btCredito.TabIndex = 2;
            btCredito.Text = "Venta Crédito";
            btCredito.TextAlign = ContentAlignment.MiddleLeft;
            btCredito.UseVisualStyleBackColor = true;
            btCredito.Click += btCredito_Click;
            // 
            // btContado
            // 
            btContado.Dock = DockStyle.Top;
            btContado.FlatAppearance.BorderSize = 0;
            btContado.FlatStyle = FlatStyle.Flat;
            btContado.ForeColor = SystemColors.ControlLightLight;
            btContado.Location = new Point(0, 0);
            btContado.Name = "btContado";
            btContado.Padding = new Padding(35, 0, 0, 0);
            btContado.Size = new Size(192, 51);
            btContado.TabIndex = 1;
            btContado.Text = "Venta Contado";
            btContado.TextAlign = ContentAlignment.MiddleLeft;
            btContado.UseVisualStyleBackColor = true;
            btContado.Click += btContado_Click;
            // 
            // btRealizarVenta
            // 
            btRealizarVenta.Dock = DockStyle.Top;
            btRealizarVenta.FlatAppearance.BorderSize = 0;
            btRealizarVenta.FlatStyle = FlatStyle.Flat;
            btRealizarVenta.ForeColor = SystemColors.ControlLightLight;
            btRealizarVenta.Location = new Point(0, 145);
            btRealizarVenta.Name = "btRealizarVenta";
            btRealizarVenta.Padding = new Padding(10, 0, 0, 0);
            btRealizarVenta.Size = new Size(192, 51);
            btRealizarVenta.TabIndex = 0;
            btRealizarVenta.Text = "Realizar Venta";
            btRealizarVenta.TextAlign = ContentAlignment.MiddleLeft;
            btRealizarVenta.UseVisualStyleBackColor = true;
            btRealizarVenta.Click += btRealizarVenta_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btRegistrarCliente);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(192, 145);
            panel2.TabIndex = 0;
            // 
            // btRegistrarCliente
            // 
            btRegistrarCliente.Dock = DockStyle.Top;
            btRegistrarCliente.FlatAppearance.BorderSize = 0;
            btRegistrarCliente.FlatStyle = FlatStyle.Flat;
            btRegistrarCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btRegistrarCliente.ForeColor = SystemColors.ControlLightLight;
            btRegistrarCliente.Location = new Point(0, 95);
            btRegistrarCliente.Name = "btRegistrarCliente";
            btRegistrarCliente.Padding = new Padding(10, 0, 0, 0);
            btRegistrarCliente.Size = new Size(192, 51);
            btRegistrarCliente.TabIndex = 2;
            btRegistrarCliente.Text = "Registrar Cliente";
            btRegistrarCliente.TextAlign = ContentAlignment.MiddleLeft;
            btRegistrarCliente.UseVisualStyleBackColor = true;
            btRegistrarCliente.Click += btRegistrarCliente_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // copy
            // 
            copy.AutoSize = true;
            copy.ForeColor = SystemColors.ControlDarkDark;
            copy.Location = new Point(696, 482);
            copy.Name = "copy";
            copy.Size = new Size(92, 19);
            copy.TabIndex = 1;
            copy.Text = "JEELM©2024";
            // 
            // pContenedor
            // 
            pContenedor.Controls.Add(label2);
            pContenedor.Controls.Add(pictureBox2);
            pContenedor.Controls.Add(labelCopy);
            pContenedor.Dock = DockStyle.Fill;
            pContenedor.Location = new Point(209, 0);
            pContenedor.Name = "pContenedor";
            pContenedor.Size = new Size(591, 510);
            pContenedor.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(496, 482);
            label2.Name = "label2";
            label2.Size = new Size(92, 19);
            label2.TabIndex = 9;
            label2.Text = "JEELM©2024";
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(591, 510);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // labelCopy
            // 
            labelCopy.AutoSize = true;
            labelCopy.ForeColor = SystemColors.ControlDarkDark;
            labelCopy.Location = new Point(487, 477);
            labelCopy.Name = "labelCopy";
            labelCopy.Size = new Size(92, 19);
            labelCopy.TabIndex = 0;
            labelCopy.Text = "JEELM©2024";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(pContenedor);
            Controls.Add(copy);
            Controls.Add(pSubMenu);
            Font = new Font("Segoe UI", 10F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(816, 549);
            MinimumSize = new Size(816, 549);
            Name = "Form1";
            Text = "Menú Empleado";
            Load += Form1_Load;
            pSubMenu.ResumeLayout(false);
            pSubMenuRealizarVenta.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pContenedor.ResumeLayout(false);
            pContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pSubMenu;
        private Panel pSubMenuRealizarVenta;
        private Button btCredito;
        private Button btContado;
        private Button btRealizarVenta;
        private Panel panel2;
        private Button btRegistrarProducto;
        private Button btBuscarProducto;
        private PictureBox pictureBox1;
        private Label copy;
        private Panel pContenedor;
        private Label labelCopy;
        private PictureBox pictureBox2;
        private Button btHistorialVentas;
        private Button btRegistrarProveedor;
        private Button btRegistrarCliente;
        private Label label2;
    }
}
