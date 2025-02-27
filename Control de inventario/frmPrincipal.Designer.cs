namespace Control_de_inventario
{
    partial class frmPrincipal
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
            label1 = new Label();
            btnVendedor = new Button();
            button1 = new Button();
            btnProbedor = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(355, 37);
            label1.Name = "label1";
            label1.Size = new Size(319, 41);
            label1.TabIndex = 2;
            label1.Text = "Control de inventario";
            label1.Click += label1_Click;
            // 
            // btnVendedor
            // 
            btnVendedor.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVendedor.Location = new Point(566, 353);
            btnVendedor.Name = "btnVendedor";
            btnVendedor.Size = new Size(185, 81);
            btnVendedor.TabIndex = 3;
            btnVendedor.Text = "Informacion del vendedor";
            btnVendedor.UseVisualStyleBackColor = true;
            btnVendedor.Click += btnVendedor_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(828, 353);
            button1.Name = "button1";
            button1.Size = new Size(164, 75);
            button1.TabIndex = 4;
            button1.Text = "Cerrar la apliacacion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnProbedor
            // 
            btnProbedor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProbedor.Location = new Point(171, 124);
            btnProbedor.Name = "btnProbedor";
            btnProbedor.Size = new Size(197, 79);
            btnProbedor.TabIndex = 5;
            btnProbedor.Text = "Informacion del Proveedor";
            btnProbedor.UseVisualStyleBackColor = true;
            btnProbedor.Click += btnProbedor_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(171, 347);
            button2.Name = "button2";
            button2.Size = new Size(197, 75);
            button2.TabIndex = 6;
            button2.Text = "Informacion del producto\r\n";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(566, 124);
            button3.Name = "button3";
            button3.Size = new Size(185, 79);
            button3.TabIndex = 7;
            button3.Text = "Metodo de pago";
            button3.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 545);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnProbedor);
            Controls.Add(button1);
            Controls.Add(btnVendedor);
            Controls.Add(label1);
            Name = "frmPrincipal";
            Text = "Formulario principal";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnVendedor;
        private Button button1;
        private Button btnProbedor;
        private Button button2;
        private Button button3;
    }
}
