namespace StoryTales_RN___Trabalho_Final
{
    partial class FormUsuarios
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
            lblNomeUsuario = new Label();
            lblEmailUsuario = new Label();
            txtNomeUsuario = new TextBox();
            txtEmailUsuario = new TextBox();
            btnSalvarUsuario = new Button();
            btnAtualizarUsuario = new Button();
            btnExcluirUsuario = new Button();
            btnConsultarUsuario = new Button();
            label1 = new Label();
            label2 = new Label();
            lblIdUsuario = new Label();
            txtIdUsuario = new TextBox();
            SuspendLayout();
            // 
            // lblNomeUsuario
            // 
            lblNomeUsuario.AutoSize = true;
            lblNomeUsuario.Location = new Point(12, 90);
            lblNomeUsuario.Name = "lblNomeUsuario";
            lblNomeUsuario.Size = new Size(129, 20);
            lblNomeUsuario.TabIndex = 0;
            lblNomeUsuario.Text = "Nome do Usuário:";
            // 
            // lblEmailUsuario
            // 
            lblEmailUsuario.AutoSize = true;
            lblEmailUsuario.Location = new Point(16, 190);
            lblEmailUsuario.Name = "lblEmailUsuario";
            lblEmailUsuario.Size = new Size(125, 20);
            lblEmailUsuario.TabIndex = 1;
            lblEmailUsuario.Text = "Email do Usuário:";
            // 
            // txtNomeUsuario
            // 
            txtNomeUsuario.Location = new Point(147, 87);
            txtNomeUsuario.Name = "txtNomeUsuario";
            txtNomeUsuario.Size = new Size(352, 27);
            txtNomeUsuario.TabIndex = 2;
            // 
            // txtEmailUsuario
            // 
            txtEmailUsuario.Location = new Point(147, 187);
            txtEmailUsuario.Name = "txtEmailUsuario";
            txtEmailUsuario.Size = new Size(352, 27);
            txtEmailUsuario.TabIndex = 3;
            // 
            // btnSalvarUsuario
            // 
            btnSalvarUsuario.Location = new Point(523, 55);
            btnSalvarUsuario.Name = "btnSalvarUsuario";
            btnSalvarUsuario.Size = new Size(125, 46);
            btnSalvarUsuario.TabIndex = 4;
            btnSalvarUsuario.Text = "Salvar";
            btnSalvarUsuario.UseVisualStyleBackColor = true;
            btnSalvarUsuario.Click += btnSalvarUsuario_Click;
            // 
            // btnAtualizarUsuario
            // 
            btnAtualizarUsuario.Location = new Point(523, 107);
            btnAtualizarUsuario.Name = "btnAtualizarUsuario";
            btnAtualizarUsuario.Size = new Size(125, 46);
            btnAtualizarUsuario.TabIndex = 5;
            btnAtualizarUsuario.Text = "Atualizar";
            btnAtualizarUsuario.UseVisualStyleBackColor = true;
            btnAtualizarUsuario.Click += btnAtualizarUsuario_Click;
            // 
            // btnExcluirUsuario
            // 
            btnExcluirUsuario.Location = new Point(521, 159);
            btnExcluirUsuario.Name = "btnExcluirUsuario";
            btnExcluirUsuario.Size = new Size(125, 46);
            btnExcluirUsuario.TabIndex = 6;
            btnExcluirUsuario.Text = "Excluir";
            btnExcluirUsuario.UseVisualStyleBackColor = true;
            btnExcluirUsuario.Click += btnExcluirUsuario_Click;
            // 
            // btnConsultarUsuario
            // 
            btnConsultarUsuario.Location = new Point(523, 211);
            btnConsultarUsuario.Name = "btnConsultarUsuario";
            btnConsultarUsuario.Size = new Size(125, 46);
            btnConsultarUsuario.TabIndex = 7;
            btnConsultarUsuario.Text = "Consultar";
            btnConsultarUsuario.UseVisualStyleBackColor = true;
            btnConsultarUsuario.Click += btnConsultarUsuario_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(221, 278);
            label1.Name = "label1";
            label1.Size = new Size(192, 20);
            label1.TabIndex = 8;
            label1.Text = "Renan Santos - 2222200490";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(251, 25);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 9;
            label2.Text = "StoryTales RN";
            // 
            // lblIdUsuario
            // 
            lblIdUsuario.AutoSize = true;
            lblIdUsuario.Location = new Point(108, 143);
            lblIdUsuario.Name = "lblIdUsuario";
            lblIdUsuario.Size = new Size(27, 20);
            lblIdUsuario.TabIndex = 10;
            lblIdUsuario.Text = "ID:";
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(147, 140);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(132, 27);
            txtIdUsuario.TabIndex = 11;
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 307);
            Controls.Add(txtIdUsuario);
            Controls.Add(lblIdUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnConsultarUsuario);
            Controls.Add(btnExcluirUsuario);
            Controls.Add(btnAtualizarUsuario);
            Controls.Add(btnSalvarUsuario);
            Controls.Add(txtEmailUsuario);
            Controls.Add(txtNomeUsuario);
            Controls.Add(lblEmailUsuario);
            Controls.Add(lblNomeUsuario);
            Name = "FormUsuarios";
            Text = "FormUsuarios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeUsuario;
        private Label lblEmailUsuario;
        private TextBox txtNomeUsuario;
        private TextBox txtEmailUsuario;
        private Button btnSalvarUsuario;
        private Button btnAtualizarUsuario;
        private Button btnExcluirUsuario;
        private Button btnConsultarUsuario;
        private Label label1;
        private Label label2;
        private Label lblIdUsuario;
        private TextBox txtIdUsuario;
    }
}