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
            label1.Font = new Font("Bookman Old Style", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(273, 50);
            label1.Name = "label1";
            label1.Size = new Size(467, 47);
            label1.TabIndex = 2;
            label1.Text = "Control de inventario";
            label1.Click += label1_Click;
            // 
            // btnVendedor
            // 
            btnVendedor.BackColor = Color.LightCyan;
            btnVendedor.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnVendedor.Location = new Point(140, 335);
            btnVendedor.Name = "btnVendedor";
            btnVendedor.Size = new Size(325, 75);
            btnVendedor.TabIndex = 3;
            btnVendedor.Text = "Información del Vendedor";
            btnVendedor.UseVisualStyleBackColor = false;
            btnVendedor.Click += btnVendedor_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Cornsilk;
            button1.Location = new Point(912, 467);
            button1.Name = "button1";
            button1.Size = new Size(81, 44);
            button1.TabIndex = 4;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnProbedor
            // 
            btnProbedor.BackColor = Color.LightCyan;
            btnProbedor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProbedor.Location = new Point(140, 169);
            btnProbedor.Name = "btnProbedor";
            btnProbedor.Size = new Size(327, 79);
            btnProbedor.TabIndex = 5;
            btnProbedor.Text = "Información del Proveedor";
            btnProbedor.UseVisualStyleBackColor = false;
            btnProbedor.Click += btnProbedor_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightCyan;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(546, 173);
            button2.Name = "button2";
            button2.Size = new Size(317, 75);
            button2.TabIndex = 6;
            button2.Text = "Información del Producto";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientInactiveCaption;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(546, 335);
            button3.Name = "button3";
            button3.Size = new Size(317, 79);
            button3.TabIndex = 7;
            button3.Text = "Método de Pago";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1023, 523);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnProbedor);
            Controls.Add(button1);
            Controls.Add(btnVendedor);
            Controls.Add(label1);
            Name = "frmPrincipal";
            Text = "Formulario principal";
            
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
