﻿namespace Control_de_inventario
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
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(160, 88);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 173);
            label2.Name = "label2";
            label2.Size = new Size(132, 20);
            label2.TabIndex = 1;
            label2.Text = "Correo electronico";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(150, 132);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 2;
            label3.Text = "Domicilio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GradientActiveCaption;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(264, 31);
            label4.Name = "label4";
            label4.Size = new Size(281, 28);
            label4.TabIndex = 3;
            label4.Text = "Información del proveedor";
            label4.Click += label4_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(245, 85);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(265, 27);
            txtNombre.TabIndex = 4;
            // 
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(245, 129);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(265, 27);
            txtDomicilio.TabIndex = 5;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(245, 173);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(265, 27);
            txtCorreo.TabIndex = 6;
            txtCorreo.TextChanged += textBox3_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(634, 362);
            button1.Name = "button1";
            button1.Size = new Size(81, 50);
            button1.TabIndex = 7;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGray;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button2.Location = new Point(321, 253);
            button2.Name = "button2";
            button2.Size = new Size(104, 45);
            button2.TabIndex = 8;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = false;
            // 
            // fomularioProvedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtCorreo);
            Controls.Add(txtDomicilio);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fomularioProvedor";
            Text = "fomularioProvedor";
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
    }
}