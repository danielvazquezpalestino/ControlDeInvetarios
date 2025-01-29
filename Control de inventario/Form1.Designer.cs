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
            btnVendedor.Location = new Point(63, 120);
            btnVendedor.Name = "btnVendedor";
            btnVendedor.Size = new Size(197, 92);
            btnVendedor.TabIndex = 3;
            btnVendedor.Text = "Informacion del vendedor";
            btnVendedor.UseVisualStyleBackColor = true;
            btnVendedor.Click += btnVendedor_Click;
            // 
            // button1
            // 
            button1.Location = new Point(888, 392);
            button1.Name = "button1";
            button1.Size = new Size(112, 80);
            button1.TabIndex = 4;
            button1.Text = "Cerrar la apliacacion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnProbedor
            // 
            btnProbedor.Location = new Point(63, 312);
            btnProbedor.Name = "btnProbedor";
            btnProbedor.Size = new Size(197, 79);
            btnProbedor.TabIndex = 5;
            btnProbedor.Text = "Informacion del Provedor";
            btnProbedor.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 545);
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
    }
}
