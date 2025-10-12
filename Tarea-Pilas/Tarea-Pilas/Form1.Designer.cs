namespace Tarea_Pilas
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
            txtTexto = new TextBox();
            label1 = new Label();
            btnVerificar = new Button();
            SuspendLayout();
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(147, 85);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(167, 27);
            txtTexto.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 88);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 3;
            label1.Text = "Ingresar texto:";
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(137, 177);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(94, 48);
            btnVerificar.TabIndex = 4;
            btnVerificar.Text = "&Verificar texto";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 281);
            Controls.Add(btnVerificar);
            Controls.Add(label1);
            Controls.Add(txtTexto);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTexto;
        private Label label1;
        private Button btnVerificar;
    }
}
