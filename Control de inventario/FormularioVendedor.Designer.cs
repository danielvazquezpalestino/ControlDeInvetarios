namespace Control_de_inventario
{
    partial class FormularioVendedor
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
            lblID = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label1 = new Label();
            txtID = new TextBox();
            txtNombre = new TextBox();
            txtNumeroTelefono = new TextBox();
            txtCorreo = new TextBox();
            txtSeguroSocial = new TextBox();
            btGuardar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnMostrar = new Button();
            btnSalir = new Button();
            txtDomicilio = new Label();
            textBox1 = new TextBox();
            dataGridViewVendedores = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVendedores).BeginInit();
            SuspendLayout();
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.BackColor = Color.LightCyan;
            lblID.Location = new Point(168, 53);
            lblID.Name = "lblID";
            lblID.Size = new Size(18, 15);
            lblID.TabIndex = 0;
            lblID.Text = "ID";
            lblID.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(133, 78);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 101);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 2;
            label3.Text = "Número de telefono";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 130);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 3;
            label4.Text = "Correo electronico";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 155);
            label5.Name = "label5";
            label5.Size = new Size(139, 15);
            label5.TabIndex = 4;
            label5.Text = "Número de seguro social";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(208, 10);
            label1.Name = "label1";
            label1.Size = new Size(220, 21);
            label1.TabIndex = 5;
            label1.Text = "Ingresa los siguientes datos";
            label1.Click += label1_Click_1;
            // 
            // txtID
            // 
            txtID.Location = new Point(220, 51);
            txtID.Margin = new Padding(3, 2, 3, 2);
            txtID.Name = "txtID";
            txtID.Size = new Size(154, 23);
            txtID.TabIndex = 6;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(220, 76);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(154, 23);
            txtNombre.TabIndex = 7;
            // 
            // txtNumeroTelefono
            // 
            txtNumeroTelefono.Location = new Point(221, 99);
            txtNumeroTelefono.Margin = new Padding(3, 2, 3, 2);
            txtNumeroTelefono.Name = "txtNumeroTelefono";
            txtNumeroTelefono.Size = new Size(152, 23);
            txtNumeroTelefono.TabIndex = 8;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(220, 127);
            txtCorreo.Margin = new Padding(3, 2, 3, 2);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(152, 23);
            txtCorreo.TabIndex = 9;
            // 
            // txtSeguroSocial
            // 
            txtSeguroSocial.Location = new Point(223, 153);
            txtSeguroSocial.Margin = new Padding(3, 2, 3, 2);
            txtSeguroSocial.Name = "txtSeguroSocial";
            txtSeguroSocial.Size = new Size(152, 23);
            txtSeguroSocial.TabIndex = 10;
            // 
            // btGuardar
            // 
            btGuardar.BackColor = SystemColors.GradientActiveCaption;
            btGuardar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btGuardar.Location = new Point(103, 247);
            btGuardar.Margin = new Padding(3, 2, 3, 2);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(94, 33);
            btGuardar.TabIndex = 11;
            btGuardar.Text = "Guardar";
            btGuardar.UseVisualStyleBackColor = false;
            btGuardar.Click += btGuardar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.LightGray;
            btnActualizar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnActualizar.Location = new Point(211, 247);
            btnActualizar.Margin = new Padding(3, 2, 3, 2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(105, 33);
            btnActualizar.TabIndex = 12;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnEliminar.ForeColor = SystemColors.ButtonFace;
            btnEliminar.Location = new Point(438, 247);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(98, 33);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.BackColor = Color.LightGray;
            btnMostrar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnMostrar.Location = new Point(334, 247);
            btnMostrar.Margin = new Padding(3, 2, 3, 2);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(91, 33);
            btnMostrar.TabIndex = 14;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = false;
            btnMostrar.Click += btnMostar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.DarkCyan;
            btnSalir.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.Snow;
            btnSalir.Location = new Point(1032, 268);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(90, 32);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += button1_Click;
            // 
            // txtDomicilio
            // 
            txtDomicilio.AutoSize = true;
            txtDomicilio.Location = new Point(128, 183);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(58, 15);
            txtDomicilio.TabIndex = 16;
            txtDomicilio.Text = "Domicilio";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(222, 180);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(153, 23);
            textBox1.TabIndex = 17;
            // 
            // dataGridViewVendedores
            // 
            dataGridViewVendedores.AllowUserToOrderColumns = true;
            dataGridViewVendedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVendedores.Location = new Point(408, 34);
            dataGridViewVendedores.Name = "dataGridViewVendedores";
            dataGridViewVendedores.Size = new Size(733, 196);
            dataGridViewVendedores.TabIndex = 18;
            // 
            // FormularioVendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 344);
            Controls.Add(dataGridViewVendedores);
            Controls.Add(textBox1);
            Controls.Add(txtDomicilio);
            Controls.Add(btnSalir);
            Controls.Add(btnMostrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btGuardar);
            Controls.Add(txtSeguroSocial);
            Controls.Add(txtCorreo);
            Controls.Add(txtNumeroTelefono);
            Controls.Add(txtNombre);
            Controls.Add(txtID);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblID);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormularioVendedor";
            Text = "Formulario del Vendedor";
            Load += FormularioVendedor_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewVendedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblID;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label1;
        private TextBox txtID;
        private TextBox txtNombre;
        private TextBox txtNumeroTelefono;
        private TextBox txtCorreo;
        private TextBox txtSeguroSocial;
        private Button btGuardar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnMostrar;
        private Button btnSalir;
        private Label txtDomicilio;
        private TextBox textBox1;
        private DataGridView dataGridViewVendedores;
    }
}