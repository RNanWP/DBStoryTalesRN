namespace StoryTales_RN___Trabalho_Final
{
    partial class FormConsultas
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
            gbConsultas = new GroupBox();
            rbLivrosEmprestados = new RadioButton();
            rbLivrosDisponiveis = new RadioButton();
            btnConsultar = new Button();
            label2 = new Label();
            label1 = new Label();
            gbConsultas.SuspendLayout();
            SuspendLayout();
            // 
            // gbConsultas
            // 
            gbConsultas.Controls.Add(rbLivrosEmprestados);
            gbConsultas.Controls.Add(rbLivrosDisponiveis);
            gbConsultas.Location = new Point(12, 88);
            gbConsultas.Name = "gbConsultas";
            gbConsultas.Size = new Size(250, 125);
            gbConsultas.TabIndex = 0;
            gbConsultas.TabStop = false;
            gbConsultas.Text = "Consulta de livros";
            // 
            // rbLivrosEmprestados
            // 
            rbLivrosEmprestados.AutoSize = true;
            rbLivrosEmprestados.Location = new Point(6, 95);
            rbLivrosEmprestados.Name = "rbLivrosEmprestados";
            rbLivrosEmprestados.Size = new Size(158, 24);
            rbLivrosEmprestados.TabIndex = 2;
            rbLivrosEmprestados.TabStop = true;
            rbLivrosEmprestados.Text = "Livros Emprestados";
            rbLivrosEmprestados.UseVisualStyleBackColor = true;
            // 
            // rbLivrosDisponiveis
            // 
            rbLivrosDisponiveis.AutoSize = true;
            rbLivrosDisponiveis.Location = new Point(6, 48);
            rbLivrosDisponiveis.Name = "rbLivrosDisponiveis";
            rbLivrosDisponiveis.Size = new Size(148, 24);
            rbLivrosDisponiveis.TabIndex = 1;
            rbLivrosDisponiveis.TabStop = true;
            rbLivrosDisponiveis.Text = "Livros Disponíveis";
            rbLivrosDisponiveis.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(68, 255);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(145, 57);
            btnConsultar.TabIndex = 1;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(81, 45);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 26;
            label2.Text = "StoryTales RN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(46, 350);
            label1.Name = "label1";
            label1.Size = new Size(192, 20);
            label1.TabIndex = 25;
            label1.Text = "Renan Santos - 2222200490";
            // 
            // FormConsultas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 379);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnConsultar);
            Controls.Add(gbConsultas);
            Name = "FormConsultas";
            Text = "FormConsultas";
            gbConsultas.ResumeLayout(false);
            gbConsultas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbConsultas;
        private RadioButton rbLivrosEmprestados;
        private RadioButton rbLivrosDisponiveis;
        private Button btnConsultar;
        private Label label2;
        private Label label1;
    }
}