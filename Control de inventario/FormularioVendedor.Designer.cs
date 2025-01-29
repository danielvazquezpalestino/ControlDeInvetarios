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
            btnMostar = new Button();
            btnSalir = new Button();
            txtDomicilio = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(175, 55);
            lblID.Name = "lblID";
            lblID.Size = new Size(24, 20);
            lblID.TabIndex = 0;
            lblID.Text = "ID";
            lblID.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(135, 88);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 119);
            label3.Name = "label3";
            label3.Size = new Size(144, 20);
            label3.TabIndex = 2;
            label3.Text = "Numero de telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 158);
            label4.Name = "label4";
            label4.Size = new Size(140, 20);
            label4.TabIndex = 3;
            label4.Text = "Correo electreonico";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 188);
            label5.Name = "label5";
            label5.Size = new Size(175, 20);
            label5.TabIndex = 4;
            label5.Text = "Numero de seguro social";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Info;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(238, 9);
            label1.Name = "label1";
            label1.Size = new Size(274, 28);
            label1.TabIndex = 5;
            label1.Text = "Ingrese los siguientes datos";
            // 
            // txtID
            // 
            txtID.Location = new Point(234, 52);
            txtID.Name = "txtID";
            txtID.Size = new Size(175, 27);
            txtID.TabIndex = 6;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(234, 85);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(175, 27);
            txtNombre.TabIndex = 7;
            // 
            // txtNumeroTelefono
            // 
            txtNumeroTelefono.Location = new Point(236, 116);
            txtNumeroTelefono.Name = "txtNumeroTelefono";
            txtNumeroTelefono.Size = new Size(173, 27);
            txtNumeroTelefono.TabIndex = 8;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(234, 155);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(173, 27);
            txtCorreo.TabIndex = 9;
            // 
            // txtSeguroSocial
            // 
            txtSeguroSocial.Location = new Point(236, 185);
            txtSeguroSocial.Name = "txtSeguroSocial";
            txtSeguroSocial.Size = new Size(173, 27);
            txtSeguroSocial.TabIndex = 10;
            // 
            // btGuardar
            // 
            btGuardar.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btGuardar.Location = new Point(157, 310);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(94, 29);
            btGuardar.TabIndex = 11;
            btGuardar.Text = "Guardar";
            btGuardar.UseVisualStyleBackColor = true;
            btGuardar.Click += btGuardar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(292, 309);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 29);
            btnActualizar.TabIndex = 12;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(549, 310);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnMostar
            // 
            btnMostar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostar.Location = new Point(418, 309);
            btnMostar.Name = "btnMostar";
            btnMostar.Size = new Size(94, 29);
            btnMostar.TabIndex = 14;
            btnMostar.Text = "Mostar";
            btnMostar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(606, 225);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += button1_Click;
            // 
            // txtDomicilio
            // 
            txtDomicilio.AutoSize = true;
            txtDomicilio.Location = new Point(75, 243);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(74, 20);
            txtDomicilio.TabIndex = 16;
            txtDomicilio.Text = "Domicilio";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(235, 240);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 27);
            textBox1.TabIndex = 17;
            // 
            // FormularioVendedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(txtDomicilio);
            Controls.Add(btnSalir);
            Controls.Add(btnMostar);
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
            Name = "FormularioVendedor";
            Text = "Formulario del Vendedor";
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
        private Button btnMostar;
        private Button btnSalir;
        private Label txtDomicilio;
        private TextBox textBox1;
    }
}