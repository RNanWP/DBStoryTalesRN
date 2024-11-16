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
            StoryTales = new Label();
            Matricula = new Label();
            btnRegistrarDevolucao = new Button();
            dtpDataDevolucao = new DateTimePicker();
            lblDataDevolucao = new Label();
            txtIdEmprestimo = new TextBox();
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
            cmbLivroEmprestimo.Location = new Point(99, 138);
            cmbLivroEmprestimo.Name = "cmbLivroEmprestimo";
            cmbLivroEmprestimo.Size = new Size(234, 28);
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
            btnRegistrarEmprestimo.Location = new Point(60, 337);
            btnRegistrarEmprestimo.Name = "btnRegistrarEmprestimo";
            btnRegistrarEmprestimo.Size = new Size(176, 52);
            btnRegistrarEmprestimo.TabIndex = 6;
            btnRegistrarEmprestimo.Text = "Registrar Empréstimo";
            btnRegistrarEmprestimo.UseVisualStyleBackColor = true;
            btnRegistrarEmprestimo.Click += btnRegistrarEmprestimo_Click;
            // 
            // StoryTales
            // 
            StoryTales.AutoSize = true;
            StoryTales.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            StoryTales.Location = new Point(209, 24);
            StoryTales.Name = "StoryTales";
            StoryTales.Size = new Size(108, 20);
            StoryTales.TabIndex = 15;
            StoryTales.Text = "StoryTales RN";
            // 
            // Matricula
            // 
            Matricula.AutoSize = true;
            Matricula.Font = new Font("Segoe UI", 9F);
            Matricula.Location = new Point(176, 432);
            Matricula.Name = "Matricula";
            Matricula.Size = new Size(192, 20);
            Matricula.TabIndex = 14;
            Matricula.Text = "Renan Santos - 2222200490";
            // 
            // btnRegistrarDevolucao
            // 
            btnRegistrarDevolucao.Location = new Point(305, 337);
            btnRegistrarDevolucao.Name = "btnRegistrarDevolucao";
            btnRegistrarDevolucao.Size = new Size(176, 52);
            btnRegistrarDevolucao.TabIndex = 16;
            btnRegistrarDevolucao.Text = "Registrar Devolução";
            btnRegistrarDevolucao.UseVisualStyleBackColor = true;
            btnRegistrarDevolucao.Click += btnRegistrarDevolucao_Click;
            // 
            // dtpDataDevolucao
            // 
            dtpDataDevolucao.Location = new Point(186, 262);
            dtpDataDevolucao.Name = "dtpDataDevolucao";
            dtpDataDevolucao.Size = new Size(333, 27);
            dtpDataDevolucao.TabIndex = 23;
            // 
            // lblDataDevolucao
            // 
            lblDataDevolucao.AutoSize = true;
            lblDataDevolucao.Location = new Point(42, 267);
            lblDataDevolucao.Name = "lblDataDevolucao";
            lblDataDevolucao.Size = new Size(138, 20);
            lblDataDevolucao.TabIndex = 22;
            lblDataDevolucao.Text = "Data de devolução:";
            // 
            // txtIdEmprestimo
            // 
            txtIdEmprestimo.Location = new Point(373, 68);
            txtIdEmprestimo.Name = "txtIdEmprestimo";
            txtIdEmprestimo.Size = new Size(125, 27);
            txtIdEmprestimo.TabIndex = 24;
            // 
            // FormEmprestimos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 469);
            Controls.Add(txtIdEmprestimo);
            Controls.Add(dtpDataDevolucao);
            Controls.Add(lblDataDevolucao);
            Controls.Add(btnRegistrarDevolucao);
            Controls.Add(StoryTales);
            Controls.Add(Matricula);
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
        private Label StoryTales;
        private Label Matricula;
        private Button btnRegistrarDevolucao;
        private DateTimePicker dtpDataDevolucao;
        private Label lblDataDevolucao;
        private TextBox txtIdEmprestimo;
    }
}