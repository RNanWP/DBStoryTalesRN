namespace StoryTales_RN___Trabalho_Final
{
    partial class FormAutores
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
            lblNomeAutor = new Label();
            txtNomeAutor = new TextBox();
            btnConsultarAutor = new Button();
            btnExcluirAutor = new Button();
            btnAtualizarAutor = new Button();
            btnSalvarAutor = new Button();
            label2 = new Label();
            label1 = new Label();
            txtIdAutor = new TextBox();
            lblIdAutor = new Label();
            SuspendLayout();
            // 
            // lblNomeAutor
            // 
            lblNomeAutor.AutoSize = true;
            lblNomeAutor.Location = new Point(12, 70);
            lblNomeAutor.Name = "lblNomeAutor";
            lblNomeAutor.Size = new Size(116, 20);
            lblNomeAutor.TabIndex = 0;
            lblNomeAutor.Text = "Nome do Autor:";
            // 
            // txtNomeAutor
            // 
            txtNomeAutor.Location = new Point(134, 67);
            txtNomeAutor.Name = "txtNomeAutor";
            txtNomeAutor.Size = new Size(228, 27);
            txtNomeAutor.TabIndex = 1;
            // 
            // btnConsultarAutor
            // 
            btnConsultarAutor.Location = new Point(228, 281);
            btnConsultarAutor.Name = "btnConsultarAutor";
            btnConsultarAutor.Size = new Size(125, 46);
            btnConsultarAutor.TabIndex = 15;
            btnConsultarAutor.Text = "Consultar";
            btnConsultarAutor.UseVisualStyleBackColor = true;
            // 
            // btnExcluirAutor
            // 
            btnExcluirAutor.Location = new Point(60, 281);
            btnExcluirAutor.Name = "btnExcluirAutor";
            btnExcluirAutor.Size = new Size(125, 46);
            btnExcluirAutor.TabIndex = 14;
            btnExcluirAutor.Text = "Excluir";
            btnExcluirAutor.UseVisualStyleBackColor = true;
            // 
            // btnAtualizarAutor
            // 
            btnAtualizarAutor.Location = new Point(228, 212);
            btnAtualizarAutor.Name = "btnAtualizarAutor";
            btnAtualizarAutor.Size = new Size(125, 46);
            btnAtualizarAutor.TabIndex = 13;
            btnAtualizarAutor.Text = "Atualizar";
            btnAtualizarAutor.UseVisualStyleBackColor = true;
            // 
            // btnSalvarAutor
            // 
            btnSalvarAutor.Location = new Point(60, 212);
            btnSalvarAutor.Name = "btnSalvarAutor";
            btnSalvarAutor.Size = new Size(125, 46);
            btnSalvarAutor.TabIndex = 12;
            btnSalvarAutor.Text = "Salvar";
            btnSalvarAutor.UseVisualStyleBackColor = true;
            btnSalvarAutor.Click += btnSalvarAutor_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(148, 24);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 16;
            label2.Text = "StoryTales RN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(126, 350);
            label1.Name = "label1";
            label1.Size = new Size(192, 20);
            label1.TabIndex = 17;
            label1.Text = "Renan Santos - 2222200490";
            // 
            // txtIdAutor
            // 
            txtIdAutor.Location = new Point(134, 127);
            txtIdAutor.Name = "txtIdAutor";
            txtIdAutor.Size = new Size(132, 27);
            txtIdAutor.TabIndex = 19;
            // 
            // lblIdAutor
            // 
            lblIdAutor.AutoSize = true;
            lblIdAutor.Location = new Point(95, 130);
            lblIdAutor.Name = "lblIdAutor";
            lblIdAutor.Size = new Size(27, 20);
            lblIdAutor.TabIndex = 18;
            lblIdAutor.Text = "ID:";
            // 
            // FormAutores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 383);
            Controls.Add(txtIdAutor);
            Controls.Add(lblIdAutor);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(btnConsultarAutor);
            Controls.Add(btnExcluirAutor);
            Controls.Add(btnAtualizarAutor);
            Controls.Add(btnSalvarAutor);
            Controls.Add(txtNomeAutor);
            Controls.Add(lblNomeAutor);
            Name = "FormAutores";
            Text = "FormAutores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeAutor;
        private TextBox txtNomeAutor;
        private Button btnConsultarAutor;
        private Button btnExcluirAutor;
        private Button btnAtualizarAutor;
        private Button btnSalvarAutor;
        private Label label2;
        private Label label1;
        private TextBox txtIdAutor;
        private Label lblIdAutor;
    }
}