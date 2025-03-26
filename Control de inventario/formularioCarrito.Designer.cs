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
            label6 = new Label();
            btnBuscar = new Button();
            txtTotal = new TextBox();
            btnSalir = new Button();
            dataGridView1 = new DataGridView();
            txtBusquedaProducto = new TextBox();
            button1 = new Button();
            label3 = new Label();
            comboBox1 = new ComboBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Cyan;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(444, 21);
            label1.Name = "label1";
            label1.Size = new Size(186, 33);
            label1.TabIndex = 0;
            label1.Text = "Inventario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 88);
            label2.Name = "label2";
            label2.Size = new Size(229, 28);
            label2.TabIndex = 4;
            label2.Text = "Buscar Productos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            label6.Location = new Point(40, 191);
            label6.Name = "label6";
            label6.Size = new Size(89, 23);
            label6.TabIndex = 8;
            label6.Text = "Cantidad";
            label6.Click += label6_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DarkGray;
            btnBuscar.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(410, 130);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(248, 34);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Mostrar Productos";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += button2_Click;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(153, 187);
            txtTotal.Margin = new Padding(3, 2, 3, 2);
            txtTotal.Multiline = true;
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(168, 27);
            txtTotal.TabIndex = 10;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Red;
            btnSalir.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(1002, 455);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(99, 31);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(53, 233);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(883, 253);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // txtBusquedaProducto
            // 
            txtBusquedaProducto.Location = new Point(292, 79);
            txtBusquedaProducto.Margin = new Padding(3, 2, 3, 2);
            txtBusquedaProducto.Multiline = true;
            txtBusquedaProducto.Name = "txtBusquedaProducto";
            txtBusquedaProducto.Size = new Size(673, 38);
            txtBusquedaProducto.TabIndex = 15;
            // 
            // button1
            // 
            button1.BackColor = Color.Chartreuse;
            button1.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(976, 233);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(99, 31);
            button1.TabIndex = 17;
            button1.Text = "Vender";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            label3.Location = new Point(382, 191);
            label3.Name = "label3";
            label3.Size = new Size(153, 23);
            label3.TabIndex = 18;
            label3.Text = "Metodo de Pago";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(556, 194);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(225, 23);
            comboBox1.TabIndex = 19;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGray;
            button2.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(968, 286);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(133, 56);
            button2.TabIndex = 20;
            button2.Text = "Mostrar Ventas";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // formularioCarrito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1161, 506);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(txtBusquedaProducto);
            Controls.Add(dataGridView1);
            Controls.Add(btnSalir);
            Controls.Add(txtTotal);
            Controls.Add(btnBuscar);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "formularioCarrito";
            Text = "formularioCarrito";
            Load += formularioCarrito_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label6;
        private Button btnBuscar;
        private TextBox txtTotal;
        private Button btnSalir;
        private DataGridView dataGridView1;
        private TextBox txtBusquedaProducto;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label3;
        private ComboBox comboBox1;
        private Button button2;
    }
}