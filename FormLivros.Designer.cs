namespace StoryTales_RN___Trabalho_Final
{
    partial class FormLivros
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
            lblTituloLivro = new Label();
            lblAutorLivro = new Label();
            txtTituloLivro = new TextBox();
            comboBox1 = new ComboBox();
            btnConsultarLivro = new Button();
            btnExcluirLivro = new Button();
            btnAtualizarLivro = new Button();
            btnSalvarLivro = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblTituloLivro
            // 
            lblTituloLivro.AutoSize = true;
            lblTituloLivro.Location = new Point(11, 77);
            lblTituloLivro.Name = "lblTituloLivro";
            lblTituloLivro.Size = new Size(108, 20);
            lblTituloLivro.TabIndex = 0;
            lblTituloLivro.Text = "Título do Livro:";
            // 
            // lblAutorLivro
            // 
            lblAutorLivro.AutoSize = true;
            lblAutorLivro.Location = new Point(12, 137);
            lblAutorLivro.Name = "lblAutorLivro";
            lblAutorLivro.Size = new Size(107, 20);
            lblAutorLivro.TabIndex = 1;
            lblAutorLivro.Text = "Autor do Livro:";
            // 
            // txtTituloLivro
            // 
            txtTituloLivro.Location = new Point(125, 74);
            txtTituloLivro.Name = "txtTituloLivro";
            txtTituloLivro.Size = new Size(230, 27);
            txtTituloLivro.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(125, 134);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(230, 28);
            comboBox1.TabIndex = 3;
            // 
            // btnConsultarLivro
            // 
            btnConsultarLivro.Location = new Point(230, 267);
            btnConsultarLivro.Name = "btnConsultarLivro";
            btnConsultarLivro.Size = new Size(125, 46);
            btnConsultarLivro.TabIndex = 11;
            btnConsultarLivro.Text = "Consultar";
            btnConsultarLivro.UseVisualStyleBackColor = true;
            // 
            // btnExcluirLivro
            // 
            btnExcluirLivro.Location = new Point(62, 267);
            btnExcluirLivro.Name = "btnExcluirLivro";
            btnExcluirLivro.Size = new Size(125, 46);
            btnExcluirLivro.TabIndex = 10;
            btnExcluirLivro.Text = "Excluir";
            btnExcluirLivro.UseVisualStyleBackColor = true;
            // 
            // btnAtualizarLivro
            // 
            btnAtualizarLivro.Location = new Point(231, 198);
            btnAtualizarLivro.Name = "btnAtualizarLivro";
            btnAtualizarLivro.Size = new Size(125, 46);
            btnAtualizarLivro.TabIndex = 9;
            btnAtualizarLivro.Text = "Atualizar";
            btnAtualizarLivro.UseVisualStyleBackColor = true;
            // 
            // btnSalvarLivro
            // 
            btnSalvarLivro.Location = new Point(62, 198);
            btnSalvarLivro.Name = "btnSalvarLivro";
            btnSalvarLivro.Size = new Size(125, 46);
            btnSalvarLivro.TabIndex = 8;
            btnSalvarLivro.Text = "Salvar";
            btnSalvarLivro.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(103, 327);
            label1.Name = "label1";
            label1.Size = new Size(192, 20);
            label1.TabIndex = 12;
            label1.Text = "Renan Santos - 2222200490";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(143, 19);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 13;
            label2.Text = "StoryTales RN";
            // 
            // FormLivros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 356);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnConsultarLivro);
            Controls.Add(btnExcluirLivro);
            Controls.Add(btnAtualizarLivro);
            Controls.Add(btnSalvarLivro);
            Controls.Add(comboBox1);
            Controls.Add(txtTituloLivro);
            Controls.Add(lblAutorLivro);
            Controls.Add(lblTituloLivro);
            Name = "FormLivros";
            Text = "FormLivros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloLivro;
        private Label lblAutorLivro;
        private TextBox txtTituloLivro;
        private ComboBox comboBox1;
        private Button btnConsultarLivro;
        private Button btnExcluirLivro;
        private Button btnAtualizarLivro;
        private Button btnSalvarLivro;
        private Label label1;
        private Label label2;
    }
}