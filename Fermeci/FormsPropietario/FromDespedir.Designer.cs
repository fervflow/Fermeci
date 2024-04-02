namespace Fermeci
{
    partial class FromDespedir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromDespedir));
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            tbCI = new TextBox();
            btDespedir = new Button();
            pictureBox1 = new PictureBox();
            btX = new Button();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            dtgEmpleados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgEmpleados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(68, 108, 84);
            label1.Location = new Point(258, 25);
            label1.Name = "label1";
            label1.Size = new Size(163, 20);
            label1.TabIndex = 0;
            label1.Text = "DESPEDIR EMPLEADO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(68, 108, 84);
            label2.Location = new Point(112, 63);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 2;
            label2.Text = "Datos del empleado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 9.75F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(68, 108, 84);
            label4.Location = new Point(112, 116);
            label4.Name = "label4";
            label4.Size = new Size(112, 15);
            label4.TabIndex = 4;
            label4.Text = "Célula de Identidad";
            // 
            // tbCI
            // 
            tbCI.Location = new Point(239, 113);
            tbCI.Name = "tbCI";
            tbCI.Size = new Size(231, 23);
            tbCI.TabIndex = 5;
            tbCI.TextChanged += tbCI_TextChanged;
            // 
            // btDespedir
            // 
            btDespedir.BackColor = Color.FromArgb(68, 108, 84);
            btDespedir.FlatAppearance.BorderSize = 0;
            btDespedir.FlatStyle = FlatStyle.Flat;
            btDespedir.ForeColor = Color.White;
            btDespedir.Location = new Point(299, 157);
            btDespedir.Name = "btDespedir";
            btDespedir.Size = new Size(99, 34);
            btDespedir.TabIndex = 6;
            btDespedir.Text = "DESPEDIR";
            btDespedir.UseVisualStyleBackColor = false;
            btDespedir.Click += btDespedir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btX
            // 
            btX.BackColor = Color.FromArgb(68, 108, 84);
            btX.FlatAppearance.BorderSize = 0;
            btX.FlatStyle = FlatStyle.Flat;
            btX.ForeColor = Color.White;
            btX.Location = new Point(12, 9);
            btX.Name = "btX";
            btX.Size = new Size(40, 31);
            btX.TabIndex = 8;
            btX.Text = "X";
            btX.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(517, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 47);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlDark;
            label3.Location = new Point(504, 9);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 10;
            label3.Text = "JEELM©2024";
            // 
            // dtgEmpleados
            // 
            dtgEmpleados.BackgroundColor = Color.FromArgb(68, 108, 84);
            dtgEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgEmpleados.Location = new Point(12, 217);
            dtgEmpleados.Name = "dtgEmpleados";
            dtgEmpleados.ReadOnly = true;
            dtgEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgEmpleados.Size = new Size(567, 212);
            dtgEmpleados.TabIndex = 11;
            dtgEmpleados.CellContentClick += dtgEmpleados_CellContentClick;
            // 
            // FromDespedir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 510);
            Controls.Add(dtgEmpleados);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(btX);
            Controls.Add(pictureBox1);
            Controls.Add(btDespedir);
            Controls.Add(tbCI);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FromDespedir";
            Text = "FERMECI-Despedir";
            Load += FromDespedir_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox tbCI;
        private Button btDespedir;
        private PictureBox pictureBox1;
        private Button btX;
        private PictureBox pictureBox2;
        private Label label3;
        private DataGridView dtgEmpleados;
    }
}
