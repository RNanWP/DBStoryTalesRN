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
            dtpDataDevolucao = new DateTimePicker();
            btnRegistrarEmprestimo = new Button();
            StoryTales = new Label();
            Matricula = new Label();
            btnRegistrarDevolucao = new Button();
            txtIdEmprestimo = new TextBox();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
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
            lblDataEmprestimo.Location = new Point(31, 311);
            lblDataEmprestimo.Name = "lblDataEmprestimo";
            lblDataEmprestimo.Size = new Size(135, 20);
            lblDataEmprestimo.TabIndex = 2;
            lblDataEmprestimo.Text = "Data de devolução";
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
            // dtpDataDevolucao
            // 
            dtpDataDevolucao.Location = new Point(186, 306);
            dtpDataDevolucao.Name = "dtpDataDevolucao";
            dtpDataDevolucao.Size = new Size(333, 27);
            dtpDataDevolucao.TabIndex = 5;
            // 
            // btnRegistrarEmprestimo
            // 
            btnRegistrarEmprestimo.Location = new Point(59, 356);
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
            Matricula.Location = new Point(175, 451);
            Matricula.Name = "Matricula";
            Matricula.Size = new Size(192, 20);
            Matricula.TabIndex = 14;
            Matricula.Text = "Renan Santos - 2222200490";
            // 
            // btnRegistrarDevolucao
            // 
            btnRegistrarDevolucao.Location = new Point(304, 356);
            btnRegistrarDevolucao.Name = "btnRegistrarDevolucao";
            btnRegistrarDevolucao.Size = new Size(176, 52);
            btnRegistrarDevolucao.TabIndex = 16;
            btnRegistrarDevolucao.Text = "Registrar Devolução";
            btnRegistrarDevolucao.UseVisualStyleBackColor = true;
            btnRegistrarDevolucao.Click += btnRegistrarDevolucao_Click;
            // 
            // txtIdEmprestimo
            // 
            txtIdEmprestimo.Location = new Point(134, 186);
            txtIdEmprestimo.Name = "txtIdEmprestimo";
            txtIdEmprestimo.Size = new Size(199, 27);
            txtIdEmprestimo.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 189);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 25;
            label1.Text = "ID devolução:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(186, 253);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(333, 27);
            dateTimePicker1.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 258);
            label2.Name = "label2";
            label2.Size = new Size(149, 20);
            label2.TabIndex = 26;
            label2.Text = "Data de Empréstimo:";
            // 
            // FormEmprestimos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 488);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtIdEmprestimo);
            Controls.Add(btnRegistrarDevolucao);
            Controls.Add(StoryTales);
            Controls.Add(Matricula);
            Controls.Add(btnRegistrarEmprestimo);
            Controls.Add(dtpDataDevolucao);
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
        private DateTimePicker dtpDataDevolucao;
        private Button btnRegistrarEmprestimo;
        private Label StoryTales;
        private Label Matricula;
        private Button btnRegistrarDevolucao;
        private TextBox txtIdEmprestimo;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
    }
}