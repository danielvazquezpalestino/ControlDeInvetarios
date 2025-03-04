namespace Control_de_inventario
{
    partial class formularioCarrito
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
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnBuscar = new Button();
            txtTotal = new TextBox();
            txtCantidad = new TextBox();
            txtPrecioUnitario = new TextBox();
            btnSalir = new Button();
            dataGridView1 = new DataGridView();
            txtBusquedaProducto = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Cyan;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(508, 28);
            label1.Name = "label1";
            label1.Size = new Size(149, 43);
            label1.TabIndex = 0;
            label1.Text = "Ventas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 118);
            label2.Name = "label2";
            label2.Size = new Size(294, 35);
            label2.TabIndex = 4;
            label2.Text = "Buscar Productos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 255);
            label4.Name = "label4";
            label4.Size = new Size(172, 28);
            label4.TabIndex = 6;
            label4.Text = "Precio unitario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(505, 256);
            label5.Name = "label5";
            label5.Size = new Size(113, 28);
            label5.TabIndex = 7;
            label5.Text = " cantidad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            label6.Location = new Point(1002, 258);
            label6.Name = "label6";
            label6.Size = new Size(67, 28);
            label6.TabIndex = 8;
            label6.Text = "Total";
            label6.Click += label6_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DarkGray;
            btnBuscar.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(468, 173);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(284, 45);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Mostrar Productos";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += button2_Click;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(1078, 255);
            txtTotal.Multiline = true;
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(192, 35);
            txtTotal.TabIndex = 10;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(624, 254);
            txtCantidad.Multiline = true;
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(218, 36);
            txtCantidad.TabIndex = 11;
            txtCantidad.TextChanged += textBox2_TextChanged;
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Location = new Point(203, 254);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Size = new Size(273, 27);
            txtPrecioUnitario.TabIndex = 12;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Red;
            btnSalir.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(1139, 607);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(113, 41);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(61, 311);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(756, 337);
            dataGridView1.TabIndex = 14;
            // 
            // txtBusquedaProducto
            // 
            txtBusquedaProducto.Location = new Point(334, 105);
            txtBusquedaProducto.Multiline = true;
            txtBusquedaProducto.Name = "txtBusquedaProducto";
            txtBusquedaProducto.Size = new Size(769, 49);
            txtBusquedaProducto.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(823, 327);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(310, 297);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // formularioCarrito
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1327, 675);
            Controls.Add(pictureBox1);
            Controls.Add(txtBusquedaProducto);
            Controls.Add(dataGridView1);
            Controls.Add(btnSalir);
            Controls.Add(txtPrecioUnitario);
            Controls.Add(txtCantidad);
            Controls.Add(txtTotal);
            Controls.Add(btnBuscar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formularioCarrito";
            Text = "formularioCarrito";
            Load += formularioCarrito_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnBuscar;
        private TextBox txtTotal;
        private TextBox txtCantidad;
        private TextBox txtPrecioUnitario;
        private Button btnSalir;
        private DataGridView dataGridView1;
        private TextBox txtBusquedaProducto;
        private PictureBox pictureBox1;
    }
}