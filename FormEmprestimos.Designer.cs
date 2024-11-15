namespace StoryTales_RN___Trabalho_Final
{
    partial class FormEmprestimos
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
            lblUsuarioEmprestimo = new Label();
            lblLivroEmprestimo = new Label();
            lblDataEmprestimo = new Label();
            cmbUsuarioEmprestimo = new ComboBox();
            cmbLivroEmprestimo = new ComboBox();
            dtpDataEmprestimo = new DateTimePicker();
            btnRegistrarEmprestimo = new Button();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblUsuarioEmprestimo
            // 
            lblUsuarioEmprestimo.AutoSize = true;
            lblUsuarioEmprestimo.Location = new Point(31, 88);
            lblUsuarioEmprestimo.Name = "lblUsuarioEmprestimo";
            lblUsuarioEmprestimo.Size = new Size(62, 20);
            lblUsuarioEmprestimo.TabIndex = 0;
            lblUsuarioEmprestimo.Text = "Usuário:";
            // 
            // lblLivroEmprestimo
            // 
            lblLivroEmprestimo.AutoSize = true;
            lblLivroEmprestimo.Location = new Point(31, 141);
            lblLivroEmprestimo.Name = "lblLivroEmprestimo";
            lblLivroEmprestimo.Size = new Size(44, 20);
            lblLivroEmprestimo.TabIndex = 1;
            lblLivroEmprestimo.Text = "Livro:";
            // 
            // lblDataEmprestimo
            // 
            lblDataEmprestimo.AutoSize = true;
            lblDataEmprestimo.Location = new Point(31, 218);
            lblDataEmprestimo.Name = "lblDataEmprestimo";
            lblDataEmprestimo.Size = new Size(149, 20);
            lblDataEmprestimo.TabIndex = 2;
            lblDataEmprestimo.Text = "Data de Empréstimo:";
            // 
            // cmbUsuarioEmprestimo
            // 
            cmbUsuarioEmprestimo.FormattingEnabled = true;
            cmbUsuarioEmprestimo.Location = new Point(99, 85);
            cmbUsuarioEmprestimo.Name = "cmbUsuarioEmprestimo";
            cmbUsuarioEmprestimo.Size = new Size(234, 28);
            cmbUsuarioEmprestimo.TabIndex = 3;
            // 
            // cmbLivroEmprestimo
            // 
            cmbLivroEmprestimo.FormattingEnabled = true;
            cmbLivroEmprestimo.Location = new Point(81, 138);
            cmbLivroEmprestimo.Name = "cmbLivroEmprestimo";
            cmbLivroEmprestimo.Size = new Size(252, 28);
            cmbLivroEmprestimo.TabIndex = 4;
            // 
            // dtpDataEmprestimo
            // 
            dtpDataEmprestimo.Location = new Point(186, 213);
            dtpDataEmprestimo.Name = "dtpDataEmprestimo";
            dtpDataEmprestimo.Size = new Size(333, 27);
            dtpDataEmprestimo.TabIndex = 5;
            // 
            // btnRegistrarEmprestimo
            // 
            btnRegistrarEmprestimo.Location = new Point(186, 272);
            btnRegistrarEmprestimo.Name = "btnRegistrarEmprestimo";
            btnRegistrarEmprestimo.Size = new Size(176, 52);
            btnRegistrarEmprestimo.TabIndex = 6;
            btnRegistrarEmprestimo.Text = "Registrar Empréstimo";
            btnRegistrarEmprestimo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(209, 24);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 15;
            label2.Text = "StoryTales RN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(170, 372);
            label1.Name = "label1";
            label1.Size = new Size(192, 20);
            label1.TabIndex = 14;
            label1.Text = "Renan Santos - 2222200490";
            // 
            // FormEmprestimos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 401);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRegistrarEmprestimo);
            Controls.Add(dtpDataEmprestimo);
            Controls.Add(cmbLivroEmprestimo);
            Controls.Add(cmbUsuarioEmprestimo);
            Controls.Add(lblDataEmprestimo);
            Controls.Add(lblLivroEmprestimo);
            Controls.Add(lblUsuarioEmprestimo);
            Name = "FormEmprestimos";
            Text = "FormEmprestimos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuarioEmprestimo;
        private Label lblLivroEmprestimo;
        private Label lblDataEmprestimo;
        private ComboBox cmbUsuarioEmprestimo;
        private ComboBox cmbLivroEmprestimo;
        private DateTimePicker dtpDataEmprestimo;
        private Button btnRegistrarEmprestimo;
        private Label label2;
        private Label label1;
    }
}