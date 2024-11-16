namespace StoryTales_RN___Trabalho_Final
{
    partial class FormDevolucoes
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
            label2 = new Label();
            label1 = new Label();
            btnRegistrarDevolucao = new Button();
            dtpDataDevolucao = new DateTimePicker();
            cmbLivroDevolucao = new ComboBox();
            cmbUsuarioDevolucao = new ComboBox();
            lblDataDevolucao = new Label();
            lblLivroDevolucao = new Label();
            lblUsuarioDevolucao = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(209, 42);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 24;
            label2.Text = "StoryTales RN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(154, 411);
            label1.Name = "label1";
            label1.Size = new Size(192, 20);
            label1.TabIndex = 23;
            label1.Text = "Renan Santos - 2222200490";
            // 
            // btnRegistrarDevolucao
            // 
            btnRegistrarDevolucao.Location = new Point(170, 294);
            btnRegistrarDevolucao.Name = "btnRegistrarDevolucao";
            btnRegistrarDevolucao.Size = new Size(176, 52);
            btnRegistrarDevolucao.TabIndex = 22;
            btnRegistrarDevolucao.Text = "Registrar Devolução";
            btnRegistrarDevolucao.UseVisualStyleBackColor = true;
            // 
            // dtpDataDevolucao
            // 
            dtpDataDevolucao.Location = new Point(159, 235);
            dtpDataDevolucao.Name = "dtpDataDevolucao";
            dtpDataDevolucao.Size = new Size(333, 27);
            dtpDataDevolucao.TabIndex = 21;
            // 
            // cmbLivroDevolucao
            // 
            cmbLivroDevolucao.FormattingEnabled = true;
            cmbLivroDevolucao.Location = new Point(83, 160);
            cmbLivroDevolucao.Name = "cmbLivroDevolucao";
            cmbLivroDevolucao.Size = new Size(234, 28);
            cmbLivroDevolucao.TabIndex = 20;
            // 
            // cmbUsuarioDevolucao
            // 
            cmbUsuarioDevolucao.FormattingEnabled = true;
            cmbUsuarioDevolucao.Location = new Point(83, 107);
            cmbUsuarioDevolucao.Name = "cmbUsuarioDevolucao";
            cmbUsuarioDevolucao.Size = new Size(234, 28);
            cmbUsuarioDevolucao.TabIndex = 19;
            // 
            // lblDataDevolucao
            // 
            lblDataDevolucao.AutoSize = true;
            lblDataDevolucao.Location = new Point(15, 240);
            lblDataDevolucao.Name = "lblDataDevolucao";
            lblDataDevolucao.Size = new Size(138, 20);
            lblDataDevolucao.TabIndex = 18;
            lblDataDevolucao.Text = "Data de devolução:";
            // 
            // lblLivroDevolucao
            // 
            lblLivroDevolucao.AutoSize = true;
            lblLivroDevolucao.Location = new Point(15, 163);
            lblLivroDevolucao.Name = "lblLivroDevolucao";
            lblLivroDevolucao.Size = new Size(44, 20);
            lblLivroDevolucao.TabIndex = 17;
            lblLivroDevolucao.Text = "Livro:";
            // 
            // lblUsuarioDevolucao
            // 
            lblUsuarioDevolucao.AutoSize = true;
            lblUsuarioDevolucao.Location = new Point(15, 110);
            lblUsuarioDevolucao.Name = "lblUsuarioDevolucao";
            lblUsuarioDevolucao.Size = new Size(62, 20);
            lblUsuarioDevolucao.TabIndex = 16;
            lblUsuarioDevolucao.Text = "Usuário:";
            // 
            // FormDevolucoes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRegistrarDevolucao);
            Controls.Add(dtpDataDevolucao);
            Controls.Add(cmbLivroDevolucao);
            Controls.Add(cmbUsuarioDevolucao);
            Controls.Add(lblDataDevolucao);
            Controls.Add(lblLivroDevolucao);
            Controls.Add(lblUsuarioDevolucao);
            Name = "FormDevolucoes";
            Text = "FormDevolucoes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button btnRegistrarDevolucao;
        private DateTimePicker dtpDataDevolucao;
        private ComboBox cmbLivroDevolucao;
        private ComboBox cmbUsuarioDevolucao;
        private Label lblDataDevolucao;
        private Label lblLivroDevolucao;
        private Label lblUsuarioDevolucao;
    }
}