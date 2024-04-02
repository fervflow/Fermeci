namespace Fermeci
{
    partial class FormBuscarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscarProducto));
            tbBuscar = new TextBox();
            btnBuscar = new Button();
            btnX = new Button();
            pictureBox1 = new PictureBox();
            dtgProductos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgProductos).BeginInit();
            SuspendLayout();
            // 
            // tbBuscar
            // 
            tbBuscar.BackColor = Color.Silver;
            tbBuscar.BorderStyle = BorderStyle.None;
            tbBuscar.Font = new Font("Calibri", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            tbBuscar.ForeColor = Color.DimGray;
            tbBuscar.Location = new Point(166, 42);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.Size = new Size(422, 24);
            tbBuscar.TabIndex = 0;
            tbBuscar.Text = "Buscar producto";
            tbBuscar.TextChanged += tbBuscar_TextChanged;
            tbBuscar.Enter += tbBuscar_Enter;
            tbBuscar.Leave += tbBuscar_Leave;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(68, 108, 84);
            btnBuscar.BackgroundImage = (Image)resources.GetObject("btnBuscar.BackgroundImage");
            btnBuscar.BackgroundImageLayout = ImageLayout.Zoom;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Location = new Point(562, 43);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(26, 23);
            btnBuscar.TabIndex = 1;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnX
            // 
            btnX.BackColor = Color.FromArgb(68, 108, 45);
            btnX.BackgroundImageLayout = ImageLayout.Zoom;
            btnX.FlatAppearance.BorderSize = 0;
            btnX.FlatStyle = FlatStyle.Flat;
            btnX.Location = new Point(12, 12);
            btnX.Name = "btnX";
            btnX.Size = new Size(26, 23);
            btnX.TabIndex = 2;
            btnX.Text = "X";
            btnX.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(44, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // dtgProductos
            // 
            dtgProductos.BackgroundColor = Color.FromArgb(68, 108, 84);
            dtgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgProductos.Location = new Point(2, 116);
            dtgProductos.Name = "dtgProductos";
            dtgProductos.ReadOnly = true;
            dtgProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgProductos.Size = new Size(586, 326);
            dtgProductos.TabIndex = 4;
            dtgProductos.CellContentClick += dtgProductos_CellContentClick;
            // 
            // FormBuscarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 510);
            Controls.Add(dtgProductos);
            Controls.Add(pictureBox1);
            Controls.Add(btnX);
            Controls.Add(btnBuscar);
            Controls.Add(tbBuscar);
            Name = "FormBuscarProducto";
            Text = "FERMECI-Buscar Producto";
            Load += FormBuscarProducto_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbBuscar;
        private Button btnBuscar;
        private Button btnX;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private DataGridView dtgProductos;
    }
}