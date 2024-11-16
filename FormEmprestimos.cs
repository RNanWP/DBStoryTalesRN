using MySql.Data.MySqlClient;
using StoryTales_Rn___Trabalho_Final;
using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoryTales_RN___Trabalho_Final
{
    public partial class FormEmprestimos : Form
    {
        public FormEmprestimos()
        {
            InitializeComponent();
            this.Load += new EventHandler(FormEmprestimos_Load);
        }

        private void FormEmprestimos_Load(object sender, EventArgs e)
        {
            // Conectar ao banco e carregar os dados dos usuários e livros
            CarregarUsuarios();
            CarregarLivros();
        }

        private void CarregarUsuarios()
        {
            string connectionString = @"Server=localhost; Database=storytalesrn; Uid=root; Pwd=root;";
            string query = "SELECT Id, Nome FROM Usuario";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbUsuarioEmprestimo.DisplayMember = "Nome";  // Coluna que será exibida no ComboBox
                cmbUsuarioEmprestimo.ValueMember = "Id";  // Coluna que será utilizada como valor
                cmbUsuarioEmprestimo.DataSource = dt; // Bind para o ComboBox
            }
        }

        private void CarregarLivros()
        {
            string connectionString = @"Server=localhost; Database=storytalesrn; Uid=root; Pwd=root;";
            string query = "SELECT Id, Titulo FROM Livro";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbLivroEmprestimo.DisplayMember = "Titulo";  // Coluna que será exibida no ComboBox
                cmbLivroEmprestimo.ValueMember = "Id";  // Coluna que será utilizada como valor
                cmbLivroEmprestimo.DataSource = dt; // Bind para o ComboBox
            }
        }

        private void btnRegistrarEmprestimo_Click(object sender, EventArgs e)
        {
            // Verificar se os ComboBoxes possuem valor selecionado
            if (cmbUsuarioEmprestimo.SelectedValue == null || cmbLivroEmprestimo.SelectedValue == null)
            {
                MessageBox.Show("Por favor, selecione um usuário e um livro.");
                return;  // Interrompe o método se algum valor não for selecionado
            }

            int usuarioID = (int)cmbUsuarioEmprestimo.SelectedValue;
            int livroID = (int)cmbLivroEmprestimo.SelectedValue;
            DateTime dataEmprestimo = dtpDataEmprestimo.Value;

            string connectionString = @"Server=localhost; Database=storytalesrn; Uid=root; Pwd=root;";
            string query = "INSERT INTO Emprestimo (UsuarioId, LivroId, DataEmprestimo) VALUES (@UsuarioID, @LivroID, @DataEmprestimo)";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UsuarioID", usuarioID);
                cmd.Parameters.AddWithValue("@LivroID", livroID);
                cmd.Parameters.AddWithValue("@DataEmprestimo", dataEmprestimo);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Empréstimo registrado com sucesso!");
        }

        private void btnRegistrarDevolucao_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdEmprestimo.Text, out int emprestimoId))
            {
                MessageBox.Show("ID do Empréstimo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime dataDevolucao = dtpDataDevolucao.Value;
            string dataDevolucaoFormatada = dataDevolucao.ToString("yyyy-MM-dd");

            try
            {
                using (var db = new Database())
                {
                    if (db.OpenConnection())
                    {
                        string query = "UPDATE Emprestimo SET DataDevolucao = @dataDevolucao WHERE Id = @emprestimoId";
                        MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                        cmd.Parameters.AddWithValue("@emprestimoId", emprestimoId);
                        cmd.Parameters.AddWithValue("@dataDevolucao", dataDevolucaoFormatada);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Devolução registrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("ID do Empréstimo não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        db.CloseConnection();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar devolução: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
