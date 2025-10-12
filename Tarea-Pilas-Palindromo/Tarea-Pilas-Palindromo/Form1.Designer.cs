namespace Tarea_Pilas_Palindromo
{
    partial class Form1
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
            btnVerificar = new Button();
            lblPalabra = new Label();
            txtPalabra = new TextBox();
            SuspendLayout();
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(129, 229);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(94, 48);
            btnVerificar.TabIndex = 6;
            btnVerificar.Text = "&Verificar palabra";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // lblPalabra
            // 
            lblPalabra.AutoSize = true;
            lblPalabra.Location = new Point(49, 94);
            lblPalabra.Name = "lblPalabra";
            lblPalabra.Size = new Size(120, 20);
            lblPalabra.TabIndex = 8;
            lblPalabra.Text = "Ingresar palabra:";
            // 
            // txtPalabra
            // 
            txtPalabra.Location = new Point(175, 91);
            txtPalabra.Name = "txtPalabra";
            txtPalabra.Size = new Size(167, 27);
            txtPalabra.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 336);
            Controls.Add(lblPalabra);
            Controls.Add(txtPalabra);
            Controls.Add(btnVerificar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVerificar;
        private Label lblPalabra;
        private TextBox txtPalabra;
    }
}
