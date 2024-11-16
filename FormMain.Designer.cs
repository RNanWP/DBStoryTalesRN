namespace StoryTales_RN___Trabalho_Final
{
    partial class FormMain
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
            btnUsuarios = new Button();
            btnLivros = new Button();
            btnAutores = new Button();
            btnEmprestimos = new Button();
            label2 = new Label();
            label1 = new Label();
            btnConsulta = new Button();
            SuspendLayout();
            // 
            // btnUsuarios
            // 
            btnUsuarios.Font = new Font("Segoe UI", 15F);
            btnUsuarios.Location = new Point(12, 12);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(330, 152);
            btnUsuarios.TabIndex = 0;
            btnUsuarios.Text = "Gerenciar Usuários";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnLivros
            // 
            btnLivros.Font = new Font("Segoe UI", 15F);
            btnLivros.Location = new Point(406, 12);
            btnLivros.Name = "btnLivros";
            btnLivros.Size = new Size(316, 152);
            btnLivros.TabIndex = 1;
            btnLivros.Text = "Gerenciar Livros";
            btnLivros.UseVisualStyleBackColor = true;
            btnLivros.Click += btnLivros_Click;
            // 
            // btnAutores
            // 
            btnAutores.Font = new Font("Segoe UI", 15F);
            btnAutores.Location = new Point(12, 235);
            btnAutores.Name = "btnAutores";
            btnAutores.Size = new Size(330, 159);
            btnAutores.TabIndex = 2;
            btnAutores.Text = "Gerenciar Autores";
            btnAutores.UseVisualStyleBackColor = true;
            btnAutores.Click += btnAutores_Click;
            // 
            // btnEmprestimos
            // 
            btnEmprestimos.Font = new Font("Segoe UI", 15F);
            btnEmprestimos.Location = new Point(406, 235);
            btnEmprestimos.Name = "btnEmprestimos";
            btnEmprestimos.Size = new Size(316, 159);
            btnEmprestimos.TabIndex = 3;
            btnEmprestimos.Text = "Gerenciar Empréstimos";
            btnEmprestimos.UseVisualStyleBackColor = true;
            btnEmprestimos.Click += btnEmprestimos_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(320, 178);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 10;
            label2.Text = "StoryTales RN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(274, 198);
            label1.Name = "label1";
            label1.Size = new Size(192, 20);
            label1.TabIndex = 11;
            label1.Text = "Renan Santos - 2222200490";
            // 
            // btnConsulta
            // 
            btnConsulta.Font = new Font("Segoe UI", 15F);
            btnConsulta.Location = new Point(274, 422);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(198, 64);
            btnConsulta.TabIndex = 12;
            btnConsulta.Text = "Consultas";
            btnConsulta.UseVisualStyleBackColor = true;
            btnConsulta.Click += btnConsulta_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 498);
            Controls.Add(btnConsulta);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(btnEmprestimos);
            Controls.Add(btnAutores);
            Controls.Add(btnLivros);
            Controls.Add(btnUsuarios);
            Name = "FormMain";
            Text = "FormMain";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUsuarios;
        private Button btnLivros;
        private Button btnAutores;
        private Button btnEmprestimos;
        private Label label2;
        private Label label1;
        private Button btnConsulta;
    }
}
