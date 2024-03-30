namespace Fermeci
{
    partial class FormPropietario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPropietario));
            pSubMenu = new Panel();
            btHistorialVentas = new Button();
            btGenerarPedido = new Button();
            btDarBaja = new Button();
            ObtenerReporte = new Button();
            pSubMenuRegistrar = new Panel();
            btRegistrarProveedor = new Button();
            btRegistrarEmpleado = new Button();
            btRegistrarEmpleadoProveedor = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            pContenedor = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            pSubMenu.SuspendLayout();
            pSubMenuRegistrar.SuspendLayout();
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
            pSubMenu.Controls.Add(btGenerarPedido);
            pSubMenu.Controls.Add(btDarBaja);
            pSubMenu.Controls.Add(ObtenerReporte);
            pSubMenu.Controls.Add(pSubMenuRegistrar);
            pSubMenu.Controls.Add(btRegistrarEmpleadoProveedor);
            pSubMenu.Controls.Add(panel2);
            pSubMenu.Dock = DockStyle.Left;
            pSubMenu.Location = new Point(0, 0);
            pSubMenu.Name = "pSubMenu";
            pSubMenu.Size = new Size(209, 578);
            pSubMenu.TabIndex = 0;
            // 
            // btHistorialVentas
            // 
            btHistorialVentas.Dock = DockStyle.Top;
            btHistorialVentas.FlatAppearance.BorderSize = 0;
            btHistorialVentas.FlatStyle = FlatStyle.Flat;
            btHistorialVentas.ForeColor = Color.WhiteSmoke;
            btHistorialVentas.Location = new Point(0, 479);
            btHistorialVentas.Name = "btHistorialVentas";
            btHistorialVentas.Size = new Size(209, 58);
            btHistorialVentas.TabIndex = 5;
            btHistorialVentas.Text = "Historial de Ventas";
            btHistorialVentas.UseVisualStyleBackColor = true;
            btHistorialVentas.Click += btHistorialVentas_Click;
            // 
            // btGenerarPedido
            // 
            btGenerarPedido.Dock = DockStyle.Top;
            btGenerarPedido.FlatAppearance.BorderSize = 0;
            btGenerarPedido.FlatStyle = FlatStyle.Flat;
            btGenerarPedido.ForeColor = Color.WhiteSmoke;
            btGenerarPedido.Location = new Point(0, 421);
            btGenerarPedido.Name = "btGenerarPedido";
            btGenerarPedido.Size = new Size(209, 58);
            btGenerarPedido.TabIndex = 4;
            btGenerarPedido.Text = "Pedir Mercancia";
            btGenerarPedido.UseVisualStyleBackColor = true;
            btGenerarPedido.Click += btGenerarPedido_Click;
            // 
            // btDarBaja
            // 
            btDarBaja.Dock = DockStyle.Top;
            btDarBaja.FlatAppearance.BorderSize = 0;
            btDarBaja.FlatStyle = FlatStyle.Flat;
            btDarBaja.ForeColor = Color.WhiteSmoke;
            btDarBaja.Location = new Point(0, 363);
            btDarBaja.Name = "btDarBaja";
            btDarBaja.Size = new Size(209, 58);
            btDarBaja.TabIndex = 3;
            btDarBaja.Text = "Despedir/Eliminar\r\nEmpleado";
            btDarBaja.UseVisualStyleBackColor = true;
            btDarBaja.Click += btDarBaja_Click;
            // 
            // ObtenerReporte
            // 
            ObtenerReporte.Dock = DockStyle.Top;
            ObtenerReporte.FlatAppearance.BorderSize = 0;
            ObtenerReporte.FlatStyle = FlatStyle.Flat;
            ObtenerReporte.ForeColor = Color.WhiteSmoke;
            ObtenerReporte.Location = new Point(0, 305);
            ObtenerReporte.Name = "ObtenerReporte";
            ObtenerReporte.Size = new Size(209, 58);
            ObtenerReporte.TabIndex = 2;
            ObtenerReporte.Text = "Obtener Reporte";
            ObtenerReporte.UseVisualStyleBackColor = true;
            ObtenerReporte.Click += ObtenerReporte_Click;
            // 
            // pSubMenuRegistrar
            // 
            pSubMenuRegistrar.BackColor = Color.FromArgb(78, 118, 94);
            pSubMenuRegistrar.Controls.Add(btRegistrarProveedor);
            pSubMenuRegistrar.Controls.Add(btRegistrarEmpleado);
            pSubMenuRegistrar.Dock = DockStyle.Top;
            pSubMenuRegistrar.Location = new Point(0, 171);
            pSubMenuRegistrar.Name = "pSubMenuRegistrar";
            pSubMenuRegistrar.Size = new Size(209, 134);
            pSubMenuRegistrar.TabIndex = 1;
            // 
            // btRegistrarProveedor
            // 
            btRegistrarProveedor.Dock = DockStyle.Top;
            btRegistrarProveedor.FlatAppearance.BorderSize = 0;
            btRegistrarProveedor.FlatStyle = FlatStyle.Flat;
            btRegistrarProveedor.ForeColor = Color.WhiteSmoke;
            btRegistrarProveedor.Location = new Point(0, 58);
            btRegistrarProveedor.Name = "btRegistrarProveedor";
            btRegistrarProveedor.Size = new Size(209, 58);
            btRegistrarProveedor.TabIndex = 2;
            btRegistrarProveedor.Text = "Registrar Proveedor";
            btRegistrarProveedor.UseVisualStyleBackColor = true;
            btRegistrarProveedor.Click += btRegistrarProveedor_Click;
            // 
            // btRegistrarEmpleado
            // 
            btRegistrarEmpleado.Dock = DockStyle.Top;
            btRegistrarEmpleado.FlatAppearance.BorderSize = 0;
            btRegistrarEmpleado.FlatStyle = FlatStyle.Flat;
            btRegistrarEmpleado.ForeColor = Color.WhiteSmoke;
            btRegistrarEmpleado.Location = new Point(0, 0);
            btRegistrarEmpleado.Name = "btRegistrarEmpleado";
            btRegistrarEmpleado.Size = new Size(209, 58);
            btRegistrarEmpleado.TabIndex = 1;
            btRegistrarEmpleado.Text = "Registrar Empleado";
            btRegistrarEmpleado.UseVisualStyleBackColor = true;
            btRegistrarEmpleado.Click += btRegistrarEmpleado_Click;
            // 
            // btRegistrarEmpleadoProveedor
            // 
            btRegistrarEmpleadoProveedor.Dock = DockStyle.Top;
            btRegistrarEmpleadoProveedor.FlatAppearance.BorderSize = 0;
            btRegistrarEmpleadoProveedor.FlatStyle = FlatStyle.Flat;
            btRegistrarEmpleadoProveedor.ForeColor = Color.WhiteSmoke;
            btRegistrarEmpleadoProveedor.Location = new Point(0, 113);
            btRegistrarEmpleadoProveedor.Name = "btRegistrarEmpleadoProveedor";
            btRegistrarEmpleadoProveedor.Size = new Size(209, 58);
            btRegistrarEmpleadoProveedor.TabIndex = 0;
            btRegistrarEmpleadoProveedor.Text = "Registrar";
            btRegistrarEmpleadoProveedor.UseVisualStyleBackColor = true;
            btRegistrarEmpleadoProveedor.Click += btRegistrarEmpleadoProveedor_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(209, 113);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(209, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pContenedor
            // 
            pContenedor.Controls.Add(label1);
            pContenedor.Controls.Add(pictureBox2);
            pContenedor.Dock = DockStyle.Fill;
            pContenedor.Location = new Point(209, 0);
            pContenedor.Name = "pContenedor";
            pContenedor.Size = new Size(591, 578);
            pContenedor.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(487, 550);
            label1.Name = "label1";
            label1.Size = new Size(92, 19);
            label1.TabIndex = 9;
            label1.Text = "JEELM©2024";
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(591, 578);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(354, 280);
            label2.Name = "label2";
            label2.Size = new Size(0, 19);
            label2.TabIndex = 9;
            // 
            // FormPropietario
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 578);
            Controls.Add(label2);
            Controls.Add(pContenedor);
            Controls.Add(pSubMenu);
            Font = new Font("Segoe UI", 10F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormPropietario";
            Text = "Menú Propietario";
            Load += FormPropietario_Load;
            pSubMenu.ResumeLayout(false);
            pSubMenuRegistrar.ResumeLayout(false);
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
        private Button btRegistrarEmpleadoProveedor;
        private Panel panel2;
        private Panel pSubMenuRegistrar;
        private Button btRegistrarEmpleado;
        private Button ObtenerReporte;
        private Button btRegistrarProveedor;
        private PictureBox pictureBox1;
        private Button btGenerarPedido;
        private Button btDarBaja;
        private Button btHistorialVentas;
        private Panel pContenedor;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label1;
    }
}