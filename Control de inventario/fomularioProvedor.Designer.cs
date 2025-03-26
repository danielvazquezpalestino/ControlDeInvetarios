namespace Control_de_inventario
{
    partial class fomularioProvedor
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
            label3 = new Label();
            label4 = new Label();
            txtNombre = new TextBox();
            txtDomicilio = new TextBox();
            txtCorreo = new TextBox();
            button1 = new Button();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnMostrar = new Button();
            txtID = new TextBox();
            dataGridViewProveedores = new DataGridView();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProveedores).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(157, 91);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 155);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 1;
            label2.Text = "Correo electronico";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(148, 124);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Domicilio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GradientActiveCaption;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(231, 23);
            label4.Name = "label4";
            label4.Size = new Size(220, 21);
            label4.TabIndex = 3;
            label4.Text = "Información del proveedor";
            label4.Click += label4_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(231, 89);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(232, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(231, 122);
            txtDomicilio.Margin = new Padding(3, 2, 3, 2);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(232, 23);
            txtDomicilio.TabIndex = 5;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(231, 155);
            txtCorreo.Margin = new Padding(3, 2, 3, 2);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(232, 23);
            txtCorreo.TabIndex = 6;
            txtCorreo.TextChanged += textBox3_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(555, 272);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(71, 38);
            button1.TabIndex = 7;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.LightGray;
            btnAgregar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnAgregar.Location = new Point(12, 202);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(91, 34);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.LightGray;
            btnActualizar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnActualizar.Location = new Point(109, 202);
            btnActualizar.Margin = new Padding(3, 2, 3, 2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(96, 34);
            btnActualizar.TabIndex = 10;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnEliminar.ForeColor = SystemColors.ButtonFace;
            btnEliminar.Location = new Point(329, 202);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(71, 38);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.IndianRed;
            btnLimpiar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLimpiar.ForeColor = SystemColors.ButtonFace;
            btnLimpiar.Location = new Point(419, 202);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(71, 38);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.BackColor = Color.LightGray;
            btnMostrar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnMostrar.Location = new Point(214, 202);
            btnMostrar.Margin = new Padding(3, 2, 3, 2);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(96, 34);
            btnMostrar.TabIndex = 13;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = false;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(231, 62);
            txtID.Margin = new Padding(3, 2, 3, 2);
            txtID.Name = "txtID";
            txtID.Size = new Size(232, 23);
            txtID.TabIndex = 14;
            // 
            // dataGridViewProveedores
            // 
            dataGridViewProveedores.AllowUserToOrderColumns = true;
            dataGridViewProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProveedores.Location = new Point(494, 29);
            dataGridViewProveedores.Name = "dataGridViewProveedores";
            dataGridViewProveedores.Size = new Size(465, 150);
            dataGridViewProveedores.TabIndex = 15;
            dataGridViewProveedores.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(184, 65);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 16;
            label5.Text = "ID";
            // 
            // fomularioProvedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 338);
            Controls.Add(label5);
            Controls.Add(dataGridViewProveedores);
            Controls.Add(txtID);
            Controls.Add(btnMostrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(button1);
            Controls.Add(txtCorreo);
            Controls.Add(txtDomicilio);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "fomularioProvedor";
            Text = "fomularioProvedor";
            Load += fomularioProvedor_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombre;
        private TextBox txtDomicilio;
        private TextBox txtCorreo;
        private Button button1;
        private Button button2;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Button btnMostrar;
        private TextBox txtID;
        private DataGridView dataGridViewProveedores;
        private Label label5;
    }
}